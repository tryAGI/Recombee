dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl -o openapi.yaml https://docs.recombee.com/openapi.yaml

# Fix invalid placeholder server URLs and add proper base URL
# Add security scheme (bearer) for constructor generation
# The actual auth is HMAC-SHA1 via query params, handled by PrepareRequest hook
python3 -c "
import yaml, json, sys

with open('openapi.yaml', 'r') as f:
    spec = yaml.safe_load(f)

# Fix servers - replace placeholder with actual Recombee API URL
spec['servers'] = [
    {'url': 'https://rapi.recombee.com', 'description': 'Recombee API (default region)'}
]

# Add security scheme for bearer auth (used for constructor generation)
if 'components' not in spec:
    spec['components'] = {}
if 'securitySchemes' not in spec['components']:
    spec['components']['securitySchemes'] = {}
spec['components']['securitySchemes']['BearerAuth'] = {
    'type': 'http',
    'scheme': 'bearer'
}

# Add top-level security
spec['security'] = [{'BearerAuth': []}]

with open('openapi.yaml', 'w') as f:
    yaml.dump(spec, f, default_flow_style=False, allow_unicode=True, sort_keys=False, width=200)
"

autosdk generate openapi.yaml \
  --namespace Recombee \
  --clientClassName RecombeeClient \
  --targetFramework net10.0 \
  --output Generated \
  --security-scheme Http:Header:Bearer \
  --exclude-deprecated-operations

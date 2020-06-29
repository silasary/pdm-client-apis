# PDM API client

This file contains the configuration for generating My API from the OpenAPI specification.

> see https://aka.ms/autorest

``` yaml
input-file: https://pennydreadfulmagic.com/api/swagger.json
csharp:
  namespace: PennyDreadfulMagic
  output-folder: csharp/src

directive:
  - from: code-model-v1
    where: $.baseUrl
    set: https://pennydreadfulmagic.com/api
```

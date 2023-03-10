---
title: Inventory API v2.10
language_tabs:
  - shell: Shell
  - javascript: JavaScript
language_clients:
  - shell: ""
  - javascript: ""
toc_footers: []
includes: []
search: false
highlight_theme: darkula
headingLevel: 2

---

<!-- Generator: Widdershins v4.0.1 -->

<h1 id="inventory-api">Inventory API v2.10</h1>

> Scroll down for code samples, example requests and responses. Select a language for code samples from the tabs above or the mobile navigation menu.

An API to perform Inventory operations

<h1 id="inventory-api-products">Products</h1>

## get__api_Products

> Code samples

```shell
# You can also use wget
curl -X GET /api/Products \
  -H 'Accept: text/plain'

```

```javascript

const headers = {
  'Accept':'text/plain'
};

fetch('/api/Products',
{
  method: 'GET',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

`GET /api/Products`

<h3 id="get__api_products-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|inStock|query|boolean|false|none|
|skip|query|integer(int32)|false|none|
|take|query|integer(int32)|false|none|

> Example responses

> 200 Response

```
[{"productId":0,"name":"string","category":"string","color":"string","unitPrice":0,"availableQuantity":0,"description":"string"}]
```

```json
[
  {
    "productId": 0,
    "name": "string",
    "category": "string",
    "color": "string",
    "unitPrice": 0,
    "availableQuantity": 0,
    "description": "string"
  }
]
```

<h3 id="get__api_products-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|Success|Inline|

<h3 id="get__api_products-responseschema">Response Schema</h3>

Status Code **200**

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|*anonymous*|[[Products](#schemaproducts)]|false|none|none|
|» productId|integer(int32)|true|none|none|
|» name|string|true|none|none|
|» category|string¦null|false|none|none|
|» color|string(string)¦null|false|none|none|
|» unitPrice|number(currency)|false|none|none|
|» availableQuantity|integer(int32)|false|none|none|
|» description|string¦null|false|none|none|

<aside class="success">
This operation does not require authentication
</aside>

## post__api_Products

> Code samples

```shell
# You can also use wget
curl -X POST /api/Products \
  -H 'Content-Type: application/json' \
  -H 'Accept: text/plain'

```

```javascript
const inputBody = '{
  "productId": 0,
  "name": "string",
  "category": "string",
  "color": "string",
  "unitPrice": 0,
  "availableQuantity": 0,
  "description": "string"
}';
const headers = {
  'Content-Type':'application/json',
  'Accept':'text/plain'
};

fetch('/api/Products',
{
  method: 'POST',
  body: inputBody,
  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

`POST /api/Products`

> Body parameter

```json
{
  "productId": 0,
  "name": "string",
  "category": "string",
  "color": "string",
  "unitPrice": 0,
  "availableQuantity": 0,
  "description": "string"
}
```

<h3 id="post__api_products-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|body|body|[Products](#schemaproducts)|false|none|

> Example responses

> 200 Response

```
{"productId":0,"name":"string","category":"string","color":"string","unitPrice":0,"availableQuantity":0,"description":"string"}
```

```json
{
  "productId": 0,
  "name": "string",
  "category": "string",
  "color": "string",
  "unitPrice": 0,
  "availableQuantity": 0,
  "description": "string"
}
```

<h3 id="post__api_products-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|Success|[Products](#schemaproducts)|

<aside class="success">
This operation does not require authentication
</aside>

## delete__api_Products_{id}

> Code samples

```shell
# You can also use wget
curl -X DELETE /api/Products/{id} \
  -H 'Accept: text/plain'

```

```javascript

const headers = {
  'Accept':'text/plain'
};

fetch('/api/Products/{id}',
{
  method: 'DELETE',

  headers: headers
})
.then(function(res) {
    return res.json();
}).then(function(body) {
    console.log(body);
});

```

`DELETE /api/Products/{id}`

<h3 id="delete__api_products_{id}-parameters">Parameters</h3>

|Name|In|Type|Required|Description|
|---|---|---|---|---|
|id|path|integer(int32)|true|none|

> Example responses

> 200 Response

```
{"productId":0,"name":"string","category":"string","color":"string","unitPrice":0,"availableQuantity":0,"description":"string"}
```

```json
{
  "productId": 0,
  "name": "string",
  "category": "string",
  "color": "string",
  "unitPrice": 0,
  "availableQuantity": 0,
  "description": "string"
}
```

<h3 id="delete__api_products_{id}-responses">Responses</h3>

|Status|Meaning|Description|Schema|
|---|---|---|---|
|200|[OK](https://tools.ietf.org/html/rfc7231#section-6.3.1)|Success|[Products](#schemaproducts)|

<aside class="success">
This operation does not require authentication
</aside>

# Schemas

<h2 id="tocS_Products">Products</h2>
<!-- backwards compatibility -->
<a id="schemaproducts"></a>
<a id="schema_Products"></a>
<a id="tocSproducts"></a>
<a id="tocsproducts"></a>

```json
{
  "productId": 0,
  "name": "string",
  "category": "string",
  "color": "string",
  "unitPrice": 0,
  "availableQuantity": 0,
  "description": "string"
}

```

### Properties

|Name|Type|Required|Restrictions|Description|
|---|---|---|---|---|
|productId|integer(int32)|true|none|none|
|name|string|true|none|none|
|category|string¦null|false|none|none|
|color|string(string)¦null|false|none|none|
|unitPrice|number(currency)|false|none|none|
|availableQuantity|integer(int32)|false|none|none|
|description|string¦null|false|none|none|


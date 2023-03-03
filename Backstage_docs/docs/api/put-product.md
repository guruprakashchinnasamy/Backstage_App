
### PUT /products {id}

This `PUT /products {id}` API used to update products by product id.

Request-url: http://localhost:3000/api/Products/1

#### Header

| Key             | Value                                                                |
| --------------| ----- |
| Authorization | {API Key} |
| Content-Type | application/json |

#### Request body:
    {
    "productId": 1,
    "name": "string",
    "category": "string",
    "color": "string",
    "unitPrice": 0,
    "availableQuantity": 0
    }

#### Response Code: 200
#### Response body:

    {
     No response body
    }


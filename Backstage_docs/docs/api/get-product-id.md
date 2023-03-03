
### GET /products {id}

This `GET /products {id}` API used to get specific the products by passing product id from inventory database.

Request-url: http://localhost:3000/api/Products/1

#### Header

| Key             | Value |
| --------------| ----- |
| Authorization | {API Key} |
| Content-Type | application/json |

#### Response Code: 200
#### Response body:

    {
      "productId": 0,
      "name": "string",
      "category": "string",
      "color": "string",
      "unitPrice": 0,
      "availableQuantity": 0
    }



### POST /products

This `POST /products` API used to insert products to inventory database.

Request-url: http://localhost:3000/api/Products

#### Header

| Key             | Value                                                                |
| --------------| ----- |
| Authorization | {API Key} |
| Content-Type | application/json |

#### Request body:
    {
    "productId": 0,
    "name": "string",
    "category": "string",
    "color": "string",
    "unitPrice": 0,
    "availableQuantity": 0
    }

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


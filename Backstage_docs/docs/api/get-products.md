
### GET /products

This `GET /products` API used to get all the products from inventory database.

Request-url: http://localhost:3000/api/Products?inStock=true&skip=1&take=1

#### Header

| Key             | Value                                                                |
| --------------| ----- |
| Authorization | {API Key} |
| Content-Type | application/json |

#### Response Code: 200
#### Response body:

    [
        {
            "productId": 0,
            "name": "string",
            "category": "string",
            "color": "string",
            "unitPrice": 0,
            "availableQuantity": 0
        }
    ]


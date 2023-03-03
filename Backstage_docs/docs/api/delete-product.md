
### DELETE /products {id}

This `DELETE /products {id}` API used to delete specific the products by passing product id from inventory database.

Request-url: https://localhost:7175/api/Products/1

#### Header

| Key             | Value |
| --------------| ----- |
| Authorization | {{API Key}} |
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


--- 

title: Inventory API 

language_tabs: 
   - shell 

toc_footers: 
   - <a href='#'>Sign Up for a Developer Key</a> 
   - <a href='https://github.com/lavkumarv'>Documentation Powered by lav</a> 

includes: 
   - errors 

search: true 

--- 

# Introduction 

An API to perform Inventory operations 

**Version:** 2.10 

# /API/PRODUCTS
## ***GET*** 

### HTTP Request 
`***GET*** /api/Products` 

**Parameters**

| Name | Located in | Description | Required | Type |
| ---- | ---------- | ----------- | -------- | ---- |
| inStock | query |  | No |  |
| skip | query |  | No |  |
| take | query |  | No |  |

**Responses**

| Code | Description |
| ---- | ----------- |
| 200 | Success |

## ***POST*** 

### HTTP Request 
`***POST*** /api/Products` 

**Parameters**

| Name | Located in | Description | Required | Type |
| ---- | ---------- | ----------- | -------- | ---- |
| Token | query |  | No |  |

**Responses**

| Code | Description |
| ---- | ----------- |
| 200 | Success |

# /API/PRODUCTS/{ID}
## ***DELETE*** 

### HTTP Request 
`***DELETE*** /api/Products/{id}` 

**Parameters**

| Name | Located in | Description | Required | Type |
| ---- | ---------- | ----------- | -------- | ---- |
| id | path |  | Yes |  |

**Responses**

| Code | Description |
| ---- | ----------- |
| 200 | Success |

<!-- Converted with the swagger-to-slate https://github.com/lavkumarv/swagger-to-slate -->

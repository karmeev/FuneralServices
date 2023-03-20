# Domain Models

## Order

```csharp
class Order
{
    Order Create();
    void AddOrder(Order order);
    void UpdateOrder(Order order);
}
```

```json
{
    "id": "000000-00000-000000-0000000-00000000000",
    "userId": "000000-00000-000000-0000000-00000000000",
    "orderId": "000000-00000-000000-0000000-00000000000",
    "otherInformation": "000000-00000-000000-0000000-00000000000",
    "storageId": "000000-00000-000000-0000000-00000000000",
    "orderPrice": 0,
    "prepayment": 0,
    "reminder": 0,
    "sellerProcent": 0,
    "createdDateTime": "2023-01-01T00:00:00.0000000Z",
    "updatedDateTime": "2023-01-01T00:00:00.0000000Z",
    hostId: "000000-00000-000000-0000000-00000000000"
}
```
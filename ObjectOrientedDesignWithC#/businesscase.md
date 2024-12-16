


# Identifying the classes and their functionalities


* Product class data

Product class functtionalites

“Use” product
Add new product to inventory
Alert if low on stock
Display the details of a product (short & long)
Increase stock when order arrives


* Order class data
Order class functtionalites
Show details of order and order lines





```mermaid

classDiagram
    class Product
        Product : +Description
        Product : +AmountInStock
        Product : +Id
        Product : +IsBelowStockThreshold
        Product : +Name
        Product : +Price
        Product : +UnitType

        Product : +CreateSimpleProductRepresentation()
        Product : +DecreaseStock()
        Product : +Log()
        Product : +DisplayDetailsFull()
        Product : +IncreaseStock()
        Product : +DisplayDetailsShort()
        Product : +Product()
        Product : +UseProduct()

    class Price
        Price : +Currency
        Price : +ItemPrice

        Price : +Tostring()

    class Currency
        <<Enum>> Currency
            Currency : Dollar
            Currency : Euro
            Currency : Pound

    class UnitType
       <<Enum>> UnitType
            UnitType : peritem
            UnitType : PerBox
            UnitType : PerKg

    Product ..> UnitType
    Price ..> Currency

    Price ..* Product

    class Order
        Order: Fulfiled
        Order : Id
        Order : OrderFulilment
        Order : OrderItems

        Order : Order()
        Order : ShowOrderDetected()

    class OrderItem
        OrderItem : AmountOrdered
        OrderItem : Id
        OrderItem : ProductId
        OrderItem : ProductName

        OrderItem : ToString()

    Order ..* OrderItem
```



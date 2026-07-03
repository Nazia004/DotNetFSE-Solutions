# Strategy Pattern

## Objective

Select a payment method at runtime without changing the client code.

## Pattern Type

Behavioral Design Pattern

## Components

- IPaymentStrategy
- CreditCardPayment
- UPIPayment
- PayPalPayment
- PaymentContext

## How It Works

The PaymentContext delegates the payment operation to the selected strategy. Different payment methods can be switched at runtime without modifying the client.

## Output

```text
Paid ₹2500 using Credit Card.
Paid ₹1500 using UPI.
Paid ₹5000 using PayPal.
```

## Benefits

- Runtime flexibility
- Easy to add new payment methods
- Follows the Open/Closed Principle
# Chain of Responsibility Pattern

## Objective

Pass a request through a chain of handlers until one of them processes it.

## Pattern Type

Behavioral Design Pattern

## Components

- SupportHandler
- Level1Support
- Level2Support
- Level3Support

## How It Works

Each handler decides whether it can process the request. If it cannot, it forwards the request to the next handler in the chain.

## Output

```text
Level 1 Support handled the request.
Level 2 Support handled the request.
Level 3 Support handled the request.
No support level available for this request.
```

## Benefits

- Reduces coupling between sender and receiver
- Makes adding new handlers easy
- Flexible request processing
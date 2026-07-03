# State Pattern

## Objective

Allow an object to change its behavior when its internal state changes.

## Pattern Type

Behavioral Design Pattern

## Components

- IState
- NoCoinState
- HasCoinState
- VendingMachine

## How It Works

The VendingMachine delegates its behavior to the current state object. When a coin is inserted or a button is pressed, the state changes, and the machine behaves differently without complex conditional logic.

## Output

```text
Please insert a coin first.
Coin inserted.
Dispensing item...
Please insert a coin first.
```

## Benefits

- Eliminates large if-else or switch statements
- Encapsulates state-specific behavior
- Makes adding new states easier
# Decorator Pattern

## Objective

Add additional features to a coffee object without modifying its original implementation.

## Pattern Type

Structural Design Pattern

## Components

- Coffee
- SimpleCoffee
- CoffeeDecorator
- MilkDecorator
- SugarDecorator

## How It Works

Decorators wrap the original coffee object and add new functionality such as milk and sugar while keeping the original object unchanged.

## Output

```text
Plain Coffee
Cost: ₹50

Plain Coffee, Milk, Sugar
Cost: ₹80
```

## Benefits

- Adds functionality dynamically
- Avoids large inheritance hierarchies
- Promotes flexible design
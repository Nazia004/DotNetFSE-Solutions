# Prototype Pattern

## Objective

Create new objects by cloning existing objects instead of creating them from scratch.

## Pattern Type

Creational Design Pattern

## Components

- Shape
- Circle
- Rectangle
- Program

## How It Works

Each object implements Clone(). New objects are created by copying existing objects while preserving their properties.

## Output

```text
Original Objects
Circle -> Radius: 10, Color: Red
Rectangle -> Width: 20, Height: 10, Color: Blue

Cloned Objects
Circle -> Radius: 10, Color: Red
Rectangle -> Width: 20, Height: 10, Color: Blue
```

## Benefits

- Faster object creation
- Avoids repeated initialization
- Simplifies copying complex objects
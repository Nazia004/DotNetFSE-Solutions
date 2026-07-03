# Command Pattern

## Objective

Encapsulate a request as an object, allowing commands to be parameterized and executed independently.

## Pattern Type

Behavioral Design Pattern

## Components

- ICommand
- Light
- LightOnCommand
- LightOffCommand
- Remote

## How It Works

The `Remote` acts as the invoker. It doesn't know how the light works; it simply executes the command object. Each command contains the logic to perform an action on the receiver (`Light`).

## Output

```text
Light is ON
Light is OFF
```

## Benefits

- Decouples the sender from the receiver
- Easy to add new commands
- Supports undo/redo functionality
# Singleton Pattern

## Objective

Ensure that only one instance of the Logger class exists throughout the application.

## Pattern Type

Creational Design Pattern

## Components

- Logger
- Program

## How It Works

The Logger class has a private constructor and a static instance. The GetInstance() method always returns the same object.

## Output

```text
Log: First Log Message
Log: Second Log Message
Both logger instances are the same.
```

## Benefits

- Single shared instance
- Controlled object creation
- Reduced memory usage
# Factory Method Pattern

## Objective

Create document objects without exposing their concrete implementation.

## Pattern Type

Creational Design Pattern

## Components

- Document
- WordDocument
- PdfDocument
- DocumentFactory
- WordFactory
- PdfFactory

## How It Works

The factory creates the required document object. The client works with the abstract type instead of directly creating objects.

## Output

```text
Opening Word Document...
Opening PDF Document...
```

## Benefits

- Loose coupling
- Easier to extend
- Centralized object creation
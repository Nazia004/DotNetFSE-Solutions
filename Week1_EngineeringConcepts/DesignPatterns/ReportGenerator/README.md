# Template Method Pattern

## Objective

Define the skeleton of an algorithm in a base class while allowing subclasses to customize individual steps.

## Pattern Type

Behavioral Design Pattern

## Components

- Report (Abstract Class)
- PDFReport
- ExcelReport

## How It Works

The `GenerateReport()` method defines the overall workflow. Each subclass provides its own implementation for fetching, formatting, and exporting data.

## Output

```text
Fetching data for PDF Report...
Formatting PDF Report...
Exporting PDF Report.

Fetching data for Excel Report...
Formatting Excel Report...
Exporting Excel Report.
```

## Benefits

- Promotes code reuse
- Maintains a consistent workflow
- Allows customization of individual steps
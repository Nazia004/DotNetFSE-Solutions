# Observer Pattern

## Objective

Notify multiple objects automatically whenever the state of another object changes.

## Pattern Type

Behavioral Design Pattern

## Components

- ISubject
- IObserver
- WeatherStation
- MobileDisplay
- TVDisplay

## How It Works

The WeatherStation maintains a list of observers. Whenever the temperature changes, it notifies all registered displays, which update themselves automatically.

## Output

```text
Mobile Display : Temperature = 30°C
TV Display : Temperature = 30°C

Mobile Display : Temperature = 35°C
TV Display : Temperature = 35°C
```

## Benefits

- Loose coupling
- Automatic notifications
- Easy to add new observers
# Proxy Pattern

## Objective

Control access to an object by introducing a proxy that creates the real object only when required.

## Pattern Type

Structural Design Pattern

## Components

- IImage
- RealImage
- ProxyImage

## How It Works

The proxy holds a reference to the real image. The real image is loaded only when `Display()` is called for the first time (lazy initialization).

## Output

```text
Image created.

First Display:
Loading profile_photo.jpg...
Displaying profile_photo.jpg

Second Display:
Displaying profile_photo.jpg
```

## Benefits

- Lazy loading
- Improves performance
- Controls access to expensive objects
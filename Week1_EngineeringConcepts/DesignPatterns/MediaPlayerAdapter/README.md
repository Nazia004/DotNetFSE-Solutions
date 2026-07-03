# Adapter Pattern

## Objective

Allow incompatible media player interfaces to work together.

## Pattern Type

Structural Design Pattern

## Components

- MediaPlayer
- AdvancedMediaPlayer
- MediaAdapter
- AudioPlayer
- Mp4Player
- VlcPlayer

## How It Works

The adapter converts requests from AudioPlayer into the appropriate advanced media player implementation.

## Output

```text
Playing mp3 file: song.mp3
Playing mp4 file: movie.mp4
Playing vlc file: video.vlc
Invalid media format.
```

## Benefits

- Reuses existing classes
- Improves compatibility
- Reduces code changes
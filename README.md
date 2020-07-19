# Subtitle Manager

A .Net Standard library that provides functionality for serialization, parsing/deserialization & editing of subtitles.

Supported subtitle formats:

Name | Extension | Status |
--- | --- | ---
SubRip | .srt | completed
WebVTT | .vtt | work in progress

## Base structure

### ISubtitle

Property | Type |
--- | ---
Lines | List\<ISubtitleLine>

### ISubtitleLine

Property | Type |
--- | ---
Start | TimeSpan
End | TimeSpan
Text | string

## Serialization

To serialize call ```ToString()``` on types that implement ```ISubtitle``` or ```ISubtitleLine```.
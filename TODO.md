# C# Music Library

## POCOs

* ***Note*** :heavy_check_mark:
    1. Name (C, F#) - string
    2. Octave (1 - 7) - int
        * omits A0 / Bb0 / B0 and C8
    3. Frequency (32.70 - 3951.07) - double
    4. Duration (1 = quarter, 0.5 = eighth, 4 = whole) - double
    5. DisplayName ("C# 3") - string

* ***Key*** :heavy_check_mark:
    1. RootNote - Note or string(?)
    2. KeyMode - Scale.(Major, Minor, Dorian, etc) = List<1/2 or whole steps>
    3. Notes - List\<Note>
        * Calculated based on KeyMode + RootNote (Needs Chromatic Scale static obj as reference)

* ***Chord***
    1. Notes - List\<Note>
    2. ChordQuality - Quality.(Major, Minor, Diminished, Augmented, [1/2 Diminished, Dominant] - 7ths) - Quality
    3. ChordKey (C, Em) - Key
    4. DisplayName (Am, Chalf-dim7, D7, Em7, Gmaj7, F#11(add2)) - string

## Enums / Static Classes / Needed Lists

* ***Scale*** :heavy_check_mark:
    1. Major = 2212221
    2. Dorian = 2122212
    3. Phrygian = 1222122
    4. (rest of major modes)
    5. Chromatic = 11111111111

* ***Quality***
    1. Major
    2. Minor
    3. Diminished
    4. Augmented
    5. HalfDiminished
    6. Dominant

* ***Frequencies*** :heavy_check_mark:
    1. A = 55.00000
    2. etc

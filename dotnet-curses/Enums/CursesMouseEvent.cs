﻿namespace Mindmagma.Curses
{
    public enum CursesMouseEvent : long
    {
        BUTTON1_RELEASED = 1,
        BUTTON1_PRESSED,
        BUTTON1_CLICKED = 4,
        BUTTON1_DOUBLE_CLICKED = 8,
        BUTTON1_TRIPLE_CLICKED = 16,
        BUTTON2_RELEASED = 64,
        BUTTON2_PRESSED = 128,
        BUTTON2_CLICKED = 256,
        BUTTON2_DOUBLE_CLICKED = 512,
        BUTTON2_TRIPLE_CLICKED = 1024,
        BUTTON3_RELEASED = 4096,
        BUTTON3_DOUBLE_CLICKED = 32768,
        BUTTON3_TRIPLE_CLICKED = 65536,
        BUTTON4_RELEASED = 262144,
        BUTTON4_PRESSED = 524288,
        BUTTON4_CLICKED = 1048576,
        BUTTON4_DOUBLE_CLICKED = 2097152,
        BUTTON4_TRIPLE_CLICKED = 4194304,
        BUTTON1_RESERVED_EVENT = 32,
        BUTTON2_RESERVED_EVENT = 2048,
        BUTTON3_RESERVED_EVENT = 131072,
        BUTTON4_RESERVED_EVENT = 8388608,
        BUTTON_CTRL = 16777216,
        BUTTON_SHIFT = 33554432,
        BUTTON_ALT = 67108864,
        REPORT_MOUSE_POSITION = 134217728,
        ALL_MOUSE_EVENTS = 134217727
    }
}
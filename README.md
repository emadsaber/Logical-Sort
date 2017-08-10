# Logical-Sort
This library is used for sorting strings logically like Windows Explorer style.

## Programming Language
-  C#.NET (4.5.2)

## Editor
-  Visual Studio 2015

## Example
Assume you have the following string array which may be files in a folder: 
{
  "1.mp3",
  "5.mp3",
  "3.mp3",
  "10.mp3",
  "50.mp3",
  "31.mp3"
}
If you used the usual Array.Sort() method, it will sort the files on this form:
{
  "1.mp3",
  "10.mp3",
  "3.mp3",
  "31.mp3"
  "5.mp3",
  "50.mp3",
}
Which is incorrect way. But using Our logical comparer, the output will be like that:
{
  "1.mp3",
  "3.mp3",
  "5.mp3",
  "10.mp3",
  "31.mp3"
  "50.mp3",
}

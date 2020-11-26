# Lorem.NetCore
This is a .Net Core port of the original Lorem.NET. Original Lorem.NET can be accessed at https://github.com/dochoffiday/Lorem.NET  by @dochoffiday.

# Installation
Install-Package Lorem.NetCore

# Usage

Console.WriteLine($"Email: {LoremNETCore.Generate.Email()}"); <br />
Console.WriteLine($"Chance: {LoremNETCore.Generate.Chance(1, 2)}");<br />
Console.WriteLine($"Words: {LoremNETCore.Generate.Words(5)}");<br />
Console.WriteLine($"Sentence: {LoremNETCore.Generate.Sentence(5, 25)}");<br />
Console.WriteLine($"Paragraph: {LoremNETCore.Generate.Paragraph(5,10)}");<br />



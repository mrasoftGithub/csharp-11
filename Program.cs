using csharp11Solution;
using System.Text.Unicode;

// Gewone string
// De "\" heeft een speciale betekenis.
// daarom een escape sequence
string volledigPad = "C:\\Mijn documenten\\Tanga's.xslx";
string tekst = "Bestand: ";
Console.WriteLine(tekst + volledigPad);

//Verbatim String
tekst = @"Bestand: C:\Mijn documenten\Tanga's.xslx";
Console.WriteLine(tekst);

// Interpolated String
tekst = $"Bestand: {volledigPad}";
Console.WriteLine(tekst);

// Raw String Literal
string eigenaar1 = "Marisca";
string eigenaar2 = "Sandra";

string xml =
    $"""

    <root>
        <eigenaar>
            <naam>{eigenaar1}</naam>
        </eigenaar>
        <eigenaar>
            <naam>{eigenaar2}</naam>
        </eigenaar>
    </root>

    """;
Console.WriteLine(xml);

string json = $$"""
              [
                {
                    "naam" : "{{eigenaar1}}"
                },
                {
                    "naam" : "{{eigenaar2}}"
                }
              ]

              """;
Console.WriteLine(json);

// required keyword
EIGENAAR eigenaar = new EIGENAAR {ID = 1, Omschrijving = "de auto van Marisca" };
Console.WriteLine($"Dit is {eigenaar.Omschrijving} en de ID is {eigenaar.ID}.\n");

// switch statement in een Raw String Literal 
int Regio = 2;
Console.WriteLine(
   $"""
   Nummer {Regio} staat voor regio {Regio switch
   {
       1 => "Noord",
       2 => "Midden",
       3 => "Zuid",
       _ => "Onbekend"
   }}.

   """);

// List Patterns
int[] nummers = { 1, 2, 3, };

// patroon 1
var patroon1 = nummers is [1,2,3];
if (patroon1) Console.WriteLine("De elementen in de array voldoen aan patroon1\n(precies drie dezelfde elementen).\n");

// patroon 2
var patroon2 = nummers is [1, 2];
if (!patroon2) Console.WriteLine("De elementen in de array voldoen niet aan patroon2\n(patroon2 begint en bevat weliswaar dezelfde twee elementen,\nmaar het zijn er twee terwijl de array drie elementen bevat).\n");

// patroon 3
var patroon3 = nummers is [1, 2, _];
if (patroon3) Console.WriteLine("De elementen in de array voldoen aan patroon3\n(het begint met twee dezelfde elementen en wat daarna komt is irrelevant).\n");

// patroon 4
var patroon4 = nummers is [1, 2, > 2];
if (patroon4) Console.WriteLine("De elementen in de array voldoen aan patroon4\n(het begint met twee dezelfde elementen en het derde element is groter dan 2).\n");

// C# file access modifier   //
int getal1 = 1;
int getal2 = 2;

Berekening_Correct berekening_correct = new Berekening_Correct();
Berekening_Exoot berekening_exoot = new Berekening_Exoot();

Console.WriteLine($"De correcte manier van optellen     : {getal1} + {getal2}  is {berekening_correct.Optellen(getal1, getal2)}");
Console.WriteLine($"De exotische manier van optellen    : {getal1} en {getal2} is {berekening_exoot.Optellen(getal1, getal2)}");
Console.WriteLine($"De correcte manier van verminderen  : {getal1} - {getal2}  is {berekening_correct.Verminderen(getal1, getal2)}");
Console.WriteLine($"De exotische manier van verminderen : {getal1} - {getal2}  is {berekening_exoot.Verminderen(getal1, getal2)}\n");

Console.WriteLine("De methoden '.Optellen()' en '.Verminderen()' in Bestand2.cs wijken af van de publieke methodes in Bestand1.cs, ");
Console.WriteLine("en we kunnen die methoden met de file access modifier definiëren in Bestand2.cs zonder");
Console.WriteLine("dat dat conflicten oplevert met de publieke methoden in Bestand1.cs.\n");

// UTF8 string literals
var data = new ReadOnlySpan<byte>(new byte[] { 65, 66, 67 });
data = "ABC"u8;
data = new byte[] { 65, 66, 67 };
data = "ABC"u8.ToArray();
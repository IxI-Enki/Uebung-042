<!--              READE -> VORLAGE Uebungen: Programmieren & Software Engineering              -->

# Uebung-042  --  [***ASCII Tabelle***](https://github.com/IxI-Enki/Uebung-042/blob/main)  

<!-- ---------------------------------------------|-------------------------------------------- -->
###### 📎[**Angabe**](https://github.com/IxI-Enki/Uebung-042/blob/main/work-directory/ASCII_Table.pdf) *.pdf*
<sup><sub> 
---
</sub></sup>

<!-- ---------------------------------------------|-------------------------------------------- -->
## 📊 Lernziele:  
- ↳ Stringbearbeitung   
- ↳ ASCII Code  
 
  > <sub> [..*Quelle ASCII Code*..](https://tools.piex.at/ascii-tabelle/)

<sup><sub> </sub></sup>
---

<!-- ---------------------------------------------|-------------------------------------------- -->
## 🧮 **Aufgabenstellung:**  
  -  *Schreiben Sie ein Programm, welches die druckbaren Zeichen des ASCII Codes, samt der entsprechende INT und HEX Zahl ausgibt.  
  -  *Die Druckbaren Zeichen beginnen bei dezimal 32 und enden bei dezimal 127*   
 
---
 
<!-- ---------------------------------------------|-------------------------------------------- -->
## 🔎 **Ausgabe** <sub>*Bsp.*</sub> 

- Exemplarisch die ersten 15 Zeilen der Ausgabe …

   |           *Benutzerschnittstelle:*   |  
   | :-----------------------------------------------------------------------------------------------------------------: |
   |  ![**Ausgabebeispiel 📎**](https://github.com/IxI-Enki/Uebung-042/assets/138018029/55785dfd-c5ae-4399-9fb3-c7fd8cef4dec) |

- … muss fortgesetzt werden bis zum Code 127

---

<!-- ---------------------------------------------|-------------------------------------------- -->


# *SPOILER* <sub><sup> → [*Lösung*](https://github.com/IxI-Enki/Uebung-<<AUSFÜHRBAREDAT>>.cs) <sup></sub>:




### 🖥 **Ausgabe**: 
   |           *meine Ausgabe:*     |
   |--------------------------------|
   |  ![**Ausgabe 📎**](https://github.com/IxI-Enki/Uebung-042/assets/138018029/cc3c86db-1d77-42ee-a97a-ba10ae06371f) |

---

## 💾 `C#` - *Programm*:
 <details><summary>👉 ausklappen 👈 </summary>


 ```c#
namespace ASCIItable        //  
{                           //
  public class Program      //
  {                         //
    static void Main()      //
    {
      ///*----------------------- console_settings ------------------------*///
      const int cWidth = 53;                     //  console width
      const int cHeight = 30;                    //  & height
      Console.SetWindowSize(cWidth, cHeight);    //
      Console.OutputEncoding = Encoding.UTF8;    //  Unicode Symbols
      /*----------------------------- CONSTANTES ----------------------------*/
      const int firstASCII = 32;
      const int lastASCII = 127;
      /*----------------------------- VARIABLES -----------------------------*/
      int index, hexIndex = 3,
          decimalNumber,
          hexRemainder;

      char printChar;
      char[] hexDigit = new char[hexIndex + 1];

      string outputCode,
             outHex;
      string[] outputLine = new string[lastASCII - firstASCII + 1];

      /*-------------------------------- HEAD -------------------------------*/
      Console.Clear();
      Console.Write("\n                   ASCII Tabelle                     " +
      /* cWidth: */ "\n==========================-==========================");

      for (index = 0; index < (lastASCII - firstASCII + 1); index++)
      {
        //  add Symbol & Prefix to Line
        printChar = Convert.ToChar(firstASCII + index);
        outputLine[index] = "    Zeichen: " + printChar;

        //  add Decimal & Prefix + Suffix to Line
        decimalNumber = firstASCII + index;
        outputCode = "    Code: " + Convert.ToString(decimalNumber).PadLeft(3) + " (dez)    ";
        outputLine[index] = outputLine[index] + outputCode;

        //  add Hex & Prefix + Suffix to Line
        outHex = ""; hexIndex = 0;
        while (decimalNumber % 16 >= 0 && hexIndex < 4)
        {
          hexRemainder = decimalNumber % 16;
          hexDigit[hexIndex] = (char)(hexRemainder < 10 ? hexRemainder + '0' : hexRemainder - 10 + 'A');
          outHex = hexDigit[hexIndex] + outHex;
          decimalNumber = decimalNumber / 16;
          hexIndex++;
        }
        outputLine[index] = outputLine[index] + outHex + " (hex)    ";
      }
      //  output:
      for (index = 0; index < (lastASCII - firstASCII + 1); index++)
      {
        Console.Write($"\n {outputLine[index]}");
      }
      /*-------------------------------- END --------------------------------*/
      Console.Write("\n Zum beenden Eingabetaste drücken..");
      Console.ReadLine();    //  wait for [enter]
      Console.Clear();       //
    }
  }
}

```
> <sub> [..*weiterführende Quelle*..] </sub> [ **⁷** ]()

</dertails>

-->

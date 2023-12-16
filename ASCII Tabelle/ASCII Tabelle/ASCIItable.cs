/*-----------------------------------------------------------------------------
 *                      HTBLA-Leonding / Class: 3ACIF                          
 *-----------------------------------------------------------------------------
 *                      Jan Ritt                                               
 *-----------------------------------------------------------------------------
 *  Description:  Print Ascii Table - Symbol + appropriate hex & decimal number
 *-----------------------------------------------------------------------------
*/

/*_________________________________libraries_________________________________*/
using System;                   //  
using System.Text;              //  Unicode Symbols
using System.Threading;         //  Thread.Sleep(1000) = 1 sec

/*---------------------------------- START ----------------------------------*/
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
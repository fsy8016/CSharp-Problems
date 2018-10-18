using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the braces function below.
    static string[] braces(string[] values)
    {
        string[] result = new string[values.Count()];
        int count = 0;

        // your code goes here :)
        foreach (var element in values)
        {
            Stack stack = new Stack();

            foreach (char character in element)
            {
                if (character == '{' || character == '[' || character == '(')
                {
                    stack.Push(character);
                }
                else if (character == '}' || character == ']' || character == ')')
                {
                    if (stack.Count == 0)
                    {
                        result[count] = "NO";
                        break;
                    }

                    char compareCharacter = ((char)stack.Pop());

                    if (character == '}' && compareCharacter == '{')
                    {
                        continue;
                    }

                    if (character == ']' && compareCharacter == '[')
                    {
                        continue;
                    }

                    if (character == ')' && compareCharacter == '(')
                    {
                        continue;
                    }

                    result[count] = "NO";
                    break;
                }

                result[count] = "YES";

            }

            if (stack.Count != 0)
            {
                result[count] = "NO";
            }

            count++;

        }

        return result;

    }

    // ignore all the stuff down here
    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int valuesCount = Convert.ToInt32(Console.ReadLine());

        string[] values = new string[valuesCount];

        for (int i = 0; i < valuesCount; i++)
        {
            string valuesItem = Console.ReadLine();
            values[i] = valuesItem;
        }

        string[] res = braces(values);

        textWriter.WriteLine(string.Join("\n", res));

        textWriter.Flush();
        textWriter.Close();
    }
}

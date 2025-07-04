﻿// See https://aka.ms/new-console-template for more information
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\Users\91897\Desktop\c#\MyExceptio\Helloworld.txt";
        StreamReader str = null;

        try
        {
            str = new StreamReader(path);
            Console.WriteLine("*******************[ File content ]****************");
            Console.WriteLine(str.ReadToEnd());
        }
        catch (FileNotFoundException ex)
        {
            // exception creation and throw
            Console.WriteLine("FILE NOT FOUND {0}", ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine("DIRECTORY NOT FOUND {0}", ex.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("Now I am in finally block");
        }

        Console.WriteLine("Bye Bye");
        Console.ReadLine();
    }
}

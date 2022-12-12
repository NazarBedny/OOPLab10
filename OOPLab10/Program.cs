using System;
using System.Reflection;

namespace OOPLab10
{

    public class HarvestingFieldsTest
    {
        static void Main(string[] args)
        {
            Type myType = typeof(HarvestingFields);

            string input = "";
            while (input != "Harvest")
            {
                input = Console.ReadLine();
                if (input == "private")
                {
                    foreach (FieldInfo field in myType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static))
                    {
                        string modificator = "";
                        if (field.IsPrivate)
                        {
                            modificator += "private ";
                            Console.WriteLine($"{modificator}{field.FieldType.Name} {field.Name}");
                        }

                    }
                }
                if (input == "protected")
                {
                    foreach (FieldInfo field in myType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static))
                    {
                        string modificator = "";

                        if (field.IsFamily)
                        {
                            modificator += "protected ";
                            Console.WriteLine($"{modificator}{field.FieldType.Name} {field.Name}");
                        }
                            

                    }
                }
                if (input == "public")
                {
                    foreach (FieldInfo field in myType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static))
                    {
                        string modificator = "";
                        if (field.IsPublic)
                        {
                            modificator += "public ";
                            Console.WriteLine($"{modificator}{field.FieldType.Name} {field.Name}");
                        }
                    }
                }
                if (input == "all")
                {
                    foreach (FieldInfo field in myType.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static))
                    {
                        string modificator = "";
                        if (field.IsPublic)
                            modificator += "public ";
                        else if (field.IsPrivate)
                            modificator += "private ";
                        else if (field.IsFamily)
                            modificator += "protected ";

                        Console.WriteLine($"{modificator}{field.FieldType.Name} {field.Name}");
                    }
                }
            }
        }
    }

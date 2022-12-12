using System;
using System.Reflection;

namespace Task2
{
    public class BlackBoxIntegerTests
    {
        public delegate void boxDelegate(int parameter);
        public static void Main(string[] args)
        {
            Type myType = typeof(BlackBoxInteger);
            BlackBoxInteger activator = (BlackBoxInteger)Activator.CreateInstance(myType, true);

            string input = "";
            while (input != "END")
            {
                input = Console.ReadLine();
                var res = input.Split('_');
                var value = 0;
                var name = "";
                if (res.Length == 2)
                {
                    value = int.Parse(res[1]);
                    name = res[0];

                    var method = myType.GetMethod(name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                    method.Invoke(activator, new object[] { value });
                    int currentValue = (int)myType.GetField("innerValue", BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic)
                    .GetValue(activator);
                    Console.WriteLine(currentValue);
                }
            }
        }
    }
}

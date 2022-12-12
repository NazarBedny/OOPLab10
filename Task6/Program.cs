using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter order of traffic lights: ");

            string[] input = Console.ReadLine().Split();
            TrafficLight[] trafficLights = new TrafficLight[input.Length];

            if (!input.Any())
            {
                Console.WriteLine("You have not entered lights.");
            }

            for (int i = 0; i < trafficLights.Length; i++)
            {
                trafficLights[i] = (TrafficLight)Activator.CreateInstance(typeof(TrafficLight), new object[] { input[i] });
            }

            Console.WriteLine("Please enter the n number of times you need to change each traffic light's signal: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                List<string> result = new List<string>();
                foreach (var trafficLight in trafficLights)
                {
                    MethodInfo dynMethod = trafficLight.GetType().GetMethod("UpdateColor",
                        BindingFlags.NonPublic | BindingFlags.Instance);

                    dynMethod.Invoke(trafficLight, new object[] { });

                    var field = typeof(TrafficLight).GetField("_currentSignal", BindingFlags.NonPublic | BindingFlags.Instance);
                    result.Add(field.GetValue(trafficLight).ToString());
                }

                Console.WriteLine(String.Join(" ", result));
            }
        }
    }
}

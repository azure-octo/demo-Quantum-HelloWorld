using System;

using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using Microsoft.Quantum.Intrinsic;

namespace QSharpHelloWorld
{
    class Driver
    {
        static void Main(string[] args)
        {
            int nbExperiments = 10000;
            int oneCount = 0;
            using (var qsim = new QuantumSimulator())
            {
                for(int i=0; i<nbExperiments; i++)
                {
                    var r = HelloQ.Run(qsim).Result;
                    if (r.ToString() == "One")
                    {
                        Console.Write("X");
                        oneCount++;
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine(string.Format("\n\nProbability of 1s: {0:P2}", oneCount * 1.0 / nbExperiments));
            }
        }
    }
}
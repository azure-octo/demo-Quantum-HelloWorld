using System;
using System.Diagnostics;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace QubitMemory
{
    class Driver
    {
        static void Main(string[] args)
        {
            using (var qsim = new QuantumSimulator())
            {
                int count = 35;
                double[] m = new double[count];
                for (int i=0; i<count; i++)
                {
                    qsim.QubitManager.Allocate(1);
                    m[i] = Process.GetCurrentProcess().WorkingSet64;
                    Console.WriteLine(string.Format("# of qubits: {0:00}:\t\tMemory usage: {1:0.###}G", (i+1), m[i]/(1024*1024*1024)));
                }
            }
        }
    }
}
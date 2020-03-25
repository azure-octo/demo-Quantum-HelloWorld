# Demo: Quantum Development Kit Hello World
Two programs to demonstrate the QDK integration with Visual Studio code, as well as the fundamentals of Q# and quantum development.

## Create Dev Environment
- [Visual Studio Online Template](https://env.new?name=QSharp%20Hello%20World&repo=azure-octo/demo-Quantum-HelloWorld)

## Demo 1: Quantum Gates

1. Open `QSharpHelloWorld\Driver.cs` to show C# code
1. Open `QSharpHelloWorld\Operations.qs` to show Q# code
1. Select the VSCode debug menu
1. Drop down the debug profiles and select `QSharpHelloWorld` and select play
1. See the output of the simulation
1. Open `QSharpHelloWorld\Operations.qs` and comment out H Gate + Assert and uncomment Ry Gate + Assert
1. Repeat debug run and show output of simulation

## Demo 2: Quantum Simulation

1. Open `QubitMemory\Driver.cs` to show simulation code
1. Select the VSCode debug menu
1. Drop down the debug profiles and select `QubitMemory` and select play
1. See the memory use exponentially grow as number of qubits increases

Definition
Convert the interface of a class into another interface clients expect. Adapter lets classes work together that couldn't otherwise because of incompatible interfaces.

Participants
The classes and/or objects participating in this pattern are:
 Target (ChemicalCompound)
	o defines the domain-specific interface that Client uses.
 Adapter (Compound)
	o adapts the interface Adaptee to the Target interface.
 Adaptee (ChemicalDatabank)
	o defines an existing interface that needs adapting.
 Client (AdapterApp)
	o collaborates with objects conforming to the Target interface.

Real-world sample code
The real-world code demonstrates the use of a legacy chemical databank. Chemical compound objects access the databank through an Adapter interface.
Code in project: DoFactory.GangOfFour.Adapter.RealWorld

.NET optimized sample code
The .NET optimized code demonstrates the same code as above but uses more modern, built-in .NET features. To improve encapsulation Compound class
variables were changed from protected to private and several corresponding set/get properties were added. This will allow the derived class to access
these variables via properties rather than directly. Finally, two enumerations (Chemical and State) were added for increased type safety.
Code in project: DoFactory.GangOfFour.Adapter.NetOptimized

Adapter: when and where you would use it
.NET developers write classes that expose methods that are called by clients. Most of the time they will be able to control the interfaces, but there
are situations, for example, when using 3rd party libraries, where they may not be able to do so. The 3rd party library performs the desired services 
but the interface methods and property names are different from what the client expects. This is a scenario where you would use the Adapter pattern.

The Adapter provides an interface the client expects using the services of a class with a different interface. Adapters are commonly used in programming 
environments where new components or new applications need to be integrated and work together with existing programming components.

Adapters are also useful in refactoring scenarios. Suppose that you have two classes that perform similar functions but have different interfaces. 
The client uses both classes, but the code would be far cleaner and simpler to understand if they would share the same interface. You cannot alter
the interface, but you can shield the differences by using an Adapter which allows the client to communicate via a common interface. The Adapter 
handles the mapping between the shared interface and the original interfaces.
using System;

namespace Adapter
{
    class RichCompound : Compound
    {
        ChemicalDatabank bank;

        // Constructor
        public RichCompound(Chemical chemical)
        {
            Chemical = chemical;

            // The Adaptee
            bank = new ChemicalDatabank();
        }

        public override void Display()
        {
            // Adaptee request methods
            BoilingPoint = bank.GetCriticalPoint(Chemical, State.Boiling);
            MeltingPoint = bank.GetCriticalPoint(Chemical, State.Melting);
            MolecularWeight = bank.GetMolecularWeight(Chemical);
            MolecularFormula = bank.GetMolecularStructure(Chemical);

            Console.WriteLine("\nCompound: {0} ------ ", Chemical);
            Console.WriteLine(" Formula: {0}", MolecularFormula);
            Console.WriteLine(" Weight : {0}", MolecularWeight);
            Console.WriteLine(" Melting Pt: {0}", MeltingPoint);
            Console.WriteLine(" Boiling Pt: {0}", BoilingPoint);
        }
    }
}
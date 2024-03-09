using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ApplicationDevelopmentInC_.seminar_1.FamilyMember;

namespace ApplicationDevelopmentInC_.seminar_1
{

    internal class ProgramSeminar
    {
        static void Main(string[] args)
        {
            // Create family members
            AdultFamilyMember mother = new AdultFamilyMember(null, null, "Mary", Gender.Famele, 35);
            AdultFamilyMember father = new AdultFamilyMember(null, null, "John", Gender.Male, 40);
            FamilyMember child1 = new FamilyMember(mother, father, "Emily", Gender.Famele, 10);
            FamilyMember child2 = new FamilyMember(mother, father, "David", Gender.Male, 8);
            mother.Children = new[] { child1, child2 };
            father.Children = new[] { child1, child2 };

            // Create an adult family member with children
            AdultFamilyMember adult = new AdultFamilyMember(
                null,
                null,
                "Jane",
                Gender.Famele,
                30,
                new FamilyMember[] { father });
            mother.Spouse = father;
            father.Spouse = mother;

            // Print the family tree
            adult.Print();
            Console.WriteLine();
            mother.PrintSpouse();

            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentInC_.seminar_1
{
    public class AdultFamilyMember : FamilyMember
    {
        public AdultFamilyMember(FamilyMember? mother, FamilyMember? father, string name, Gender sex, int age,
            FamilyMember[]? children = null) : base(mother, father, name, sex, age)
        {
            Children = children;
        }

        public FamilyMember[] Children { get; set; }
        public FamilyMember Spouse { get; set; }


        public override void Print(int indent = 1)
        {
            base.Print(indent);

            foreach (var child in Children)
            {
                if (child is AdultFamilyMember adultChild)
                {
                    adultChild.Print(indent * 2);
                }
                else
                {
                    child.Print(indent * 2);
                }
            }
        }

        public void PrintSpouse(int indent = 1)
        {
            base.Print(indent);
            Spouse.Print(indent);
        }
    }
}
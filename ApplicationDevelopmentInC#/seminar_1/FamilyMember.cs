using System;

namespace ApplicationDevelopmentInC_.seminar_1
{
    public class FamilyMember
    {
        public FamilyMember(FamilyMember mother, FamilyMember father, string name, Gender sex, int age)
        {
            Mother = mother;
            Father = father;
            Name = name;
            Sex = sex;
            Age = age;
        }

        public FamilyMember Mother { get; }
        public FamilyMember Father { get; }
        public string Name { get; }
        public Gender Sex { get; }
        public int Age { get; }

        void Info(int indent = 1)
        {
            Console.WriteLine($"{new String('-', indent)}Имя {this.Name}");
            if (this.Mother != null)
            {
                Console.WriteLine($"{new String('-', indent)}Мать: {this.Mother.Name}");
            }
            if (this.Father != null)
            {
                Console.WriteLine($"{new String('-', indent)}Отец: {this.Father.Name}");
            }
        }

        public virtual void Print(int indent = 1)
        {
            Info(indent);
        }
    }
}
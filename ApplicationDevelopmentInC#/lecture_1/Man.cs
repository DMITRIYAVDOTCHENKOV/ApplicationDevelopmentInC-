using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentInC_.lecture_1
{
    internal class Man : Person
    {
        /// <summary>
        /// Вызываем  переопределенный метод, определенный в классе Person
        /// </summary>
        protected override string HelloPhrase => "Я новый метод !!!";



        public Man(string neme) : base(neme)
        {
        }

        public Man(string name, DateTime birthday, int height) : base(name, birthday, height)
        {
        }

        /// <summary>
        /// Наличия бороды
        /// </summary>
        public bool HasBeard { get; private set; } = true;



        /// <summary>
        /// Метод бритья
        /// </summary>
        public void Shave()
        {
            Console.WriteLine("Бреется");
            this.HasBeard = false;
        }
        public override void SayHello()
        {
            base.SayHello();
            Console.WriteLine("Я побрился !!!");
        }

        public void SayHelloBase()
        {
            base.SayHello();
        }

        public new void Print()
        {
            Console.WriteLine("Скрытый метод");
        }
    }

}

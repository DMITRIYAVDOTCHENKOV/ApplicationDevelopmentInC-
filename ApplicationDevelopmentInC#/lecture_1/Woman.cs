using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationDevelopmentInC_.lecture_1
{
    internal class Woman : Person
    {
        /// <summary>
        /// наличия макияжа, возможно задать из нутри класса
        /// </summary>
        public bool MasMakeup { get; private set; } = false;
        protected override string HelloPhrase { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Woman(string neme) : base(neme)
        {
        }

        public Woman(string name, DateTime birthday, int height) : base(name, birthday, height)
        {
        }

        /// <summary>
        /// Метод нанесения макияжа
        /// </summary>
        public void PutMakeup()
        {
            Console.WriteLine("Наносит макияж");
            this.MasMakeup = true;
        }

        /// <summary>
        /// Метод удаления макияжа
        /// </summary>
        public void RemovePutMakeup()
        {
            Console.WriteLine("Удаляет макияж");
            this.MasMakeup = false;
        }





    }
}

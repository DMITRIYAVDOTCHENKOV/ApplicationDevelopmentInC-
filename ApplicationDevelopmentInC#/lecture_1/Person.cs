namespace ApplicationDevelopmentInC_.lecture_1

{
    /// <summary>
    /// Класс человек
    /// </summary>
   public abstract class  Person
    {
        public readonly string Name = string.Empty; // Имя
        public readonly DateTime Birthday; // Дата рождения
        public readonly int Height; // Рост
        public Person? Father = null; // Отец, может быть null , если стоит '?'
        public Person? Mother = null; // Мать, может быть null , если стоит '?'
        public Person[]? Cheldren = null; // Массив дитей, может быть null , если стоит '?'
        protected virtual string HelloPhrase { get; set; } = "Привет, я вызывался из класса Person!";


        /// <summary>
        /// конструктор с параметрами класса человек
        /// </summary>
        /// <param name="name">Имя</param> 
        /// <param name="birthday">Дата рождения</param>
        /// <param name="height">Рост</param>
        public Person(string name, DateTime birthday, int height)
        {
            Name = name;

            if (birthday == DateTime.Now)
                Birthday = birthday;
            {
                Console.WriteLine($"Дата {birthday}, не верная дата , присваеввем сегодняшнию!");
                Birthday = DateTime.Now;
            }
            Height = height;
        }

        /// <summary>
        /// Контсруктор с именем создающий экхемпдяр с текущей датой рождения
        /// </summary>
        /// <param name="neme">Имя</param>
        public Person(string neme)
        {
            this.Name = neme;
            this.Birthday = DateTime.Now;
            
        }


        /// <summary>
        /// Выводим более структуировано класс person
        /// </summary>
        public void Print() => Console.WriteLine($"Имя = {Name}, день рождения = {Birthday}, рост = {Height}");

        /// <summary>
        /// Проверяем, соверщшенно летний ли человек или нет
        /// </summary>
        /// <param name="abulAge">парметр возраст, можно задать по умолчанию </param>
        /// <returns></returns>
        public bool IsAdult(int abulAge = 18)
        {
            var delta = DateTime.Now.Year - Birthday.Year;
            if (delta > abulAge || delta == abulAge && DateTime.Now.DayOfYear <= Birthday.DayOfYear)
            {
                return true;
            }
            return false;
        }
        /// <summary>
        /// переопределение метода
        /// </summary>
        /// <param name="abulAge"></param>
        /// <returns></returns>
        public bool IsAdult()
        {
            return IsAdult(18);
        }
        /// <summary>
        /// Метод добавления родственников
        /// </summary>
        /// <param name="father">Отец</param>
        /// <param name="mother">Мать</param>
        /// <param name="cheldren">Дети</param>
        public void AddFamilyInfo(Person father, Person mother, params Person[] cheldren)
        {
            Father = father;
            Mother = mother;
            Cheldren = cheldren;
        }
        /// <summary>
        /// Метод выводит древо всего симейства 
        /// </summary>
        public void PrintFamilyInfo()
        {
            if (Father != null)
            {
                Console.WriteLine("Отец: ");
                Father.Print();
            }
            if (Mother != null)
            {
                Console.WriteLine("Мать: ");
                Mother.Print();
            }
            if (Cheldren != null && Cheldren.Length > 0)
            {
                Console.WriteLine("Дети: ");
                foreach (Person person in Cheldren)
                {
                    person.Print();
                }
            }
        }
        /// <summary>
        /// Метод выводящий приведственную фразу
        /// </summary>
        public virtual void SayHello()
        {
            Console.WriteLine("Привет, я - человек");
        }
    }
}
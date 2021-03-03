namespace SystemTypeMethods
{
    using System;

    public class Person : IPerson
    {
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        protected Person()
        {
        }

        public string Name { get; private set; }

        public int Age
        {
            get => this.age;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Age value, cannot be below zero!");
                }

                this.age = value;
            }
        }

        protected internal string MyProtectedInternalProperty { get; set; }

        public string WhoAmI()
        {
            return this.Name + "SomeRandomText";
        }

        [Obsolete]
        public void ObsoleteMethod()
        {
        }

        private static void PrivateStaticMethod()
        {
        }
    }
}

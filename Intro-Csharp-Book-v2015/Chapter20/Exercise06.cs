namespace Chapter20;

public static class Exercise06
{
    public static void Animals()
    {
        Animal[] animals = new Animal[]
        {
            new Dog("doggo", 1, "male"),
            new Frog("frogga", 2, "female"),
            new Cat("cattew", 3, "male"),
            new Kitten("kitty", 4, "female"),
            new Tomcat("tommo", 5, "male"),
        };
        
        foreach (var animal in animals)
            animal.MakeNoise();
    }

    public class Animal
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }

        public Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public virtual void MakeNoise()
        {
            Console.WriteLine("I am an animal");
        }
    }

    public class Dog : Animal
    {
        public Dog(string name, int age, string gender) : base(name, age, gender){}

        public override void MakeNoise()
        {
            Console.WriteLine("I am a dog");
        }
    }

    public class Frog : Animal
    {
        public Frog(string name, int age, string gender) : base(name, age, gender){}

        public override void MakeNoise()
        {
            Console.WriteLine("I am a frog");
        }
    }

    public class Cat : Animal
    {
        public Cat(string name, int age, string gender) : base(name, age, gender){}

        public override void MakeNoise()
        {
            Console.WriteLine("I am a cat");
        }
    }

    public class Kitten : Animal
    {
        public Kitten(string name, int age, string gender) : base(name, age, gender){}

        public override void MakeNoise()
        {
            Console.WriteLine("I am a kitten");
        }
    }

    public class Tomcat : Animal
    {
        public Tomcat(string name, int age, string gender) : base(name, age, gender){}

        public override void MakeNoise()
        {
            Console.WriteLine("I am a tomcat");
        }
    }
}
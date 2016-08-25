using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






namespace U2O
{
    public enum AnimalType
    {
        Bird,
        Fish,
        Amphibians,
        Insect,
        Mammal,
        Reptile
    }

    interface Animalsound
    {
        string Talk();
    }
    public class Animal : Animalsound
    {
        internal int Leg;
        internal int Eye;
        internal AnimalType Type;
        internal string Name;


        public Animal() { }
        public Animal(string name, AnimalType type, int leg, int eye)
        {
            Name = name;
            Leg = leg;
            Type = type;
            Eye = eye;
        }

        public string Talk()
        {
            return AnimalTalk.GetTalk(Type);
        }

    }

    public class Bird : Animal
    {
        private int Wingspan;
        public Bird(string name, int leg, int eye, int wingspan)
        {
            Name = name;
            Wingspan = wingspan;
            Leg = leg;
            Type = AnimalType.Bird;
            Eye = eye;
        }

        public override string ToString()
        {
            return string.Format("The {0} name is {1} and has a wingspan of {2}. The sound is {3}.", Type, Name, Wingspan, Talk());
        }
    }

    static class AnimalTalk
    {
        public static string GetTalk(AnimalType type)
        {
            string ret = "";
            switch (type)
            {
                case AnimalType.Bird:
                    ret = "Pip Pip";
                    break;
                case AnimalType.Fish:
                    ret = "Babel babel";
                    break;
                case AnimalType.Amphibians:
                    ret = "Cough Cough";
                    break;
                case AnimalType.Insect:
                    ret = "Buzz buzz";
                    break;
                case AnimalType.Mammal:
                    ret = "Bark bark";
                    break;
                case AnimalType.Reptile:
                    ret = "Hissssssssiiiii";
                    break;
                default:
                    ret = "";
                    break;
            }
            return ret;
        }
    }


    public static class AnimalExtensions
    {
        public static List<Animal> FilterOut(this List<Animal> animals, delegates.Filter filter)
        {
            var newAnimal = new List<Animal>();
            foreach (var animal in animals)
            {
                if (filter(animal))
                {
                    newAnimal.Add(animal);

                }
            }

            foreach (var item in newAnimal)
            {
                animals.Remove(item);
            }
            return animals;
        }

    }


}

namespace U2O.delegates
{
    public delegate bool Filter(Animal animal);
}

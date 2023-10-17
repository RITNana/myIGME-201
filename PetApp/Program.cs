using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetApp
{
    using PetApp;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Runtime.Remoting.Messaging;
    using System.Text;
    using System.Threading.Tasks;

    namespace PetApp
    {
        public interface ICat
        {
            void Eat();
            void Play();
            void Scratch();
            void Purr();
        }

        public abstract class Pet
        {
            private string name;
            public int age;

            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
                }

            }

            public abstract void Eat();





            public abstract void Play();




            public abstract void GotoVet();



            public Pet()
            {

            }
            public Pet(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

        }

        public interface IDog
        {
            void Eat();
            void Play();
            void Bark();
            void NeedWalk();
            void GotoVet();

        }

        public class Cat : Pet, ICat
        {
            public override void Eat()
            {
                Console.WriteLine(this.Name + " Meow! Tasty!");
            }

            public override void Play()
            {
                Console.WriteLine(this.Name + "Meow! Where's my ball of string?");
            }

            public void Purr()
            {
                Console.WriteLine(this.Name + " Purrrrrrrrrrrrrr");
            }

            public void Scratch()
            {
                Console.WriteLine(this.Name + "Meoooooooooooowwwwwww");
            }

            public override void GotoVet()
            {
                Console.WriteLine(this.Name + " HISSSSS! NO! I REFUSE!");
            }

            public Cat()
            {

            }

        }

        public class Dog : Pet, IDog
        {
            public string license;

            public override void Eat()
            {
                Console.WriteLine(this.Name + "Woof! Boy am I hungry");
            }

            public override void Play()
            {
                Console.WriteLine(this.Name + " Woof! Hey Owner! Let's play fetch!");
            }

            public void Bark()
            {
                Console.WriteLine(this.Name + " Woof Woof!");
            }

            public void NeedWalk()
            {
                Console.WriteLine(this.Name + " Woof! I need to go run!");
            }

            public override void GotoVet()
            {
                Console.WriteLine(this.Name + " BARK! BARK! NO! I DON'T WANNA GO!");
            }

            public Dog(string szLicense, string szName, int nAge) : base(szName, nAge)
            {
                this.license = szLicense;
                this.Name = szName;
                this.age = nAge;

            }
        }

        public class Pets
        {
            public List<Pet> petList = new List<Pet>();

            public Pet this[int nPetEl]
            {
                get
                {
                    Pet returnVal;
                    try
                    {
                        returnVal = (Pet)petList[nPetEl];
                    }
                    catch
                    {
                        returnVal = null;
                    }

                    return (returnVal);
                }

                set
                {
                    // if the index is less than the number of list elements
                    if (nPetEl < petList.Count)
                    {
                        // update the existing value at that index
                        petList[nPetEl] = value;
                    }
                    else
                    {
                        // add the value to the list
                        petList.Add(value);
                    }
                }
            }

            public int Count
            {
                get
                {
                    return petList.Count;
                }
            }

            public void Add(Pet pet)
            {
                petList.Add(pet);
            }

            public void Remove(Pet pet)
            {
                petList.Remove(pet);
            }

            public void RemoveAt(int petEl)
            {
                petList.RemoveAt(petEl);
            }

        }




    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Pet thisPet = null;
            Dog dog = null;
            Cat cat = null;
            IDog idog = null;
            ICat icat = null;

            Pets pets = new Pets();
            Random rand = new Random();

            for (int i = 0; i <= 50; i++)
            {
                // 1 in 10 chance of adding an animal
                if (rand.Next(1, 11) == 1)
                {
                    if (rand.Next(0, 2) == 0)
                    {
                        // add a dog

                         dog = new Dog(Console.ReadLine(), Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
                       
                        




                    }
                    else
                    {
                        // else add a cat

                    }
                }
                else
                {
                    // choose a random pet from pets and choose a random activity for the pet to do
                }

            }

        }
    }
}
    
 

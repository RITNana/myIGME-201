using System;
using System.Collections.Generic;
using PetApp;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Nana Sarpong
// PE13 - PetsApp
//Errors - none
// Bugs - none
// Professor Schuh
// 10/16/23


// Self-Graded on 10/24/23
//SCORE: 80/100
namespace PetApp
{
    // create an interface called ICat to hold member methods
    public interface ICat
    {
        void Eat(); // the cat eating
        void Play(); // the cat playing
        void Scratch(); // the cat scratching
        void Purr(); // the cat purring 
    }

    // create an abstract class for common functionality between multiple pet classes
    public abstract class Pet
    {
        private string name; // field for name of pet
        public int age; // field for age of pet

        public string Name
        {
            get
            {
                return name; // return the name of the pet by reading
            }
            set
            {
                name = value; // set value of name by writing
            }

        }
        // common eating functionality between pets 
        public abstract void Eat();

        // common playing functionality between pets
        public abstract void Play();

        // common "going to the vet" vunctionality for pets 
        public abstract void GotoVet();


        // default constructor
        public Pet()
        {

        }
        // constructors for name and age 
        public Pet(string name, int age)
        {
            this.name = name; // initialize name
            this.age = age; // initialize age
        }

    }

    // create an interface to be used for multiple classes if need be called Dog
    // set member methods for dogs
    public interface IDog
    {

        void Eat(); // functionality of eating
        void Play(); // functionality of playing
        void Bark(); // functionality of barking
        void NeedWalk(); // functionality of going for a walk
        void GotoVet(); // functionality of going to the vet 

    }

    // define class as the child class to Pet and derived from ICAt interface
    // override the member methods to allow our child class Cat to use them plus it's own personal methods 
    public class Cat : Pet, ICat
    {
        // override to allow specificity for eating 
        public override void Eat()
        {
            Console.WriteLine(this.Name + " Meow! Tasty!"); //phrase
        }

        // override to allow specificity for playing 
        public override void Play()
        {
            Console.WriteLine(this.Name + "Meow! Where's my ball of string?"); //phrase
        }

        // basic member method for putting 
        public void Purr()
        {
            Console.WriteLine(this.Name + " Purrrrrrrrrrrrrr"); //phrase
        }

        // basic member method for scratching
        public void Scratch()
        {
            Console.WriteLine(this.Name + "Meoooooooooooowwwwwww"); //phrase
        }

        // override to allow specificity for going to the vet 
        public override void GotoVet()
        {
            Console.WriteLine(this.Name + " HISSSSS! NO! I REFUSE!"); //phrase
        }

        // default cat constructor
        public Cat()
        {

        }

    }

    // child class called Dog to derive methods from Pet class and derive from interface 
    public class Dog : Pet, IDog
    {
        public string license; // license for dogs

        // override to allow specificity for eating
        public override void Eat()
        {
            Console.WriteLine(this.Name + "Woof! Boy am I hungry");
        }

        // override to allow specificity for playing
        public override void Play()
        {
            Console.WriteLine(this.Name + " Woof! Hey Owner! Let's play fetch!");
        }

        // basic member method for barking
        public void Bark()
        {
            Console.WriteLine(this.Name + " Woof Woof!");
        }


        // basic member method for walking
        public void NeedWalk()
        {
            Console.WriteLine(this.Name + " Woof! I need to go run!");
        }

        // override to allow specificity for going to the vet
        public override void GotoVet()
        {
            Console.WriteLine(this.Name + " BARK! BARK! NO! I DON'T WANNA GO!");
        }

        // constructor holding variables for the name, license, and age and using the Pet constructor to call and set these fields 
        public Dog(string szLicense, string szName, int nAge) : base(szName, nAge)
        {
            this.license = szLicense; // declare
            this.Name = szName; // declare
            this.age = nAge; // declare

        }
    }
    // class to hold my list of pets in
    public class Pets
    {
        // create public lists of my Pets (Dogs and Cats)
        public List<Pet> petList = new List<Pet>();

        // implement a string-based indexer in order to access the elements in our Pet List
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

        // return number of pets in pet list
        public int Count
        {
            get
            {
                return petList.Count;
            }
        }

        // add pet to pet list
        public void Add(Pet pet)
        // - 5 (forgot the if statements)
        {
            if (pet != null)
            {
                petList.Add(pet);
            }

        }

        // remove a pet from pet list 
        public void Remove(Pet pet)
        {
            // - 5 (forgot the if statements)
            if (pet != null) 
            {
                petList.Remove(pet);
            }
            
        }

        // remove at a specific area in pet list
        public void RemoveAt(int petEl)
        {
            petList.RemoveAt(petEl);
        }

    }




}
// Create new insatnces of our pets and create a for loop to see if we get a dog, a cat, or neither
// Add the pets we get to out list to generate responses based on the pet chosen
internal class Program
{
    // new instances of class objects 
    // randomly displays a prompt based on selected method
    // Errors: Method isn't randomized
    static void Main(string[] args)
    {


        Pet thisPet = null; // declare a pet
        Dog dog = null; // declare a dog
        Cat cat = null; // declare a cat
        IDog iDog = null; // name out interface IDog
        ICat iCat = null; // name our interface ICat

        Pets pets = new Pets(); // create our list
        Random rand = new Random();


        // loop through 50 times
        for (int i = 0; i <= 50; i++)
        {
            // 1 in 10 chance of adding an animal
            if (rand.Next(1, 11) == 1)
            {
                if (rand.Next(0, 2) == 0)
                {
                    // add a dog

                    Console.WriteLine("You've Bought a Dog!");

                    Console.Write("Dog's License: ");
                    string dogLicense = Console.ReadLine();

                    Console.Write("Dog's Name: ");
                    string dogName = Console.ReadLine();

                    Console.Write("Dog's Age: ");
                    int dogsAge = Convert.ToInt32(Console.ReadLine());

                    dog = new Dog(dogLicense, dogName, dogsAge);
                    // pets.Add(dog);
                    thisPet = dog;
                }
                else
                {
                    // else add a cat
                    Console.WriteLine("You've Bought a Cat!");
                    cat = new Cat();
                    Console.WriteLine("Cat's Name: ");
                    cat.Name = Console.ReadLine();

                    Console.WriteLine("Cat's Age: ");
                    cat.age = Convert.ToInt32(Console.ReadLine());
                    //pets.Add(cat);
                    thisPet = cat;

                }

                pets.Add(thisPet);
            }
            else
            {
                // choose a random pet from pets and choose a random activity for the pet to do
                int petEl = rand.Next(0, pets.Count);
                thisPet = pets[petEl];


                if (thisPet == null)
                {
                    continue;
                }

                // added from solution code: - 5
                if (thisPet.GetType() == typeof(Pet))
                {
                    iCat = (ICat)thisPet;

                    int nAction = rand.Next(0, 4);
                    switch (nAction)
                    {
                        case 0:
                            iCat.Eat();
                            break;
                        case 1:
                            iCat.Play();
                            break;
                        case 2:
                            iCat.Purr();
                            break;
                        case 3:
                            iCat.Scratch();
                            break;

                    }
                }
                // added from solution code: - 5
                else
                {
                    iDog = (IDog)thisPet;
                    int nAction = rand.Next(0, 5);

                    switch (nAction)
                    {
                        case 0:
                            iDog.Eat();
                            break;
                        case 1:
                            iDog.Play();
                            break;
                        case 2:
                            iDog.Bark();
                            break;
                        case 3:
                            iDog.NeedWalk();
                            break;
                        case 4:
                            iDog.GotoVet();
                            break;
                    }

                }

            }
        }


    }
}





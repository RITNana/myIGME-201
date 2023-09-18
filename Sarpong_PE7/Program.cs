using System;
using System.IO;


namespace Madlibs
{
    class Program
    {
        // Nana Sarpong
        // PE7
       /* Practice working with strings, lists, and input/output to create a Mad Libs game.
         Using predetermined narratives stored in a text file, gather information from the user to generate a complete story.*/
       // Errors - Yes or No input is not case insensitive
        static void Main(string[] args)
        {
            int numLibs = 0; // number of madlibs
            int cntr = 0; // counter
            int nChoice = 0; // choice number

            string finalStory = ""; // final output of what the mad lib story can be
            string userName; // the user input
            string resultString; // finaly story made into string

            bool bValid = false;


            while (!bValid)
            {
                Console.WriteLine("Do you wish to play Mad Libs? Yes or No?");
                string choice = Console.ReadLine();
              //  choice = choice.ToLower();
                if (choice != "Yes" && choice  != "No")
                {
                    Console.WriteLine("Try Again"); // will ask user to input again until valid answer
                }
                else if (choice == "No") {
                    Console.WriteLine("Goodbye!"); // close program
                    return;
                }
                else if (choice == "Yes") // run entire program
                {
                    StreamReader input;

                    // open the template file to count how many MadLibs it contains
                    input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");





                    string line = null;
                    while ((line = input.ReadLine()) != null) // line chosen is based on user inout
                    {
                        ++numLibs;
                    }

                    // close it
                    input.Close(); // closes the document 


                    // only allocate as many strings as there are Mad Libs
                    string[] madLibs = new string[numLibs];

                    // read the Mad Libs into the array of strings
                    input = new StreamReader("c:\\templates\\MadLibsTemplate.txt");

                    line = null;
                    while ((line = input.ReadLine()) != null)
                    {
                        // set this array element to the current line of the template file
                        madLibs[cntr] = line;

                        // replace the "\\n" tag with the newline escape character
                        madLibs[cntr] = madLibs[cntr].Replace("\\n", "\n");

                        ++cntr;
                    }

                    input.Close();


                    // prompting for use input
                    Console.Write("Enter your name: ");
                    userName = Console.ReadLine(); // reads user input

                    Console.Write("Select a story between 1 - " + madLibs.Length + ": ");
                    nChoice = int.Parse(Console.ReadLine()) - 1; // parses user input as an integer



                    // prompt the user for which Mad Lib they want to play (nChoice)

                    // split the Mad Lib into separate words
                    string[] words = madLibs[nChoice].Split(' ');
                    // Console.Write(words);
                    foreach (string word in words)
                    {
                        //  Console.WriteLine(word);


                        // if word is a placeholder
                        if (word[0] == '{')
                        {
                            string replaceWord = word.Replace("{", "").Replace("}", "").Replace("_", " ");
                            // prompt the user for the replacement
                            Console.WriteLine("Input a {0}: ", replaceWord);
                            // and append the user response to the result string
                            finalStory += Console.ReadLine();

                        }
                        // else append word to the result string
                        else
                        {
                            finalStory += word;
                        }
                        finalStory += " "; // adds spacing to mad libs words
                    }
                    Console.WriteLine(finalStory);
                   // resultString = finalStory;



                }
            } 


        }





    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BinaryTreeVisualizer;

namespace BTree
{
    public partial class BTreeForm : Form
    {
        public BTreeForm()
        {
            try
            {
                // Mozilla/4.0 (compatible; MSIE 7.0; Windows NT 6.2; WOW64; Trident / 7.0; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.30729; .NET CLR 3.5.30729; wbx 1.0.0)
                Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\\WOW6432Node\\Microsoft\\Internet Explorer\\MAIN\\FeatureControl\\FEATURE_BROWSER_EMULATION",
                    true);
                key.SetValue(Application.ExecutablePath.Replace(Application.StartupPath + "\\", ""), 11001, Microsoft.Win32.RegistryValueKind.DWord);
                key.Close();
            }
            catch
            {
            }

            InitializeComponent();

            this.randomButton.Click += new EventHandler(RandomButton__Click);
            this.unbalancedButton.Click += new EventHandler(UnbalancedButton__Click);
            this.primedButton.Click += new EventHandler(PrimedButton__Click);
            this.button1.Click += new EventHandler(Exercise1__Click);
            this.button2.Click += new EventHandler(Exercise2__Click);
            this.button3.Click += new EventHandler(Exercise3__Click);
            this.button4.Click += new EventHandler(Exercise4__Click);
            this.button5.Click += new EventHandler(Exercise5__Click);
            this.button6.Click += new EventHandler(Exercise6__Click);
            this.button7.Click += new EventHandler(Exercise7__Click);
            this.exitButton.Click += new EventHandler(ExitButton__Click);

            // give the BTree class objects access to Form1
            BTree.bTreeForm = this;
        }

        private void ExitButton__Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RandomButton__Click(object sender, EventArgs e)
        {
            // load a tree with random numbers
            BTree root = null;
            BTree node;
            Random random = new Random();

            this.richTextBox.Clear();

            for (int i = 0; i < 10; ++i)
            {
                node = new BTree(random.Next(100), root);

                if (i == 0)
                {
                    root = node;
                }
            }

            this.richTextBox.Text += "\nAscending order:";
            BTree.TraverseAscending(root);

            this.richTextBox.Text += "\nDescending order:";
            BTree.TraverseDescending(root);


            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void UnbalancedButton__Click(object sender, EventArgs e)
        {
            // load a tree in data-ascending order, 
            // which will cause it to be unbalanced and poor-performing
            BTree root = null;
            BTree node;

            this.richTextBox.Clear();

            for (int i = 0; i < 10; ++i)
            {
                node = new BTree(i, root);

                if (i == 0)
                {
                    root = node;
                }
            }

            this.richTextBox.Text += "\n";
            BTree.TraverseAscending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void PrimedButton__Click(object sender, EventArgs e)
        {
            // Prime a tree to hold alphabetical information

            this.richTextBox.Clear();

            BTree node = null;
            BTree root = null;
            
            node = new BTree("M", null);
            root = node;

            node = new BTree("F", root);
            node = new BTree("C", root);
            node = new BTree("B", root);
            node = new BTree("A", root);
            node = new BTree("E", root);
            node = new BTree("D", root);

            node = new BTree("J", root);
            node = new BTree("I", root);
            node = new BTree("H", root);
            node = new BTree("G", root);
            node = new BTree("L", root);
            node = new BTree("K", root);

            node = new BTree("P", root);
            node = new BTree("O", root);
            node = new BTree("N", root);
            node = new BTree("T", root);
            node = new BTree("S", root);
            node = new BTree("R", root);
            node = new BTree("Q", root);

            node = new BTree("W", root);
            node = new BTree("V", root);
            node = new BTree("U", root);
            node = new BTree("X", root);
            node = new BTree("Y", root);
            node = new BTree("Z", root);

            this.richTextBox.Text += "\n";            
            BTree.TraverseAscending(root);

            this.richTextBox.Text += "\n";
            BTree.TraverseDescending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void Exercise1__Click(object sender, EventArgs e)
        {
            // Exercise #1
            // insert 30 random numbers between 1 and 51

            BTree root = null;
            BTree node;
            Random random = new Random();

            this.richTextBox.Clear();

            // Your code here
            for (int i = 0; i < 30; i++)
            {
                node = new BTree(random.Next(1, 52), root);

                if(i == 0)
                {
                    root = node;
                }
            }

            


            this.richTextBox.Text += "\n";

            BTree.TraverseAscending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void Exercise2__Click(object sender, EventArgs e)
        {
            // Exercise #2
            // prime the tree for numbers between 1 and 51
            // with 7 optimally distributed data points (setting isData = false) 
            // then insert 30 random numbers between 1 and 51

            BTree root = null;
            BTree node;
            Random random = new Random();

            this.richTextBox.Clear();


            // Your code here

            //           25
            //      12         37
            //   6    18    31    43

            node = new BTree(25, root, false);
            root = node;
            node = new BTree(12, root, false);
            node = new BTree(37, root, false);
            node = new BTree(6, root, false);
            node = new BTree(18, root, false);
            node = new BTree(31, root, false);
            node = new BTree(43, root, false);


            for (int i = 0; i < 30; ++i)
            {
                node = new BTree(random.Next(1, 52), root);
            }

            this.richTextBox.Text += "\n";

            BTree.TraverseAscending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void Exercise3__Click(object sender, EventArgs e)
        {
            // Exercise #3
            // insert 15 random uppercase strings

            BTree root = null;
            BTree node;
            Random random = new Random();

            this.richTextBox.Clear();

            

            // Your code here


            string[] words = { "John", "Jeff", "Bobby", "Wasabi", "Joke", "Rice", "Cat", "Dog", "Mouse", 
                "Rat", "Turtle", "Naruto", "Sasuke", "Jill", "Cake" };

            for(int i = 0; i < 15; i++)
            {
                string word = words[random.Next(words.Length)].ToUpper();
                if (root == null)
                {
                    root = new BTree(word, null); // Create root if it's null
                }
                else
                {
                    node = new BTree(word, root); // Function to insert nodes into the BTree
                }

            }
              

            this.richTextBox.Text += "\n";

            

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void Exercise4__Click(object sender, EventArgs e)
        {
            // Exercise #4
            // prime the tree using the code in Button3_Click()
            // then insert the 15 random uppercase strings from Exercise #3

            this.richTextBox.Clear();

            BTree node = null;
            BTree root = null;
            Random random = new Random();

            // Your code here
            // Naruto = 6
            // Turtle = 6
            // Sasuke = 6
            // Wasabi = 6
            // Bobby = 5
            // Mouse = 5
            // John = 4
            // Joke  = 4
            // Jeff = 4
            // Rice = 4
            // Jill = 4
            // Cake = 4
            // Cat = 3
            // Dog = 3
            // rat = 3

            node = new BTree("M", null);
            root = node;

            node = new BTree("F", root, false);
            node = new BTree("C", root, false );
            node = new BTree("B", root, false);
            node = new BTree("A", root, false);
            node = new BTree("E", root, false);
            node = new BTree("D", root, false);

            node = new BTree("J", root, false);
            node = new BTree("I", root, false);
            node = new BTree("H", root, false);
            node = new BTree("G", root, false);
            node = new BTree("L", root, false);
            node = new BTree("K", root  , false);

            node = new BTree("P", root, false);
            node = new BTree("O", root, false);
            node = new BTree("N", root, false);
            node = new BTree("T", root, false   );
            node = new BTree("S", root, false);
            node = new BTree("R", root  , false);
            node = new BTree("Q", root, false);

            node = new BTree("W", root, false);
            node = new BTree("V", root, false);
            node = new BTree("U", root, false);
            node = new BTree("X", root, false);
            node = new BTree("Y", root, false);
            node = new BTree("Z", root, false);

            string[] words = { "John", "Jeff", "Bobby", "Wasabi", "Joke", "Rice", "Cat", "Dog", "Mouse",
                "Rat", "Turtle", "Naruto", "Sasuke", "Jill", "Cake" };

            for (int i = 0; i < 15; i++)
            {
                string word = words[random.Next(words.Length)].ToUpper();
                if (root == null)
                {
                    root = new BTree(word, null); // Create root if it's null
                }
                else
                {
                    node = new BTree(word, root); // Function to insert nodes into the BTree
                }

            }




            this.richTextBox.Text += "\nAsecnding";
                BTree.TraverseAscending(root);

                this.richTextBox.Text += "\nDescending";
                BTree.TraverseDescending(root);

                VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
            }
        

        private void Exercise5__Click(object sender, EventArgs e)
        {
            // Exercise #5
            // use the code in Button3_Click to add the 26 letters to the tree
            // then remove nodes "C", "I" and "A" 
            // using this code to remove each node:
            //     // create new freestanding node for "C"
            //     nodeToDelete = new BTree("C", null);
            //     BTree.DeleteNode(nodeToDelete, root);
            // add the newline and call BTree.TraverseAscending() after each delete

            this.richTextBox.Clear();

            BTree node = null;
            BTree nodeToDelete = null;
            BTree root = null;

            // Your code here
            node = new BTree("M", null);
            root = node;

            node = new BTree("F", root, false);
            node = new BTree("C", root, false);
            node = new BTree("B", root, false);
            node = new BTree("A", root, false);
            node = new BTree("E", root, false);
            node = new BTree("D", root, false);

            node = new BTree("J", root, false);
            node = new BTree("I", root, false);
            node = new BTree("H", root, false);
            node = new BTree("G", root, false);
            node = new BTree("L", root, false);
            node = new BTree("K", root, false);

            node = new BTree("P", root, false);
            node = new BTree("O", root, false);
            node = new BTree("N", root, false);
            node = new BTree("T", root, false);
            node = new BTree("S", root, false);
            node = new BTree("R", root, false);
            node = new BTree("Q", root, false);

            node = new BTree("W", root, false);
            node = new BTree("V", root, false);
            node = new BTree("U", root, false);
            node = new BTree("X", root, false);
            node = new BTree("Y", root, false);
            node = new BTree("Z", root, false);


          
            nodeToDelete = new BTree("C", null);
            BTree.DeleteNode(nodeToDelete, root);

            this.richTextBox.Text += "\n";
            BTree.TraverseAscending(root);

            nodeToDelete = new BTree("I", null);
            BTree.DeleteNode(nodeToDelete, root);

            this.richTextBox.Text += "\n";
            BTree.TraverseAscending(root);

         
            nodeToDelete = new BTree("A", null);
            BTree.DeleteNode(nodeToDelete, root);

            this.richTextBox.Text += "\n";
            BTree.TraverseAscending(root);



            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void Exercise6__Click(object sender, EventArgs e)
        {
            // Exercise #6
            // there are operator overloads to compare 2 BTree objects for BTree.data being string or int
            // enhance the overloads to support the Person object and compare using Person.age using:                
            //     if (a.data.GetType() == typeof(Person))


            // create at least 15 new Person objects which correspond to members of your family
            // insert them into the tree starting with yourself
            this.richTextBox.Clear();

            BTree node = null;
            BTree root = null;

            // the Person class is defined below
           // Person person = null;

            // Your code here
            Person[] familyMembers = new Person[]
            {
               

                new Person("Me", 19),
                new Person("Mom", 48),
                new Person("Sister", 16),
                new Person("Dad", 58),
                new Person("Uncle Mens", 64),
                new Person("Cousin Sarah", 23),
                new Person("Aunty Joyce", 49),
                new Person("Cousin Daniel", 21),
                new Person("Uncle Kwaku", 53),
                new Person("Aunty Nana Ama", 45),
                new Person("Cousin Omena", 25),
                new Person("Cousin Akua", 28),
                new Person("Cosuin Babe", 27),
                new Person("Aunty Esther", 43),
                new Person("Cousin TK", 29)
            };

            foreach (Person person in familyMembers)
            {
                if (root == null)
                {
                    root = new BTree(person, null); // Create root if it's null
                }
                else
                {
                    node = new BTree(person, root); // Function to insert nodes into the BTree based on age
                }
            }

            this.richTextBox.Text += "\n";
            BTree.TraverseAscending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        }

        private void Exercise7__Click(object sender, EventArgs e)
        {
            // Exercise #7
            // given the age range of people in Exercise #6, 
            // prime the tree with nodes containing Person objects (set isData = false for the seed nodes)
            // containing the optimal ages to balance the tree
            this.richTextBox.Clear();

            BTree node = null;
            BTree root = null;

            // the Person class is defined below
            //  Person person = null;

            // Your code here
            node = new BTree("29", null);
            root = node;

            node = new BTree("21", root, false);
            node = new BTree("53", root, false);
            node = new BTree("19", root, false);
            node = new BTree("28", root, false);
            node = new BTree("45", root, false);
            node = new BTree("58", root, false);

            node = new BTree("16", root, false);
            node = new BTree("27", root, false);
            node = new BTree("48", root, false);
            node = new BTree("64", root, false);
            node = new BTree("23", root, false);
            node = new BTree("25", root, false);

            node = new BTree("43", root, false);
            node = new BTree("49", root, false);

            this.richTextBox.Text += "\n";
            BTree.TraverseAscending(root);

            VisualizeBinaryTree visualizeBinaryTree = new VisualizeBinaryTree(root);
        } 
    } 
}

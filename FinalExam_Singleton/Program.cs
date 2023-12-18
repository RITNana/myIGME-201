using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Linq.Expressions;



namespace FinalExam_Singleton
{   // Nana Sarpong
    // Final Exam - Question 6

    // Create a singleton class
    // Create a filepath that will hold our JSON data
    // build the following properties that will create our JSON data
    public class PlayerSettingsManager
    {
        // create one instance for the singleton class
        private static PlayerSettingsManager instance = new PlayerSettingsManager();

        // create a private field that will hold our path file, only accessible within class
        private string settingFilePath = "c:/temp/player_settings.json";

        // return the instance 
        public static PlayerSettingsManager GetInstance()
        {
            return instance;
        }

        // Allow only one instance of the class by making the constructor 
        private PlayerSettingsManager()
        {

        }

        // save our JSON data by creating our object and converting it into JSON string
        // Create the file, write the necessary information, and close it, our file path will go to the JSON conversion
        public void SaveSettings(PlayerSettings settings)
        {
            string serializedStrings = JsonConvert.SerializeObject(settings);
            File.WriteAllText(settingFilePath, serializedStrings);
        }

        // if the file path exists, read the content of our object and return the conversion of the JSON striong back into object
        // if it doesn't, return null
        public PlayerSettings LoadSettings()
        {
            if(File.Exists(settingFilePath))
            {
                string serializedStrings = File.ReadAllText(settingFilePath);
                return JsonConvert.DeserializeObject<PlayerSettings>(serializedStrings);
            } else
            {
                return null;
            }
        }


    }
    // Class that holds our fields for the player
    public class PlayerSettings
    {
        public string player_name { get; set; }
        public string level { get; set; }
        public string hp {  get; set; }
        public string[] inventory { get; set; }
        public string licenseKey {  get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // getting the ONLY instance of PlayerSettingsManager
            PlayerSettingsManager settingsManager = PlayerSettingsManager.GetInstance();

            // Createw our PlayerSettings settings object with the necessary information
            PlayerSettings settings = new PlayerSettings
            {
                player_name = "dschuh",
                level = "4",
                hp = "99",
                inventory = new string[] { "spear", "water bottle", "hammer", "sonic screwdriver", "cannonball", "wood",
                    "Scooby snack", "Hydra", "poisonous potato", "dead bush", "repair powder" },
                licenseKey = "DFGU99-1454"

            };
            // save these settings for object
            settingsManager.SaveSettings(settings);

            // load our settings which will then be loaded into the file path we created
            PlayerSettings loadedSettings = settingsManager.LoadSettings();
            if( loadedSettings != null )
            {
                Console.WriteLine("Player Settings Loaded: ");
                Console.WriteLine($"Player Name: {loadedSettings.player_name}");
                Console.WriteLine($"Player Level: {loadedSettings.level}");
                Console.WriteLine($"Player Health: {loadedSettings.hp}");
                Console.WriteLine($"Player Inventory: {loadedSettings.inventory}");
                Console.WriteLine($"Player License Key: {loadedSettings.licenseKey}");
            } else
            {
                Console.WriteLine("No saved settings found");
            }
            Console.ReadLine();


        }
    }
}


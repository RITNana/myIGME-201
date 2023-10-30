using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Nana Sarpong
// Unit Test 2
// 4.	Convert this schUML to C#
// No errors

/*namespace Unit_Test_2_Codes
{
     // Questions 4-7

// create an interface as a contract for my different classes
    public interface PhoneInterface
    {
        void Answer(); // method to Answer the phone
        void MakeCall(); // method to make a call
        void HangUp(); // method to hang up the phone 

    }
// Nana Sarpong
// abstract class for a phone
// no errors 
    public abstract class Phone
    {
        private string phoneNumber; // field member phone number
        public string address; // field member address

        public string PhoneNumber
        {
            get
            {
                return phoneNumber; // get the value of the phone number string
            }
            set
            {
               phoneNumber = value; // set the value of the phone number string 
            }
        }

        // Connect the phone with a defined signature
        // No errors 
        public abstract void Connect();

        // Disconnect phone with a defined signature
        // no errors
        public abstract void Disconnect(); 

    }

// Nana Sarpong
// create child derived class that inherits phone and phone interface
// no errors 

    public class RotaryPhone : Phone, PhoneInterface
    {

        // call Answer method from interface PhoneInterface
        public void Answer()
        {
            
        }

        // call MakeCall method from PhoneInterface
        public void MakeCall()
        {

        }

        // Call HnagUp method from Phone Interface
        //no errors
        public void HangUp()
        {

        }

        // Override abstract Connect method to create own values for Rotary phone 
        public override void Connect()
        {

        }

        // Override abstract Disconnect method to create own values for Rotary phone 
        public override void Disconnect()
        {

        }

        // Nana Sarpong
         // create child derived class that inherits phone and phone interface
         // no errors 

        public class PushButtonPhone : Phone, PhoneInterface
        {
            
             // call Answer method from interface PhoneInterface
            public void Answer()
            {

            }

            // call MakeCall method from PhoneInterface
            public void MakeCall()
            {

            }

            public void HangUp()
            public void HangUp()
            {

            }

            // Override abstract Connect method to create own values for Rotary phone 
            public override void Connect()
            {

            }

            // Override abstract Disconnect method to create own values for Rotary phone 
            public override void Disconnect()
            {

            }
        }

// Nana Sarpong
// create child derived class that inherits phone and phone interface
// no errors 
        public class Tardis : RotaryPhone
        {
            
            private bool sonicScrewDriver;
            private byte whichDoctorWho;
            private string femaleSideKick;
            public double exteriorSurfaceArea;
            public double interiorVolume;


            public byte WhichDrWho
            {
                get
                {
                    return this.whichDoctorWho;
                }

            }


            public string FemaleSideKick
            {
                get
                {
                    return femaleSideKick;
                }
            }

            public void TimeTravel()
            {

            }

            
            // Overload the boolean operators ==, !=, <, >, <= and >= 
          // for the Tardis class such that whichDrWho is used to compare Tardis objects

            // write the logic so that the 10th Doctor (whichDrWho == 10) is greater than any other numbered Dr Who

            public static bool operator ==(Tardis tardis1,  Tardis tardis2)
            {
               if (tardis1.whichDoctorWho == 10)
                {
                    return tardis1.WhichDrWho > tardis2.whichDoctorWho;
                } 

                return (tardis1.whichDoctorWho ==  tardis2.whichDoctorWho);
                
            }

            public static bool operator !=(Tardis tardis1,  Tardis tardis2)
            {
                if (tardis1.whichDoctorWho == 10)
                {
                    return tardis1.WhichDrWho > tardis2.whichDoctorWho;
                }

                return (tardis1.whichDoctorWho != tardis2.whichDoctorWho);
            }

            public static bool operator <(Tardis tardis1, Tardis tardis2)
            {
                if (tardis1.whichDoctorWho == 10)
                {
                    return tardis1.WhichDrWho > tardis2.whichDoctorWho;
                }
                return (tardis1.whichDoctorWho < tardis2.whichDoctorWho);
            }

            public static bool operator >(Tardis tardis1, Tardis tardis2)
            {
                if (tardis1.whichDoctorWho == 10)
                {
                    return tardis1.WhichDrWho > tardis2.whichDoctorWho;
                }

                return (tardis1.whichDoctorWho > tardis2.whichDoctorWho);
            }

            public static bool operator <=(Tardis tardis1, Tardis tardis2)
            {
                if (tardis1.whichDoctorWho == 10)
                {
                    return tardis1.WhichDrWho > tardis2.whichDoctorWho;
                }
                return (tardis1.whichDoctorWho <= tardis2.whichDoctorWho);
            }

            public static bool operator >=(Tardis tardis1, Tardis tardis2)
            {
                if (tardis1.whichDoctorWho == 10)
                {
                    return tardis1.WhichDrWho > tardis2.whichDoctorWho;
                }
                return (tardis1.whichDoctorWho >= tardis2.whichDoctorWho);
            }





            public class PhoneBooth : PushButtonPhone 
            {
                private bool superMan;
                public double costPerCall;
                public bool phoneBook;

                public bool SuperMane { get; }
                

                public void OpenDoor()
                {

                }

                public void CloseDoor()
                {

                }


            } 

          //  Nana Sarpong
          //  Call our two classes too objects and their methods
           // no errors

            internal class Question4
            {
                // create class objects of Tardis and PhoneBooth and call their functions 
                // with the MyMethod() param using the interface and typeof

               static void Main(string[] args)
                {
                    

                  /*  Tardis tardis = new Tardis();
                    PhoneBooth phoneBooth = new PhoneBooth();

                    UsePhone(tardis);
                    UsePhone(phoneBooth); 
                }


            // Without changing the signature of UsePhone(), 
           // add the code to the UsePhone() method to call OpenDoor() if it's a PhoneBooth object 
          //  and TimeTravel() if it's a Tardis object.
                static void UsePhone(object obj)
                {
                    PhoneInterface phoneInterface = (PhoneInterface)obj;
                    phoneInterface.MakeCall();
                    phoneInterface.HangUp();

                    if (obj.GetType() == typeof(Tardis)) 
                    {
                        Tardis tardis = (Tardis)obj;
                        tardis.TimeTravel();
                    } else
                    {
                        PhoneBooth phoneBooth = (PhoneBooth)obj;
                        phoneBooth.OpenDoor();
                    }
                   
                } 
            }
        } 
    }

} */


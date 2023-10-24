using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Unit_Test_2_Codes.RotaryPhone;

namespace Unit_Test_2_Codes
{

    public interface PhoneInterface
    {
        void Answer();
        void MakeCall();
        void HangUp();

    }

    public abstract class Phone
    {
        private string phoneNumber;
        public string address;

        public string PhoneNumber
        {
            get
            {
                return phoneNumber;
            }
            set
            {
               phoneNumber = value;
            }
        }

        public abstract void Connect();


        public abstract void Disconnect();

    }

    public class RotaryPhone : Phone, PhoneInterface
    {
        public void Answer()
        {

        }

        public void MakeCall()
        {

        }

        public void HangUp()
        {

        }

        public override void Connect()
        {

        }

        public override void Disconnect()
        {

        }

        public class PushButtonPhone : Phone, PhoneInterface
        {
            public void Answer()
            {

            }

            public void MakeCall()
            {

            }

            public void HangUp()
            {

            }

            public override void Connect()
            {

            }

            public override void Disconnect()
            {

            }
        }

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

            public static bool operator ==(Tardis tardis1,  Tardis tardis2)
            {
               
                return (tardis1.whichDoctorWho ==  tardis2.whichDoctorWho);
                
            }

            public static bool operator !=(Tardis tardis1,  Tardis tardis2)
            {
                return (tardis1.whichDoctorWho != tardis2.whichDoctorWho);
            }

            public static bool operator <(Tardis tardis1, Tardis tardis2)
            {
                return (tardis1.whichDoctorWho < tardis2.whichDoctorWho);
            }

            public static bool operator >(Tardis tardis1, Tardis tardis2)
            {
                
                return (tardis1.whichDoctorWho > tardis2.whichDoctorWho);
            }

            public static bool operator <=(Tardis tardis1, Tardis tardis2)
            {
                return (tardis1.whichDoctorWho <= tardis2.whichDoctorWho);
            }

            public static bool operator >=(Tardis tardis1, Tardis tardis2)
            {
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

            internal class Program
            {
                static void Main(string[] args)
                {

                }
            }
        }
    }

}


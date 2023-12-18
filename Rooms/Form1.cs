using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoomsLib;

namespace Rooms
{
    
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();

            // Create a ListView control
            ListView listView = new ListView();
            listView.View = View.Details;
            listView.Columns.Add("Room Numbers", 120);

            // Get the generated room numbers from the class library
            var roomNumbers = RoomList.GenerateRoomNumbers();

            // Add room numbers to the ListView
            foreach (var room in roomNumbers)
            {
                listView.Items.Add(room.ToString());
            }

            // Add the ListView to the form
            this.Controls.Add(listView);
        }
    }
}


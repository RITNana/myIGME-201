using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PeopleLib;
using PeopleAppGlobals;

namespace EditPerson
{
    public partial class PersonEditForm : Form
    {

        public Person formPerson;

        public PersonEditForm(Person person, Form parentForm)
        {
            InitializeComponent();

          //  foreach (Control control in this.Controls)
          foreach(Control control in this.detailsTabPage.Controls)
            {
                control.Tag = false;
            }

            if (parentForm != null)
            {
                this.Owner = parentForm;
                this.CenterToParent();
            }

            this.formPerson = person;

            // all form configuration should be done first
            // before working with form's data
            this.okButton.Enabled = false;

            this.nameText.Validating += new CancelEventHandler(TxtBoxEmpty__Validating);
            this.emailText.Validating += new CancelEventHandler(TxtBoxEmpty__Validating);
            this.ageText.Validating += new CancelEventHandler(TxtBoxEmpty__Validating);
            this.specText.Validating += new CancelEventHandler(TxtBoxEmpty__Validating);
            this.gpaText.Validating += new CancelEventHandler(TxtBoxEmpty__Validating);
            this.licText.Validating += new CancelEventHandler(TxtBoxEmpty__Validating);


            this.nameText.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
            this.emailText.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
            this.ageText.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
            this.specText.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
            this.gpaText.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);
            this.licText.TextChanged += new EventHandler(TxtBoxEmpty__TextChanged);



            this.ageText.KeyPress += new KeyPressEventHandler(TxtBoxNum__KeyPress);
            this.gpaText.KeyPress += new KeyPressEventHandler(TxtBoxNum__KeyPress);
            this.licText.KeyPress += new KeyPressEventHandler(TxtBoxNum__KeyPress);

            this.typeComboBox.SelectedIndexChanged += new EventHandler(TypeComboBox__SelectedIndexChnaged);

            this.cancelButton.Click += new EventHandler(CancelButton__Click);
            this.okButton.Click += new EventHandler(OkButton__Click);

            // after all controls are configurated then we can manipulate the data
            this.nameText.Text = person.name;
            this.emailText.Text = person.email;
            this.ageText.Text = person.age.ToString();
            this.licText.Text = person.LicenseId.ToString();


            if (person.GetType() == typeof(Student))
            {
                this.typeComboBox.SelectedIndex = 0;

                Student student = (Student)person;
                this.gpaText.Text = student.gpa.ToString();
            } else
            {
                this.typeComboBox.SelectedIndex = 1;

                Teacher teacher = (Teacher)person;
                this.specText.Text = teacher.specialty.ToString();
            }


            this.Show();
        }


        private void OkButton__Click(Object sender, EventArgs e)
        {
            Student student = null;
            Teacher teacher = null;
            Person person = null;

            Globals.people.Remove(this.formPerson.email);

            if(this.typeComboBox.SelectedIndex == 0)
            {
                student = new Student();
                person = student;
            }
            else
            {
                teacher = new Teacher();
                person = teacher;
            }

            person.name = this.nameText.Text;
            person.email = this.emailText.Text;
            person.age = Convert.ToInt32(this.ageText.Text);
            person.LicenseId = Convert.ToInt32(this.licText.Text);

            if(person.GetType() == typeof(Student))
            {
                student.gpa = Convert.ToDouble(this.gpaText.Text);
            }
            else
            {
                teacher.specialty = this.specText.Text;
            }

            Globals.people[person.email] = person;

            if(this.Owner != null)
            {
                this.Owner.Enabled = true;
                this.Owner.Focus();

                IListView listView = (IListView)this.Owner;
                listView.PaintListView(person.email);
            }

            this.Close();
            this.Dispose();
        }


        private void CancelButton__Click(Object sender,  EventArgs e)
        {
            if(this.Owner != null)
            {
                this.Owner.Enabled = true;
                this.Owner.Focus();
            }

            this.Close();
            this.Dispose();
        }



        private void TypeComboBox__SelectedIndexChnaged(Object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            if (cb.SelectedIndex == 0)
            {
                this.specialtyLabel.Visible = false;
                this.specText.Visible = false;

                this.specText.Tag = true;

                this.gpaLabel.Visible = true;
                this.gpaText.Visible = true;

                this.gpaText.Tag = (this.gpaText.Text.Length > 0);
            } else
            {
                this.specialtyLabel.Visible = true;
                this.specText.Visible = true;

                this.gpaText.Tag = true;

                this.gpaLabel.Visible = false;
                this.gpaText.Visible = false;

                this.specText.Tag = (this.gpaText.Text.Length > 0);
            }

            ValidateAll();
        }




        private void TxtBoxEmpty__TextChanged(Object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text.Length == 0)
            {
                this.errorProvider.SetError(tb, "This field cannot be empty");
                tb.Tag = false;
            } else
            {
                this.errorProvider.SetError(tb, null);
                tb.Tag = true;
            }

            ValidateAll();
        }




        private void TxtBoxNum__KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (Char.IsDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                e.Handled = false;
                tb.Tag = true;
            }
            else
            {
                e.Handled |= true;

                if(tb == this.gpaText)
                {
                    if(e.KeyChar == '.' && tb.Text.Contains("."))
                    {
                        e.Handled = false;
                        tb.Tag = true;
                    }
                }
            }

            ValidateAll();
        }

        public void TxtBoxEmpty__Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text.Length == 0)
            {
                this.errorProvider.SetError(tb, "This field cannot be empty");
                e.Cancel = true;
                tb.Tag = false;
            }
            else
            {
                this.errorProvider.SetError(tb, "This field cannot be empty");
                e.Cancel = false;
                tb.Tag = true;
            }

            ValidateAll();
        }

        private void ValidateAll()
        {
            this.okButton.Enabled =
                (bool)this.nameText.Tag &&
                (bool)this.emailText.Tag &&
                (bool)this.ageText.Tag &&
                (bool)this.specText.Tag &&
                (bool)this.gpaText.Tag;
        }


        private void okButton__Clicked(object sender, EventArgs e)
        {

        }

        private void PersonEditForm_Load(object sender, EventArgs e)
        {

        }
    }
}

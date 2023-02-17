using System;
using System.Text;
using System.Text.Json;

namespace LoginPanelTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Person person = new Person
            {
                Name = nameTextBox.Text,
                Surname = surnameTextBox.Text,
                FatherName = fathernameTextBox.Text,
                Country = countryTextBox.Text,
                City = cityTextBox.Text,
                Phone = phoneTextBox.Text,
                BirthDay = birthdayDateTime.Value,
            };

            RadioButton maleRadioButton = this.maleRadioButton;
            RadioButton femaleRadioButton = this.femaleRadioButton;

            if (maleRadioButton.Checked)
            {
                person.Gender = "Male";
            }

            else
            {
                person.Gender = "Female";
            }

            var json = JsonSerializer.Serialize(person);
            File.WriteAllText($"{person.Name}{person.Surname}.json", json);
            MessageBox.Show("Person has been successfully added to the database.", "Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            string loadName = loadTextBox.Text;
            string json = File.ReadAllText($"{loadName}.json");
            Person person = JsonSerializer.Deserialize<Person>(json);

            nameTextBox.Text = person.Name;
            surnameTextBox.Text = person.Surname;
            fathernameTextBox.Text = person.FatherName;
            countryTextBox.Text = person.Country;
            cityTextBox.Text = person.City;
            phoneTextBox.Text = person.Phone;
            birthdayDateTime.Value = person.BirthDay;

            if (person.Gender == "Male")
            {
                maleRadioButton.Checked = true;
            }

            else
            {
                femaleRadioButton.Checked = true;
            }
        }
    }
}
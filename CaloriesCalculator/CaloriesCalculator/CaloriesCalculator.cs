using System;
using System.Windows.Forms;

namespace CaloriesCalculator
{
    public partial class CaloriesCalculator : Form
    {
        public CaloriesCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal weight = Convert.ToDecimal(txtWeight.Text);
            decimal heightOfFeet = Convert.ToDecimal(txtFeet.Text);
            decimal heightOfInch = Convert.ToDecimal(txtInches.Text);
            decimal age = Convert.ToDecimal(txtAge.Text);
            string sexName = cbxSex.SelectedItem == null ? string.Empty : cbxSex.SelectedItem.ToString();
            if (sexName.Equals(string.Empty))
                MessageBox.Show("请先选择性别");
            else
                txtCalories.Text = CalculateCalories(weight, heightOfFeet, heightOfInch, age, sexName).ToString();
        }

        public decimal CalculateCalories(decimal weight, decimal heightOfFeet, decimal heightOfInch, decimal age, string sexName)
        {
            //var personFactory = new PersonFactory(sexName);
            //var person = personFactory.CreatePerson(weight, heightOfFeet, heightOfInch, age);
            var person = new Person(weight, heightOfFeet, heightOfInch, age);
            return person.CalculateCalories(PersonFactors.GetPersonFactor(sexName));
        }

    }
}

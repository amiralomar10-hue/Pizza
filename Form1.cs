using System;
using System.Windows.Forms;

namespace FormPizza
{
    public partial class Form : System.Windows.Forms.Form
    {
        int Total = 0;
        public Form()
        {
            InitializeComponent();
        }
        private void GetTotalPrice()
        {
            Total = 0;
            if (radioButtonSm.Checked)
                Total = Total + 10;
            else if (radioButtonMe.Checked)
                Total = Total + 20;
            else if (radioButtonL.Checked)
                Total = Total + 30;
            if (radioButtonThin.Checked)
                Total = Total + 10;
            else if (radioButtonThink.Checked)
                Total = Total + 20;
            if (checkBoxChees.Checked)
                Total = Total + 5;
            if (checkBoxMushrooms.Checked)
                Total = Total + 5;
            if (checkBoxOlives.Checked)
                Total = Total + 5;
            if (checkBoxOnion.Checked)
                Total = Total + 5;
            if (checkBoxPeppers.Checked)
                Total = Total + 5;
            if (checkBoxTomatoes.Checked)
                Total = Total + 5;
            labelResultTotal.Text = $"${Total}";


        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            GetTotalPrice();
            labelResultSize.Text = "Small";

        }

        private char ToString(int total)
        {
            throw new NotImplementedException();
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

            GetTotalPrice();
            labelResultCrust.Text = "Thin Crust";

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            GetTotalPrice();
            if (checkBoxChees.Checked)
            {
                if (labelResultToppings.Text == "No Toppings")
                    labelResultToppings.Text = "Extra Chees";
                else
                    labelResultToppings.Text = labelResultToppings.Text + " , Extra Chees ";
            }

            else
            {
                if (labelResultToppings.Text == "Extra Chees")
                    labelResultToppings.Text = "No Toppings";
                else
                    labelResultToppings.Text = labelResultToppings.Text.Replace(" , Extra Chees ", "");

            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            GetTotalPrice();
            if (checkBoxTomatoes.Checked)
            {
                if (labelResultToppings.Text == "No Toppings")
                    labelResultToppings.Text = "Tomatoes";
                else
                    labelResultToppings.Text = labelResultToppings.Text + " , Tomatoes ";
            }


            else
            {
                if (labelResultToppings.Text == "Tomatoes")
                    labelResultToppings.Text = "No Toppings";
                else
                    labelResultToppings.Text = labelResultToppings.Text.Replace(" , Tomatoes ", "");

            }


        }

        private void radioButtonMe_CheckedChanged(object sender, EventArgs e)
        {
            GetTotalPrice();

            labelResultSize.Text = "Meduim";
        }

        private void radioButtonL_CheckedChanged(object sender, EventArgs e)
        {
            GetTotalPrice();
            labelResultSize.Text = "Larg";

        }

        private void radioButtonThink_CheckedChanged(object sender, EventArgs e)
        {
            GetTotalPrice();
            labelResultCrust.Text = "Think Crust";

        }

        private void checkBoxOnion_CheckedChanged(object sender, EventArgs e)
        {
            GetTotalPrice();
            if (checkBoxOnion.Checked)
            {
                if (labelResultToppings.Text == "No Toppings")
                    labelResultToppings.Text = "Onion";
                else
                    labelResultToppings.Text = labelResultToppings.Text + " , Onion ";
            }


            else
            {
                if (labelResultToppings.Text == "Onion")
                    labelResultToppings.Text = "No Toppings";
                else
                    labelResultToppings.Text = labelResultToppings.Text.Replace(" , Onion ", "");

            }

        }

        private void checkBoxMushrooms_CheckedChanged(object sender, EventArgs e)
        {
            GetTotalPrice();
            if (checkBoxMushrooms.Checked)
            {
                if (labelResultToppings.Text == "No Toppings")
                    labelResultToppings.Text = "Mushrooms";
                else
                    labelResultToppings.Text = labelResultToppings.Text + " , Mushrooms ";

            }


            else
            {
                if (labelResultToppings.Text == "Mushrooms")
                    labelResultToppings.Text = "No Toppings";
                else
                    labelResultToppings.Text = labelResultToppings.Text.Replace(" , Mushrooms ", "");

            }

        }

        private void checkBoxOlives_CheckedChanged(object sender, EventArgs e)
        {
            GetTotalPrice();
            if (checkBoxOlives.Checked)
            {
                if (labelResultToppings.Text == "No Toppings")
                    labelResultToppings.Text = "Olives";
                else
                    labelResultToppings.Text = labelResultToppings.Text + " , Olives ";

            }

            else
            {
                if (labelResultToppings.Text == "Olives")
                    labelResultToppings.Text = "No Toppings";
                else
                    labelResultToppings.Text = labelResultToppings.Text.Replace(" , Olives ", "");

            }
        }

        private void checkBoxPeppers_CheckedChanged(object sender, EventArgs e)
        {
            GetTotalPrice();
            if (checkBoxPeppers.Checked)
            {
                if (labelResultToppings.Text == "No Toppings")
                    labelResultToppings.Text = "Green Peppers";
                else
                    labelResultToppings.Text = labelResultToppings.Text + " , Green Peppers ";

            }
            else
            {
                if (labelResultToppings.Text == "Green Peppers")
                    labelResultToppings.Text = "No Toppings";
                else
                    labelResultToppings.Text = labelResultToppings.Text.Replace(", Green Peppers ", "");
            }
        }

        private void Form_Load(object sender, EventArgs e)
        {

            GetTotalPrice();
        }

        private void radioButtonIn_CheckedChanged(object sender, EventArgs e)
        {
            labelResultWhere.Text = "Eat In";
        }

        private void radioButtonOut_CheckedChanged(object sender, EventArgs e)
        {
            labelResultWhere.Text = "Take Out";

        }

        private void buttonOP_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confrim Order", "Confrim", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                MessageBox.Show("Order Placed Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                groupBoxCrustType.Enabled = false;
                groupBoxToppings.Enabled = false;
                groupBoxWhereToEat.Enabled = false;
                groupBoxSize.Enabled = false;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBoxCrustType.Enabled = true;
            groupBoxToppings.Enabled = true;
            groupBoxWhereToEat.Enabled = true;
            groupBoxSize.Enabled = true;
        }
    }
}

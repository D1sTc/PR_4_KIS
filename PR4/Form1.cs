using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PR4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxNaumber.SelectedIndexChanged += comboBoxNumber_SelectedIndexChanged;
            textDestination.Validating += textDestination_TextChanged;
            textFlightNumber.Validating += textFlightNumber_TextChanged;
            textFIO.Validating += textFIO_TextChanged;
            textDepartureDate.Validating += textDepartureDate_TextChanged;
        }

        class Group<T1, T2, T3, T4>
        {
            T1 val1 { get; set; }
            T2 val2 { get; set; }
            T3 val3 { get; set; }
            T4 val4 { get; set; }
            public Group(T1 val1, T2 val2, T3 val3, T4 val4)
            {
                this.val1 = val1;
                this.val2 = val2;
                this.val3 = val3;
                this.val4 = val4;
                GetInfo();
            }
            void GetInfo()
            {
                //Console.WriteLine($"Первое значение: {val1}, второе значение: {val2}.");
            }
        }

        private void ButtonAddaRequestToList_Click(object sender, EventArgs e)
        {
            string Destination = textDestination.Text;
            if (!string.IsNullOrEmpty(Destination))
            {
                try
                {

                    int count = Convert.ToInt16(textFlightNumber.Text);
                    ApplicationNumber.Add(Destination, count);
                    List<string> list = new List<string>(ApplicationNumber.Keys);
                    comboBoxNaumber.DataSource = list;
                }
                catch
                {
                    MessageBox.Show("Введены неверные значения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textDestination.Clear();
                    textFlightNumber.Clear();
                    textFIO.Clear();
                    textDepartureDate.Clear();
                }
            }
            else
            {
                MessageBox.Show("Вы не ввели пункт назначения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textDestination.Clear();
                textFlightNumber.Clear();
                textFIO.Clear();
                textDepartureDate.Clear();
            }
        }

        private void ButtonDeleteaRequestFromList_Click(object sender, EventArgs e)
        {
            if (comboBoxNaumber.SelectedItem != null)
            {
                string name = comboBoxNaumber.SelectedItem.ToString();
                ApplicationNumber.Remove(name);
                List<string> list = new List<string>(ApplicationNumber.Keys);
                comboBoxNaumber.DataSource = list;
            }
            else
            {
                MessageBox.Show("Вы не выбрали группу", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textDestination.Clear();
                textFlightNumber.Clear();
                textFIO.Clear();
                textDepartureDate.Clear();
            }
        }

        private void ButtonWithdrawRequest_Click(object sender, EventArgs e)
        {

        }

        private void ButtonWithdrawAllRequests_Click(object sender, EventArgs e)
        {

        }

        private void ButtonWithdrawList_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textDestination.Clear();
            textFlightNumber.Clear();
            textFIO.Clear();
            textDepartureDate.Clear();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearMenu_Click(object sender, EventArgs e)
        {
            Clear_Click(sender, e);
        }

        private void ExitMenu_Click(object sender, EventArgs e)
        {
            Exit_Click(sender, e);
        }

        Dictionary<string, int> ApplicationNumber = new Dictionary<string, int>()
        {
            ["1"] = 1,
        };
        Dictionary<string, int> ApplicationNumber2 = new Dictionary<string, int>()
        {
            ["1"] = 2,
        };
        Dictionary<string, int> ApplicationNumber3 = new Dictionary<string, int>()
        {
            ["1"] = 3,
        };
        Dictionary<string, int> ApplicationNumber4 = new Dictionary<string, int>()
        {
            ["1"] = 4,
        };
        private void comboBoxNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedState = comboBoxNaumber.SelectedItem.ToString();
            int counter = 0;
            if (ApplicationNumber.TryGetValue(selectedState, out counter)) textDestination.Text = counter.ToString();
            if (ApplicationNumber2.TryGetValue(selectedState, out counter)) textFlightNumber.Text = counter.ToString();
            if (ApplicationNumber3.TryGetValue(selectedState, out counter)) textFIO.Text = counter.ToString();
            if (ApplicationNumber4.TryGetValue(selectedState, out counter)) textDepartureDate.Text = counter.ToString();
        }

        private void textDestination_TextChanged(object sender, EventArgs e)
        {

        }

        private void textFlightNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void textFIO_TextChanged(object sender, EventArgs e)
        {

        }

        private void textDepartureDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
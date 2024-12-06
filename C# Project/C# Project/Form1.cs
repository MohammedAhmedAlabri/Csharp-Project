using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C__Project
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void prcBtn_Click(object sender, EventArgs e)
		{
			int Nopeople = Convert.ToInt16(peopleNum.Value);
			double dblmtotalfruit = 0;
			double dblmtotalveg = 0;
			double dblftotalfruit = 0;
			double dblftotalveg = 0;
			int Fcount =0, Mcount =0;
			double totalcups = 0;
			// gender arrray ========================================================================

			string strPg1 = Gbox1.SelectedItem.ToString();
			string strPg2 = Gbox2.SelectedItem.ToString();
			string strPg3 = Gbox3.SelectedItem.ToString();
			string strPg4 = Gbox4.SelectedItem.ToString();
			string strPg5 = Gbox5.SelectedItem.ToString();
			string strPg6 = Gbox6.SelectedItem.ToString();
			string strPg7 = Gbox7.SelectedItem.ToString();
			string strPg8 = Gbox8.SelectedItem.ToString();
			string strPg9 = Gbox9.SelectedItem.ToString();
			string strPg10 = Gbox10.SelectedItem.ToString();

			string[] StrGender = new string[10];

			StrGender[0] = strPg1;
			StrGender[1] = strPg2;
			StrGender[2] = strPg3;
			StrGender[3] = strPg4;
			StrGender[4] = strPg5;
			StrGender[5] = strPg6;
			StrGender[6] = strPg7;
			StrGender[7] = strPg8;
			StrGender[8] = strPg9;
			StrGender[9] = strPg10;

			// age array ========================================================================

			int intPa1 = Convert.ToInt16(Page1.Value);
			int intPa2 = Convert.ToInt16(Page2.Value);
			int intPa3 = Convert.ToInt16(Page3.Value);
			int intPa4 = Convert.ToInt16(Page4.Value);
			int intPa5 = Convert.ToInt16(Page5.Value);
			int intPa6 = Convert.ToInt16(Page6.Value);
			int intPa7 = Convert.ToInt16(Page7.Value);
			int intPa8 = Convert.ToInt16(Page8.Value);
			int intPa9 = Convert.ToInt16(Page9.Value);
			int intPa10 = Convert.ToInt16(Page10.Value);


			int[] intAge = new int[10];

			intAge[0] = intPa1;
			intAge[1] = intPa2;
			intAge[2] = intPa3;
			intAge[3] = intPa4;
			intAge[4] = intPa5;
			intAge[5] = intPa6;
			intAge[6] = intPa7;
			intAge[7] = intPa8;
			intAge[8] = intPa9;
			intAge[9] = intPa10;

			// how many females from each age group with total cup array ========================================================================
			int[] intFemalegroup = new int[14];
			double[] dblFFruit = { 1, 1.5, 1.5, 2, 2, 1.5, 1.5, 1.5, 1.5, 1.5, 1.5, 1.5, 1.5, 1.5 }; 
			double[] dblFVeg = { 1.5, 1.5, 2.5, 2.5, 2.5, 2.5, 2.5, 2.5, 2.5, 2, 2,2,2, 2};

			// how many males from each age group with total cup array ========================================================================
			int[] intMalegroup = new int[11];
			double[] dblMFruit = { 1, 1.5, 2, 2, 2, 2, 2, 2, 2, 2, 2 }; 
			double[] dblMVeg = { 1.5, 2, 3, 3.5, 3, 3, 3, 3, 3, 3, 3 };


			// calculate loop ========================================================================

			for (int intCounter = 0; intCounter < Nopeople; intCounter++)
			{
				// male calculate section ==========================================================================
				if (StrGender[intCounter] == "M")
				{
					Mcount++;
					if (intAge[intCounter] <= 5)
					{
						intMalegroup[0]++;
					}
					else if (intAge[intCounter] <= 10)
					{
						intMalegroup[1]++;
					}
					else if (intAge[intCounter] <= 15)
					{
						intMalegroup[2]++;
					}
					else if (intAge[intCounter] <= 20)
					{
						intMalegroup[3]++;
					}
					else if (intAge[intCounter] <= 25)
					{
						intMalegroup[4]++;
					}
					else if (intAge[intCounter] <= 30)
					{
						intMalegroup[5]++;
					}
					else if (intAge[intCounter] <= 35)
					{
						intMalegroup[6]++;
					}
					else if (intAge[intCounter] <= 40)
					{
						intMalegroup[7]++;
					}
					else if (intAge[intCounter] <= 45)
					{
						intMalegroup[8]++;
					}
					else if (intAge[intCounter] <= 50)
					{
						intMalegroup[9]++;
					}
					else if (intAge[intCounter] <= 55)
					{
						intMalegroup[10]++;
					}
					else
					{
					}
				}

				else if (StrGender[intCounter] == "F")
				{
					Fcount++;

					// Female calculate section ==========================================================================

					if (intAge[intCounter] <= 5)
					{
						intFemalegroup[0]++;

					}
					else if (intAge[intCounter] <= 10)
					{
						intFemalegroup[1]++;
					}
					else if (intAge[intCounter] <= 15)
					{
						intFemalegroup[2]++;
					}
					else if (intAge[intCounter] <= 20)
					{
						intFemalegroup[3]++;
					}
					else if (intAge[intCounter] <= 25)
					{
						intFemalegroup[4]++;
					}
					else if (intAge[intCounter] <= 30)
					{
						intFemalegroup[5]++;
					}
					else if (intAge[intCounter] <= 40)
					{
					
						intFemalegroup[6]++;
					}
					else if (intAge[intCounter] <= 45)
					{
						intFemalegroup[7]++;
					}
					else if (intAge[intCounter] <= 50)
					{
						intFemalegroup[8]++;
					}
					else if (intAge[intCounter] <= 55)
					{
						intFemalegroup[9]++;
					}
					else if (intAge[intCounter] <= 60)
					{
						intFemalegroup[10]++;
					}
					else if (intAge[intCounter] <= 65)
					{
						intFemalegroup[11]++;
					}
					else if (intAge[intCounter] <= 70)
					{
						intFemalegroup[12]++;
					}
					else if (intAge[intCounter] <= 75)
					{
						intFemalegroup[13]++;
					}
					else
					{

					}

				}

			}

			// to calculate total cups for each gender

			for (int x = 0; x < 14; x++)
			{
				dblftotalfruit += intFemalegroup[x] * dblFFruit[x];
				dblftotalveg += intFemalegroup[x] * dblFVeg[x];
			}

			for (int x = 0; x < 11; x++)
			{
				dblmtotalfruit += intMalegroup[x] * dblMFruit[x];
				dblmtotalveg += intMalegroup[x] * dblMVeg[x];
			}

			totalcups = (dblftotalfruit + dblftotalfruit) + (dblmtotalfruit + dblmtotalveg);

			txtDisplay.Text += "Total Fruits for Females: " + Convert.ToString(dblftotalfruit) + " cups" + Environment.NewLine;
			txtDisplay.Text += "Total Vegetables for Females: " + Convert.ToString(dblftotalveg) + " cups" + Environment.NewLine;
			txtDisplay.Text += "Total Fruits for Males: " + Convert.ToString(dblmtotalfruit) + " cups" + Environment.NewLine;
			txtDisplay.Text += "Total Vegetables for Males: " + Convert.ToString(dblmtotalveg) + " cups" + Environment.NewLine;
			txtDisplay.Text += "Total cups: " + Convert.ToString(totalcups) + " cups" + Environment.NewLine;

		}

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void label3_Click(object sender, EventArgs e)
		{

		}

        private void pictureBox17_Click(object sender, EventArgs e)
        {

        }

		private void checkBox2_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}

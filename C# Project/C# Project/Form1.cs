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

			double dblDailyFruit = 0;
			double dblDailyVeg = 0;


			// gender arrray
			string Pg1 = Gbox1.SelectedItem.ToString();
			string Pg2 = Gbox2.SelectedItem.ToString();
			string Pg3 = Gbox3.SelectedItem.ToString();
			string Pg4 = Gbox4.SelectedItem.ToString();
			string Pg5 = Gbox5.SelectedItem.ToString();
			string Pg6 = Gbox6.SelectedItem.ToString();
			string Pg7 = Gbox7.SelectedItem.ToString();
			string Pg8 = Gbox8.SelectedItem.ToString();
			string Pg9 = Gbox9.SelectedItem.ToString();
			string Pg10 = Gbox10.SelectedItem.ToString();

			string[] StrGender = new string[10];

			StrGender[0] = Pg1;
			StrGender[1] = Pg2;
			StrGender[2] = Pg3;
			StrGender[3] = Pg4;
			StrGender[4] = Pg5;
			StrGender[5] = Pg6;
			StrGender[6] = Pg7;
			StrGender[7] = Pg8;
			StrGender[8] = Pg9;
			StrGender[9] = Pg10;

			// age array

			int Pa1 = Convert.ToInt16(Page1.Value);
			int Pa2 = Convert.ToInt16(Page2.Value);
			int Pa3 = Convert.ToInt16(Page3.Value);
			int Pa4 = Convert.ToInt16(Page4.Value);
			int Pa5 = Convert.ToInt16(Page5.Value);
			int Pa6 = Convert.ToInt16(Page6.Value);
			int Pa7 = Convert.ToInt16(Page7.Value);
			int Pa8 = Convert.ToInt16(Page8.Value);
			int Pa9 = Convert.ToInt16(Page9.Value);
			int Pa10 = Convert.ToInt16(Page10.Value);


			int[] intAge = new int[10];

			intAge[0] = Pa1;
			intAge[1] = Pa2;
			intAge[2] = Pa3;
			intAge[3] = Pa4;
			intAge[4] = Pa5;
			intAge[5] = Pa6;
			intAge[6] = Pa7;
			intAge[7] = Pa8;
			intAge[8] = Pa9;
			intAge[9] = Pa10;



			for (int intCounter = 0; intCounter	< Nopeople; intCounter++)
			{
				if (StrGender[intCounter] == "M")
				{
					if (intAge[intCounter] <= 5)
					{
						dblDailyFruit = 1;
						dblDailyVeg = 1.5;
					}
					else if (intAge[intCounter] <= 10)
					{
						dblDailyFruit = 1.5;
						dblDailyVeg = 2;
					}
					else if (intAge[intCounter] <= 15)
					{
						dblDailyFruit = 2;
						dblDailyVeg = 3;
					}
					else if (intAge[intCounter] <= 20)
					{
						dblDailyFruit = 2;
						dblDailyVeg = 3.5;
					}
					else if (intAge[intCounter] <= 25)
					{
						dblDailyFruit = 2;
						dblDailyVeg = 3;
					}
					else if (intAge[intCounter] <= 30)
					{
						dblDailyFruit = 2;
						dblDailyVeg = 3;
					}
					else if (intAge[intCounter] <= 35)
					{
						dblDailyFruit = 2;
						dblDailyVeg = 3;
					}
					else if (intAge[intCounter] <= 40)
					{
						dblDailyFruit = 2;
						dblDailyVeg = 3;
					}
					else if (intAge[intCounter] <= 45)
					{
						dblDailyFruit = 2;
						dblDailyVeg = 3;
					}
					else if (intAge[intCounter] <= 50)
					{
						dblDailyFruit = 2;
						dblDailyVeg = 3;
					}
					else if (intAge[intCounter] <= 55)
					{
						dblDailyFruit = 2;
						dblDailyVeg = 3;
					}
					else
					{
						dblDailyFruit = 2;
						dblDailyVeg = 3; 
					}
				}
			}
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

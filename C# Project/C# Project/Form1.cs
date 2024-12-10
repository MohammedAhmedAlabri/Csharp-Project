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
            double dbltotalcups = 0;
			double dblRemainingcups = 0;
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

			int intPa1 = Convert.ToInt16(PersonAge1.Value);
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


			// =============================================================عشان نحسب كم شخص من كل مجموعة نخليهم يدخلوا فالأراي اللي بإسم ميل جروب مثلا
			// intMalegroup [0] = يساوي مجموع الأشخاص اللي عمرهم من 0 لحد 5
			// intMalegroup [1] = يساوي مجموع الأشخاص اللي عمرهم من 5 لحد 10
			// وكذا لحد ما يكتملوا
			int[] intMalegroup = new int[11];
			double[] dblMFruit = { 1, 1.5, 2, 2, 2, 2, 2, 2, 2, 2, 2 }; 
			double[] dblMVeg = { 1.5, 2, 3, 3.5, 3, 3, 3, 3, 3, 3, 3 };

			// how many females from each age group with total cup array ========================================================================
			int[] intFemalegroup = new int[14];
			double[] dblFFruit = { 1, 1.5, 1.5, 2, 2, 1.5, 1.5, 1.5, 1.5, 1.5, 1.5, 1.5, 1.5, 1.5 };
			double[] dblFVeg = { 1.5, 1.5, 2.5, 2.5, 2.5, 2.5, 2.5, 2.5, 2.5, 2, 2, 2, 2, 2 };

			// calculate loop ========================================================================

			for (int intCounter = 0; intCounter < Nopeople; intCounter++)
			{
				// male calculate section ==========================================================================
				if (StrGender[intCounter] == "M")
				{
					
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



			// Array to calculate cups per age group
			// السطر الأول للفواكه والثاني للخضروات
			double[,] dblMCupPerAgeGroup = new double[11,2];
			for (int x = 0; x < 11; x++)
			{
				dblMCupPerAgeGroup[x,0] = intMalegroup[x] * dblMFruit[x];
				dblMCupPerAgeGroup[x, 1] = intMalegroup[x] * dblMVeg[x];

			}

			double[,] dblFCupPerAgeGroup = new double[14,2];
			for (int x = 0; x < 14; x++)
			{
				dblFCupPerAgeGroup[x, 0] = intFemalegroup[x] * dblFFruit[x];
				dblFCupPerAgeGroup[x, 1] = intFemalegroup[x] * dblFVeg[x];

			}


			//عشان نحسب كم الكمية لكل فئة عمرية نسوي أراي نفس ملف الأكسل عشان كلما شخص يضيف كمية يحسبها بما يوافق الفئة العمرية
			// https://docs.google.com/spreadsheets/d/1_WYPxh6jFq5m11LdPwt9GanhzpiBGeS7/edit?usp=sharing&ouid=102816776279368103436&rtpof=true&sd=true

			double[,] dblmportion = new double[11,6];

			for (int x = 0; x < 11; x++)
			{				
					if (Banana_CB.Checked){dblmportion[x,0] = dblMCupPerAgeGroup[x,0] * 0.25;}
					if (Watermelon_CB.Checked) {dblmportion[x,1] = dblMCupPerAgeGroup[x,0] * 0.20;}
					if (Orange_CB.Checked){dblmportion[x,2] = dblMCupPerAgeGroup[x,0] * 0.20;}
					if (Potatoes_CB.Checked){dblmportion[x,3] = dblMCupPerAgeGroup[x,1] * 0.25;}
					if (Onion_CB.Checked) {dblmportion[x,4] = dblMCupPerAgeGroup[x,1] * 0.20;}
					if (Garlic_CB.Checked){dblmportion[x,5] = dblMCupPerAgeGroup[x,1] * 0.20;}
		
			};


			double[,] dblfportion = new double[14, 6];

			for (int x = 0; x < 14; x++)
			{
				if (Banana_CB.Checked) { dblfportion[x,0] = dblFCupPerAgeGroup[x, 0] * 0.25; }
				if (Watermelon_CB.Checked) { dblfportion[x,1] = dblFCupPerAgeGroup[x, 0] * 0.20; }
				if (Orange_CB.Checked) { dblfportion[x, 2] = dblFCupPerAgeGroup[x, 0] * 0.20; }
				if (Potatoes_CB.Checked) { dblfportion[x, 3] = dblFCupPerAgeGroup[x, 0] * 0.25; }
				if (Onion_CB.Checked) { dblfportion[x, 4] = dblFCupPerAgeGroup[x, 0] * 0.20; }
				if (Garlic_CB.Checked) { dblfportion[x, 5] = dblFCupPerAgeGroup[x,0] * 0.20; }

			};

			// total calculations 

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


			dbltotalcups = (dblftotalfruit + dblftotalveg) + (dblmtotalfruit + dblmtotalveg);


			// display section 
			for (int x = 0; x < 11; x++)
            {
				if (intMalegroup[x] > 0)
				{
					txtDisplay.Text += intMalegroup[x] + " number of People in this Age group get " + dblMCupPerAgeGroup[x,0] + " cup" + Environment.NewLine;
					txtDisplay.Text += dblmportion[x,0] + Environment.NewLine;
					txtDisplay.Text += dblmportion[x,1] + Environment.NewLine;
					txtDisplay.Text += dblmportion[x,2] + Environment.NewLine;
					txtDisplay.Text += "Male " + (dblRemainingcups = (dblmtotalfruit - (dblmportion[x,0] + dblmportion[x,1] + dblmportion[x,2]))) + Environment.NewLine;
				}
            };

			for (int x = 0; x < 14; x++)
			{
				if (intFemalegroup[x] > 0)
				{
					txtDisplay.Text += intFemalegroup[x] + " number of People in this Age group get " + dblFCupPerAgeGroup[x, 0] + " cup" + Environment.NewLine;
					txtDisplay.Text += dblfportion[x, 0] + Environment.NewLine;
					txtDisplay.Text += dblfportion[x, 1] + Environment.NewLine;
					txtDisplay.Text += dblfportion[x, 2] + Environment.NewLine;
					txtDisplay.Text += (dblRemainingcups = (dblftotalfruit - (dblfportion[x, 0] + dblfportion[x, 1] + dblfportion[x, 2]))) + Environment.NewLine;
				}
			};


			//if (StrGender[x] == "M")
			//{
			//	if (intAge[x] <= 5)
			//	{
			//                    dblCupPerAgeGroupM[x] = intMalegroup[x] * dblMFruit[x];

			//                }

			//		if (Banana_CB.Checked)
			//		{
			//			dblBananaPortion = dblmtotalfruit * 0.25;

			//		}
			//		if (Watermelon_CB.Checked)
			//		{
			//			dblWatermelonPortion = dblmtotalfruit * 0.20;

			//		}
			//		if (Orange_CB.Checked)
			//		{
			//			dblOrangePortion = dblmtotalfruit * 0.20;

			//		}
			//		if (Potatoes_CB.Checked)
			//		{
			//			dblPotatoesPortion = dblmtotalveg * 0.25;

			//		}
			//		if (Onion_CB.Checked)
			//		{
			//			dblOnionPortion = dblmtotalveg * 0.20;

			//		}
			//		if (Garlic_CB.Checked)
			//		{
			//			dblGarlicPortion = dblmtotalveg * 0.20;

			//		}


			//else if (intAge[x] <= 10)
			//               {
			//                   M10count++;
			//                   dblmtotalfruit += intMalegroup[x] * dblMFruit[x];
			//                   dblmtotalveg += intMalegroup[x] * dblMVeg[x];

			//                   if (Banana_CB.Checked)
			//                   {
			//                       dblBananaPortion = dblmtotalfruit * 0.25;

			//                   }
			//                   if (Watermelon_CB.Checked)
			//                   {
			//                       dblWatermelonPortion = dblmtotalfruit * 0.20;

			//                   }
			//                   if (Orange_CB.Checked)
			//                   {
			//                       dblOrangePortion = dblmtotalfruit * 0.20;

			//                   }
			//                   if (Potatoes_CB.Checked)
			//                   {
			//                       dblPotatoesPortion = dblmtotalveg * 0.25;

			//                   }
			//                   if (Onion_CB.Checked)
			//                   {
			//                       dblOnionPortion = dblmtotalveg * 0.20;

			//                   }
			//                   if (Garlic_CB.Checked)
			//                   {
			//                       dblGarlicPortion = dblmtotalveg * 0.20;

			//                   }

			//               }
			//}
			//}


			//for (int y = 0; y < Nopeople; y++)
			//{

			//	if (StrGender[y] == "M")
			//	{

			//	}
			//}
			//if (intAge[x] <= 10)
			//{
			//	M10count++;
			//                   dblmtotalfruit += intMalegroup[x] * dblMFruit[x];
			//                   dblmtotalveg += intMalegroup[x] * dblMVeg[x];

			//                   if (Banana_CB.Checked)
			//                   {
			//                       dblBananaPortion = dblmtotalfruit * 0.25;

			//                   }
			//                   if (Watermelon_CB.Checked)
			//                   {
			//                       dblWatermelonPortion = dblmtotalfruit * 0.20;

			//                   }
			//                   if (Orange_CB.Checked)
			//                   {
			//                       dblOrangePortion = dblmtotalfruit * 0.20;

			//                   }
			//                   if (Potatoes_CB.Checked)
			//                   {
			//                       dblPotatoesPortion = dblmtotalveg * 0.25;

			//                   }
			//                   if (Onion_CB.Checked)
			//                   {
			//                       dblOnionPortion = dblmtotalveg * 0.20;

			//                   }
			//                   if (Garlic_CB.Checked)
			//                   {
			//                       dblGarlicPortion = dblmtotalveg * 0.20;

			//                   }
			//               }




			//if (M5count > 0) 
			//{
			//             txtDisplay.Text += "Total Fruits for 5 year old Males: " + Convert.ToString(dblmtotalfruit) + " cups" + Environment.NewLine;
			//             txtDisplay.Text += "Total Vegetables for 5 year old Males: " + Convert.ToString(dblmtotalveg) + " cups" + Environment.NewLine;
			//             if (Banana_CB.Checked) 
			//	{
			//                 txtDisplay.Text += dblBananaPortion + " Cups of total Fruits should be Bananas" + Environment.NewLine;

			//             }
			//             if (Watermelon_CB.Checked)
			//             {
			//                 txtDisplay.Text += dblWatermelonPortion + " Cups of total Fruits should be Watermelon" + Environment.NewLine;


			//             }
			//             if (Orange_CB.Checked)
			//             {
			//                 txtDisplay.Text += dblOrangePortion + " Cups of total Fruits should be Oranges" + Environment.NewLine;


			//             }
			//             if (Potatoes_CB.Checked)
			//             {
			//                 txtDisplay.Text += dblPotatoesPortion + " Cups of total Vegetables should be Potatoes" + Environment.NewLine;


			//             }
			//             if (Onion_CB.Checked)
			//             {
			//                 txtDisplay.Text += dblOnionPortion + " Cups of total Vegetables should be Onion" + Environment.NewLine;


			//             }
			//             if (Garlic_CB.Checked)
			//             {
			//                 txtDisplay.Text += dblGarlicPortion + " Cups of total Vegetables should be Garlic" + Environment.NewLine;


			//             }
			//         }
			//		if (M10count > 0)
			//		{
			//			txtDisplay.Text += "Total Fruits for 10 year old Males: " + Convert.ToString(dblmtotalfruit) + " cups" + Environment.NewLine;
			//			txtDisplay.Text += "Total Vegetables for 10 year old Males: " + Convert.ToString(dblmtotalveg) + " cups" + Environment.NewLine;
			//			if (Banana_CB.Checked)
			//			{
			//				txtDisplay.Text += dblBananaPortion + " Cups of total Fruits should be Bananas" + Environment.NewLine;

			//			}
			//			if (Watermelon_CB.Checked)
			//			{
			//				txtDisplay.Text += dblWatermelonPortion + " Cups of total Fruits should be Watermelon" + Environment.NewLine;


			//			}
			//			if (Orange_CB.Checked)
			//			{
			//				txtDisplay.Text += dblOrangePortion + " Cups of total Fruits should be Oranges" + Environment.NewLine;


			//			}
			//			if (Potatoes_CB.Checked)
			//			{
			//				txtDisplay.Text += dblPotatoesPortion + " Cups of total Vegetables should be Potatoes" + Environment.NewLine;


			//			}
			//			if (Onion_CB.Checked)
			//			{
			//				txtDisplay.Text += dblOnionPortion + " Cups of total Vegetables should be Onion" + Environment.NewLine;


			//			}
			//			if (Garlic_CB.Checked)
			//			{
			//				txtDisplay.Text += dblGarlicPortion + " Cups of total Vegetables should be Garlic" + Environment.NewLine;


			//			}
			//		}

			//txtDisplay.Text += "Total Fruits for Females: " + Convert.ToString(dblftotalfruit) + " cups" + Environment.NewLine;
			//txtDisplay.Text += "Total Vegetables for Females: " + Convert.ToString(dblftotalveg) + " cups" + Environment.NewLine;
			//for (int intCounter = 0; intCounter < Nopeople; intCounter++)
			//{

			//	if (StrGender[intCounter] == "M")
			//	{
			//		if (intAge[intCounter] <= 5)
			//		{
			//			txtDisplay.Text += "Total Fruits for 5 year old Males: " + Convert.ToString(dblmtotalfruit) + " cups" + Environment.NewLine;


			//			if (Banana_CB.Checked)
			//			{
			//                         txtDisplay.Text += dblBananaPortion + " Cups of total Fruits should be Bananas" + Environment.NewLine;


			//                     }
			//                     if (Watermelon_CB.Checked)
			//			{
			//                         txtDisplay.Text += dblWatermelonPortion + " Cups of total Fruits should be Watermelon" + Environment.NewLine;


			//                     }
			//                     if (Orange_CB.Checked)
			//			{
			//                         txtDisplay.Text += dblOrangePortion + " Cups of total Fruits should be Oranges" + Environment.NewLine;


			//                     }
			//                     if (Potatoes_CB.Checked)
			//			{
			//                         txtDisplay.Text += dblPotatoesPortion + " Cups of total Vegetables should be Potatoes" + Environment.NewLine;


			//                     }
			//                     if (Onion_CB.Checked)
			//			{
			//                         txtDisplay.Text += dblOnionPortion + " Cups of total Vegetables should be Onion" + Environment.NewLine;


			//                     }
			//                     if (Garlic_CB.Checked)
			//			{
			//                         txtDisplay.Text += dblGarlicPortion + " Cups of total Vegetables should be Garlic" + Environment.NewLine;


			//                     }
			//                 }
			//	}
			//}

			//                     txtDisplay.Text += "Total Fruits for 5 year old Males: " + Convert.ToString(dblmtotalfruit) + " cups" + Environment.NewLine;
			//         if (Banana_CB.Checked)
			//         {
			//             txtDisplay.Text += dblBananaPortion + " Cups of total Fruits should be Bananas" + Environment.NewLine;
			//         }
			//         if (Watermelon_CB.Checked)
			//         {
			//             txtDisplay.Text += dblWatermelonPortion + " Cups of total Fruits should be Watermelon" + Environment.NewLine;

			//         }
			//         if (Orange_CB.Checked)
			//         {
			//             txtDisplay.Text += dblOrangePortion + " Cups of total Fruits should be Oranges" + Environment.NewLine;
			//         }
			//         txtDisplay.Text += "Total Vegetables for 5 year old Males: " + Convert.ToString(dblmtotalveg) + " cups" + Environment.NewLine;
			//if (Potatoes_CB.Checked)
			//         {
			//             txtDisplay.Text += dblPotatoesPortion + " Cups of total Vegetables should be Potatoes" + Environment.NewLine;
			//         }
			//         if (Onion_CB.Checked)
			//         {
			//             txtDisplay.Text += dblOnionPortion + " Cups of total Vegetables should be Onion" + Environment.NewLine;

			//         }
			//         if (Garlic_CB.Checked)
			//         {
			//             txtDisplay.Text += dblGarlicPortion + " Cups of total Vegetables should be Garlic" + Environment.NewLine;
			//         }
			//txtDisplay.Text += "Total cups: " + Convert.ToString(totalcups) + " cups" + Environment.NewLine;

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
            //for visibilty
            Gbox2.Visible = false;
            Gbox3.Visible = false;
            Gbox4.Visible = false;
            Gbox5.Visible = false;
            Gbox6.Visible = false;
            Gbox7.Visible = false;
            Gbox8.Visible = false;
            Gbox9.Visible = false;
			Gbox10.Visible = false;


			Page2.Visible = false;
			Page3.Visible = false;
            Page4.Visible = false;
            Page5.Visible = false;
            Page6.Visible = false;
            Page7.Visible = false;
            Page8.Visible = false;
            Page9.Visible = false;
            Page10.Visible = false;

			person2Label.Visible = false;
            person3Label.Visible = false;
            person4Label.Visible = false;
            person5Label.Visible = false;
            person6Label.Visible = false;
            person7Label.Visible = false;
            person8Label.Visible = false;
            person9Label.Visible = false;
            person10Label.Visible = false;

			genderLabel2.Visible = false;
			ageLabel2.Visible = false;

        }

        private void peopleNum_ValueChanged(object sender, EventArgs e)
        {
            int Nopeople = Convert.ToInt16(peopleNum.Value);

            // Update visibility
            for (int x = 0; x < Nopeople; x++)
            {
				if (x == 1)
				{
					person2Label.Visible = true;
					Page2.Visible = true;
					Gbox2.Visible = true;
				}
				if (x == 2)
				{
					person3Label.Visible = true;
					Page3.Visible= true;
					Gbox3.Visible = true;
				}
				if (x == 3)
				{
					person4Label.Visible = true;
					Page4.Visible= true;
					Gbox4.Visible = true;
				}
				if (x == 4)
				{
					person5Label.Visible = true;
					Page5.Visible= true;
					Gbox5.Visible = true;
				}
				if (x == 5)
				{
					person6Label.Visible = true;
					genderLabel2.Visible = true;
					ageLabel2.Visible = true;
					Page6.Visible= true;
					Gbox6.Visible = true;
				}
				if (x == 6)
				{
					person7Label.Visible = true;
					Page7.Visible= true;
					Gbox7.Visible = true;
				}
				if (x == 7)
				{
					person8Label.Visible = true;
					Page8.Visible= true;
					Gbox8.Visible = true;
				}
				if (x == 8)
				{
					person9Label.Visible = true;
					Page9.Visible= true;
					Gbox9.Visible = true;
				}
				if (x == 9)
				{
					person10Label.Visible = true;
					Page10.Visible= true;
					Gbox10.Visible = true;
				}

            }

            for (int x = 11; x > Nopeople; x--)
            {
				if (x == 2)
				{
					person2Label.Visible = false;
					Page2.Visible = false;
					Gbox2.Visible = false;
				}
				if (x == 3)
				{
                    person3Label.Visible = false;
                    Page3.Visible = false;
					Gbox3.Visible = false;
				}
				if (x == 4)
				{
					person4Label.Visible = false;
					Page4.Visible = false;
					Gbox4.Visible = false;
				}
				if (x == 5)
				{
					person5Label.Visible = false;
					Page5.Visible = false;
					Gbox5.Visible = false;
				}
				if (x == 6)
				{
					person6Label.Visible = false;
                    genderLabel2.Visible = false;
                    ageLabel2.Visible = false;
                    Page6.Visible = false;
					Gbox6.Visible = false;
				}
				if (x == 7)
				{
					person7Label.Visible = false;
					Page7.Visible = false;
					Gbox7.Visible = false;
				}
				if (x == 8)
				{
					person8Label.Visible = false;
					Page8.Visible = false;
					Gbox8.Visible = false;
				}
				if (x == 9)
				{
					person9Label.Visible = false;
					Page9.Visible = false;
					Gbox9.Visible = false;
				}
				if (x == 10)
				{
					person10Label.Visible = false;
					Page10.Visible = false;
					Gbox10.Visible = false;
				}


            }

        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

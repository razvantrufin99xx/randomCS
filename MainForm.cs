/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/15/2024
 * Time: 12:10 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace findRandoms
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		Random m = new Random(100);
		string s = "";
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		void Button1Click(object sender, EventArgs e)
		{
			for(int i = 0 ; i<100 ;i++)
			{
				s+= m.Next(1,100).ToString() + ",";
			}
			textBox1.Text  = s;
		}
		
		/*
		 //output
		 
		 96,16,67,90,36,94,71,61,35,15,96,54,38,50,97,48,89,99,39,4,11,38,89,96,50,84,91,65,17,62,11,79,51,50,56,10,86,53,47,74,28,50,34,59,63,86,36,3,91,44,3,79,30,86,22,59,27,70,40,51,4,7,44,73,5,17,3,88,93,88,62,37,53,64,76,60,5,30,34,64,49,88,73,73,59,32,50,65,28,97,83,17,13,95,70,21,6,60,55,46,83,48,9,4,82,66,26,65,10,61,54,96,36,76,3,15,33,71,15,73,67,38,60,96,6,45,24,57,94,55,55,45,75,87,81,1,79,70,90,92,6,85,55,66,44,86,80,37,93,55,88,34,46,81,78,45,87,13,98,37,42,69,70,55,7,10,21,49,94,2,36,63,80,22,67,82,83,93,53,19,65,87,63,40,67,21,98,93,9,36,14,67,72,54,51,36,15,99,60,34,66,32,42,91,20,25,54,25,15,96,62,93,60,79,72,55,6,31,88,85,11,27,40,58,88,68,91,27,71,31,67,83,34,19,53,33,45,72,21,42,67,74,79,13,74,20,7,92,81,95,30,84,12,74,24,39,92,83,4,51,33,28,53,83,29,78,60,42,27,39,11,34,10,46,19,36,48,27,84,68,62,99,45,75,1,83,72,59,94,14,41,61,68,69,9,39,21,96,83,96,60,65,66,43,85,96,74,65,56,87,91,65,99,36,89,34,82,78,82,46,7,1,47,13,97,49,66,40,38,79,15,51,43,87,8,96,34,2,90,5,9,7,4,7,23,76,62,33,80,74,56,43,14,38,90,59,18,53,45,36,31,34,28,76,73,40,22,12,28,92,1,81,87,77,37,99,97,40,90,21,87,33,60,63,23,72,38,6,97,48,79,80,56,54,74,75,79,27,34,82,55,50,5,88,74,75,55,36,2,90,62,77,63,25,49,97,74,65,53,1,3,17,14,80,14,21,25,33,4,62,21,71,7,8,66,37,29,72,89,48,17,2,4,8,86,2,17,32,6,77,1,15,74,34,80,39,36,25,75,53,51,22,33,40,70,90,71,56,58,12,68,3,76,6,83,2,13,7,93,12,4,92,28,27,61,7,97,73,27,28,2,5,96,36,97,95,68,64,38,95,31,61,73,94,9,98,38,68,50,79,26,30,31,63,49,58,94,7,78,64,93,97,29,31,10,64,6,40,9,88,33,49,69,98,81,43,19,33,19,63,68,29,24,48,2,72,74,34,86,39,1,62,85,74,2,33,32,43,84,44,93,98,60,61,46,76,60,32,82,7,39,61,88,16,95,65,74,80,29,38,90,71,54,69,88,70,64,95,97,48,11,76,49,74,69,69,69,62,2,26,12,42,51,79,1,39,74,69,78,37,58,52,15,46,54,22,45,90,73,76,12,65,35,35,96,62,13,14,46,26,95,13,78,4,27,48,21,74,69,49,95,95,17,60,89,59,62,3,20,48,25,78,89,26,14,46,8,17,83,38,26,60,23,52,41,46,73,12,20,7,1,71,22,24,80,17,48,74,45,38,1,11,94,98,2,18,24,53,89,80,40,4,90,31,23,35,72,65,20,44,85,51,82,13,47,54,57,65,45,96,97,33,72,46,37,16,66,25,51,24,23,20,22,39,67,97,80,91,1,45,45,83,55,1,52,50,28,81,51,47,61,58,8,92,82,7,32,45,93,8,69,48,14,96,22,65,29,43,46,50,74,65,65,99,52,15,78,71,94,87,87,84,73,5,63,64,13,29,56,60,65,36,97,93,76,96,69,59,79,86,22,84,36,2,73,95,93,8,41,68,28,60,51,7,20,85,75,10,34,57,53,99,87,86,84,38,68,71,24,55,45,20,92,8,66,4,48,72,31,67,71,5,88,88,32,6,85,90,73,91,22,60,25,22,33,22,97,50,17,35,27,22,84,85,24,9,68,43,41,17,37,4,78,66,85,49,12,98,54,79,53,77,98,33,34,85,94,70,75,44,6,98,55,96,40,50,20,4,64,24,37,42,50,57,54,19,81,59,37,83,10,98,95,38,81,50,24,51,51,39,14,97,68,96,12,38,48,82,26,36,30,9,34,31,42,11,27,42,78,15,4,36,34,91,34,7,4,18,15,90,27,69,52,26,11,40,74,54,45,17,70,98,34,2,54,2,65,65,95,71,23,81,72,37,35,77,64,76,62,5,35,31,68,35,9,61,56,9,21,3,37,73,96,62,45,5,3,33,38,33,42,39,22,44,68,45,96,16,91,33,76,97,91,41,82,40,31,98,92,93,46,57,44,92,34,49,85,11,91,30,75,31,39,30,63,96,9,24,67,64,65,41,17,88,27,39,82,55,80,6,74,4,41,44,87,85,94,29,10,19,59,85,24,61,57,45,59,61,78,85,31,7,31,28,29,5,40,56,66,95,67,30,30,86,56,71,90,94,43,77,2,80,15,48,5,79,18,55,31,81,80,21,77,94,74,67,73,13,16,82,46,38,63,14,52,30,55,37,6,86,54,64,19,1,84,51,92,82,24,49,87,84,26,84,16,46,52,36,12,89,98,78,79,61,32,63,17,1,96,75,24,80,50,45,27,16,3,77,11,24,74,90,89,66,95,61,13,78,98,6,77,20,25,16,87,76,85,58,68,21,34,91,86,49,26,7,35,80,58,99,44,75,25,88,15,9,88,13,65,71,51,39,3,90,97,4,56,34,57,50,31,44,9,89,90,83,4,40,40,88,27,32,21,98,62,3,94,37,2,79,88,72,92,97,70,94,88,95,51,22,51,1,23,8,69,1,66,36,97,31,5,48,73,77,44,19,19,4,29,95,9,20,33,78,62,59,52,12,20,96,94,8,89,19,38,27,10,13,29,61,36,59,39,70,74,40,99,16,53,51,75,85,67,55,13,32,68,45,45,11,49,55,16,2,37,96,59,55,39,18,10,6,74,67,60,50,80,62,4,23,60,36,58,69,21,10,41,35,6,7,59,64,68,19,13,80,44,38,34,77,80,44,76,36,42,70,11,99,94,63,51,6,41,22,51,13,97,47,80,27,56,24,49,33,59,45,38,56,54,79,7,42,29,26,42,16,60,23,27,51,99,41,40,42,55,53,24,46,68,1,83,96,58,7,22,56,95,44,76,96,33,54,46,16,57,10,76,15,79,36,53,74,20,30,28,16,84,7,77,6,22,91,87,53,95,10,84,22,5,85,20,16,46,31,19,45,94,24,85,45,76,9,67,33,48,9,77,28,79,6,72,88,66,70,75,42,66,92,20,47,26,55,11,93,16,37,29,89,12,82,21,60,21,33,30,14,24,55,6,87,33,56,43,98,14,32,50,75,55,77,78,3,5,39,20,22,97,73,18,12,80,87,17,96,85,12,67,34,41,62,18,12,87,33,14,70,13,12,80,83,86,53,34,35,4,18,56,82,13,8,16,51,38,93,7,46,39,46,14,2,64,17,34,93,59,67,16,71,25,50,10,86,93,34,25,27,53,82,92,67,56,85,21,34,46,66,74,93,26,68,31,67,97,78,19,69,20,41,75,37,3,84,57,63,98,30,58,4,68,80,92,56,53,47,46,79,96,1,47,93,92,22,46,56,19,43,88,15,15,55,8,13,8,56,64,72,28,57,35,17,9,70,25,46,75,74,14,51,33,39,73,19,93,81,44,80,39,1,44,56,41,43,88,14,72,80,49,97,83,74,52,39,65,31,85,23,97,99,81,45,29,38,82,76,82,89,19,26,12,83,33,27,13,79,75,65,81,12,73,95,26,17,68,59,87,34,53,63,96,22,83,39,20,99,28,3,61,13,31,83,62,23,85,99,41,26,26,86,55,20,41,85,26,85,19,12,70,24,89,48,36,56,30,89,99,94,7,14,51,73,5,69,80,90,34,3,31,68,19,61,9,67,8,77,80,98,14,35,80,16,33,37,24,83,48,6,93,95,99,47,19,13,35,82,15,71,5,36,52,16,80,2,6,28,40,69,48,52,10,2,81,72,33,36,40,67,46,97,42,28,10,35,69,72,42,95,32,26,62,9,93,77,82,64,35,31,32,95,43,79,57,41,86,97,65,47,80,99,42,47,26,8,93,24,7,46,33,34,85,45,37,23,89,1,9,4,89,68,1,9,36,50,54,63,71,68,49,71,7,95,15,32,83,16,83,85,83,58,58,89,97,98,11,98,42,34,51,86,89,62,57,13,98,34,12,76,54,31,53,38,97,62,27,90,30,5,40,74,18,24,21,31,10,11,12,37,39,55,22,37,18,62,82,44,38,3,34,50,5,7,32,53,6,21,92,36,71,21,69,37,94,77,69,66,41,27,3,88,22,74,37,98,10,17,21,35,80,83,52,27,71,90,70,11,91,68,26,89,19,75,66,19,85,84,43,41,92,17,3,12,99,45,28,30,70,34,44,88,1,57,55,88,68,42,65,4,7,59,74,73,1,14,70,46,9,18,13,25,74,79,43,64,80,41,27,26,63,40,41,58,25,37,89,61,21,77,50,44,20,39,34,34,42,30,11,86,75,81,22,52,21,19,15,21,15,91,9,28,15,39,41,66,18,17,49,64,24,9,26,31,67,69,6,35,46,9,22,50,30,41,51,82,19,89,37,6,22,69,46,29,69,23,29,80,98,67,16,26,80,47,63,66,55,91,84,52,14,80,75,7,69,58,97,74,88,59,48,29,79,44,42,55,63,97,61,45,40,25,36,78,93,96,70,83,77,84,27,27,5,85,91,42,94,40,59,11,25,54,91,40,20,86,46,37,5,9,4,58,30,39,12,88,45,96,13,73,87,15,97,5,32,22,25,94,52,1,60,24,38,50,21,86,34,95,58,7,50,34,79,69,80,68,96,65,73,4,96,97,27,86,23,11,57,87,9,98,62,52,84,4,48,79,21,79,19,26,55,49,38,7,23,54,36,28,24,63,25,59,21,49,4,63,97,51,27,11,29,46,87,60,44,98,49,75,22,2,48,17,47,48,48,48,59,20,64,69,74,30,63,45,73,4,31,36,99,84,82,69,52,9,96,9,62,78,62,24,6,60,6,23,16,8,13,73,2,56,4,77,87,58,36,99,82,42,86,41,68,14,75,37,19,78,64,38,51,39,85,81,58,40,64,15,24,41,30,66,91,58,35,44,80,6,81,94,73,97,27,20,91,21,56,92,85,68,4,37,43,74,22,62,70,23,20,48,94,22,76,42,13,21,50,10,78,32,57,13,96,70,64,54,13,66,90,37,84,72,29,55,37,92,23,17,36,72,73,58,86,34,99,52,21,85,7,70,71,46,14,53,12,90,41,72,10,67,50,4,33,82,64,23,92,22,5,21,97,33,74,7,58,99,27,63,70,13,34,28,60,20,65,38,58,76,43,46,52,50,7,69,23,69,25,4,70,77,60,99,80,85,72,39,72,7,95,13,64,78,3,97,34,23,44,14,17,26,64,17,78,58,69,47,26,5,83,88,74,23,92,93,52,34,47,74,47,27,66,52,80,30,82,74,48,10,35,1,26,12,86,45,14,44,21,23,17,25,13,67,23,7,38,41,85,10,45,1,75,70,66,90,59,13,36,48,75,95,99,17,70,83,63,63,36,48,80,9,13,24,58,22,15,99,29,73,92,41,88,39,64,35,25,56,45,96,85,1,8,73,47,21,26,95,97,40,44,75,5,37,29,37,87,52,12,44,75,60,83,62,56,34,7,60,53,35,59,8,18,40,63,79,1,40,76,37,95,19,2,89,30,17,37,51,10,28,48,73,44,1,21,25,17,45,17,14,14,66,43,62,81,37,58,65,74,50,36,48,75,74,49,57,58,94,33,40,97,56,50,25,87,85,64,17,19,38,62,55,24,63,24,30,76,39,9,93,59,71,76,59,92,99,98,69,52,64,66,23,13,77,16,58,16,18,75,95,72,41,47,37,88,80,25,12,51,19,80,20,86,40,80,27,79,90,33,87,87,94,64,54,71,40,43,46,47,65,15,58,64,13,21,18,25,40,71,12,75,86,18,34,83,47,36,72,96,89,78,25,85,87,9,78,76,92,66,49,37,78,64,85,5,22,55,74,20,63,2,40,20,21,12,1,77,31,71,24,4,70,50,58,86,89,73,76,5,43,41,33,73,23,75,97,22,32,30,61,91,62,53,34,87,39,6,64,76,8,1,46,22,42,45,66,29,7,98,15,49,79,70,77,22,69,66,96,46,14,79,45,2,10,32,41,18,16,70,48,84,10,1,96,42,95,11,31,77,9,69,15,33,15,13,13,92,75,13,19,73,9,18,62,29,55,45,13,11,4,49,13,37,51,30,39,79,73,35,27,58,35,20,38,45,64,12,86,96,19,49,42,4,52,74,76,91,38,67,86,50,98,21,74,59,56,78,82,84,73,34,19,41,86,60,39,89,79,17,65,43,58,16,91,55,7,10,85,77,54,47,41,7,49,76,60,14,45,78,88,85,30,2,23,85,30,2,18,91,35,87,12,21,3,43,92,82,29,19,53,47,93,5,31,26,92,13,91,10,1,25,44,2,29,79,14,56,93,6,25,5,92,93,42,66,35,20,5,6,84,77,84,26,26,42,92,26,70,96,93,18,10,8,91,11,44,11,92,23,30,36,89,24,94,48,55,99,62,65,90,72,9,86,26,24,40,18,75,86,87,87,85,96,13,7,95,84,3,32,23,25,28,81,75,48,87,61,32,78,86,93,63,6,6,21,10,24,81,67,70,27,36,6,36,42,50,93,11,88,52,70,96,31,43,66,45,27,11,77,36,78,86,97,1,94,25,80,90,92,97,72,4,36,61,96,88,22,46,33,98,93,51,44,26,16,96,32,63,40,75,83,13,4,31,91,40,39,6,42,18,69,4,19,90,80,67,61,70,46,78,24,80,78,79,43,28,42,71,84,97,92,18,51,17,15,60,99,5,69,56,49,16,5,16,29,90,32,53,45,49,36,62,17,61,52,3,35,25,88,64,98,67,22,44,25,52,53,2,76,21,68,57,1,90,29,8,76,62,51,53,95,89,26,35,62,31,1,89,65,12,25,75,16,6,58,81,94,60,90,76,37,31,76,24,81,78,61,26,33,44,26,72,73,36,68,9,41,86,82,94,52,63,36,64,95,92,41,95,33,47,14,16,72,74,16,65,13,3,54,83,70,74,57,22,85,53,2,80,37,49,40,9,78,96,25,74,94,12,29,88,37,65,93,85,31,11,1,99,21,4,96,39,32,98,25,77,7,15,78,43,91,61,59,84,7,6,37,75,50,41,70,1,74,66,46,5,81,71,90,75,53,3,59,33,53,2,76,80,72,47,67,79,33,85,96,76,7,9,79,26,73,25,49,79,34,95,65,65,52,20,95,36,24,4,90,88,2,27,32,6,29,57,4,4,74,90,67,88,69,70,98,72,92,65,3,28,54,80,99,57,36,11,29,52,51,32,56,30,95,9,74,80,77,73,96,17,21,46,5,43,28,77,96,81,22,24,44,58,2,62,35,22,27,74,70,18,29,52,52,43,35,38,92,61,96,19,95,19,69,85,8,8,75,56,30,58,15,47,30,28,88,97,29,34,73,53,53,4,4,78,87,68,94,62,8,90,84,35,85,4,28,25,89,16,54,27,46,70,44,12,4,82,23,24,54,38,9,59,88,43,65,91,15,90,97,39,14,13,49,40,74,80,61,27,99,63,9,14,79,46,7,82,60,92,75,6,46,70,8,70,81,25,47,43,38,37,11,98,18,16,14,34,22,4,38,23,21,96,24,91,30,95,80,42,37,83,32,23,16,92,92,43,5,78,59,49,33,19,88,63,52,10,96,64,33,73,60,56,55,52,85,50,47,17,41,86,45,5,7,55,5,87,83,26,23,70,29,44,45,88,89,3,8,60,39,20,98,17,10,63,23,75,68,63,7,42,96,88,38,73,4,29,13,33,58,64,27,71,41,62,45,17,12,66,63,83,42,86,77,21,87,29,95,43,32,30,20,20,19,80,73,41,6,72,84,61,90,75,3,74,93,28,75,47,19,7,64,2,1,24,99,11,11,18,85,75,33,69,2,29,45,7,52,60,88,4,11,39,81,2,93,67,83,3,28,59,53,49,25,26,65,19,20,95,80,63,30,88,86,9,29,21,74,73,30,86,76,16,58,15,96,25,20,99,31,33,27,8,90,26,23,83,45,76,64,26,87,57,79,26,74,22,53,72,72,72,93,11,73,41,83,38,90,10,29,40,98,20,64,48,36,22,98,60,86,45,75,98,10,4,98,19,36,32,40,74,72,48,27,58,39,17,35,49,43,85,92,35,47,24,28,67,93,32,89,53,24,92,86,28,96,95,1,69,43,65,2,58,69,55,67,51,93,6,10,20,86,50,18,1,52,41,51,85,76,31,26,4,43,87,51,79,61,98,62,43,16,66,6,77,83,35,66,91,57,77,74,87,22,70,66,73,75,85,75,56,44,15,93,12,39,98,16,82,5,87,89,94,44,66,4,21,44,40,18,18,74,60,29,98,57,39,82,73,21,77,5,75,23,6,98,1,72,93,38,85,19,84,87,69,87,79,43,55,66,46,30,35,68,58,81,84,86,94,55,1,16,43,61,28,83,14,71,39,68,3,48,50,2,32,98,90,73,60,11,77,95,27,8,75,48,69,8,65,24,15,15,78,38,37,69,76,23,60,86,74,8,5,87,63,97,79,34,36,59,91,12,27,83,78,6,89,35,85,79,14,6,7,15,53,88,69,12,64,63,23,67,13,73,37,69,91,40,44,78,68,36,72,6,33,3,87,95,60,32,80,41,38,80,72,68,2,89,34,75,28,67,69,73,37,24,98,53,46,10,15,50,91,8,11,77,34,1,82,50,1,74,52,33,82,81,30,33,2,69,67,2,6,69,50,2,67,98,69,10,5,35,49,51,18,31,49,31,69,95,34,2,8,83,74,53,15,37,91,55,93,65,52,77,42,13,44,23,57,10,10,36,31,72,46,66,26,2,15,51,32,99,64,6,36,66,94,22,94,96,86,31,8,15,16,39,83,71,10,5,87,27,73,59,85,97,70,35,38,9,28,14,22,40,23,94,2,46,42,75,19,22,28,61,24,79,29,16,57,7,82,54,91,11,64,6,26,5,21,38,95,59,84,86,69,72,10,67,92,21,38,37,30,34,85,65,99,12,36,6,69,54,78,31,26,73,22,12,75,18,68,96,26,5,80,60,38,42,91,51,70,61,24,36,69,46,24,58,25,99,6,15,69,15,68,41,81,53,60,96,50,97,91,75,53,41,12,26,54,26,27,58,20,85,36,9,31,42,62,80,49,64,87,76,12,54,28,11,36,39,79,84,81,95,1,72,69,49,83,28,34,98,5,98,72,48,94,83,78,59,11,39,90,80,47,86,11,16,63,98,14,1,89,15,47,42,76,24,84,63,40,81,59,35,46,51,59,88,5,63,60,44,32,77,29,41,93,1,49,15,62,54,85,84,14,34,9,89,52,30,71,70,99,16,20,29,79,56,35,96,27,23,12,99,39,69,68,13,86,7,48,76,75,70,2,86,95,75,21,13,42,70,37,74,92,89,45,17,58,99,61,38,66,52,87,39,42,86,45,45,65,96,4,45,81,95,94,29,14,33,33,4,35,23,55,57,85,37,8,50,24,52,55,86,45,11,10,24,83,62,44,10,31,76,47,45,67,91,92,96,94,17,4,25,67,58,4,44,97,30,54,6,78,95,21,14,42,17,99,71,85,71,46,51,89,23,73,59,75,10,90,93,44,11,55,8,48,30,20,87,8,66,26,53,9,39,32,36,55,34,4,50,91,22,11,24,70,52,35,44,84,44,68,87,40,60,61,67,40,14,65,12,96,13,64,20,45,92,43,51,91,38,5,42,6,40,2,23,99,32,37,96,95,76,3,63,97,38,14,48,78,64,95,41,68,92,53,79,57,91,78,78,10,84,52,47,40,27,82,99,58,38,67,9,76,69,17,21,10,1,22,7,79,94,72,27,42,63,74,14,87,23,65,9,53,59,87,11,24,56,23,71,56,15,89,40,96,86,65,99,76,33,69,56,69,71,98,15,12,26,5,77,53,69,13,36,72,59,56,17,81,6,97,54,78,51,51,64,5,33,30,56,97,74,38,54,53,9,39,81,60,72,98,98,51,46,18,87,3,54,67,38,31,48,18,70,36,15,78,19,21,35,11,79,95,49,79,78,31,58,83,64,21,74,57,10,8,98,4,32,33,63,62,51,65,92,25,50,57,68,19,38,30,20,61,26,61,20,4,2,66,40,56,44,70,4,18,57,91,8,62,37,12,47,86,57,72,60,14,3,24,30,22,63,40,45,34,1,13,31,48,88,95,2,65,92,8,18,80,61,75,68,58,49,6,81,27,83,34,5,53,2,6,1,77,37,19,92,5,25,70,18,44,60,60,74,42,10,81,93,50,55,79,53,28,56,71,72,58,58,19,50,66,9,77,47,82,94,24,28,74,15,13,55,91,58,25,98,89,31,40,17,2,41,55,98,22,53,73,22,66,47,35,46,7,21,51,35,82,13,91,47,86,53,19,35,42,25,61,70,32,73,82,27,19,3,48,25,54,79,26,30,22,2,62,28,80,66,49,71,7,89,16,77,40,93,30,49,23,20,56,96,91,4,90,92,64,8,28,4,72,27,81,3,87,61,25,84,90,91,55,75,76,90,63,42,58,6,87,25,72,99,3,34,24,29,39,19,12,70,64,72,38,45,98,80,9,13,89,78,69,46,58,31,65,80,21,2,40,49,35,58,21,4,31,73,24,47,79,58,23,6,73,21,28,82,37,31,91,83,34,46,16,10,56,27,41,71,69,43,8,38,79,62,36,6,52,35,14,26,56,61,33,31,55,63,73,38,4,82,43,89,10,56,16,89,42,12,48,5,32,53,78,37,51,85,27,11,85,22,31,3,18,66,28,72,13,85,54,93,54,4,67,86,99,19,28,24,47,46,63,40,87,10,93,3,83,96,80,69,36,62,52,82,51,41,72,44,28,43,76,57,57,54,51,29,86,91,37,32,57,4,63,39,58,90,15,8,72,26,88,16,5,84,57,91,51,84,35,58,46,84,95,4,70,7,83,33,59,65,17,91,59,48,12,33,99,14,25,61,26,64,71,2,55,60,53,72,97,59,77,2,57,78,86,73,8,59,68,51,8,82,49,8,10,96,57,56,73,25,92,37,60,74,32,82,13,94,49,10,54,12,36,99,87,16,35,81,62,39,26,40,45,73,53,44,15,64,92,58,4,96,99,73,67,41,41,82,46,4,60,14,11,59,97,96,46,50,20,94,61,75,93,34,98,52,92,87,21,88,67,49,2,91,6,58,12,63,33,47,74,53,35,59,78,12,30,86,75,57,98,65,44,98,96,28,3,65,74,15,49,53,61,58,37,11,13,19,53,40,84,83,18,73,20,9,41,35,55,86,23,6,13,64,89,2,5,3,94,78,55,47,88,18,98,22,91,76,22,68,99,11,34,36,73,15,48,71,79,88,87,68,10,87,92,43,41,97,69,36,6,10,25,75,85,37,94,99,75,98,17,64,14,87,86,12,72,77,90,74,53,34,24,7,90,86,37,2,26,55,81,93,8,86,62,90,86,58,50,36,21,49,96,80,71,24,55,23,1,80,70,64,8,94,82,72,85,18,84,98,99,93,74,20,18,24,56,27,26,96,26,14,27,54,54,5,38,43,36,67,32,15,1,46,84,17,86,14,5,90,5,68,74,52,36,27,74,76,63,47,67,28,96,5,54,57,37,53,40,77,34,43,82,18,66,85,92,29,35,1,37,43,23,35,91,58,40,74,18,27,30,61,79,88,99,5,18,96,91,28,79,33,73,27,56,62,86,56,85,51,34,46,42,63,10,25,5,62,13,96,18,63,35,14,47,72,63,93,19,62,67,96,37,7,21,4,69,95,78,29,71,83,89,67,92,84,19,16,78,74,99,56,83,94,11,17,98,60,80,83,99,93,38,24,83,38,9,35,43,7,56,9,83,84,26,34,73,68,21,63,53,47,15,44,63,12,14,43,96,4,6,10,16,95,30,77,46,66,83,55,75,84,73,72,19,90,73,99,69,77,43,30,39,17,30,52,79,94,60,72,24,66,39,40,1,46,93,88,54,48,88,8,84,66,88,69,74,42,25,72,38,15,73,20,60,75,70,98,65,77,98,51,6,11,31,9,45,34,72,72,97,85,45,22,89,36,46,72,29,61,78,37,69,88,34,10,93,19,79,25,75,94,23,77,49,37,3,74,35,79,24,40,69,53,74,53,70,52,31,25,30,98,70,5,98,62,82,17,76,22,16,27,54,48,96,4,62,67,72,53,33,72,37,49,37,39,67,17,14,80,40,41,88,55,94,77,24,19,78,87,54,85,97,14,64,97,85,22,56,71,91,3,80,78,91,58,61,21,67,60,94,66,4,96,82,74,38,99,53,19,79,43,89,85,98,48,74,24,85,39,53,45,60,43,89,37,61,11,64,36,17,4,52,18,92,87,82,2,32,90,60,86,69,38,92,49,14,94,79,43,83,37,36,29,8,49,7,60,8,45,13,27,35,17,3,76,90,71,92,11,65,73,92,94,79,66,76,23,51,40,24,66,32,21,53,79,67,24,11,44,81,22,94,86,77,33,51,52,36,16,58,43,3,68,78,10,45,41,49,42,72,84,10,67,22,47,95,15,64,23,9,67,61,48,30,43,79,6,18,46,15,25,86,35,81,81,63,63,43,43,35,26,74,69,71,96,12,27,65,31,38,37,88,13,8,91,82,55,39,35,31,40,24,4,27,48,97,75,86,41,83,32,72,22,87,82,93,91,76,33,32,53,40,86,8,78,36,74,28,89,99,9,25,8,13,95,3,70,42,24,99,37,40,25,48,6,65,67,25,25,98,90,78,6,4,77,99,38,96,49,12,24,48,96,41,74,8,64,10,92,80,23,49,53,34,95,13,16,39,2,14,69,49,3,91,9,31,19,5,35,95,64,74,93,12,76,88,43,83,74,97,1,57,33,44,75,41,26,72,8,64,83,99,94,35,43,75,45,6,32,44,89,59,74,96,16,49,55,42,57,7,69,32,65,5,13,12,16,59,17,68,6,46,96,70,13,65,79,59,69,1,44,38,51,30,8,42,83,36,28,27,85,83,15,2,94,51,35,90,23,31,59,86,89,64,39,44,62,5,84,51,69,96,72,57,62,32,81,35,96,71,29,80,31,89,82,22,31,94,75,61,31,89,36,39,42,58,49,87,91,64,79,78,52,77,57,89,12,58,40,63,70,99,93,51,2,79,56,99,81,17,13,67,29,23,21,79,60,34,15,5,82,93,43,32,92,50,29,53,32,93,11,72,55,12,90,31,95,84,37,63,3,50,6,74,51,12,50,29,57,78,29,77,44,36,81,77,57,62,59,51,50,3,67,88,7,41,13,17,33,89,83,76,96,52,3,32,88,68,80,80,1,99,95,54,65,33,29,20,30,14,74,34,25,86,13,99,83,18,67,11,99,33,96,67,94,53,80,92,33,50,89,88,81,79,50,51,7,13,24,74,12,92,87,19,16,50,51,11,39,3,49,70,2,70,81,68,4,28,59,13,52,37,86,80,25,85,53,46,36,62,92,70,94,93,99,7,46,77,52,45,3,70,53,30,1,19,87,12,97,81,47,78,53,12,22,75,6,7,94,30,97,5,74,76,11,79,76,8,71,75,23,27,76,15,10,82,83,57,80,7,98,41,49,54,16,14,17,82,71,24,1,40,83,22,48,97,95,76,20,22,42,79,41,23,59,20,3,39,2,40,91,49,26,88,32,56,55,20,61,96,62,93,37,47,74,83,44,55,67,13,86,7,37,58,64,20,1,27,95,95,12,78,81,31,32,51,14,95,89,91,43,76,16,23,59,48,42,93,48,76,76,48,71,89,54,85,13,67,24,13,55,28,25,65,85,84,13,6,15,23,70,49,65,75,69,11,91,15,99,16,77,7,79,19,20,64,7,92,76,47,39,46,71,77,37,15,51,51,37,74,36,37,79,25,7,27,82,96,20,44,94,97,68,8,35,48,49,6,45,22,78,20,29,67,84,24,77,87,39,55,59,41,78,26,80,41,28,54,13,92,81,10,72,33,53,42,77,63,42,88,65,45,6,15,95,16,8,12,41,82,50,95,58,65,85,54,20,43,28,94,21,95,92,53,41,68,48,96,14,42,46,15,45,50,89,14,35,63,30,64,33,16,14,31,43,86,52,8,48,99,22,35,36,48,68,70,53,53,74,28,68,11,97,98,36,35,50,8,76,71,19,57,13,63,61,5,82,62,10,55,16,40,49,15,21,12,79,97,81,20,61,82,89,3,96,22,18,15,95,8,36,44,32,76,81,65,22,72,86,64,88,91,43,19,12,28,62,83,78,25,56,53,27,56,11,36,68,11,67,39,86,67,66,2,19,71,9,72,34,55,89,7,12,18,32,70,40,70,91,69,60,35,37,70,52,83,18,75,66,45,97,12,6,47,77,21,25,42,1,40,19,89,50,23,36,50,42,9,25,41,96,97,20,97,79,52,30,96,50,36,54,34,7,88,58,77,2,64,41,11,45,97,69,51,50,71,85,14,35,3,41,10,50,25,49,99,91,8,67,25,91,29,92,64,86,84,82,61,65,58,49,77,67,15,95,98,28,68,48,9,67,16,61,47,94,44,83,81,40,58,85,93,96,16,19,17,6,6,65,65,88,25,49,76,54,64,42,35,30,50,71,24,60,59,58,75,67,45,69,42,1,1,21,8,72,55,80,51,95,78,93,23,3,82,20,43,67,84,93,31,2,49,52,90,86,62,34,38,58,44,49,61,37,23,64,87,4,41,4,98,83,91,39,51,57,49,21,77,39,16,9,83,51,38,41,52,49,31,21,11,22,43,93,52,30,32,86,79,18,33,39,26,80,95,47,11,10,2,34,38,41,56,98,42,35,66,11,98,82,12,38,72,21,93,76,41,97,87,22,25,62,42,60,7,76,82,3,55,90,31,43,48,97,82,70,66,44,51,17,63,22,88,97,6,94,66,5,87,19,7,13,23,80,9,75,99,96,92,65,53,63,55,8,52,69,90,75,38,23,11,96,46,70,58,3,74,45,54,12,11,77,16,37,84,18,21,68,88,8,71,70,52,86,64,99,67,80,45,37,4,91,67,64,9,10,67,53,22,6,1,55,42,80,55,75,48,18,23,34,49,23,86,31,52,41,45,60,6,58,36,94,99,18,8,20,11,51,29,74,51,68,46,82,7,17,28,71,31,88,52,49,57,11,88,81,5,37,12,67,65,7,47,64,70,7,55,25,72,36,65,96,89,49,83,80,77,5,25,36,13,73,29,17,6,86,37,88,29,27,15,74,39,61,10,44,22,81,13,99,61,4,99,95,24,55,59,9,28,8,4,1,12,76,55,92,78,30,58,83,70,66,95,45,21,91,57,29,40,40,59,95,91,25,74,10,74,34,93,50,27,28,61,22,24,15,62,63,6,17,66,91,24,29,29,94,8,54,74,33,98,31,69,88,48,9,9,87,2,46,18,44,37,8,56,43,6,74,22,6,29,94,23,23,73,68,72,62,96,80,2,21,59,60,52,96,58,73,73,15,7,75,61,60,99,22,55,16,72,86,89,34,32,68,4,4,8,47,15,80,36,46,90,22,44,97,85,76,55,60,84,32,1,8,99,54,33,63,24,52,14,56,89,11,91,68,88,90,57,49,88,12,59,93,78,60,84,40,17,2,37,78,60,13,2,57,34,25,69,49,70,45,24,63,67,80,57,80,30,76,10,94,20,7,71,73,73,7,29,40,70,93,47,22,16,35,96,77,9,34,34,64,22,8,78,44,87,95,27,98,4,5,10,41,92,42,59,53,41,29,83,27,95,29,79,77,98,2,48,32,83,79,71,95,42,45,73,12,29,28,85,77,80,30,37,66,83,7,30,73,76,43,36,80,51,8,68,92,29,2,46,86,48,94,16,24,33,15,98,47,69,47,25,14,43,7,46,66,92,14,94,92,72,74,56,41,44,90,45,34,77,80,83,28,82,99,29,86,15,13,33,69,8,83,5,29,18,23,38,45,61,3,99,16,7,54,14,74,38,75,79,43,69,65,70,88,64,97,32,44,77,60,51,79,80,26,84,88,70,28,23,22,53,1,72,74,80,68,21,28,85,55,49,40,34,90,99,43,13,16,65,21,90,94,67,2,51,20,35,81,69,26,5,10,53,58,89,69,92,95,8,95,77,4,58,23,11,12,46,89,26,42,75,54,63,2,31,59,33,71,24,61,33,39,59,60,50,39,87,75,2,31,50,18,8,69,44,87,36,45,91,39,73,45,55,27,50,50,47,51,27,30,36,21,72,47,62,38,44,98,72,71,25,71,88,95,91,58,47,93,58,44,23,88,80,84,87,87,84,33,10,1,92,36,49,71,94,29,45,60,8,7,43,38,72,20,15,3,57,59,35,92,4,54,93,82,8,47,41,88,60,74,53,11,88,72,79,88,23,18,2,62,13,86,86,51,2,85,17,60,69,84,31,25,98,18,96,39,43,66,64,47,88,57,1,33,53,32,49,99,41,27,80,39,58,72,79,17,67,42,81,22,31,81,19,75,44,29,13,70,75,40,46,56,54,54,74,55,85,54,98,69,36,17,20,43,5,91,66,27,39,80,71,1,84,42,17,7,39,26,88,24,20,79,25,1,80,24,85,5,97,24,31,14,44,13,85,15,62,76,70,52,62,86,32,95,68,46,71,12,37,68,17,60,65,74,50,57,91,19,62,80,7,62,29,15,49,58,56,72,57,2,45,62,55,37,62,33,47,29,32,35,52,73,67,29,7,71,49,70,62,28,23,43,14,90,45,1,57,18,47,11,89,99,55,35,24,55,5,28,12,17,11,63,86,28,28,33,95,99,8,77,10,86,11,29,79,2,49,65,91,62,76,29,82,21,46,53,19,32,6,52,66,21,58,46,18,60,56,86,62,13,6,57,10,69,2,4,89,27,56,22,6,40,37,50,40,81,81,65,82,74,14,63,93,55,11,88,28,64,11,20,45,62,3,78,57,20,19,13,20,42,64,92,76,84,47,27,84,8,6,36,78,91,5,88,98,42,63,55,59,13,75,25,16,37,77,43,37,58,93,21,62,69,46,40,11,22,87,10,9,84,5,21,59,74,41,54,58,15,80,15,56,64,53,7,67,40,76,40,8,4,89,27,14,84,73,10,45,64,78,77,55,53,46,74,9,55,65,42,95,23,84,23,77,78,65,98,16,40,73,70,46,48,3,6,95,78,7,75,1,31,9,93,37,4,60,3,19,79,97,12,74,35,44,84,19,66,49,35,20,75,94,6,91,8,31,7,51,41,79,31,49,90,41,64,14,91,86,74,19,62,79,37,42,61,96,11,4,19,86,29,29,71,56,25,37,4,3,30,72,53,52,78,99,67,63,84,94,79,70,28,80,74,17,57,96,58,63,30,12,21,4,32,54,51,2,78,35,16,28,11,88,57,3,66,10,2,37,75,98,12,17,25,49,59,48,55,54,98,29,79,40,73,18,51,50,20,25,49,65,85,49,78,52,60,39,24,71,51,47,95,21,88,32,99,4,79,83,94,3,47,24,36,86,48,70,16,39,51,16,90,76,88,10,13,63,39,72,88,20,24,83,4,51,34,58,52,41,19,48,71,37,30,46,19,62,13,92,4,89,24,85,20,35,57,19,33,79,19,37,65,7,94,74,78,63,20,84,53,90,18,74,20,4,45,53,46,42,90,51,50,47
		 
		 */
		
	}
}
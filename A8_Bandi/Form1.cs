//Jared Bandi
//Program 8 
// This program searches an array and prints out a report in excel about broadway shows in Chicago.
using Shows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace A8_Bandi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Creates a list to read in the array of theatres
        List<String> TheaterNames = new List<String>();

        private void Form1_Load(object sender, EventArgs e)
        {
            TheaterNames.Add("All Theaters");
            //Adds Theater names to the list TheaterNames
            for (int i = 0; i < BroadwayShow.GetShows().Length; i++)
            {
                if (TheaterNames.Contains(BroadwayShow.GetShows()[i].Theater) == false)
                {
                    TheaterNames.Add(BroadwayShow.GetShows()[i].Theater);
                }
            }
           // Adds Theatre Names to the ComboBox
            for (int i = 0; i < TheaterNames.Count; i++)
            {
                cbTheatre.Items.Add(TheaterNames[i]);
            }       
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            //int numbers to help edit row characteristics easier
            int shows = 0;
            int num = 3;
            //Using Excel
            var excelApp = new Microsoft.Office.Interop.Excel.Application();
            excelApp.Visible = true;

            Workbook workbook = excelApp.Workbooks.Add();
            Worksheet sheet = workbook.Worksheets[1];

            // Sets up fornat on Excel such as color,Footer, and text in Excel Boxes
            sheet.PageSetup.PrintGridlines = true;
            
            
            sheet.PageSetup.LeftFooter= "Jared Bandi "+ dtpStart.Value.ToShortDateString()+"-"+dtpEnd.Value.ToShortDateString();

            DateTime now = DateTime.Now;

            sheet.Cells[1, 1] = "CHI-TOWN BROADWAY "+ now;
            sheet.Range["A1"].Font.Size = 25;

            sheet.Cells[2, 1] = "SHOW";
            sheet.Cells[2, 2] = "THEATRE";
            sheet.Cells[2, 3] = "CLOSING DATE";
         
            //Runs through array of shows
            for (int i = 0; i < BroadwayShow.GetShows().Length; i++)
            {
                //Runs through array and checks if selected theater matches at spot[i] or all if it is selected
                if (cbTheatre.SelectedItem.Equals("All Theaters") || BroadwayShow.GetShows()[i].Theater.Equals(cbTheatre.SelectedItem))
                {
                    //Checks that the shows are in the specified range at the specific range
                    if (BroadwayShow.GetShows()[i].CloseDate > dtpStart.Value && BroadwayShow.GetShows()[i].OpenDate < dtpEnd.Value)
                    {
                        sheet.Cells[num, 1] = BroadwayShow.GetShows()[i].Name;
                        sheet.Cells[num, 2] = BroadwayShow.GetShows()[i].Theater;
                        sheet.Cells[num, 3] = BroadwayShow.GetShows()[i].CloseDate.ToShortDateString();
                        num++;
                        shows++;
                    }
                }
                
            }
            //Sets Color of the Body of the Program
            sheet.Range["A3:A"+num].Font.Color = Color.Aqua;
            sheet.Range["B3:B"+num].Font.Color = Color.SaddleBrown;
            sheet.Range["C3:C"+num].Font.Color = Color.PeachPuff;

            //Prints the number of shows
            sheet.Cells[num, 1] = "There are " + shows + " shows listed";
            
           //Autofits the Columns
            sheet.Columns.AutoFit();
        }
    }
}

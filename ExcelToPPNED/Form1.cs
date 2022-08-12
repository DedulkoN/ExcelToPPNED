using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.IO;


namespace ExcelToPPNED
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            cBoxCvartal.SelectedIndex = 0;
            tbYear.Text = DateTime.Now.Year.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<StudentData> LStudData = new List<StudentData>();
            
            
                Microsoft.Office.Interop.Excel.Application ObjExcel = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel.Workbook ObjWorkBook = ObjExcel.Workbooks.Open(tbFile.Text);
                Microsoft.Office.Interop.Excel.Worksheet ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1];
                try
                {

                try
                {
                    for (int i = 2; ObjExcel.Cells[nFam.Value][i].Value.ToString() != DBNull.Value.ToString(); i++)
                    {
                        /*for (int j = 1; j < 5; j++)
                            MessageBox.Show(j.ToString() + " " + ObjExcel.Cells[j][i].Value.ToString());
                        MessageBox.Show(ObjExcel.Cells[15][i].Value.ToString());*/
                        try
                        {
                            LStudData.Add(new StudentData(
                                ObjExcel.Cells[nFam.Value][i].Value.ToString(),
                                ObjExcel.Cells[nName.Value][i].Value.ToString(),
                                ObjExcel.Cells[nfathername.Value][i].Value.ToString(),
                                ObjExcel.Cells[nIdPasp.Value][i].Value.ToString(),
                                ObjExcel.Cells[ndateStart.Value][i].Value.ToString(),
                                ObjExcel.Cells[nDateEnd.Value][i].Value.ToString()));
                        }
                        catch
                        {
                            LStudData.Add(new StudentData(
                                ObjExcel.Cells[nFam.Value][i].Value.ToString(),
                                ObjExcel.Cells[nName.Value][i].Value.ToString(),
                                ObjExcel.Cells[nfathername.Value][i].Value.ToString(),
                                ObjExcel.Cells[nIdPasp.Value][i].Value.ToString(),
                                ObjExcel.Cells[ndateStart.Value][i].Value.ToString()
                                ));
                        };
                    }
                }
                catch(Exception ex) { MessageBox.Show(ex.Message); };
                
            }            
            finally
            {
                ObjWorkBook.Close(false);
                ObjExcel.Quit();
            }

            //а теперь выгрузка в файл
            string Qfilename = Path.Combine(Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().ManifestModule.FullyQualifiedName), 
                tbNameList.Text.Replace(" ", "_") + "_" + tbUNN.Text +".txt");

            FileStream f = new FileStream(Qfilename, FileMode.Append, FileAccess.Write, FileShare.Write, 256 * 256, FileOptions.Asynchronous);
            StreamWriter sw = new StreamWriter(f);
            try
            {
                sw.WriteLine("[FORMAT]");
                sw.WriteLine("VERSION=1.0");
                sw.WriteLine("TYPE=PERSON");
                sw.WriteLine("DIRECTION=EXCLUDE");
                sw.WriteLine("[/FORMAT]");
                sw.WriteLine("[LIST]");
                sw.WriteLine("YEAR={0}", tbYear.Text);
                sw.WriteLine("QUARTER={0}", (cBoxCvartal.SelectedIndex+1).ToString());
                sw.WriteLine("ORG_UNP={0}", tbUNN.Text);
                sw.WriteLine("NAME={0}", tbNameList.Text);
                sw.WriteLine("[/LIST]");
                sw.WriteLine("[PERSON]");
                foreach (StudentData Stud in LStudData)
                {
                    sw.WriteLine(Stud.ToString());
                }
                sw.WriteLine("[/PERSON]");
                

            }
            catch(Exception ec) { MessageBox.Show(ec.Message); }
            finally
            {
                sw.Close();
                f.Close();
            }

            MessageBox.Show("Формирование завершено в файл" + Environment.NewLine + Qfilename);



        }

        private void bOpenExcel_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbFile.Text = openFileDialog1.FileName;

            }
        }

        private void tbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}

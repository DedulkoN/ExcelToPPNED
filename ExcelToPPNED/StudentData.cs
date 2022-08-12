using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExcelToPPNED
{
    class StudentData
    {
        string Fam { get; set; }
        string Name { get; set; }
        string fatherName { get; set; }
        DateTime dateStart { get; set; }
        DateTime dateEnd { get; set; }
        string passportid { get; set; }

        bool srok { get; set; }

       public StudentData(string sFam, string sName, string sfatherName, string passpid, string sDateStart, string sDateEnd)
        {
            Fam = sFam.Trim();
            Name = sName.Trim();
            fatherName = sfatherName.Trim();
            passportid = passpid.Trim();
            try
            {
                dateStart = Convert.ToDateTime(sDateStart);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message + Environment.NewLine + e.StackTrace );
                dateStart = DateTime.Now;
            }

            try
            {
                dateEnd = Convert.ToDateTime(sDateEnd);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + Environment.NewLine + e.StackTrace);
                dateEnd = DateTime.Now;
            }
            srok = false;

        }

        public StudentData(string sFam, string sName, string sfatherName, string passpid, string sDateStart)
        {
            Fam = sFam.Trim();
            Name = sName.Trim();
            fatherName = sfatherName.Trim();
            passportid = passpid.Trim();
            try
            {
                dateStart = Convert.ToDateTime(sDateStart);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message + Environment.NewLine + e.StackTrace);
                dateStart = DateTime.Now;
            }           
                dateEnd = DateTime.Now;
            
            srok = true;

        }


        public override string ToString()
        {
            if(srok) return string.Format("{0}*{1} {2} {3}*T*{4:dd.MM.yyyy}*",
               passportid, Fam, Name, fatherName, dateStart);
            return string.Format("{0}*{1} {2} {3}*F*{4:dd.MM.yyyy}*{5:dd.MM.yyyy}",
                passportid, Fam, Name, fatherName, dateStart, dateEnd);
        }


        


    }
}

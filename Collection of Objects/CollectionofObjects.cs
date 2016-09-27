using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collection_of_Objects
{
    public partial class CollectionofObjects : Form
    {
        public CollectionofObjects()
        {
            InitializeComponent();
       
        }

        Form c = new Form();
        Personas[] P;
        Docentes[] D;
        int i, a;

        private void btnIngresarP_Click(object sender, EventArgs e)
        {
            try
            {
                Array.Resize(ref P, i + 1);
                P[i] = new Personas();
                P[i].GSNames = TextboxNameP.Text;
                P[i].GSLastNames = TextBoxLastNameP.Text;
                P[i].GSPhoneNumbers = TextBoxPhoneNumP.Text;
                P[i].SGYear = int.Parse(TextBoxYeahP.Text);
                i++;
            }
            catch{};
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            DG1.DataSource = P;

            TextboxNameP.Clear();
            TextBoxLastNameP.Clear();
            TextBoxPhoneNumP.Clear();
            TextBoxYeahP.Clear();


        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            { 

                Array.Resize(ref D, a + 1);
            D[a] = new Docentes();
            D[a].GSNames = TextBoxNamesD.Text;
            D[a].GSLastNames = TextBoxLastnameD.Text;
            D[a].GSPhoneNumbers = TextBoxPhoneNumber.Text;
            D[a].GSFaculta = CBFaccultad.Text;
            D[a].SGYear = int.Parse(TextBoxYearofBirth.Text);
            D[a].SGSalario = double.Parse(TextBoxSalary.Text);
            a++;
            }
            catch{};
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DG2.DataSource = D;

            TextBoxNamesD.Clear();
            TextBoxLastnameD.Clear();
            TextBoxPhoneNumber.Clear();
            TextBoxYearofBirth.Clear();
            TextBoxSalary.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void CBFaccultad_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CBFaccultad.Items.Add("FEC");
            CBFaccultad.Items.Add("FIQ");
            CBFaccultad.Items.Add("FTC");
            CBFaccultad.Items.Add("FARQ");
            CBFaccultad.DropDownStyle = ComboBoxStyle.DropDownList;


        }
    }
}

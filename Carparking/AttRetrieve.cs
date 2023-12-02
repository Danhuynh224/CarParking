using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carparking
{
    public partial class AttRetrieve : Form
    {
        qlyrequestDataContext dbrq;
        ResquestDb resquest;
        Attendant attendant;
        public AttRetrieve(Attendant attendant)
        {
            
            InitializeComponent();
            this.attendant = attendant;
        }

        private void AttRetrieve_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDataDataSet7.ResquestDb' table. You can move, or remove it, as needed.
            this.resquestDbTableAdapter.Fill(this.userDataDataSet7.ResquestDb);
            resquest = new ResquestDb();
            dbrq = new qlyrequestDataContext();
            var list = (from s in dbrq.ResquestDbs where s.Type == "Retrieve" select s).ToList();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[1].Visible = false;
        }

        private void AssistButton_Click(object sender, EventArgs e)
        {
            dbrq = new qlyrequestDataContext();
            MessageBox.Show(IDrequesttextBox.Text);
            resquest = dbrq.ResquestDbs.Where(s => s.IDRequest == int.Parse(IDrequesttextBox.Text)).Single();
            
            attendant.Retrieve(resquest.IDRequest, resquest.IDCar, resquest.IDParkRequest);
            AttRetrieve_Load(sender, e);    
        }
    }
}

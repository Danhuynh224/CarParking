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
    public partial class AttParkCar : Form
    {
        qlyrequestDataContext dbrq;
        ResquestDb resquest;
        Attendant attendant;
        public AttParkCar(Attendant attendant)
        {

            InitializeComponent();
            this.attendant = attendant;
        }

        private void AttParkCar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'userDataDataSet4.ResquestDb' table. You can move, or remove it, as needed.
            this.resquestDbTableAdapter.Fill(this.userDataDataSet4.ResquestDb);
           
        
            resquest = new ResquestDb();
            dbrq = new qlyrequestDataContext();
            var list = (from s in dbrq.ResquestDbs where s.Type=="Park" select s).ToList();
            dataGridView1.DataSource = list;
            dataGridView1.Columns[1].Visible = false;

        }

        private void AssistButton_Click(object sender, EventArgs e)
        {
            dbrq = new qlyrequestDataContext();
            resquest = dbrq.ResquestDbs.Where(s => s.IDRequest == int.Parse(IDrequesttextBox.Text) ).Single();
            if (resquest.IDParkRequest != 0)
            {
                attendant.Park(resquest.IDRequest, resquest.IDCar, resquest.IDParkRequest, resquest.Date);
                attendant.issueTicket(resquest.IDRequest);
            }
            else if(resquest.AreaRequest!= "")
            {
                attendant.Park(resquest.IDRequest, resquest.IDCar, resquest.AreaRequest, resquest.Date);
                attendant.issueTicket(resquest.IDRequest);
            }
            else
            {
                attendant.Park(resquest.IDRequest, resquest.IDCar, resquest.Date);
                attendant.issueTicket(resquest.IDRequest);
            }
            AttParkCar_Load(sender, e);
        }
    }
}

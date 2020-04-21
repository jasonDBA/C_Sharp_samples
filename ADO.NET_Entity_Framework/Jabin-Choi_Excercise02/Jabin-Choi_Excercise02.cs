using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jabin_Choi_Excercise02
{
    public partial class Excercise02 : Form
    {
        public Excercise02()
        {
            InitializeComponent();
        }

        BaseballExamples.BaseballEntities dbcontext = new BaseballExamples.BaseballEntities();
        
        private void Details_Load(object sender, EventArgs e)
        {
            dbcontext.Players.Load();
            playerBindingSource.DataSource = dbcontext.Players.Local;
        }

        private void Search_Click(object sender, EventArgs e)
        {
            var searchQuery =
                from player in dbcontext.Players
                where player.LastName.Contains(txtLastName.Text)
                select player;

            playerBindingSource.DataSource = searchQuery.ToList();

        }

        private void Return_Click(object sender, EventArgs e)
        {
            dbcontext.Players.Load();
            playerBindingSource.DataSource = dbcontext.Players.Local;
        }
    }
}

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

namespace Jabin_Choi_Sec004_Excercise02
{
    public partial class Excercise02 : Form
    {
        public Excercise02()
        {
            InitializeComponent();
        }

        BaseBallExamples.BaseballEntities dbcontext = new BaseBallExamples.BaseballEntities();

        private void Excercise02_Load(object sender, EventArgs e)
        {
            dbcontext.Players.Load();
            playerBindingSource.DataSource = dbcontext.Players.Local;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var searchPlayerID =
                from player in dbcontext.Players
                where player.PlayerID.ToString().Contains(txtPlayerID.Text)
                select player;

            playerBindingSource.DataSource = searchPlayerID.ToList();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            playerBindingSource.DataSource = dbcontext.Players.ToList();
        }

        private void btnDisplayBattingAvg_Click(object sender, EventArgs e)
        {
            var averageBattingScore = dbcontext.Players.Average(x => x.BattingAverage);

            txtBattingAverage.AppendText($"{Math.Round(averageBattingScore, 3)}");
        }

        private void btnDisplayHighestScore_Click(object sender, EventArgs e)
        {
            var highestScore = dbcontext.Players.Max(x => x.BattingAverage);

            var result =
                from player in dbcontext.Players
                where player.BattingAverage == highestScore
                select new
                {
                    FirstName = player.FirstName,
                    LastName = player.LastName
                };

            foreach(var results in result)
            {
                txtHighestScore.AppendText($"{results.FirstName} {results.LastName}");
            }
            
        }
    }
}

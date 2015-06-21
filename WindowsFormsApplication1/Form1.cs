using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DataLayer;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string path = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;
            
            string json = File.ReadAllText(path + @"\JSON\AllSets.json");
            var rootobject = Newtonsoft.Json.JsonConvert.DeserializeObject<Rootobject>(json);
            
            var hearthStoneContext = new HearthStoneContext();

            hearthStoneContext.Basics.AddRange(rootobject.Basic);
            hearthStoneContext.Classics.AddRange(rootobject.Classic);
            hearthStoneContext.Credits.AddRange(rootobject.Credits);
            hearthStoneContext.Debugs.AddRange(rootobject.Debug);
            hearthStoneContext.Missions.AddRange(rootobject.Missions);
            hearthStoneContext.Rewards.AddRange(rootobject.Reward);
            hearthStoneContext.Promotions.AddRange(rootobject.Promotion);
            hearthStoneContext.Systems.AddRange(rootobject.System);

            hearthStoneContext.SaveChanges();
        }
    }
}

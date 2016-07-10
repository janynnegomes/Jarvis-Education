using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JarvisPluginInterface;
using Jarvis_Library;
using System.Drawing;
using System.Windows.Forms;

namespace Plugin_Tasks
{
    public class Starter : IPluginImplementer
    {

        public void MenuAdder(SideMenuItem menuItem)
        {
            menuItem.Click += tsCLick;
        }


        private void tsCLick(object sender, EventArgs e)
        {
            TasksPanel panel = new TasksPanel();
            panel.ShowDialog();
        }

        public string PluginName()
        {
            return "Tasks";
        }

        public Icon PluginIcon()
        {
            return Properties.Resources.Task;
        }

        public Form LoadContent()
        {
            return new TasksPanel();
        }
    }
}

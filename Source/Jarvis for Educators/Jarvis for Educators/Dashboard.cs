using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JarvisPluginInterface;
using System.IO;
using System.Reflection;
using Jarvis_Library;

namespace Jarvis_for_Educators
{
    public partial class Dashboard : Form
    {
        IPluginImplementer pluginImplementer;
        SideMenuItem externalMenuItem;

        List<Panel> panels;

        public Dashboard()
        {
            InitializeComponent();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripExit_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripAbout_Click(object sender, EventArgs e)
        {
            new Sobre().ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            panels = new List<Panel>();

            // load menu
            SideMenu sideMenu = new SideMenu();

            SideMenuItem itemAbout = new SideMenuItem("ABOUT", "Informações gerais", Properties.Resources.iconAbout);
            SideMenuItem itemCalendar = new SideMenuItem("CALENDAR", "Informações gerais", Properties.Resources.iconAbout);
            SideMenuItem itemRemembers = new SideMenuItem("REMINDERS", "Informações gerais", Properties.Resources.iconAbout);
            SideMenuItem itemSettings = new SideMenuItem("SETTINGS", "Informações gerais", Properties.Resources.iconAbout);

            itemAbout.MouseHover += new EventHandler(delegate (object obj, EventArgs ev)
            {
                itemAbout.BackColor = Color.Red;
            });

            sideMenu.items.Add(itemCalendar);
            sideMenu.items.Add(itemRemembers);
            sideMenu.items.Add(itemSettings);
            sideMenu.items.Add(itemAbout);

            sideMenu.active = itemCalendar;



            // Look for files with .dll extension inside especific folder 
            foreach (var file in Directory.GetFiles(@"../../Plugins","*.dll"))
            {
                var assembly = Assembly.LoadFrom((@"../../Plugins" + file));

                foreach (var type in assembly.GetTypes())
                {
                    if(type.GetInterfaces().Contains(typeof(IPluginImplementer)))
                    {
                        pluginImplementer = Activator.CreateInstance(type) as IPluginImplementer;

                        string pluginName = pluginImplementer.PluginName();
                        Icon pluginIcon = pluginImplementer.PluginIcon();
                        
                        externalMenuItem = new SideMenuItem(pluginName, "", pluginIcon);

                        externalMenuItem.Click += new EventHandler(delegate(object obj, EventArgs args) {

                            MessageBox.Show("hahhahaha");
                        });

                        sideMenu.items.Add(externalMenuItem);

                        pluginImplementer.MenuAdder(externalMenuItem);
                    }
                }
            }

            sideNavigation1.defaultBackColor = Color.FromArgb(24, 58, 86);
            sideNavigation1.hoverColor = Color.FromArgb(24, 90, 90);

            sideNavigation1.menu = sideMenu;
            
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripTop_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Panel oldPanel = pnlContent;

            panels.Add(oldPanel);

            Calendar objForm = new  Calendar();
            objForm.TopLevel = false;

            pnlContent.Controls.Clear();
            pnlContent.Controls.Add(objForm);
            objForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlContent.Controls.Clear();
            pnlContent = panels[0];
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
           
            this.Hide();
            
            
        }

        private void Dashboard_Resize(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void panel9_Move(object sender, EventArgs e)
        {
            
        }
    }
}

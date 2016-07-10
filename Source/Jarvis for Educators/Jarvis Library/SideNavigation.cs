using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jarvis_Library
{
    public partial class SideNavigation : UserControl
    {
        private SideMenu _menu;
        public Color hoverColor { get; set; }
        public Color defaultBackColor { get; set; }

       public SideMenu menu { get { return menu; }

        set
            {
                _menu = value;
                
                if (_menu.items.Count > 0)
                {
                    // Loop the items list
                    foreach (var item in _menu.items)
                    {
                        
                        item.Click += new EventHandler(delegate(object itemComponent, EventArgs args) {

                            _menu.active = (SideMenuItem)itemComponent;
                            ((SideMenuItem)itemComponent).BackColor = this.hoverColor;


                            // Deactivate ohters items
                            for (int i = 0; i < _menu.items.Count; i++)
                            {
                                // Make sure the active item dont reset back color
                                if (_menu.items[i] != _menu.active)
                                {
                                    _menu.items[i].BackColor = this.defaultBackColor;
                                }
                            }
                        });

                        item.MouseHover += new EventHandler(delegate (object itemComponent, EventArgs args) {

                            if(this.hoverColor != null)
                            {
                                ((SideMenuItem)itemComponent).BackColor = this.hoverColor;
                            }
                            
                        });

                        item.MouseLeave += new EventHandler(delegate (object itemComponent, EventArgs args) {

                            if (_menu.active != null & ((SideMenuItem)itemComponent) != _menu.active)
                            {

                                if (this.defaultBackColor != null)
                                {
                                    ((SideMenuItem)itemComponent).BackColor = this.defaultBackColor;
                                }
                            }
                        });

                        flowMenuContainer.Controls.Add(item);
                        flowMenuContainer.Show();
                    }
                }
            }
        }

        public SideNavigation()
        {
            InitializeComponent();
        }

        private void SideNavigation_Load(object sender, EventArgs e)
        {
            // Get Plugins Options

        }

        private void pictureBoxItemIcon_Click(object sender, EventArgs e)
        {

            
        }

        
    }
}

using Jarvis_Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace JarvisPluginInterface
{
   public interface IPluginImplementer
    {

        string PluginName();
        Icon PluginIcon();
        void MenuAdder(SideMenuItem menuItem);

        Form LoadContent();

    }
}

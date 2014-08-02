using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace fPlayer_2
{
    public class basePlugin : IPlugin
    {
        public string name = "EQ";
        public Control getGUI(Player self)
        {
            pluginUI pui = new pluginUI();
            pui.Tag = self;
            return pui;
        }


        string Name
        {
            get { return name; }
            set { name = value; }
        }

        string IPlugin.Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}

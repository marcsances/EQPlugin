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
        public pluginUI pui;
        public Control getGUI(Player self)
        {
            if (pui == null)
            {
                pui = new pluginUI();
                pui.Tag = self;
                return pui;
            }
            else return pui;
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

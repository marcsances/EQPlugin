using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using libZPlay;
namespace fPlayer_2
{
    public partial class pluginUI : UserControl
    {
        Player parent;
        public pluginUI()
        {
            InitializeComponent();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("EQ plugin 1.0\r\nCopyright (c) 2014, MSS Software & Services.", "EQPlugin", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void freq115_Scroll(object sender, EventArgs e)
        {
            if (parent==null) parent = (Player)this.Tag;
            if (parent != null && parent.gI()!=null && libap.libAP.LIBAP_API_IMPL<2) // force IMPL 1.x
            {
                getZP().SetEqualizerBandGain(0, freq115.Value);
            }
        }

        private ZPlay getZP()
        {
            if (parent == null) parent = (Player)this.Tag;
            return (ZPlay)parent.gI().impl_command("GETZPLAY", null)[0];
        }

        private void freq240_Scroll(object sender, EventArgs e)
        {
            if (parent == null) parent = (Player)this.Tag;
            if (parent != null && parent.gI() != null && libap.libAP.LIBAP_API_IMPL < 2) // force IMPL 1.x
            {
                getZP().EnableEqualizer(true);
                getZP().SetEqualizerBandGain(1, freq240.Value);
            }
        }

        private void freq455_Scroll(object sender, EventArgs e)
        {
            if (parent == null) parent = (Player)this.Tag;
            if (parent != null && parent.gI() != null && libap.libAP.LIBAP_API_IMPL < 2) // force IMPL 1.x
            {
                getZP().EnableEqualizer(true);
                getZP().SetEqualizerBandGain(2, freq455.Value);
            }
        }

        private void freq800_Scroll(object sender, EventArgs e)
        {
            if (parent == null) parent = (Player)this.Tag;
            if (parent != null && parent.gI() != null && libap.libAP.LIBAP_API_IMPL < 2) // force IMPL 1.x
            {
                getZP().EnableEqualizer(true);
                getZP().SetEqualizerBandGain(3, freq800.Value);
            }
        }


        private void freq2k_Scroll(object sender, EventArgs e)
        {
            if (parent == null) parent = (Player)this.Tag;
            if (parent != null && parent.gI() != null && libap.libAP.LIBAP_API_IMPL < 2) // force IMPL 1.x
            {
                getZP().EnableEqualizer(true);
                getZP().SetEqualizerBandGain(4, freq2k.Value);
            }
        }

        private void freq4d5k_Scroll(object sender, EventArgs e)
        {
            if (parent == null) parent = (Player)this.Tag;
            if (parent != null && parent.gI() != null && libap.libAP.LIBAP_API_IMPL < 2) // force IMPL 1.x
            {
                getZP().EnableEqualizer(true);
                getZP().SetEqualizerBandGain(5, freq4d5k.Value);
            }
        }

        private void freq9k_Scroll(object sender, EventArgs e)
        {
            if (parent == null) parent = (Player)this.Tag;
            if (parent != null && parent.gI() != null && libap.libAP.LIBAP_API_IMPL < 2) // force IMPL 1.x
            {
                getZP().EnableEqualizer(true);
                getZP().SetEqualizerBandGain(6, freq9k.Value);
            }
        }

        private void freq13k_Scroll(object sender, EventArgs e)
        {
            if (parent == null) parent = (Player)this.Tag;
            if (parent != null && parent.gI() != null && libap.libAP.LIBAP_API_IMPL < 2) // force IMPL 1.x
            {
                getZP().EnableEqualizer(true);
                getZP().SetEqualizerBandGain(7, freq13k.Value);
            }
        }

        private void freq15k_Scroll(object sender, EventArgs e)
        {
            if (parent == null) parent = (Player)this.Tag;
            if (parent != null && parent.gI() != null && libap.libAP.LIBAP_API_IMPL < 2) // force IMPL 1.x
            {
                getZP().EnableEqualizer(true);
                getZP().SetEqualizerBandGain(8, freq15k.Value);
            }
        }

        private void freqsr_Scroll(object sender, EventArgs e)
        {
            if (parent == null) parent = (Player)this.Tag;
            if (parent != null && parent.gI() != null && libap.libAP.LIBAP_API_IMPL < 2) // force IMPL 1.x
            {
                getZP().EnableEqualizer(true);
                getZP().SetEqualizerBandGain(9, freqsr.Value);
            }
        }

        private void pitchbar_Scroll(object sender, EventArgs e)
        {
            if (parent == null) parent = (Player)this.Tag;
            if (parent != null && parent.gI() != null && libap.libAP.LIBAP_API_IMPL < 2) // force IMPL 1.x
            {
                getZP().SetPitch(pitchbar.Value);
            }
        }

        private void tempobar_Scroll(object sender, EventArgs e)
        {
            if (parent == null) parent = (Player)this.Tag;
            if (parent != null && parent.gI() != null && libap.libAP.LIBAP_API_IMPL < 2) // force IMPL 1.x
            {
                getZP().SetTempo(tempobar.Value);
            }
        }

        private void echobar_Scroll(object sender, EventArgs e)
        {
            if (parent == null) parent = (Player)this.Tag;
            updateecho();
        }

        private void updateecho()
        {
            if (parent == null) parent = (Player)this.Tag;
            if (parent != null && parent.gI() != null && libap.libAP.LIBAP_API_IMPL < 2) // force IMPL 1.x
            {
                getZP().EnableEcho(true);
                TEchoEffect tef = new TEchoEffect();
                tef.nLeftEchoVolume = echobar.Value;
                tef.nLeftSrcVolume = 100 - echobar.Value;
                tef.nRightEchoVolume = echobar.Value;
                tef.nRightSrcVolume = 100 - echobar.Value;
                tef.nLeftDelay = echooffbar.Value*10;
                tef.nRightDelay = echooffbar.Value*10;
            }
        }

        private void echooffbar_Scroll(object sender, EventArgs e)
        {
            if (parent == null) parent = (Player)this.Tag;
            updateecho();
        }

        private void reversebox_CheckedChanged(object sender, EventArgs e)
        {
            if (parent == null) parent = (Player)this.Tag;
            if (parent != null && parent.gI() != null && libap.libAP.LIBAP_API_IMPL < 2) // force IMPL 1.x
            {
                getZP().ReverseMode(reversebox.Checked);
            }
        }

        private void stereomixbox_CheckedChanged(object sender, EventArgs e)
        {
            if (parent == null) parent = (Player)this.Tag;
            if (parent != null && parent.gI() != null && libap.libAP.LIBAP_API_IMPL < 2) // force IMPL 1.x
            {
                getZP().StereoCut(stereomixbox.Checked,true,true);
            }
        }

        private void resetbox_Click(object sender, EventArgs e)
        {
            if (parent == null) parent = (Player)this.Tag;
            freq115.Value = 0;
            freq13k.Value = 0;
            freq15k.Value = 0;
            freq240.Value = 0;
            freq2k.Value = 0;
            freq455.Value = 0;
            freq4d5k.Value = 0;
            freq800.Value = 0;
            freq9k.Value = 0;
            freqsr.Value = 0;
            echooffbar.Value = 0;
            echobar.Value = 50;
            pitchbar.Value = 100;
            tempobar.Value = 100;
            reversebox.Checked = false;
            stereomixbox.Checked = false;
            if (parent != null && parent.gI() != null && libap.libAP.LIBAP_API_IMPL < 2) // force IMPL 1.x
            {
                getZP().SetPitch(100);
                getZP().SetTempo(100);
                getZP().EnableEqualizer(false);
                getZP().EnableEcho(false);
            }
        }

        private void presetbox_Click(object sender, EventArgs e)
        {
            if (parent == null) parent = (Player)this.Tag;
            MessageBox.Show("Not yet implemented");     
        }

        private void pluginUI_Load(object sender, EventArgs e)
        {
            if (parent == null) parent = (Player)this.Tag;
        }

        
    }
}

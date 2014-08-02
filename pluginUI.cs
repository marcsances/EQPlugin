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
            presetmenu.Show(MousePosition);
        }   

        private void pluginUI_Load(object sender, EventArgs e)
        {
            if (parent == null) parent = (Player)this.Tag;
        }

        public void seteq(int[] frequencies, int pitch, int tempo)
        {
            if (parent != null && parent.gI() != null && libap.libAP.LIBAP_API_IMPL < 2) // force IMPL 1.x
            {
                int m = 0;
                getZP().EnableEqualizer(true);
                foreach (int i in frequencies)
                {
                    getZP().SetEqualizerBandGain(m, i);
                    m++;
                }
                if (pitch > 0) getZP().SetPitch(pitch);
                if (tempo > 0) getZP().SetTempo(tempo);
            }
            updateui();
        }

        public void updateui() {
            freq115.Value = getZP().GetEqualizerBandGain(0);
            freq240.Value = getZP().GetEqualizerBandGain(1);
            freq455.Value = getZP().GetEqualizerBandGain(2);
            freq800.Value = getZP().GetEqualizerBandGain(3);
            freq2k.Value = getZP().GetEqualizerBandGain(4);
            freq4d5k.Value = getZP().GetEqualizerBandGain(5);
            freq9k.Value = getZP().GetEqualizerBandGain(6);
            freq13k.Value = getZP().GetEqualizerBandGain(7);
            freq15k.Value = getZP().GetEqualizerBandGain(8);
            freqsr.Value = getZP().GetEqualizerBandGain(9);
            pitchbar.Value = getZP().GetPitch();
            tempobar.Value = getZP().GetTempo();
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] freqs = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            seteq(freqs, 0, 0);
        }

        private void rockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] freqs = { 20000, 16500, 13500, 11500, 2500, 2500, 11500, 13500, 16500, 20000 };
            seteq(freqs, 0, 0);
        }

        private void technoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] freqs = { 13500, 11500, 10000, 4000, 5000, 5000, 10000, 12000, 7000, 3000 };
            seteq(freqs, 0, 0);
        }

        private void classicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] freqs = { 9000, 8500, 5750, 0, 3000, 0, -5000, -13500, -15750, -17000 };
            seteq(freqs, 0, 0);
        }

        private void voiceBoostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] freqs = { -9000, -8000, -5000, 2500, 10000, 15000, 7000, -5000, -7000, -15000 };
            seteq(freqs, 0, 0);
        }

        private void softToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] freqs = { 10000, 7000, 3000, 1000,500, 0, 0, 0, 0, 0 };
            seteq(freqs, 0, 0);
        }

        private void normalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int[] freqs = { 16000, 13000, 9000, 5000, 2000, 0, 0, 0, 0, 0 };
            seteq(freqs, 0, 0);
        }

        private void highToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] freqs = { 20000, 16500, 13500, 11500, 2500, 0, 0, 0, 0, 0 };
            seteq(freqs, 0, 0);
        }

        private void extremeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] freqs = { 29999, 25000, 19000, 15000, 6000, 0, 0, 0, 0, 0 };
            seteq(freqs, 0, 0);
        }

        private void maximumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int[] freqs = { 29999, 25000, 19000, 15000, 6000, 0, -6000, -15000, -19000, -25000, };
            seteq(freqs, 0, 0);
        }

        private void softToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int[] freqs = { 0, 0, 0, 0, 0, 500, 1000, 3000, 7000, 10000 };
            seteq(freqs, 0, 0);
        }

        private void normalToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int[] freqs = { 0, 0, 0, 0, 0, 2000, 5000, 9000, 13000, 16000 };
            seteq(freqs, 0, 0);
        }

        private void highToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int[] freqs = { 0, 0, 0, 0, 0, 2500, 11500, 13500, 16500, 20000 };
            seteq(freqs, 0, 0);
        }

        private void extremeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int[] freqs = { 0, 0, 0, 0, 0, 6000, 15000, 19000, 25000, 29999 };
            seteq(freqs, 0, 0);
        }

        private void maximumToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int[] freqs = { -25000, -19000, -15000, -6000, 0, 6000, 15000, 19000, 25000, 29999 };
            seteq(freqs, 0, 0);
        }

        private void softToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int[] freqs={0,0,0,0,0,0,0,0,0,0};
            seteq(freqs, 110, 110);
        }

        private void normalToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            int[] freqs = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            seteq(freqs, 130, 130);
        }

        private void extremeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            int[] freqs = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            seteq(freqs, 150, 150);
        }

        private void softToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            int[] freqs = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            seteq(freqs, 90, 90);
        }

        private void normalToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            int[] freqs = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            seteq(freqs, 70, 70);
        }

        private void extremeToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            int[] freqs = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            seteq(freqs, 50, 50);
        }




    }
}

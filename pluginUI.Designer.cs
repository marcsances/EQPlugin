namespace fPlayer_2
{
    partial class pluginUI
    {
        /// <summary> 
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar 
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pluginUI));
            this.freq115 = new System.Windows.Forms.TrackBar();
            this.freq240 = new System.Windows.Forms.TrackBar();
            this.freq455 = new System.Windows.Forms.TrackBar();
            this.freq800 = new System.Windows.Forms.TrackBar();
            this.freq2k = new System.Windows.Forms.TrackBar();
            this.freq4d5k = new System.Windows.Forms.TrackBar();
            this.freq9k = new System.Windows.Forms.TrackBar();
            this.freq13k = new System.Windows.Forms.TrackBar();
            this.freq15k = new System.Windows.Forms.TrackBar();
            this.freqsr = new System.Windows.Forms.TrackBar();
            this.freqlbl = new System.Windows.Forms.Label();
            this.pitchbar = new System.Windows.Forms.TrackBar();
            this.tempobar = new System.Windows.Forms.TrackBar();
            this.echobar = new System.Windows.Forms.TrackBar();
            this.pitchlbl = new System.Windows.Forms.Label();
            this.tempolbl = new System.Windows.Forms.Label();
            this.echolbl = new System.Windows.Forms.Label();
            this.reversebox = new System.Windows.Forms.CheckBox();
            this.stereomixbox = new System.Windows.Forms.CheckBox();
            this.echooffbar = new System.Windows.Forms.TrackBar();
            this.echoofflbl = new System.Windows.Forms.Label();
            this.resetbox = new System.Windows.Forms.Button();
            this.presetbox = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.presetmenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.normalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.technoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.classicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voiceBoostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.bassBoostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.highToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extremeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trebbleBoostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.highToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.extremeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.maximumToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.heliumEffectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.extremeToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.monsterEffectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.softToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.normalToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.extremeToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.freq115)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freq240)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freq455)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freq800)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freq2k)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freq4d5k)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freq9k)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freq13k)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freq15k)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freqsr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempobar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.echobar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.echooffbar)).BeginInit();
            this.presetmenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // freq115
            // 
            resources.ApplyResources(this.freq115, "freq115");
            this.freq115.LargeChange = 50000;
            this.freq115.Maximum = 30000;
            this.freq115.Minimum = -30000;
            this.freq115.Name = "freq115";
            this.freq115.SmallChange = 1000;
            this.freq115.TickFrequency = 1000;
            this.freq115.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.freq115.Scroll += new System.EventHandler(this.freq115_Scroll);
            // 
            // freq240
            // 
            resources.ApplyResources(this.freq240, "freq240");
            this.freq240.Maximum = 30000;
            this.freq240.Minimum = -30000;
            this.freq240.Name = "freq240";
            this.freq240.TickFrequency = 1000;
            this.freq240.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.freq240.Scroll += new System.EventHandler(this.freq240_Scroll);
            // 
            // freq455
            // 
            resources.ApplyResources(this.freq455, "freq455");
            this.freq455.Maximum = 30000;
            this.freq455.Minimum = -30000;
            this.freq455.Name = "freq455";
            this.freq455.TickFrequency = 1000;
            this.freq455.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.freq455.Scroll += new System.EventHandler(this.freq455_Scroll);
            // 
            // freq800
            // 
            resources.ApplyResources(this.freq800, "freq800");
            this.freq800.Maximum = 30000;
            this.freq800.Minimum = -30000;
            this.freq800.Name = "freq800";
            this.freq800.TickFrequency = 1000;
            this.freq800.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.freq800.Scroll += new System.EventHandler(this.freq800_Scroll);
            // 
            // freq2k
            // 
            resources.ApplyResources(this.freq2k, "freq2k");
            this.freq2k.Maximum = 30000;
            this.freq2k.Minimum = -30000;
            this.freq2k.Name = "freq2k";
            this.freq2k.TickFrequency = 1000;
            this.freq2k.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.freq2k.Scroll += new System.EventHandler(this.freq2k_Scroll);
            // 
            // freq4d5k
            // 
            resources.ApplyResources(this.freq4d5k, "freq4d5k");
            this.freq4d5k.Maximum = 30000;
            this.freq4d5k.Minimum = -30000;
            this.freq4d5k.Name = "freq4d5k";
            this.freq4d5k.TickFrequency = 1000;
            this.freq4d5k.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.freq4d5k.Scroll += new System.EventHandler(this.freq4d5k_Scroll);
            // 
            // freq9k
            // 
            resources.ApplyResources(this.freq9k, "freq9k");
            this.freq9k.Maximum = 30000;
            this.freq9k.Minimum = -30000;
            this.freq9k.Name = "freq9k";
            this.freq9k.TickFrequency = 1000;
            this.freq9k.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.freq9k.Scroll += new System.EventHandler(this.freq9k_Scroll);
            // 
            // freq13k
            // 
            resources.ApplyResources(this.freq13k, "freq13k");
            this.freq13k.Maximum = 30000;
            this.freq13k.Minimum = -30000;
            this.freq13k.Name = "freq13k";
            this.freq13k.TickFrequency = 1000;
            this.freq13k.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.freq13k.Scroll += new System.EventHandler(this.freq13k_Scroll);
            // 
            // freq15k
            // 
            resources.ApplyResources(this.freq15k, "freq15k");
            this.freq15k.Maximum = 30000;
            this.freq15k.Minimum = -30000;
            this.freq15k.Name = "freq15k";
            this.freq15k.TickFrequency = 1000;
            this.freq15k.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.freq15k.Scroll += new System.EventHandler(this.freq15k_Scroll);
            // 
            // freqsr
            // 
            resources.ApplyResources(this.freqsr, "freqsr");
            this.freqsr.Maximum = 30000;
            this.freqsr.Minimum = -30000;
            this.freqsr.Name = "freqsr";
            this.freqsr.TickFrequency = 1000;
            this.freqsr.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.freqsr.Scroll += new System.EventHandler(this.freqsr_Scroll);
            // 
            // freqlbl
            // 
            resources.ApplyResources(this.freqlbl, "freqlbl");
            this.freqlbl.Name = "freqlbl";
            // 
            // pitchbar
            // 
            resources.ApplyResources(this.pitchbar, "pitchbar");
            this.pitchbar.Maximum = 200;
            this.pitchbar.Minimum = 1;
            this.pitchbar.Name = "pitchbar";
            this.pitchbar.TickFrequency = 5;
            this.pitchbar.Value = 100;
            this.pitchbar.Scroll += new System.EventHandler(this.pitchbar_Scroll);
            // 
            // tempobar
            // 
            resources.ApplyResources(this.tempobar, "tempobar");
            this.tempobar.Maximum = 200;
            this.tempobar.Minimum = 1;
            this.tempobar.Name = "tempobar";
            this.tempobar.TickFrequency = 5;
            this.tempobar.Value = 100;
            this.tempobar.Scroll += new System.EventHandler(this.tempobar_Scroll);
            // 
            // echobar
            // 
            resources.ApplyResources(this.echobar, "echobar");
            this.echobar.Maximum = 100;
            this.echobar.Name = "echobar";
            this.echobar.TickFrequency = 5;
            this.echobar.Value = 50;
            this.echobar.Scroll += new System.EventHandler(this.echobar_Scroll);
            // 
            // pitchlbl
            // 
            resources.ApplyResources(this.pitchlbl, "pitchlbl");
            this.pitchlbl.Name = "pitchlbl";
            // 
            // tempolbl
            // 
            resources.ApplyResources(this.tempolbl, "tempolbl");
            this.tempolbl.Name = "tempolbl";
            // 
            // echolbl
            // 
            resources.ApplyResources(this.echolbl, "echolbl");
            this.echolbl.Name = "echolbl";
            // 
            // reversebox
            // 
            resources.ApplyResources(this.reversebox, "reversebox");
            this.reversebox.Name = "reversebox";
            this.reversebox.UseVisualStyleBackColor = true;
            this.reversebox.CheckedChanged += new System.EventHandler(this.reversebox_CheckedChanged);
            // 
            // stereomixbox
            // 
            resources.ApplyResources(this.stereomixbox, "stereomixbox");
            this.stereomixbox.Name = "stereomixbox";
            this.stereomixbox.UseVisualStyleBackColor = true;
            this.stereomixbox.CheckedChanged += new System.EventHandler(this.stereomixbox_CheckedChanged);
            // 
            // echooffbar
            // 
            resources.ApplyResources(this.echooffbar, "echooffbar");
            this.echooffbar.LargeChange = 10;
            this.echooffbar.Maximum = 1000;
            this.echooffbar.Name = "echooffbar";
            this.echooffbar.SmallChange = 5;
            this.echooffbar.TickFrequency = 50;
            this.echooffbar.Scroll += new System.EventHandler(this.echooffbar_Scroll);
            // 
            // echoofflbl
            // 
            resources.ApplyResources(this.echoofflbl, "echoofflbl");
            this.echoofflbl.Name = "echoofflbl";
            // 
            // resetbox
            // 
            resources.ApplyResources(this.resetbox, "resetbox");
            this.resetbox.Name = "resetbox";
            this.resetbox.UseVisualStyleBackColor = true;
            this.resetbox.Click += new System.EventHandler(this.resetbox_Click);
            // 
            // presetbox
            // 
            resources.ApplyResources(this.presetbox, "presetbox");
            this.presetbox.Name = "presetbox";
            this.presetbox.UseVisualStyleBackColor = true;
            this.presetbox.Click += new System.EventHandler(this.presetbox_Click);
            // 
            // aboutButton
            // 
            resources.ApplyResources(this.aboutButton, "aboutButton");
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // presetmenu
            // 
            resources.ApplyResources(this.presetmenu, "presetmenu");
            this.presetmenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.normalToolStripMenuItem,
            this.rockToolStripMenuItem,
            this.technoToolStripMenuItem,
            this.classicToolStripMenuItem,
            this.voiceBoostToolStripMenuItem,
            this.toolStripMenuItem1,
            this.bassBoostToolStripMenuItem,
            this.trebbleBoostToolStripMenuItem,
            this.toolStripMenuItem2,
            this.heliumEffectToolStripMenuItem,
            this.monsterEffectToolStripMenuItem});
            this.presetmenu.Name = "presetmenu";
            // 
            // normalToolStripMenuItem
            // 
            resources.ApplyResources(this.normalToolStripMenuItem, "normalToolStripMenuItem");
            this.normalToolStripMenuItem.Name = "normalToolStripMenuItem";
            this.normalToolStripMenuItem.Click += new System.EventHandler(this.normalToolStripMenuItem_Click);
            // 
            // rockToolStripMenuItem
            // 
            resources.ApplyResources(this.rockToolStripMenuItem, "rockToolStripMenuItem");
            this.rockToolStripMenuItem.Name = "rockToolStripMenuItem";
            this.rockToolStripMenuItem.Click += new System.EventHandler(this.rockToolStripMenuItem_Click);
            // 
            // technoToolStripMenuItem
            // 
            resources.ApplyResources(this.technoToolStripMenuItem, "technoToolStripMenuItem");
            this.technoToolStripMenuItem.Name = "technoToolStripMenuItem";
            this.technoToolStripMenuItem.Click += new System.EventHandler(this.technoToolStripMenuItem_Click);
            // 
            // classicToolStripMenuItem
            // 
            resources.ApplyResources(this.classicToolStripMenuItem, "classicToolStripMenuItem");
            this.classicToolStripMenuItem.Name = "classicToolStripMenuItem";
            this.classicToolStripMenuItem.Click += new System.EventHandler(this.classicToolStripMenuItem_Click);
            // 
            // voiceBoostToolStripMenuItem
            // 
            resources.ApplyResources(this.voiceBoostToolStripMenuItem, "voiceBoostToolStripMenuItem");
            this.voiceBoostToolStripMenuItem.Name = "voiceBoostToolStripMenuItem";
            this.voiceBoostToolStripMenuItem.Click += new System.EventHandler(this.voiceBoostToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // bassBoostToolStripMenuItem
            // 
            resources.ApplyResources(this.bassBoostToolStripMenuItem, "bassBoostToolStripMenuItem");
            this.bassBoostToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.softToolStripMenuItem,
            this.normalToolStripMenuItem1,
            this.highToolStripMenuItem,
            this.extremeToolStripMenuItem,
            this.maximumToolStripMenuItem});
            this.bassBoostToolStripMenuItem.Name = "bassBoostToolStripMenuItem";
            // 
            // softToolStripMenuItem
            // 
            resources.ApplyResources(this.softToolStripMenuItem, "softToolStripMenuItem");
            this.softToolStripMenuItem.Name = "softToolStripMenuItem";
            this.softToolStripMenuItem.Click += new System.EventHandler(this.softToolStripMenuItem_Click);
            // 
            // normalToolStripMenuItem1
            // 
            resources.ApplyResources(this.normalToolStripMenuItem1, "normalToolStripMenuItem1");
            this.normalToolStripMenuItem1.Name = "normalToolStripMenuItem1";
            this.normalToolStripMenuItem1.Click += new System.EventHandler(this.normalToolStripMenuItem1_Click);
            // 
            // highToolStripMenuItem
            // 
            resources.ApplyResources(this.highToolStripMenuItem, "highToolStripMenuItem");
            this.highToolStripMenuItem.Name = "highToolStripMenuItem";
            this.highToolStripMenuItem.Click += new System.EventHandler(this.highToolStripMenuItem_Click);
            // 
            // extremeToolStripMenuItem
            // 
            resources.ApplyResources(this.extremeToolStripMenuItem, "extremeToolStripMenuItem");
            this.extremeToolStripMenuItem.Name = "extremeToolStripMenuItem";
            this.extremeToolStripMenuItem.Click += new System.EventHandler(this.extremeToolStripMenuItem_Click);
            // 
            // maximumToolStripMenuItem
            // 
            resources.ApplyResources(this.maximumToolStripMenuItem, "maximumToolStripMenuItem");
            this.maximumToolStripMenuItem.Name = "maximumToolStripMenuItem";
            this.maximumToolStripMenuItem.Click += new System.EventHandler(this.maximumToolStripMenuItem_Click);
            // 
            // trebbleBoostToolStripMenuItem
            // 
            resources.ApplyResources(this.trebbleBoostToolStripMenuItem, "trebbleBoostToolStripMenuItem");
            this.trebbleBoostToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.softToolStripMenuItem1,
            this.normalToolStripMenuItem2,
            this.highToolStripMenuItem1,
            this.extremeToolStripMenuItem1,
            this.maximumToolStripMenuItem1});
            this.trebbleBoostToolStripMenuItem.Name = "trebbleBoostToolStripMenuItem";
            // 
            // softToolStripMenuItem1
            // 
            resources.ApplyResources(this.softToolStripMenuItem1, "softToolStripMenuItem1");
            this.softToolStripMenuItem1.Name = "softToolStripMenuItem1";
            this.softToolStripMenuItem1.Click += new System.EventHandler(this.softToolStripMenuItem1_Click);
            // 
            // normalToolStripMenuItem2
            // 
            resources.ApplyResources(this.normalToolStripMenuItem2, "normalToolStripMenuItem2");
            this.normalToolStripMenuItem2.Name = "normalToolStripMenuItem2";
            this.normalToolStripMenuItem2.Click += new System.EventHandler(this.normalToolStripMenuItem2_Click);
            // 
            // highToolStripMenuItem1
            // 
            resources.ApplyResources(this.highToolStripMenuItem1, "highToolStripMenuItem1");
            this.highToolStripMenuItem1.Name = "highToolStripMenuItem1";
            this.highToolStripMenuItem1.Click += new System.EventHandler(this.highToolStripMenuItem1_Click);
            // 
            // extremeToolStripMenuItem1
            // 
            resources.ApplyResources(this.extremeToolStripMenuItem1, "extremeToolStripMenuItem1");
            this.extremeToolStripMenuItem1.Name = "extremeToolStripMenuItem1";
            this.extremeToolStripMenuItem1.Click += new System.EventHandler(this.extremeToolStripMenuItem1_Click);
            // 
            // maximumToolStripMenuItem1
            // 
            resources.ApplyResources(this.maximumToolStripMenuItem1, "maximumToolStripMenuItem1");
            this.maximumToolStripMenuItem1.Name = "maximumToolStripMenuItem1";
            this.maximumToolStripMenuItem1.Click += new System.EventHandler(this.maximumToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            // 
            // heliumEffectToolStripMenuItem
            // 
            resources.ApplyResources(this.heliumEffectToolStripMenuItem, "heliumEffectToolStripMenuItem");
            this.heliumEffectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.softToolStripMenuItem2,
            this.normalToolStripMenuItem3,
            this.extremeToolStripMenuItem2});
            this.heliumEffectToolStripMenuItem.Name = "heliumEffectToolStripMenuItem";
            // 
            // softToolStripMenuItem2
            // 
            resources.ApplyResources(this.softToolStripMenuItem2, "softToolStripMenuItem2");
            this.softToolStripMenuItem2.Name = "softToolStripMenuItem2";
            this.softToolStripMenuItem2.Click += new System.EventHandler(this.softToolStripMenuItem2_Click);
            // 
            // normalToolStripMenuItem3
            // 
            resources.ApplyResources(this.normalToolStripMenuItem3, "normalToolStripMenuItem3");
            this.normalToolStripMenuItem3.Name = "normalToolStripMenuItem3";
            this.normalToolStripMenuItem3.Click += new System.EventHandler(this.normalToolStripMenuItem3_Click);
            // 
            // extremeToolStripMenuItem2
            // 
            resources.ApplyResources(this.extremeToolStripMenuItem2, "extremeToolStripMenuItem2");
            this.extremeToolStripMenuItem2.Name = "extremeToolStripMenuItem2";
            this.extremeToolStripMenuItem2.Click += new System.EventHandler(this.extremeToolStripMenuItem2_Click);
            // 
            // monsterEffectToolStripMenuItem
            // 
            resources.ApplyResources(this.monsterEffectToolStripMenuItem, "monsterEffectToolStripMenuItem");
            this.monsterEffectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.softToolStripMenuItem3,
            this.normalToolStripMenuItem4,
            this.extremeToolStripMenuItem3});
            this.monsterEffectToolStripMenuItem.Name = "monsterEffectToolStripMenuItem";
            // 
            // softToolStripMenuItem3
            // 
            resources.ApplyResources(this.softToolStripMenuItem3, "softToolStripMenuItem3");
            this.softToolStripMenuItem3.Name = "softToolStripMenuItem3";
            this.softToolStripMenuItem3.Click += new System.EventHandler(this.softToolStripMenuItem3_Click);
            // 
            // normalToolStripMenuItem4
            // 
            resources.ApplyResources(this.normalToolStripMenuItem4, "normalToolStripMenuItem4");
            this.normalToolStripMenuItem4.Name = "normalToolStripMenuItem4";
            this.normalToolStripMenuItem4.Click += new System.EventHandler(this.normalToolStripMenuItem4_Click);
            // 
            // extremeToolStripMenuItem3
            // 
            resources.ApplyResources(this.extremeToolStripMenuItem3, "extremeToolStripMenuItem3");
            this.extremeToolStripMenuItem3.Name = "extremeToolStripMenuItem3";
            this.extremeToolStripMenuItem3.Click += new System.EventHandler(this.extremeToolStripMenuItem3_Click);
            // 
            // pluginUI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.presetbox);
            this.Controls.Add(this.resetbox);
            this.Controls.Add(this.echoofflbl);
            this.Controls.Add(this.echooffbar);
            this.Controls.Add(this.stereomixbox);
            this.Controls.Add(this.reversebox);
            this.Controls.Add(this.echolbl);
            this.Controls.Add(this.tempolbl);
            this.Controls.Add(this.pitchlbl);
            this.Controls.Add(this.echobar);
            this.Controls.Add(this.tempobar);
            this.Controls.Add(this.pitchbar);
            this.Controls.Add(this.freqlbl);
            this.Controls.Add(this.freqsr);
            this.Controls.Add(this.freq15k);
            this.Controls.Add(this.freq13k);
            this.Controls.Add(this.freq9k);
            this.Controls.Add(this.freq4d5k);
            this.Controls.Add(this.freq2k);
            this.Controls.Add(this.freq800);
            this.Controls.Add(this.freq455);
            this.Controls.Add(this.freq240);
            this.Controls.Add(this.freq115);
            this.Name = "pluginUI";
            this.Load += new System.EventHandler(this.pluginUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.freq115)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freq240)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freq455)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freq800)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freq2k)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freq4d5k)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freq9k)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freq13k)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freq15k)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freqsr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempobar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.echobar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.echooffbar)).EndInit();
            this.presetmenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar freq115;
        private System.Windows.Forms.TrackBar freq240;
        private System.Windows.Forms.TrackBar freq455;
        private System.Windows.Forms.TrackBar freq800;
        private System.Windows.Forms.TrackBar freq2k;
        private System.Windows.Forms.TrackBar freq4d5k;
        private System.Windows.Forms.TrackBar freq9k;
        private System.Windows.Forms.TrackBar freq13k;
        private System.Windows.Forms.TrackBar freq15k;
        private System.Windows.Forms.TrackBar freqsr;
        private System.Windows.Forms.Label freqlbl;
        private System.Windows.Forms.TrackBar pitchbar;
        private System.Windows.Forms.TrackBar tempobar;
        private System.Windows.Forms.TrackBar echobar;
        private System.Windows.Forms.Label pitchlbl;
        private System.Windows.Forms.Label tempolbl;
        private System.Windows.Forms.Label echolbl;
        private System.Windows.Forms.CheckBox reversebox;
        private System.Windows.Forms.CheckBox stereomixbox;
        private System.Windows.Forms.TrackBar echooffbar;
        private System.Windows.Forms.Label echoofflbl;
        private System.Windows.Forms.Button resetbox;
        private System.Windows.Forms.Button presetbox;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.ContextMenuStrip presetmenu;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem technoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem classicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voiceBoostToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bassBoostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem softToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem highToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extremeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maximumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trebbleBoostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem softToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem highToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem extremeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem maximumToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem heliumEffectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem softToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem extremeToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem monsterEffectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem softToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem normalToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem extremeToolStripMenuItem3;
    }
}

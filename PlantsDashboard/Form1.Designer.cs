namespace PlantsDashboard
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Repository.TrackBarLabel trackBarLabel1 = new DevExpress.XtraEditors.Repository.TrackBarLabel();
            this.formAssistant1 = new DevExpress.XtraBars.FormAssistant();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.chartHumidity = new LiveCharts.WinForms.CartesianChart();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.gaugeIllu = new LiveCharts.WinForms.SolidGauge();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.gaugeAtm = new LiveCharts.WinForms.SolidGauge();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.lbEarthHumid = new DevExpress.XtraEditors.LabelControl();
            this.lbAirHumid = new DevExpress.XtraEditors.LabelControl();
            this.lbTemp = new DevExpress.XtraEditors.LabelControl();
            this.lbIllumination = new DevExpress.XtraEditors.LabelControl();
            this.lbAtm = new DevExpress.XtraEditors.LabelControl();
            this.groupControl7 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btConnect = new DevExpress.XtraEditors.SimpleButton();
            this.btStop = new DevExpress.XtraEditors.SimpleButton();
            this.cbAuto = new DevExpress.XtraEditors.CheckEdit();
            this.lbWThreshold = new DevExpress.XtraEditors.LabelControl();
            this.tbCOM = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.trackThreshold = new DevExpress.XtraEditors.TrackBarControl();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.btDisconnect = new DevExpress.XtraEditors.SimpleButton();
            this.btSave = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).BeginInit();
            this.groupControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbAuto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCOM.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackThreshold.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Metropolis Dark";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.groupControl4);
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1034, 383);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Meter";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.chartHumidity);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(317, 22);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(715, 359);
            this.groupControl4.TabIndex = 2;
            this.groupControl4.Text = "Temperature - Humidity";
            // 
            // chartHumidity
            // 
            this.chartHumidity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartHumidity.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.chartHumidity.Location = new System.Drawing.Point(2, 22);
            this.chartHumidity.Name = "chartHumidity";
            this.chartHumidity.Size = new System.Drawing.Size(711, 335);
            this.chartHumidity.TabIndex = 0;
            this.chartHumidity.Text = "cartesianChart1";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.groupControl6);
            this.groupControl2.Controls.Add(this.groupControl5);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(2, 22);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(315, 359);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Pressure - Light";
            // 
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.gaugeIllu);
            this.groupControl6.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl6.Location = new System.Drawing.Point(2, 220);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(311, 191);
            this.groupControl6.TabIndex = 1;
            this.groupControl6.Text = "Illuminance";
            // 
            // gaugeIllu
            // 
            this.gaugeIllu.Dock = System.Windows.Forms.DockStyle.Top;
            this.gaugeIllu.Location = new System.Drawing.Point(2, 22);
            this.gaugeIllu.Name = "gaugeIllu";
            this.gaugeIllu.Size = new System.Drawing.Size(307, 168);
            this.gaugeIllu.TabIndex = 0;
            this.gaugeIllu.Text = "Illumination";
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.gaugeAtm);
            this.groupControl5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl5.Location = new System.Drawing.Point(2, 22);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(311, 198);
            this.groupControl5.TabIndex = 0;
            this.groupControl5.Text = "Atmosphere Pressure (hPa)";
            // 
            // gaugeAtm
            // 
            this.gaugeAtm.Dock = System.Windows.Forms.DockStyle.Top;
            this.gaugeAtm.Location = new System.Drawing.Point(2, 22);
            this.gaugeAtm.Name = "gaugeAtm";
            this.gaugeAtm.Size = new System.Drawing.Size(307, 160);
            this.gaugeAtm.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Controls.Add(this.groupControl7);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1034, 683);
            this.splitContainerControl1.SplitterPosition = 383;
            this.splitContainerControl1.TabIndex = 2;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.lbEarthHumid);
            this.groupControl3.Controls.Add(this.lbAirHumid);
            this.groupControl3.Controls.Add(this.lbTemp);
            this.groupControl3.Controls.Add(this.lbIllumination);
            this.groupControl3.Controls.Add(this.lbAtm);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(0, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(303, 288);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Data";
            // 
            // lbEarthHumid
            // 
            this.lbEarthHumid.Appearance.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbEarthHumid.Appearance.Options.UseFont = true;
            this.lbEarthHumid.Location = new System.Drawing.Point(23, 141);
            this.lbEarthHumid.Name = "lbEarthHumid";
            this.lbEarthHumid.Size = new System.Drawing.Size(189, 19);
            this.lbEarthHumid.TabIndex = 4;
            this.lbEarthHumid.Text = "Earth Humidity: N/A %";
            // 
            // lbAirHumid
            // 
            this.lbAirHumid.Appearance.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAirHumid.Appearance.Options.UseFont = true;
            this.lbAirHumid.Location = new System.Drawing.Point(23, 110);
            this.lbAirHumid.Name = "lbAirHumid";
            this.lbAirHumid.Size = new System.Drawing.Size(171, 19);
            this.lbAirHumid.TabIndex = 3;
            this.lbAirHumid.Text = "Air Humidity: N/A %";
            // 
            // lbTemp
            // 
            this.lbTemp.Appearance.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTemp.Appearance.Options.UseFont = true;
            this.lbTemp.Location = new System.Drawing.Point(23, 80);
            this.lbTemp.Name = "lbTemp";
            this.lbTemp.Size = new System.Drawing.Size(234, 19);
            this.lbTemp.TabIndex = 2;
            this.lbTemp.Text = "Temperature: N/A (Celsius)";
            // 
            // lbIllumination
            // 
            this.lbIllumination.Appearance.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbIllumination.Appearance.Options.UseFont = true;
            this.lbIllumination.Location = new System.Drawing.Point(23, 49);
            this.lbIllumination.Name = "lbIllumination";
            this.lbIllumination.Size = new System.Drawing.Size(189, 19);
            this.lbIllumination.TabIndex = 1;
            this.lbIllumination.Text = "Illumination: N/A (%)";
            // 
            // lbAtm
            // 
            this.lbAtm.Appearance.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbAtm.Appearance.Options.UseFont = true;
            this.lbAtm.Location = new System.Drawing.Point(23, 19);
            this.lbAtm.Name = "lbAtm";
            this.lbAtm.Size = new System.Drawing.Size(270, 19);
            this.lbAtm.TabIndex = 0;
            this.lbAtm.Text = "Atmosphere Pressure: N/A (hPa)";
            // 
            // groupControl7
            // 
            this.groupControl7.Controls.Add(this.btSave);
            this.groupControl7.Controls.Add(this.btDisconnect);
            this.groupControl7.Controls.Add(this.simpleButton2);
            this.groupControl7.Controls.Add(this.btConnect);
            this.groupControl7.Controls.Add(this.btStop);
            this.groupControl7.Controls.Add(this.cbAuto);
            this.groupControl7.Controls.Add(this.lbWThreshold);
            this.groupControl7.Controls.Add(this.tbCOM);
            this.groupControl7.Controls.Add(this.labelControl1);
            this.groupControl7.Controls.Add(this.trackThreshold);
            this.groupControl7.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl7.Location = new System.Drawing.Point(0, 0);
            this.groupControl7.Name = "groupControl7";
            this.groupControl7.Size = new System.Drawing.Size(412, 288);
            this.groupControl7.TabIndex = 0;
            this.groupControl7.Text = "Setting";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(6, 105);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(183, 23);
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "Watering";
            this.simpleButton2.Click += new System.EventHandler(this.btWatering_Click);
            // 
            // btConnect
            // 
            this.btConnect.Location = new System.Drawing.Point(6, 132);
            this.btConnect.Name = "btConnect";
            this.btConnect.Size = new System.Drawing.Size(382, 23);
            this.btConnect.TabIndex = 8;
            this.btConnect.Text = "Connect";
            this.btConnect.Click += new System.EventHandler(this.btApply_Click);
            // 
            // btStop
            // 
            this.btStop.Location = new System.Drawing.Point(195, 104);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(193, 23);
            this.btStop.TabIndex = 7;
            this.btStop.Text = "Stop watering";
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // cbAuto
            // 
            this.cbAuto.Location = new System.Drawing.Point(296, 71);
            this.cbAuto.Name = "cbAuto";
            this.cbAuto.Properties.Caption = "Automatically";
            this.cbAuto.Size = new System.Drawing.Size(92, 19);
            this.cbAuto.TabIndex = 4;
            // 
            // lbWThreshold
            // 
            this.lbWThreshold.Location = new System.Drawing.Point(13, 79);
            this.lbWThreshold.Name = "lbWThreshold";
            this.lbWThreshold.Size = new System.Drawing.Size(92, 13);
            this.lbWThreshold.TabIndex = 2;
            this.lbWThreshold.Text = "Watering threshold";
            // 
            // tbCOM
            // 
            this.tbCOM.Location = new System.Drawing.Point(129, 40);
            this.tbCOM.Name = "tbCOM";
            this.tbCOM.Size = new System.Drawing.Size(151, 20);
            this.tbCOM.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 49);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "COM Port:";
            // 
            // trackThreshold
            // 
            this.trackThreshold.EditValue = null;
            this.trackThreshold.Location = new System.Drawing.Point(129, 66);
            this.trackThreshold.Name = "trackThreshold";
            this.trackThreshold.Properties.LabelAppearance.Options.UseTextOptions = true;
            this.trackThreshold.Properties.LabelAppearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            trackBarLabel1.Label = "";
            this.trackThreshold.Properties.Labels.AddRange(new DevExpress.XtraEditors.Repository.TrackBarLabel[] {
            trackBarLabel1});
            this.trackThreshold.Properties.Maximum = 100;
            this.trackThreshold.Properties.ShowLabels = true;
            this.trackThreshold.Size = new System.Drawing.Size(151, 72);
            this.trackThreshold.TabIndex = 10;
            this.trackThreshold.EditValueChanged += new System.EventHandler(this.buttonEdit1_EditValueChanged);
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Location = new System.Drawing.Point(412, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.groupControl3);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(622, 288);
            this.splitContainerControl2.SplitterPosition = 303;
            this.splitContainerControl2.TabIndex = 1;
            this.splitContainerControl2.Text = "splitContainerControl2";
            // 
            // btDisconnect
            // 
            this.btDisconnect.Location = new System.Drawing.Point(6, 162);
            this.btDisconnect.Name = "btDisconnect";
            this.btDisconnect.Size = new System.Drawing.Size(382, 23);
            this.btDisconnect.TabIndex = 11;
            this.btDisconnect.Text = "Disconnect";
            this.btDisconnect.Click += new System.EventHandler(this.btDisconnect_Click);
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(6, 191);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(382, 23);
            this.btSave.TabIndex = 12;
            this.btSave.Text = "Write to log";
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 683);
            this.Controls.Add(this.splitContainerControl1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.Name = "Form1";
            this.Text = "Plants Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).EndInit();
            this.groupControl7.ResumeLayout(false);
            this.groupControl7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbAuto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCOM.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackThreshold.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.FormAssistant formAssistant1;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private LiveCharts.WinForms.CartesianChart chartHumidity;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private LiveCharts.WinForms.SolidGauge gaugeIllu;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private LiveCharts.WinForms.SolidGauge gaugeAtm;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl groupControl7;
        private DevExpress.XtraEditors.CheckEdit cbAuto;
        private DevExpress.XtraEditors.LabelControl lbWThreshold;
        private DevExpress.XtraEditors.TextEdit tbCOM;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl lbEarthHumid;
        private DevExpress.XtraEditors.LabelControl lbAirHumid;
        private DevExpress.XtraEditors.LabelControl lbTemp;
        private DevExpress.XtraEditors.LabelControl lbIllumination;
        private DevExpress.XtraEditors.LabelControl lbAtm;
        private DevExpress.XtraEditors.SimpleButton btStop;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btConnect;
        private DevExpress.XtraEditors.TrackBarControl trackThreshold;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.SimpleButton btSave;
        private DevExpress.XtraEditors.SimpleButton btDisconnect;
    }
}


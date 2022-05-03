namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MinTrackBar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.MaxTrackBar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelMin = new System.Windows.Forms.Label();
            this.buttonToggle = new Guna.UI2.WinForms.Guna2Button();
            this.clicktimer = new System.Windows.Forms.Timer(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.checkBoxMC = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.SuspendLayout();
            // 
            // MinTrackBar
            // 
            this.MinTrackBar.Location = new System.Drawing.Point(27, 160);
            this.MinTrackBar.Name = "MinTrackBar";
            this.MinTrackBar.Size = new System.Drawing.Size(269, 23);
            this.MinTrackBar.TabIndex = 1;
            this.MinTrackBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.MinTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.MinTrackBar_Scroll);
            // 
            // MaxTrackBar
            // 
            this.MaxTrackBar.Location = new System.Drawing.Point(27, 108);
            this.MaxTrackBar.Name = "MaxTrackBar";
            this.MaxTrackBar.Size = new System.Drawing.Size(269, 23);
            this.MaxTrackBar.TabIndex = 2;
            this.MaxTrackBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.MaxTrackBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.guna2TrackBar2_Scroll);
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.guna2CircleButton1.Location = new System.Drawing.Point(365, 3);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(35, 33);
            this.guna2CircleButton1.TabIndex = 3;
            this.guna2CircleButton1.Text = "X";
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.labelMax.Location = new System.Drawing.Point(304, 114);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(54, 13);
            this.labelMax.TabIndex = 4;
            this.labelMax.Text = "Max CPS:";
            this.labelMax.Click += new System.EventHandler(this.labelMax_Click);
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.labelMin.Location = new System.Drawing.Point(304, 164);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(51, 13);
            this.labelMin.TabIndex = 5;
            this.labelMin.Text = "Min CPS:";
            // 
            // buttonToggle
            // 
            this.buttonToggle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonToggle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonToggle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonToggle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonToggle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.buttonToggle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.buttonToggle.ForeColor = System.Drawing.Color.White;
            this.buttonToggle.Location = new System.Drawing.Point(263, 219);
            this.buttonToggle.Name = "buttonToggle";
            this.buttonToggle.Size = new System.Drawing.Size(128, 36);
            this.buttonToggle.TabIndex = 6;
            this.buttonToggle.Text = "Toggle : on";
            this.buttonToggle.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // clicktimer
            // 
            this.clicktimer.Tick += new System.EventHandler(this.clicktimer_Tick);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // checkBoxMC
            // 
            this.checkBoxMC.AutoSize = true;
            this.checkBoxMC.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.checkBoxMC.CheckedState.BorderRadius = 1;
            this.checkBoxMC.CheckedState.BorderThickness = 0;
            this.checkBoxMC.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.checkBoxMC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.checkBoxMC.Location = new System.Drawing.Point(264, 198);
            this.checkBoxMC.Name = "checkBoxMC";
            this.checkBoxMC.Size = new System.Drawing.Size(94, 17);
            this.checkBoxMC.TabIndex = 7;
            this.checkBoxMC.Text = "Minecraft Only";
            this.checkBoxMC.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBoxMC.UncheckedState.BorderRadius = 0;
            this.checkBoxMC.UncheckedState.BorderThickness = 0;
            this.checkBoxMC.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBoxMC.CheckedChanged += new System.EventHandler(this.checkBoxMC_CheckedChanged);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 2;
            this.guna2Elipse2.TargetControl = this.buttonToggle;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(404, 284);
            this.Controls.Add(this.checkBoxMC);
            this.Controls.Add(this.buttonToggle);
            this.Controls.Add(this.labelMin);
            this.Controls.Add(this.labelMax);
            this.Controls.Add(this.guna2CircleButton1);
            this.Controls.Add(this.MaxTrackBar);
            this.Controls.Add(this.MinTrackBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Discord";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TrackBar MinTrackBar;
        private Guna.UI2.WinForms.Guna2TrackBar MaxTrackBar;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelMin;
        private Guna.UI2.WinForms.Guna2Button buttonToggle;
        private System.Windows.Forms.Timer clicktimer;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CheckBox checkBoxMC;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
    }
}


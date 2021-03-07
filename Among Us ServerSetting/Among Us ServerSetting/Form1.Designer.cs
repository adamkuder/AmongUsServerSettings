
namespace Among_Us_ServerSetting
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxMap = new System.Windows.Forms.ComboBox();
            this.numericImpostor = new System.Windows.Forms.NumericUpDown();
            this.ButtonPlayerSpeed = new System.Windows.Forms.Button();
            this.ButtonMap = new System.Windows.Forms.Button();
            this.ButtonImpostor = new System.Windows.Forms.Button();
            this.numericPlayerSpeed = new System.Windows.Forms.NumericUpDown();
            this.ButtonImpostorVison = new System.Windows.Forms.Button();
            this.numericImpostorVison = new System.Windows.Forms.NumericUpDown();
            this.numericCrewVison = new System.Windows.Forms.NumericUpDown();
            this.ButtonCrewVison = new System.Windows.Forms.Button();
            this.numericKillCooldown = new System.Windows.Forms.NumericUpDown();
            this.ButonKillCoolDown = new System.Windows.Forms.Button();
            this.groupBoxMap = new System.Windows.Forms.GroupBox();
            this.groupBoxKillCoolDown = new System.Windows.Forms.GroupBox();
            this.groupBoxImpostorVison = new System.Windows.Forms.GroupBox();
            this.groupBoxCrewmateVison = new System.Windows.Forms.GroupBox();
            this.groupBoxPlayerSpeed = new System.Windows.Forms.GroupBox();
            this.groupBoxImpostor = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericImpostor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlayerSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericImpostorVison)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCrewVison)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKillCooldown)).BeginInit();
            this.groupBoxMap.SuspendLayout();
            this.groupBoxKillCoolDown.SuspendLayout();
            this.groupBoxImpostorVison.SuspendLayout();
            this.groupBoxCrewmateVison.SuspendLayout();
            this.groupBoxPlayerSpeed.SuspendLayout();
            this.groupBoxImpostor.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxMap
            // 
            this.comboBoxMap.BackColor = System.Drawing.SystemColors.InfoText;
            this.comboBoxMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxMap.ForeColor = System.Drawing.Color.Lime;
            this.comboBoxMap.FormattingEnabled = true;
            this.comboBoxMap.Location = new System.Drawing.Point(4, 17);
            this.comboBoxMap.Name = "comboBoxMap";
            this.comboBoxMap.Size = new System.Drawing.Size(97, 21);
            this.comboBoxMap.TabIndex = 2;
            // 
            // numericImpostor
            // 
            this.numericImpostor.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.numericImpostor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericImpostor.ForeColor = System.Drawing.Color.Lime;
            this.numericImpostor.Location = new System.Drawing.Point(65, 17);
            this.numericImpostor.Name = "numericImpostor";
            this.numericImpostor.Size = new System.Drawing.Size(36, 20);
            this.numericImpostor.TabIndex = 3;
            this.numericImpostor.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // ButtonPlayerSpeed
            // 
            this.ButtonPlayerSpeed.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonPlayerSpeed.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonPlayerSpeed.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonPlayerSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPlayerSpeed.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonPlayerSpeed.Location = new System.Drawing.Point(107, 17);
            this.ButtonPlayerSpeed.Name = "ButtonPlayerSpeed";
            this.ButtonPlayerSpeed.Size = new System.Drawing.Size(81, 23);
            this.ButtonPlayerSpeed.TabIndex = 7;
            this.ButtonPlayerSpeed.Text = "Change";
            this.ButtonPlayerSpeed.UseVisualStyleBackColor = false;
            this.ButtonPlayerSpeed.Click += new System.EventHandler(this.ButtonPlayerSpeed_Click);
            // 
            // ButtonMap
            // 
            this.ButtonMap.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonMap.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonMap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonMap.Location = new System.Drawing.Point(107, 15);
            this.ButtonMap.Name = "ButtonMap";
            this.ButtonMap.Size = new System.Drawing.Size(81, 23);
            this.ButtonMap.TabIndex = 9;
            this.ButtonMap.Text = "Change Map";
            this.ButtonMap.UseVisualStyleBackColor = false;
            this.ButtonMap.Click += new System.EventHandler(this.ButtonMap_Click);
            // 
            // ButtonImpostor
            // 
            this.ButtonImpostor.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonImpostor.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonImpostor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonImpostor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonImpostor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonImpostor.Location = new System.Drawing.Point(107, 14);
            this.ButtonImpostor.Name = "ButtonImpostor";
            this.ButtonImpostor.Size = new System.Drawing.Size(81, 23);
            this.ButtonImpostor.TabIndex = 11;
            this.ButtonImpostor.Text = "Change Impo";
            this.ButtonImpostor.UseVisualStyleBackColor = false;
            this.ButtonImpostor.Click += new System.EventHandler(this.ButtonImpostor_Click);
            // 
            // numericPlayerSpeed
            // 
            this.numericPlayerSpeed.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.numericPlayerSpeed.DecimalPlaces = 2;
            this.numericPlayerSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericPlayerSpeed.ForeColor = System.Drawing.Color.Lime;
            this.numericPlayerSpeed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericPlayerSpeed.Location = new System.Drawing.Point(48, 17);
            this.numericPlayerSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericPlayerSpeed.Name = "numericPlayerSpeed";
            this.numericPlayerSpeed.Size = new System.Drawing.Size(53, 20);
            this.numericPlayerSpeed.TabIndex = 13;
            this.numericPlayerSpeed.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // ButtonImpostorVison
            // 
            this.ButtonImpostorVison.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonImpostorVison.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonImpostorVison.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonImpostorVison.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonImpostorVison.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonImpostorVison.Location = new System.Drawing.Point(107, 14);
            this.ButtonImpostorVison.Name = "ButtonImpostorVison";
            this.ButtonImpostorVison.Size = new System.Drawing.Size(81, 23);
            this.ButtonImpostorVison.TabIndex = 14;
            this.ButtonImpostorVison.Text = "Change";
            this.ButtonImpostorVison.UseVisualStyleBackColor = false;
            this.ButtonImpostorVison.Click += new System.EventHandler(this.ButtonImpostorVison_Click);
            // 
            // numericImpostorVison
            // 
            this.numericImpostorVison.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.numericImpostorVison.DecimalPlaces = 2;
            this.numericImpostorVison.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericImpostorVison.ForeColor = System.Drawing.Color.Lime;
            this.numericImpostorVison.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericImpostorVison.Location = new System.Drawing.Point(48, 17);
            this.numericImpostorVison.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericImpostorVison.Name = "numericImpostorVison";
            this.numericImpostorVison.Size = new System.Drawing.Size(53, 20);
            this.numericImpostorVison.TabIndex = 15;
            this.numericImpostorVison.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericCrewVison
            // 
            this.numericCrewVison.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.numericCrewVison.DecimalPlaces = 2;
            this.numericCrewVison.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericCrewVison.ForeColor = System.Drawing.Color.Lime;
            this.numericCrewVison.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericCrewVison.Location = new System.Drawing.Point(48, 17);
            this.numericCrewVison.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericCrewVison.Name = "numericCrewVison";
            this.numericCrewVison.Size = new System.Drawing.Size(53, 20);
            this.numericCrewVison.TabIndex = 16;
            this.numericCrewVison.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // ButtonCrewVison
            // 
            this.ButtonCrewVison.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ButtonCrewVison.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButtonCrewVison.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonCrewVison.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCrewVison.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonCrewVison.Location = new System.Drawing.Point(107, 14);
            this.ButtonCrewVison.Name = "ButtonCrewVison";
            this.ButtonCrewVison.Size = new System.Drawing.Size(81, 23);
            this.ButtonCrewVison.TabIndex = 17;
            this.ButtonCrewVison.Text = "Change";
            this.ButtonCrewVison.UseVisualStyleBackColor = false;
            this.ButtonCrewVison.Click += new System.EventHandler(this.ButtonCrewVison_Click);
            // 
            // numericKillCooldown
            // 
            this.numericKillCooldown.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.numericKillCooldown.DecimalPlaces = 2;
            this.numericKillCooldown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericKillCooldown.ForeColor = System.Drawing.Color.Lime;
            this.numericKillCooldown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericKillCooldown.Location = new System.Drawing.Point(48, 17);
            this.numericKillCooldown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericKillCooldown.Name = "numericKillCooldown";
            this.numericKillCooldown.Size = new System.Drawing.Size(53, 20);
            this.numericKillCooldown.TabIndex = 18;
            this.numericKillCooldown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // ButonKillCoolDown
            // 
            this.ButonKillCoolDown.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ButonKillCoolDown.Cursor = System.Windows.Forms.Cursors.Default;
            this.ButonKillCoolDown.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButonKillCoolDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButonKillCoolDown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButonKillCoolDown.Location = new System.Drawing.Point(107, 14);
            this.ButonKillCoolDown.Name = "ButonKillCoolDown";
            this.ButonKillCoolDown.Size = new System.Drawing.Size(81, 23);
            this.ButonKillCoolDown.TabIndex = 19;
            this.ButonKillCoolDown.Text = "Change";
            this.ButonKillCoolDown.UseVisualStyleBackColor = false;
            this.ButonKillCoolDown.Click += new System.EventHandler(this.ButonKillCoolDown_Click);
            // 
            // groupBoxMap
            // 
            this.groupBoxMap.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBoxMap.Controls.Add(this.comboBoxMap);
            this.groupBoxMap.Controls.Add(this.ButtonMap);
            this.groupBoxMap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxMap.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxMap.Location = new System.Drawing.Point(11, 12);
            this.groupBoxMap.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxMap.Name = "groupBoxMap";
            this.groupBoxMap.Padding = new System.Windows.Forms.Padding(1);
            this.groupBoxMap.Size = new System.Drawing.Size(200, 46);
            this.groupBoxMap.TabIndex = 20;
            this.groupBoxMap.TabStop = false;
            this.groupBoxMap.Text = "Map";
            // 
            // groupBoxKillCoolDown
            // 
            this.groupBoxKillCoolDown.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBoxKillCoolDown.Controls.Add(this.numericKillCooldown);
            this.groupBoxKillCoolDown.Controls.Add(this.ButonKillCoolDown);
            this.groupBoxKillCoolDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxKillCoolDown.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxKillCoolDown.Location = new System.Drawing.Point(11, 262);
            this.groupBoxKillCoolDown.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxKillCoolDown.Name = "groupBoxKillCoolDown";
            this.groupBoxKillCoolDown.Padding = new System.Windows.Forms.Padding(1);
            this.groupBoxKillCoolDown.Size = new System.Drawing.Size(200, 46);
            this.groupBoxKillCoolDown.TabIndex = 21;
            this.groupBoxKillCoolDown.TabStop = false;
            this.groupBoxKillCoolDown.Text = "KillCoolDown";
            // 
            // groupBoxImpostorVison
            // 
            this.groupBoxImpostorVison.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBoxImpostorVison.Controls.Add(this.numericImpostorVison);
            this.groupBoxImpostorVison.Controls.Add(this.ButtonImpostorVison);
            this.groupBoxImpostorVison.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxImpostorVison.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxImpostorVison.Location = new System.Drawing.Point(11, 212);
            this.groupBoxImpostorVison.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxImpostorVison.Name = "groupBoxImpostorVison";
            this.groupBoxImpostorVison.Padding = new System.Windows.Forms.Padding(1);
            this.groupBoxImpostorVison.Size = new System.Drawing.Size(200, 46);
            this.groupBoxImpostorVison.TabIndex = 22;
            this.groupBoxImpostorVison.TabStop = false;
            this.groupBoxImpostorVison.Text = "Impostor Vison";
            // 
            // groupBoxCrewmateVison
            // 
            this.groupBoxCrewmateVison.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBoxCrewmateVison.Controls.Add(this.numericCrewVison);
            this.groupBoxCrewmateVison.Controls.Add(this.ButtonCrewVison);
            this.groupBoxCrewmateVison.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxCrewmateVison.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxCrewmateVison.Location = new System.Drawing.Point(11, 162);
            this.groupBoxCrewmateVison.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxCrewmateVison.Name = "groupBoxCrewmateVison";
            this.groupBoxCrewmateVison.Padding = new System.Windows.Forms.Padding(1);
            this.groupBoxCrewmateVison.Size = new System.Drawing.Size(200, 46);
            this.groupBoxCrewmateVison.TabIndex = 22;
            this.groupBoxCrewmateVison.TabStop = false;
            this.groupBoxCrewmateVison.Text = "Crewmate Vison";
            // 
            // groupBoxPlayerSpeed
            // 
            this.groupBoxPlayerSpeed.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBoxPlayerSpeed.Controls.Add(this.numericPlayerSpeed);
            this.groupBoxPlayerSpeed.Controls.Add(this.ButtonPlayerSpeed);
            this.groupBoxPlayerSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxPlayerSpeed.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxPlayerSpeed.Location = new System.Drawing.Point(11, 112);
            this.groupBoxPlayerSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxPlayerSpeed.Name = "groupBoxPlayerSpeed";
            this.groupBoxPlayerSpeed.Padding = new System.Windows.Forms.Padding(1);
            this.groupBoxPlayerSpeed.Size = new System.Drawing.Size(200, 46);
            this.groupBoxPlayerSpeed.TabIndex = 22;
            this.groupBoxPlayerSpeed.TabStop = false;
            this.groupBoxPlayerSpeed.Text = "Player Speed";
            // 
            // groupBoxImpostor
            // 
            this.groupBoxImpostor.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBoxImpostor.Controls.Add(this.numericImpostor);
            this.groupBoxImpostor.Controls.Add(this.ButtonImpostor);
            this.groupBoxImpostor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBoxImpostor.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBoxImpostor.Location = new System.Drawing.Point(11, 62);
            this.groupBoxImpostor.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxImpostor.Name = "groupBoxImpostor";
            this.groupBoxImpostor.Padding = new System.Windows.Forms.Padding(1);
            this.groupBoxImpostor.Size = new System.Drawing.Size(200, 46);
            this.groupBoxImpostor.TabIndex = 22;
            this.groupBoxImpostor.TabStop = false;
            this.groupBoxImpostor.Text = "Impostor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Autor: Adam Kuder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(223, 334);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxImpostorVison);
            this.Controls.Add(this.groupBoxPlayerSpeed);
            this.Controls.Add(this.groupBoxImpostor);
            this.Controls.Add(this.groupBoxCrewmateVison);
            this.Controls.Add(this.groupBoxKillCoolDown);
            this.Controls.Add(this.groupBoxMap);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Server Setting";
            ((System.ComponentModel.ISupportInitialize)(this.numericImpostor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericPlayerSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericImpostorVison)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCrewVison)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericKillCooldown)).EndInit();
            this.groupBoxMap.ResumeLayout(false);
            this.groupBoxKillCoolDown.ResumeLayout(false);
            this.groupBoxImpostorVison.ResumeLayout(false);
            this.groupBoxCrewmateVison.ResumeLayout(false);
            this.groupBoxPlayerSpeed.ResumeLayout(false);
            this.groupBoxImpostor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxMap;
        private System.Windows.Forms.NumericUpDown numericImpostor;
        private System.Windows.Forms.Button ButtonPlayerSpeed;
        private System.Windows.Forms.Button ButtonMap;
        private System.Windows.Forms.Button ButtonImpostor;
        private System.Windows.Forms.NumericUpDown numericPlayerSpeed;
        private System.Windows.Forms.Button ButtonImpostorVison;
        private System.Windows.Forms.NumericUpDown numericImpostorVison;
        private System.Windows.Forms.NumericUpDown numericCrewVison;
        private System.Windows.Forms.Button ButtonCrewVison;
        private System.Windows.Forms.NumericUpDown numericKillCooldown;
        private System.Windows.Forms.Button ButonKillCoolDown;
        private System.Windows.Forms.GroupBox groupBoxMap;
        private System.Windows.Forms.GroupBox groupBoxKillCoolDown;
        private System.Windows.Forms.GroupBox groupBoxImpostorVison;
        private System.Windows.Forms.GroupBox groupBoxCrewmateVison;
        private System.Windows.Forms.GroupBox groupBoxPlayerSpeed;
        private System.Windows.Forms.GroupBox groupBoxImpostor;
        private System.Windows.Forms.Label label1;
    }
}



namespace Baigiamasis_darbas_Alcotesterio_simuliatorius
{
    partial class Main_Form1
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
            this.controlPanel_groupBox1 = new System.Windows.Forms.GroupBox();
            this.comPort_groupBox1 = new System.Windows.Forms.GroupBox();
            this.comPort_comboBox1 = new System.Windows.Forms.ComboBox();
            this.boud_comboBox2 = new System.Windows.Forms.ComboBox();
            this.connect_button1 = new System.Windows.Forms.Button();
            this.alcoMsg_groupBox1 = new System.Windows.Forms.GroupBox();
            this.on_checkBox1 = new System.Windows.Forms.CheckBox();
            this.blow_checkBox2 = new System.Windows.Forms.CheckBox();
            this.aboveDispl_checkBox3 = new System.Windows.Forms.CheckBox();
            this.aboveAlcLim_checkBox4 = new System.Windows.Forms.CheckBox();
            this.belowAlcLim_checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.errFlow_checkBox7 = new System.Windows.Forms.CheckBox();
            this.errTemp_checkBox8 = new System.Windows.Forms.CheckBox();
            this.errSuck_checkBox9 = new System.Windows.Forms.CheckBox();
            this.errBreathTemp_checkBox1 = new System.Windows.Forms.CheckBox();
            this.controlPanel_groupBox1.SuspendLayout();
            this.comPort_groupBox1.SuspendLayout();
            this.alcoMsg_groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // controlPanel_groupBox1
            // 
            this.controlPanel_groupBox1.Controls.Add(this.alcoMsg_groupBox1);
            this.controlPanel_groupBox1.Controls.Add(this.comPort_groupBox1);
            this.controlPanel_groupBox1.Location = new System.Drawing.Point(12, 12);
            this.controlPanel_groupBox1.Name = "controlPanel_groupBox1";
            this.controlPanel_groupBox1.Size = new System.Drawing.Size(776, 426);
            this.controlPanel_groupBox1.TabIndex = 0;
            this.controlPanel_groupBox1.TabStop = false;
            this.controlPanel_groupBox1.Text = "Control Panel";
            // 
            // comPort_groupBox1
            // 
            this.comPort_groupBox1.Controls.Add(this.connect_button1);
            this.comPort_groupBox1.Controls.Add(this.boud_comboBox2);
            this.comPort_groupBox1.Controls.Add(this.comPort_comboBox1);
            this.comPort_groupBox1.Location = new System.Drawing.Point(6, 19);
            this.comPort_groupBox1.Name = "comPort_groupBox1";
            this.comPort_groupBox1.Size = new System.Drawing.Size(469, 101);
            this.comPort_groupBox1.TabIndex = 0;
            this.comPort_groupBox1.TabStop = false;
            this.comPort_groupBox1.Text = "COM Port setting:";
            // 
            // comPort_comboBox1
            // 
            this.comPort_comboBox1.FormattingEnabled = true;
            this.comPort_comboBox1.Location = new System.Drawing.Point(6, 46);
            this.comPort_comboBox1.Name = "comPort_comboBox1";
            this.comPort_comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comPort_comboBox1.TabIndex = 0;
            // 
            // boud_comboBox2
            // 
            this.boud_comboBox2.FormattingEnabled = true;
            this.boud_comboBox2.Location = new System.Drawing.Point(168, 46);
            this.boud_comboBox2.Name = "boud_comboBox2";
            this.boud_comboBox2.Size = new System.Drawing.Size(156, 21);
            this.boud_comboBox2.TabIndex = 1;
            // 
            // connect_button1
            // 
            this.connect_button1.Location = new System.Drawing.Point(330, 46);
            this.connect_button1.Name = "connect_button1";
            this.connect_button1.Size = new System.Drawing.Size(133, 21);
            this.connect_button1.TabIndex = 2;
            this.connect_button1.Text = "Connect";
            this.connect_button1.UseVisualStyleBackColor = true;
            // 
            // alcoMsg_groupBox1
            // 
            this.alcoMsg_groupBox1.Controls.Add(this.errBreathTemp_checkBox1);
            this.alcoMsg_groupBox1.Controls.Add(this.errSuck_checkBox9);
            this.alcoMsg_groupBox1.Controls.Add(this.errTemp_checkBox8);
            this.alcoMsg_groupBox1.Controls.Add(this.errFlow_checkBox7);
            this.alcoMsg_groupBox1.Controls.Add(this.checkBox6);
            this.alcoMsg_groupBox1.Controls.Add(this.belowAlcLim_checkBox5);
            this.alcoMsg_groupBox1.Controls.Add(this.aboveAlcLim_checkBox4);
            this.alcoMsg_groupBox1.Controls.Add(this.aboveDispl_checkBox3);
            this.alcoMsg_groupBox1.Controls.Add(this.blow_checkBox2);
            this.alcoMsg_groupBox1.Controls.Add(this.on_checkBox1);
            this.alcoMsg_groupBox1.Location = new System.Drawing.Point(481, 19);
            this.alcoMsg_groupBox1.Name = "alcoMsg_groupBox1";
            this.alcoMsg_groupBox1.Size = new System.Drawing.Size(289, 401);
            this.alcoMsg_groupBox1.TabIndex = 1;
            this.alcoMsg_groupBox1.TabStop = false;
            this.alcoMsg_groupBox1.Text = "Alcotester message settings:";
            // 
            // on_checkBox1
            // 
            this.on_checkBox1.AutoSize = true;
            this.on_checkBox1.Location = new System.Drawing.Point(6, 19);
            this.on_checkBox1.Name = "on_checkBox1";
            this.on_checkBox1.Size = new System.Drawing.Size(75, 17);
            this.on_checkBox1.TabIndex = 0;
            this.on_checkBox1.Text = "Power ON";
            this.on_checkBox1.UseVisualStyleBackColor = true;
            this.on_checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // blow_checkBox2
            // 
            this.blow_checkBox2.AutoSize = true;
            this.blow_checkBox2.Location = new System.Drawing.Point(6, 42);
            this.blow_checkBox2.Name = "blow_checkBox2";
            this.blow_checkBox2.Size = new System.Drawing.Size(87, 17);
            this.blow_checkBox2.TabIndex = 1;
            this.blow_checkBox2.Text = "Start blowing";
            this.blow_checkBox2.UseVisualStyleBackColor = true;
            // 
            // aboveDispl_checkBox3
            // 
            this.aboveDispl_checkBox3.AutoSize = true;
            this.aboveDispl_checkBox3.Location = new System.Drawing.Point(6, 65);
            this.aboveDispl_checkBox3.Name = "aboveDispl_checkBox3";
            this.aboveDispl_checkBox3.Size = new System.Drawing.Size(122, 17);
            this.aboveDispl_checkBox3.TabIndex = 2;
            this.aboveDispl_checkBox3.Text = "Above display range";
            this.aboveDispl_checkBox3.UseVisualStyleBackColor = true;
            // 
            // aboveAlcLim_checkBox4
            // 
            this.aboveAlcLim_checkBox4.AutoSize = true;
            this.aboveAlcLim_checkBox4.Location = new System.Drawing.Point(6, 88);
            this.aboveAlcLim_checkBox4.Name = "aboveAlcLim_checkBox4";
            this.aboveAlcLim_checkBox4.Size = new System.Drawing.Size(114, 17);
            this.aboveAlcLim_checkBox4.TabIndex = 3;
            this.aboveAlcLim_checkBox4.Text = "Above alcohol limit";
            this.aboveAlcLim_checkBox4.UseVisualStyleBackColor = true;
            // 
            // belowAlcLim_checkBox5
            // 
            this.belowAlcLim_checkBox5.AutoSize = true;
            this.belowAlcLim_checkBox5.Location = new System.Drawing.Point(6, 111);
            this.belowAlcLim_checkBox5.Name = "belowAlcLim_checkBox5";
            this.belowAlcLim_checkBox5.Size = new System.Drawing.Size(112, 17);
            this.belowAlcLim_checkBox5.TabIndex = 4;
            this.belowAlcLim_checkBox5.Text = "Below alcohol limit";
            this.belowAlcLim_checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(6, 134);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(94, 17);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Text = "Test value *‰";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // errFlow_checkBox7
            // 
            this.errFlow_checkBox7.AutoSize = true;
            this.errFlow_checkBox7.Location = new System.Drawing.Point(6, 157);
            this.errFlow_checkBox7.Name = "errFlow_checkBox7";
            this.errFlow_checkBox7.Size = new System.Drawing.Size(124, 17);
            this.errFlow_checkBox7.TabIndex = 6;
            this.errFlow_checkBox7.Text = "Error for blowing flow";
            this.errFlow_checkBox7.UseVisualStyleBackColor = true;
            this.errFlow_checkBox7.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // errTemp_checkBox8
            // 
            this.errTemp_checkBox8.AutoSize = true;
            this.errTemp_checkBox8.Location = new System.Drawing.Point(6, 180);
            this.errTemp_checkBox8.Name = "errTemp_checkBox8";
            this.errTemp_checkBox8.Size = new System.Drawing.Size(161, 17);
            this.errTemp_checkBox8.TabIndex = 7;
            this.errTemp_checkBox8.Text = "Error for outdoor temperature";
            this.errTemp_checkBox8.UseVisualStyleBackColor = true;
            // 
            // errSuck_checkBox9
            // 
            this.errSuck_checkBox9.AutoSize = true;
            this.errSuck_checkBox9.Location = new System.Drawing.Point(6, 203);
            this.errSuck_checkBox9.Name = "errSuck_checkBox9";
            this.errSuck_checkBox9.Size = new System.Drawing.Size(119, 17);
            this.errSuck_checkBox9.TabIndex = 8;
            this.errSuck_checkBox9.Text = "Error in sucking test";
            this.errSuck_checkBox9.UseVisualStyleBackColor = true;
            // 
            // errBreathTemp_checkBox1
            // 
            this.errBreathTemp_checkBox1.AutoSize = true;
            this.errBreathTemp_checkBox1.Location = new System.Drawing.Point(6, 226);
            this.errBreathTemp_checkBox1.Name = "errBreathTemp_checkBox1";
            this.errBreathTemp_checkBox1.Size = new System.Drawing.Size(151, 17);
            this.errBreathTemp_checkBox1.TabIndex = 9;
            this.errBreathTemp_checkBox1.Text = "Error in breath temperature";
            this.errBreathTemp_checkBox1.UseVisualStyleBackColor = true;
            // 
            // Main_Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.controlPanel_groupBox1);
            this.Name = "Main_Form1";
            this.Text = "Alcotester Simulator";
            this.controlPanel_groupBox1.ResumeLayout(false);
            this.comPort_groupBox1.ResumeLayout(false);
            this.alcoMsg_groupBox1.ResumeLayout(false);
            this.alcoMsg_groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox controlPanel_groupBox1;
        private System.Windows.Forms.GroupBox alcoMsg_groupBox1;
        private System.Windows.Forms.GroupBox comPort_groupBox1;
        private System.Windows.Forms.Button connect_button1;
        private System.Windows.Forms.ComboBox boud_comboBox2;
        private System.Windows.Forms.ComboBox comPort_comboBox1;
        private System.Windows.Forms.CheckBox errSuck_checkBox9;
        private System.Windows.Forms.CheckBox errTemp_checkBox8;
        private System.Windows.Forms.CheckBox errFlow_checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox belowAlcLim_checkBox5;
        private System.Windows.Forms.CheckBox aboveAlcLim_checkBox4;
        private System.Windows.Forms.CheckBox aboveDispl_checkBox3;
        private System.Windows.Forms.CheckBox blow_checkBox2;
        private System.Windows.Forms.CheckBox on_checkBox1;
        private System.Windows.Forms.CheckBox errBreathTemp_checkBox1;
    }
}


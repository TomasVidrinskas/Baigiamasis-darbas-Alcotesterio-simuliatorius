
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
            this.controlPanel_groupBox1.SuspendLayout();
            this.comPort_groupBox1.SuspendLayout();
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
            this.alcoMsg_groupBox1.Location = new System.Drawing.Point(481, 19);
            this.alcoMsg_groupBox1.Name = "alcoMsg_groupBox1";
            this.alcoMsg_groupBox1.Size = new System.Drawing.Size(289, 401);
            this.alcoMsg_groupBox1.TabIndex = 1;
            this.alcoMsg_groupBox1.TabStop = false;
            this.alcoMsg_groupBox1.Text = "Alcotester message settings:";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox controlPanel_groupBox1;
        private System.Windows.Forms.GroupBox alcoMsg_groupBox1;
        private System.Windows.Forms.GroupBox comPort_groupBox1;
        private System.Windows.Forms.Button connect_button1;
        private System.Windows.Forms.ComboBox boud_comboBox2;
        private System.Windows.Forms.ComboBox comPort_comboBox1;
    }
}


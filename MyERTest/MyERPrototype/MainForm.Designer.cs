namespace MyERPrototype
{
    partial class Prototype
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
            this.groupBoxWR = new System.Windows.Forms.GroupBox();
            this.groupBoxP2 = new System.Windows.Forms.GroupBox();
            this.groupBoxP3 = new System.Windows.Forms.GroupBox();
            this.btnLooping = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timeMoving = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // groupBoxWR
            // 
            this.groupBoxWR.Location = new System.Drawing.Point(110, 130);
            this.groupBoxWR.Name = "groupBoxWR";
            this.groupBoxWR.Size = new System.Drawing.Size(250, 31);
            this.groupBoxWR.TabIndex = 0;
            this.groupBoxWR.TabStop = false;
            this.groupBoxWR.Text = "WaitingRoom";
            this.groupBoxWR.Paint += new System.Windows.Forms.PaintEventHandler(this.groupBoxWR_Paint);
            // 
            // groupBoxP2
            // 
            this.groupBoxP2.Location = new System.Drawing.Point(400, 130);
            this.groupBoxP2.Name = "groupBoxP2";
            this.groupBoxP2.Size = new System.Drawing.Size(250, 31);
            this.groupBoxP2.TabIndex = 1;
            this.groupBoxP2.TabStop = false;
            this.groupBoxP2.Text = "P2Room";
            // 
            // groupBoxP3
            // 
            this.groupBoxP3.Location = new System.Drawing.Point(700, 130);
            this.groupBoxP3.Name = "groupBoxP3";
            this.groupBoxP3.Size = new System.Drawing.Size(250, 31);
            this.groupBoxP3.TabIndex = 1;
            this.groupBoxP3.TabStop = false;
            this.groupBoxP3.Text = "P3Room";
            // 
            // btnLooping
            // 
            this.btnLooping.Location = new System.Drawing.Point(12, 12);
            this.btnLooping.Name = "btnLooping";
            this.btnLooping.Size = new System.Drawing.Size(75, 23);
            this.btnLooping.TabIndex = 2;
            this.btnLooping.Text = "|| / >>";
            this.btnLooping.UseVisualStyleBackColor = true;
            this.btnLooping.Click += new System.EventHandler(this.btnLooping_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(901, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(901, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(901, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(777, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Partient";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(777, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Dr";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(777, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Nurse";
            // 
            // timeMoving
            // 
            this.timeMoving.Enabled = true;
            this.timeMoving.Tick += new System.EventHandler(this.timeMoving_Tick);
            // 
            // Prototype
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 721);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLooping);
            this.Controls.Add(this.groupBoxP3);
            this.Controls.Add(this.groupBoxP2);
            this.Controls.Add(this.groupBoxWR);
            this.Name = "Prototype";
            this.Text = "Prototype";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Prototype_FormClosing);
            this.Load += new System.EventHandler(this.Prototype_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Prototype_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxWR;
        private System.Windows.Forms.GroupBox groupBoxP2;
        private System.Windows.Forms.GroupBox groupBoxP3;
        private System.Windows.Forms.Button btnLooping;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timeMoving;
    }


}


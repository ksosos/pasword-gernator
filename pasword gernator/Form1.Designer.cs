namespace pasword_gernator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(295, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(370, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Length, if none, it will choose standard (13)";
            // 
            // checkBox1
            // 
            this.checkBox1.Location = new System.Drawing.Point(189, 78);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(139, 44);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Include symbols";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.Location = new System.Drawing.Point(189, 183);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(212, 39);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Use uppercase and lowercase (if unchecked will only use lowercase)";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.Location = new System.Drawing.Point(189, 128);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(118, 39);
            this.checkBox3.TabIndex = 1;
            this.checkBox3.Text = "Include numbers";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(189, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(189, 289);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(267, 59);
            this.textBox2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private CheckBox checkBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
    }
}
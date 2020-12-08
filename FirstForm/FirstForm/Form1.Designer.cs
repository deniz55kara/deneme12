
namespace FirstForm
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
            this.PROCESSOR_COMBOBOX = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PROCESSOR_COMBOBOX
            // 
            this.PROCESSOR_COMBOBOX.FormattingEnabled = true;
            this.PROCESSOR_COMBOBOX.Location = new System.Drawing.Point(260, 42);
            this.PROCESSOR_COMBOBOX.Name = "PROCESSOR_COMBOBOX";
            this.PROCESSOR_COMBOBOX.Size = new System.Drawing.Size(121, 21);
            this.PROCESSOR_COMBOBOX.TabIndex = 2;
            this.PROCESSOR_COMBOBOX.TabStop = false;
            this.PROCESSOR_COMBOBOX.Text = "PROCESSOR";
            this.PROCESSOR_COMBOBOX.SelectedIndexChanged += new System.EventHandler(this.PROCESSOR_COMBOBOX_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "SHOW";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 451);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.PROCESSOR_COMBOBOX);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "FIRST PROJECT";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox PROCESSOR_COMBOBOX;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}


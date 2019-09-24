namespace WindowsFormsMobilePhone
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
            this.labelFormHeader = new System.Windows.Forms.Label();
            this.rbiPhoneHeadset = new System.Windows.Forms.RadioButton();
            this.rbSansungHeadset = new System.Windows.Forms.RadioButton();
            this.rbUnofficialHeadset = new System.Windows.Forms.RadioButton();
            this.rbPhoneSpeaker = new System.Windows.Forms.RadioButton();
            this.butApply = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelFormHeader
            // 
            this.labelFormHeader.AutoSize = true;
            this.labelFormHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelFormHeader.Location = new System.Drawing.Point(28, 32);
            this.labelFormHeader.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFormHeader.Name = "labelFormHeader";
            this.labelFormHeader.Size = new System.Drawing.Size(181, 17);
            this.labelFormHeader.TabIndex = 0;
            this.labelFormHeader.Text = "Select playback component";
            // 
            // rbiPhoneHeadset
            // 
            this.rbiPhoneHeadset.AutoSize = true;
            this.rbiPhoneHeadset.Location = new System.Drawing.Point(31, 70);
            this.rbiPhoneHeadset.Name = "rbiPhoneHeadset";
            this.rbiPhoneHeadset.Size = new System.Drawing.Size(98, 17);
            this.rbiPhoneHeadset.TabIndex = 1;
            this.rbiPhoneHeadset.TabStop = true;
            this.rbiPhoneHeadset.Text = "iPhoneHeadset";
            this.rbiPhoneHeadset.UseVisualStyleBackColor = true;
            // 
            // rbSansungHeadset
            // 
            this.rbSansungHeadset.AutoSize = true;
            this.rbSansungHeadset.Location = new System.Drawing.Point(31, 93);
            this.rbSansungHeadset.Name = "rbSansungHeadset";
            this.rbSansungHeadset.Size = new System.Drawing.Size(109, 17);
            this.rbSansungHeadset.TabIndex = 2;
            this.rbSansungHeadset.TabStop = true;
            this.rbSansungHeadset.Text = "SamsungHeadset";
            this.rbSansungHeadset.UseVisualStyleBackColor = true;
            // 
            // rbUnofficialHeadset
            // 
            this.rbUnofficialHeadset.AutoSize = true;
            this.rbUnofficialHeadset.Location = new System.Drawing.Point(31, 117);
            this.rbUnofficialHeadset.Name = "rbUnofficialHeadset";
            this.rbUnofficialHeadset.Size = new System.Drawing.Size(109, 17);
            this.rbUnofficialHeadset.TabIndex = 3;
            this.rbUnofficialHeadset.TabStop = true;
            this.rbUnofficialHeadset.Text = "UnofficialHeadset";
            this.rbUnofficialHeadset.UseVisualStyleBackColor = true;
            // 
            // rbPhoneSpeaker
            // 
            this.rbPhoneSpeaker.AutoSize = true;
            this.rbPhoneSpeaker.Location = new System.Drawing.Point(31, 141);
            this.rbPhoneSpeaker.Name = "rbPhoneSpeaker";
            this.rbPhoneSpeaker.Size = new System.Drawing.Size(96, 17);
            this.rbPhoneSpeaker.TabIndex = 4;
            this.rbPhoneSpeaker.TabStop = true;
            this.rbPhoneSpeaker.Text = "PhoneSpeaker";
            this.rbPhoneSpeaker.UseVisualStyleBackColor = true;
            // 
            // butApply
            // 
            this.butApply.Location = new System.Drawing.Point(238, 141);
            this.butApply.Name = "butApply";
            this.butApply.Size = new System.Drawing.Size(103, 23);
            this.butApply.TabIndex = 5;
            this.butApply.Text = "Apply";
            this.butApply.UseVisualStyleBackColor = true;
            this.butApply.Click += new System.EventHandler(this.butApply_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 237);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(310, 210);
            this.textBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 473);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.butApply);
            this.Controls.Add(this.rbPhoneSpeaker);
            this.Controls.Add(this.rbUnofficialHeadset);
            this.Controls.Add(this.rbSansungHeadset);
            this.Controls.Add(this.rbiPhoneHeadset);
            this.Controls.Add(this.labelFormHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "WinForms Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFormHeader;
        private System.Windows.Forms.RadioButton rbiPhoneHeadset;
        private System.Windows.Forms.RadioButton rbSansungHeadset;
        private System.Windows.Forms.RadioButton rbUnofficialHeadset;
        private System.Windows.Forms.RadioButton rbPhoneSpeaker;
        private System.Windows.Forms.Button butApply;
        private System.Windows.Forms.TextBox textBox1;
    }
}


namespace WindowsFormsApplication1
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ImportDfa = new System.Windows.Forms.Button();
            this.rtb_displayDfa = new System.Windows.Forms.RichTextBox();
            this.labelDfa = new System.Windows.Forms.Label();
            this.rtb_stringToCheck = new System.Windows.Forms.RichTextBox();
            this.btn_submitString = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Davids Super Awesome DFA Checker";
            // 
            // btn_ImportDfa
            // 
            this.btn_ImportDfa.Location = new System.Drawing.Point(108, 72);
            this.btn_ImportDfa.Name = "btn_ImportDfa";
            this.btn_ImportDfa.Size = new System.Drawing.Size(75, 23);
            this.btn_ImportDfa.TabIndex = 1;
            this.btn_ImportDfa.Text = "Import DFA";
            this.btn_ImportDfa.UseVisualStyleBackColor = true;
            this.btn_ImportDfa.Click += new System.EventHandler(this.btn_ImportDfa_Click);
            // 
            // rtb_displayDfa
            // 
            this.rtb_displayDfa.Location = new System.Drawing.Point(108, 101);
            this.rtb_displayDfa.Name = "rtb_displayDfa";
            this.rtb_displayDfa.Size = new System.Drawing.Size(494, 266);
            this.rtb_displayDfa.TabIndex = 2;
            this.rtb_displayDfa.Text = "";
            // 
            // labelDfa
            // 
            this.labelDfa.AutoSize = true;
            this.labelDfa.Location = new System.Drawing.Point(299, 82);
            this.labelDfa.Name = "labelDfa";
            this.labelDfa.Size = new System.Drawing.Size(56, 13);
            this.labelDfa.TabIndex = 3;
            this.labelDfa.Text = "Your DFA.";
            this.labelDfa.Visible = false;
            // 
            // rtb_stringToCheck
            // 
            this.rtb_stringToCheck.Location = new System.Drawing.Point(108, 422);
            this.rtb_stringToCheck.Name = "rtb_stringToCheck";
            this.rtb_stringToCheck.Size = new System.Drawing.Size(297, 51);
            this.rtb_stringToCheck.TabIndex = 4;
            this.rtb_stringToCheck.Text = "Please enter a string to check";
            this.rtb_stringToCheck.Click += new System.EventHandler(this.rtb_stringCheckClick);
            // 
            // btn_submitString
            // 
            this.btn_submitString.Location = new System.Drawing.Point(108, 480);
            this.btn_submitString.Name = "btn_submitString";
            this.btn_submitString.Size = new System.Drawing.Size(75, 23);
            this.btn_submitString.TabIndex = 5;
            this.btn_submitString.Text = "Submit";
            this.btn_submitString.UseVisualStyleBackColor = true;
            this.btn_submitString.Click += new System.EventHandler(this.btn_submitString_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 579);
            this.Controls.Add(this.btn_submitString);
            this.Controls.Add(this.rtb_stringToCheck);
            this.Controls.Add(this.labelDfa);
            this.Controls.Add(this.rtb_displayDfa);
            this.Controls.Add(this.btn_ImportDfa);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ImportDfa;
        private System.Windows.Forms.RichTextBox rtb_displayDfa;
        private System.Windows.Forms.Label labelDfa;
        private System.Windows.Forms.RichTextBox rtb_stringToCheck;
        private System.Windows.Forms.Button btn_submitString;
    }
}


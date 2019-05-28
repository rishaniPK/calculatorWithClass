namespace calculatorWithClass
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
            this.lbl_1st = new System.Windows.Forms.Label();
            this.lbl_2nd = new System.Windows.Forms.Label();
            this.lbl_resu = new System.Windows.Forms.Label();
            this.txt_num1 = new System.Windows.Forms.TextBox();
            this.txt_num2 = new System.Windows.Forms.TextBox();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_multi = new System.Windows.Forms.Button();
            this.btn_divi = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_1st
            // 
            this.lbl_1st.AutoSize = true;
            this.lbl_1st.Location = new System.Drawing.Point(98, 54);
            this.lbl_1st.Name = "lbl_1st";
            this.lbl_1st.Size = new System.Drawing.Size(66, 13);
            this.lbl_1st.TabIndex = 0;
            this.lbl_1st.Text = "First Number";
            // 
            // lbl_2nd
            // 
            this.lbl_2nd.AutoSize = true;
            this.lbl_2nd.Location = new System.Drawing.Point(98, 87);
            this.lbl_2nd.Name = "lbl_2nd";
            this.lbl_2nd.Size = new System.Drawing.Size(84, 13);
            this.lbl_2nd.TabIndex = 1;
            this.lbl_2nd.Text = "Second Number";
            // 
            // lbl_resu
            // 
            this.lbl_resu.AutoSize = true;
            this.lbl_resu.Location = new System.Drawing.Point(98, 120);
            this.lbl_resu.Name = "lbl_resu";
            this.lbl_resu.Size = new System.Drawing.Size(37, 13);
            this.lbl_resu.TabIndex = 2;
            this.lbl_resu.Text = "Result";
            // 
            // txt_num1
            // 
            this.txt_num1.Location = new System.Drawing.Point(228, 54);
            this.txt_num1.Name = "txt_num1";
            this.txt_num1.Size = new System.Drawing.Size(100, 20);
            this.txt_num1.TabIndex = 3;
            // 
            // txt_num2
            // 
            this.txt_num2.Location = new System.Drawing.Point(228, 87);
            this.txt_num2.Name = "txt_num2";
            this.txt_num2.Size = new System.Drawing.Size(100, 20);
            this.txt_num2.TabIndex = 4;
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(228, 117);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(100, 20);
            this.txt_result.TabIndex = 5;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(32, 174);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(56, 23);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.Location = new System.Drawing.Point(108, 174);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(56, 23);
            this.btn_sub.TabIndex = 7;
            this.btn_sub.Text = "Sub";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.Btn_sub_Click);
            // 
            // btn_multi
            // 
            this.btn_multi.Location = new System.Drawing.Point(170, 174);
            this.btn_multi.Name = "btn_multi";
            this.btn_multi.Size = new System.Drawing.Size(52, 23);
            this.btn_multi.TabIndex = 8;
            this.btn_multi.Text = "Multi";
            this.btn_multi.UseVisualStyleBackColor = true;
            this.btn_multi.Click += new System.EventHandler(this.Btn_multi_Click);
            // 
            // btn_divi
            // 
            this.btn_divi.Location = new System.Drawing.Point(228, 174);
            this.btn_divi.Name = "btn_divi";
            this.btn_divi.Size = new System.Drawing.Size(51, 23);
            this.btn_divi.TabIndex = 9;
            this.btn_divi.Text = "Divi";
            this.btn_divi.UseVisualStyleBackColor = true;
            this.btn_divi.Click += new System.EventHandler(this.Btn_divi_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(295, 174);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(57, 23);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(368, 174);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(52, 23);
            this.btn_exit.TabIndex = 11;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(463, 372);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_divi);
            this.Controls.Add(this.btn_multi);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.txt_num2);
            this.Controls.Add(this.txt_num1);
            this.Controls.Add(this.lbl_resu);
            this.Controls.Add(this.lbl_2nd);
            this.Controls.Add(this.lbl_1st);
            this.Name = "Form1";
            this.Text = "Class Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_1st;
        private System.Windows.Forms.Label lbl_2nd;
        private System.Windows.Forms.Label lbl_resu;
        private System.Windows.Forms.TextBox txt_num1;
        private System.Windows.Forms.TextBox txt_num2;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_multi;
        private System.Windows.Forms.Button btn_divi;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_exit;
    }
}


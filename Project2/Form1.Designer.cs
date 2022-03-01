
namespace Project2
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
            this.lblStudentList = new System.Windows.Forms.Label();
            this.lbxStudentList = new System.Windows.Forms.ListBox();
            this.lblStudentName = new System.Windows.Forms.Label();
            this.tbxStudentName = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnRemovoStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStudentList
            // 
            this.lblStudentList.AutoSize = true;
            this.lblStudentList.Location = new System.Drawing.Point(26, 77);
            this.lblStudentList.Name = "lblStudentList";
            this.lblStudentList.Size = new System.Drawing.Size(105, 20);
            this.lblStudentList.TabIndex = 0;
            this.lblStudentList.Text = "Öğrenci Listesi";
            // 
            // lbxStudentList
            // 
            this.lbxStudentList.FormattingEnabled = true;
            this.lbxStudentList.ItemHeight = 20;
            this.lbxStudentList.Location = new System.Drawing.Point(26, 117);
            this.lbxStudentList.Name = "lbxStudentList";
            this.lbxStudentList.Size = new System.Drawing.Size(150, 184);
            this.lbxStudentList.TabIndex = 1;
            // 
            // lblStudentName
            // 
            this.lblStudentName.AutoSize = true;
            this.lblStudentName.Location = new System.Drawing.Point(380, 77);
            this.lblStudentName.Name = "lblStudentName";
            this.lblStudentName.Size = new System.Drawing.Size(88, 20);
            this.lblStudentName.TabIndex = 2;
            this.lblStudentName.Text = "Öğrenci Adı";
            // 
            // tbxStudentName
            // 
            this.tbxStudentName.Location = new System.Drawing.Point(365, 117);
            this.tbxStudentName.Name = "tbxStudentName";
            this.tbxStudentName.Size = new System.Drawing.Size(125, 27);
            this.tbxStudentName.TabIndex = 3;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(374, 150);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(94, 29);
            this.btnAddStudent.TabIndex = 4;
            this.btnAddStudent.Text = "Ekle";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnRemovoStudent
            // 
            this.btnRemovoStudent.Location = new System.Drawing.Point(37, 307);
            this.btnRemovoStudent.Name = "btnRemovoStudent";
            this.btnRemovoStudent.Size = new System.Drawing.Size(94, 29);
            this.btnRemovoStudent.TabIndex = 5;
            this.btnRemovoStudent.Text = "Öğrenci Sil";
            this.btnRemovoStudent.UseVisualStyleBackColor = true;
            this.btnRemovoStudent.Click += new System.EventHandler(this.btnRemovoStudent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemovoStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.tbxStudentName);
            this.Controls.Add(this.lblStudentName);
            this.Controls.Add(this.lbxStudentList);
            this.Controls.Add(this.lblStudentList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentList;
        private System.Windows.Forms.ListBox lbxStudentList;
        private System.Windows.Forms.Label lblStudentName;
        private System.Windows.Forms.TextBox tbxStudentName;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnRemovoStudent;
    }
}


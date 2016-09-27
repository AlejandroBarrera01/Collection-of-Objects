namespace Collection_of_Objects
{
    partial class CollectionofObjects
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
            this.TCPersonas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.DG1 = new System.Windows.Forms.DataGridView();
            this.btnIngresarP = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxLastNameP = new System.Windows.Forms.TextBox();
            this.TextBoxPhoneNumP = new System.Windows.Forms.TextBox();
            this.TextBoxYeahP = new System.Windows.Forms.TextBox();
            this.TextboxNameP = new System.Windows.Forms.TextBox();
            this.TCDocentes = new System.Windows.Forms.TabPage();
            this.DG2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CBFaccultad = new System.Windows.Forms.ComboBox();
            this.TextBoxSalary = new System.Windows.Forms.TextBox();
            this.TextBoxLastnameD = new System.Windows.Forms.TextBox();
            this.TextBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.TextBoxYearofBirth = new System.Windows.Forms.TextBox();
            this.TextBoxNamesD = new System.Windows.Forms.TextBox();
            this.TCPersonas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG1)).BeginInit();
            this.TCDocentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG2)).BeginInit();
            this.SuspendLayout();
            // 
            // TCPersonas
            // 
            this.TCPersonas.Controls.Add(this.tabPage1);
            this.TCPersonas.Controls.Add(this.TCDocentes);
            this.TCPersonas.Location = new System.Drawing.Point(12, 12);
            this.TCPersonas.Name = "TCPersonas";
            this.TCPersonas.SelectedIndex = 0;
            this.TCPersonas.Size = new System.Drawing.Size(615, 502);
            this.TCPersonas.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnImprimir);
            this.tabPage1.Controls.Add(this.DG1);
            this.tabPage1.Controls.Add(this.btnIngresarP);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.TextBoxLastNameP);
            this.tabPage1.Controls.Add(this.TextBoxPhoneNumP);
            this.tabPage1.Controls.Add(this.TextBoxYeahP);
            this.tabPage1.Controls.Add(this.TextboxNameP);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(607, 474);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Insert People";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(145, 189);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Show";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // DG1
            // 
            this.DG1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG1.Location = new System.Drawing.Point(17, 238);
            this.DG1.Name = "DG1";
            this.DG1.Size = new System.Drawing.Size(519, 209);
            this.DG1.TabIndex = 9;
            // 
            // btnIngresarP
            // 
            this.btnIngresarP.Location = new System.Drawing.Point(17, 189);
            this.btnIngresarP.Name = "btnIngresarP";
            this.btnIngresarP.Size = new System.Drawing.Size(75, 23);
            this.btnIngresarP.TabIndex = 5;
            this.btnIngresarP.Text = "Insert";
            this.btnIngresarP.UseVisualStyleBackColor = true;
            this.btnIngresarP.Click += new System.EventHandler(this.btnIngresarP_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Year of Birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // TextBoxLastNameP
            // 
            this.TextBoxLastNameP.Location = new System.Drawing.Point(3, 79);
            this.TextBoxLastNameP.Name = "TextBoxLastNameP";
            this.TextBoxLastNameP.Size = new System.Drawing.Size(100, 20);
            this.TextBoxLastNameP.TabIndex = 2;
            // 
            // TextBoxPhoneNumP
            // 
            this.TextBoxPhoneNumP.Location = new System.Drawing.Point(3, 105);
            this.TextBoxPhoneNumP.Name = "TextBoxPhoneNumP";
            this.TextBoxPhoneNumP.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPhoneNumP.TabIndex = 3;
            // 
            // TextBoxYeahP
            // 
            this.TextBoxYeahP.Location = new System.Drawing.Point(3, 131);
            this.TextBoxYeahP.Name = "TextBoxYeahP";
            this.TextBoxYeahP.Size = new System.Drawing.Size(100, 20);
            this.TextBoxYeahP.TabIndex = 4;
            // 
            // TextboxNameP
            // 
            this.TextboxNameP.Location = new System.Drawing.Point(3, 53);
            this.TextboxNameP.Name = "TextboxNameP";
            this.TextboxNameP.Size = new System.Drawing.Size(100, 20);
            this.TextboxNameP.TabIndex = 1;
            // 
            // TCDocentes
            // 
            this.TCDocentes.Controls.Add(this.DG2);
            this.TCDocentes.Controls.Add(this.button2);
            this.TCDocentes.Controls.Add(this.btnIngresar);
            this.TCDocentes.Controls.Add(this.label9);
            this.TCDocentes.Controls.Add(this.label8);
            this.TCDocentes.Controls.Add(this.label10);
            this.TCDocentes.Controls.Add(this.label7);
            this.TCDocentes.Controls.Add(this.label6);
            this.TCDocentes.Controls.Add(this.label5);
            this.TCDocentes.Controls.Add(this.CBFaccultad);
            this.TCDocentes.Controls.Add(this.TextBoxSalary);
            this.TCDocentes.Controls.Add(this.TextBoxLastnameD);
            this.TCDocentes.Controls.Add(this.TextBoxPhoneNumber);
            this.TCDocentes.Controls.Add(this.TextBoxYearofBirth);
            this.TCDocentes.Controls.Add(this.TextBoxNamesD);
            this.TCDocentes.Location = new System.Drawing.Point(4, 24);
            this.TCDocentes.Name = "TCDocentes";
            this.TCDocentes.Padding = new System.Windows.Forms.Padding(3);
            this.TCDocentes.Size = new System.Drawing.Size(607, 474);
            this.TCDocentes.TabIndex = 1;
            this.TCDocentes.Text = "Teachers";
            this.TCDocentes.UseVisualStyleBackColor = true;
            // 
            // DG2
            // 
            this.DG2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG2.Location = new System.Drawing.Point(16, 218);
            this.DG2.Name = "DG2";
            this.DG2.Size = new System.Drawing.Size(567, 241);
            this.DG2.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(263, 164);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(157, 164);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 14;
            this.btnIngresar.Text = "Insert";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(349, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Salary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(230, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Faculty";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(230, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Last Names";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(338, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Phone Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Year of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Names";
            // 
            // CBFaccultad
            // 
            this.CBFaccultad.FormattingEnabled = true;
            this.CBFaccultad.Location = new System.Drawing.Point(193, 115);
            this.CBFaccultad.Name = "CBFaccultad";
            this.CBFaccultad.Size = new System.Drawing.Size(100, 21);
            this.CBFaccultad.TabIndex = 5;
            this.CBFaccultad.SelectedIndexChanged += new System.EventHandler(this.CBFaccultad_SelectedIndexChanged);
            // 
            // TextBoxSalary
            // 
            this.TextBoxSalary.Location = new System.Drawing.Point(316, 115);
            this.TextBoxSalary.Name = "TextBoxSalary";
            this.TextBoxSalary.Size = new System.Drawing.Size(100, 20);
            this.TextBoxSalary.TabIndex = 4;
            // 
            // TextBoxLastnameD
            // 
            this.TextBoxLastnameD.Location = new System.Drawing.Point(209, 60);
            this.TextBoxLastnameD.Name = "TextBoxLastnameD";
            this.TextBoxLastnameD.Size = new System.Drawing.Size(100, 20);
            this.TextBoxLastnameD.TabIndex = 3;
            // 
            // TextBoxPhoneNumber
            // 
            this.TextBoxPhoneNumber.Location = new System.Drawing.Point(327, 60);
            this.TextBoxPhoneNumber.Name = "TextBoxPhoneNumber";
            this.TextBoxPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPhoneNumber.TabIndex = 2;
            // 
            // TextBoxYearofBirth
            // 
            this.TextBoxYearofBirth.Location = new System.Drawing.Point(80, 116);
            this.TextBoxYearofBirth.Name = "TextBoxYearofBirth";
            this.TextBoxYearofBirth.Size = new System.Drawing.Size(100, 20);
            this.TextBoxYearofBirth.TabIndex = 1;
            // 
            // TextBoxNamesD
            // 
            this.TextBoxNamesD.Location = new System.Drawing.Point(80, 60);
            this.TextBoxNamesD.Name = "TextBoxNamesD";
            this.TextBoxNamesD.Size = new System.Drawing.Size(100, 20);
            this.TextBoxNamesD.TabIndex = 0;
            // 
            // CollectionofObjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 515);
            this.Controls.Add(this.TCPersonas);
            this.Name = "CollectionofObjects";
            this.Text = "Collection of Objects";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.TCPersonas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG1)).EndInit();
            this.TCDocentes.ResumeLayout(false);
            this.TCDocentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TCPersonas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage TCDocentes;
        private System.Windows.Forms.TextBox TextBoxLastNameP;
        private System.Windows.Forms.TextBox TextBoxPhoneNumP;
        private System.Windows.Forms.TextBox TextBoxYeahP;
        private System.Windows.Forms.TextBox TextboxNameP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.DataGridView DG1;
        private System.Windows.Forms.Button btnIngresarP;
        private System.Windows.Forms.DataGridView DG2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBFaccultad;
        private System.Windows.Forms.TextBox TextBoxSalary;
        private System.Windows.Forms.TextBox TextBoxLastnameD;
        private System.Windows.Forms.TextBox TextBoxPhoneNumber;
        private System.Windows.Forms.TextBox TextBoxYearofBirth;
        private System.Windows.Forms.TextBox TextBoxNamesD;
    }
}


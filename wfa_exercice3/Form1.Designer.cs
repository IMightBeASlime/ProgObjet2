namespace wfa_exercice3
{
    partial class frmExercice3
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
            this.txtFraction1 = new System.Windows.Forms.TextBox();
            this.txtFraction2 = new System.Windows.Forms.TextBox();
            this.txtFractionReponse = new System.Windows.Forms.TextBox();
            this.btnAddition = new System.Windows.Forms.Button();
            this.lblEgal = new System.Windows.Forms.Label();
            this.btnSoustraire = new System.Windows.Forms.Button();
            this.btnMultiplier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtFraction1
            // 
            this.txtFraction1.Location = new System.Drawing.Point(48, 75);
            this.txtFraction1.Name = "txtFraction1";
            this.txtFraction1.Size = new System.Drawing.Size(100, 20);
            this.txtFraction1.TabIndex = 0;
            // 
            // txtFraction2
            // 
            this.txtFraction2.Location = new System.Drawing.Point(208, 75);
            this.txtFraction2.Name = "txtFraction2";
            this.txtFraction2.Size = new System.Drawing.Size(100, 20);
            this.txtFraction2.TabIndex = 3;
            // 
            // txtFractionReponse
            // 
            this.txtFractionReponse.Enabled = false;
            this.txtFractionReponse.Location = new System.Drawing.Point(412, 75);
            this.txtFractionReponse.Name = "txtFractionReponse";
            this.txtFractionReponse.Size = new System.Drawing.Size(100, 20);
            this.txtFractionReponse.TabIndex = 6;
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(73, 136);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(75, 23);
            this.btnAddition.TabIndex = 9;
            this.btnAddition.Text = "Additionner";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // lblEgal
            // 
            this.lblEgal.AutoSize = true;
            this.lblEgal.Location = new System.Drawing.Point(346, 78);
            this.lblEgal.Name = "lblEgal";
            this.lblEgal.Size = new System.Drawing.Size(25, 13);
            this.lblEgal.TabIndex = 10;
            this.lblEgal.Text = "===";
            // 
            // btnSoustraire
            // 
            this.btnSoustraire.Location = new System.Drawing.Point(233, 136);
            this.btnSoustraire.Name = "btnSoustraire";
            this.btnSoustraire.Size = new System.Drawing.Size(75, 23);
            this.btnSoustraire.TabIndex = 11;
            this.btnSoustraire.Text = "Soustraire";
            this.btnSoustraire.UseVisualStyleBackColor = true;
            this.btnSoustraire.Click += new System.EventHandler(this.btnSoustraire_Click);
            // 
            // btnMultiplier
            // 
            this.btnMultiplier.Location = new System.Drawing.Point(393, 136);
            this.btnMultiplier.Name = "btnMultiplier";
            this.btnMultiplier.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplier.TabIndex = 12;
            this.btnMultiplier.Text = "Multiplier";
            this.btnMultiplier.UseVisualStyleBackColor = true;
            this.btnMultiplier.Click += new System.EventHandler(this.btnMultiplier_Click);
            // 
            // frmExercice3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 210);
            this.Controls.Add(this.btnMultiplier);
            this.Controls.Add(this.btnSoustraire);
            this.Controls.Add(this.lblEgal);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.txtFractionReponse);
            this.Controls.Add(this.txtFraction2);
            this.Controls.Add(this.txtFraction1);
            this.Name = "frmExercice3";
            this.Text = "Fractions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFraction1;
        private System.Windows.Forms.TextBox txtFraction2;
        private System.Windows.Forms.TextBox txtFractionReponse;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Label lblEgal;
        private System.Windows.Forms.Button btnSoustraire;
        private System.Windows.Forms.Button btnMultiplier;
    }
}


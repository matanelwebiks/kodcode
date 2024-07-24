namespace Shabbat_Guests
{
    partial class Form2
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
            this.btnFoword = new System.Windows.Forms.Button();
            this.btnBabk = new System.Windows.Forms.Button();
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.txtFood = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvMyFood = new System.Windows.Forms.DataGridView();
            this.dgvAllGuests = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllGuests)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFoword
            // 
            this.btnFoword.Location = new System.Drawing.Point(672, 475);
            this.btnFoword.Margin = new System.Windows.Forms.Padding(4);
            this.btnFoword.Name = "btnFoword";
            this.btnFoword.Size = new System.Drawing.Size(148, 26);
            this.btnFoword.TabIndex = 21;
            this.btnFoword.Text = ">>";
            this.btnFoword.UseVisualStyleBackColor = true;
            // 
            // btnBabk
            // 
            this.btnBabk.Location = new System.Drawing.Point(83, 475);
            this.btnBabk.Margin = new System.Windows.Forms.Padding(4);
            this.btnBabk.Name = "btnBabk";
            this.btnBabk.Size = new System.Drawing.Size(148, 26);
            this.btnBabk.TabIndex = 20;
            this.btnBabk.Text = "<<";
            this.btnBabk.UseVisualStyleBackColor = true;
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Location = new System.Drawing.Point(372, 4);
            this.lblCategoryName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(0, 20);
            this.lblCategoryName.TabIndex = 19;
            // 
            // txtFood
            // 
            this.txtFood.Location = new System.Drawing.Point(376, 224);
            this.txtFood.Margin = new System.Windows.Forms.Padding(4);
            this.txtFood.Name = "txtFood";
            this.txtFood.Size = new System.Drawing.Size(181, 26);
            this.txtFood.TabIndex = 18;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(95, 224);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(96, 26);
            this.btnOk.TabIndex = 17;
            this.btnOk.Text = "אישר";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(657, 224);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(148, 26);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "הוספת בחירה";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(777, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "הבחירה של כל האורחים";
            // 
            // dgvMyFood
            // 
            this.dgvMyFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyFood.Location = new System.Drawing.Point(65, 277);
            this.dgvMyFood.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMyFood.Name = "dgvMyFood";
            this.dgvMyFood.RowHeadersWidth = 62;
            this.dgvMyFood.Size = new System.Drawing.Size(777, 172);
            this.dgvMyFood.TabIndex = 14;
            // 
            // dgvAllGuests
            // 
            this.dgvAllGuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllGuests.Location = new System.Drawing.Point(65, 44);
            this.dgvAllGuests.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAllGuests.Name = "dgvAllGuests";
            this.dgvAllGuests.RowHeadersWidth = 62;
            this.dgvAllGuests.Size = new System.Drawing.Size(777, 172);
            this.dgvAllGuests.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(836, 257);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "הבחירה שלי";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 507);
            this.Controls.Add(this.btnFoword);
            this.Controls.Add(this.btnBabk);
            this.Controls.Add(this.lblCategoryName);
            this.Controls.Add(this.txtFood);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvMyFood);
            this.Controls.Add(this.dgvAllGuests);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllGuests)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFoword;
        private System.Windows.Forms.Button btnBabk;
        private System.Windows.Forms.Label lblCategoryName;
        private System.Windows.Forms.TextBox txtFood;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvMyFood;
        private System.Windows.Forms.DataGridView dgvAllGuests;
        private System.Windows.Forms.Label label1;
    }
}
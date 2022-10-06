namespace ClientProductsApp
{
    partial class FormMain
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
            this.buttonGetAll = new System.Windows.Forms.Button();
            this.richTextBoxShowProducts = new System.Windows.Forms.RichTextBox();
            this.buttonGetProductById = new System.Windows.Forms.Button();
            this.textBoxFilterById = new System.Windows.Forms.TextBox();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxCategory = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonPost = new System.Windows.Forms.Button();
            this.buttonPut = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonGetAll
            // 
            this.buttonGetAll.Location = new System.Drawing.Point(42, 52);
            this.buttonGetAll.Margin = new System.Windows.Forms.Padding(6);
            this.buttonGetAll.Name = "buttonGetAll";
            this.buttonGetAll.Size = new System.Drawing.Size(222, 44);
            this.buttonGetAll.TabIndex = 0;
            this.buttonGetAll.Text = "Get All Products";
            this.buttonGetAll.UseVisualStyleBackColor = true;
            this.buttonGetAll.Click += new System.EventHandler(this.buttonGetAll_Click);
            // 
            // richTextBoxShowProducts
            // 
            this.richTextBoxShowProducts.Location = new System.Drawing.Point(42, 108);
            this.richTextBoxShowProducts.Margin = new System.Windows.Forms.Padding(6);
            this.richTextBoxShowProducts.Name = "richTextBoxShowProducts";
            this.richTextBoxShowProducts.Size = new System.Drawing.Size(632, 229);
            this.richTextBoxShowProducts.TabIndex = 1;
            this.richTextBoxShowProducts.Text = "";
            // 
            // buttonGetProductById
            // 
            this.buttonGetProductById.Location = new System.Drawing.Point(42, 375);
            this.buttonGetProductById.Margin = new System.Windows.Forms.Padding(6);
            this.buttonGetProductById.Name = "buttonGetProductById";
            this.buttonGetProductById.Size = new System.Drawing.Size(222, 44);
            this.buttonGetProductById.TabIndex = 2;
            this.buttonGetProductById.Text = "Get Product {?}";
            this.buttonGetProductById.UseVisualStyleBackColor = true;
            // 
            // textBoxFilterById
            // 
            this.textBoxFilterById.Location = new System.Drawing.Point(278, 379);
            this.textBoxFilterById.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxFilterById.Name = "textBoxFilterById";
            this.textBoxFilterById.Size = new System.Drawing.Size(196, 31);
            this.textBoxFilterById.TabIndex = 3;
            this.textBoxFilterById.Text = "1";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(42, 433);
            this.textBoxOutput.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(632, 104);
            this.textBoxOutput.TabIndex = 4;
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(836, 119);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(196, 31);
            this.textBoxID.TabIndex = 5;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(836, 171);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(476, 31);
            this.textBoxName.TabIndex = 6;
            // 
            // textBoxCategory
            // 
            this.textBoxCategory.Location = new System.Drawing.Point(836, 223);
            this.textBoxCategory.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxCategory.Name = "textBoxCategory";
            this.textBoxCategory.Size = new System.Drawing.Size(476, 31);
            this.textBoxCategory.TabIndex = 7;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(836, 275);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(196, 31);
            this.textBoxPrice.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(730, 133);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(730, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(730, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Category:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(730, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Price:";
            // 
            // buttonPost
            // 
            this.buttonPost.Location = new System.Drawing.Point(836, 373);
            this.buttonPost.Margin = new System.Windows.Forms.Padding(6);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(182, 44);
            this.buttonPost.TabIndex = 13;
            this.buttonPost.Text = "POST (Create)";
            this.buttonPost.UseVisualStyleBackColor = true;
            // 
            // buttonPut
            // 
            this.buttonPut.Location = new System.Drawing.Point(836, 433);
            this.buttonPut.Margin = new System.Windows.Forms.Padding(6);
            this.buttonPut.Name = "buttonPut";
            this.buttonPut.Size = new System.Drawing.Size(182, 44);
            this.buttonPut.TabIndex = 14;
            this.buttonPut.Text = "PUT (Update)";
            this.buttonPut.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(836, 490);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(6);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(182, 44);
            this.buttonDelete.TabIndex = 15;
            this.buttonDelete.Text = "DEL (Delete)";
            this.buttonDelete.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 650);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonPut);
            this.Controls.Add(this.buttonPost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxCategory);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.textBoxFilterById);
            this.Controls.Add(this.buttonGetProductById);
            this.Controls.Add(this.richTextBoxShowProducts);
            this.Controls.Add(this.buttonGetAll);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormMain";
            this.Text = "RESTFull client application - Products";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonGetAll;
        private System.Windows.Forms.RichTextBox richTextBoxShowProducts;
        private System.Windows.Forms.Button buttonGetProductById;
        private System.Windows.Forms.TextBox textBoxFilterById;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxCategory;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonPost;
        private System.Windows.Forms.Button buttonPut;
        private System.Windows.Forms.Button buttonDelete;
    }
}


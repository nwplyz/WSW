
namespace WSWHotelManagement
{
    partial class frmRooms
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbRoomNumber = new System.Windows.Forms.TextBox();
            this.lblRoomNumber = new System.Windows.Forms.Label();
            this.lblBed = new System.Windows.Forms.Label();
            this.lblExtraBed = new System.Windows.Forms.Label();
            this.lblDefaultPrice = new System.Windows.Forms.Label();
            this.tbDefaultPrice = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cbBed = new System.Windows.Forms.ComboBox();
            this.cbExtraBed = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(326, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(889, 599);
            this.dataGridView1.TabIndex = 0;
            // 
            // tbRoomNumber
            // 
            this.tbRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRoomNumber.Location = new System.Drawing.Point(25, 201);
            this.tbRoomNumber.Margin = new System.Windows.Forms.Padding(10, 4, 10, 10);
            this.tbRoomNumber.Name = "tbRoomNumber";
            this.tbRoomNumber.Size = new System.Drawing.Size(294, 34);
            this.tbRoomNumber.TabIndex = 1;
            // 
            // lblRoomNumber
            // 
            this.lblRoomNumber.AutoSize = true;
            this.lblRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoomNumber.Location = new System.Drawing.Point(20, 168);
            this.lblRoomNumber.Name = "lblRoomNumber";
            this.lblRoomNumber.Size = new System.Drawing.Size(171, 29);
            this.lblRoomNumber.TabIndex = 2;
            this.lblRoomNumber.Text = "Room Number";
            // 
            // lblBed
            // 
            this.lblBed.AutoSize = true;
            this.lblBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBed.Location = new System.Drawing.Point(19, 265);
            this.lblBed.Margin = new System.Windows.Forms.Padding(10);
            this.lblBed.Name = "lblBed";
            this.lblBed.Size = new System.Drawing.Size(57, 29);
            this.lblBed.TabIndex = 4;
            this.lblBed.Text = "Bed";
            // 
            // lblExtraBed
            // 
            this.lblExtraBed.AutoSize = true;
            this.lblExtraBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtraBed.Location = new System.Drawing.Point(19, 357);
            this.lblExtraBed.Name = "lblExtraBed";
            this.lblExtraBed.Size = new System.Drawing.Size(221, 29);
            this.lblExtraBed.TabIndex = 6;
            this.lblExtraBed.Text = "Possible Extrabeds";
            // 
            // lblDefaultPrice
            // 
            this.lblDefaultPrice.AutoSize = true;
            this.lblDefaultPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultPrice.Location = new System.Drawing.Point(20, 452);
            this.lblDefaultPrice.Name = "lblDefaultPrice";
            this.lblDefaultPrice.Size = new System.Drawing.Size(142, 29);
            this.lblDefaultPrice.TabIndex = 8;
            this.lblDefaultPrice.Text = "Defaultprice";
            // 
            // tbDefaultPrice
            // 
            this.tbDefaultPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDefaultPrice.Location = new System.Drawing.Point(25, 485);
            this.tbDefaultPrice.Margin = new System.Windows.Forms.Padding(10, 4, 10, 10);
            this.tbDefaultPrice.Name = "tbDefaultPrice";
            this.tbDefaultPrice.Size = new System.Drawing.Size(294, 34);
            this.tbDefaultPrice.TabIndex = 7;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 54F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(5, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(263, 82);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Rooms";
            // 
            // cbBed
            // 
            this.cbBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBed.FormattingEnabled = true;
            this.cbBed.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbBed.Location = new System.Drawing.Point(24, 299);
            this.cbBed.Margin = new System.Windows.Forms.Padding(10, 4, 10, 10);
            this.cbBed.Name = "cbBed";
            this.cbBed.Size = new System.Drawing.Size(295, 33);
            this.cbBed.TabIndex = 10;
            // 
            // cbExtraBed
            // 
            this.cbExtraBed.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbExtraBed.FormattingEnabled = true;
            this.cbExtraBed.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3"});
            this.cbExtraBed.Location = new System.Drawing.Point(24, 390);
            this.cbExtraBed.Margin = new System.Windows.Forms.Padding(10, 4, 10, 10);
            this.cbExtraBed.Name = "cbExtraBed";
            this.cbExtraBed.Size = new System.Drawing.Size(295, 33);
            this.cbExtraBed.TabIndex = 11;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(24, 559);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(295, 36);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(25, 601);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(295, 36);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(25, 643);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(295, 36);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // frmRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1227, 779);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbExtraBed);
            this.Controls.Add(this.cbBed);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblDefaultPrice);
            this.Controls.Add(this.tbDefaultPrice);
            this.Controls.Add(this.lblExtraBed);
            this.Controls.Add(this.lblBed);
            this.Controls.Add(this.lblRoomNumber);
            this.Controls.Add(this.tbRoomNumber);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRooms";
            this.Text = "frmRooms";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbRoomNumber;
        private System.Windows.Forms.Label lblRoomNumber;
        private System.Windows.Forms.Label lblBed;
        private System.Windows.Forms.Label lblExtraBed;
        private System.Windows.Forms.Label lblDefaultPrice;
        private System.Windows.Forms.TextBox tbDefaultPrice;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.ComboBox cbBed;
        private System.Windows.Forms.ComboBox cbExtraBed;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}
namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.topWearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tShirtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shirtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomWearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shortsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.longPantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accesoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jewelleriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shoesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.labelSubTotal = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxSubTotal = new System.Windows.Forms.TextBox();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageListTShirt = new System.Windows.Forms.ImageList(this.components);
            this.imageListShirt = new System.Windows.Forms.ImageList(this.components);
            this.imageListShorts = new System.Windows.Forms.ImageList(this.components);
            this.imageListLongPants = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topWearToolStripMenuItem,
            this.bottomWearToolStripMenuItem,
            this.accesoriesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // topWearToolStripMenuItem
            // 
            this.topWearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tShirtToolStripMenuItem,
            this.shirtToolStripMenuItem});
            this.topWearToolStripMenuItem.Name = "topWearToolStripMenuItem";
            this.topWearToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.topWearToolStripMenuItem.Text = "Top Wear";
            // 
            // tShirtToolStripMenuItem
            // 
            this.tShirtToolStripMenuItem.Name = "tShirtToolStripMenuItem";
            this.tShirtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tShirtToolStripMenuItem.Text = "T-Shirt";
            this.tShirtToolStripMenuItem.Click += new System.EventHandler(this.tShirtToolStripMenuItem_Click);
            // 
            // shirtToolStripMenuItem
            // 
            this.shirtToolStripMenuItem.Name = "shirtToolStripMenuItem";
            this.shirtToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shirtToolStripMenuItem.Text = "Shirt";
            this.shirtToolStripMenuItem.Click += new System.EventHandler(this.shirtToolStripMenuItem_Click);
            // 
            // bottomWearToolStripMenuItem
            // 
            this.bottomWearToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shortsToolStripMenuItem,
            this.longPantsToolStripMenuItem});
            this.bottomWearToolStripMenuItem.Name = "bottomWearToolStripMenuItem";
            this.bottomWearToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.bottomWearToolStripMenuItem.Text = "Bottom Wear";
            // 
            // shortsToolStripMenuItem
            // 
            this.shortsToolStripMenuItem.Name = "shortsToolStripMenuItem";
            this.shortsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shortsToolStripMenuItem.Text = "Shorts";
            this.shortsToolStripMenuItem.Click += new System.EventHandler(this.shortsToolStripMenuItem_Click);
            // 
            // longPantsToolStripMenuItem
            // 
            this.longPantsToolStripMenuItem.Name = "longPantsToolStripMenuItem";
            this.longPantsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.longPantsToolStripMenuItem.Text = "Long pants";
            this.longPantsToolStripMenuItem.Click += new System.EventHandler(this.longPantsToolStripMenuItem_Click);
            // 
            // accesoriesToolStripMenuItem
            // 
            this.accesoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jewelleriesToolStripMenuItem,
            this.shoesToolStripMenuItem});
            this.accesoriesToolStripMenuItem.Name = "accesoriesToolStripMenuItem";
            this.accesoriesToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.accesoriesToolStripMenuItem.Text = "Accesories";
            // 
            // jewelleriesToolStripMenuItem
            // 
            this.jewelleriesToolStripMenuItem.Name = "jewelleriesToolStripMenuItem";
            this.jewelleriesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.jewelleriesToolStripMenuItem.Text = "Jewelleries";
            this.jewelleriesToolStripMenuItem.Click += new System.EventHandler(this.jewelleriesToolStripMenuItem_Click);
            // 
            // shoesToolStripMenuItem
            // 
            this.shoesToolStripMenuItem.Name = "shoesToolStripMenuItem";
            this.shoesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.shoesToolStripMenuItem.Text = "Shoes";
            this.shoesToolStripMenuItem.Click += new System.EventHandler(this.shoesToolStripMenuItem_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(465, 38);
            this.dgv.Name = "dgv";
            this.dgv.Size = new System.Drawing.Size(323, 213);
            this.dgv.TabIndex = 1;
            this.dgv.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellValueChanged);
            // 
            // labelSubTotal
            // 
            this.labelSubTotal.AutoSize = true;
            this.labelSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubTotal.Location = new System.Drawing.Point(572, 272);
            this.labelSubTotal.Name = "labelSubTotal";
            this.labelSubTotal.Size = new System.Drawing.Size(107, 25);
            this.labelSubTotal.TabIndex = 2;
            this.labelSubTotal.Text = "Sub-total";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(614, 297);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(65, 25);
            this.labelTotal.TabIndex = 3;
            this.labelTotal.Text = "Total";
            // 
            // textBoxSubTotal
            // 
            this.textBoxSubTotal.Location = new System.Drawing.Point(685, 272);
            this.textBoxSubTotal.Name = "textBoxSubTotal";
            this.textBoxSubTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxSubTotal.TabIndex = 4;
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(685, 298);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotal.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 284);
            this.panel1.TabIndex = 6;
            // 
            // imageListTShirt
            // 
            this.imageListTShirt.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTShirt.ImageStream")));
            this.imageListTShirt.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTShirt.Images.SetKeyName(0, "1.jpeg");
            this.imageListTShirt.Images.SetKeyName(1, "2.jpeg");
            this.imageListTShirt.Images.SetKeyName(2, "3.jpeg");
            this.imageListTShirt.Images.SetKeyName(3, "1.jpeg");
            this.imageListTShirt.Images.SetKeyName(4, "2.jpeg");
            this.imageListTShirt.Images.SetKeyName(5, "3.jpeg");
            this.imageListTShirt.Images.SetKeyName(6, "1.jpeg");
            this.imageListTShirt.Images.SetKeyName(7, "2.jpeg");
            this.imageListTShirt.Images.SetKeyName(8, "3.jpeg");
            this.imageListTShirt.Images.SetKeyName(9, "1.jpeg");
            this.imageListTShirt.Images.SetKeyName(10, "2.jpeg");
            this.imageListTShirt.Images.SetKeyName(11, "3.jpeg");
            this.imageListTShirt.Images.SetKeyName(12, "1.jpeg");
            this.imageListTShirt.Images.SetKeyName(13, "2.jpeg");
            this.imageListTShirt.Images.SetKeyName(14, "3.jpeg");
            this.imageListTShirt.Images.SetKeyName(15, "1.jpeg");
            this.imageListTShirt.Images.SetKeyName(16, "2.jpeg");
            this.imageListTShirt.Images.SetKeyName(17, "3.jpeg");
            // 
            // imageListShirt
            // 
            this.imageListShirt.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListShirt.ImageStream")));
            this.imageListShirt.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListShirt.Images.SetKeyName(0, "1.jpeg");
            this.imageListShirt.Images.SetKeyName(1, "2.jpeg");
            this.imageListShirt.Images.SetKeyName(2, "3.jpeg");
            // 
            // imageListShorts
            // 
            this.imageListShorts.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListShorts.ImageStream")));
            this.imageListShorts.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListShorts.Images.SetKeyName(0, "1.jpeg");
            this.imageListShorts.Images.SetKeyName(1, "2.jpeg");
            this.imageListShorts.Images.SetKeyName(2, "3.jpeg");
            // 
            // imageListLongPants
            // 
            this.imageListLongPants.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLongPants.ImageStream")));
            this.imageListLongPants.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLongPants.Images.SetKeyName(0, "1.jpeg");
            this.imageListLongPants.Images.SetKeyName(1, "2.jpeg");
            this.imageListLongPants.Images.SetKeyName(2, "3.jpeg");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxTotal);
            this.Controls.Add(this.textBoxSubTotal);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelSubTotal);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem topWearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tShirtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shirtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottomWearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shortsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem longPantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accesoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jewelleriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shoesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label labelSubTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.TextBox textBoxSubTotal;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageListTShirt;
        private System.Windows.Forms.ImageList imageListShirt;
        private System.Windows.Forms.ImageList imageListShorts;
        private System.Windows.Forms.ImageList imageListLongPants;
    }
}


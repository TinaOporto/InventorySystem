﻿namespace LoginForm
{
    partial class MainForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Manage User", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Manage Inventory", 2, 2);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Employee Details", 3, 3);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Transaction", 4, 4);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Designation", 5, 5);
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Generate Reports");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Inventory System", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.AliceBlue;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.LineColor = System.Drawing.Color.Turquoise;
            this.treeView1.Location = new System.Drawing.Point(20, 160);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "Node1";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "Manage User";
            treeNode2.ImageIndex = 2;
            treeNode2.Name = "Node2";
            treeNode2.SelectedImageIndex = 2;
            treeNode2.Text = "Manage Inventory";
            treeNode3.ImageIndex = 3;
            treeNode3.Name = "Node3";
            treeNode3.SelectedImageIndex = 3;
            treeNode3.Text = "Employee Details";
            treeNode4.ImageIndex = 4;
            treeNode4.Name = "Node4";
            treeNode4.SelectedImageIndex = 4;
            treeNode4.Text = "Transaction";
            treeNode5.ImageIndex = 5;
            treeNode5.Name = "Node5";
            treeNode5.SelectedImageIndex = 5;
            treeNode5.Text = "Designation";
            treeNode6.ImageKey = "System Report-25.png";
            treeNode6.Name = "Node6";
            treeNode6.SelectedImageIndex = 6;
            treeNode6.Text = "Generate Reports";
            treeNode7.Name = "Node()";
            treeNode7.Text = "Inventory System";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(200, 420);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.metroPanel1.BackgroundImage = global::LoginForm.Properties.Resources.new_logo;
            this.metroPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1022, 100);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "filled_box_32px.png");
            this.imageList1.Images.SetKeyName(1, "Employee Card-25.png");
            this.imageList1.Images.SetKeyName(2, "Product-25.png");
            this.imageList1.Images.SetKeyName(3, "User Menu-25.png");
            this.imageList1.Images.SetKeyName(4, "Money Transfer-25.png");
            this.imageList1.Images.SetKeyName(5, "Conference-25.png");
            this.imageList1.Images.SetKeyName(6, "System Report-25.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 600);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.metroPanel1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList imageList1;
    }
}
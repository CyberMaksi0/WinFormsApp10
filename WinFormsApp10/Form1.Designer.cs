namespace WinFormsApp10
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Maszyny");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Elektronika");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Produkcja", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Sprzedaż");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Firma", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12});
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Prezes");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Rada");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Zarząd", new System.Windows.Forms.TreeNode[] {
            treeNode14,
            treeNode15});
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dodajGałaźToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajPodgałaźToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmieńToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajGałaźToolStripMenuItem,
            this.dodajPodgałaźToolStripMenuItem,
            this.usuńToolStripMenuItem,
            this.zmieńToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(157, 92);
            // 
            // dodajGałaźToolStripMenuItem
            // 
            this.dodajGałaźToolStripMenuItem.Name = "dodajGałaźToolStripMenuItem";
            this.dodajGałaźToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajGałaźToolStripMenuItem.Text = "Dodaj gałaź";
            this.dodajGałaźToolStripMenuItem.Click += new System.EventHandler(this.dodajGałaźToolStripMenuItem_Click);
            // 
            // dodajPodgałaźToolStripMenuItem
            // 
            this.dodajPodgałaźToolStripMenuItem.Name = "dodajPodgałaźToolStripMenuItem";
            this.dodajPodgałaźToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dodajPodgałaźToolStripMenuItem.Text = "Dodaj podgałaź";
            this.dodajPodgałaźToolStripMenuItem.Click += new System.EventHandler(this.dodajPodgałaźToolStripMenuItem_Click);
            // 
            // usuńToolStripMenuItem
            // 
            this.usuńToolStripMenuItem.Name = "usuńToolStripMenuItem";
            this.usuńToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuńToolStripMenuItem.Text = "Usuń";
            this.usuńToolStripMenuItem.Click += new System.EventHandler(this.usuńToolStripMenuItem_Click);
            // 
            // zmieńToolStripMenuItem
            // 
            this.zmieńToolStripMenuItem.Name = "zmieńToolStripMenuItem";
            this.zmieńToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.zmieńToolStripMenuItem.Text = "Zmień";
            this.zmieńToolStripMenuItem.Click += new System.EventHandler(this.zmieńToolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.FullRowSelect = true;
            this.treeView1.Location = new System.Drawing.Point(23, 19);
            this.treeView1.Name = "treeView1";
            treeNode9.Name = "Maszyny";
            treeNode9.Text = "Maszyny";
            treeNode10.Name = "Elektronika";
            treeNode10.Text = "Elektronika";
            treeNode11.Name = "Produkcja";
            treeNode11.Text = "Produkcja";
            treeNode12.Name = "Sprzedaż";
            treeNode12.Text = "Sprzedaż";
            treeNode13.Name = "Firma";
            treeNode13.Text = "Firma";
            treeNode14.Name = "Prezes";
            treeNode14.Text = "Prezes";
            treeNode15.Name = "Rada";
            treeNode15.Text = "Rada";
            treeNode16.Name = "Zarząd";
            treeNode16.Text = "Zarząd";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode13,
            treeNode16});
            this.treeView1.Size = new System.Drawing.Size(572, 402);
            this.treeView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(644, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(644, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 32);
            this.button2.TabIndex = 3;
            this.button2.Text = "Zamknij";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Schemat Organizacyjny";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem dodajGałaźToolStripMenuItem;
        private ToolStripMenuItem dodajPodgałaźToolStripMenuItem;
        private ToolStripMenuItem usuńToolStripMenuItem;
        private ToolStripMenuItem zmieńToolStripMenuItem;
        private TreeView treeView1;
        private Button button1;
        private Button button2;
    }
}
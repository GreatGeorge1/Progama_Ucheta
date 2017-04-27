namespace WindowsFormsApp1
{
    partial class Insert
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.факультетToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фепToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.нНИИКТToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.групаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рПЗToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПСІКToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рПЗ1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рПЗ2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предметиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.студентиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.dataGridView1);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(617, 315);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(401, 205);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.факультетToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(617, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // факультетToolStripMenuItem
            // 
            this.факультетToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.фепToolStripMenuItem,
            this.нНИИКТToolStripMenuItem});
            this.факультетToolStripMenuItem.Name = "факультетToolStripMenuItem";
            this.факультетToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.факультетToolStripMenuItem.Text = "Факультет";
            // 
            // фепToolStripMenuItem
            // 
            this.фепToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.групаToolStripMenuItem});
            this.фепToolStripMenuItem.Name = "фепToolStripMenuItem";
            this.фепToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.фепToolStripMenuItem.Text = "ФЕП";
            // 
            // нНИИКТToolStripMenuItem
            // 
            this.нНИИКТToolStripMenuItem.Name = "нНИИКТToolStripMenuItem";
            this.нНИИКТToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.нНИИКТToolStripMenuItem.Text = "ННИИКТ";
            // 
            // групаToolStripMenuItem
            // 
            this.групаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рПЗToolStripMenuItem,
            this.оПСІКToolStripMenuItem});
            this.групаToolStripMenuItem.Name = "групаToolStripMenuItem";
            this.групаToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.групаToolStripMenuItem.Text = "Група";
            // 
            // рПЗToolStripMenuItem
            // 
            this.рПЗToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.рПЗ1ToolStripMenuItem,
            this.рПЗ2ToolStripMenuItem});
            this.рПЗToolStripMenuItem.Name = "рПЗToolStripMenuItem";
            this.рПЗToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.рПЗToolStripMenuItem.Text = "РПЗ";
            // 
            // оПСІКToolStripMenuItem
            // 
            this.оПСІКToolStripMenuItem.Name = "оПСІКToolStripMenuItem";
            this.оПСІКToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.оПСІКToolStripMenuItem.Text = "ОПСІК";
            // 
            // рПЗ1ToolStripMenuItem
            // 
            this.рПЗ1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.предметиToolStripMenuItem,
            this.студентиToolStripMenuItem});
            this.рПЗ1ToolStripMenuItem.Name = "рПЗ1ToolStripMenuItem";
            this.рПЗ1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.рПЗ1ToolStripMenuItem.Text = "РПЗ1";
            // 
            // рПЗ2ToolStripMenuItem
            // 
            this.рПЗ2ToolStripMenuItem.Name = "рПЗ2ToolStripMenuItem";
            this.рПЗ2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.рПЗ2ToolStripMenuItem.Text = "РПЗ2";
            // 
            // предметиToolStripMenuItem
            // 
            this.предметиToolStripMenuItem.Name = "предметиToolStripMenuItem";
            this.предметиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.предметиToolStripMenuItem.Text = "Предмети";
            // 
            // студентиToolStripMenuItem
            // 
            this.студентиToolStripMenuItem.Name = "студентиToolStripMenuItem";
            this.студентиToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.студентиToolStripMenuItem.Text = "Студенти";
            // 
            // Insert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 339);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Insert";
            this.Text = "Form2";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem факультетToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фепToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem групаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рПЗToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рПЗ1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предметиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem студентиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рПЗ2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПСІКToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem нНИИКТToolStripMenuItem;
    }
}
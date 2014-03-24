namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn1 = new System.Windows.Forms.Button();
            this.opfd1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cargarMusicaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarMusicaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.gb = new System.Windows.Forms.GroupBox();
            this.pbalbun = new System.Windows.Forms.PictureBox();
            this.ltb = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstv2 = new System.Windows.Forms.ListView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lst1 = new System.Windows.Forms.ListView();
            this.btncoin = new System.Windows.Forms.Button();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.estadisticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reproduccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.gb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbalbun)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(322, 499);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(79, 28);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "animacion";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // opfd1
            // 
            this.opfd1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarMusicaToolStripMenuItem,
            this.estadisticaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(744, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cargarMusicaToolStripMenuItem
            // 
            this.cargarMusicaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarMusicaToolStripMenuItem1,
            this.salirToolStripMenuItem});
            this.cargarMusicaToolStripMenuItem.Name = "cargarMusicaToolStripMenuItem";
            this.cargarMusicaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.cargarMusicaToolStripMenuItem.Text = "Menu";
            // 
            // cargarMusicaToolStripMenuItem1
            // 
            this.cargarMusicaToolStripMenuItem1.Name = "cargarMusicaToolStripMenuItem1";
            this.cargarMusicaToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.cargarMusicaToolStripMenuItem1.Text = "Cargar Musica";
            this.cargarMusicaToolStripMenuItem1.Click += new System.EventHandler(this.cargarMusicaToolStripMenuItem1_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            this.label1.Visible = false;
            // 
            // gb
            // 
            this.gb.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gb.Controls.Add(this.pbalbun);
            this.gb.Controls.Add(this.ltb);
            this.gb.Controls.Add(this.groupBox2);
            this.gb.Controls.Add(this.groupBox1);
            this.gb.Location = new System.Drawing.Point(10, 65);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(723, 287);
            this.gb.TabIndex = 6;
            this.gb.TabStop = false;
            this.gb.Text = "Albunes";
            // 
            // pbalbun
            // 
            this.pbalbun.Location = new System.Drawing.Point(253, 21);
            this.pbalbun.Name = "pbalbun";
            this.pbalbun.Size = new System.Drawing.Size(173, 79);
            this.pbalbun.TabIndex = 3;
            this.pbalbun.TabStop = false;
            // 
            // ltb
            // 
            this.ltb.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ltb.FormattingEnabled = true;
            this.ltb.Location = new System.Drawing.Point(7, 21);
            this.ltb.Name = "ltb";
            this.ltb.Size = new System.Drawing.Size(203, 264);
            this.ltb.TabIndex = 2;
            this.ltb.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ltb_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstv2);
            this.groupBox2.Location = new System.Drawing.Point(477, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 272);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Selecciones";
            // 
            // lstv2
            // 
            this.lstv2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lstv2.Location = new System.Drawing.Point(9, 23);
            this.lstv2.Name = "lstv2";
            this.lstv2.Size = new System.Drawing.Size(207, 245);
            this.lstv2.TabIndex = 0;
            this.lstv2.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lst1);
            this.groupBox1.Location = new System.Drawing.Point(216, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Canciones";
            // 
            // lst1
            // 
            this.lst1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lst1.ForeColor = System.Drawing.SystemColors.Info;
            this.lst1.Location = new System.Drawing.Point(6, 19);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(238, 164);
            this.lst1.TabIndex = 0;
            this.lst1.UseCompatibleStateImageBehavior = false;
            this.lst1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lst1_MouseDoubleClick);
            // 
            // btncoin
            // 
            this.btncoin.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.coin3;
            this.btncoin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncoin.Location = new System.Drawing.Point(407, 499);
            this.btncoin.Name = "btncoin";
            this.btncoin.Size = new System.Drawing.Size(82, 61);
            this.btncoin.TabIndex = 4;
            this.btncoin.UseVisualStyleBackColor = true;
            this.btncoin.Click += new System.EventHandler(this.btncoin_Click);
            // 
            // pb3
            // 
            this.pb3.Location = new System.Drawing.Point(226, 356);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(281, 137);
            this.pb3.TabIndex = 2;
            this.pb3.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Location = new System.Drawing.Point(10, 358);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(195, 225);
            this.pb2.TabIndex = 1;
            this.pb2.TabStop = false;
            // 
            // pb1
            // 
            this.pb1.ErrorImage = global::WindowsFormsApplication1.Properties.Resources.coin1;
            this.pb1.Location = new System.Drawing.Point(528, 358);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(205, 225);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(226, 499);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 84);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(339, 547);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "0";
            // 
            // timer3
            // 
            this.timer3.Interval = 1000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(294, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(294, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(667, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 18);
            this.label5.TabIndex = 15;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(25, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 17;
            this.label6.Text = "label6";
            // 
            // estadisticaToolStripMenuItem
            // 
            this.estadisticaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reproduccionesToolStripMenuItem});
            this.estadisticaToolStripMenuItem.Name = "estadisticaToolStripMenuItem";
            this.estadisticaToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.estadisticaToolStripMenuItem.Text = "Estadistica";
            // 
            // reproduccionesToolStripMenuItem
            // 
            this.reproduccionesToolStripMenuItem.Name = "reproduccionesToolStripMenuItem";
            this.reproduccionesToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.reproduccionesToolStripMenuItem.Text = "Reproducciones";
            this.reproduccionesToolStripMenuItem.Click += new System.EventHandler(this.reproduccionesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(744, 592);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btncoin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rockola";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gb.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbalbun)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.OpenFileDialog opfd1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cargarMusicaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarMusicaToolStripMenuItem1;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ltb;
        private System.Windows.Forms.PictureBox pbalbun;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lst1;
        private System.Windows.Forms.ListView lstv2;
        private System.Windows.Forms.Button btncoin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem estadisticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reproduccionesToolStripMenuItem;

    }
}


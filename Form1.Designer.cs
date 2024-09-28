
namespace ED_P5U3_COLAS
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.btnIngresar = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonPalette1 = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnExtraer = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtN1 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtN2 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtN4 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtN3 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtN5 = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(154, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Elementos en cola";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.White;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(200, 59);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(49, 29);
            this.txtTotal.TabIndex = 1;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pb1
            // 
            this.pb1.Image = global::ED_P5U3_COLAS.Properties.Resources.user;
            this.pb1.Location = new System.Drawing.Point(-50, 150);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(49, 49);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 2;
            this.pb1.TabStop = false;
            // 
            // pb4
            // 
            this.pb4.Image = ((System.Drawing.Image)(resources.GetObject("pb4.Image")));
            this.pb4.Location = new System.Drawing.Point(-50, 150);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(49, 49);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb4.TabIndex = 3;
            this.pb4.TabStop = false;
            // 
            // pb3
            // 
            this.pb3.Image = ((System.Drawing.Image)(resources.GetObject("pb3.Image")));
            this.pb3.Location = new System.Drawing.Point(-50, 150);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(49, 49);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb3.TabIndex = 4;
            this.pb3.TabStop = false;
            // 
            // pb2
            // 
            this.pb2.Image = ((System.Drawing.Image)(resources.GetObject("pb2.Image")));
            this.pb2.Location = new System.Drawing.Point(-50, 150);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(49, 49);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb2.TabIndex = 5;
            this.pb2.TabStop = false;
            // 
            // pb5
            // 
            this.pb5.Image = ((System.Drawing.Image)(resources.GetObject("pb5.Image")));
            this.pb5.Location = new System.Drawing.Point(-50, 150);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(49, 49);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb5.TabIndex = 6;
            this.pb5.TabStop = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(28, 59);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(75)))), ((int)(((byte)(41)))));
            this.btnIngresar.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(75)))), ((int)(((byte)(41)))));
            this.btnIngresar.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(147)))), ((int)(((byte)(104)))));
            this.btnIngresar.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(147)))), ((int)(((byte)(104)))));
            this.btnIngresar.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnIngresar.OverrideDefault.Border.Rounding = 8;
            this.btnIngresar.Size = new System.Drawing.Size(121, 37);
            this.btnIngresar.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(75)))), ((int)(((byte)(41)))));
            this.btnIngresar.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(75)))), ((int)(((byte)(41)))));
            this.btnIngresar.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(147)))), ((int)(((byte)(104)))));
            this.btnIngresar.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(147)))), ((int)(((byte)(104)))));
            this.btnIngresar.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnIngresar.StateCommon.Border.Rounding = 8;
            this.btnIngresar.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnIngresar.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(148)))), ((int)(((byte)(153)))));
            this.btnIngresar.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(148)))), ((int)(((byte)(153)))));
            this.btnIngresar.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(85)))), ((int)(((byte)(61)))));
            this.btnIngresar.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(85)))), ((int)(((byte)(61)))));
            this.btnIngresar.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(81)))));
            this.btnIngresar.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(81)))));
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Values.Text = "Ingresar";
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnExtraer
            // 
            this.btnExtraer.Location = new System.Drawing.Point(300, 59);
            this.btnExtraer.Name = "btnExtraer";
            this.btnExtraer.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(75)))), ((int)(((byte)(41)))));
            this.btnExtraer.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(75)))), ((int)(((byte)(41)))));
            this.btnExtraer.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(147)))), ((int)(((byte)(104)))));
            this.btnExtraer.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(147)))), ((int)(((byte)(104)))));
            this.btnExtraer.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExtraer.OverrideDefault.Border.Rounding = 8;
            this.btnExtraer.Size = new System.Drawing.Size(121, 37);
            this.btnExtraer.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(75)))), ((int)(((byte)(41)))));
            this.btnExtraer.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(75)))), ((int)(((byte)(41)))));
            this.btnExtraer.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(147)))), ((int)(((byte)(104)))));
            this.btnExtraer.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(147)))), ((int)(((byte)(104)))));
            this.btnExtraer.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnExtraer.StateCommon.Border.Rounding = 8;
            this.btnExtraer.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btnExtraer.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Nunito", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtraer.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(148)))), ((int)(((byte)(153)))));
            this.btnExtraer.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(148)))), ((int)(((byte)(153)))));
            this.btnExtraer.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(85)))), ((int)(((byte)(61)))));
            this.btnExtraer.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(85)))), ((int)(((byte)(61)))));
            this.btnExtraer.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(81)))));
            this.btnExtraer.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(95)))), ((int)(((byte)(81)))));
            this.btnExtraer.TabIndex = 8;
            this.btnExtraer.Values.Text = "Extraer";
            this.btnExtraer.Click += new System.EventHandler(this.btnExtraer_Click);
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(300, 215);
            this.txtN1.Multiline = true;
            this.txtN1.Name = "txtN1";
            this.txtN1.ReadOnly = true;
            this.txtN1.Size = new System.Drawing.Size(49, 49);
            this.txtN1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(147)))), ((int)(((byte)(104)))));
            this.txtN1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(147)))), ((int)(((byte)(104)))));
            this.txtN1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtN1.StateCommon.Border.Rounding = 6;
            this.txtN1.StateCommon.Content.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN1.TabIndex = 9;
            this.txtN1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(250, 215);
            this.txtN2.Multiline = true;
            this.txtN2.Name = "txtN2";
            this.txtN2.ReadOnly = true;
            this.txtN2.Size = new System.Drawing.Size(49, 49);
            this.txtN2.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(147)))), ((int)(((byte)(104)))));
            this.txtN2.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(147)))), ((int)(((byte)(104)))));
            this.txtN2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtN2.StateCommon.Border.Rounding = 6;
            this.txtN2.StateCommon.Content.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN2.TabIndex = 10;
            this.txtN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtN4
            // 
            this.txtN4.Location = new System.Drawing.Point(150, 215);
            this.txtN4.Multiline = true;
            this.txtN4.Name = "txtN4";
            this.txtN4.ReadOnly = true;
            this.txtN4.Size = new System.Drawing.Size(49, 49);
            this.txtN4.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(147)))), ((int)(((byte)(104)))));
            this.txtN4.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(147)))), ((int)(((byte)(104)))));
            this.txtN4.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtN4.StateCommon.Border.Rounding = 6;
            this.txtN4.StateCommon.Content.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN4.TabIndex = 12;
            this.txtN4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(200, 215);
            this.txtN3.Multiline = true;
            this.txtN3.Name = "txtN3";
            this.txtN3.ReadOnly = true;
            this.txtN3.Size = new System.Drawing.Size(49, 49);
            this.txtN3.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(147)))), ((int)(((byte)(104)))));
            this.txtN3.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(147)))), ((int)(((byte)(104)))));
            this.txtN3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtN3.StateCommon.Border.Rounding = 6;
            this.txtN3.StateCommon.Content.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN3.TabIndex = 11;
            this.txtN3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtN5
            // 
            this.txtN5.Location = new System.Drawing.Point(100, 215);
            this.txtN5.Multiline = true;
            this.txtN5.Name = "txtN5";
            this.txtN5.ReadOnly = true;
            this.txtN5.Size = new System.Drawing.Size(49, 49);
            this.txtN5.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(147)))), ((int)(((byte)(104)))));
            this.txtN5.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(147)))), ((int)(((byte)(104)))));
            this.txtN5.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtN5.StateCommon.Border.Rounding = 6;
            this.txtN5.StateCommon.Content.Font = new System.Drawing.Font("Nunito", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN5.TabIndex = 13;
            this.txtN5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(451, 276);
            this.Controls.Add(this.txtN5);
            this.Controls.Add(this.txtN4);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.btnExtraer);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb5;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnIngresar;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnExtraer;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtN1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtN2;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtN4;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtN3;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtN5;
    }
}


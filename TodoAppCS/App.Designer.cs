using System.ComponentModel;

namespace TodoAppCS
{
    partial class App
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.borrar = new Guna.UI2.WinForms.Guna2Button();
            this.agregar = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.text = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dataview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.nombreTabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textTabla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.borrar);
            this.panel1.Controls.Add(this.agregar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.nombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.text);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(748, 342);
            this.panel1.TabIndex = 0;
            // 
            // borrar
            // 
            this.borrar.BorderColor = System.Drawing.Color.Transparent;
            this.borrar.BorderRadius = 10;
            this.borrar.CustomizableEdges = customizableEdges1;
            this.borrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.borrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.borrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.borrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.borrar.FillColor = System.Drawing.Color.Black;
            this.borrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.borrar.ForeColor = System.Drawing.Color.White;
            this.borrar.Location = new System.Drawing.Point(588, 54);
            this.borrar.Name = "borrar";
            this.borrar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.borrar.Size = new System.Drawing.Size(148, 56);
            this.borrar.TabIndex = 6;
            this.borrar.Text = "Borrar";
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // agregar
            // 
            this.agregar.BorderColor = System.Drawing.Color.Transparent;
            this.agregar.BorderRadius = 10;
            this.agregar.CustomizableEdges = customizableEdges3;
            this.agregar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.agregar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.agregar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.agregar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.agregar.FillColor = System.Drawing.Color.Black;
            this.agregar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.agregar.ForeColor = System.Drawing.Color.White;
            this.agregar.Location = new System.Drawing.Point(434, 54);
            this.agregar.Name = "agregar";
            this.agregar.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.agregar.Size = new System.Drawing.Size(148, 56);
            this.agregar.TabIndex = 5;
            this.agregar.Text = "Agregar";
            this.agregar.Click += new System.EventHandler(this.agregar_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("FiraCode Nerd Font", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nombre
            // 
            this.nombre.BorderColor = System.Drawing.Color.Black;
            this.nombre.BorderRadius = 10;
            this.nombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nombre.CustomizableEdges = customizableEdges5;
            this.nombre.DefaultText = "";
            this.nombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nombre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nombre.Location = new System.Drawing.Point(12, 54);
            this.nombre.Name = "nombre";
            this.nombre.PasswordChar = '\0';
            this.nombre.PlaceholderText = "Nombre aqui";
            this.nombre.SelectedText = "";
            this.nombre.ShadowDecoration.CustomizableEdges = customizableEdges6;
            this.nombre.Size = new System.Drawing.Size(226, 35);
            this.nombre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("FiraCode Nerd Font", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text
            // 
            this.text.BorderColor = System.Drawing.Color.Black;
            this.text.BorderRadius = 10;
            this.text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.text.CustomizableEdges = customizableEdges7;
            this.text.DefaultText = "";
            this.text.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.text.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.text.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.text.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.text.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.text.Location = new System.Drawing.Point(12, 139);
            this.text.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.text.MaxLength = 100;
            this.text.Multiline = true;
            this.text.Name = "text";
            this.text.PasswordChar = '\0';
            this.text.PlaceholderText = "Hacer la comida del medio dia";
            this.text.SelectedText = "";
            this.text.ShadowDecoration.CustomizableEdges = customizableEdges8;
            this.text.Size = new System.Drawing.Size(724, 190);
            this.text.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this.panel1;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            // 
            // dataview
            // 
            this.dataview.AllowUserToAddRows = false;
            this.dataview.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dataview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataview.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataview.ColumnHeadersHeight = 15;
            this.dataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.nombreTabla, this.textTabla });
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataview.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dataview.Location = new System.Drawing.Point(12, 375);
            this.dataview.Name = "dataview";
            this.dataview.ReadOnly = true;
            this.dataview.RowHeadersVisible = false;
            this.dataview.Size = new System.Drawing.Size(748, 495);
            this.dataview.TabIndex = 2;
            this.dataview.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark;
            this.dataview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.dataview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataview.ThemeStyle.BackColor = System.Drawing.SystemColors.ControlLight;
            this.dataview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.dataview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.dataview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataview.ThemeStyle.HeaderStyle.Height = 15;
            this.dataview.ThemeStyle.ReadOnly = true;
            this.dataview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.dataview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dataview.ThemeStyle.RowsStyle.Height = 22;
            this.dataview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.dataview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            // 
            // nombreTabla
            // 
            this.nombreTabla.HeaderText = "Nombre";
            this.nombreTabla.Name = "nombreTabla";
            this.nombreTabla.ReadOnly = true;
            // 
            // textTabla
            // 
            this.textTabla.HeaderText = "Text";
            this.textTabla.Name = "textTabla";
            this.textTabla.ReadOnly = true;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 15;
            this.guna2Elipse3.TargetControl = this.dataview;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(772, 882);
            this.Controls.Add(this.dataview);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(788, 921);
            this.MinimumSize = new System.Drawing.Size(788, 921);
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ToDo App CS";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataview)).EndInit();
            this.ResumeLayout(false);
        }

        private Guna.UI2.WinForms.Guna2Button borrar;

        private System.Windows.Forms.DataGridViewTextBoxColumn nombreTabla;
        private System.Windows.Forms.DataGridViewTextBoxColumn textTabla;

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;

        private Guna.UI2.WinForms.Guna2DataGridView dataview;

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;

        private Guna.UI2.WinForms.Guna2Button agregar;

        private Guna.UI2.WinForms.Guna2TextBox nombre;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private Guna.UI2.WinForms.Guna2TextBox text;

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;

        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}
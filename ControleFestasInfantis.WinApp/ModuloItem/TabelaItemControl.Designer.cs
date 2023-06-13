namespace ControleFestasInfantis.WinApp.ModuloItem
{
    partial class TabelaItemControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabelaItem = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tabelaItem).BeginInit();
            SuspendLayout();
            // 
            // tabelaItem
            // 
            tabelaItem.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabelaItem.Location = new Point(3, 3);
            tabelaItem.Name = "tabelaItem";
            tabelaItem.RowTemplate.Height = 25;
            tabelaItem.Size = new Size(483, 316);
            tabelaItem.TabIndex = 0;
            // 
            // TabelaItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabelaItem);
            Name = "TabelaItemControl";
            Size = new Size(489, 319);
            ((System.ComponentModel.ISupportInitialize)tabelaItem).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tabelaItem;
    }
}

namespace Tyuiu.MokhamedAA.Sprint7.V10
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelup = new Panel();
            textBoxDeviz_BKV = new TextBox();
            textBoxNazvanie_BKV = new TextBox();
            panel1 = new Panel();
            buttonHelp_BKV = new Button();
            buttonCatalog_BKV = new Button();
            buttonDetalyZak_BKV = new Button();
            buttonAboutUs_BKV = new Button();
            toolTipGlavMeny_BKV = new ToolTip(components);
            panelup.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelup
            // 
            panelup.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelup.BackColor = Color.MediumPurple;
            panelup.BackgroundImage = (Image)resources.GetObject("panelup.BackgroundImage");
            panelup.BackgroundImageLayout = ImageLayout.Stretch;
            panelup.Controls.Add(textBoxDeviz_BKV);
            panelup.Controls.Add(textBoxNazvanie_BKV);
            panelup.Location = new Point(-1, 141);
            panelup.Name = "panelup";
            panelup.Size = new Size(786, 420);
            panelup.TabIndex = 0;
            panelup.Paint += panelup_Paint;
            // 
            // textBoxDeviz_BKV
            // 
            textBoxDeviz_BKV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDeviz_BKV.BackColor = Color.Silver;
            textBoxDeviz_BKV.BorderStyle = BorderStyle.None;
            textBoxDeviz_BKV.Font = new Font("Cambria", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxDeviz_BKV.ForeColor = Color.GhostWhite;
            textBoxDeviz_BKV.Location = new Point(13, 92);
            textBoxDeviz_BKV.Multiline = true;
            textBoxDeviz_BKV.Name = "textBoxDeviz_BKV";
            textBoxDeviz_BKV.ReadOnly = true;
            textBoxDeviz_BKV.Size = new Size(282, 52);
            textBoxDeviz_BKV.TabIndex = 1;
            textBoxDeviz_BKV.Text = "при выборе нас, мы гарантируем тебе качество!";
            // 
            // textBoxNazvanie_BKV
            // 
            textBoxNazvanie_BKV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxNazvanie_BKV.BackColor = SystemColors.ActiveBorder;
            textBoxNazvanie_BKV.BorderStyle = BorderStyle.None;
            textBoxNazvanie_BKV.Font = new Font("Palatino Linotype", 48F, FontStyle.Bold, GraphicsUnit.Point, 204);
            textBoxNazvanie_BKV.ForeColor = Color.GhostWhite;
            textBoxNazvanie_BKV.ImeMode = ImeMode.NoControl;
            textBoxNazvanie_BKV.Location = new Point(13, 3);
            textBoxNazvanie_BKV.Multiline = true;
            textBoxNazvanie_BKV.Name = "textBoxNazvanie_BKV";
            textBoxNazvanie_BKV.ReadOnly = true;
            textBoxNazvanie_BKV.Size = new Size(251, 83);
            textBoxNazvanie_BKV.TabIndex = 0;
            textBoxNazvanie_BKV.Text = "MA Store";
            textBoxNazvanie_BKV.TextChanged += textBoxNazvanie_BKV_TextChanged;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.PaleVioletRed;
            panel1.Controls.Add(buttonHelp_BKV);
            panel1.Controls.Add(buttonCatalog_BKV);
            panel1.Controls.Add(buttonDetalyZak_BKV);
            panel1.Controls.Add(buttonAboutUs_BKV);
            panel1.ForeColor = Color.Silver;
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(793, 157);
            panel1.TabIndex = 1;
            // 
            // buttonHelp_BKV
            // 
            buttonHelp_BKV.BackColor = Color.White;
            buttonHelp_BKV.FlatStyle = FlatStyle.Popup;
            buttonHelp_BKV.Image = (Image)resources.GetObject("buttonHelp_BKV.Image");
            buttonHelp_BKV.Location = new Point(218, 25);
            buttonHelp_BKV.Name = "buttonHelp_BKV";
            buttonHelp_BKV.Size = new Size(62, 65);
            buttonHelp_BKV.TabIndex = 5;
            toolTipGlavMeny_BKV.SetToolTip(buttonHelp_BKV, "Во вкладке \"Помощь\" вы сможете найти краткое руководство пользователя,\r\n ответы на актуальные вопросы, а также контакты для связи с поддержкой.");
            buttonHelp_BKV.UseVisualStyleBackColor = false;
            buttonHelp_BKV.Click += buttonHelp_BKV_Click;
            // 
            // buttonCatalog_BKV
            // 
            buttonCatalog_BKV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            buttonCatalog_BKV.BackColor = Color.Thistle;
            buttonCatalog_BKV.FlatStyle = FlatStyle.Popup;
            buttonCatalog_BKV.Font = new Font("Constantia", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonCatalog_BKV.ForeColor = Color.GhostWhite;
            buttonCatalog_BKV.Location = new Point(473, 13);
            buttonCatalog_BKV.Name = "buttonCatalog_BKV";
            buttonCatalog_BKV.Size = new Size(286, 112);
            buttonCatalog_BKV.TabIndex = 4;
            buttonCatalog_BKV.Text = "Products";
            toolTipGlavMeny_BKV.SetToolTip(buttonCatalog_BKV, "Во вкладке \"Наш ассортимент\" вы сможете найти\r\n интересующий вас товар. ");
            buttonCatalog_BKV.UseVisualStyleBackColor = false;
            buttonCatalog_BKV.Click += buttonCatalog_BKV_Click;
            // 
            // buttonDetalyZak_BKV
            // 
            buttonDetalyZak_BKV.BackColor = Color.White;
            buttonDetalyZak_BKV.FlatStyle = FlatStyle.Popup;
            buttonDetalyZak_BKV.Image = (Image)resources.GetObject("buttonDetalyZak_BKV.Image");
            buttonDetalyZak_BKV.Location = new Point(129, 25);
            buttonDetalyZak_BKV.Name = "buttonDetalyZak_BKV";
            buttonDetalyZak_BKV.Size = new Size(62, 65);
            buttonDetalyZak_BKV.TabIndex = 2;
            buttonDetalyZak_BKV.Text = "\r\n\r\n\r\n";
            toolTipGlavMeny_BKV.SetToolTip(buttonDetalyZak_BKV, "В вкладке \"Оплата и доставка\" вы можете ознакомиться со способами оплаты и доставки.\r\n Также здесь вы найдёте этапы доставки.\r\n");
            buttonDetalyZak_BKV.UseVisualStyleBackColor = false;
            buttonDetalyZak_BKV.Click += buttonDetalyZak_BKV_Click;
            // 
            // buttonAboutUs_BKV
            // 
            buttonAboutUs_BKV.BackColor = Color.White;
            buttonAboutUs_BKV.FlatStyle = FlatStyle.Popup;
            buttonAboutUs_BKV.Image = (Image)resources.GetObject("buttonAboutUs_BKV.Image");
            buttonAboutUs_BKV.Location = new Point(42, 25);
            buttonAboutUs_BKV.Name = "buttonAboutUs_BKV";
            buttonAboutUs_BKV.Size = new Size(65, 65);
            buttonAboutUs_BKV.TabIndex = 1;
            toolTipGlavMeny_BKV.SetToolTip(buttonAboutUs_BKV, "В вкладке \"О нас\" вы можете лучше\r\n ознакомиться с нашей компанией.\r\n");
            buttonAboutUs_BKV.UseVisualStyleBackColor = false;
            buttonAboutUs_BKV.Click += buttonAboutUs_BKV_Click;
            // 
            // toolTipGlavMeny_BKV
            // 
            toolTipGlavMeny_BKV.BackColor = Color.Thistle;
            toolTipGlavMeny_BKV.IsBalloon = true;
            toolTipGlavMeny_BKV.ToolTipIcon = ToolTipIcon.Info;
            toolTipGlavMeny_BKV.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Indigo;
            ClientSize = new Size(784, 561);
            Controls.Add(panel1);
            Controls.Add(panelup);
            MinimumSize = new Size(800, 600);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Главное меню";
            WindowState = FormWindowState.Maximized;
            panelup.ResumeLayout(false);
            panelup.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelup;
        private Panel panel1;
        private Button buttonAboutUs_BKV;
        private Button buttonDetalyZak_BKV;
        private Button buttonCatalog_BKV;
        private TextBox textBoxNazvanie_BKV;
        private TextBox textBoxDeviz_BKV;
        private ToolTip toolTipGlavMeny_BKV;
        private Button buttonHelp_BKV;
    }
}

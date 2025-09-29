namespace SalaoBeleza.Desktop
{
    partial class FormDashboard
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
            tblDivisao = new TableLayoutPanel();
            pnlAgendar = new Panel();
            btnAgendar = new Button();
            tblFormulario = new TableLayoutPanel();
            lblServico = new Label();
            cbxServico = new ComboBox();
            lblData = new Label();
            cbxData = new ComboBox();
            lblHorario = new Label();
            cbxHorario = new ComboBox();
            lblSub = new Label();
            lblTitulo = new Label();
            pnlAgendamentos = new FlowLayoutPanel();
            lblAgendamentos = new Label();
            lblSubAgendamentos = new Label();
            dgvDados = new DataGridView();
            tblDivisao.SuspendLayout();
            pnlAgendar.SuspendLayout();
            tblFormulario.SuspendLayout();
            pnlAgendamentos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDados).BeginInit();
            SuspendLayout();
            // 
            // tblDivisao
            // 
            tblDivisao.ColumnCount = 2;
            tblDivisao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tblDivisao.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tblDivisao.Controls.Add(pnlAgendar, 0, 0);
            tblDivisao.Controls.Add(pnlAgendamentos, 1, 0);
            tblDivisao.Dock = DockStyle.Fill;
            tblDivisao.Location = new Point(8, 8);
            tblDivisao.Name = "tblDivisao";
            tblDivisao.RowCount = 2;
            tblDivisao.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDivisao.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblDivisao.Size = new Size(1248, 665);
            tblDivisao.TabIndex = 0;
            // 
            // pnlAgendar
            // 
            pnlAgendar.BackColor = Color.FromArgb(35, 34, 37);
            pnlAgendar.Controls.Add(btnAgendar);
            pnlAgendar.Controls.Add(tblFormulario);
            pnlAgendar.Controls.Add(lblSub);
            pnlAgendar.Controls.Add(lblTitulo);
            pnlAgendar.Dock = DockStyle.Fill;
            pnlAgendar.Location = new Point(0, 0);
            pnlAgendar.Margin = new Padding(0);
            pnlAgendar.Name = "pnlAgendar";
            pnlAgendar.Padding = new Padding(20);
            pnlAgendar.Size = new Size(374, 645);
            pnlAgendar.TabIndex = 0;
            // 
            // btnAgendar
            // 
            btnAgendar.Dock = DockStyle.Bottom;
            btnAgendar.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnAgendar.Location = new Point(20, 593);
            btnAgendar.Name = "btnAgendar";
            btnAgendar.Size = new Size(334, 32);
            btnAgendar.TabIndex = 3;
            btnAgendar.Text = "Agendar Horário";
            btnAgendar.UseVisualStyleBackColor = true;
            // 
            // tblFormulario
            // 
            tblFormulario.ColumnCount = 1;
            tblFormulario.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblFormulario.Controls.Add(lblServico, 0, 0);
            tblFormulario.Controls.Add(cbxServico, 0, 1);
            tblFormulario.Controls.Add(lblData, 0, 2);
            tblFormulario.Controls.Add(cbxData, 0, 3);
            tblFormulario.Controls.Add(lblHorario, 0, 4);
            tblFormulario.Controls.Add(cbxHorario, 0, 5);
            tblFormulario.Dock = DockStyle.Top;
            tblFormulario.Location = new Point(20, 96);
            tblFormulario.Name = "tblFormulario";
            tblFormulario.RowCount = 6;
            tblFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblFormulario.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tblFormulario.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tblFormulario.Size = new Size(334, 192);
            tblFormulario.TabIndex = 2;
            // 
            // lblServico
            // 
            lblServico.AutoSize = true;
            lblServico.Dock = DockStyle.Top;
            lblServico.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblServico.ForeColor = Color.FromArgb(178, 175, 182);
            lblServico.Location = new Point(3, 0);
            lblServico.Name = "lblServico";
            lblServico.Size = new Size(328, 21);
            lblServico.TabIndex = 0;
            lblServico.Text = "Serviço";
            // 
            // cbxServico
            // 
            cbxServico.Dock = DockStyle.Fill;
            cbxServico.FormattingEnabled = true;
            cbxServico.Items.AddRange(new object[] { "Cabelo", "Unha", "Hidratação" });
            cbxServico.Location = new Point(3, 35);
            cbxServico.Name = "cbxServico";
            cbxServico.Size = new Size(328, 23);
            cbxServico.TabIndex = 3;
            // 
            // lblData
            // 
            lblData.AutoSize = true;
            lblData.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblData.ForeColor = Color.FromArgb(178, 175, 182);
            lblData.Location = new Point(3, 64);
            lblData.Name = "lblData";
            lblData.Size = new Size(46, 21);
            lblData.TabIndex = 1;
            lblData.Text = "Data";
            // 
            // cbxData
            // 
            cbxData.Dock = DockStyle.Fill;
            cbxData.FormattingEnabled = true;
            cbxData.Location = new Point(3, 99);
            cbxData.Name = "cbxData";
            cbxData.Size = new Size(328, 23);
            cbxData.TabIndex = 4;
            // 
            // lblHorario
            // 
            lblHorario.AutoSize = true;
            lblHorario.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblHorario.ForeColor = Color.FromArgb(178, 175, 182);
            lblHorario.Location = new Point(3, 128);
            lblHorario.Name = "lblHorario";
            lblHorario.Size = new Size(68, 21);
            lblHorario.TabIndex = 2;
            lblHorario.Text = "Horário";
            // 
            // cbxHorario
            // 
            cbxHorario.Dock = DockStyle.Fill;
            cbxHorario.FormattingEnabled = true;
            cbxHorario.Location = new Point(3, 163);
            cbxHorario.Name = "cbxHorario";
            cbxHorario.Size = new Size(328, 23);
            cbxHorario.TabIndex = 5;
            // 
            // lblSub
            // 
            lblSub.Dock = DockStyle.Top;
            lblSub.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel, 0);
            lblSub.ForeColor = Color.FromArgb(152, 149, 157);
            lblSub.Location = new Point(20, 54);
            lblSub.Name = "lblSub";
            lblSub.Size = new Size(334, 42);
            lblSub.TabIndex = 1;
            lblSub.Text = "Selecione o serviço, a data e informe o horário para criar o agendamento";
            // 
            // lblTitulo
            // 
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 20);
            lblTitulo.Margin = new Padding(0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(334, 34);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Agende um atendimento";
            // 
            // pnlAgendamentos
            // 
            pnlAgendamentos.Controls.Add(lblAgendamentos);
            pnlAgendamentos.Controls.Add(lblSubAgendamentos);
            pnlAgendamentos.Controls.Add(dgvDados);
            pnlAgendamentos.Dock = DockStyle.Fill;
            pnlAgendamentos.FlowDirection = FlowDirection.TopDown;
            pnlAgendamentos.Location = new Point(386, 0);
            pnlAgendamentos.Margin = new Padding(12, 0, 0, 0);
            pnlAgendamentos.Name = "pnlAgendamentos";
            pnlAgendamentos.Padding = new Padding(20);
            pnlAgendamentos.Size = new Size(862, 645);
            pnlAgendamentos.TabIndex = 1;
            // 
            // lblAgendamentos
            // 
            lblAgendamentos.AutoSize = true;
            lblAgendamentos.Dock = DockStyle.Top;
            lblAgendamentos.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            lblAgendamentos.ForeColor = Color.White;
            lblAgendamentos.Location = new Point(23, 20);
            lblAgendamentos.Name = "lblAgendamentos";
            lblAgendamentos.Size = new Size(820, 32);
            lblAgendamentos.TabIndex = 0;
            lblAgendamentos.Text = "Seus agendamentos";
            // 
            // lblSubAgendamentos
            // 
            lblSubAgendamentos.AutoSize = true;
            lblSubAgendamentos.Dock = DockStyle.Top;
            lblSubAgendamentos.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            lblSubAgendamentos.ForeColor = Color.FromArgb(152, 149, 157);
            lblSubAgendamentos.Location = new Point(23, 52);
            lblSubAgendamentos.Name = "lblSubAgendamentos";
            lblSubAgendamentos.Size = new Size(820, 21);
            lblSubAgendamentos.TabIndex = 1;
            lblSubAgendamentos.Text = "Consulte abaixo os seus últimos agendamentos";
            // 
            // dgvDados
            // 
            dgvDados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDados.Location = new Point(23, 76);
            dgvDados.Name = "dgvDados";
            dgvDados.Size = new Size(820, 546);
            dgvDados.TabIndex = 2;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 24, 27);
            ClientSize = new Size(1264, 681);
            Controls.Add(tblDivisao);
            MinimumSize = new Size(1280, 720);
            Name = "FormDashboard";
            Padding = new Padding(8);
            Text = "Salão de Beleza - Agendamento";
            tblDivisao.ResumeLayout(false);
            pnlAgendar.ResumeLayout(false);
            tblFormulario.ResumeLayout(false);
            tblFormulario.PerformLayout();
            pnlAgendamentos.ResumeLayout(false);
            pnlAgendamentos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDados).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tblDivisao;
        private Panel pnlAgendar;
        private Label lblSub;
        private Label lblTitulo;
        private TableLayoutPanel tblFormulario;
        private Label lblServico;
        private Label lblHorario;
        private ComboBox cbxServico;
        private ComboBox cbxData;
        private ComboBox cbxHorario;
        private Label lblData;
        private Button btnAgendar;
        private FlowLayoutPanel pnlAgendamentos;
        private Label lblAgendamentos;
        private Label lblSubAgendamentos;
        private DataGridView dgvDados;
    }
}
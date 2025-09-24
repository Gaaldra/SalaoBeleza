namespace SalaoBeleza.Desktop;

public partial class FormLogin : Form
{
    public FormLogin()
    {
        InitializeComponent();
    }

    private void FecharPrograma(object sender, EventArgs e)
    {
        this.Close();
    }

    private void btnEntrar_Click(object sender, EventArgs e)
    {

    }

    private void CadastrarUsuario(object sender, EventArgs e)
    {
        new FormCadastro().ShowDialog();
    }
}

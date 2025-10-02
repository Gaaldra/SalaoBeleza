using SalaoBeleza.Desktop.Banco_de_Dados;
using SalaoBeleza.Desktop.Servicos;

namespace SalaoBeleza.Desktop;

public partial class FormCadastro : Form
{
    public FormCadastro()
    {
        InitializeComponent();
    }

    private void FecharCadastro(object sender, EventArgs e)
    {
        this.Close();
    }

    private void CadastrarUsuario(object sender, EventArgs e)
    {
        UsuarioServicos userServicos = new(new SalaoBelezaContext());
    }
}

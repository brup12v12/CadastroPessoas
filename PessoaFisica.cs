namespace CadastroPessoas
{
    public class PessoaFisica : Pessoa
    {
        public string? cpf { get; set; }

        public DateTime dataNascimento { get; set; }

        public override float PagarImposto(float rendimento)
        {

            float taxa;
            if (rendimento <= 1500)
            {
                return 0;
            }
            else if (rendimento > 1500 && rendimento <= 3500)
            {
                taxa = (rendimento / 100) * 2;
                //return rendimento * .02f;
                return taxa;
            }
            else if (rendimento > 3500 && rendimento <= 6000)
            {
                taxa = (rendimento / 100) * 3.5f;
                return taxa;
            }
            else
            {
                taxa = (rendimento / 100) * 5;
                return taxa;
            }

        }

        public bool ValidarDataNascimento(DateTime dataNasc)
        {
            DateTime dataAtual = DateTime.Today;

            double anos = (dataAtual - dataNasc).TotalDays / 365;

            Console.WriteLine($"{anos}");

            if (anos >= 18)
            {
                return true;
            }
            return false;
        }

    }
}
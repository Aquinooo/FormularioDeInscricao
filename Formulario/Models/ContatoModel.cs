namespace Formulario.Models
{
    public class ContatoModel
    {
        
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Celular { get; set; }
        public string Plano { get; set; }
        public decimal Preco { get; set; }
        public DateTime DataViradaDePreco { get; set; } = new DateTime(2024, 10, 05); // aqui você pode colocar a data de virada de preço, coloquei uma data aleatória

        // método para calcular o preço do plano com base na data de virada, como foi pedido
        // não coloquei nenhuma informação sobre essa "virada de lote" na View porque não sei se era pra ser algo interno ou comunicado ao usuário
        public decimal CalcularPreco()
        {
            if (Plano == "assinaturaPremium")
            {
                // após a data de virada, o preço muda
                return DateTime.Now >= DataViradaDePreco ? 450 : 400; // preço antes e após a virada
            }
            else if (Plano == "assinaturaStandard")
            {
                return DateTime.Now >= DataViradaDePreco ? 250 : 220;
            }

            return 0; 
        }
    }
}


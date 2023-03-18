using NerdStore.Core.DomainObjects;

namespace NerdStore.Catalogo.Domain
{
    public class Categoria : Entity
    {
        public string Nome { get; private set; }

        public int Codigo { get; private set; }

        public Categoria(string nome, int codigo)
        {
            Validar();

            Nome = nome;
            Codigo = codigo;
        }

        public void Validar()
        {
            AssertionConcern.ValidarSeVazio(Nome, "O campo Nome da categoria não pode estar vazio");
            AssertionConcern.ValidarSeIgual(Codigo, 0, "O campo Codigo não pode ser 0");
        }

        public override string ToString()
        {
            return $"{Nome} - {Codigo}";
        }
    }
}

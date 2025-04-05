class Catalogo
{
    public Catalogo(string? nome)
    {
        Nome = nome;
    }

    private string? Nome { get; }
    private List<Jogo> jogos = new List<Jogo>();
    public void AdicionarJogo(Jogo jogo)
    {
        jogos.Add(jogo);
    }
    public void ExibirCatalogo()
    {
        System.Console.WriteLine($"---------- Catálogo de Jogos {Nome} ----------");
        foreach(Jogo jogo in jogos)
        {
            System.Console.WriteLine($"Jogo: {jogo.Nome}");
        }
    }
    public void DeletarJogo(Jogo jogo)
    {
        jogos.Remove(jogo);
    }
    public void AtualizarJogo(Jogo jogorem, Jogo jogoadd)
    {
        jogos.Remove(jogorem);
        jogos.Add(jogoadd);
    }
}
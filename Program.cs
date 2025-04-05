Jogo jogo1 = new Jogo("GTA V");
Jogo jogo2 = new Jogo("GTA San Andreas");

Catalogo catalogo = new Catalogo("Saga GTA");

catalogo.AdicionarJogo(jogo1);
catalogo.AdicionarJogo(jogo2);
catalogo.DeletarJogo(jogo2);
Jogo jogo3 = new Jogo("GTA Vice City");
catalogo.AtualizarJogo(jogo1, jogo3);
catalogo.ExibirCatalogo();

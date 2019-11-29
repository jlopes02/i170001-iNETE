using System;

namespace PSI10_iNETE
{
    public class Playlist
    {
        private string nome;
        private int qtdMusicas;
        private Musica[] musicas;

        public string Nome
        {
            set
            {
                if (nome == "")
                      throw new Exception("Nome inválido");           
                nome = value;
            }
            get { return nome; }
        }
        public Playlist(string _nome, int max)
        {
            musicas = new Musica[max];
            nome = _nome;
            qtdMusicas = 0;           
        }
        public bool AdicionarMusica (Musica musica)
        { 
            try
            {              
                musicas[qtdMusicas] = musica;
                qtdMusicas++;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public double DuracaoTotal()
        {
           double duracao = 0;
           foreach (Musica musica in musicas)
           {
                duracao += musica._Duracao;
           }
            return duracao;
        }

    }
}

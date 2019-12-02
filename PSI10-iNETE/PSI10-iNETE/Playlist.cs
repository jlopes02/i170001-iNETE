using System;

namespace PSI10_iNETE
{
    public class Playlist
    {
        private string nome;
        private int idPlaylist;
        private DateTime dataCriacao;
        public MusicCollection musicas;

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
        public string DataCriacao { get; set; }
        public int IdPlaylist
        {
            get
            {
                return idPlaylist;
            }
        }
        public Playlist(string n, int id)
        {
            Nome = n;
            idPlaylist = id;
            dataCriacao = DateTime.Today;
            musicas = new MusicCollection();
        }
            
       
    }
}

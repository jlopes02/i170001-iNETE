using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSI10_iNETE
{
    public class Musica
    {

        private string titulo, artista;
        private genero genero;
        private int duracao;

        public Musica(string _titulo, string _artista, int s, genero _genero)
        {
            Titulo = _titulo;
            Artista = _artista;
            Duracao = s;
            Genero = _genero;
        }

        public string Titulo
        {
            set
            {
                if (value == "") throw new Exception("Campo titulo vazio");
                titulo = value;
            }
            get { return titulo; }
        }

        public string Artista
        {
            set
            {
                if (value == "") throw new Exception("Campo artista vazio");
                artista = value;
            }
            get { return artista; }
        }
        
        public genero Genero { set; get; }
           
        public int Duracao
        {
            set
            {
                if (value <= 0)
                    throw new Exception("Duracao invalida");
                duracao = value;
            }
            get { return duracao; }
        }

        
    }

}

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
        private double duracao;

        public Musica(string _titulo, string _artista, int s, genero _genero)
        {
            Titulo = _titulo;
            Artista = _artista;
            duracao = s;
            genero = _genero;
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
        
        public genero Genero
        {
            set { genero = value; }
            get { return genero; }             
        }
       
        public double _Duracao
        {
            set
            {
                if (value <= 0)
                    throw new Exception("Duracao invalida");
                duracao = value / 60;
            }
            get { return duracao; }
        }

      
        public int Duracao()
        {
            return Convert.ToInt32(_Duracao * 60);
        }

    }

}

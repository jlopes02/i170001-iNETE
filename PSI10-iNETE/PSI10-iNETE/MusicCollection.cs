using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PSI10_iNETE
{
    public class MusicCollection : CollectionBase
    {
        public void AddMusica (Musica musica)
        {
            List.Add(musica);
        }

        public void RemoveMusica (Musica musica)
        {
            List.Remove(musica);
        }

        public void RemoveMusicaAt (int idx)
        {
            List.RemoveAt(idx);
        }

        public bool ContainsMusica (Musica musica)
        {
            return InnerList.Contains(musica);
        }
        /// <summary>
        /// Devolve um booleano dependendo se existe uma musica na coleção com os parâmetros artista/titulo/duracao especificados
        /// </summary>
        /// <param name="musica"></param>
        /// <returns></returns>
        public bool ContainsMusic (Musica musica) 
        {
            foreach (Musica m in this.List)
            {
                if (musica.Artista == m.Artista && musica.Titulo == m.Titulo && musica.Duracao == m.Duracao)
                    return true;
            }
            return false;
        }

        public Musica tituloToMusica (string artista, string titulo, int duracao)
        {
            foreach (Musica m in this.InnerList)
            {
                if (m.Artista == artista && m.Titulo == titulo && m.Duracao == duracao)
                    return m;
            }
            return null;
        }
        public int QtdMusicas()
        {
            return List.Count;
        }

        /// <summary>
        /// Devolve a quantidade de músicas do artista com o nome especificado
        /// </summary>
        /// <param name="artista"></param>
        /// <returns></returns>
        public int QtdMusicasArtista(string artista)
        {
            int cnt = 0;
            if (string.IsNullOrWhiteSpace(artista))
                throw new Exception("string inválida para o campo artista");
            foreach (Musica m in List)
            {
                if (m.Artista == artista)
                    cnt++;
            }

            return cnt;
        }

        /// <summary>
        /// Devolve a quantidade de músicas do género especificado
        /// </summary>
        /// <param name="genero"></param>
        /// <returns></returns>
        public int QtdMusicasGenero(genero genero)
        {
            int cnt = 0;

            foreach (Musica m in List)
            {
                if (m.Genero == genero)
                    cnt++;
            }

            return cnt;
        }
        /// <summary>
        /// Indexer da coleção de músicas
        /// </summary>
        /// <param name="idxMusica"></param>
        /// <returns></returns>
        public Musica this[int idxMusica]
        {
            set
            {
                List[idxMusica] = value;
            }
            get
            {
                return (Musica)List[idxMusica];
            }
        }


    }
}

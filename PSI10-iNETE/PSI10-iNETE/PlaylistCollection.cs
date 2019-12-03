using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace PSI10_iNETE
{
    public class PlaylistCollection : CollectionBase
    {
        public void AddPlaylist(Playlist playlist)
        {
            List.Add(playlist); 
        }

        public void RemovePlaylist(Playlist playlist)
        {
            List.Remove(playlist);
        }

        public void RemovePlaylistAt(int idx)
        {
            List.RemoveAt(idx);
        }

        /// <summary>
        /// Remove a playlist com o código especificado
        /// </summary>
        /// <param name="code"></param>
        public void RemovePlaylist(int code)
        {
            for (int idx = 0; idx < this.Count; idx++)
            {
                if (this[idx].IdPlaylist == code)
                    RemovePlaylistAt(idx);
            }
        }
        public int QtdPlaylists()
        {
            return List.Count;
        }

        /// <summary>
        /// Indexer da coleção de playlists
        /// </summary>
        /// <param name="idxPlaylist"></param>
        /// <returns></returns>
        public Playlist this[int idxPlaylist]
        {
            set
            {
                List[idxPlaylist] = value;
            }
            get
            {
                return (Playlist)List[idxPlaylist];
            }
        }
    }
}

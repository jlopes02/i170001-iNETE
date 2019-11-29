using System;

namespace PSI10_iNETE
{
    public class iNETE
    {
        private Playlist[] playlists;
        int qtdPlaylists;

        public iNETE(int max)
        {
            playlists = new Playlist[max];
        }
        public Playlist[] getPlayListList()
        {
            return playlists;
        }
        public bool AdicionarPlaylist(Playlist playlist)
        {
            try
            {
                for (int idx = 0; idx < playlists.Length; idx++)
                {
                    if (playlists[idx] == null)
                    {
                        playlists[idx] = playlist;
                        qtdPlaylists++;
                        return true;
                    }

                }
                return false;
            }
            catch
            {
                return false;
            }
        }
        public bool AdicionarPlaylist(Playlist playlist, int idx)
        {
            try
            {
                if (playlists[idx] == null)
                {
                    playlists[idx] = playlist;
                    return true;
                }

                for (int idx2 = idx; idx2 < playlists.Length; idx2++)
                {
                    if (playlists[idx2] == null)
                    {
                        for (;idx2!= idx ; idx2--)
                        {
                            playlists[idx2] = playlists[idx2 - 1];
                        }
                        playlists[idx] = playlist;
                    }
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public Playlist[] PlaylistsDuracaoMinima(int duracaoMinima)
        {
            Playlist[] _playlists = new Playlist[qtdPlaylists];
            int cnt = 0;
            foreach (Playlist playlist in playlists)
            {
                if (playlist.DuracaoTotal() >= duracaoMinima)
                {
                    _playlists[cnt] = playlist;
                    cnt++;
                }
            }
            return _playlists;
        }
    }
}

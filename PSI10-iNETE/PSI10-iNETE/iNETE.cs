using System;

namespace PSI10_iNETE
{
    public class iNETE
    {
        private PlaylistCollection playlists;

        

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

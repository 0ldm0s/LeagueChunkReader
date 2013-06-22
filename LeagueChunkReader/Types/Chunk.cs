using System;

namespace LeagueChunkReader.Types
{
    public class Chunk
    {
        private string m_path;

        #region Methods

        public Chunk(string p_path)
        {
            m_path = p_path;
        }

        #endregion
    }
}
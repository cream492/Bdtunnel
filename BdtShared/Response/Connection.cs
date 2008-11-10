// -----------------------------------------------------------------------------
// BoutDuTunnel
// Sebastien LEBRETON
// sebastien.lebreton[-at-]free.fr
// -----------------------------------------------------------------------------

#region " Inclusions "
using System;
#endregion

namespace Bdt.Shared.Response
{

    /// -----------------------------------------------------------------------------
    /// <summary>
    /// Une connexion au sein du tunnel
    /// </summary>
    /// -----------------------------------------------------------------------------
    [Serializable()]
    public struct Connection 
    {

        #region " Attributs "
        private string m_address;
        private string m_host;
        private int m_port;
        private DateTime m_lastAccess;
        private string m_cid;
        private int m_readcount;
        private int m_writecount;
        #endregion

        #region " Proprietes "
        /// -----------------------------------------------------------------------------
        /// <summary>
        /// Le nombre d'octets lus
        /// </summary>
        /// -----------------------------------------------------------------------------
        public int ReadCount 
        {
            get
            {
                return m_readcount;
            }
            set
            {
                m_readcount = value;
            }
        }

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// Le nombre d'octets écrits
        /// </summary>
        /// -----------------------------------------------------------------------------
        public int WriteCount
        {
            get
            {
                return m_writecount;
            }
            set
            {
                m_writecount = value;
            }
        }

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// L'adresse distante
        /// </summary>
        /// -----------------------------------------------------------------------------
        public string Address
        {
            get
            {
                return m_address;
            }
            set
            {
                m_address = value;
            }
        }

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// Le hôte distant
        /// </summary>
        /// -----------------------------------------------------------------------------
        public string Host
        {
            get
            {
                return m_host;
            }
            set
            {
                m_host = value;
            }
        }

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// Le port distant
        /// </summary>
        /// -----------------------------------------------------------------------------
        public int Port
        {
            get
            {
                return m_port;
            }
            set
            {
                m_port = value;
            }
        }

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// La date de dernier accès
        /// </summary>
        /// -----------------------------------------------------------------------------
        public DateTime LastAccess
        {
            get
            {
                return m_lastAccess;
            }
            set
            {
                m_lastAccess = value;
            }
        }

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// Le jeton de connexion
        /// </summary>
        /// -----------------------------------------------------------------------------
        public string Cid
        {
            get
            {
                return m_cid;
            }
            set
            {
                m_cid = value;
            }
        }
        #endregion

    }

}

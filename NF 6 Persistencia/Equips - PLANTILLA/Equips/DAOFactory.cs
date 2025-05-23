using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO_Pattern
{   public enum DataSource { XML, MySQL }
    public class DAOTeamFactory
    {
        
        public IDAO<Team> CreateDAOTeamInstance(DataSource source)
        {   IDAO<Team> dao=null;
            switch (source)
            {
                case DataSource.MySQL:
                    dao = (IDAO<Team>)(new IDAOTeamMySqlImpl());
                    break;
                case DataSource.XML:
                    dao = (IDAO<Team>)(new IDAOTeamXMLImpl());
                    break;
            }
              return dao;

        }
    }
}

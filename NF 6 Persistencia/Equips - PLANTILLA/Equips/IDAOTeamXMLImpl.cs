using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.XPath;

namespace DAO_Pattern
{
    public class IDAOTeamXMLImpl : IDAO<Team>
    {
        string xmlFile = "EQUIPS.XML";
        public void Delete(string id)
        {
            throw new NotImplementedException();
        }

        public HashSet<Team> GetAll()
        {
           
            return null;
        }

        public Team GetValue(string abv)
        {
            Team eq = null;
            XDocument docEquips = XDocument.Load(xmlFile);

            XElement e = docEquips.XPathSelectElement($"/EQUIPS/EQUIP[ABREVIACIO='{abv}']");
           
            if (e!=null) 
                eq = new Team(e.Element("ABREVIACIO").Value, e.Element("NOM").Value, Convert.ToInt32(e.Element("PRESSUPOST").Value), e.Element("LOGO").Value);
            return eq;
        }

        public void Save(Team value)
        {
            throw new NotImplementedException();
        }

        public void Update(string abreviacio, Team updatedTeam)
        {
            throw new NotImplementedException();
        }
    }
}

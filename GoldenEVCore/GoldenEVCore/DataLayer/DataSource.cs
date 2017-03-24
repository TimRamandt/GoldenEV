using GoldenEVCore.Models;
using System.Xml.Linq;

namespace GoldenEVCore.DataLayer
{
    class DataSource
    {
        private XDocument source;

        //datasource must be a Singleton.
        public DataSource()
        { }

        public void InitializeSource()
        {
            source = new XDocument(new XElement("body"));

            //local path will have to be removed in a later version.
            source.Save("C:\\Users\\Tim Ramandt\\Documents\\off-school projects\\GoldenEV\\GoldenEVData.xml");
        }

        public void FetchSource()
        {
            //TO DO:
            //implement later...
        }

        public void CreatePokemon(Pokemon pokemon)
        {
            
            /*using (StreamWriter file = new StreamWriter(Properties.Resources.Data.FullPath))
            {
                file.WriteLine(newPokemon);
            }*/
        }
    }
}

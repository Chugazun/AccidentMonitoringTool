using System.Collections.Generic;

namespace Petrobras_AccidentsMonitoring_Tool.Entities
{
    public class Stats
    {
        public string StatTag { get; private set; }
        public IEnumerable<Accident> resultList { get; set; }

        public Stats(string statTag, IEnumerable<Accident> resultList)
        {
            StatTag = statTag;
            this.resultList = resultList;
        }
    }
}

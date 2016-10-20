using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb3
{
    public class EventList : Event
    {
        #region EventList

        public List<Event> GetEventList()
        {
            List<Event> eventData = new List<Event>()
        {
            new EventList { EventType = "Concert", EventName = "Alter Bridge", Date = "2016-11-18", Time = "19:30" },
            new EventList { EventType = "Concert", EventName = "Behemoth", Date = "2016-12-17", Time = "19:30" },
            new EventList { EventType = "Concert", EventName = "Devin Townsend", Date = "2017-03-03", Time = "20:00" },
            new EventList { EventType = "Concert", EventName = "Russian Circles", Date = "2017-04-04", Time = "19:00" },
            new EventList { EventType = "Festival", EventName = "Wacken", Date = "2017-06-01", Time = "06:00" },
            new EventList { EventType = "Festival", EventName = "Rock Am Ring", Date = "2017-07-01", Time = "07:00" },
            new EventList { EventType = "Festival", EventName = "BOOM", Date = "2017-08-01", Time = "08:00" },
            new EventList { EventType = "Festival", EventName = "Sweden Rock", Date = "2017-09-01", Time = "09:00" },
            new EventList { EventType = "Movie", EventName = "Assassin's Creed", Date = "2017-01-13", Time = "20:00" },
            new EventList { EventType = "Movie", EventName = "Doctor Strange", Date = "2016-10-28", Time = "21:20" },
            new EventList { EventType = "Movie", EventName = "Guardians Of The Galaxy 2", Date = "2017-08-01", Time = "18:30" },
            new EventList { EventType = "Movie", EventName = "Rogue One; A Star Wars Story", Date = "2016-12-14", Time = "19:10" }
        };
            return eventData;
        }

        #endregion
    }
}
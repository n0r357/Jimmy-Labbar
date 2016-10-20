using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Labb3
{
    public abstract class Event
    {
        #region Properties

        public string UserName { get; set; }
        public string EventType { get; set; }
        public string EventName { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }

        #endregion

        #region ToStringOverride

        public override string ToString()
        {
            return String.Format("{0,-10}\t{1,-30}\t{2,-15}\t{3,-15}", EventType, EventName, Date, Time);
        }

        #endregion

        #region InformationFormat

        public virtual string Information()
        {
            return String.Format("{0,-10}\t{1,-30}\t{2,-15}\t{3,-15}", EventType, EventName, Date, Time);
        }

        #endregion
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    class BookingManager : MenuManager
    {
        #region Properties

        public List<string> BookingList { get; set; }

        public EventList EventList { get; set; }

        #endregion

        #region BookEvent

        //  Sorterar ut ett specifikt evengemang från en lista och lägger till bokningen i en annan lista
        public void BookSelectionFromEventList(List<Event> inputEventList, string inputSelection)
        {
            string[] eventSelection = inputEventList.Where(selection => String.Equals(selection.EventType, inputSelection)).Select(selection => selection.Information()).ToArray();
            bool loop;
            do
            {
                try
                {
                    Console.Clear();
                    LargeMenuBar();
                    EventMenuColumNames();
                    LargeMenuBar();
                    for (int i = 0; i < eventSelection.Length; i++)
                    {
                        Console.WriteLine("{0,-20}\t{1,-10}", i + 1, eventSelection[i]);
                    }
                    LargeMenuBar();
                    Console.Write("\t\t\t\t\t   Choice: ");
                    int bookingChoice = int.Parse(Console.ReadLine());
                    loop = MenuErrorHandling(bookingChoice, inputEventList.Count);
                    BookingList.Add(eventSelection[bookingChoice - 1]);
                }
                catch (Exception)
                {
                    loop = true;
                }
            } while (loop);
        }

        #endregion

        #region EventList

        //  Skriver ut lista över alla evengemang
                public void PrintCompeteEventList(List<Event> inputEventList)
                {
                    EventMeta[] inputMeta = inputEventList.Select(eventList => new EventMeta { EventData = eventList.ToString() }).ToArray();

                    Console.Clear();
                    LargeMenuBar();
                    EventMenuColumNames();
                    LargeMenuBar();
                    int counter = 1;

                    foreach (var inputEvent in inputMeta)
                    {
                        Console.WriteLine("{0,-20}\t{1,-10}", counter, inputEvent.EventData);
                        counter++;
                    }
                }

        #endregion

        #region Bookings

        //  Visar alla bokningar
        public void ViewBooking(string inputFullName)
        {
            Console.Clear();
            LargeMenuBar();
            BookingMenuColumnNames();
            LargeMenuBar();
            foreach (var booking in BookingList)
            {
                Console.WriteLine("{0,-20}\t{1}", inputFullName, booking);
            }
        }

        #endregion

        #region InformationOverride

        public override string Information()
        {
            return String.Format("{0,-20}\t{1}", UserName, base.Information());
        }

        #endregion

        #region MenuBars

        private void EventMenuColumNames()
        {
            Console.WriteLine("{0,-20}\t{1,-10}\t{2,-30}\t{3,-15}\t{4,-15}", "Index:", "Type:", "Name:", "Date:", "Time:");
        }
        private void BookingMenuColumnNames()
        {
            Console.WriteLine("{0,-20}\t{1,-10}\t{2,-30}\t{3,-15}\t{4,-15}", "User:", "Type:", "Name:", "Date:", "Time:");
        }
        private void LargeMenuBar()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------");
        }

        #endregion
    }
}

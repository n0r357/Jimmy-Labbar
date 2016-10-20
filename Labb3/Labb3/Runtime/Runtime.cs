using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb3
{
    class Runtime
    {
        public void Start()
        {
            #region ObjectInitiations

            BookingManager bookings = new BookingManager();
            EventList events = new EventList();
            GFX graphics = new GFX();
            MenuManager menu = new MenuManager();
            Person user = new Person(events.UserName = graphics.StartMenu());
            bookings.BookingList = new List<string>();

            #endregion

            #region Runtime

            do
            {
                switch (menu.BuildMenuAndReturnSelection(graphics.MainMenu()))
                {
                    case 1: //  Book Event Menu
                        switch (menu.BuildMenuAndReturnSelection(graphics.EventMenu()))
                        {
                            case 1: //  Book Concert
                                bookings.BookSelectionFromEventList(events.GetEventList(), "Concert");
                                graphics.BookingAdded();
                                break;
                            case 2: //  Book Festival
                                bookings.BookSelectionFromEventList(events.GetEventList(), "Festival");
                                graphics.BookingAdded();
                                break;
                            case 3: // Book Movie
                                bookings.BookSelectionFromEventList(events.GetEventList(), "Movie");
                                graphics.BookingAdded();
                                break;
                            default:
                                break;
                        }
                        break;
                    case 2: //  View All Events
                        bookings.PrintCompeteEventList(events.GetEventList());
                        graphics.PressKeyToContinue();
                        break;
                    case 3: //  View Bookings Menu
                        bookings.ViewBooking(events.UserName);
                        graphics.PressKeyToContinue();
                        break;
                    case 4: //  Quit Program
                        graphics.Quit();
                        break;
                    default:
                        break;
                }
            } while (!graphics.IsProgramOver);

            #endregion              
        }
    }
}

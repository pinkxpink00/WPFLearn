using System.Configuration;
using System.Data;
using System.Windows;
using WPFLearn.Models;

namespace WPFLearn
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            Hotel hotel = new Hotel("SingletonSuite");

            hotel.MakeReservation(new Reservation(
                new RoomID(1, 3),
                "Signleton",
                new DateTime(2000, 1, 2),
                new DateTime(2000, 1, 6)));

            IEnumerable<Reservation> reservations = hotel.GetAllReservations();

            base.OnStartup(e);
        }
    }

}

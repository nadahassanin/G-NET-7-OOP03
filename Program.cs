using System.Net.Sockets;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1: Relationships
            // a) Composition:  If University dies, Departments die too.
            // b) Association:  Driver and Car just use each other.
            // c) Inheritance:  A Dog is a type of Animal.
            // d) Aggregation:  If Team is deleted, Players stay alive.
            // e) Dependency:  The method only needs the Logger for a moment.
            #endregion
            #region Q2: Modifiers & Sealed
            // a) Protected: Yes, a child can see it in another assembly. 
            //    Outside instance? No, only children can see it.

            // b) Differences:
            //    Protected Internal: Child OR anyone in the same assembly.
            //    Private Protected: Child ONLY if it's in the same assembly.

            // c) Sealed:
            //    On Class: No one can inherit from it (The end of the family tree).
            //    On Method: No child can override it (Change its behavior).

            // d) New Sealed Class: Yes! You can use 'new' normally. 
            //    Sealed only stops inheritance, not creating objects.
            #endregion
            #region 1. Base Class Ticket
            //public class Ticket
            //        {
            //            private static int counter = 0;
            //            public int TicketId { get; }
            //            public string MovieName { get; set; }
            //            public decimal Price { get; set; }
            //            public decimal PriceAfterTax => Price * 1.14m;

            //            public Ticket(string name, decimal price)
            //            {
            //                counter++;
            //                TicketId = counter;
            //                MovieName = name;
            //                Price = price > 0 ? price : 50;
            //            }

            //            public static int GetTotalTickets() => counter;

            //            public override string ToString() =>
            //                $"ID: {TicketId}, Movie: {MovieName}, Price: {Price} LE";
            //        }
            #endregion
            #region 2. Child Classes
            //public class StandardTicket : Ticket
            //        {
            //            public string SeatNumber { get; set; }
            //            public StandardTicket(string n, decimal p, string s) : base(n, p) => SeatNumber = s;

            //            public override string ToString() => base.ToString() + $", Seat: {SeatNumber}";
            //        }

            //        public class VIPTicket : Ticket
            //        {
            //            public decimal ServiceFee { get; } = 50;
            //            public VIPTicket(string n, decimal p) : base(n, p) { }

            //            public override string ToString() => base.ToString() + $", Lounge: Yes, Fee: {ServiceFee}";
            //        }

            //        public class IMAXTicket : Ticket
            //        {
            //            public bool Is3D { get; set; }
            //            public IMAXTicket(string n, decimal p, bool is3d) : base(n, is3d ? p + 30 : p) => Is3D = is3d;

            //            public override string ToString() => base.ToString() + $", 3D: {Is3D}";
            //        }
            #endregion
            #region 3. Cinema & Projector 
//public class Projector
//        {
//            public void Start() => Console.WriteLine("Projector is ON");
//            public void Stop() => Console.WriteLine("Projector is OFF");
//        }

//        public class Cinema
//        {
//            public string Name { get; set; }
//            private Projector projector = new Projector(); // Composition
//            private Ticket[] tickets = new Ticket[20];

//            public void OpenCinema() => projector.Start();
//            public void CloseCinema() => projector.Stop();

//            public void AddTicket(Ticket t)
//            {
//                for (int i = 0; i < 20; i++)
//                {
//                    if (tickets[i] == null) { tickets[i] = t; break; }
//                }
//            }

//            public void PrintAll()
//            {
//                foreach (var t in tickets) if (t != null) Console.WriteLine(t.ToString());
//            }
//        }
        #endregion







    }


}
}

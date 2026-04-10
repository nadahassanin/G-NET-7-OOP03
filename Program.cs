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
    }
}
}

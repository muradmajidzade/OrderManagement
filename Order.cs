//using System.Diagnostics.Metrics;

//namespace OrderManagement
//{
//    public class Order
//    {
//        public int Id { get; set; }
//        public string? clientName { get; set; }
//        public int Price { get; set; }
//        public string? OrderStatus { get; set; }
//        public static int InProcess = 0;
//        public static int CountProcessed = 0;
//        public static int CountFailed = 0;

//        public Order (int id, string name, int price)
//        {
//            this.Id = id;
//            this.clientName = name;
//            this.Price = price;
//            this.OrderStatus = null;
//        }

//        // Sync
//        //public void checkOrder()
//        //{
//        //    Random random = new Random();
//        //    string[] statuses = ["Processed", "Failed"];

//        //    // 1. Check Availability
//        //    Thread.Sleep(random.Next(300, 500));

//        //    // 2. Calculate Total Cost
//        //    Thread.Sleep(random.Next(100, 600));

//        //    // 3. Process Payment
//        //    Thread.Sleep(random.Next(200, 800));

//        //    // 4. Send Notification
//        //    Thread.Sleep(random.Next(100, 400));
//        //    Console.WriteLine($"Order {Id}: notification sent to {clientName}");

//        //    // 5. Change Status
//        //    OrderStatus = statuses[random.Next(0, 2)];
//        //}


//        // Parallel
//        public void checkOrder()
//        {
//            Interlocked.Increment(ref InProcess);

//            Random random = new Random();
//            string[] statuses = ["Processed", "Failed"];

//            // 1. Check Availability
//            Thread.Sleep(random.Next(300, 500));

//            // 2. Calculate Total Cost
//            Thread.Sleep(random.Next(100, 600));

//            // 3. Process Payment
//            Thread.Sleep(random.Next(200, 800));

//            // 4. Send Notification
//            Thread.Sleep(random.Next(100, 400));
//            Console.WriteLine($"Order {Id}: notification sent to {clientName}");

//            // 5. Change Status
//            OrderStatus = statuses[random.Next(0, 2)];
//            Counter(this);
//            Interlocked.Decrement(ref InProcess);
//        }

//        public void Counter(Order order)
//        {
//            if (order.OrderStatus == "Processed")
//            {
//                Interlocked.Increment(ref CountProcessed);
//            }
//            else
//            {
//                Interlocked.Increment(ref CountFailed);
//            }
//        }
//    }
//}

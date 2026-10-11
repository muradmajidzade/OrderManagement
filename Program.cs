//using System.Diagnostics;
//using System.Diagnostics.Metrics;
//using System.Threading;
//using OrderManagement;

//var random = new Random();
//var orders = new List<Order>();

//for (int i = 0; i < 100; i++)
//{
//    orders.Add(new Order(i, $"Client {i}", random.Next(10, 1001)));
//}

//// Task 1
//Stopwatch stopwatch = new Stopwatch();

//stopwatch.Start();

//for (int i = 0; i < 100; i++)
//{
//    orders[i].checkOrder();
//}

//stopwatch.Stop();

//// Task 2
//Stopwatch stopwatch1 = new Stopwatch();

//stopwatch1.Start();
//var cts = new CancellationTokenSource();

//var inputThread = new Thread(() =>
//{
//    Console.WriteLine("Enter any button to stop");
//    Console.ReadKey(true);
//    cts.Cancel();
//});

//inputThread.IsBackground = true;
//inputThread.Start();

//var options = new ParallelOptions
//{
//    MaxDegreeOfParallelism = 5,
//    CancellationToken = cts.Token
//};

//try
//{
//    Parallel.ForEach(orders, options, order =>
//    {
//        order.checkOrder();
//    });
//}

//catch (OperationCanceledException)
//{
//    Console.WriteLine("Stopped");
//}

//stopwatch1.Stop();

//Console.WriteLine($"Processed: {Order.CountProcessed}");
//Console.WriteLine($"Failed: {Order.CountFailed}");
//Console.WriteLine($"In process: {Order.InProcess}");

//List<int> failedIds = orders
//                     .Where(order => order.OrderStatus == "Failed")
//                     .Select(order => order.Id)
//                     .ToList();

//for (int i = 0; i < failedIds.Count; i++)
//{
//    Console.Write($"{failedIds[i]} ");
//}

//Console.WriteLine($"Time of Sync: {stopwatch.Elapsed.TotalSeconds:F2} s");
//Console.WriteLine($"Time of Parallel: {stopwatch1.Elapsed.TotalSeconds:F2} s");
// Время выполнения отличается в примерно 5 раз так как в первый раз 1 поток обрабатывает каждый заказ а во втором сразу 5 потоков
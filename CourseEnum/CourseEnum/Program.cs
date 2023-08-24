using CourseEnum.Entities.Enums;
using CourseEnum.Entities;
using System;

namespace CourseEnum // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Order order = new Order
          {
              Id = 1,   Moment = DateTime.Now, Status = OrderStatus.PendingPayment,
          };

            Console.WriteLine(order);   
        }
    }
}
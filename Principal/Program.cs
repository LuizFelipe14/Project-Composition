using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Principal.Entities;
using Principal.Entities.Enums;

namespace Principal {
    class Program {
        static void Main(string[] args) {

            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);
        }
    }
}

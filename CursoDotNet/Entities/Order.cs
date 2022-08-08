using System;
using Curso.Entities.Enums;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Curso.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total ()
        {
            double sum = 0.0;

            foreach(OrderItem i in Items)
            {
                sum += i.SubTotal();
            }

            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();


            sb.AppendLine("ORDER SUMMARY: ");
            sb.AppendLine("Order Moment: " + Moment);
            sb.AppendLine("Order Status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order Items:");
            foreach (OrderItem oi in Items)
            {
                sb.AppendLine(oi.ToString());
            }

            sb.AppendLine("Total Price: R$" + Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
    }
    }

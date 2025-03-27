using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Backend.Core.Entities.Order
{
    public class OrderItem
    {
        public int Id { get; set; }  // ID interno do item no pedido
        public int OrderId { get; set; }  // ID do pedido ao qual pertence
        public Order? Order { get; set; }  // Relacionamento com o pedido

        public int ProductId { get; set; }  // ID do produto comprado
        public Product? Product { get; set; }  // Relacionamento com o produto

        public int Quantity { get; set; }  // Quantidade comprada
        public decimal UnitPrice { get; set; }  // Preço unitário no momento da compra
        public decimal TotalPrice => Quantity * UnitPrice; // Total do item
    }
}
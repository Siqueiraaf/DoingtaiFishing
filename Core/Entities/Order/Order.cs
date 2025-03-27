namespace Backend.Core.Entities.Order;
public class Order
{
        public int Id { get; set; }  // ID interno para otimização no banco
        public Guid OrderNumber { get; set; } = Guid.NewGuid(); // ID externo para segurança
        public int UserId { get; set; }  // ID do usuário que fez o pedido
        public User? User { get; set; } // Relacionamento com o usuário

        public List<OrderItem> Items { get; set; } = new List<OrderItem>(); // Lista de itens no pedido

        public decimal TotalAmount => Items.Sum(i => i.TotalPrice); // Total calculado automaticamente

        public OrderStatus Status { get; set; } = OrderStatus.Pending; // Status do pedido

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow; // Data do pedido
        public DateTime? UpdatedAt { get; set; }  // Última atualização
}

namespace Backend.Core.Entities.Order;
public enum OrderStatus
{
    Pending,    // Pedido realizado, aguardando pagamento
    Paid,       // Pedido pago
    Shipped,    // Pedido enviado
    Delivered,  // Pedido entregue
    Canceled    // Pedido cancelado
}


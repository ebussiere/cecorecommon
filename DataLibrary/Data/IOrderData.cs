using System.Threading.Tasks;
using DataLibrary.Db.Models;

namespace DataLibrary.Data
{
    internal interface IOrderData
    {
        Task<int> CreateOrder(OrderModel order);
        Task<int> UpdateOrderName(int orderId,string orderName);
        Task<int> DeleteOrder(int orderId);
        Task<OrderModel> GetOrderById(int orderId);
    }
}
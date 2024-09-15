using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestaurantFavesApp.Data;
using RestaurantFavesApp.Models;

namespace RestaurantFavesApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        
        private readonly OrderDbContext _ordersDB;

        public OrdersController(OrderDbContext OrdersDbContext)
        {
            _ordersDB = OrdersDbContext;
        }

        [HttpGet]
        public ActionResult<Order> GetOrders()
        {

            return Ok(_ordersDB.Orders.ToList());
        }

        [HttpGet("{id}")]
        public ActionResult<Order> GetOrder(int id)
        {
            var order = _ordersDB.Orders.Find(id);

            if (order == null)

            {
                return NotFound();
            }
            return Ok(order);
        }

        [HttpPost]
        public ActionResult<Order> CreateOrder([FromBody] Order newOrder)
        {
            
            _ordersDB.Add(newOrder);
            _ordersDB.SaveChanges();

            return CreatedAtAction(nameof(GetOrder), new { id = newOrder.Id }, newOrder);
        }

        [HttpPut("{id}")]
        public ActionResult UpdateOrder(int id, [FromBody] Order updatedOrder)
        {
            var order = _ordersDB.Orders.Find(id);
            if (order == null)
                return NotFound();

            order.Description = updatedOrder.Description;
            order.Restaurant = updatedOrder.Restaurant;
            order.Rating = updatedOrder.Rating;
            order.OrderAgain = updatedOrder.OrderAgain;

            _ordersDB.SaveChanges();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteOrder(int id)
        {
            var order = _ordersDB.Orders.Find(id);
            if (order == null)
                return NotFound();

            _ordersDB.Orders.Remove(order);
            _ordersDB.SaveChanges();

            return NoContent();
        }
    }
}

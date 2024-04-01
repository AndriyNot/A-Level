using HomeWork4._5.Data;
using HomeWork4._5.DTOs;
using HomeWork4._5.Models;
using HomeWork4._5.Service.Abstractions;

namespace HomeWork4._5
{
    public class App
    {
        private readonly IUserService _userService;
        private readonly IOrderService _orderService;
        private readonly IProductService _productService;
        

        public App(
            IUserService userService,
            IOrderService orderService,
            IProductService productService)
        {
            _userService = userService;
            _orderService = orderService;
            _productService = productService;
        }
        
        public async Task Start()
        {
            var firstName = "Andrii";
            var lastName = "Fartukh";

            var userId = await _userService.AddUser(firstName, lastName);
            

            await _userService.GetUser(userId);

            var product1 = await _productService.AddProductAsync("TV Samsung", 99);
            var product2 = await _productService.AddProductAsync("Apple", 7);

            var order1 = await _orderService.AddOrderAsync(userId, new List<OrderItem>()
        {
            new OrderItem()
            {
                Count = 3,
                ProductId = product1
            },

            new OrderItem()
            {
                Count = 6,
                ProductId = product2
            },
        });

            var order2 = await _orderService.AddOrderAsync(userId, new List<OrderItem>()
        {
            new OrderItem()
            {
                Count = 1,
                ProductId = product1
            },

            new OrderItem()
            {
                Count = 9,
                ProductId = product2
            },
        });

            await _orderService.GetOrderByUserIdAsync(userId);

            await _userService.DeleteUserAsync("f19f68ff-2184-4a41-9396-1f2291230d12");

            await _productService.DeleteProductAsync(42);

            var pageDto = new PageDto
            {
                PageSize = 20,
                Filter = new FilterDto
                {
                    Name = "Apple", 
                    Price = 50 
                }
            };

            var filteredProducts = await _productService.GetFilteredProductsAsync(pageDto);

            
            foreach (var product in filteredProducts)
            {
                Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}");
            }

        }
    }
}

using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using SimpleMVCApp.Models;

public class OrderController : Controller
{
    
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Add(Order order)
    {
        if (order.ProductPrice > 0 && order.ProductAmount > 0)
    {
        decimal totalCost = order.ProductPrice * order.ProductAmount;
        ViewBag.OrderMessage = $"Your order of {order.ProductName} been placed successfully!";
        ViewBag.TotalCost = $"Total Cost: R{totalCost:F2}";
    }
    else
    {
        ViewBag.OrderMessage = "Invalid order details. Please check the inputs.";
        ViewBag.TotalCost = "";
    }
    
    return View("Index");
    }
}
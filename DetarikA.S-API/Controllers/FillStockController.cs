using DetarikA.S_API.Models.ContexClasses;
using DetarikA.S_API.Models.Entities;
using DetarikA.S_API.RequestModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DetarikA.S_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FillStockController : ControllerBase
    {
        MyContext _db;
        public FillStockController(MyContext db)
        {
            _db = db;
        }
        [HttpPost]
        public async Task<IActionResult> StartFilling(FillRequestModel model)
        {     
            if (_db.Dealers.Any(x=>x.CompanyName==model.CompanyName)&&_db.Products.Any(x=>x.ProductName==model.ProductName)) // gelen istekteki verileri veri tabanımızdaki verilerle kıyaslayıp böyle bir firma ve ürün var mı diye kontrol ediyoruz
            {

                Dealer? dealer = await _db.Dealers.FirstOrDefaultAsync(x => x.CompanyName == model.CompanyName); //dealeri yakalıyoruz.
                Product? product = await _db.Products.FirstOrDefaultAsync(x => x.ProductName == model.ProductName);// Productı yakılıyoruz.
                Order order = new()
                {
                    DealerID = dealer.ID,
                    TotalPrice = model.Quantity * product.UnitPrice
                };
                await _db.Orders.AddAsync(order);
                await _db.SaveChangesAsync();
                OrderDetail detail = new()
                {
                    OrderID = order.ID,
                    ProductID = product.ID,
                    Quantity = model.Quantity,
                };


                await _db.OrderDetails.AddAsync(detail);
                dealer.Orders.Add(order);
                _db.Dealers.Update(dealer);
                await _db.SaveChangesAsync();

                return Ok("Siparişiniz alındı.");
            }
            return StatusCode(400,"Firma adı yada Ürün Adını kontrol ediniz.");
        }
    }
}

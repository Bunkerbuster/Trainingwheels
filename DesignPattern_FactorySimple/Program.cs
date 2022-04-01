

//create order
using DesignPattern_FactorySimple.Business;

var cart = new ShoppingCart(order);
var ShippingLabel = cart.Finalize();
Console.WriteLine(ShippingLabel);





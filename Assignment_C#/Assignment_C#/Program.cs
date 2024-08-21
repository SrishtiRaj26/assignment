using System;
 
abstract class Product
{
    
    public string Name { get; set; }
   
    public abstract void Dispense();
}

class Snack : Product
{
   
    public Snack()
    {
        
        Name = "Snack";
    }
   
    public override void Dispense()
    {
        
        Console.WriteLine("Dispensing a snack...");
    }
}

class Beverage : Product
{
   
    public Beverage()
    {
       
        Name = "Beverage";
    }
   
    public override void Dispense()
    {
        
        Console.WriteLine("Dispensing a beverage...");
    }
}

interface IVendingMachine
{

    void SelectProduct(Product product);
  
    void DispenseProduct();
}

class VendingMachine : IVendingMachine
{

    private Product selectedProduct;
  
    public VendingMachine()
    {
       
        selectedProduct = null;
    }
    public void SelectProduct(Product product)
    {
        
        selectedProduct = product;
       
        Console.WriteLine("You have selected a " + product.Name);
    }

    public void DispenseProduct()
    {
      
        if (selectedProduct != null)
        {
           
            selectedProduct.Dispense();
           
            selectedProduct = null;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
       
        VendingMachine vendingMachine = new VendingMachine();
       
        Snack snack = new Snack();
     
        Beverage beverage = new Beverage();
         
        vendingMachine.SelectProduct(snack);
        vendingMachine.DispenseProduct();
         
        vendingMachine.SelectProduct(beverage);
        vendingMachine.DispenseProduct();
         
        vendingMachine.DispenseProduct();
    }
}
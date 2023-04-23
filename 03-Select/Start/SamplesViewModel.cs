using System.Text;

namespace LINQSamples
{
  public class SamplesViewModel : ViewModelBase
  {
    #region GetAllQuery
    /// <summary>
    /// Put all products into a collection using LINQ
    /// </summary>
    public List<Product> GetAllQuery()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Query Syntax Here
      //list = (from prod in products select prod).ToList();
      list = (from prod in products select prod).ToList();

      return list;
    }
    #endregion

    #region GetAllMethod
    /// <summary>
    /// Put all products into a collection using LINQ
    /// </summary>
    public List<Product> GetAllMethod()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Method Syntax Here
      list = products.Select(prod=>prod).ToList();

      return list;
    }
    #endregion

    #region GetSingleColumnQuery
    /// <summary>
    /// Select a single column
    /// </summary>
    public List<string> GetSingleColumnQuery()
    {
      List<Product> products = GetProducts();
      List<string> list = new();
      
      // Write Query Syntax Here
      // we only get one property on the other hand 
      // we get a single column from the property
      // its a list of string so we will choose the name
      list.AddRange(from prod in products select prod.Name);
      return list;
    }
    #endregion

    #region GetSingleColumnMethod
    /// <summary>
    /// Select a single column
    /// </summary>
    public List<string> GetSingleColumnMethod()
    {
      List<Product> products = GetProducts();
      List<string> list = new();
     
      // Write Method Syntax Here
      // use  addRange to add multiple value 
      // in a list
      list.AddRange(products.Select(prod=>prod.Name));

      return list;
    }
    #endregion

    #region GetSpecificColumnsQuery
    /// <summary>
    /// Select a few specific properties from products and create new Product objects
    /// </summary>
    public List<Product> GetSpecificColumnsQuery()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      // Write Query Syntax Here
      list = (from prod in products select 
      new Product
      {
          ProductID = prod.ProductID,
          Name      = prod.Name,
          Size      = prod.Size
      }).ToList();

      return list;
    }
    #endregion

    #region GetSpecificColumnsMethod
    /// <summary>
    /// Select a few specific properties from products and create new Product objects
    /// </summary>
    public List<Product> GetSpecificColumnsMethod()
    {
      List<Product> products = GetProducts();
      List<Product> list = new();

      list = products.Select(prod=> new Product{
          ProductID = prod.ProductID,
          Name = prod.Name,
          Size = prod.Size
      }).ToList();
      

      return list;
    }
    #endregion

    #region AnonymousClassQuery
    /// <summary>
    /// Create an anonymous class from selected product properties
    /// </summary>
    public string AnonymousClassQuery()
    {
      List<Product> products = GetProducts();
      StringBuilder sb = new(2048);

      // Write Query Syntax Here
      var list = (from prod in products
                  select new {
                    Identifier  = prod.ProductID,
                    ProductName = prod.Name,
                    ProductSize = prod.Size
                  }).ToList();
      

      // Loop through anonymous class
      //foreach (var prod in list)
      //{
      //  sb.AppendLine($"Product ID: {prod.Identifier}");
      //  sb.AppendLine($"   Product Name: {prod.ProductName}");
      //  sb.AppendLine($"   Product Size: {prod.ProductSize}");
      //}

      foreach(var prod in list){
        sb.AppendLine($"Product ID: {prod.Identifier}\n");
        sb.AppendLine($"Product Name: {prod.ProductName}\n");
        sb.AppendLine($"Product Size: {prod.ProductSize}\n");
        sb.AppendLine($"--------------------------------\n");

      }
      return sb.ToString();
    }
    #endregion

    #region AnonymousClassMethod
    /// <summary>
    /// Create an anonymous class from selected product properties
    /// </summary>
    public string AnonymousClassMethod()
    {
      List<Product> products = GetProducts();
      StringBuilder sb = new(2048);

      // Write Method Syntax Here
      var list = products.Select(prod=>new{
          Identifier = prod.ProductID,
          ProductName = prod.Name,
          ProductSize = prod.Size
      }).ToList();

      // Loop through anonymous class
      foreach (var prod in list)
      {
       sb.AppendLine($"Product ID: {prod.Identifier}\n");
       sb.AppendLine($"Product Name: {prod.ProductName}\n");
       sb.AppendLine($"Product Size: {prod.ProductSize}\n");
       sb.AppendLine("----------------------------------\n");
      }

      return sb.ToString();
    }
    #endregion
  }
}

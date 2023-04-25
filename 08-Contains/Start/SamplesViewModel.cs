using Start.ProductComparer;
namespace LINQSamples
{
  public class SamplesViewModel : ViewModelBase
  {
    #region AllQuery
    /// <summary>
    /// Use All() to see if all items in a collection meet a specified condition
    /// </summary>
    public bool AllQuery()
    {
      List<Product> products = GetProducts();
      bool value = false;

      // Write Query Syntax Here
      // if all elements are true for the condition then return true
      // otherwise return false
      value = (from prod in products select prod).All(prod=>prod.ListPrice> prod.StandardCost);
      return value;
    }
    #endregion

    #region AllMethod
    /// <summary>
    /// Use All() to see if all items in a collection meet a specified condition
    /// </summary>
    public bool AllMethod()
    {
      List<Product> products = GetProducts();
      bool value = false;
      value = products.All(prod=>prod.ListPrice> prod.StandardCost);
      // Write Method Syntax Here
      

      return value;
    }
    #endregion

    #region AllSalesQuery
    /// <summary>
    /// Use All() to see if all items in a collection meet a specified condition
    /// </summary>
    public bool AllSalesQuery()
    {
      List<SalesOrder> sales = GetSales();
      bool value = false;

      value = (from sale in sales select sale).All(sale=>sale.OrderQty >0);
      // Write Query Syntax Here
      

      return value;
    }
    #endregion

    #region AllSalesMethod
    /// <summary>
    /// Use All() to see if all items in a collection meet a specified condition
    /// </summary>
    public bool AllSalesMethod()
    {
      List<SalesOrder> sales = GetSales();
      bool value = false;
      value = sales.All(sale=>sale.OrderQty >0);
      // Write Method Syntax Here
      return value;
    }
    #endregion

    #region AnyQuery
    /// <summary>
    /// Use Any() to see if at least one item in a collection meets a specified condition
    /// </summary>
    public bool AnyQuery()
    {

      // if any of the element is true in condition
      // return true
      // other wise return false
      // if just one is matched then return true
      List<SalesOrder> sales = GetSales();
      bool value = false;

      // Write Query Syntax Here
      value = (from sale in sales select sale).Any(s=>s.OrderQty > 10000);

      return value;
    }
    #endregion

    #region AnyMethod
    /// <summary>
    /// Use Any() to see if at least one item in a collection meets a specified condition
    /// </summary>
    public bool AnyMethod()
    {
      List<SalesOrder> sales = GetSales();
      bool value = false;
      value = sales.Any(s=>s.OrderQty > 10000);
      // Write Method Syntax Here
      

      return value;
    }
    #endregion

    #region ContainsQuery
    /// <summary>
    /// Use the Contains() operator to see if a collection contains a specific value
    /// </summary>
    public bool ContainsQuery()
    {
      List<int> numbers = new() { 1, 2, 3, 4, 5 };
      bool value = false;

      // Write Query Syntax Here
      // value = (from number in numbers select number).Contains(3); // return true
      // value = (from number in numbers select number).Contains(100); // return false

      return value;
    }
    #endregion

    #region ContainsMethod
    /// <summary>
    /// Use the Contains() operator to see if a collection contains a specific value
    /// </summary>
    public bool ContainsMethod()
    {
      List<int> numbers = new() { 1, 2, 3, 4, 5 };
      bool value = false;

      // Write Method Syntax Here
      // value = numbers.Contains(3); // return true
      // value = numbers.Contains(100); // return false

      return value;
    }
    #endregion

    #region ContainsComparerQuery
    /// <summary>
    /// Use the Contains() operator to see if a collection contains a specific value
    /// </summary>
    public bool ContainsComparerQuery()
    {
      List<Product> products = GetProducts();
      ProductIdComparer pc = new();
      bool value = false;

      // Write Query Syntax Here
      // contains take a product object and a comparer
      value = (from prod in products select prod).Contains(new Product{ProductID = 706},pc);

      return value;
    }
    #endregion

    #region ContainsComparerMethod
    /// <summary>
    /// Use the Contains() operator to see if a collection contains a specific value.
    /// When comparing classes, you need to write a EqualityComparer class.
    /// </summary>
    public bool ContainsComparerMethod()
    {
      List<Product> products = GetProducts();
      ProductIdComparer pc = new();
      bool value = false;

      // Write Method Syntax Here
      value = products.Contains(new Product{ProductID = 706},pc);
      

      return value;
    }
    #endregion
  }
}

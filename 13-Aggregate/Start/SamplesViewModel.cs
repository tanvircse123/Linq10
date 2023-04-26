namespace LINQSamples
{
  public class SamplesViewModel : ViewModelBase
  {
    #region CountQuery
    /// <summary>
    /// Gets the total number of products in a collection
    /// </summary>
    public int CountQuery()
    {
      int value = 0;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Query Syntax Here
      // aggragate function will apply after the query is executed
      // means after you getting all the data
      value = (from prod in products select prod).Count();
      return value;
    }
    #endregion

    #region CountMethod
    /// <summary>
    /// Gets the total number of products in a collection
    /// </summary>
    public int CountMethod()
    {
      int value = 0;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax Here
      // there is a property and there is method
      // if possible always use the property not the method
      // it is more efficient
      value = products.Count;

      return value;
    }
    #endregion

    #region CountFilteredQuery
    /// <summary>
    /// Can either add a where clause or a predicate in the Count() method
    /// </summary>
    public int CountFilteredQuery()
    {
      int value = 0;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Query Syntax #1 Here
      value = (from prod in products where prod.Color == "Red" select prod).Count();

      // Write Query Syntax #2 Here
     
     value = (from prod in products select prod).Count(s=>s.Color == "Red");

      return value;
    }
    #endregion

    #region CountFilteredMethod
    /// <summary>
    /// Gets the total number of products in a collection
    /// </summary>
    public int CountFilteredMethod()
    {
      int value = 0;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax #1 Here
      value = products.Where(s=>s.Color == "Red").Count();
      value = products.Count(s=>s.Color == "Red");

      // Write Method Syntax #2 Here
      

      return value;
    }
    #endregion

    #region MinQuery
    /// <summary>
    /// Get the minimum value of a single property in a collection
    /// </summary>
    public decimal MinQuery()
    {
      decimal value = 0;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Query Syntax #1 Here
      value = (from product in products select product.ListPrice).Min();
      value = (from product in products select product).Min(s=>s.ListPrice);
     

      // Write Query Syntax #2 Here
      

      return value;
    }
    #endregion

    #region MinMethod
    /// <summary>
    /// Get the minimum value of a single property in a collection
    /// </summary>
    public decimal MinMethod()
    {
      decimal value = 0;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax #1 Here
      value = products.Select(s=>s.ListPrice).Min();
      value = products.Min(s=>s.ListPrice);
      // Write Method Syntax #2 Here
      

      return value;
    }
    #endregion

    #region MaxQuery
    /// <summary>
    /// Get the maximum value of a single property in a collection
    /// </summary>
    public decimal MaxQuery()
    {
      decimal value = 0;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Query Syntax #1 Here
      value = (from product in products select product.ListPrice).Max();
      value = (from product in products select product).Max(s=>s.ListPrice);

      // Write Query Syntax #2 Here
     

      return value;
    }
    #endregion

    #region MaxMethod
    /// <summary>
    /// Get the maximum value of a single property in a collection
    /// </summary>
    public decimal MaxMethod()
    {
      decimal value = 0;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax #1 Here
      value = products.Select(s=>s.ListPrice).Max();
      value = products.Max(s=>s.ListPrice);
      // Write Method Syntax #2 Here
      

      return value;
    }
    #endregion

    #region MinByQuery
    /// <summary>
    /// Get the minimum value of a single property in a collection, but return the object
    /// </summary>
    public Product MinByQuery()
    {
      Product product = null;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Query Syntax Here
      // you can easily find min and max of some value
      // but if the question asked that find the whole object
      // that has the minimum value then you use the MinBy and MaxBy
      

      // this is my dumb implementation
      product = (from prod in products orderby prod.ListPrice ascending select prod).FirstOrDefault();
      
      // there are better ways to do that
      product = (from prod in products select prod).MinBy(s=>s.ListPrice);


      return product;
    }
    #endregion

    #region MinByMethod
    /// <summary>
    /// Get the minimum value of a single property in a collection, but return the object
    /// </summary>
    public Product MinByMethod()
    {
      Product product = null;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax Here
      // my implmentation
      product = products.OrderBy(s=>s.ListPrice).FirstOrDefault();
      product = products.MinBy(s=>s.ListPrice);

      return product;
    }
    #endregion

    #region MaxByQuery
    /// <summary>
    /// Get the maximum value of a single property in a collection, but return the object
    /// </summary>
    public Product MaxByQuery()
    {
      Product product = null;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Query Syntax Here
      // my implementation
      product = (from prod in products orderby prod.ListPrice descending  select prod).FirstOrDefault();
      product = (from prod in products select prod).MaxBy(s=>s.ListPrice);
     

      return product;
    }
    #endregion

    #region MaxByMethod
    /// <summary>
    /// Get the maximum value of a single property in a collection, but return the object
    /// </summary>
    public Product MaxByMethod()
    {
      Product product = null;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax Here
      product = products.OrderByDescending(s=>s.ListPrice).FirstOrDefault();
      product = products.MaxBy(s=>s.ListPrice); 

      return product;
    }
    #endregion

    #region AverageQuery
    /// <summary>
    /// Get the average of all values within a single property in a collection
    /// </summary>
    public decimal AverageQuery()
    {
      decimal value = 0;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Query Syntax #1 Here
      // get only the average value not the object
      value = (from prod in products select prod.ListPrice).Average();
      value = (from prod in products select prod).Average(s=>s.ListPrice);
      // what if you want the object that has average value
      var avgProduct = (from prod in products where prod.ListPrice == products.Average(s=>s.ListPrice) select prod);

      // Write Query Syntax #2 Here
      

      return value;
    }
    #endregion

    #region AverageMethod
    /// <summary>
    /// Get the average of all values within a single property in a collection
    /// </summary>
    public decimal AverageMethod()
    {
      decimal value = 0;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax #1 Here
      //value = products.Select(s=>s.ListPrice).Average();
      value = products.Average(s=>s.ListPrice);
      
      

      // Write Method Syntax #2 Here
      

      return value;
    }
    #endregion

    #region SumQuery
    /// <summary>
    /// Gets the sum of the values of a single property in a collection
    /// </summary>
    public decimal SumQuery()
    {
      decimal value = 0;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Query Syntax #1 Here
      value = (from prod in products select prod.ListPrice).Sum();
      value = (from prod in products select prod).Sum(s=>s.ListPrice);
      

      // Write Query Syntax #2 Here
      

      return value;
    }
    #endregion

    #region SumMethod
    /// <summary>
    /// Gets the sum of the values of a single property in a collection
    /// </summary>
    public decimal SumMethod()
    {
      decimal value = 0;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax #1 Here
      value = products.Select(s=>s.ListPrice).Sum();
      //value = products.Sum(s=>s.ListPrice);
      

      // Write Method Syntax #1 Here
      

      return value;
    }
    #endregion

    #region AggregateQuery
    /// <summary>
    /// Aggregate allows you to iterate over a collection and perform an accumulation of values. With this operator you can simulate count, sum, etc.
    /// </summary>
    public decimal AggregateQuery()
    {
      decimal value = 0;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Query Syntax Here
      // sum min max  avg they are aggragate function
      // but if you want tomake a aggragate method with custom logic that iterate
      // over the collection and return a single value then this is the example
      // we implement the sum with aggragate value
      //var starting_value = 0M; // M for decimal
      //value = (from prod in products select prod).Aggregate(starting_value,(sum,prod)=>
      //        sum+=prod.ListPrice
      //);

      // make a average method with aggragate 
      // remember it must be after the query 
      var starting = 0M;
      value = (from prod in products select prod).Aggregate(starting,(sum,prod)=>sum+=prod.ListPrice)/products.Count();

      return value;
    }
    #endregion

    #region AggregateMethod
    /// <summary>
    /// Aggregate allows you to iterate over a collection and perform an accumulation of values. With this operator you can simulate count, sum, etc.
    /// </summary>
    public decimal AggregateMethod()
    {
      decimal value = 0;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax Here
      value = products.Aggregate(0M,(sum,prod)=>sum+=prod.ListPrice);
      

      return value;
    }
    #endregion

    #region AggregateCustomQuery
    /// <summary>
    /// Use Sales Orders and calculate the total Sales by multiplying OrderQty * UnitPrice for each order
    /// </summary>
    public decimal AggregateCustomQuery()
    {
      decimal value = 0;
      // Load all Sales Data
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Query Syntax Here
      value = (from sale in sales select sale).Aggregate(0M,(sum,sale)=>sum+=sale.OrderQty*sale.UnitPrice);
      return value;
    }
    #endregion

    #region AggregateCustomMethod
    /// <summary>
    /// Use Sales Orders and calculate the total Sales by multiplying OrderQty * UnitPrice for each order
    /// </summary>
    public decimal AggregateCustomMethod()
    {
      decimal value = 0;
      // Load all Sales Data
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Method Syntax Here
      value = sales.Aggregate(0M,(sum,sale)=>sum+=sale.OrderQty*sale.UnitPrice);
      

      return value;
    }
    #endregion

    #region AggregateUsingGroupByQuery
    /// <summary>
    /// Group products by Size property and calculate min/max/average prices
    /// </summary>
    public List<ProductStats> AggregateUsingGroupByQuery()
    {
      List<ProductStats> list = null;
      // Load all Sales Data
      List<Product> products = ProductRepository.GetAll();

      // Write Query Syntax Here
      // just remember this always when you use group by 
      // something you get multiple array inside a list
      // based on the thing you group by
      // 1) from prod in products group prod by prod.Size into sizeGroup where sizeGroup.Count()>0
      // in this part we group products in different chunks and then sql having clause in to therit chunks
      // to filter out any chunks that has no element
      // why we put those value into sizeGroup? because we now need the chunks of value in a list to work with
      // our work now based on the sizegroup value
      // we group the product by Size so the Key attribute will be the Size value
      // when we use selecr after sizeGroup we take chunks one by one
      list = (from prod in products 
      group prod by prod.Size 
      into sizeGroup 
      where sizeGroup.Count()>0
      select new ProductStats{
          Size = sizeGroup.Key,
          TotalProducts = sizeGroup.Count(),
          MinListPrice = sizeGroup.Min(s=>s.ListPrice),
          MaxListPrice = sizeGroup.Max(s=>s.ListPrice),
          AverageListPrice = sizeGroup.Average(s=>s.ListPrice),

        }
        into result
        orderby result.Size
        select result
    ).ToList();

      return list;
    }
    #endregion

    #region AggregateUsingGroupByMethod
    /// <summary>
    /// Group products by Size property and calculate min/max/average prices
    /// </summary>
    public List<ProductStats> AggregateUsingGroupByMethod()
    {
      List<ProductStats> list = null;
      // Load all Sales Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax Here
      

      return list;
    }
    #endregion

    #region AggregateMoreEfficientMethod
    /// <summary>
    /// Use Aggregate with some custom methods to gather the data in one pass 
    /// </summary>
    public List<ProductStats> AggregateMoreEfficientMethod()
    {
      List<ProductStats> list = null;
      // Load all Sales Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax Here
      

      return list;
    }
    #endregion
  }
}

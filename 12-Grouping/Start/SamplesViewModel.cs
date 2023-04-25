namespace LINQSamples
{
  public class SamplesViewModel : ViewModelBase
  {
    #region GroupByQuery
    /// <summary>
    /// Group products by Size property. orderby is optional, but generally used
    /// </summary>
    public List<IGrouping<string, Product>> GroupByQuery()
    {
      List<IGrouping<string, Product>> list = null;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Query Syntax Here

      return list;
    }
    #endregion

    #region GroupByMethod
    /// <summary>
    /// Group products by Size property. orderby is optional, but generally used
    /// </summary>
    public List<IGrouping<string, Product>> GroupByMethod()
    {
      List<IGrouping<string, Product>> list = null;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax Here
      list = products.OrderBy(p=>p.Size).GroupBy(s=>s.Size).ToList();
      return list;
    }
    #endregion

    #region GroupByIntoQuery
    /// <summary>
    /// Group products by Size property. 'into' is optional.
    /// </summary>
    public List<IGrouping<string, Product>> GroupByIntoQuery()
    {
      List<IGrouping<string, Product>> list = null;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Query Syntax Here
      

      return list;
    }
    #endregion

    #region GroupByUsingKeyQuery
    /// <summary>
    /// After selecting 'into' new variable, can sort on the 'Key' property. Key property has the value of what you grouped on.
    /// </summary>
    public List<IGrouping<string, Product>> GroupByUsingKeyQuery()
    {
      List<IGrouping<string, Product>> list = null;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Query Syntax Here
      

      return list;
    }
    #endregion

    #region GroupByUsingKeyMethod
    /// <summary>
    /// After selecting 'into' new variable, can sort on the 'Key' property. Key property has the value of what you grouped on.
    /// </summary>
    public List<IGrouping<string, Product>> GroupByUsingKeyMethod()
    {
      List<IGrouping<string, Product>> list = null;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax Here
     

      return list;
    }
    #endregion

    #region GroupByWhereQuery
    /// <summary>
    /// Group products by Size property and where the group has more than 2 members
    /// This simulates a HAVING clause in SQL
    /// </summary>
    public List<IGrouping<string, Product>> GroupByWhereQuery()
    {
      List<IGrouping<string, Product>> list = null;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Query Syntax Here
      

      return list;
    }
    #endregion

    #region GroupByWhereMethod
    /// <summary>
    /// Group products by Size property and where the group has more than 2 members
    /// This simulates a HAVING clause in SQL
    /// </summary>
    public List<IGrouping<string, Product>> GroupByWhereMethod()
    {
      List<IGrouping<string, Product>> list = null;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax Here
      // first arrange data with group by size
      // then select the group in which group has more than 3 element
      // Group by where method
      // it simulate the having clause in sql
      // where clause after the groupby is having clause
      list = (from prod in products orderby prod.Size 
              group prod by prod.Size into sizes
              where sizes.Count()>2
              select sizes
      ).ToList();

      // explanation
      // select every product and then group by diffeent size and put into the variable sizes
      // then search for each group whose Count()>2 then choose the sizes
      // its like having just doing it with where

      

      return list;
    }
    #endregion

    #region GroupBySubQueryQuery
    /// <summary>
    /// Group Sales by SalesOrderID, add Products into new Sales Order object using a subquery
    /// </summary>
    public List<SaleProducts> GroupBySubQueryQuery()
    {
      List<SaleProducts> list = null;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();
      // Load all Sales Data
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Query Syntax Here
      

      return list;
    }
    #endregion

    #region GroupBySubQueryMethod
    /// <summary>
    /// Group Sales by SalesOrderID, add Products into new Sales Order object using a subquery
    /// </summary>
    public List<SaleProducts> GroupBySubQueryMethod()
    {
      List<SaleProducts> list = null;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();
      // Load all Sales Data
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Method Syntax Here
      

      return list;
    }
    #endregion

    #region GroupByDistinctQuery
    /// <summary>
    /// The Distinct() operator can be simulated using the GroupBy() and FirstOrDefault() operators
    /// In this sample you put distinct product colors into another collection using LINQ
    /// </summary>
    public List<string> GroupByDistinctQuery()
    {
      List<string> list = null;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Query Syntax Here
      
      return list;
    }
    #endregion

    #region GroupByDistinctMethod
    /// <summary>
    /// The Distinct() operator can be simulated using the GroupBy() and FirstOrDefault() operators
    /// In this sample you put distinct product colors into another collection using LINQ
    /// </summary>
    public List<string> GroupByDistinctMethod()
    {
      List<string> list =null;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();

      // Write Method Syntax Here
      

      return list;
    }
    #endregion
  }
}

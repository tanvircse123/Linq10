namespace LINQSamples
{
  public class SamplesViewModel : ViewModelBase
  {
    #region InnerJoinQuery
    /// <summary>
    /// Join a Sales Order collection with Products into anonymous class
    /// NOTE: This is an equijoin or an inner join
    /// </summary>
    public List<ProductOrder> InnerJoinQuery()
    {
      List<ProductOrder> list = null;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();
      // Load all Sales Order Data
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Query Syntax Here
      // this is the inner join
      // only the common will be there
      list = (from p in products join s in sales on p.ProductID equals s.ProductID
              select new ProductOrder{
                ProductID = p.ProductID,
                Name = p.Name,
                SalesOrderID = s.SalesOrderID,
                OrderQty = s.OrderQty
              }
      ).ToList();


      return list;
    }
    #endregion

    #region InnerJoinMethod
    /// <summary>
    /// Join a Sales Order collection with Products into anonymous class
    /// NOTE: This is an equijoin or an inner join
    /// </summary>
    public List<ProductOrder> InnerJoinMethod()
    {
      List<ProductOrder> list = null;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();
      // Load all Sales Order Data
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Method Syntax Here


      return list;
    }
    #endregion

    #region InnerJoinTwoFieldsQuery
    /// <summary>
    /// Join a Sales Order collection with Products collection using two fields
    /// </summary>
    public List<ProductOrder> InnerJoinTwoFieldsQuery()
    {
      List<ProductOrder> list = null;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();
      // Load all Sales Order Data
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Query Syntax Here


      return list;
    }
    #endregion

    #region InnerJoinTwoFieldsMethod
    /// <summary>
    /// Join a Sales Order collection with Products collection using two fields
    /// </summary>
    public List<ProductOrder> InnerJoinTwoFieldsMethod()
    {
      List<ProductOrder> list = null;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();
      // Load all Sales Order Data
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Method Syntax Here


      return list;
    }
    #endregion

    #region JoinIntoQuery
    /// <summary>
    /// Use 'into' to create a new object with a Sales collection for each Product
    /// This is like a combination of an inner join and left outer join
    /// The 'into' keyword allows you to put the sales into a 'sales' variable 
    /// that can be used to retrieve all sales for a specific product
    /// </summary>
    /// very very important
    public List<ProductSales> JoinIntoQuery()
    {
      List<ProductSales> list = null;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();
      // Load all Sales Order Data
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // join query

      // Write Query Syntax Here
      // list = (from prod in products join sale in sales
      //         on prod.ProductID equals sale.ProductID
      //         into corresponding_sale 
      //         select new ProductSales{
      //           Product = prod,
      //           Sales = corresponding_sale.ToList()
      //         } 
      // ).ToList();


      // sub query
      list = (from prod in products select new ProductSales{
              Product = prod,
              Sales = (from sale in sales where sale.ProductID == prod.ProductID select sale).ToList()
      }).ToList();

      return list;
    }
    #endregion

    #region JoinIntoMethod
    /// <summary>
    /// Use GroupJoin() to create a new object with a Sales collection for each Product
    /// This is like a combination of an inner join and left outer join
    /// The GroupJoin() method replaces the into keyword
    /// </summary>
    public List<ProductSales> JoinIntoMethod()
    {
      List<ProductSales> list = null;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();
      // Load all Sales Order Data
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Method Syntax Here


      return list;
    }
    #endregion

    #region LeftOuterJoinQuery
    /// <summary>
    /// Perform a left join between Products and Sales using DefaultIfEmpty() and SelectMany()
    /// </summary>
    public List<ProductOrder> LeftOuterJoinQuery()
    {
      List<ProductOrder> list = null;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();
      // Load all Sales Order Data
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Query Syntax Here
      // left join
      // DefaultIfEmpty() means put null if empty

      list = (from prod in products 
              join sale in sales
              on 
              prod.ProductID equals sale.ProductID
              into newsales
              from sale in newsales.DefaultIfEmpty()
              select new ProductOrder
              {
                ProductID = prod.ProductID,
                Name = prod.Name,
                Color = prod.Color,
                Size = prod.Size,
                SalesOrderID = sale?.SalesOrderID,
                StandardCost = prod.StandardCost,
                ListPrice = prod.ListPrice,
                OrderQty = sale?.OrderQty,
                UnitPrice = sale?.UnitPrice,
                LineTotal = sale?.LineTotal
              }
      ).OrderBy(p=>p.Name).ToList();


      return list;
    }
    #endregion

    #region LeftOuterJoinMethod
    /// <summary>
    /// Perform a left join between Products and Sales using DefaultIfEmpty() and SelectMany()
    /// </summary>
    public List<ProductOrder> LeftOuterJoinMethod()
    {
      List<ProductOrder> list = null;
      // Load all Product Data
      List<Product> products = ProductRepository.GetAll();
      // Load all Sales Order Data
      List<SalesOrder> sales = SalesOrderRepository.GetAll();

      // Write Method Syntax Here


      return list;
    }
    #endregion
  }
}

using System.Data;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using ORM_Dapper;


var config = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

    string connString = config.GetConnectionString("DefaultConnection");

    IDbConnection conn = new MySqlConnection(connString);

    //var departmentRepo = new DapperDepartmentRepository(conn);

    //var departments = departmentRepo.GetAllDepartments();

    //foreach (var d in departments)
    {
        //Console.WriteLine(d.DepartmentID);
        //Console.WriteLine(d.Name);
    }

      var productsRepo = new DapperProductRepository(conn);
      
      var products = productsRepo.GetAllProducts();

      foreach (var p in products)
      {
          Console.WriteLine(p.ProductID);
          Console.WriteLine(p.Name);
          Console.WriteLine(p.Price);
          Console.WriteLine(p.CategoryID);
          Console.WriteLine(p.OnSale);
          Console.WriteLine(p.StockLevel);
      }


using System;
using System.Collections.Generic;
using System.Linq;
using FashionWebsite.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FashionWebsite.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SalesController : ControllerBase
    {

        private readonly ILogger<SalesController> _logger;

        public SalesController(ILogger<SalesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("getSalesGraph")]
        public SalesGraphModel GetSalesGraphDataModel()
        {
            var sales = GetSales();

            return BuildMockSalesGraphModel(sales);
        }

        private IEnumerable<Order> GetSales()
        {
            var sales = new List<Order>();

            var sale1 = new Order
            {
                Id = 1,
                OrderItems = new List<OrderItem>
                {
                    new OrderItem
                    {
                        ProductId = 1,
                        Product = new Product
                        {
                            ProductId = 1,
                            ProductName = "Baby Shoes 1",
                            Description = "Description of baby shoes 1",
                            UnitPrice = 34.89m,
                            ImageUrl = "assets/jordan-1-baby-crib-bootie-0ZXFgC-removebg-preview.png",
                            AvailableInventory = 12
                        },
                        Quantity = 3,
                        OrderId = 1
                    },
                    new OrderItem
                    {
                        ProductId = 2,
                        Product = new Product
                        {
                            ProductId = 2,
                            ProductName = "Baby Shoes 2",
                            Description = "Description of baby shoes 2",
                            UnitPrice = 34.89m,
                            ImageUrl = "assets/white_sneakers-removebg-preview.png",
                            AvailableInventory = 12
                        },
                        Quantity = 2,
                        OrderId = 1
                    }
                },
                TotalAmount = 43.99m,
                Customer = new Customer
                {
                    Id = 1,
                    FirstName = "Ryan",
                    LastName = "Parsons",
                    ContactInfo = new ContactInfo
                    {
                        Id = 1,
                        BillingAddress = new Address
                        {
                            Id = 1,
                            StreetAddress = "123 S Mississippi Street",
                            City = "Denver",
                            State = "CO",
                            Zipcode = 80124
                        },
                        ShippingAddress = new Address
                        {
                            Id = 2,
                            StreetAddress = "13 Home Address",
                            City = "Parker",
                            State = "CO",
                            Zipcode = 80134
                        },
                        PhoneNumber = new PhoneNumber
                        {
                            Id = 1,
                            CountryCode = 1,
                            AreaCode = 208,
                            Prefix = 596,
                            LineNumber = 8054
                        }
                    },
                    PaymentInfo = new PaymentInfo
                    {
                    }
                },
                OrderDate = new DateTime(2020,10,14)
            };
            sales.Add(sale1);

            var sale2 = new Order
            {
                Id = 2,
                OrderItems = new List<OrderItem>
                {
                    new OrderItem
                    {
                        ProductId = 1,
                        Product = new Product
                        {
                            ProductId = 1,
                            ProductName = "Baby Shoes 1",
                            Description = "Description of baby shoes 1",
                            UnitPrice = 34.89m,
                            ImageUrl = "assets/jordan-1-baby-crib-bootie-0ZXFgC-removebg-preview.png",
                            AvailableInventory = 12
                        },
                        Quantity = 5
                    },
                    new OrderItem
                    {
                        ProductId = 2,
                        Product = new Product
                        {
                            ProductId = 2,
                            ProductName = "Baby Shoes 2",
                            Description = "Description of baby shoes 2",
                            UnitPrice = 34.89m,
                            ImageUrl = "assets/white_sneakers-removebg-preview.png",
                            AvailableInventory = 12
                        },
                        Quantity = 1
                    }
                },
                TotalAmount = 73.89m,
                Customer = new Customer
                {
                    Id = 1,
                    FirstName = "Ryan",
                    LastName = "Parsons",
                    ContactInfo = new ContactInfo
                    {
                        Id = 1,
                        BillingAddress = new Address
                        {
                            Id = 1,
                            StreetAddress = "123 S Mississippi Street",
                            City = "Denver",
                            State = "CO",
                            Zipcode = 80124
                        },
                        ShippingAddress = new Address
                        {
                            Id = 2,
                            StreetAddress = "13 Home Address",
                            City = "Parker",
                            State = "CO",
                            Zipcode = 80134
                        },
                        PhoneNumber = new PhoneNumber
                        {
                            Id = 1,
                            CountryCode = 1,
                            AreaCode = 208,
                            Prefix = 596,
                            LineNumber = 8054
                        }
                    },
                    PaymentInfo = new PaymentInfo
                    {
                    }
                },
                OrderDate = new DateTime(2020,10,28)
            };
            sales.Add(sale2);

            var sale3 = new Order
            {
                Id = 3,
                OrderItems = new List<OrderItem>
                {
                    new OrderItem
                    {
                        ProductId = 1,
                        Product = new Product
                        {
                            ProductId = 1,
                            ProductName = "Baby Shoes 1",
                            Description = "Description of baby shoes 1",
                            UnitPrice = 34.89m,
                            ImageUrl = "assets/jordan-1-baby-crib-bootie-0ZXFgC-removebg-preview.png",
                            AvailableInventory = 12
                        },
                        Quantity = 5
                    },
                    new OrderItem
                    {
                        ProductId = 2,
                        Product = new Product
                        {
                            ProductId = 2,
                            ProductName = "Baby Shoes 2",
                            Description = "Description of baby shoes 2",
                            UnitPrice = 34.89m,
                            ImageUrl = "assets/white_sneakers-removebg-preview.png",
                            AvailableInventory = 12
                        },
                        Quantity = 7
                    },
                    new OrderItem
                    {
                        ProductId = 3,
                        Product = new Product
                        {
                            ProductId = 3,
                            ProductName = "Baby Shoes 3",
                            Description = "Description of baby shoes 3",
                            UnitPrice = 34.89m,
                            ImageUrl = "assets/white_sneakers-removebg-preview.png",
                            AvailableInventory = 12
                        },
                        Quantity = 4
                    }
                },
                TotalAmount = 113.45m,
                Customer = new Customer
                {
                    Id = 2,
                    FirstName = "Tyler",
                    LastName = "Durden",
                    ContactInfo = new ContactInfo
                    {
                        Id = 1,
                        BillingAddress = new Address
                        {
                            Id = 1,
                            StreetAddress = "123 S Mississippi Street",
                            City = "Denver",
                            State = "CO",
                            Zipcode = 80124
                        },
                        ShippingAddress = new Address
                        {
                            Id = 2,
                            StreetAddress = "13 Home Address",
                            City = "Parker",
                            State = "CO",
                            Zipcode = 80134
                        },
                        PhoneNumber = new PhoneNumber
                        {
                            Id = 1,
                            CountryCode = 1,
                            AreaCode = 208,
                            Prefix = 596,
                            LineNumber = 8054
                        }
                    },
                    PaymentInfo = new PaymentInfo
                    {
                    }
                },
                OrderDate = new DateTime(2020,10,2)
            };
            sales.Add(sale3);


            return sales;
        }

        private SalesGraphModel BuildMockSalesGraphModel(IEnumerable<Order> orders, int width = 900, int height = 350)
        {
            var model = new SalesGraphModel();
            string[] productNames = {"Baby Shoes 1", "Baby Shoes 2", "Baby Shoes 3"};
            var qtr1Sales = new Dictionary<string, decimal>();
            var qtr2Sales = new Dictionary<string, decimal>();
            var qtr3Sales = new Dictionary<string, decimal>();
            var qtr4Sales = new Dictionary<string, decimal>();
            var qtr1Revenue = 0m;
            var qtr2Revenue = 0m;
            var qtr3Revenue = 0m;
            var qtr4Revenue = 0m;
            var columnNames = new List<string>{"Quarter"};

            //TODO: Update to get products from db
            foreach (var productName in productNames)
            {
                qtr1Sales[productName] = 0;
                qtr2Sales[productName] = 0;
                qtr3Sales[productName] = 0;
                qtr4Sales[productName] = 0;
            }

            // Calculate products sold by quarter and product
            var enumerable = orders.ToList();
            foreach (var order in enumerable)
            {
                switch (order.OrderDate.Month)
                {
                    case 1:
                    case 2:
                    case 3:
                        foreach (var item in order.OrderItems)
                        {
                            if (qtr1Sales.ContainsKey(item.Product.ProductName))
                            {
                                qtr1Sales[item.Product.ProductName] += item.Quantity * item.Product.UnitPrice;
                            }
                            else
                            {
                                qtr1Sales.Add(item.Product.ProductName, item.Quantity * item.Product.UnitPrice);
                            }

                            // Update 1st Qtr Revenue
                          //  qtr1Revenue += item.Quantity * item.Product.UnitPrice;

                            // Adds product name to columnNames if not yet included
                            if (!columnNames.Contains(item.Product.ProductName))
                            {
                                columnNames.Add(item.Product.ProductName);
                            }
                        }
                        break;
                    case 4:
                    case 5:
                    case 6:
                        foreach (var item in order.OrderItems)
                        {
                            if (qtr2Sales.ContainsKey(item.Product.ProductName))
                            {
                                qtr2Sales[item.Product.ProductName] += item.Quantity * item.Product.UnitPrice;
                            }
                            else
                            {
                                qtr2Sales.Add(item.Product.ProductName, item.Quantity * item.Product.UnitPrice);
                            }

                            // Update 2nd Qtr Revenue
                            qtr2Revenue += item.Quantity * item.Product.UnitPrice;

                            // Adds product name to columnNames if not yet included
                            if (!columnNames.Contains(item.Product.ProductName))
                            {
                                columnNames.Add(item.Product.ProductName);
                            }
                        }
                        break;
                    case 7:
                    case 8:
                    case 9:
                        foreach (var item in order.OrderItems)
                        {
                            if (qtr3Sales.ContainsKey(item.Product.ProductName))
                            {
                                qtr3Sales[item.Product.ProductName] += item.Quantity * item.Product.UnitPrice;
                            }
                            else
                            {
                                qtr3Sales.Add(item.Product.ProductName, item.Quantity * item.Product.UnitPrice);
                            }

                            // Update 3rd Qtr Revenue
                            qtr3Revenue += item.Quantity * item.Product.UnitPrice;

                            // Adds product name to columnNames if not yet included
                            if (!columnNames.Contains(item.Product.ProductName))
                            {
                                columnNames.Add(item.Product.ProductName);
                            }
                        }
                        break;
                    case 10:
                    case 11:
                    case 12:
                        foreach (var item in order.OrderItems)
                        {
                            if (qtr4Sales.ContainsKey(item.Product.ProductName))
                            {
                                qtr4Sales[item.Product.ProductName] += item.Quantity * item.Product.UnitPrice;
                            }
                            else
                            {
                                qtr4Sales.Add(item.Product.ProductName, item.Quantity * item.Product.UnitPrice);
                            }

                            // Update 4th Qtr Revenue
                            qtr4Revenue += item.Quantity * item.Product.UnitPrice;

                            // Adds product name to columnNames if not yet included
                            if (!columnNames.Contains(item.Product.ProductName))
                            {
                                columnNames.Add(item.Product.ProductName);
                            }
                        }
                        break;
                }
            }

            var salesByQuarter = getSalesByQuarter(columnNames, enumerable);

            var data = new Dictionary<string, List<decimal>>();
            var productSalesQ1 = new List<decimal>();
            foreach (var sales in qtr1Sales.Values)
            {
                productSalesQ1.Add(sales);
            }
            data.Add("1st Quarter", productSalesQ1);

            var productSalesQ2 = new List<decimal>();
            foreach (var sales in qtr2Sales.Values)
            {
                productSalesQ2.Add(sales);
            }
            data.Add("2nd Quarter", productSalesQ2);

            var productSalesQ3 = new List<decimal>();
            foreach (var sales in qtr3Sales.Values)
            {
                productSalesQ3.Add(sales);
            }
            data.Add("3rd Quarter", productSalesQ3);

            var productSalesQ4 = new List<decimal>();
            foreach (var sales in qtr4Sales.Values)
            {
                productSalesQ4.Add(sales);
            }
            data.Add("4th Quarter", productSalesQ4);

            model.Title = "Quarterly Sales";
            model.Type = "ColumnChart";
            model.Data = data; 
            model.ColumnNames = columnNames;
            model.Width = width;
            model.Height = height;


            return model;
        }

        private List<SalesByQuarter> getSalesByQuarter(IList<string> columnNames, IList<Order> orders)
        {
            var salesByQuarter = new List<SalesByQuarter>();


            for (var i = 1; i < 5; i++)
            {

                var salesData = new List<SaleData>();

                foreach (var columnName in columnNames)
                {
                    var productSales = new SaleData();
                    productSales.ProductName = columnName;
                    productSales.QuantitySold = 2;
                    salesData.Add(productSales);
                }

                var quarterSales = new SalesByQuarter();
                quarterSales.Quarter = $"Qtr {i}";
                quarterSales.Sales = salesData;

                if(orders.Any())
                    quarterSales.Revenue = i switch
                    {
                        1 => orders.Where(order =>
                                order.OrderDate.Month == 1 || order.OrderDate.Month == 2 || order.OrderDate.Month == 3)
                            .Sum(order => order.TotalAmount),
                        2 => orders.Where(order =>
                                order.OrderDate.Month == 4 || order.OrderDate.Month == 5 || order.OrderDate.Month == 6)
                            .Sum(order => order.TotalAmount),
                        3 => orders.Where(order =>
                                order.OrderDate.Month == 7 || order.OrderDate.Month == 8 || order.OrderDate.Month == 9)
                            .Sum(order => order.TotalAmount),
                        4 => orders.Where(order =>
                                order.OrderDate.Month == 10 || order.OrderDate.Month == 11 || order.OrderDate.Month == 12)
                            .Sum(order => order.TotalAmount),
                        _ => quarterSales.Revenue
                    };
                salesByQuarter.Add(quarterSales);
            }


            return salesByQuarter;
        }
    }
    }

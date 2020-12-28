using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotChocolate;
using Microsoft.AspNetCore.Cors;

namespace GraphQL.GraphQL
{
    [EnableCors("AllowAllOrigins")]
    public class Query
    {

        [EnableCors("AllowAllOrigins")]
        public IQueryable<AlphabeticalListOfProduct> GetAlphabeticalListOfProducts([Service] NorthwindContext context) => context.AlphabeticalListOfProducts;
        [EnableCors("AllowAllOrigins")]
        public IQueryable<Category> GetCategories([Service] NorthwindContext context) => context.Categories;
        [EnableCors("AllowAllOrigins")]
        public IQueryable<CategorySalesFor1997> GetCategorySalesFor1997s([Service] NorthwindContext context) => context.CategorySalesFor1997s;
        [EnableCors("AllowAllOrigins")]
        public IQueryable<CurrentProductList> GetCurrentProductLists([Service] NorthwindContext context) => context.CurrentProductLists;
        [EnableCors("AllowAllOrigins")]
        public IQueryable<Customer> GetCustomers([Service] NorthwindContext context) => context.Customers;
        [EnableCors("AllowAllOrigins")]
        public IQueryable<CustomerAndSuppliersByCity> GetCustomerAndSuppliersByCities([Service] NorthwindContext context) => context.CustomerAndSuppliersByCities;
        [EnableCors("AllowAllOrigins")]
        public IQueryable<CustomerCustomerDemo> GetCustomerCustomerDemos([Service] NorthwindContext context) => context.CustomerCustomerDemos;
        [EnableCors("AllowAllOrigins")]
        public IQueryable<CustomerDemographic> GetCustomerDemographics([Service] NorthwindContext context) => context.CustomerDemographics;
        [EnableCors("AllowAllOrigins")]
        public IQueryable<Employee> GetEmployees([Service] NorthwindContext context) => context.Employees;
        [EnableCors("AllowAllOrigins")]
        public IQueryable<EmployeeTerritory> GetEmployeeTerritories([Service] NorthwindContext context) => context.EmployeeTerritories;
        [EnableCors("AllowAllOrigins")]
        public IQueryable<Invoice> GetInvoices([Service] NorthwindContext context) => context.Invoices;
        [EnableCors("AllowAllOrigins")]
        public IQueryable<Order> GetOrders([Service] NorthwindContext context) => context.Orders;
        [EnableCors("AllowAllOrigins")]
        public IQueryable<OrderDetail> GetOrderDetails([Service] NorthwindContext context) => context.OrderDetails;
        [EnableCors("AllowAllOrigins")]
        public IQueryable<OrderDetailsExtended> GetOrderDetailsExtendeds([Service] NorthwindContext context) => context.OrderDetailsExtendeds;
        [EnableCors("AllowAllOrigins")]
        public IQueryable<OrderSubtotal> GetOrderSubtotals([Service] NorthwindContext context) => context.OrderSubtotals;
        [EnableCors("AllowAllOrigins")]
        public IQueryable<OrdersQry> GetOrdersQries([Service] NorthwindContext context) => context.OrdersQries;
        [EnableCors("AllowAllOrigins")]
        public IQueryable<Product> GetProducts([Service] NorthwindContext context) => context.Products;
        [EnableCors("AllowAllOrigins")]
        public IQueryable<ProductSalesFor1997> GetProductSalesFor1997s([Service] NorthwindContext context) => context.ProductSalesFor1997s;
        [EnableCors("AllowAllOrigins")]
        public IQueryable<ProductsAboveAveragePrice> GetProductsAboveAveragePrices([Service] NorthwindContext context) => context.ProductsAboveAveragePrices;
        [EnableCors("AllowAllOrigins")]
        public IQueryable<ProductsByCategory> GetProductsByCategories([Service] NorthwindContext context) => context.ProductsByCategories;
        [EnableCors("AllowAllOrigins")]
        public IQueryable<QuarterlyOrder> GetQuarterlyOrders([Service] NorthwindContext context) => context.QuarterlyOrders;
        [EnableCors("AllowAllOrigins")]
        public IQueryable<Region> GetRegions([Service] NorthwindContext context) => context.Regions;
        [EnableCors("AllowAllOrigins")]
        public IQueryable<SalesByCategory> GetSalesByCategories([Service] NorthwindContext context) => context.SalesByCategories;
        [EnableCors("AllowAllOrigins")]
        public IQueryable<SalesTotalsByAmount> GetSalesTotalsByAmounts([Service] NorthwindContext context) => context.SalesTotalsByAmounts;
        [EnableCors("AllowAllOrigins")]
        public IQueryable<Shipper> GetShippers([Service] NorthwindContext context) => context.Shippers;
        [EnableCors("AllowAllOrigins")]
        public IQueryable<SummaryOfSalesByQuarter> GetSummaryOfSalesByQuarters([Service] NorthwindContext context) => context.SummaryOfSalesByQuarters;
        [EnableCors("AllowAllOrigins")]
        public IQueryable<SummaryOfSalesByYear> GetSummaryOfSalesByYears([Service] NorthwindContext context) => context.SummaryOfSalesByYears;
        [EnableCors("AllowAllOrigins")]
        public IQueryable<Supplier> GetSuppliers([Service] NorthwindContext context) => context.Suppliers;
        [EnableCors("AllowAllOrigins")]
        public IQueryable<Territory> GetTerritories([Service] NorthwindContext context) => context.Territories;
    }
}

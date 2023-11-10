// See https://aka.ms/new-console-template for more information
using Business.Concretes;
using Entities.Concretes;
using System.Net.Http.Headers;

Product product1 = new Product();
product1.Name = "Masa";
product1.Id = 1;
product1.UnitPrice = 500;

ProductManager productManager = new ProductManager();
productManager.Add(product1);
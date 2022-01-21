﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
	public class InMemoryProductDal : IProductDal
	{
		List<Product> _products;
		public InMemoryProductDal()
		{
			_products = new List<Product> {
				new Product{ProductId=1,CategoryId=1,ProductName="Canon20 Max", UnitPrice=1999,UnitsInStock=10 },
				new Product{ProductId=2,CategoryId=2,ProductName="LG HD12 TV", UnitPrice=2499,UnitsInStock=10 },
				new Product{ProductId=3,CategoryId=3,ProductName="Monster Laptop", UnitPrice=5999,UnitsInStock=10 },
				new Product{ProductId=4,CategoryId=4,ProductName="Iphone 11", UnitPrice=8999,UnitsInStock=10 },
				new Product{ProductId=5,CategoryId=5,ProductName="JBL Kulaklık", UnitPrice=299,UnitsInStock=10 }
			
			};
		}
		public void Add(Product product)
		{
			_products.Add(product);
		}

		public void Delete(Product product)
		{
			Product productToDelete=_products.SingleOrDefault(x=>x.ProductId==product.ProductId);
			_products.Remove(productToDelete);
		}

		public List<Product> GetAll()
		{
			return _products;
		}

		public List<Product> GetAllByCategory(int categoryId)
		{
			return _products.Where(x => x.CategoryId == categoryId).ToList();
			
		}

		public void Update(Product product)
		{
			Product productToUpdate = _products.SingleOrDefault(x => x.ProductId == product.ProductId);
			productToUpdate.ProductName = product.ProductName;
			productToUpdate.CategoryId = product.CategoryId;
			productToUpdate.UnitPrice = product.UnitPrice;
			productToUpdate.UnitsInStock = productToUpdate.UnitsInStock;
		}
	}
}

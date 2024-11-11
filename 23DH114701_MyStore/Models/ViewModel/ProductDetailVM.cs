using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _23DH114701_MyStore.Models;
using PagedList.Mvc;

namespace _23DH114701_MyStore.Models.ViewModel
{
    public class ProductDetailVM
    {

        public string SearchTerm { get; set; }
        public Product product { get; set; }
        public int quantity { get; set; } = 1;

        public decimal estimate => quantity * product.ProductPrice;

        public int PageNumber { get; set; }
        public int PageSize { get; set; } = 3;

        public PagedList.IPagedList<Product> RelatedProducts { get; set; }

        public PagedList.IPagedList<Product> TopProducts { get; set; }

    }
}
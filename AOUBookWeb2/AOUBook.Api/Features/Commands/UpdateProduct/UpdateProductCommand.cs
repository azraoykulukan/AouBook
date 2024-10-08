﻿using AOUBook.Api.Models;
using MediatR;

namespace AOUBook.Api.Features.Commands.UpdateProduct
{
    public class UpdateProductCommand : IRequest<ProductResponse>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }
        public double ListPrice { get; set; }
        public double Price { get; set; }
        public double Price50 { get; set; }
        public double Price100 { get; set; }
        public int CategoryId { get; set; }
        public string ImageUrl { get; set; }
    }
}

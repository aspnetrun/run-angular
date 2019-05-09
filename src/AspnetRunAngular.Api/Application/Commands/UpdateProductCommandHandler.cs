﻿using AspnetRunAngular.Api.Requests;
using AspnetRunAngular.Application.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace AspnetRunAngular.Api.Application.Commands
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductRequest>
    {
        private readonly IProductService _productService;

        public UpdateProductCommandHandler(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<Unit> Handle(UpdateProductRequest request, CancellationToken cancellationToken)
        {
            await _productService.UpdateProduct(request.Product);

            return Unit.Value;
        }
    }
}

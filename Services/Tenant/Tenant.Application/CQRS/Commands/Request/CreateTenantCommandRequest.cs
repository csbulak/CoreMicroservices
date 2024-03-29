﻿using MediatR;
using Shared.Dtos;
using Tenant.Application.CQRS.Commands.Response;

namespace Tenant.Application.CQRS.Commands.Request;

public class CreateTenantCommandRequest : IRequest<Response<CreateTenantCommandResponse>>
{
    public string TenantCode { get; set; }
    public string TenantName { get; set; } 
}
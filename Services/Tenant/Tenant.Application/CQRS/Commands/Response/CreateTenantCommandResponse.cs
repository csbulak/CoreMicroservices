﻿namespace Tenant.Application.CQRS.Commands.Response;

public class CreateTenantCommandResponse
{
    public Guid ID { get; set; }
    public string TenantCode { get; set; }
    public string TenantName { get; set; }
}
using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/ElectronicWallet/External/Delete/{DigiCurrency}", "POST", Summary = @"Delete an external digital currency addresses related to the logged in user. ", Notes = @"")]
public class DeleteExternalElectronicAddress : IReturn<CommonResponse>
{
[ApiMember(Name = "DigiCurrency", Description = "Crypto-currency for the address (btc,ltc etc)", ParameterType = "path", DataType = "string", IsRequired = false)]
public System.String DigiCurrency {get; set; } 
[ApiMember(Name = "AddressName", Description = "External address name", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String AddressName {get; set; } 
}
}


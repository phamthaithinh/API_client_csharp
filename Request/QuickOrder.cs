using System;
using System.Collections.Generic;
using System.Web;
using ServiceStack.Common;
using ServiceStack.ServiceHost;
using ServiceStack.Common.Web;
using GatecoinServiceInterface.Response;
namespace GatecoinServiceInterface.Request{
[Route("/Orders/QuickOrder", "POST", Summary = @"Place a quick order to trade again market maker", Notes = @"")]
public class QuickOrder : IReturn<CommonResponse>
{
[ApiMember(Name = "CurrencyFrom", Description = "Request for quote from currency, Ex: USD, HKD, BTC", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String CurrencyFrom {get; set; } 
[ApiMember(Name = "CurrencyTo", Description = "Request for quote to currency, Ex: USD, HKD, BTC", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String CurrencyTo {get; set; } 
[ApiMember(Name = "Amount", Description = "Amount expressed in the currency to", ParameterType = "query", DataType = "decimal", IsRequired = true)]
public System.Decimal Amount {get; set; } 
[ApiMember(Name = "Price", Description = "The price from quote", ParameterType = "query", DataType = "decimal", IsRequired = true)]
public System.Decimal Price {get; set; } 
[ApiMember(Name = "QuoteID", Description = "The quote id from quote", ParameterType = "query", DataType = "string", IsRequired = true)]
public System.String QuoteID {get; set; } 
}
}


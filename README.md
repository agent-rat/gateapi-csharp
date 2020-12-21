# Io.Gate.GateApi - the C# library for the Gate API v4

APIv4 provides spot, margin and futures trading operations. There are public APIs to retrieve the real-time market statistics, and private APIs which needs authentication to trade on user's behalf.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 4.18.0
- SDK version: 4.18.0
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen
    For more information, please visit [https://www.gate.io/page/contacts](https://www.gate.io/page/contacts)

<a name="frameworks-supported"></a>
## Frameworks supported
- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>
## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.10.1 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.1 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.5.2 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 4.5.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:
```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742)

<a name="installation"></a>
## Installation
Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:
```csharp
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;
```
<a name="getting-started"></a>
## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Io.Gate.GateApi.Api;
using Io.Gate.GateApi.Client;
using Io.Gate.GateApi.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://api.gateio.ws/api/v4";
            var apiInstance = new DeliveryApi(config);
            var settle = "usdt";  // string | Settle currency

            try
            {
                // List all futures contracts
                List<DeliveryContract> result = apiInstance.ListDeliveryContracts(settle);
                Debug.WriteLine(result);
            }
            catch (GateApiException e)
            {
                Debug.Print("Exception when calling DeliveryApi.ListDeliveryContracts: " + e.Message);
                Debug.Print("Exception label: {0}, message: {1}", e.ErrorLabel, e.ErrorMessage);
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

For a more complete API usage example, refer to the demo application in [example](example) directory

<a name="documentation-for-api-endpoints"></a>
## Documentation for API Endpoints

All URIs are relative to *https://api.gateio.ws/api/v4*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*DeliveryApi* | [**ListDeliveryContracts**](docs/DeliveryApi.md#listdeliverycontracts) | **GET** /delivery/{settle}/contracts | List all futures contracts
*DeliveryApi* | [**GetDeliveryContract**](docs/DeliveryApi.md#getdeliverycontract) | **GET** /delivery/{settle}/contracts/{contract} | Get a single contract
*DeliveryApi* | [**ListDeliveryOrderBook**](docs/DeliveryApi.md#listdeliveryorderbook) | **GET** /delivery/{settle}/order_book | Futures order book
*DeliveryApi* | [**ListDeliveryTrades**](docs/DeliveryApi.md#listdeliverytrades) | **GET** /delivery/{settle}/trades | Futures trading history
*DeliveryApi* | [**ListDeliveryCandlesticks**](docs/DeliveryApi.md#listdeliverycandlesticks) | **GET** /delivery/{settle}/candlesticks | Get futures candlesticks
*DeliveryApi* | [**ListDeliveryTickers**](docs/DeliveryApi.md#listdeliverytickers) | **GET** /delivery/{settle}/tickers | List futures tickers
*DeliveryApi* | [**ListDeliveryInsuranceLedger**](docs/DeliveryApi.md#listdeliveryinsuranceledger) | **GET** /delivery/{settle}/insurance | Futures insurance balance history
*DeliveryApi* | [**ListDeliveryAccounts**](docs/DeliveryApi.md#listdeliveryaccounts) | **GET** /delivery/{settle}/accounts | Query futures account
*DeliveryApi* | [**ListDeliveryAccountBook**](docs/DeliveryApi.md#listdeliveryaccountbook) | **GET** /delivery/{settle}/account_book | Query account book
*DeliveryApi* | [**ListDeliveryPositions**](docs/DeliveryApi.md#listdeliverypositions) | **GET** /delivery/{settle}/positions | List all positions of a user
*DeliveryApi* | [**GetDeliveryPosition**](docs/DeliveryApi.md#getdeliveryposition) | **GET** /delivery/{settle}/positions/{contract} | Get single position
*DeliveryApi* | [**UpdateDeliveryPositionMargin**](docs/DeliveryApi.md#updatedeliverypositionmargin) | **POST** /delivery/{settle}/positions/{contract}/margin | Update position margin
*DeliveryApi* | [**UpdateDeliveryPositionLeverage**](docs/DeliveryApi.md#updatedeliverypositionleverage) | **POST** /delivery/{settle}/positions/{contract}/leverage | Update position leverage
*DeliveryApi* | [**UpdateDeliveryPositionRiskLimit**](docs/DeliveryApi.md#updatedeliverypositionrisklimit) | **POST** /delivery/{settle}/positions/{contract}/risk_limit | Update position risk limit
*DeliveryApi* | [**ListDeliveryOrders**](docs/DeliveryApi.md#listdeliveryorders) | **GET** /delivery/{settle}/orders | List futures orders
*DeliveryApi* | [**CreateDeliveryOrder**](docs/DeliveryApi.md#createdeliveryorder) | **POST** /delivery/{settle}/orders | Create a futures order
*DeliveryApi* | [**CancelDeliveryOrders**](docs/DeliveryApi.md#canceldeliveryorders) | **DELETE** /delivery/{settle}/orders | Cancel all `open` orders matched
*DeliveryApi* | [**GetDeliveryOrder**](docs/DeliveryApi.md#getdeliveryorder) | **GET** /delivery/{settle}/orders/{order_id} | Get a single order
*DeliveryApi* | [**CancelDeliveryOrder**](docs/DeliveryApi.md#canceldeliveryorder) | **DELETE** /delivery/{settle}/orders/{order_id} | Cancel a single order
*DeliveryApi* | [**GetMyDeliveryTrades**](docs/DeliveryApi.md#getmydeliverytrades) | **GET** /delivery/{settle}/my_trades | List personal trading history
*DeliveryApi* | [**ListDeliveryPositionClose**](docs/DeliveryApi.md#listdeliverypositionclose) | **GET** /delivery/{settle}/position_close | List position close history
*DeliveryApi* | [**ListDeliveryLiquidates**](docs/DeliveryApi.md#listdeliveryliquidates) | **GET** /delivery/{settle}/liquidates | List liquidation history
*DeliveryApi* | [**ListDeliverySettlements**](docs/DeliveryApi.md#listdeliverysettlements) | **GET** /delivery/{settle}/settlements | List settlement history
*DeliveryApi* | [**ListPriceTriggeredDeliveryOrders**](docs/DeliveryApi.md#listpricetriggereddeliveryorders) | **GET** /delivery/{settle}/price_orders | List all auto orders
*DeliveryApi* | [**CreatePriceTriggeredDeliveryOrder**](docs/DeliveryApi.md#createpricetriggereddeliveryorder) | **POST** /delivery/{settle}/price_orders | Create a price-triggered order
*DeliveryApi* | [**CancelPriceTriggeredDeliveryOrderList**](docs/DeliveryApi.md#cancelpricetriggereddeliveryorderlist) | **DELETE** /delivery/{settle}/price_orders | Cancel all open orders
*DeliveryApi* | [**GetPriceTriggeredDeliveryOrder**](docs/DeliveryApi.md#getpricetriggereddeliveryorder) | **GET** /delivery/{settle}/price_orders/{order_id} | Get a single order
*DeliveryApi* | [**CancelPriceTriggeredDeliveryOrder**](docs/DeliveryApi.md#cancelpricetriggereddeliveryorder) | **DELETE** /delivery/{settle}/price_orders/{order_id} | Cancel a single order
*FuturesApi* | [**ListFuturesContracts**](docs/FuturesApi.md#listfuturescontracts) | **GET** /futures/{settle}/contracts | List all futures contracts
*FuturesApi* | [**GetFuturesContract**](docs/FuturesApi.md#getfuturescontract) | **GET** /futures/{settle}/contracts/{contract} | Get a single contract
*FuturesApi* | [**ListFuturesOrderBook**](docs/FuturesApi.md#listfuturesorderbook) | **GET** /futures/{settle}/order_book | Futures order book
*FuturesApi* | [**ListFuturesTrades**](docs/FuturesApi.md#listfuturestrades) | **GET** /futures/{settle}/trades | Futures trading history
*FuturesApi* | [**ListFuturesCandlesticks**](docs/FuturesApi.md#listfuturescandlesticks) | **GET** /futures/{settle}/candlesticks | Get futures candlesticks
*FuturesApi* | [**ListFuturesTickers**](docs/FuturesApi.md#listfuturestickers) | **GET** /futures/{settle}/tickers | List futures tickers
*FuturesApi* | [**ListFuturesFundingRateHistory**](docs/FuturesApi.md#listfuturesfundingratehistory) | **GET** /futures/{settle}/funding_rate | Funding rate history
*FuturesApi* | [**ListFuturesInsuranceLedger**](docs/FuturesApi.md#listfuturesinsuranceledger) | **GET** /futures/{settle}/insurance | Futures insurance balance history
*FuturesApi* | [**ListContractStats**](docs/FuturesApi.md#listcontractstats) | **GET** /futures/{settle}/contract_stats | Futures stats
*FuturesApi* | [**ListLiquidatedOrders**](docs/FuturesApi.md#listliquidatedorders) | **GET** /futures/{settle}/liq_orders | Retrieve liquidation history
*FuturesApi* | [**ListFuturesAccounts**](docs/FuturesApi.md#listfuturesaccounts) | **GET** /futures/{settle}/accounts | Query futures account
*FuturesApi* | [**ListFuturesAccountBook**](docs/FuturesApi.md#listfuturesaccountbook) | **GET** /futures/{settle}/account_book | Query account book
*FuturesApi* | [**ListPositions**](docs/FuturesApi.md#listpositions) | **GET** /futures/{settle}/positions | List all positions of a user
*FuturesApi* | [**GetPosition**](docs/FuturesApi.md#getposition) | **GET** /futures/{settle}/positions/{contract} | Get single position
*FuturesApi* | [**UpdatePositionMargin**](docs/FuturesApi.md#updatepositionmargin) | **POST** /futures/{settle}/positions/{contract}/margin | Update position margin
*FuturesApi* | [**UpdatePositionLeverage**](docs/FuturesApi.md#updatepositionleverage) | **POST** /futures/{settle}/positions/{contract}/leverage | Update position leverage
*FuturesApi* | [**UpdatePositionRiskLimit**](docs/FuturesApi.md#updatepositionrisklimit) | **POST** /futures/{settle}/positions/{contract}/risk_limit | Update position risk limit
*FuturesApi* | [**SetDualMode**](docs/FuturesApi.md#setdualmode) | **POST** /futures/{settle}/dual_mode | Enable or disable dual mode
*FuturesApi* | [**GetDualModePosition**](docs/FuturesApi.md#getdualmodeposition) | **GET** /futures/{settle}/dual_comp/positions/{contract} | Retrieve position detail in dual mode
*FuturesApi* | [**UpdateDualModePositionMargin**](docs/FuturesApi.md#updatedualmodepositionmargin) | **POST** /futures/{settle}/dual_comp/positions/{contract}/margin | Update position margin in dual mode
*FuturesApi* | [**UpdateDualModePositionLeverage**](docs/FuturesApi.md#updatedualmodepositionleverage) | **POST** /futures/{settle}/dual_comp/positions/{contract}/leverage | Update position leverage in dual mode
*FuturesApi* | [**UpdateDualModePositionRiskLimit**](docs/FuturesApi.md#updatedualmodepositionrisklimit) | **POST** /futures/{settle}/dual_comp/positions/{contract}/risk_limit | Update position risk limit in dual mode
*FuturesApi* | [**ListFuturesOrders**](docs/FuturesApi.md#listfuturesorders) | **GET** /futures/{settle}/orders | List futures orders
*FuturesApi* | [**CreateFuturesOrder**](docs/FuturesApi.md#createfuturesorder) | **POST** /futures/{settle}/orders | Create a futures order
*FuturesApi* | [**CancelFuturesOrders**](docs/FuturesApi.md#cancelfuturesorders) | **DELETE** /futures/{settle}/orders | Cancel all `open` orders matched
*FuturesApi* | [**GetFuturesOrder**](docs/FuturesApi.md#getfuturesorder) | **GET** /futures/{settle}/orders/{order_id} | Get a single order
*FuturesApi* | [**CancelFuturesOrder**](docs/FuturesApi.md#cancelfuturesorder) | **DELETE** /futures/{settle}/orders/{order_id} | Cancel a single order
*FuturesApi* | [**GetMyTrades**](docs/FuturesApi.md#getmytrades) | **GET** /futures/{settle}/my_trades | List personal trading history
*FuturesApi* | [**ListPositionClose**](docs/FuturesApi.md#listpositionclose) | **GET** /futures/{settle}/position_close | List position close history
*FuturesApi* | [**ListLiquidates**](docs/FuturesApi.md#listliquidates) | **GET** /futures/{settle}/liquidates | List liquidation history
*FuturesApi* | [**ListPriceTriggeredOrders**](docs/FuturesApi.md#listpricetriggeredorders) | **GET** /futures/{settle}/price_orders | List all auto orders
*FuturesApi* | [**CreatePriceTriggeredOrder**](docs/FuturesApi.md#createpricetriggeredorder) | **POST** /futures/{settle}/price_orders | Create a price-triggered order
*FuturesApi* | [**CancelPriceTriggeredOrderList**](docs/FuturesApi.md#cancelpricetriggeredorderlist) | **DELETE** /futures/{settle}/price_orders | Cancel all open orders
*FuturesApi* | [**GetPriceTriggeredOrder**](docs/FuturesApi.md#getpricetriggeredorder) | **GET** /futures/{settle}/price_orders/{order_id} | Get a single order
*FuturesApi* | [**CancelPriceTriggeredOrder**](docs/FuturesApi.md#cancelpricetriggeredorder) | **DELETE** /futures/{settle}/price_orders/{order_id} | Cancel a single order
*MarginApi* | [**ListMarginCurrencyPairs**](docs/MarginApi.md#listmargincurrencypairs) | **GET** /margin/currency_pairs | List all supported currency pairs supported in margin trading
*MarginApi* | [**GetMarginCurrencyPair**](docs/MarginApi.md#getmargincurrencypair) | **GET** /margin/currency_pairs/{currency_pair} | Query one single margin currency pair
*MarginApi* | [**ListFundingBook**](docs/MarginApi.md#listfundingbook) | **GET** /margin/funding_book | Order book of lending loans
*MarginApi* | [**ListMarginAccounts**](docs/MarginApi.md#listmarginaccounts) | **GET** /margin/accounts | Margin account list
*MarginApi* | [**ListMarginAccountBook**](docs/MarginApi.md#listmarginaccountbook) | **GET** /margin/account_book | List margin account balance change history
*MarginApi* | [**ListFundingAccounts**](docs/MarginApi.md#listfundingaccounts) | **GET** /margin/funding_accounts | Funding account list
*MarginApi* | [**ListLoans**](docs/MarginApi.md#listloans) | **GET** /margin/loans | List all loans
*MarginApi* | [**CreateLoan**](docs/MarginApi.md#createloan) | **POST** /margin/loans | Lend or borrow
*MarginApi* | [**MergeLoans**](docs/MarginApi.md#mergeloans) | **POST** /margin/merged_loans | Merge multiple lending loans
*MarginApi* | [**GetLoan**](docs/MarginApi.md#getloan) | **GET** /margin/loans/{loan_id} | Retrieve one single loan detail
*MarginApi* | [**CancelLoan**](docs/MarginApi.md#cancelloan) | **DELETE** /margin/loans/{loan_id} | Cancel lending loan
*MarginApi* | [**UpdateLoan**](docs/MarginApi.md#updateloan) | **PATCH** /margin/loans/{loan_id} | Modify a loan
*MarginApi* | [**ListLoanRepayments**](docs/MarginApi.md#listloanrepayments) | **GET** /margin/loans/{loan_id}/repayment | List loan repayment records
*MarginApi* | [**RepayLoan**](docs/MarginApi.md#repayloan) | **POST** /margin/loans/{loan_id}/repayment | Repay a loan
*MarginApi* | [**ListLoanRecords**](docs/MarginApi.md#listloanrecords) | **GET** /margin/loan_records | List repayment records of specified loan
*MarginApi* | [**GetLoanRecord**](docs/MarginApi.md#getloanrecord) | **GET** /margin/loan_records/{loan_record_id} | Get one single loan record
*MarginApi* | [**UpdateLoanRecord**](docs/MarginApi.md#updateloanrecord) | **PATCH** /margin/loan_records/{loan_record_id} | Modify a loan record
*SpotApi* | [**ListCurrencies**](docs/SpotApi.md#listcurrencies) | **GET** /spot/currencies | List all currencies' detail
*SpotApi* | [**GetCurrency**](docs/SpotApi.md#getcurrency) | **GET** /spot/currencies/{currency} | Get detail of one particular currency
*SpotApi* | [**ListCurrencyPairs**](docs/SpotApi.md#listcurrencypairs) | **GET** /spot/currency_pairs | List all currency pairs supported
*SpotApi* | [**GetCurrencyPair**](docs/SpotApi.md#getcurrencypair) | **GET** /spot/currency_pairs/{currency_pair} | Get detail of one single order
*SpotApi* | [**ListTickers**](docs/SpotApi.md#listtickers) | **GET** /spot/tickers | Retrieve ticker information
*SpotApi* | [**ListOrderBook**](docs/SpotApi.md#listorderbook) | **GET** /spot/order_book | Retrieve order book
*SpotApi* | [**ListTrades**](docs/SpotApi.md#listtrades) | **GET** /spot/trades | Retrieve market trades
*SpotApi* | [**ListCandlesticks**](docs/SpotApi.md#listcandlesticks) | **GET** /spot/candlesticks | Market candlesticks
*SpotApi* | [**GetFee**](docs/SpotApi.md#getfee) | **GET** /spot/fee | Query user trading fee rates
*SpotApi* | [**ListSpotAccounts**](docs/SpotApi.md#listspotaccounts) | **GET** /spot/accounts | List spot accounts
*SpotApi* | [**CreateBatchOrders**](docs/SpotApi.md#createbatchorders) | **POST** /spot/batch_orders | Create a batch of orders
*SpotApi* | [**ListAllOpenOrders**](docs/SpotApi.md#listallopenorders) | **GET** /spot/open_orders | List all open orders
*SpotApi* | [**ListOrders**](docs/SpotApi.md#listorders) | **GET** /spot/orders | List orders
*SpotApi* | [**CreateOrder**](docs/SpotApi.md#createorder) | **POST** /spot/orders | Create an order
*SpotApi* | [**CancelOrders**](docs/SpotApi.md#cancelorders) | **DELETE** /spot/orders | Cancel all `open` orders in specified currency pair
*SpotApi* | [**CancelBatchOrders**](docs/SpotApi.md#cancelbatchorders) | **POST** /spot/cancel_batch_orders | Cancel a batch of orders with an ID list
*SpotApi* | [**GetOrder**](docs/SpotApi.md#getorder) | **GET** /spot/orders/{order_id} | Get a single order
*SpotApi* | [**CancelOrder**](docs/SpotApi.md#cancelorder) | **DELETE** /spot/orders/{order_id} | Cancel a single order
*SpotApi* | [**ListMyTrades**](docs/SpotApi.md#listmytrades) | **GET** /spot/my_trades | List personal trading history
*WalletApi* | [**GetDepositAddress**](docs/WalletApi.md#getdepositaddress) | **GET** /wallet/deposit_address | Generate currency deposit address
*WalletApi* | [**ListWithdrawals**](docs/WalletApi.md#listwithdrawals) | **GET** /wallet/withdrawals | Retrieve withdrawal records
*WalletApi* | [**ListDeposits**](docs/WalletApi.md#listdeposits) | **GET** /wallet/deposits | Retrieve deposit records
*WalletApi* | [**Transfer**](docs/WalletApi.md#transfer) | **POST** /wallet/transfers | Transfer between trading accounts
*WalletApi* | [**ListSubAccountTransfers**](docs/WalletApi.md#listsubaccounttransfers) | **GET** /wallet/sub_account_transfers | Transfer records between main and sub accounts
*WalletApi* | [**TransferWithSubAccount**](docs/WalletApi.md#transferwithsubaccount) | **POST** /wallet/sub_account_transfers | Transfer between main and sub accounts
*WalletApi* | [**ListWithdrawStatus**](docs/WalletApi.md#listwithdrawstatus) | **GET** /wallet/withdraw_status | Retrieve withdrawal status
*WalletApi* | [**ListSubAccountBalances**](docs/WalletApi.md#listsubaccountbalances) | **GET** /wallet/sub_account_balances | Retrieve sub account balances
*WithdrawalApi* | [**Withdraw**](docs/WithdrawalApi.md#withdraw) | **POST** /withdrawals | Withdraw


<a name="documentation-for-models"></a>
## Documentation for Models

 - [Model.BatchOrder](docs/BatchOrder.md)
 - [Model.CancelOrder](docs/CancelOrder.md)
 - [Model.CancelOrderResult](docs/CancelOrderResult.md)
 - [Model.Contract](docs/Contract.md)
 - [Model.ContractStat](docs/ContractStat.md)
 - [Model.Currency](docs/Currency.md)
 - [Model.CurrencyPair](docs/CurrencyPair.md)
 - [Model.DeliveryContract](docs/DeliveryContract.md)
 - [Model.DeliverySettlement](docs/DeliverySettlement.md)
 - [Model.DepositAddress](docs/DepositAddress.md)
 - [Model.FundingAccount](docs/FundingAccount.md)
 - [Model.FundingBookItem](docs/FundingBookItem.md)
 - [Model.FundingRateRecord](docs/FundingRateRecord.md)
 - [Model.FuturesAccount](docs/FuturesAccount.md)
 - [Model.FuturesAccountBook](docs/FuturesAccountBook.md)
 - [Model.FuturesCandlestick](docs/FuturesCandlestick.md)
 - [Model.FuturesInitialOrder](docs/FuturesInitialOrder.md)
 - [Model.FuturesLiquidate](docs/FuturesLiquidate.md)
 - [Model.FuturesOrder](docs/FuturesOrder.md)
 - [Model.FuturesOrderBook](docs/FuturesOrderBook.md)
 - [Model.FuturesOrderBookItem](docs/FuturesOrderBookItem.md)
 - [Model.FuturesPriceTrigger](docs/FuturesPriceTrigger.md)
 - [Model.FuturesPriceTriggeredOrder](docs/FuturesPriceTriggeredOrder.md)
 - [Model.FuturesTicker](docs/FuturesTicker.md)
 - [Model.FuturesTrade](docs/FuturesTrade.md)
 - [Model.InsuranceRecord](docs/InsuranceRecord.md)
 - [Model.LedgerRecord](docs/LedgerRecord.md)
 - [Model.Loan](docs/Loan.md)
 - [Model.LoanPatch](docs/LoanPatch.md)
 - [Model.LoanRecord](docs/LoanRecord.md)
 - [Model.MarginAccount](docs/MarginAccount.md)
 - [Model.MarginAccountBook](docs/MarginAccountBook.md)
 - [Model.MarginAccountCurrency](docs/MarginAccountCurrency.md)
 - [Model.MarginCurrencyPair](docs/MarginCurrencyPair.md)
 - [Model.MyFuturesTrade](docs/MyFuturesTrade.md)
 - [Model.OpenOrders](docs/OpenOrders.md)
 - [Model.Order](docs/Order.md)
 - [Model.OrderBook](docs/OrderBook.md)
 - [Model.Position](docs/Position.md)
 - [Model.PositionClose](docs/PositionClose.md)
 - [Model.PositionCloseOrder](docs/PositionCloseOrder.md)
 - [Model.RepayRequest](docs/RepayRequest.md)
 - [Model.Repayment](docs/Repayment.md)
 - [Model.SpotAccount](docs/SpotAccount.md)
 - [Model.SubAccountBalance](docs/SubAccountBalance.md)
 - [Model.SubAccountTransfer](docs/SubAccountTransfer.md)
 - [Model.Ticker](docs/Ticker.md)
 - [Model.Trade](docs/Trade.md)
 - [Model.TradeFee](docs/TradeFee.md)
 - [Model.Transfer](docs/Transfer.md)
 - [Model.TriggerOrderResponse](docs/TriggerOrderResponse.md)
 - [Model.WithdrawStatus](docs/WithdrawStatus.md)


<a name="documentation-for-authorization"></a>
## Documentation for Authorization

<a name="apiv4"></a>
### apiv4

- **Type**: Gate APIv4 authentication

For details, refer to:
[APIv4 signed request requirements](https://www.gate.io/docs/apiv4/en/index.html#apiv4-signed-request-requirements)


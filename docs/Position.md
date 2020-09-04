
# Io.Gate.GateApi.Model.Position

Futures position details

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**User** | **long** | User ID | [optional] [readonly] 
**Contract** | **string** | Futures contract | [optional] [readonly] 
**Size** | **long** | Position size | [optional] [readonly] 
**Leverage** | **string** | Position leverage. 0 means cross margin; positive number means isolated margin | [optional] 
**RiskLimit** | **string** | Position risk limit | [optional] 
**LeverageMax** | **string** | Maximum leverage under current risk limit | [optional] [readonly] 
**MaintenanceRate** | **string** | Maintenance rate under current risk limit | [optional] [readonly] 
**Value** | **string** | Position value calculated in settlement currency | [optional] [readonly] 
**Margin** | **string** | Position margin | [optional] 
**EntryPrice** | **string** | Entry price | [optional] [readonly] 
**LiqPrice** | **string** | Liquidation price | [optional] [readonly] 
**MarkPrice** | **string** | Current mark price | [optional] [readonly] 
**UnrealisedPnl** | **string** | Unrealized PNL | [optional] [readonly] 
**RealisedPnl** | **string** | Realized PNL | [optional] [readonly] 
**HistoryPnl** | **string** | History realized PNL | [optional] [readonly] 
**LastClosePnl** | **string** | PNL of last position close | [optional] [readonly] 
**RealisedPoint** | **string** | Realized POINT PNL | [optional] [readonly] 
**HistoryPoint** | **string** | History realized POINT PNL | [optional] [readonly] 
**AdlRanking** | **int** | ADL ranking, range from 1 to 5 | [optional] [readonly] 
**PendingOrders** | **int** | Current open orders | [optional] [readonly] 
**CloseOrder** | [**PositionCloseOrder**](PositionCloseOrder.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)
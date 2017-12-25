//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace CTACSharp.CTP.Trade {

public class CThostFtdcOrderField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcOrderField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcOrderField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcOrderField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcOrderField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderRef {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_OrderRef_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_OrderRef_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderPriceType {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_OrderPriceType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_OrderPriceType_get(swigCPtr);
      return ret;
    } 
  }

  public char Direction {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_Direction_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_Direction_get(swigCPtr);
      return ret;
    } 
  }

  public string CombOffsetFlag {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_CombOffsetFlag_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_CombOffsetFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string CombHedgeFlag {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_CombHedgeFlag_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_CombHedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public double LimitPrice {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_LimitPrice_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_LimitPrice_get(swigCPtr);
      return ret;
    } 
  }

  public int VolumeTotalOriginal {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_VolumeTotalOriginal_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_VolumeTotalOriginal_get(swigCPtr);
      return ret;
    } 
  }

  public char TimeCondition {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_TimeCondition_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_TimeCondition_get(swigCPtr);
      return ret;
    } 
  }

  public string GTDDate {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_GTDDate_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_GTDDate_get(swigCPtr);
      return ret;
    } 
  }

  public char VolumeCondition {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_VolumeCondition_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_VolumeCondition_get(swigCPtr);
      return ret;
    } 
  }

  public int MinVolume {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_MinVolume_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_MinVolume_get(swigCPtr);
      return ret;
    } 
  }

  public char ContingentCondition {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_ContingentCondition_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_ContingentCondition_get(swigCPtr);
      return ret;
    } 
  }

  public double StopPrice {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_StopPrice_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_StopPrice_get(swigCPtr);
      return ret;
    } 
  }

  public char ForceCloseReason {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_ForceCloseReason_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_ForceCloseReason_get(swigCPtr);
      return ret;
    } 
  }

  public int IsAutoSuspend {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_IsAutoSuspend_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_IsAutoSuspend_get(swigCPtr);
      return ret;
    } 
  }

  public string BusinessUnit {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_BusinessUnit_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_BusinessUnit_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderLocalID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_OrderLocalID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_OrderLocalID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string ParticipantID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeInstID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_ExchangeInstID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_ExchangeInstID_get(swigCPtr);
      return ret;
    } 
  }

  public string TraderID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_TraderID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_TraderID_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderSubmitStatus {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_OrderSubmitStatus_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_OrderSubmitStatus_get(swigCPtr);
      return ret;
    } 
  }

  public int NotifySequence {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_NotifySequence_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_NotifySequence_get(swigCPtr);
      return ret;
    } 
  }

  public string TradingDay {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public int SettlementID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_SettlementID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_SettlementID_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderSysID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_OrderSysID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_OrderSysID_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderSource {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_OrderSource_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_OrderSource_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderStatus {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_OrderStatus_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_OrderStatus_get(swigCPtr);
      return ret;
    } 
  }

  public char OrderType {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_OrderType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_OrderType_get(swigCPtr);
      return ret;
    } 
  }

  public int VolumeTraded {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_VolumeTraded_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_VolumeTraded_get(swigCPtr);
      return ret;
    } 
  }

  public int VolumeTotal {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_VolumeTotal_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_VolumeTotal_get(swigCPtr);
      return ret;
    } 
  }

  public string InsertDate {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_InsertDate_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_InsertDate_get(swigCPtr);
      return ret;
    } 
  }

  public string InsertTime {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_InsertTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_InsertTime_get(swigCPtr);
      return ret;
    } 
  }

  public string ActiveTime {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_ActiveTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_ActiveTime_get(swigCPtr);
      return ret;
    } 
  }

  public string SuspendTime {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_SuspendTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_SuspendTime_get(swigCPtr);
      return ret;
    } 
  }

  public string UpdateTime {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_UpdateTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_UpdateTime_get(swigCPtr);
      return ret;
    } 
  }

  public string CancelTime {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_CancelTime_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_CancelTime_get(swigCPtr);
      return ret;
    } 
  }

  public string ActiveTraderID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_ActiveTraderID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_ActiveTraderID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClearingPartID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_ClearingPartID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_ClearingPartID_get(swigCPtr);
      return ret;
    } 
  }

  public int SequenceNo {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_SequenceNo_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_SequenceNo_get(swigCPtr);
      return ret;
    } 
  }

  public int FrontID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_FrontID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_FrontID_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserProductInfo {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_UserProductInfo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_UserProductInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string StatusMsg {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_StatusMsg_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_StatusMsg_get(swigCPtr);
      return ret;
    } 
  }

  public int UserForceClose {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_UserForceClose_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_UserForceClose_get(swigCPtr);
      return ret;
    } 
  }

  public string ActiveUserID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_ActiveUserID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_ActiveUserID_get(swigCPtr);
      return ret;
    } 
  }

  public int BrokerOrderSeq {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_BrokerOrderSeq_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_BrokerOrderSeq_get(swigCPtr);
      return ret;
    } 
  }

  public string RelativeOrderSysID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_RelativeOrderSysID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_RelativeOrderSysID_get(swigCPtr);
      return ret;
    } 
  }

  public int ZCETotalTradedVolume {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_ZCETotalTradedVolume_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_ZCETotalTradedVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int IsSwapOrder {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_IsSwapOrder_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcOrderField_IsSwapOrder_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcOrderField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcOrderField(), true) {
  }

}

}

//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace CTACSharp.CTP.Market {

public class CThostFtdcInputQuoteField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcInputQuoteField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcInputQuoteField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcInputQuoteField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcInputQuoteField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public string QuoteRef {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_QuoteRef_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_QuoteRef_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public double AskPrice {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_AskPrice_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_AskPrice_get(swigCPtr);
      return ret;
    } 
  }

  public double BidPrice {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_BidPrice_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_BidPrice_get(swigCPtr);
      return ret;
    } 
  }

  public int AskVolume {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_AskVolume_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_AskVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int BidVolume {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_BidVolume_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_BidVolume_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public string BusinessUnit {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_BusinessUnit_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_BusinessUnit_get(swigCPtr);
      return ret;
    } 
  }

  public char AskOffsetFlag {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_AskOffsetFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_AskOffsetFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char BidOffsetFlag {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_BidOffsetFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_BidOffsetFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char AskHedgeFlag {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_AskHedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_AskHedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public char BidHedgeFlag {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_BidHedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_BidHedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string AskOrderRef {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_AskOrderRef_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_AskOrderRef_get(swigCPtr);
      return ret;
    } 
  }

  public string BidOrderRef {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_BidOrderRef_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_BidOrderRef_get(swigCPtr);
      return ret;
    } 
  }

  public string ForQuoteSysID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_ForQuoteSysID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputQuoteField_ForQuoteSysID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcInputQuoteField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcInputQuoteField(), true) {
  }

}

}

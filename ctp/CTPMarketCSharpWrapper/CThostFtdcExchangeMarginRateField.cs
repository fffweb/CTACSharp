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

public class CThostFtdcExchangeMarginRateField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcExchangeMarginRateField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcExchangeMarginRateField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcExchangeMarginRateField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcExchangeMarginRateField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExchangeMarginRateField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExchangeMarginRateField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExchangeMarginRateField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExchangeMarginRateField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public char HedgeFlag {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExchangeMarginRateField_HedgeFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExchangeMarginRateField_HedgeFlag_get(swigCPtr);
      return ret;
    } 
  }

  public double LongMarginRatioByMoney {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExchangeMarginRateField_LongMarginRatioByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExchangeMarginRateField_LongMarginRatioByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double LongMarginRatioByVolume {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExchangeMarginRateField_LongMarginRatioByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExchangeMarginRateField_LongMarginRatioByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public double ShortMarginRatioByMoney {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExchangeMarginRateField_ShortMarginRatioByMoney_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExchangeMarginRateField_ShortMarginRatioByMoney_get(swigCPtr);
      return ret;
    } 
  }

  public double ShortMarginRatioByVolume {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExchangeMarginRateField_ShortMarginRatioByVolume_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExchangeMarginRateField_ShortMarginRatioByVolume_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcExchangeMarginRateField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcExchangeMarginRateField(), true) {
  }

}

}

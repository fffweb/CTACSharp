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

public class CThostFtdcMarketDataAsk23Field : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcMarketDataAsk23Field(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcMarketDataAsk23Field obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcMarketDataAsk23Field() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcMarketDataAsk23Field(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public double AskPrice2 {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcMarketDataAsk23Field_AskPrice2_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcMarketDataAsk23Field_AskPrice2_get(swigCPtr);
      return ret;
    } 
  }

  public int AskVolume2 {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcMarketDataAsk23Field_AskVolume2_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcMarketDataAsk23Field_AskVolume2_get(swigCPtr);
      return ret;
    } 
  }

  public double AskPrice3 {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcMarketDataAsk23Field_AskPrice3_set(swigCPtr, value);
    } 
    get {
      double ret = CTPTradeCppWrapperPINVOKE.CThostFtdcMarketDataAsk23Field_AskPrice3_get(swigCPtr);
      return ret;
    } 
  }

  public int AskVolume3 {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcMarketDataAsk23Field_AskVolume3_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcMarketDataAsk23Field_AskVolume3_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcMarketDataAsk23Field() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcMarketDataAsk23Field(), true) {
  }

}

}

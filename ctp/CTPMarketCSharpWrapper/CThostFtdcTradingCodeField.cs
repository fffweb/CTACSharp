//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcTradingCodeField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcTradingCodeField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcTradingCodeField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcTradingCodeField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcTradingCodeField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string InvestorID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcTradingCodeField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcTradingCodeField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcTradingCodeField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcTradingCodeField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcTradingCodeField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcTradingCodeField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcTradingCodeField_ClientID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcTradingCodeField_ClientID_get(swigCPtr);
      return ret;
    } 
  }

  public int IsActive {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcTradingCodeField_IsActive_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcTradingCodeField_IsActive_get(swigCPtr);
      return ret;
    } 
  }

  public char ClientIDType {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcTradingCodeField_ClientIDType_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcTradingCodeField_ClientIDType_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcTradingCodeField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcTradingCodeField(), true) {
  }

}
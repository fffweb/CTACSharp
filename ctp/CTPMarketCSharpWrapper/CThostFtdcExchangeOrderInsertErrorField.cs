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

public class CThostFtdcExchangeOrderInsertErrorField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcExchangeOrderInsertErrorField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcExchangeOrderInsertErrorField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcExchangeOrderInsertErrorField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcExchangeOrderInsertErrorField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string ExchangeID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExchangeOrderInsertErrorField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExchangeOrderInsertErrorField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string ParticipantID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExchangeOrderInsertErrorField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExchangeOrderInsertErrorField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public string TraderID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExchangeOrderInsertErrorField_TraderID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExchangeOrderInsertErrorField_TraderID_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExchangeOrderInsertErrorField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExchangeOrderInsertErrorField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderLocalID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExchangeOrderInsertErrorField_OrderLocalID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExchangeOrderInsertErrorField_OrderLocalID_get(swigCPtr);
      return ret;
    } 
  }

  public int ErrorID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExchangeOrderInsertErrorField_ErrorID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExchangeOrderInsertErrorField_ErrorID_get(swigCPtr);
      return ret;
    } 
  }

  public string ErrorMsg {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcExchangeOrderInsertErrorField_ErrorMsg_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcExchangeOrderInsertErrorField_ErrorMsg_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcExchangeOrderInsertErrorField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcExchangeOrderInsertErrorField(), true) {
  }

}

}

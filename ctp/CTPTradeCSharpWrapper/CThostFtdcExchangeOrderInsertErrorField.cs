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
          CTPTradeCppWrapperPINVOKE.delete_CThostFtdcExchangeOrderInsertErrorField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string ExchangeID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeOrderInsertErrorField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeOrderInsertErrorField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string ParticipantID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeOrderInsertErrorField_ParticipantID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeOrderInsertErrorField_ParticipantID_get(swigCPtr);
      return ret;
    } 
  }

  public string TraderID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeOrderInsertErrorField_TraderID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeOrderInsertErrorField_TraderID_get(swigCPtr);
      return ret;
    } 
  }

  public int InstallID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeOrderInsertErrorField_InstallID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeOrderInsertErrorField_InstallID_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderLocalID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeOrderInsertErrorField_OrderLocalID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeOrderInsertErrorField_OrderLocalID_get(swigCPtr);
      return ret;
    } 
  }

  public int ErrorID {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeOrderInsertErrorField_ErrorID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeOrderInsertErrorField_ErrorID_get(swigCPtr);
      return ret;
    } 
  }

  public string ErrorMsg {
    set {
      CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeOrderInsertErrorField_ErrorMsg_set(swigCPtr, value);
    } 
    get {
      string ret = CTPTradeCppWrapperPINVOKE.CThostFtdcExchangeOrderInsertErrorField_ErrorMsg_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcExchangeOrderInsertErrorField() : this(CTPTradeCppWrapperPINVOKE.new_CThostFtdcExchangeOrderInsertErrorField(), true) {
  }

}

}

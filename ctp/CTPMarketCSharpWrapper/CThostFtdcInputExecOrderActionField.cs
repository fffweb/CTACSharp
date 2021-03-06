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

public class CThostFtdcInputExecOrderActionField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcInputExecOrderActionField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcInputExecOrderActionField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcInputExecOrderActionField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcInputExecOrderActionField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderActionField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderActionField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string InvestorID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderActionField_InvestorID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderActionField_InvestorID_get(swigCPtr);
      return ret;
    } 
  }

  public int ExecOrderActionRef {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderActionField_ExecOrderActionRef_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderActionField_ExecOrderActionRef_get(swigCPtr);
      return ret;
    } 
  }

  public string ExecOrderRef {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderActionField_ExecOrderRef_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderActionField_ExecOrderRef_get(swigCPtr);
      return ret;
    } 
  }

  public int RequestID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderActionField_RequestID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderActionField_RequestID_get(swigCPtr);
      return ret;
    } 
  }

  public int FrontID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderActionField_FrontID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderActionField_FrontID_get(swigCPtr);
      return ret;
    } 
  }

  public int SessionID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderActionField_SessionID_set(swigCPtr, value);
    } 
    get {
      int ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderActionField_SessionID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExchangeID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderActionField_ExchangeID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderActionField_ExchangeID_get(swigCPtr);
      return ret;
    } 
  }

  public string ExecOrderSysID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderActionField_ExecOrderSysID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderActionField_ExecOrderSysID_get(swigCPtr);
      return ret;
    } 
  }

  public char ActionFlag {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderActionField_ActionFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderActionField_ActionFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderActionField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderActionField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public string InstrumentID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderActionField_InstrumentID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcInputExecOrderActionField_InstrumentID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcInputExecOrderActionField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcInputExecOrderActionField(), true) {
  }

}

}

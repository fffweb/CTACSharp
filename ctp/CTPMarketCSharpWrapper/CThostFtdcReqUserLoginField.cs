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

public class CThostFtdcReqUserLoginField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcReqUserLoginField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcReqUserLoginField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcReqUserLoginField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcReqUserLoginField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string TradingDay {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqUserLoginField_TradingDay_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqUserLoginField_TradingDay_get(swigCPtr);
      return ret;
    } 
  }

  public string BrokerID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqUserLoginField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqUserLoginField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string UserID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqUserLoginField_UserID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqUserLoginField_UserID_get(swigCPtr);
      return ret;
    } 
  }

  public string Password {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqUserLoginField_Password_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqUserLoginField_Password_get(swigCPtr);
      return ret;
    } 
  }

  public string UserProductInfo {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqUserLoginField_UserProductInfo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqUserLoginField_UserProductInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string InterfaceProductInfo {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqUserLoginField_InterfaceProductInfo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqUserLoginField_InterfaceProductInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string ProtocolInfo {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqUserLoginField_ProtocolInfo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqUserLoginField_ProtocolInfo_get(swigCPtr);
      return ret;
    } 
  }

  public string MacAddress {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqUserLoginField_MacAddress_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqUserLoginField_MacAddress_get(swigCPtr);
      return ret;
    } 
  }

  public string OneTimePassword {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqUserLoginField_OneTimePassword_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqUserLoginField_OneTimePassword_get(swigCPtr);
      return ret;
    } 
  }

  public string ClientIPAddress {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcReqUserLoginField_ClientIPAddress_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcReqUserLoginField_ClientIPAddress_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcReqUserLoginField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcReqUserLoginField(), true) {
  }

}

}

//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class CThostFtdcTransferFutureToBankReqField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcTransferFutureToBankReqField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcTransferFutureToBankReqField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcTransferFutureToBankReqField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcTransferFutureToBankReqField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string FutureAccount {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcTransferFutureToBankReqField_FutureAccount_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcTransferFutureToBankReqField_FutureAccount_get(swigCPtr);
      return ret;
    } 
  }

  public char FuturePwdFlag {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcTransferFutureToBankReqField_FuturePwdFlag_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcTransferFutureToBankReqField_FuturePwdFlag_get(swigCPtr);
      return ret;
    } 
  }

  public string FutureAccPwd {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcTransferFutureToBankReqField_FutureAccPwd_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcTransferFutureToBankReqField_FutureAccPwd_get(swigCPtr);
      return ret;
    } 
  }

  public double TradeAmt {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcTransferFutureToBankReqField_TradeAmt_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcTransferFutureToBankReqField_TradeAmt_get(swigCPtr);
      return ret;
    } 
  }

  public double CustFee {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcTransferFutureToBankReqField_CustFee_set(swigCPtr, value);
    } 
    get {
      double ret = CTPMarketCppWrapperPINVOKE.CThostFtdcTransferFutureToBankReqField_CustFee_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyCode {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcTransferFutureToBankReqField_CurrencyCode_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcTransferFutureToBankReqField_CurrencyCode_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcTransferFutureToBankReqField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcTransferFutureToBankReqField(), true) {
  }

}
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

public class CThostFtdcPositionProfitAlgorithmField : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal CThostFtdcPositionProfitAlgorithmField(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(CThostFtdcPositionProfitAlgorithmField obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~CThostFtdcPositionProfitAlgorithmField() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          CTPMarketCppWrapperPINVOKE.delete_CThostFtdcPositionProfitAlgorithmField(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public string BrokerID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcPositionProfitAlgorithmField_BrokerID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcPositionProfitAlgorithmField_BrokerID_get(swigCPtr);
      return ret;
    } 
  }

  public string AccountID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcPositionProfitAlgorithmField_AccountID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcPositionProfitAlgorithmField_AccountID_get(swigCPtr);
      return ret;
    } 
  }

  public char Algorithm {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcPositionProfitAlgorithmField_Algorithm_set(swigCPtr, value);
    } 
    get {
      char ret = CTPMarketCppWrapperPINVOKE.CThostFtdcPositionProfitAlgorithmField_Algorithm_get(swigCPtr);
      return ret;
    } 
  }

  public string Memo {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcPositionProfitAlgorithmField_Memo_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcPositionProfitAlgorithmField_Memo_get(swigCPtr);
      return ret;
    } 
  }

  public string CurrencyID {
    set {
      CTPMarketCppWrapperPINVOKE.CThostFtdcPositionProfitAlgorithmField_CurrencyID_set(swigCPtr, value);
    } 
    get {
      string ret = CTPMarketCppWrapperPINVOKE.CThostFtdcPositionProfitAlgorithmField_CurrencyID_get(swigCPtr);
      return ret;
    } 
  }

  public CThostFtdcPositionProfitAlgorithmField() : this(CTPMarketCppWrapperPINVOKE.new_CThostFtdcPositionProfitAlgorithmField(), true) {
  }

}

}

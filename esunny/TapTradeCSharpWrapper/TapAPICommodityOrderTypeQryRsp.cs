//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.12
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------


public class TapAPICommodityOrderTypeQryRsp : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal TapAPICommodityOrderTypeQryRsp(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(TapAPICommodityOrderTypeQryRsp obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~TapAPICommodityOrderTypeQryRsp() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          TapTradeCppWrapperPINVOKE.delete_TapAPICommodityOrderTypeQryRsp(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public TapAPICommodity Commodity {
    set {
      TapTradeCppWrapperPINVOKE.TapAPICommodityOrderTypeQryRsp_Commodity_set(swigCPtr, TapAPICommodity.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = TapTradeCppWrapperPINVOKE.TapAPICommodityOrderTypeQryRsp_Commodity_get(swigCPtr);
      TapAPICommodity ret = (cPtr == global::System.IntPtr.Zero) ? null : new TapAPICommodity(cPtr, false);
      return ret;
    } 
  }

  public int Count {
    set {
      TapTradeCppWrapperPINVOKE.TapAPICommodityOrderTypeQryRsp_Count_set(swigCPtr, value);
    } 
    get {
      int ret = TapTradeCppWrapperPINVOKE.TapAPICommodityOrderTypeQryRsp_Count_get(swigCPtr);
      return ret;
    } 
  }

  public string OrderTypes {
    set {
      TapTradeCppWrapperPINVOKE.TapAPICommodityOrderTypeQryRsp_OrderTypes_set(swigCPtr, value);
    } 
    get {
      string ret = TapTradeCppWrapperPINVOKE.TapAPICommodityOrderTypeQryRsp_OrderTypes_get(swigCPtr);
      return ret;
    } 
  }

  public TapAPICommodityOrderTypeQryRsp() : this(TapTradeCppWrapperPINVOKE.new_TapAPICommodityOrderTypeQryRsp(), true) {
  }

}

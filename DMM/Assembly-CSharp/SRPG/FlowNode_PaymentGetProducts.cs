// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_PaymentGetProducts
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001451")]
  [FlowNode.NodeType("Payment/GetProducts", 32741)]
  [FlowNode.Pin(0, "Start", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "ClearList", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "Failure", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "WaitingForSetup", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(103, "Empty", FlowNode.PinTypes.Output, 103)]
  [AddComponentMenu("")]
  public class FlowNode_PaymentGetProducts : FlowNode
  {
    [Token(Token = "0x4004B33")]
    [FieldOffset(Offset = "0x18")]
    private bool mSetDelegate;
    [Token(Token = "0x4004B34")]
    [FieldOffset(Offset = "0x0")]
    public static PaymentManager.Product[] Products;

    [Token(Token = "0x60054F7")]
    [Address(RVA = "0x12967A0", Offset = "0x12955A0", VA = "0x112967A0")]
    private void RemoveDelegate()
    {
    }

    [Token(Token = "0x60054F8")]
    [Address(RVA = "0x12963E0", Offset = "0x12951E0", VA = "0x112963E0", Slot = "1")]
    ~FlowNode_PaymentGetProducts()
    {
    }

    [Token(Token = "0x60054F9")]
    [Address(RVA = "0x12965F0", Offset = "0x12953F0", VA = "0x112965F0", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x60054FA")]
    [Address(RVA = "0x1296480", Offset = "0x1295280", VA = "0x11296480", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60054FB")]
    [Address(RVA = "0x1296890", Offset = "0x1295690", VA = "0x11296890")]
    private void Success()
    {
    }

    [Token(Token = "0x60054FC")]
    [Address(RVA = "0x1296380", Offset = "0x1295180", VA = "0x11296380")]
    private void Failure()
    {
    }

    [Token(Token = "0x60054FD")]
    [Address(RVA = "0x12968F0", Offset = "0x12956F0", VA = "0x112968F0")]
    private void WaitingForSetup()
    {
    }

    [Token(Token = "0x60054FE")]
    [Address(RVA = "0x1296320", Offset = "0x1295120", VA = "0x11296320")]
    private void Empty()
    {
    }

    [Token(Token = "0x60054FF")]
    [Address(RVA = "0x1296610", Offset = "0x1295410", VA = "0x11296610")]
    public void OnShowItems(
      PaymentManager.EShowItemsResult result,
      PaymentManager.Product[] products)
    {
    }

    [Token(Token = "0x6005500")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_PaymentGetProducts()
    {
    }
  }
}

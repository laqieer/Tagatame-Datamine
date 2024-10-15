// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_PurchaseResume
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001465")]
  [FlowNode.NodeType("Payment/PurchaseResume", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "Failed", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(100, "ConnectingDialogOpen", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "ConnectingDialogClose", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  public class FlowNode_PurchaseResume : FlowNode
  {
    [Token(Token = "0x4004B6E")]
    [FieldOffset(Offset = "0x18")]
    private bool mSetDelegate;
    [Token(Token = "0x4004B6F")]
    [FieldOffset(Offset = "0x1C")]
    private float wait_time;
    [Token(Token = "0x4004B70")]
    [FieldOffset(Offset = "0x20")]
    private bool succeeded;

    [Token(Token = "0x6005546")]
    [Address(RVA = "0x1299BF0", Offset = "0x12989F0", VA = "0x11299BF0")]
    private void RemoveDelegate()
    {
    }

    [Token(Token = "0x6005547")]
    [Address(RVA = "0x12999C0", Offset = "0x12987C0", VA = "0x112999C0", Slot = "1")]
    ~FlowNode_PurchaseResume()
    {
    }

    [Token(Token = "0x6005548")]
    [Address(RVA = "0x1299BA0", Offset = "0x12989A0", VA = "0x11299BA0", Slot = "8")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6005549")]
    [Address(RVA = "0x1299A60", Offset = "0x1298860", VA = "0x11299A60", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600554A")]
    [Address(RVA = "0x1299CE0", Offset = "0x1298AE0", VA = "0x11299CE0")]
    public void Update()
    {
    }

    [Token(Token = "0x600554B")]
    [Address(RVA = "0x1299BC0", Offset = "0x12989C0", VA = "0x11299BC0")]
    public void OnRequestSucceeded()
    {
    }

    [Token(Token = "0x600554C")]
    [Address(RVA = "0x1299BD0", Offset = "0x12989D0", VA = "0x11299BD0")]
    public void OpenPurchaseMsg()
    {
    }

    [Token(Token = "0x600554D")]
    [Address(RVA = "0x3161D0", Offset = "0x314FD0", VA = "0x103161D0")]
    public void ClosePurchaseMsg()
    {
    }

    [Token(Token = "0x600554E")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_PurchaseResume()
    {
    }
  }
}

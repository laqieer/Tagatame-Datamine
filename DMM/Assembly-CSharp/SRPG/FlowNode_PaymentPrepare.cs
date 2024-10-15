// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_PaymentPrepare
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001453")]
  [FlowNode.NodeType("Payment/Prepare", 32741)]
  [FlowNode.Pin(0, "Start", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "Success", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(200, "Error", FlowNode.PinTypes.Output, 200)]
  [AddComponentMenu("")]
  public class FlowNode_PaymentPrepare : FlowNode_Network
  {
    [Token(Token = "0x4004B35")]
    [FieldOffset(Offset = "0x20")]
    public bool mErrorSuccess;

    [Token(Token = "0x6005503")]
    [Address(RVA = "0x1296A00", Offset = "0x1295800", VA = "0x11296A00", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005504")]
    [Address(RVA = "0x1296E50", Offset = "0x1295C50", VA = "0x11296E50")]
    private void Success()
    {
    }

    [Token(Token = "0x6005505")]
    [Address(RVA = "0x12969B0", Offset = "0x12957B0", VA = "0x112969B0")]
    private void Failure()
    {
    }

    [Token(Token = "0x6005506")]
    [Address(RVA = "0x1296BE0", Offset = "0x12959E0", VA = "0x11296BE0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005507")]
    [Address(RVA = "0x1296EE0", Offset = "0x1295CE0", VA = "0x11296EE0")]
    public FlowNode_PaymentPrepare()
    {
    }
  }
}

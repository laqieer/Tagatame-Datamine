// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqProductParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001566")]
  [FlowNode.NodeType("System/Master/ReqProductParam", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(2, "Failed", FlowNode.PinTypes.Output, 2)]
  [AddComponentMenu("")]
  public class FlowNode_ReqProductParam : FlowNode_Network
  {
    [Token(Token = "0x4004DF5")]
    [FieldOffset(Offset = "0x20")]
    public bool IsLoginBefore;

    [Token(Token = "0x6005866")]
    [Address(RVA = "0x12D6AC0", Offset = "0x12D58C0", VA = "0x112D6AC0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005867")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005868")]
    [Address(RVA = "0x126BD30", Offset = "0x126AB30", VA = "0x1126BD30")]
    private void Failure()
    {
    }

    [Token(Token = "0x6005869")]
    [Address(RVA = "0x12D6BB0", Offset = "0x12D59B0", VA = "0x112D6BB0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600586A")]
    [Address(RVA = "0x12D6A50", Offset = "0x12D5850", VA = "0x112D6A50")]
    private IEnumerator CheckPaymentInit(ProductParamResponse param) => (IEnumerator) null;

    [Token(Token = "0x600586B")]
    [Address(RVA = "0x12D6EB0", Offset = "0x12D5CB0", VA = "0x112D6EB0")]
    public FlowNode_ReqProductParam()
    {
    }
  }
}

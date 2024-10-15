// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqChatAutoAssign
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014B5")]
  [FlowNode.NodeType("System/ReqChat/ReqChatAutoAssign", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("")]
  public class FlowNode_ReqChatAutoAssign : FlowNode_Network
  {
    [Token(Token = "0x6005655")]
    [Address(RVA = "0x12BDBD0", Offset = "0x12BC9D0", VA = "0x112BDBD0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005656")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x6005657")]
    [Address(RVA = "0x12BDC80", Offset = "0x12BCA80", VA = "0x112BDC80", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x6005658")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqChatAutoAssign()
    {
    }
  }
}

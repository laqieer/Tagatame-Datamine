// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqUpdateSelectAward
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20015E3")]
  [FlowNode.NodeType("System/Award/ReqUpdateSelectAward", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(10, "Success", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "Failure", FlowNode.PinTypes.Output, 11)]
  [AddComponentMenu("")]
  public class FlowNode_ReqUpdateSelectAward : FlowNode_Network
  {
    [Token(Token = "0x60059EF")]
    [Address(RVA = "0x12E70D0", Offset = "0x12E5ED0", VA = "0x112E70D0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60059F0")]
    [Address(RVA = "0x1292FD0", Offset = "0x1291DD0", VA = "0x11292FD0")]
    private void Success()
    {
    }

    [Token(Token = "0x60059F1")]
    [Address(RVA = "0xE61A80", Offset = "0xE60880", VA = "0x10E61A80")]
    private void Failure()
    {
    }

    [Token(Token = "0x60059F2")]
    [Address(RVA = "0x12E7240", Offset = "0x12E6040", VA = "0x112E7240", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60059F3")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqUpdateSelectAward()
    {
    }
  }
}

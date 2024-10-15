// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqHealAp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200152D")]
  [FlowNode.NodeType("System/Player/ReqHealAp", 32741)]
  [FlowNode.Pin(0, "ReqHealAp", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [AddComponentMenu("")]
  public class FlowNode_ReqHealAp : FlowNode_Network
  {
    [Token(Token = "0x60057B2")]
    [Address(RVA = "0x12D3700", Offset = "0x12D2500", VA = "0x112D3700", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60057B3")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x60057B4")]
    [Address(RVA = "0x12D35C0", Offset = "0x12D23C0", VA = "0x112D35C0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60057B5")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqHealAp()
    {
    }
  }
}

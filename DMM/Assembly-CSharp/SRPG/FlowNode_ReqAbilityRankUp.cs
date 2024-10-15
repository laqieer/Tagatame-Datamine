// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqAbilityRankUp
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200147E")]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.NodeType("System/Unit/ReqAbilityRankUp", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_ReqAbilityRankUp : FlowNode_Network
  {
    [Token(Token = "0x600559A")]
    [Address(RVA = "0x12B45A0", Offset = "0x12B33A0", VA = "0x112B45A0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600559B")]
    [Address(RVA = "0x1264AF0", Offset = "0x12638F0", VA = "0x11264AF0")]
    private void Success()
    {
    }

    [Token(Token = "0x600559C")]
    [Address(RVA = "0x12B4760", Offset = "0x12B3560", VA = "0x112B4760", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x600559D")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqAbilityRankUp()
    {
    }
  }
}

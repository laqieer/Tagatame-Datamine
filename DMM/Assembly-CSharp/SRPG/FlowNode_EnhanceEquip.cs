// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_EnhanceEquip
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013D0")]
  [FlowNode.NodeType("System/Unit/EnhanceEquip", 32741)]
  [FlowNode.Pin(0, "Request", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(1, "Success", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(2, "費用が足りない", FlowNode.PinTypes.Output, 2)]
  [AddComponentMenu("")]
  public class FlowNode_EnhanceEquip : FlowNode_Network
  {
    [Token(Token = "0x400495A")]
    [FieldOffset(Offset = "0x20")]
    private int mRankupCount;

    [Token(Token = "0x60052EA")]
    [Address(RVA = "0x127A4E0", Offset = "0x12792E0", VA = "0x1127A4E0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60052EB")]
    [Address(RVA = "0x127ACD0", Offset = "0x1279AD0", VA = "0x1127ACD0")]
    private void Success()
    {
    }

    [Token(Token = "0x60052EC")]
    [Address(RVA = "0x127AA30", Offset = "0x1279830", VA = "0x1127AA30", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60052ED")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_EnhanceEquip()
    {
    }
  }
}

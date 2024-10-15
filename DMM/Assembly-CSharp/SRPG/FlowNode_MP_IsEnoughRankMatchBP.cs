// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_MP_IsEnoughRankMatchBP
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20017CD")]
  [FlowNode.NodeType("MultiPlay/RankMatch/IsEnoughBP", 32741)]
  [FlowNode.Pin(0, "Check", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "Yes", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "No", FlowNode.PinTypes.Output, 101)]
  [AddComponentMenu("")]
  public class FlowNode_MP_IsEnoughRankMatchBP : FlowNode
  {
    [Token(Token = "0x4005595")]
    private const int PIN_IN_CHECK = 0;
    [Token(Token = "0x4005596")]
    private const int PIN_OUT_YES = 100;
    [Token(Token = "0x4005597")]
    private const int PIN_OUT_NO = 101;

    [Token(Token = "0x6006065")]
    [Address(RVA = "0x134B900", Offset = "0x134A700", VA = "0x1134B900", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6006066")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_MP_IsEnoughRankMatchBP()
    {
    }
  }
}

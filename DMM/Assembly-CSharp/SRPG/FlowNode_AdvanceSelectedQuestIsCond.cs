// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_AdvanceSelectedQuestIsCond
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012CE")]
  [FlowNode.NodeType("Advance/難易度開放の可能性があるクエストか？", 32741)]
  [FlowNode.Pin(1, "In", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("")]
  [FlowNode.Pin(21, "難易度開放開放の可能性なし", FlowNode.PinTypes.Output, 21)]
  [FlowNode.Pin(11, "難易度開放の可能性あり", FlowNode.PinTypes.Output, 11)]
  public class FlowNode_AdvanceSelectedQuestIsCond : FlowNode
  {
    [Token(Token = "0x4004619")]
    private const int PIN_IN = 1;
    [Token(Token = "0x400461A")]
    private const int PIN_OUT_TRUE = 11;
    [Token(Token = "0x400461B")]
    private const int PIN_OUT_FALSE = 21;

    [Token(Token = "0x6004FB6")]
    [Address(RVA = "0x1249840", Offset = "0x1248640", VA = "0x11249840", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6004FB7")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_AdvanceSelectedQuestIsCond()
    {
    }
  }
}

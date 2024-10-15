// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_AdvanceSelectedQuestIsBossOpen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012CD")]
  [FlowNode.Pin(21, "ボス開放の可能性なし", FlowNode.PinTypes.Output, 21)]
  [FlowNode.Pin(1, "In", FlowNode.PinTypes.Input, 1)]
  [FlowNode.NodeType("Advance/ボス開放の可能性があるか？", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(11, "ボス開放の可能性あり", FlowNode.PinTypes.Output, 11)]
  public class FlowNode_AdvanceSelectedQuestIsBossOpen : FlowNode
  {
    [Token(Token = "0x4004616")]
    private const int PIN_IN = 1;
    [Token(Token = "0x4004617")]
    private const int PIN_OUT_TRUE = 11;
    [Token(Token = "0x4004618")]
    private const int PIN_OUT_FALSE = 21;

    [Token(Token = "0x6004FB4")]
    [Address(RVA = "0x12496E0", Offset = "0x12484E0", VA = "0x112496E0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6004FB5")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_AdvanceSelectedQuestIsBossOpen()
    {
    }
  }
}

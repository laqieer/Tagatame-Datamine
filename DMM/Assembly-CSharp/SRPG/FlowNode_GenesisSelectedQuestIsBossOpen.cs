// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_GenesisSelectedQuestIsBossOpen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001690")]
  [FlowNode.Pin(21, "ボス開放の可能性なし", FlowNode.PinTypes.Output, 21)]
  [FlowNode.Pin(11, "ボス開放の可能性あり", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(1, "In", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Genesis/ボス開放の可能性があるか？", 32741)]
  public class FlowNode_GenesisSelectedQuestIsBossOpen : FlowNode
  {
    [Token(Token = "0x4005206")]
    private const int PIN_IN = 1;
    [Token(Token = "0x4005207")]
    private const int PIN_OUT_TRUE = 11;
    [Token(Token = "0x4005208")]
    private const int PIN_OUT_FALSE = 21;

    [Token(Token = "0x6005C95")]
    [Address(RVA = "0x1307C50", Offset = "0x1306A50", VA = "0x11307C50", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005C96")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_GenesisSelectedQuestIsBossOpen()
    {
    }
  }
}

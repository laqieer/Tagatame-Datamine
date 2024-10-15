// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_GenesisSelectedQuestIsSkipOpen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001693")]
  [AddComponentMenu("")]
  [FlowNode.Pin(1, "In", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(11, "スキチケ開放の可能性あり", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(12, "スキチケ開放の可能性なし", FlowNode.PinTypes.Output, 12)]
  [FlowNode.NodeType("Genesis/スキチケ開放の可能性があるか？", 32741)]
  public class FlowNode_GenesisSelectedQuestIsSkipOpen : FlowNode
  {
    [Token(Token = "0x400520E")]
    private const int PIN_IN = 1;
    [Token(Token = "0x400520F")]
    private const int PIN_OUT_TRUE = 11;
    [Token(Token = "0x4005210")]
    private const int PIN_OUT_FALSE = 12;

    [Token(Token = "0x6005C9B")]
    [Address(RVA = "0x13081C0", Offset = "0x1306FC0", VA = "0x113081C0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005C9C")]
    [Address(RVA = "0x13080F0", Offset = "0x1306EF0", VA = "0x113080F0")]
    private void CheckSkipOpen()
    {
    }

    [Token(Token = "0x6005C9D")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_GenesisSelectedQuestIsSkipOpen()
    {
    }
  }
}

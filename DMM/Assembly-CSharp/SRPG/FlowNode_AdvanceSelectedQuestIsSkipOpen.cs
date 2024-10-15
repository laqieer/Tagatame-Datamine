// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_AdvanceSelectedQuestIsSkipOpen
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20012D0")]
  [FlowNode.Pin(1, "In", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(11, "スキチケ開放の可能性あり", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(12, "スキチケ開放の可能性なし", FlowNode.PinTypes.Output, 12)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("Advance/スキチケ開放の可能性があるか？", 32741)]
  public class FlowNode_AdvanceSelectedQuestIsSkipOpen : FlowNode
  {
    [Token(Token = "0x400461E")]
    private const int PIN_IN = 1;
    [Token(Token = "0x400461F")]
    private const int PIN_OUT_TRUE = 11;
    [Token(Token = "0x4004620")]
    private const int PIN_OUT_FALSE = 12;

    [Token(Token = "0x6004FBA")]
    [Address(RVA = "0x1249C50", Offset = "0x1248A50", VA = "0x11249C50", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6004FBB")]
    [Address(RVA = "0x1249B80", Offset = "0x1248980", VA = "0x11249B80")]
    private void CheckSkipOpen()
    {
    }

    [Token(Token = "0x6004FBC")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_AdvanceSelectedQuestIsSkipOpen()
    {
    }
  }
}

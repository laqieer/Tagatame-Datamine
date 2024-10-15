// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ConceptCardMixCheck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013A5")]
  [FlowNode.Pin(1001, "ゼニー不足", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(11, "一括強化による合成可能かチェック", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(10, "合成可能かチェック", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(1000, "合成可能", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.NodeType("UI/ConceptCardMixCheck", 32741)]
  [FlowNode.Pin(20, "境界値が越えているかのチェック", FlowNode.PinTypes.Input, 20)]
  [AddComponentMenu("")]
  [FlowNode.Pin(2000, "境界値の限界突破", FlowNode.PinTypes.Output, 2000)]
  public class FlowNode_ConceptCardMixCheck : FlowNode
  {
    [Token(Token = "0x400487E")]
    private const int INPUT_MIX_CHECK = 10;
    [Token(Token = "0x400487F")]
    private const int INPUT_BULK_MIX_CHECK = 11;
    [Token(Token = "0x4004880")]
    private const int OUTPUT_MIX_OK = 1000;
    [Token(Token = "0x4004881")]
    private const int OUTPUT_MIX_ZENY_NG = 1001;
    [Token(Token = "0x4004882")]
    private const int INPUT_MIX_OVERTRUST = 20;
    [Token(Token = "0x4004883")]
    private const int OUTPUT_MIX_OVERTRUST = 2000;

    [Token(Token = "0x600524E")]
    [Address(RVA = "0x126F410", Offset = "0x126E210", VA = "0x1126F410", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600524F")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_ConceptCardMixCheck()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ConceptCardRarityCheck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013A7")]
  [AddComponentMenu("")]
  [FlowNode.Pin(1001, "指定レア値より少ない", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(1000, "指定レア値以上", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(10, "入力", FlowNode.PinTypes.Input, 10)]
  [FlowNode.NodeType("UI/ConceptCardRarityCheck", 32741)]
  public class FlowNode_ConceptCardRarityCheck : FlowNode
  {
    [Token(Token = "0x4004887")]
    private const int INPUT_CHECK = 10;
    [Token(Token = "0x4004888")]
    private const int OUTPUT_HIGH = 1000;
    [Token(Token = "0x4004889")]
    private const int OUTPUT_LOW = 1001;
    [Token(Token = "0x400488A")]
    [FieldOffset(Offset = "0x18")]
    public int Rarity;

    [Token(Token = "0x6005252")]
    [Address(RVA = "0x126F870", Offset = "0x126E670", VA = "0x1126F870", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005253")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_ConceptCardRarityCheck()
    {
    }
  }
}

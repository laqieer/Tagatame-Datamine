// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ConceptCardTrustMaterialCheck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013AA")]
  [AddComponentMenu("")]
  [FlowNode.Pin(1001, "トラスト値が最大の素材が含まれていない", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(1000, "トラスト値が最大の素材が含まれている", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(10, "入力", FlowNode.PinTypes.Input, 10)]
  [FlowNode.NodeType("UI/ConceptCardTrustMaterialCheck", 32741)]
  public class FlowNode_ConceptCardTrustMaterialCheck : FlowNode
  {
    [Token(Token = "0x4004899")]
    private const int INPUT_CHECK = 10;
    [Token(Token = "0x400489A")]
    private const int OUTPUT_HIGH = 1000;
    [Token(Token = "0x400489B")]
    private const int OUTPUT_LOW = 1001;

    [Token(Token = "0x600525A")]
    [Address(RVA = "0x12701C0", Offset = "0x126EFC0", VA = "0x112701C0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x600525B")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_ConceptCardTrustMaterialCheck()
    {
    }
  }
}

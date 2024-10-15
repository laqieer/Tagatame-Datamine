// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ConceptCardTrustCheck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013A8")]
  [FlowNode.Pin(10, "入力", FlowNode.PinTypes.Input, 10)]
  [FlowNode.NodeType("UI/ConceptCardTrustCheck", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1000, "トラスト値の最大値以上", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(1001, "トラスト値の最大値より少ない", FlowNode.PinTypes.Output, 1001)]
  public class FlowNode_ConceptCardTrustCheck : FlowNode
  {
    [Token(Token = "0x400488B")]
    private const int INPUT_CHECK = 10;
    [Token(Token = "0x400488C")]
    private const int OUTPUT_HIGH = 1000;
    [Token(Token = "0x400488D")]
    private const int OUTPUT_LOW = 1001;

    [Token(Token = "0x6005254")]
    [Address(RVA = "0x126FAA0", Offset = "0x126E8A0", VA = "0x1126FAA0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005255")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_ConceptCardTrustCheck()
    {
    }
  }
}

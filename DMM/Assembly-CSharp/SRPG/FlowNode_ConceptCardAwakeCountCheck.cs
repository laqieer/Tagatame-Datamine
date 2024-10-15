// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ConceptCardAwakeCountCheck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200139E")]
  [AddComponentMenu("")]
  [FlowNode.Pin(1001, "限界突破の最大値以下", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(1000, "限界突破の最大値を超える", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(10, "入力", FlowNode.PinTypes.Input, 10)]
  [FlowNode.NodeType("UI/ConceptCardAwakeCountCheck", 32741)]
  public class FlowNode_ConceptCardAwakeCountCheck : FlowNode
  {
    [Token(Token = "0x400486C")]
    private const int INPUT_CHECK = 10;
    [Token(Token = "0x400486D")]
    private const int OUTPUT_HIGH = 1000;
    [Token(Token = "0x400486E")]
    private const int OUTPUT_LOW = 1001;

    [Token(Token = "0x600522F")]
    [Address(RVA = "0x126EF30", Offset = "0x126DD30", VA = "0x1126EF30", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005230")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_ConceptCardAwakeCountCheck()
    {
    }
  }
}

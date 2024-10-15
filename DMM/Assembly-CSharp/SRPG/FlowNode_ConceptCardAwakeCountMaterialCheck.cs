// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ConceptCardAwakeCountMaterialCheck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200139F")]
  [FlowNode.NodeType("UI/ConceptCardAwakeCountMaterialCheck", 32741)]
  [AddComponentMenu("")]
  [FlowNode.Pin(1001, "限界突破が最大の素材が含まれていない", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(10, "入力", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(1000, "限界突破が最大の素材が含まれている", FlowNode.PinTypes.Output, 1000)]
  public class FlowNode_ConceptCardAwakeCountMaterialCheck : FlowNode
  {
    [Token(Token = "0x400486F")]
    private const int INPUT_CHECK = 10;
    [Token(Token = "0x4004870")]
    private const int OUTPUT_HIGH = 1000;
    [Token(Token = "0x4004871")]
    private const int OUTPUT_LOW = 1001;

    [Token(Token = "0x6005231")]
    [Address(RVA = "0x126F020", Offset = "0x126DE20", VA = "0x1126F020", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005232")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_ConceptCardAwakeCountMaterialCheck()
    {
    }
  }
}

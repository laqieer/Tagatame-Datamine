// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ConceptCardNoSaleCheck
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20013A6")]
  [FlowNode.NodeType("UI/ConceptCardNoSaleCheck", 32741)]
  [FlowNode.Pin(10, "入力", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(1000, "非売品が存在する", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(1001, "非売品は無い", FlowNode.PinTypes.Output, 1001)]
  [AddComponentMenu("")]
  public class FlowNode_ConceptCardNoSaleCheck : FlowNode
  {
    [Token(Token = "0x4004884")]
    private const int INPUT_CHECK = 10;
    [Token(Token = "0x4004885")]
    private const int OUTPUT_EXIST = 1000;
    [Token(Token = "0x4004886")]
    private const int OUTPUT_NO_EXIST = 1001;

    [Token(Token = "0x6005250")]
    [Address(RVA = "0x126F660", Offset = "0x126E460", VA = "0x1126F660", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x6005251")]
    [Address(RVA = "0x306200", Offset = "0x305000", VA = "0x10306200")]
    public FlowNode_ConceptCardNoSaleCheck()
    {
    }
  }
}

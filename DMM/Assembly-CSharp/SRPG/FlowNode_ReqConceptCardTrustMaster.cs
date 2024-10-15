// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqConceptCardTrustMaster
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014E1")]
  [FlowNode.Pin(1000, "報酬受取完了", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(100, "報酬未受取のトラストマスター達成", FlowNode.PinTypes.Input, 100)]
  [FlowNode.NodeType("ConceptCard/Req/ReqConceptCardTrustMaster", 32741)]
  [AddComponentMenu("")]
  public class FlowNode_ReqConceptCardTrustMaster : FlowNode_Network
  {
    [Token(Token = "0x4004C8E")]
    private const int INPUT_TRUSTMASTER_ON = 100;
    [Token(Token = "0x4004C8F")]
    private const int OUTPUT_TRUSTMASTER_ON = 1000;
    [Token(Token = "0x4004C90")]
    [FieldOffset(Offset = "0x20")]
    private int mOutPutPinId;

    [Token(Token = "0x60056E0")]
    [Address(RVA = "0x12C4D70", Offset = "0x12C3B70", VA = "0x112C4D70", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60056E1")]
    [Address(RVA = "0x12C4ED0", Offset = "0x12C3CD0", VA = "0x112C4ED0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60056E2")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqConceptCardTrustMaster()
    {
    }

    [Token(Token = "0x20014E2")]
    public class Json_ConceptCardTrustMaster
    {
      [Token(Token = "0x4004C91")]
      [FieldOffset(Offset = "0x8")]
      public JSON_ConceptCard concept_card;

      [Token(Token = "0x60056E3")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_ConceptCardTrustMaster()
      {
      }
    }
  }
}

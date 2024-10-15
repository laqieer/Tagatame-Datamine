// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqConceptCard
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014CD")]
  [AddComponentMenu("")]
  [FlowNode.NodeType("ConceptCard/Req/ReqConceptCard", 32741)]
  [FlowNode.Pin(0, "一覧取得", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "一覧取得した", FlowNode.PinTypes.Output, 100)]
  public class FlowNode_ReqConceptCard : FlowNode_Network
  {
    [Token(Token = "0x4004C4F")]
    private const int INPUT_CONCEPT_CARD_GET = 0;
    [Token(Token = "0x4004C50")]
    private const int OUTPUT_CONCEPT_CARD_GOT = 100;
    [Token(Token = "0x4004C51")]
    [FieldOffset(Offset = "0x20")]
    private bool mIsDataOverride;

    [Token(Token = "0x60056A6")]
    [Address(RVA = "0x12C51E0", Offset = "0x12C3FE0", VA = "0x112C51E0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60056A7")]
    [Address(RVA = "0x12C5410", Offset = "0x12C4210", VA = "0x112C5410", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60056A8")]
    [Address(RVA = "0x12C5170", Offset = "0x12C3F70", VA = "0x112C5170")]
    private IEnumerator DownloadAssetsAndOutputPin() => (IEnumerator) null;

    [Token(Token = "0x60056A9")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqConceptCard()
    {
    }

    [Token(Token = "0x20014CE")]
    public class Json_ConceptCardList
    {
      [Token(Token = "0x4004C52")]
      [FieldOffset(Offset = "0x8")]
      public JSON_ConceptCard[] cards;
      [Token(Token = "0x4004C53")]
      [FieldOffset(Offset = "0xC")]
      public JSON_ConceptCardMaterial[] materials;

      [Token(Token = "0x60056AA")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_ConceptCardList()
      {
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqConceptCardSell
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014DA")]
  [FlowNode.NodeType("ConceptCard/Req/ReqConceptCardSell", 32741)]
  [FlowNode.Pin(0, "売却する", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(100, "売却した", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("")]
  public class FlowNode_ReqConceptCardSell : FlowNode_Network
  {
    [Token(Token = "0x4004C7B")]
    private const int INPUT_CONCEPT_CARD_SELL = 0;
    [Token(Token = "0x4004C7C")]
    private const int OUTPUT_CONCEPT_CARD_SOLD = 100;
    [Token(Token = "0x4004C7D")]
    [FieldOffset(Offset = "0x20")]
    private long[] sellCardIDs;
    [Token(Token = "0x4004C7E")]
    [FieldOffset(Offset = "0x24")]
    private int totalSellZeny;

    [Token(Token = "0x60056C6")]
    [Address(RVA = "0x12C3E90", Offset = "0x12C2C90", VA = "0x112C3E90")]
    public void SetSellParam()
    {
    }

    [Token(Token = "0x60056C7")]
    [Address(RVA = "0x12C3A50", Offset = "0x12C2850", VA = "0x112C3A50", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60056C8")]
    [Address(RVA = "0x12C3BE0", Offset = "0x12C29E0", VA = "0x112C3BE0", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60056C9")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqConceptCardSell()
    {
    }

    [Token(Token = "0x20014DB")]
    public class Json_ConceptCardSell
    {
      [Token(Token = "0x4004C7F")]
      [FieldOffset(Offset = "0x8")]
      public Json_PlayerData player;
      [Token(Token = "0x4004C80")]
      [FieldOffset(Offset = "0xC")]
      public Json_Item[] items;
      [Token(Token = "0x4004C81")]
      [FieldOffset(Offset = "0x10")]
      public long[] sell_ids;

      [Token(Token = "0x60056CA")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_ConceptCardSell()
      {
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqConceptCardAwakeItemMix
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014D0")]
  [AddComponentMenu("")]
  [FlowNode.Pin(1000, "限界突破アイテムを使った合成完了", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(10, "限界突破アイテムを使った合成開始", FlowNode.PinTypes.Input, 10)]
  [FlowNode.NodeType("ConceptCard/Req/ReqConceptCardAwakeItemMix", 32741)]
  public class FlowNode_ReqConceptCardAwakeItemMix : FlowNode_Network
  {
    [Token(Token = "0x4004C58")]
    private const int INPUT_CONCEPT_CARD_AWAKE_ITEM_MIX_START = 10;
    [Token(Token = "0x4004C59")]
    private const int OUTPUT_CONCEPT_CARD_AWAKE_ITEM_MIX_END = 1000;
    [Token(Token = "0x4004C5A")]
    [FieldOffset(Offset = "0x20")]
    private long mBaseCardId;
    [Token(Token = "0x4004C5B")]
    [FieldOffset(Offset = "0x28")]
    private Dictionary<string, int> mMaterials;
    [Token(Token = "0x4004C5C")]
    [FieldOffset(Offset = "0x2C")]
    private int totalMixZeny;

    [Token(Token = "0x60056B1")]
    [Address(RVA = "0x12C2470", Offset = "0x12C1270", VA = "0x112C2470")]
    public void SetMixParam()
    {
    }

    [Token(Token = "0x60056B2")]
    [Address(RVA = "0x12C1AE0", Offset = "0x12C08E0", VA = "0x112C1AE0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60056B3")]
    [Address(RVA = "0x12C1D40", Offset = "0x12C0B40", VA = "0x112C1D40", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60056B4")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqConceptCardAwakeItemMix()
    {
    }

    [Token(Token = "0x20014D1")]
    public class ItemData
    {
      [Token(Token = "0x4004C5D")]
      [FieldOffset(Offset = "0x8")]
      private long iid;
      [Token(Token = "0x4004C5E")]
      [FieldOffset(Offset = "0x10")]
      private int iname;

      [Token(Token = "0x60056B5")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ItemData()
      {
      }
    }

    [Token(Token = "0x20014D2")]
    public class Json_ConceptCardAwakeItemMix
    {
      [Token(Token = "0x4004C5F")]
      [FieldOffset(Offset = "0x8")]
      public JSON_ConceptCard concept_card;
      [Token(Token = "0x4004C60")]
      [FieldOffset(Offset = "0xC")]
      public Json_Item[] items;

      [Token(Token = "0x60056B6")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_ConceptCardAwakeItemMix()
      {
      }
    }
  }
}

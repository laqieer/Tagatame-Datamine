// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqConceptCardMaterialMix
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014D5")]
  [FlowNode.Pin(10, "真理念装用素材を使った合成開始", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(1000, "真理念装用素材を使った合成完了", FlowNode.PinTypes.Output, 1000)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("ConceptCard/Req/ReqConceptCardMaterialDataMix", 32741)]
  public class FlowNode_ReqConceptCardMaterialMix : FlowNode_Network
  {
    [Token(Token = "0x4004C67")]
    private const int INPUT_CONCEPT_CARD_MATERIAL_DATA_MIX_START = 10;
    [Token(Token = "0x4004C68")]
    private const int OUTPUT_CONCEPT_CARD_MATERIAL_DATA_MIX_END = 1000;
    [Token(Token = "0x4004C69")]
    [FieldOffset(Offset = "0x20")]
    private long mBaseCardId;
    [Token(Token = "0x4004C6A")]
    [FieldOffset(Offset = "0x28")]
    private List<SelecteConceptCardMaterial> mMaterials;
    [Token(Token = "0x4004C6B")]
    [FieldOffset(Offset = "0x2C")]
    private int totalMixZeny;

    [Token(Token = "0x60056BB")]
    [Address(RVA = "0x12C30B0", Offset = "0x12C1EB0", VA = "0x112C30B0")]
    public void SetMixParam()
    {
    }

    [Token(Token = "0x60056BC")]
    [Address(RVA = "0x12C29E0", Offset = "0x12C17E0", VA = "0x112C29E0", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60056BD")]
    [Address(RVA = "0x12C2C00", Offset = "0x12C1A00", VA = "0x112C2C00", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60056BE")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqConceptCardMaterialMix()
    {
    }

    [Token(Token = "0x20014D6")]
    public class UseItem
    {
      [Token(Token = "0x4004C6C")]
      [FieldOffset(Offset = "0x8")]
      private long unique_id;
      [Token(Token = "0x4004C6D")]
      [FieldOffset(Offset = "0x10")]
      private int use_num;

      [Token(Token = "0x60056BF")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public UseItem()
      {
      }
    }

    [Token(Token = "0x20014D7")]
    public class Json_ConceptCardMaterialDataMix
    {
      [Token(Token = "0x4004C6E")]
      [FieldOffset(Offset = "0x8")]
      public Json_PlayerData player;
      [Token(Token = "0x4004C6F")]
      [FieldOffset(Offset = "0xC")]
      public JSON_ConceptCard concept_card;
      [Token(Token = "0x4004C70")]
      [FieldOffset(Offset = "0x10")]
      public FlowNode_ReqConceptCardMaterialMix.UseItem[] use_item;
      [Token(Token = "0x4004C71")]
      [FieldOffset(Offset = "0x14")]
      public JSON_ConceptCardMaterial[] materials;

      [Token(Token = "0x60056C0")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_ConceptCardMaterialDataMix()
      {
      }
    }
  }
}

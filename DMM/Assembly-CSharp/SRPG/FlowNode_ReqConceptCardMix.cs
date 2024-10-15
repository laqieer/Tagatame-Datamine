// Decompiled with JetBrains decompiler
// Type: SRPG.FlowNode_ReqConceptCardMix
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20014D8")]
  [FlowNode.Pin(10, "合成開始", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(1000, "合成完了", FlowNode.PinTypes.Output, 1000)]
  [AddComponentMenu("")]
  [FlowNode.NodeType("ConceptCard/Req/ReqConceptCardMix", 32741)]
  public class FlowNode_ReqConceptCardMix : FlowNode_Network
  {
    [Token(Token = "0x4004C72")]
    private const int INPUT_CONCEPT_CARD_MIX_START = 10;
    [Token(Token = "0x4004C73")]
    private const int OUTPUT_CONCEPT_CARD_MIX_END = 1000;
    [Token(Token = "0x4004C74")]
    [FieldOffset(Offset = "0x20")]
    private long mBaseCardId;
    [Token(Token = "0x4004C75")]
    [FieldOffset(Offset = "0x28")]
    private long[] mMixCardIds;
    [Token(Token = "0x4004C76")]
    [FieldOffset(Offset = "0x2C")]
    private int totalMixZeny;
    [Token(Token = "0x4004C77")]
    [FieldOffset(Offset = "0x30")]
    private int trustBonusMix;

    [Token(Token = "0x60056C1")]
    [Address(RVA = "0x12C38C0", Offset = "0x12C26C0", VA = "0x112C38C0")]
    public void SetMixParam()
    {
    }

    [Token(Token = "0x60056C2")]
    [Address(RVA = "0x12C3210", Offset = "0x12C2010", VA = "0x112C3210", Slot = "4")]
    public override void OnActivate(int pinID)
    {
    }

    [Token(Token = "0x60056C3")]
    [Address(RVA = "0x12C3330", Offset = "0x12C2130", VA = "0x112C3330", Slot = "21")]
    public override void OnSuccess(WWWResult www)
    {
    }

    [Token(Token = "0x60056C4")]
    [Address(RVA = "0x309770", Offset = "0x308570", VA = "0x10309770")]
    public FlowNode_ReqConceptCardMix()
    {
    }

    [Token(Token = "0x20014D9")]
    public class Json_ConceptCardMix
    {
      [Token(Token = "0x4004C78")]
      [FieldOffset(Offset = "0x8")]
      public Json_PlayerData player;
      [Token(Token = "0x4004C79")]
      [FieldOffset(Offset = "0xC")]
      public JSON_ConceptCard concept_card;
      [Token(Token = "0x4004C7A")]
      [FieldOffset(Offset = "0x10")]
      public long[] mix_ids;

      [Token(Token = "0x60056C5")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_ConceptCardMix()
      {
      }
    }
  }
}

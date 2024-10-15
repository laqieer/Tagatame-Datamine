// Decompiled with JetBrains decompiler
// Type: SRPG.ReqAdventureEnd
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network.Encoding;
using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002E46")]
  public class ReqAdventureEnd : WebAPI
  {
    [Token(Token = "0x600DA8A")]
    [Address(RVA = "0xA6B3C0", Offset = "0xA6A1C0", VA = "0x10A6B3C0")]
    public ReqAdventureEnd(
      string area_iname,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002E47")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E85C")]
      [FieldOffset(Offset = "0x8")]
      public string area_iname;

      [Token(Token = "0x600DA8B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002E48")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E85D")]
      [FieldOffset(Offset = "0x8")]
      public JSON_AdventureData[] adventure_areas;
      [Token(Token = "0x400E85E")]
      [FieldOffset(Offset = "0xC")]
      public JSON_AdventureDrop[] drops;
      [Token(Token = "0x400E85F")]
      [FieldOffset(Offset = "0x10")]
      public int sally_count;
      [Token(Token = "0x400E860")]
      [FieldOffset(Offset = "0x14")]
      public int adventure_end_count;
      [Token(Token = "0x400E861")]
      [FieldOffset(Offset = "0x18")]
      public JSON_AdventureBook[] books;
      [Token(Token = "0x400E862")]
      [FieldOffset(Offset = "0x1C")]
      public Json_PlayerData player;
      [Token(Token = "0x400E863")]
      [FieldOffset(Offset = "0x20")]
      public Json_Item[] items;
      [Token(Token = "0x400E864")]
      [FieldOffset(Offset = "0x24")]
      public Json_Unit[] units;
      [Token(Token = "0x400E865")]
      [FieldOffset(Offset = "0x28")]
      public Json_Artifact[] artifacts;
      [Token(Token = "0x400E866")]
      [FieldOffset(Offset = "0x2C")]
      public JSON_ConceptCard[] concept_cards;
      [Token(Token = "0x400E867")]
      [FieldOffset(Offset = "0x30")]
      public Json_RuneData[] runes_detail;
      [Token(Token = "0x400E868")]
      [FieldOffset(Offset = "0x34")]
      public int rune_storage_used;
      [Token(Token = "0x400E869")]
      [FieldOffset(Offset = "0x38")]
      public JSON_TrophyProgress[] trophyprogs;
      [Token(Token = "0x400E86A")]
      [FieldOffset(Offset = "0x3C")]
      public JSON_TrophyProgress[] bingoprogs;
      [Token(Token = "0x400E86B")]
      [FieldOffset(Offset = "0x40")]
      public JSON_TrophyProgress[] guild_trophies;

      [Token(Token = "0x600DA8C")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

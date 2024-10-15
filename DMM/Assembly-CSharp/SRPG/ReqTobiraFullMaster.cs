// Decompiled with JetBrains decompiler
// Type: SRPG.ReqTobiraFullMaster
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
  [Token(Token = "0x20031D1")]
  public class ReqTobiraFullMaster : WebAPI
  {
    [Token(Token = "0x600DE6A")]
    [Address(RVA = "0xA9D260", Offset = "0xA9C060", VA = "0x10A9D260")]
    public ReqTobiraFullMaster(
      long unit_iid,
      string item_iname,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x20031D2")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400ED96")]
      [FieldOffset(Offset = "0x8")]
      public long iid;
      [Token(Token = "0x400ED97")]
      [FieldOffset(Offset = "0x10")]
      public string item_iname;

      [Token(Token = "0x600DE6B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x20031D3")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400ED98")]
      [FieldOffset(Offset = "0x8")]
      public Json_PlayerData player;
      [Token(Token = "0x400ED99")]
      [FieldOffset(Offset = "0xC")]
      public Json_Item[] items;
      [Token(Token = "0x400ED9A")]
      [FieldOffset(Offset = "0x10")]
      public Json_Unit[] units;
      [Token(Token = "0x400ED9B")]
      [FieldOffset(Offset = "0x14")]
      public JSON_PartyOverWrite[] party_decks;
      [Token(Token = "0x400ED9C")]
      [FieldOffset(Offset = "0x18")]
      public Json_HotDealInfo[] hot_deals;
      [Token(Token = "0x400ED9D")]
      [FieldOffset(Offset = "0x1C")]
      public Json_InvalidSkill[] invalid_units;
      [Token(Token = "0x400ED9E")]
      [FieldOffset(Offset = "0x20")]
      public string[] mastery_reward_ids;
      [Token(Token = "0x400ED9F")]
      [FieldOffset(Offset = "0x24")]
      public int door_master_unit_num;

      [Token(Token = "0x600DE6C")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

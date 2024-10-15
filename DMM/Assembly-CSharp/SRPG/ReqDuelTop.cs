// Decompiled with JetBrains decompiler
// Type: SRPG.ReqDuelTop
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
  [Token(Token = "0x2002ED2")]
  public class ReqDuelTop : WebAPI
  {
    [Token(Token = "0x600DB1E")]
    [Address(RVA = "0xA6FA80", Offset = "0xA6E880", VA = "0x10A6FA80")]
    public ReqDuelTop(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002ED3")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E90E")]
      [FieldOffset(Offset = "0x8")]
      public JSON_DuelMapData map_data;
      [Token(Token = "0x400E90F")]
      [FieldOffset(Offset = "0xC")]
      public JSON_DuelPlayerData[] duel_enemies;
      [Token(Token = "0x400E910")]
      [FieldOffset(Offset = "0x10")]
      public JSON_DuelRankData my_rank;
      [Token(Token = "0x400E911")]
      [FieldOffset(Offset = "0x14")]
      public int bp;
      [Token(Token = "0x400E912")]
      [FieldOffset(Offset = "0x18")]
      public long last_btl_at;
      [Token(Token = "0x400E913")]
      [FieldOffset(Offset = "0x20")]
      public int seed;
      [Token(Token = "0x400E914")]
      [FieldOffset(Offset = "0x24")]
      public int maxActionNum;
      [Token(Token = "0x400E915")]
      [FieldOffset(Offset = "0x28")]
      public JSON_ShopListArray.Shops shop;
      [Token(Token = "0x400E916")]
      [FieldOffset(Offset = "0x2C")]
      public string shop_name_prefix;
      [Token(Token = "0x400E917")]
      [FieldOffset(Offset = "0x30")]
      public string[] today_duel_fuids;
      [Token(Token = "0x400E918")]
      [FieldOffset(Offset = "0x34")]
      public Json_InvalidSkill[] invalid_units;
      [Token(Token = "0x400E919")]
      [FieldOffset(Offset = "0x38")]
      public Json_DuelBattleRecode battle_record;

      [Token(Token = "0x600DB1F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

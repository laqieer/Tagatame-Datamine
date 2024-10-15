// Decompiled with JetBrains decompiler
// Type: SRPG.ReqLeagueMatchTop
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
  [Token(Token = "0x2002F5D")]
  public class ReqLeagueMatchTop : WebAPI
  {
    [Token(Token = "0x600DBB0")]
    [Address(RVA = "0xA76830", Offset = "0xA75630", VA = "0x10A76830")]
    public ReqLeagueMatchTop(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002F5E")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EA16")]
      [FieldOffset(Offset = "0x8")]
      public int status;
      [Token(Token = "0x400EA17")]
      [FieldOffset(Offset = "0xC")]
      public JSON_LeagueMatchMyInfo my_info;
      [Token(Token = "0x400EA18")]
      [FieldOffset(Offset = "0x10")]
      public JSON_LeagueMatchDefenseFixInfo defense_fix_info;
      [Token(Token = "0x400EA19")]
      [FieldOffset(Offset = "0x14")]
      public JSON_LeagueMatchDefenseInfo defense_info;
      [Token(Token = "0x400EA1A")]
      [FieldOffset(Offset = "0x18")]
      public JSON_LeagueMatchOffenseinfo offense_info;
      [Token(Token = "0x400EA1B")]
      [FieldOffset(Offset = "0x1C")]
      public long[] used_units;
      [Token(Token = "0x400EA1C")]
      [FieldOffset(Offset = "0x20")]
      public long[] used_cards;
      [Token(Token = "0x400EA1D")]
      [FieldOffset(Offset = "0x24")]
      public long[] used_artifacts;
      [Token(Token = "0x400EA1E")]
      [FieldOffset(Offset = "0x28")]
      public long[] used_runes;
      [Token(Token = "0x400EA1F")]
      [FieldOffset(Offset = "0x2C")]
      public long[] used_crystals;
      [Token(Token = "0x400EA20")]
      [FieldOffset(Offset = "0x30")]
      public JSON_ShopListArray.Shops shop;
      [Token(Token = "0x400EA21")]
      [FieldOffset(Offset = "0x34")]
      public JSON_LeagueMatchResultBefore result_before;
      [Token(Token = "0x400EA22")]
      [FieldOffset(Offset = "0x38")]
      public int season_id;
      [Token(Token = "0x400EA23")]
      [FieldOffset(Offset = "0x3C")]
      public JSON_LeagueMatchShamInfo defense_sham_info;
      [Token(Token = "0x400EA24")]
      [FieldOffset(Offset = "0x40")]
      public JSON_LeagueMatchMission[] missions;

      [Token(Token = "0x600DBB1")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }

    [Token(Token = "0x2002F5F")]
    [MessagePackObject(true)]
    [Serializable]
    public class LeagueMatchTopResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400EA25")]
      [FieldOffset(Offset = "0x28")]
      public ReqLeagueMatchTop.Response body;

      [Token(Token = "0x600DBB2")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public LeagueMatchTopResponse()
      {
      }
    }
  }
}

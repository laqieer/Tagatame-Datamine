// Decompiled with JetBrains decompiler
// Type: SRPG.ReqLeagueMatchOffense
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
  [Token(Token = "0x2002F6C")]
  public class ReqLeagueMatchOffense : WebAPI
  {
    [Token(Token = "0x600DBBF")]
    [Address(RVA = "0xA76280", Offset = "0xA75080", VA = "0x10A76280")]
    public ReqLeagueMatchOffense(
      ReqLeagueMatchOffense.RequestParam param,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002F6D")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EA32")]
      [FieldOffset(Offset = "0x8")]
      public int party_no;
      [Token(Token = "0x400EA33")]
      [FieldOffset(Offset = "0xC")]
      public long[] units;

      [Token(Token = "0x600DBC0")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002F6E")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EA34")]
      [FieldOffset(Offset = "0x8")]
      public JSON_LeagueMatchParties[] parties;
      [Token(Token = "0x400EA35")]
      [FieldOffset(Offset = "0xC")]
      public JSON_PartyOverWrite[] party_decks;
      [Token(Token = "0x400EA36")]
      [FieldOffset(Offset = "0x10")]
      public Json_InvalidSkill[] invalid_units;

      [Token(Token = "0x600DBC1")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }

    [Token(Token = "0x2002F6F")]
    [MessagePackObject(true)]
    [Serializable]
    public class ReqLeagueMatchOffenseResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400EA37")]
      [FieldOffset(Offset = "0x28")]
      public ReqLeagueMatchOffense.Response body;

      [Token(Token = "0x600DBC2")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ReqLeagueMatchOffenseResponse()
      {
      }
    }
  }
}

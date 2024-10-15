// Decompiled with JetBrains decompiler
// Type: SRPG.ReqLeagueMatchParty
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
  [Token(Token = "0x2002F70")]
  public class ReqLeagueMatchParty : WebAPI
  {
    [Token(Token = "0x600DBC3")]
    [Address(RVA = "0xA765C0", Offset = "0xA753C0", VA = "0x10A765C0")]
    public ReqLeagueMatchParty(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002F71")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EA38")]
      [FieldOffset(Offset = "0x8")]
      public JSON_LeagueMatchPresetPartyUnits[] parties;
      [Token(Token = "0x400EA39")]
      [FieldOffset(Offset = "0xC")]
      public JSON_PartyOverWrite[] party_decks;
      [Token(Token = "0x400EA3A")]
      [FieldOffset(Offset = "0x10")]
      public Json_InvalidSkill[] invalid_units;

      [Token(Token = "0x600DBC4")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }

    [Token(Token = "0x2002F72")]
    [MessagePackObject(true)]
    [Serializable]
    public class ReqLeagueMatchPartyResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400EA3B")]
      [FieldOffset(Offset = "0x28")]
      public ReqLeagueMatchParty.Response body;

      [Token(Token = "0x600DBC5")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ReqLeagueMatchPartyResponse()
      {
      }
    }
  }
}

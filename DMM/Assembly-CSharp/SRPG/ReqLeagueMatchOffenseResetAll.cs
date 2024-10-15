// Decompiled with JetBrains decompiler
// Type: SRPG.ReqLeagueMatchOffenseResetAll
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
  [Token(Token = "0x2002F93")]
  public class ReqLeagueMatchOffenseResetAll : WebAPI
  {
    [Token(Token = "0x600DBE6")]
    [Address(RVA = "0xA761B0", Offset = "0xA74FB0", VA = "0x10A761B0")]
    public ReqLeagueMatchOffenseResetAll(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002F94")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EA5E")]
      [FieldOffset(Offset = "0x8")]
      public JSON_LeagueMatchParties[] parties;
      [Token(Token = "0x400EA5F")]
      [FieldOffset(Offset = "0xC")]
      public JSON_PartyOverWrite[] party_decks;
      [Token(Token = "0x400EA60")]
      [FieldOffset(Offset = "0x10")]
      public Json_InvalidSkill[] invalid_units;

      [Token(Token = "0x600DBE7")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }

    [Token(Token = "0x2002F95")]
    [MessagePackObject(true)]
    [Serializable]
    public class ReqLeagueMatchOffenseResetAllResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400EA61")]
      [FieldOffset(Offset = "0x28")]
      public ReqLeagueMatchOffenseResetAll.Response body;

      [Token(Token = "0x600DBE8")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ReqLeagueMatchOffenseResetAllResponse()
      {
      }
    }
  }
}

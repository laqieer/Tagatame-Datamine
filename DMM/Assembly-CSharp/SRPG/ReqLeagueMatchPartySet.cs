// Decompiled with JetBrains decompiler
// Type: SRPG.ReqLeagueMatchPartySet
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
  [Token(Token = "0x2002F73")]
  public class ReqLeagueMatchPartySet : WebAPI
  {
    [Token(Token = "0x600DBC6")]
    [Address(RVA = "0xA764F0", Offset = "0xA752F0", VA = "0x10A764F0")]
    public ReqLeagueMatchPartySet(
      ReqLeagueMatchPartySet.RequestParam param,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002F74")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EA3C")]
      [FieldOffset(Offset = "0x8")]
      public int party_no;
      [Token(Token = "0x400EA3D")]
      [FieldOffset(Offset = "0xC")]
      public long[] units;

      [Token(Token = "0x600DBC7")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002F75")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EA3E")]
      [FieldOffset(Offset = "0x8")]
      public JSON_LeagueMatchPresetPartyUnits[] parties;
      [Token(Token = "0x400EA3F")]
      [FieldOffset(Offset = "0xC")]
      public JSON_PartyOverWrite[] party_decks;
      [Token(Token = "0x400EA40")]
      [FieldOffset(Offset = "0x10")]
      public Json_InvalidSkill[] invalid_units;

      [Token(Token = "0x600DBC8")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }

    [Token(Token = "0x2002F76")]
    [MessagePackObject(true)]
    [Serializable]
    public class ReqLeagueMatchPartySetResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400EA41")]
      [FieldOffset(Offset = "0x28")]
      public ReqLeagueMatchPartySet.Response body;

      [Token(Token = "0x600DBC9")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ReqLeagueMatchPartySetResponse()
      {
      }
    }
  }
}

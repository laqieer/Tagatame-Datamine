// Decompiled with JetBrains decompiler
// Type: SRPG.ReqLeagueMatchReward
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
  [Token(Token = "0x2002F80")]
  public class ReqLeagueMatchReward : WebAPI
  {
    [Token(Token = "0x600DBD3")]
    [Address(RVA = "0xA76760", Offset = "0xA75560", VA = "0x10A76760")]
    public ReqLeagueMatchReward(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002F81")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EA4B")]
      [FieldOffset(Offset = "0x8")]
      public JSON_LeagueMatchDefenseReward defense;
      [Token(Token = "0x400EA4C")]
      [FieldOffset(Offset = "0xC")]
      public JSON_LeagueMatchSeasonReward season;

      [Token(Token = "0x600DBD4")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }

    [Token(Token = "0x2002F82")]
    [MessagePackObject(true)]
    [Serializable]
    public class ReqLeagueMatchRewardResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400EA4D")]
      [FieldOffset(Offset = "0x28")]
      public ReqLeagueMatchReward.Response body;

      [Token(Token = "0x600DBD5")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ReqLeagueMatchRewardResponse()
      {
      }
    }
  }
}

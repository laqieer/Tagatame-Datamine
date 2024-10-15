// Decompiled with JetBrains decompiler
// Type: SRPG.ReqCombatPowerPlayerRanking
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
  [Token(Token = "0x2002E8E")]
  public class ReqCombatPowerPlayerRanking : WebAPI
  {
    [Token(Token = "0x600DAD5")]
    [Address(RVA = "0xA6DDB0", Offset = "0xA6CBB0", VA = "0x10A6DDB0")]
    public ReqCombatPowerPlayerRanking(
      ReqCombatPowerPlayerRanking.Request _param,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2002E8F")]
    [MessagePackObject(true)]
    [Serializable]
    public class ReqCombatPowerPlayerRankingResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400E8BF")]
      [FieldOffset(Offset = "0x28")]
      public ReqCombatPowerPlayerRanking.Response body;

      [Token(Token = "0x600DAD6")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ReqCombatPowerPlayerRankingResponse()
      {
      }
    }

    [Token(Token = "0x2002E90")]
    [Serializable]
    public class Request
    {
      [Token(Token = "0x400E8C0")]
      [FieldOffset(Offset = "0x8")]
      public string unit_iname;
      [Token(Token = "0x400E8C1")]
      [FieldOffset(Offset = "0xC")]
      public int page;

      [Token(Token = "0x600DAD7")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Request()
      {
      }
    }

    [Token(Token = "0x2002E91")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E8C2")]
      [FieldOffset(Offset = "0x8")]
      public JSON_CombatPowerPlayerRanking[] ranking;
      [Token(Token = "0x400E8C3")]
      [FieldOffset(Offset = "0xC")]
      public JSON_CombatPowerPlayerRanking my_ranking;
      [Token(Token = "0x400E8C4")]
      [FieldOffset(Offset = "0x10")]
      public int max_page;

      [Token(Token = "0x600DAD8")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

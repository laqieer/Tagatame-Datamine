// Decompiled with JetBrains decompiler
// Type: SRPG.ReqCombatPowerPortRanking
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
  [Token(Token = "0x2002E92")]
  public class ReqCombatPowerPortRanking : WebAPI
  {
    [Token(Token = "0x600DAD9")]
    [Address(RVA = "0xA6DE80", Offset = "0xA6CC80", VA = "0x10A6DE80")]
    public ReqCombatPowerPortRanking(
      ReqCombatPowerPortRanking.Request _param,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2002E93")]
    [MessagePackObject(true)]
    [Serializable]
    public class ReqCombatPowerPortRankingResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400E8C5")]
      [FieldOffset(Offset = "0x28")]
      public ReqCombatPowerPortRanking.Response body;

      [Token(Token = "0x600DADA")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ReqCombatPowerPortRankingResponse()
      {
      }
    }

    [Token(Token = "0x2002E94")]
    [Serializable]
    public class Request
    {
      [Token(Token = "0x400E8C6")]
      [FieldOffset(Offset = "0x8")]
      public int page;

      [Token(Token = "0x600DADB")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Request()
      {
      }
    }

    [Token(Token = "0x2002E95")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E8C7")]
      [FieldOffset(Offset = "0x8")]
      public JSON_CombatPowerPortRanking[] ranking;
      [Token(Token = "0x400E8C8")]
      [FieldOffset(Offset = "0xC")]
      public JSON_CombatPowerPortRanking self_ranking;
      [Token(Token = "0x400E8C9")]
      [FieldOffset(Offset = "0x10")]
      public int max_page;

      [Token(Token = "0x600DADC")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

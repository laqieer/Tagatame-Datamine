// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildRanking
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
  [Token(Token = "0x2002E83")]
  public class ReqGuildRanking : WebAPI
  {
    [Token(Token = "0x600DACA")]
    [Address(RVA = "0xA73F80", Offset = "0xA72D80", VA = "0x10A73F80")]
    public ReqGuildRanking(
      int gid,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2002E84")]
    [Serializable]
    public class Request
    {
      [Token(Token = "0x400E8B1")]
      [FieldOffset(Offset = "0x8")]
      public int gid;

      [Token(Token = "0x600DACB")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Request()
      {
      }
    }

    [Token(Token = "0x2002E85")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E8B2")]
      [FieldOffset(Offset = "0x8")]
      public JSON_CombatPowerRankingViewGuild self_rank;
      [Token(Token = "0x400E8B3")]
      [FieldOffset(Offset = "0xC")]
      public JSON_CombatPowerRankingViewGuild[] ranking;

      [Token(Token = "0x600DACC")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

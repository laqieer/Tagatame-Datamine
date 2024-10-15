// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildRaidRankingDamageRound
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
  [Token(Token = "0x2002F36")]
  public class ReqGuildRaidRankingDamageRound : WebAPI
  {
    [Token(Token = "0x600DB87")]
    [Address(RVA = "0xA729B0", Offset = "0xA717B0", VA = "0x10A729B0")]
    public ReqGuildRaidRankingDamageRound(
      int gid,
      int boss_id,
      int round,
      int page,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2002F37")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E9DD")]
      [FieldOffset(Offset = "0x8")]
      public int gid;
      [Token(Token = "0x400E9DE")]
      [FieldOffset(Offset = "0xC")]
      public int boss_id;
      [Token(Token = "0x400E9DF")]
      [FieldOffset(Offset = "0x10")]
      public int round;
      [Token(Token = "0x400E9E0")]
      [FieldOffset(Offset = "0x14")]
      public int page;

      [Token(Token = "0x600DB88")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002F38")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E9E1")]
      [FieldOffset(Offset = "0x8")]
      public JSON_GuildRaidRankingDamage[] ranking_damage;
      [Token(Token = "0x400E9E2")]
      [FieldOffset(Offset = "0xC")]
      public int totalPage;

      [Token(Token = "0x600DB89")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildRaidRankingDamageSummary
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
  [Token(Token = "0x2002F33")]
  public class ReqGuildRaidRankingDamageSummary : WebAPI
  {
    [Token(Token = "0x600DB84")]
    [Address(RVA = "0xA72AD0", Offset = "0xA718D0", VA = "0x10A72AD0")]
    public ReqGuildRaidRankingDamageSummary(
      int gid,
      int page,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2002F34")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E9D9")]
      [FieldOffset(Offset = "0x8")]
      public int gid;
      [Token(Token = "0x400E9DA")]
      [FieldOffset(Offset = "0xC")]
      public int page;

      [Token(Token = "0x600DB85")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002F35")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E9DB")]
      [FieldOffset(Offset = "0x8")]
      public JSON_GuildRaidRankingDamage[] ranking_damage;
      [Token(Token = "0x400E9DC")]
      [FieldOffset(Offset = "0xC")]
      public int totalPage;

      [Token(Token = "0x600DB86")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

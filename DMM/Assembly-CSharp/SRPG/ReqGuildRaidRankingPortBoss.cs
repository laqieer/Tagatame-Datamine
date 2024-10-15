// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildRaidRankingPortBoss
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
  [Token(Token = "0x2002F30")]
  public class ReqGuildRaidRankingPortBoss : WebAPI
  {
    [Token(Token = "0x600DB81")]
    [Address(RVA = "0xA72BE0", Offset = "0xA719E0", VA = "0x10A72BE0")]
    public ReqGuildRaidRankingPortBoss(
      int gid,
      int page,
      int boss_id,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2002F31")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E9D4")]
      [FieldOffset(Offset = "0x8")]
      public int gid;
      [Token(Token = "0x400E9D5")]
      [FieldOffset(Offset = "0xC")]
      public int page;
      [Token(Token = "0x400E9D6")]
      [FieldOffset(Offset = "0x10")]
      public int boss_id;

      [Token(Token = "0x600DB82")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002F32")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E9D7")]
      [FieldOffset(Offset = "0x8")]
      public JSON_GuildRaidRankingMember[] ranking_port_boss;
      [Token(Token = "0x400E9D8")]
      [FieldOffset(Offset = "0xC")]
      public int totalPage;

      [Token(Token = "0x600DB83")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

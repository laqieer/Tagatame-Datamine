// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildRaidRankingPort
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
  [Token(Token = "0x2002F2D")]
  public class ReqGuildRaidRankingPort : WebAPI
  {
    [Token(Token = "0x600DB7E")]
    [Address(RVA = "0xA72CF0", Offset = "0xA71AF0", VA = "0x10A72CF0")]
    public ReqGuildRaidRankingPort(
      int gid,
      int page,
      GuildRaidManager.GuildRaidRankingType type,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2002F2E")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E9CF")]
      [FieldOffset(Offset = "0x8")]
      public int gid;
      [Token(Token = "0x400E9D0")]
      [FieldOffset(Offset = "0xC")]
      public int page;

      [Token(Token = "0x600DB7F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002F2F")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E9D1")]
      [FieldOffset(Offset = "0x8")]
      public JSON_GuildRaidRankingMember[] ranking_port;
      [Token(Token = "0x400E9D2")]
      [FieldOffset(Offset = "0xC")]
      public JSON_GuildRaidRankingMember my_info;
      [Token(Token = "0x400E9D3")]
      [FieldOffset(Offset = "0x10")]
      public int totalPage;

      [Token(Token = "0x600DB80")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

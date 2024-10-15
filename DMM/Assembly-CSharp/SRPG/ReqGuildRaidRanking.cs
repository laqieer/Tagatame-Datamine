// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildRaidRanking
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
  [Token(Token = "0x2002F2A")]
  public class ReqGuildRaidRanking : WebAPI
  {
    [Token(Token = "0x600DB7B")]
    [Address(RVA = "0xA72F10", Offset = "0xA71D10", VA = "0x10A72F10")]
    public ReqGuildRaidRanking(
      int gid,
      int page,
      GuildRaidManager.GuildRaidRankingType type,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2002F2B")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E9CA")]
      [FieldOffset(Offset = "0x8")]
      public int gid;
      [Token(Token = "0x400E9CB")]
      [FieldOffset(Offset = "0xC")]
      public int page;

      [Token(Token = "0x600DB7C")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002F2C")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E9CC")]
      [FieldOffset(Offset = "0x8")]
      public JSON_GuildRaidRanking[] ranking;
      [Token(Token = "0x400E9CD")]
      [FieldOffset(Offset = "0xC")]
      public JSON_GuildRaidRanking my_info;
      [Token(Token = "0x400E9CE")]
      [FieldOffset(Offset = "0x10")]
      public int totalPage;

      [Token(Token = "0x600DB7D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

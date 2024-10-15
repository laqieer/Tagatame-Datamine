// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGvGLeague
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
  [Token(Token = "0x2003286")]
  public class ReqGvGLeague : WebAPI
  {
    [Token(Token = "0x600DF27")]
    [Address(RVA = "0xA996A0", Offset = "0xA984A0", VA = "0x10A996A0")]
    public ReqGvGLeague(
      string league_id,
      int gid,
      int taret_rank,
      int limit,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2003287")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EF09")]
      [FieldOffset(Offset = "0x8")]
      public string league_id;
      [Token(Token = "0x400EF0A")]
      [FieldOffset(Offset = "0xC")]
      public int gid;
      [Token(Token = "0x400EF0B")]
      [FieldOffset(Offset = "0x10")]
      public int target_rank;
      [Token(Token = "0x400EF0C")]
      [FieldOffset(Offset = "0x14")]
      public int limit;

      [Token(Token = "0x600DF28")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003288")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EF0D")]
      [FieldOffset(Offset = "0x8")]
      public JSON_GvGLeagueViewGuild[] guilds;
      [Token(Token = "0x400EF0E")]
      [FieldOffset(Offset = "0xC")]
      public int total_count;
      [Token(Token = "0x400EF0F")]
      [FieldOffset(Offset = "0x10")]
      public JSON_GvGLeagueData my_league;

      [Token(Token = "0x600DF29")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

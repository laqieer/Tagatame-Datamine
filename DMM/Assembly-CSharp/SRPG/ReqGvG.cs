// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGvG
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
  [Token(Token = "0x200325D")]
  public class ReqGvG : WebAPI
  {
    [Token(Token = "0x600DEFE")]
    [Address(RVA = "0xA99FB0", Offset = "0xA98DB0", VA = "0x10A99FB0")]
    public ReqGvG(
      int gid,
      int gvg_group_id,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x200325E")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EE96")]
      [FieldOffset(Offset = "0x8")]
      public int gid;
      [Token(Token = "0x400EE97")]
      [FieldOffset(Offset = "0xC")]
      public int gvg_group_id;

      [Token(Token = "0x600DEFF")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x200325F")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EE98")]
      [FieldOffset(Offset = "0x8")]
      public JSON_GvGNodeData[] nodes;
      [Token(Token = "0x400EE99")]
      [FieldOffset(Offset = "0xC")]
      public int[] matching_order;
      [Token(Token = "0x400EE9A")]
      [FieldOffset(Offset = "0x10")]
      public JSON_GvGLeagueViewGuild[] guilds;
      [Token(Token = "0x400EE9B")]
      [FieldOffset(Offset = "0x14")]
      public JSON_GvGLeagueViewGuild my_guild;
      [Token(Token = "0x400EE9C")]
      [FieldOffset(Offset = "0x18")]
      public JSON_GvGUsedUnitData[] used_units;
      [Token(Token = "0x400EE9D")]
      [FieldOffset(Offset = "0x1C")]
      public int declare_num;
      [Token(Token = "0x400EE9E")]
      [FieldOffset(Offset = "0x20")]
      public int refresh_wait_sec;
      [Token(Token = "0x400EE9F")]
      [FieldOffset(Offset = "0x24")]
      public int auto_refresh_wait_sec;
      [Token(Token = "0x400EEA0")]
      [FieldOffset(Offset = "0x28")]
      public int declare_cool_time;
      [Token(Token = "0x400EEA1")]
      [FieldOffset(Offset = "0x2C")]
      public JSON_GvGResult result_daily;
      [Token(Token = "0x400EEA2")]
      [FieldOffset(Offset = "0x30")]
      public JSON_GvGResult result;
      [Token(Token = "0x400EEA3")]
      [FieldOffset(Offset = "0x34")]
      public JSON_GvGLeagueResult my_league;
      [Token(Token = "0x400EEA4")]
      [FieldOffset(Offset = "0x38")]
      public int[] used_cards;
      [Token(Token = "0x400EEA5")]
      [FieldOffset(Offset = "0x3C")]
      public int[] used_artifacts;
      [Token(Token = "0x400EEA6")]
      [FieldOffset(Offset = "0x40")]
      public int[] used_runes;
      [Token(Token = "0x400EEA7")]
      [FieldOffset(Offset = "0x44")]
      public long[] used_crystals;

      [Token(Token = "0x600DF00")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

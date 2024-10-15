// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildRaid
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
  [Token(Token = "0x2002F1A")]
  public class ReqGuildRaid : WebAPI
  {
    [Token(Token = "0x600DB69")]
    [Address(RVA = "0xA73D80", Offset = "0xA72B80", VA = "0x10A73D80")]
    public ReqGuildRaid(
      int gid,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2002F1B")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E9A3")]
      [FieldOffset(Offset = "0x8")]
      public int gid;

      [Token(Token = "0x600DB6A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002F1C")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E9A4")]
      [FieldOffset(Offset = "0x8")]
      public JSON_GuildFacilityData[] facilities;
      [Token(Token = "0x400E9A5")]
      [FieldOffset(Offset = "0xC")]
      public JSON_GuildRaidPrev prev;
      [Token(Token = "0x400E9A6")]
      [FieldOffset(Offset = "0x10")]
      public JSON_GuildRaidCurrent current;
      [Token(Token = "0x400E9A7")]
      [FieldOffset(Offset = "0x14")]
      public JSON_GuildRaidBattlePoint bp;
      [Token(Token = "0x400E9A8")]
      [FieldOffset(Offset = "0x18")]
      public JSON_GuildRaidBossInfo[] boss_info;
      [Token(Token = "0x400E9A9")]
      [FieldOffset(Offset = "0x1C")]
      public int refresh_wait_sec;
      [Token(Token = "0x400E9AA")]
      [FieldOffset(Offset = "0x20")]
      public int receive_mail_count;
      [Token(Token = "0x400E9AB")]
      [FieldOffset(Offset = "0x24")]
      public string[] selected_units;
      [Token(Token = "0x400E9AC")]
      [FieldOffset(Offset = "0x28")]
      public JSON_GuildRaidDeck forced_deck;
      [Token(Token = "0x400E9AD")]
      [FieldOffset(Offset = "0x2C")]
      public int ranking;
      [Token(Token = "0x400E9AE")]
      [FieldOffset(Offset = "0x30")]
      public JSON_GuildRaidBattleLog battle_log;

      [Token(Token = "0x600DB6B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

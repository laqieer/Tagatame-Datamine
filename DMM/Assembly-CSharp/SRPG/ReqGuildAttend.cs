// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildAttend
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
  [Token(Token = "0x2002F07")]
  public class ReqGuildAttend : WebAPI
  {
    [Token(Token = "0x600DB53")]
    [Address(RVA = "0xA70810", Offset = "0xA6F610", VA = "0x10A70810")]
    public ReqGuildAttend(
      ReqGuildAttend.RequestParam rp,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2002F08")]
    [MessagePackObject(true)]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E96D")]
      [FieldOffset(Offset = "0x8")]
      public long gid;

      [Token(Token = "0x600DB54")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }

      [Token(Token = "0x600DB55")]
      [Address(RVA = "0xA7DDA0", Offset = "0xA7CBA0", VA = "0x10A7DDA0")]
      public RequestParam(long guild_id)
      {
      }
    }

    [Token(Token = "0x2002F09")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E96E")]
      [FieldOffset(Offset = "0x8")]
      public int yesterday_attendance;
      [Token(Token = "0x400E96F")]
      [FieldOffset(Offset = "0xC")]
      public string[] attend_guild_member_uids;
      [Token(Token = "0x400E970")]
      [FieldOffset(Offset = "0x10")]
      public int status;
      [Token(Token = "0x400E971")]
      [FieldOffset(Offset = "0x14")]
      public JSON_GuildAttendReward[] rewards;
      [Token(Token = "0x400E972")]
      [FieldOffset(Offset = "0x18")]
      public Json_PlayerData player;
      [Token(Token = "0x400E973")]
      [FieldOffset(Offset = "0x1C")]
      public Json_Item[] items;
      [Token(Token = "0x400E974")]
      [FieldOffset(Offset = "0x20")]
      public JSON_ConceptCard[] cards;
      [Token(Token = "0x400E975")]
      [FieldOffset(Offset = "0x24")]
      public Json_RuneData[] runes;
      [Token(Token = "0x400E976")]
      [FieldOffset(Offset = "0x28")]
      public int rune_storage_used;
      [Token(Token = "0x400E977")]
      [FieldOffset(Offset = "0x2C")]
      public JSON_TrophyProgress[] guild_trophies;

      [Token(Token = "0x600DB56")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildRaidMailRead
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
  [Token(Token = "0x2002F46")]
  public class ReqGuildRaidMailRead : WebAPI
  {
    [Token(Token = "0x600DB97")]
    [Address(RVA = "0xA72780", Offset = "0xA71580", VA = "0x10A72780")]
    public ReqGuildRaidMailRead(
      int[] mailids,
      int page,
      int gid,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2002F47")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E9F3")]
      [FieldOffset(Offset = "0x8")]
      public int[] mailids;
      [Token(Token = "0x400E9F4")]
      [FieldOffset(Offset = "0xC")]
      public int page;
      [Token(Token = "0x400E9F5")]
      [FieldOffset(Offset = "0x10")]
      public int gid;

      [Token(Token = "0x600DB98")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002F48")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E9F6")]
      [FieldOffset(Offset = "0x8")]
      public JSON_GuildRaidMail mails;
      [Token(Token = "0x400E9F7")]
      [FieldOffset(Offset = "0xC")]
      public JSON_GuildRaidMailListItem[] processed;
      [Token(Token = "0x400E9F8")]
      [FieldOffset(Offset = "0x10")]
      public JSON_TrophyProgress[] trophyprogs;
      [Token(Token = "0x400E9F9")]
      [FieldOffset(Offset = "0x14")]
      public JSON_TrophyProgress[] bingoprogs;
      [Token(Token = "0x400E9FA")]
      [FieldOffset(Offset = "0x18")]
      public Json_PlayerData player;
      [Token(Token = "0x400E9FB")]
      [FieldOffset(Offset = "0x1C")]
      public Json_Item[] items;
      [Token(Token = "0x400E9FC")]
      [FieldOffset(Offset = "0x20")]
      public Json_Unit[] units;
      [Token(Token = "0x400E9FD")]
      [FieldOffset(Offset = "0x24")]
      public Json_Artifact[] artifacts;
      [Token(Token = "0x400E9FE")]
      [FieldOffset(Offset = "0x28")]
      public JSON_ConceptCard[] cards;
      [Token(Token = "0x400E9FF")]
      [FieldOffset(Offset = "0x2C")]
      public int[] gift_mailids;

      [Token(Token = "0x600DB99")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

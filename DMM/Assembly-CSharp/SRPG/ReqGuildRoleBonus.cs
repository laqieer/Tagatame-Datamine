// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGuildRoleBonus
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
  [Token(Token = "0x2002F0A")]
  public class ReqGuildRoleBonus : WebAPI
  {
    [Token(Token = "0x600DB57")]
    [Address(RVA = "0xA74530", Offset = "0xA73330", VA = "0x10A74530")]
    public ReqGuildRoleBonus(
      ReqGuildRoleBonus.RequestParam rp,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2002F0B")]
    [MessagePackObject(true)]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E978")]
      [FieldOffset(Offset = "0x8")]
      public long gid;

      [Token(Token = "0x600DB58")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }

      [Token(Token = "0x600DB59")]
      [Address(RVA = "0xA7DDA0", Offset = "0xA7CBA0", VA = "0x10A7DDA0")]
      public RequestParam(long guild_id)
      {
      }
    }

    [Token(Token = "0x2002F0C")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E979")]
      [FieldOffset(Offset = "0x8")]
      public JSON_GUildRoleBonusReward[] rewards;
      [Token(Token = "0x400E97A")]
      [FieldOffset(Offset = "0xC")]
      public int status;
      [Token(Token = "0x400E97B")]
      [FieldOffset(Offset = "0x10")]
      public Json_PlayerData player;
      [Token(Token = "0x400E97C")]
      [FieldOffset(Offset = "0x14")]
      public Json_Item[] items;
      [Token(Token = "0x400E97D")]
      [FieldOffset(Offset = "0x18")]
      public JSON_ConceptCard[] cards;
      [Token(Token = "0x400E97E")]
      [FieldOffset(Offset = "0x1C")]
      public Json_RuneData[] runes;
      [Token(Token = "0x400E97F")]
      [FieldOffset(Offset = "0x20")]
      public int rune_storage_used;

      [Token(Token = "0x600DB5A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

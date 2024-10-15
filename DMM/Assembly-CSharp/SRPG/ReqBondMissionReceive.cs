// Decompiled with JetBrains decompiler
// Type: SRPG.ReqBondMissionReceive
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
  [Token(Token = "0x20032B3")]
  public class ReqBondMissionReceive : WebAPI
  {
    [Token(Token = "0x600DF56")]
    [Address(RVA = "0xA93BE0", Offset = "0xA929E0", VA = "0x10A93BE0")]
    public ReqBondMissionReceive(
      string[] mission_inames,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x20032B4")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EF3E")]
      [FieldOffset(Offset = "0x8")]
      public string[] inames;

      [Token(Token = "0x600DF57")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x20032B5")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EF3F")]
      [FieldOffset(Offset = "0x8")]
      public JSON_BondMissionData[] missions;
      [Token(Token = "0x400EF40")]
      [FieldOffset(Offset = "0xC")]
      public Json_PlayerData player;
      [Token(Token = "0x400EF41")]
      [FieldOffset(Offset = "0x10")]
      public Json_Item[] items;
      [Token(Token = "0x400EF42")]
      [FieldOffset(Offset = "0x14")]
      public JSON_ConceptCard[] cards;
      [Token(Token = "0x400EF43")]
      [FieldOffset(Offset = "0x18")]
      public Json_RuneData[] runes_detail;
      [Token(Token = "0x400EF44")]
      [FieldOffset(Offset = "0x1C")]
      public int is_mail_cards;
      [Token(Token = "0x400EF45")]
      [FieldOffset(Offset = "0x20")]
      public int rune_storage_used;

      [Token(Token = "0x600DF58")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

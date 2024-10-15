// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRuneEnhance
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
  [Token(Token = "0x200300D")]
  public class ReqRuneEnhance : WebAPI
  {
    [Token(Token = "0x600DC68")]
    [Address(RVA = "0xA79F60", Offset = "0xA78D60", VA = "0x10A79F60")]
    public ReqRuneEnhance(
      ReqRuneEnhance.RequestParam rp,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x200300E")]
    [MessagePackObject(true)]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EB56")]
      [FieldOffset(Offset = "0x8")]
      public long rune_id;
      [Token(Token = "0x400EB57")]
      [FieldOffset(Offset = "0x10")]
      public int is_enforce_failure_gauge;

      [Token(Token = "0x600DC69")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }

      [Token(Token = "0x600DC6A")]
      [Address(RVA = "0xA7DD30", Offset = "0xA7CB30", VA = "0x10A7DD30")]
      public RequestParam(long _rune_id, int _is_enforce_failure_gauge = 0)
      {
      }
    }

    [Token(Token = "0x200300F")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EB58")]
      [FieldOffset(Offset = "0x8")]
      public Json_RuneData[] runes;
      [Token(Token = "0x400EB59")]
      [FieldOffset(Offset = "0xC")]
      public Json_Item[] items;
      [Token(Token = "0x400EB5A")]
      [FieldOffset(Offset = "0x10")]
      public Json_PlayerData player;
      [Token(Token = "0x400EB5B")]
      [FieldOffset(Offset = "0x14")]
      public Json_RuneEnforceGaugeData[] rune_enforce_gauge;
      [Token(Token = "0x400EB5C")]
      [FieldOffset(Offset = "0x18")]
      public int result;

      [Token(Token = "0x600DC6B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

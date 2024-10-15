// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGetRune
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
  [Token(Token = "0x2002FFE")]
  public class ReqGetRune : WebAPI
  {
    [Token(Token = "0x600DC54")]
    [Address(RVA = "0xA70570", Offset = "0xA6F370", VA = "0x10A70570")]
    public ReqGetRune(
      ReqGetRune.RequestParam rp,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2002FFF")]
    [MessagePackObject(true)]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EB40")]
      [FieldOffset(Offset = "0x8")]
      public long last_iid;

      [Token(Token = "0x600DC55")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }

      [Token(Token = "0x600DC56")]
      [Address(RVA = "0xA7DDA0", Offset = "0xA7CBA0", VA = "0x10A7DDA0")]
      public RequestParam(long _last_iid)
      {
      }
    }

    [Token(Token = "0x2003000")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EB41")]
      [FieldOffset(Offset = "0x8")]
      public Json_RuneData[] runes;
      [Token(Token = "0x400EB42")]
      [FieldOffset(Offset = "0xC")]
      public Json_RuneEnforceGaugeData[] rune_enforce_gauge;
      [Token(Token = "0x400EB43")]
      [FieldOffset(Offset = "0x10")]
      public int rune_storage;
      [Token(Token = "0x400EB44")]
      [FieldOffset(Offset = "0x14")]
      public int rune_storage_used;

      [Token(Token = "0x600DC57")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

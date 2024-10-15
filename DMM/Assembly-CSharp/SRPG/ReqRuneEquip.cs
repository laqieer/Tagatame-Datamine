// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRuneEquip
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
  [Token(Token = "0x2003001")]
  public class ReqRuneEquip : WebAPI
  {
    [Token(Token = "0x600DC58")]
    [Address(RVA = "0xA7A100", Offset = "0xA78F00", VA = "0x10A7A100")]
    public ReqRuneEquip(
      ReqRuneEquip.RequestParam rp,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2003002")]
    [MessagePackObject(true)]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EB45")]
      [FieldOffset(Offset = "0x8")]
      public long unit_id;
      [Token(Token = "0x400EB46")]
      [FieldOffset(Offset = "0x10")]
      public long[] rune_ids;

      [Token(Token = "0x600DC59")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }

      [Token(Token = "0x600DC5A")]
      [Address(RVA = "0xA7DDD0", Offset = "0xA7CBD0", VA = "0x10A7DDD0")]
      public RequestParam(long _unit_id, long[] _rune_ids)
      {
      }
    }

    [Token(Token = "0x2003003")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EB47")]
      [FieldOffset(Offset = "0x8")]
      public Json_Unit[] units;
      [Token(Token = "0x400EB48")]
      [FieldOffset(Offset = "0xC")]
      public int rune_storage_used;

      [Token(Token = "0x600DC5B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

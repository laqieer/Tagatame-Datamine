// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRuneEquip_OverWrite
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
  [Token(Token = "0x2003004")]
  public class ReqRuneEquip_OverWrite : WebAPI
  {
    [Token(Token = "0x600DC5C")]
    [Address(RVA = "0xA7A030", Offset = "0xA78E30", VA = "0x10A7A030")]
    public ReqRuneEquip_OverWrite(
      ReqRuneEquip_OverWrite.RequestParam rp,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2003005")]
    [MessagePackObject(true)]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EB49")]
      [FieldOffset(Offset = "0x8")]
      public long unit_iid;
      [Token(Token = "0x400EB4A")]
      [FieldOffset(Offset = "0x10")]
      public long[] rune_iids;
      [Token(Token = "0x400EB4B")]
      [FieldOffset(Offset = "0x14")]
      public string ptype;

      [Token(Token = "0x600DC5D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }

      [Token(Token = "0x600DC5E")]
      [Address(RVA = "0xA7DE00", Offset = "0xA7CC00", VA = "0x10A7DE00")]
      public RequestParam(long _unit_iid, long[] _rune_iids, string _ptype)
      {
      }
    }

    [Token(Token = "0x2003006")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EB4C")]
      [FieldOffset(Offset = "0x8")]
      public JSON_PartyOverWrite[] party_decks;

      [Token(Token = "0x600DC5F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

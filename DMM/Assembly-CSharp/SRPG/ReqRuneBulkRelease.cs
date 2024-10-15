// Decompiled with JetBrains decompiler
// Type: SRPG.ReqRuneBulkRelease
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
  [Token(Token = "0x2003007")]
  public class ReqRuneBulkRelease : WebAPI
  {
    [Token(Token = "0x600DC60")]
    [Address(RVA = "0xA79BD0", Offset = "0xA789D0", VA = "0x10A79BD0")]
    public ReqRuneBulkRelease(
      long rune_id,
      string[] ptypes,
      int is_common,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2003008")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EB4D")]
      [FieldOffset(Offset = "0x8")]
      public long rune_id;
      [Token(Token = "0x400EB4E")]
      [FieldOffset(Offset = "0x10")]
      public string[] ptypes;
      [Token(Token = "0x400EB4F")]
      [FieldOffset(Offset = "0x14")]
      public int is_cmn;

      [Token(Token = "0x600DC61")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }

      [Token(Token = "0x600DC62")]
      [Address(RVA = "0xA7DD60", Offset = "0xA7CB60", VA = "0x10A7DD60")]
      public RequestParam(long _rune_id, string[] _ptypes, int _is_common)
      {
      }
    }

    [Token(Token = "0x2003009")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EB50")]
      [FieldOffset(Offset = "0x8")]
      public JSON_PartyOverWrite[] party_decks;
      [Token(Token = "0x400EB51")]
      [FieldOffset(Offset = "0xC")]
      public Json_DifferenceUpdate difference_update;

      [Token(Token = "0x600DC63")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

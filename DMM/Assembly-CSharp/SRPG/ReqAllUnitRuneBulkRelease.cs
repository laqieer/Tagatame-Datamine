// Decompiled with JetBrains decompiler
// Type: SRPG.ReqAllUnitRuneBulkRelease
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
  [Token(Token = "0x200300A")]
  public class ReqAllUnitRuneBulkRelease : WebAPI
  {
    [Token(Token = "0x600DC64")]
    [Address(RVA = "0xA6BA90", Offset = "0xA6A890", VA = "0x10A6BA90")]
    public ReqAllUnitRuneBulkRelease(
      string[] ptypes,
      int is_common,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x200300B")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EB52")]
      [FieldOffset(Offset = "0x8")]
      public string[] ptypes;
      [Token(Token = "0x400EB53")]
      [FieldOffset(Offset = "0xC")]
      public int is_cmn;

      [Token(Token = "0x600DC65")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }

      [Token(Token = "0x600DC66")]
      [Address(RVA = "0x3217D0", Offset = "0x3205D0", VA = "0x103217D0")]
      public RequestParam(string[] _ptypes, int _is_common)
      {
      }
    }

    [Token(Token = "0x200300C")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EB54")]
      [FieldOffset(Offset = "0x8")]
      public JSON_PartyOverWrite[] party_decks;
      [Token(Token = "0x400EB55")]
      [FieldOffset(Offset = "0xC")]
      public Json_DifferenceUpdate difference_update;

      [Token(Token = "0x600DC67")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

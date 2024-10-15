// Decompiled with JetBrains decompiler
// Type: SRPG.ReqConceptSetOverWriteList
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
  [Token(Token = "0x2002F9A")]
  public class ReqConceptSetOverWriteList : WebAPI
  {
    [Token(Token = "0x600DBED")]
    [Address(RVA = "0xA6E330", Offset = "0xA6D130", VA = "0x10A6E330")]
    public ReqConceptSetOverWriteList(
      ReqConceptSetOverWriteList.RequestParam param,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002F9B")]
    [MessagePackObject(true)]
    [Serializable]
    public class RequestSetList
    {
      [Token(Token = "0x400EA6C")]
      [FieldOffset(Offset = "0x8")]
      public long[] concept_iids;
      [Token(Token = "0x400EA6D")]
      [FieldOffset(Offset = "0x10")]
      public long unit_iid;

      [Token(Token = "0x600DBEE")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestSetList()
      {
      }
    }

    [Token(Token = "0x2002F9C")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EA6E")]
      [FieldOffset(Offset = "0x8")]
      public ReqConceptSetOverWriteList.RequestSetList[] set_list;
      [Token(Token = "0x400EA6F")]
      [FieldOffset(Offset = "0xC")]
      public string ptype;

      [Token(Token = "0x600DBEF")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002F9D")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EA70")]
      [FieldOffset(Offset = "0x8")]
      public JSON_PartyOverWrite[] party_decks;

      [Token(Token = "0x600DBF0")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }

    [Token(Token = "0x2002F9E")]
    [MessagePackObject(true)]
    [Serializable]
    public class ReqConceptSetOverWriteResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400EA71")]
      [FieldOffset(Offset = "0x28")]
      public ReqConceptSetOverWriteList.Response body;

      [Token(Token = "0x600DBF1")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ReqConceptSetOverWriteResponse()
      {
      }
    }
  }
}

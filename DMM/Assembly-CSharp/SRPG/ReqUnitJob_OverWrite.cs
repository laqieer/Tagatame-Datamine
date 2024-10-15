// Decompiled with JetBrains decompiler
// Type: SRPG.ReqUnitJob_OverWrite
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
  [Token(Token = "0x20030BE")]
  public class ReqUnitJob_OverWrite : WebAPI
  {
    [Token(Token = "0x600DD43")]
    [Address(RVA = "0xA8C740", Offset = "0xA8B540", VA = "0x10A8C740")]
    public ReqUnitJob_OverWrite(
      long iid,
      long iid_job,
      eOverWritePartyType party_type,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x20030BF")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EC34")]
      [FieldOffset(Offset = "0x8")]
      public string ptype;
      [Token(Token = "0x400EC35")]
      [FieldOffset(Offset = "0x10")]
      public long iid;
      [Token(Token = "0x400EC36")]
      [FieldOffset(Offset = "0x18")]
      public long iid_job;

      [Token(Token = "0x600DD44")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x20030C0")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EC37")]
      [FieldOffset(Offset = "0x8")]
      public Json_PlayerData player;
      [Token(Token = "0x400EC38")]
      [FieldOffset(Offset = "0xC")]
      public JSON_PartyOverWrite[] party_decks;

      [Token(Token = "0x600DD45")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

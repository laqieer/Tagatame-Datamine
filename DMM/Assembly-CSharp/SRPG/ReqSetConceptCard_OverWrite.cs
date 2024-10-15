// Decompiled with JetBrains decompiler
// Type: SRPG.ReqSetConceptCard_OverWrite
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
  [Token(Token = "0x2002E99")]
  public class ReqSetConceptCard_OverWrite : WebAPI
  {
    [Token(Token = "0x600DAE3")]
    [Address(RVA = "0xA7B170", Offset = "0xA79F70", VA = "0x10A7B170")]
    public ReqSetConceptCard_OverWrite(
      long[] card_iids,
      long unit_iid,
      eOverWritePartyType party_type,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2002E9A")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E8CC")]
      [FieldOffset(Offset = "0x8")]
      public string ptype;
      [Token(Token = "0x400E8CD")]
      [FieldOffset(Offset = "0x10")]
      public long unit_iid;
      [Token(Token = "0x400E8CE")]
      [FieldOffset(Offset = "0x18")]
      public long[] concept_iids;

      [Token(Token = "0x600DAE4")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002E9B")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E8CF")]
      [FieldOffset(Offset = "0x8")]
      public Json_PlayerData player;
      [Token(Token = "0x400E8D0")]
      [FieldOffset(Offset = "0xC")]
      public JSON_PartyOverWrite[] party_decks;

      [Token(Token = "0x600DAE5")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

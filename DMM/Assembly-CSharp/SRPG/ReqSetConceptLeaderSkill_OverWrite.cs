// Decompiled with JetBrains decompiler
// Type: SRPG.ReqSetConceptLeaderSkill_OverWrite
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
  [Token(Token = "0x2002E9D")]
  public class ReqSetConceptLeaderSkill_OverWrite : WebAPI
  {
    [Token(Token = "0x600DAE7")]
    [Address(RVA = "0xA7B510", Offset = "0xA7A310", VA = "0x10A7B510")]
    public ReqSetConceptLeaderSkill_OverWrite(
      long unit_iid,
      bool set,
      eOverWritePartyType party_type,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2002E9E")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E8D1")]
      [FieldOffset(Offset = "0x8")]
      public string ptype;
      [Token(Token = "0x400E8D2")]
      [FieldOffset(Offset = "0x10")]
      public long unit_iid;
      [Token(Token = "0x400E8D3")]
      [FieldOffset(Offset = "0x18")]
      public int is_set;

      [Token(Token = "0x600DAE8")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002E9F")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E8D4")]
      [FieldOffset(Offset = "0x8")]
      public Json_PlayerData player;
      [Token(Token = "0x400E8D5")]
      [FieldOffset(Offset = "0xC")]
      public JSON_PartyOverWrite[] party_decks;

      [Token(Token = "0x600DAE9")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

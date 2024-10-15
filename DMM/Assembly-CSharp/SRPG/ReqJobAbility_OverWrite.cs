// Decompiled with JetBrains decompiler
// Type: SRPG.ReqJobAbility_OverWrite
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
  [Token(Token = "0x20030C5")]
  public class ReqJobAbility_OverWrite : WebAPI
  {
    [Token(Token = "0x600DD4A")]
    [Address(RVA = "0xA867D0", Offset = "0xA855D0", VA = "0x10A867D0")]
    public ReqJobAbility_OverWrite(
      long iid_job,
      long[] iid_abils,
      eOverWritePartyType party_type,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x20030C6")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EC39")]
      [FieldOffset(Offset = "0x8")]
      public string ptype;
      [Token(Token = "0x400EC3A")]
      [FieldOffset(Offset = "0x10")]
      public long iid;
      [Token(Token = "0x400EC3B")]
      [FieldOffset(Offset = "0x18")]
      public long[] iid_abils;

      [Token(Token = "0x600DD4B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x20030C7")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EC3C")]
      [FieldOffset(Offset = "0x8")]
      public Json_PlayerData player;
      [Token(Token = "0x400EC3D")]
      [FieldOffset(Offset = "0xC")]
      public JSON_PartyOverWrite[] party_decks;

      [Token(Token = "0x600DD4C")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.ReqArtifactSet_OverWrite
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
  [Token(Token = "0x2002E57")]
  public class ReqArtifactSet_OverWrite : WebAPI
  {
    [Token(Token = "0x600DA9D")]
    [Address(RVA = "0xA6C770", Offset = "0xA6B570", VA = "0x10A6C770")]
    public ReqArtifactSet_OverWrite(
      long iid_unit,
      long iid_job,
      long[] iid_artifact,
      eOverWritePartyType party_type,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2002E58")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E878")]
      [FieldOffset(Offset = "0x8")]
      public string ptype;
      [Token(Token = "0x400E879")]
      [FieldOffset(Offset = "0x10")]
      public long iid_unit;
      [Token(Token = "0x400E87A")]
      [FieldOffset(Offset = "0x18")]
      public long iid_job;
      [Token(Token = "0x400E87B")]
      [FieldOffset(Offset = "0x20")]
      public long[] iid_artifacts;

      [Token(Token = "0x600DA9E")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002E59")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E87C")]
      [FieldOffset(Offset = "0x8")]
      public Json_PlayerData player;
      [Token(Token = "0x400E87D")]
      [FieldOffset(Offset = "0xC")]
      public JSON_PartyOverWrite[] party_decks;

      [Token(Token = "0x600DA9F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

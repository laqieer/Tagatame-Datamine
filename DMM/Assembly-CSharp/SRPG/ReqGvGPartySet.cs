// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGvGPartySet
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
  [Token(Token = "0x200328B")]
  public class ReqGvGPartySet : WebAPI
  {
    [Token(Token = "0x600DF2C")]
    [Address(RVA = "0xA99CD0", Offset = "0xA98AD0", VA = "0x10A99CD0")]
    public ReqGvGPartySet(
      int party_no,
      long[] units,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x200328C")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400EF13")]
      [FieldOffset(Offset = "0x8")]
      public int party_no;
      [Token(Token = "0x400EF14")]
      [FieldOffset(Offset = "0xC")]
      public long[] units;

      [Token(Token = "0x600DF2D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x200328D")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EF15")]
      [FieldOffset(Offset = "0x8")]
      public JSON_GvGPresetPartyUnits[] parties;
      [Token(Token = "0x400EF16")]
      [FieldOffset(Offset = "0xC")]
      public JSON_PartyOverWrite[] party_decks;
      [Token(Token = "0x400EF17")]
      [FieldOffset(Offset = "0x10")]
      public Json_InvalidSkill[] invalid_units;

      [Token(Token = "0x600DF2E")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

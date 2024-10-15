// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGvGParty
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
  [Token(Token = "0x2003289")]
  public class ReqGvGParty : WebAPI
  {
    [Token(Token = "0x600DF2A")]
    [Address(RVA = "0xA99DB0", Offset = "0xA98BB0", VA = "0x10A99DB0")]
    public ReqGvGParty(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x200328A")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EF10")]
      [FieldOffset(Offset = "0x8")]
      public JSON_GvGPresetPartyUnits[] parties;
      [Token(Token = "0x400EF11")]
      [FieldOffset(Offset = "0xC")]
      public JSON_PartyOverWrite[] party_decks;
      [Token(Token = "0x400EF12")]
      [FieldOffset(Offset = "0x10")]
      public Json_InvalidSkill[] invalid_units;

      [Token(Token = "0x600DF2B")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

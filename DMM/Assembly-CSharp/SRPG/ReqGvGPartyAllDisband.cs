// Decompiled with JetBrains decompiler
// Type: SRPG.ReqGvGPartyAllDisband
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
  [Token(Token = "0x2003291")]
  public class ReqGvGPartyAllDisband : WebAPI
  {
    [Token(Token = "0x600DF32")]
    [Address(RVA = "0xA99B60", Offset = "0xA98960", VA = "0x10A99B60")]
    public ReqGvGPartyAllDisband(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x2003292")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EF1A")]
      [FieldOffset(Offset = "0x8")]
      public JSON_GvGPresetPartyUnits[] parties;
      [Token(Token = "0x400EF1B")]
      [FieldOffset(Offset = "0xC")]
      public JSON_PartyOverWrite[] party_decks;

      [Token(Token = "0x600DF33")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

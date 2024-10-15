// Decompiled with JetBrains decompiler
// Type: SRPG.ReqOverWriteParty
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
  [Token(Token = "0x20030D0")]
  public class ReqOverWriteParty : WebAPI
  {
    [Token(Token = "0x600DD55")]
    [Address(RVA = "0xA89910", Offset = "0xA88710", VA = "0x10A89910")]
    public ReqOverWriteParty(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod)
    {
    }

    [Token(Token = "0x20030D1")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EC42")]
      [FieldOffset(Offset = "0x8")]
      public JSON_PartyOverWrite[] party_decks;

      [Token(Token = "0x600DD56")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

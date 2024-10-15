// Decompiled with JetBrains decompiler
// Type: SRPG.ReqCrystalSetDeck
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
  [Token(Token = "0x2002EC4")]
  public class ReqCrystalSetDeck : WebAPI
  {
    [Token(Token = "0x600DB10")]
    [Address(RVA = "0xA6ECC0", Offset = "0xA6DAC0", VA = "0x10A6ECC0")]
    public ReqCrystalSetDeck(
      long _unit_iid,
      JSON_CrystalUnitSetReq[] _crystals,
      string _ptype,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002EC5")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E8FE")]
      [FieldOffset(Offset = "0x8")]
      public long unit_iid;
      [Token(Token = "0x400E8FF")]
      [FieldOffset(Offset = "0x10")]
      public JSON_CrystalUnitSetReq[] crystals;
      [Token(Token = "0x400E900")]
      [FieldOffset(Offset = "0x14")]
      public string ptype;

      [Token(Token = "0x600DB11")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002EC6")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E901")]
      [FieldOffset(Offset = "0x8")]
      public JSON_PartyOverWrite[] party_decks;

      [Token(Token = "0x600DB12")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

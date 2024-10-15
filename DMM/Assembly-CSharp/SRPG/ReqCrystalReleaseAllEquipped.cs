// Decompiled with JetBrains decompiler
// Type: SRPG.ReqCrystalReleaseAllEquipped
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
  [Token(Token = "0x2002ECA")]
  public class ReqCrystalReleaseAllEquipped : WebAPI
  {
    [Token(Token = "0x600DB16")]
    [Address(RVA = "0xA6E860", Offset = "0xA6D660", VA = "0x10A6E860")]
    public ReqCrystalReleaseAllEquipped(
      string[] _ptypes,
      int _is_cmn,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002ECB")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E907")]
      [FieldOffset(Offset = "0x8")]
      public string[] ptypes;
      [Token(Token = "0x400E908")]
      [FieldOffset(Offset = "0xC")]
      public int is_cmn;

      [Token(Token = "0x600DB17")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002ECC")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E909")]
      [FieldOffset(Offset = "0x8")]
      public JSON_PartyOverWrite[] party_decks;
      [Token(Token = "0x400E90A")]
      [FieldOffset(Offset = "0xC")]
      public Json_DifferenceUpdate difference_update;

      [Token(Token = "0x600DB18")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

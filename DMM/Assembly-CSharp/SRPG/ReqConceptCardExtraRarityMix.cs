// Decompiled with JetBrains decompiler
// Type: SRPG.ReqConceptCardExtraRarityMix
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
  [Token(Token = "0x2002EAB")]
  public class ReqConceptCardExtraRarityMix : WebAPI
  {
    [Token(Token = "0x600DAF7")]
    [Address(RVA = "0xA6E180", Offset = "0xA6CF80", VA = "0x10A6E180")]
    public ReqConceptCardExtraRarityMix(
      ReqConceptCardExtraRarityMix.Request _request,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002EAC")]
    [MessagePackObject(true)]
    [Serializable]
    public class ReqConceptCardExtraRarityMixResponse : WebAPI.JSON_BaseResponse
    {
      [Token(Token = "0x400E8DB")]
      [FieldOffset(Offset = "0x28")]
      public ReqConceptCardExtraRarityMix.Response body;

      [Token(Token = "0x600DAF8")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ReqConceptCardExtraRarityMixResponse()
      {
      }
    }

    [Token(Token = "0x2002EAD")]
    [Serializable]
    public class Request
    {
      [Token(Token = "0x400E8DC")]
      [FieldOffset(Offset = "0x8")]
      public long base_id;
      [Token(Token = "0x400E8DD")]
      [FieldOffset(Offset = "0x10")]
      public long[] mix_ids;

      [Token(Token = "0x600DAF9")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Request()
      {
      }
    }

    [Token(Token = "0x2002EAE")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E8DE")]
      [FieldOffset(Offset = "0x8")]
      public Json_DifferenceUpdatePlayerForConceptCard difference_update;
      [Token(Token = "0x400E8DF")]
      [FieldOffset(Offset = "0xC")]
      public long[] mix_ids;
      [Token(Token = "0x400E8E0")]
      [FieldOffset(Offset = "0x10")]
      public JSON_PartyOverWrite[] party_decks;
      [Token(Token = "0x400E8E1")]
      [FieldOffset(Offset = "0x14")]
      public JSON_TrophyProgress[] trophyprogs;

      [Token(Token = "0x600DAFA")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

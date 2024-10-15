// Decompiled with JetBrains decompiler
// Type: SRPG.ReqCrystalUpgrade
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
  [Token(Token = "0x2002EB2")]
  public class ReqCrystalUpgrade : WebAPI
  {
    [Token(Token = "0x600DAFE")]
    [Address(RVA = "0xA6EF10", Offset = "0xA6DD10", VA = "0x10A6EF10")]
    public ReqCrystalUpgrade(
      long _crystal_id,
      long[] _mats,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002EB3")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E8E4")]
      [FieldOffset(Offset = "0x8")]
      public long crystal_id;
      [Token(Token = "0x400E8E5")]
      [FieldOffset(Offset = "0x10")]
      public long[] mats;

      [Token(Token = "0x600DAFF")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002EB4")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E8E6")]
      [FieldOffset(Offset = "0x8")]
      public JSON_CrystalData base_crystal;
      [Token(Token = "0x400E8E7")]
      [FieldOffset(Offset = "0xC")]
      public Json_DifferenceUpdate difference_update;
      [Token(Token = "0x400E8E8")]
      [FieldOffset(Offset = "0x10")]
      public long[] material_ids;
      [Token(Token = "0x400E8E9")]
      [FieldOffset(Offset = "0x14")]
      public JSON_PartyOverWrite[] party_decks;

      [Token(Token = "0x600DB00")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

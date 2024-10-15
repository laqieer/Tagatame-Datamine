// Decompiled with JetBrains decompiler
// Type: SRPG.ReqCrystalBulkUpgrade
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
  [Token(Token = "0x2002EB5")]
  public class ReqCrystalBulkUpgrade : WebAPI
  {
    [Token(Token = "0x600DB01")]
    [Address(RVA = "0xA6E400", Offset = "0xA6D200", VA = "0x10A6E400")]
    public ReqCrystalBulkUpgrade(
      JSON_CrystalUpgrade[] _crystals,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002EB6")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E8EA")]
      [FieldOffset(Offset = "0x8")]
      public JSON_CrystalUpgrade[] crystals;

      [Token(Token = "0x600DB02")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002EB7")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E8EB")]
      [FieldOffset(Offset = "0x8")]
      public JSON_CrystalData[] base_crystals;
      [Token(Token = "0x400E8EC")]
      [FieldOffset(Offset = "0xC")]
      public Json_DifferenceUpdate difference_update;
      [Token(Token = "0x400E8ED")]
      [FieldOffset(Offset = "0x10")]
      public long[] material_ids;
      [Token(Token = "0x400E8EE")]
      [FieldOffset(Offset = "0x14")]
      public JSON_PartyOverWrite[] party_decks;

      [Token(Token = "0x600DB03")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

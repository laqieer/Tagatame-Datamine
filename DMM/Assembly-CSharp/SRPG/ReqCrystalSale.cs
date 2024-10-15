// Decompiled with JetBrains decompiler
// Type: SRPG.ReqCrystalSale
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
  [Token(Token = "0x2002EBB")]
  public class ReqCrystalSale : WebAPI
  {
    [Token(Token = "0x600DB07")]
    [Address(RVA = "0xA6EBB0", Offset = "0xA6D9B0", VA = "0x10A6EBB0")]
    public ReqCrystalSale(
      long[] _sale_ids,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x2002EBC")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400E8F3")]
      [FieldOffset(Offset = "0x8")]
      public long[] sale_ids;

      [Token(Token = "0x600DB08")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2002EBD")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400E8F4")]
      [FieldOffset(Offset = "0x8")]
      public long[] sale_ids;
      [Token(Token = "0x400E8F5")]
      [FieldOffset(Offset = "0xC")]
      public Json_PlayerData player;
      [Token(Token = "0x400E8F6")]
      [FieldOffset(Offset = "0x10")]
      public Json_Item[] items;

      [Token(Token = "0x600DB09")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

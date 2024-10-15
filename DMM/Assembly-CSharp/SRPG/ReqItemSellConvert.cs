// Decompiled with JetBrains decompiler
// Type: SRPG.ReqItemSellConvert
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
  [Token(Token = "0x20030D3")]
  public class ReqItemSellConvert : WebAPI
  {
    [Token(Token = "0x600DD58")]
    [Address(RVA = "0xA860F0", Offset = "0xA84EF0", VA = "0x10A860F0")]
    public ReqItemSellConvert(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod serializeCompressMethod = EncodingTypes.ESerializeCompressMethod.TYPED_MESSAGE_PACK)
    {
    }

    [Token(Token = "0x20030D4")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400EC43")]
      [FieldOffset(Offset = "0x8")]
      public Json_PlayerData player;
      [Token(Token = "0x400EC44")]
      [FieldOffset(Offset = "0xC")]
      public Json_Item[] items;
      [Token(Token = "0x400EC45")]
      [FieldOffset(Offset = "0x10")]
      public Json_ItemSellConvertList[] sellItems;
      [Token(Token = "0x400EC46")]
      [FieldOffset(Offset = "0x14")]
      public int isRemain;

      [Token(Token = "0x600DD59")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

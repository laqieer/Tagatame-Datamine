// Decompiled with JetBrains decompiler
// Type: SRPG.ReqUnitPieceShopItemList
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
  [Token(Token = "0x200318C")]
  public class ReqUnitPieceShopItemList : WebAPI
  {
    [Token(Token = "0x600DE1E")]
    [Address(RVA = "0xA9F340", Offset = "0xA9E140", VA = "0x10A9F340")]
    public ReqUnitPieceShopItemList(
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod compress)
    {
    }

    [Token(Token = "0x200318D")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400ED4D")]
      [FieldOffset(Offset = "0x8")]
      public string shop_iname;
      [Token(Token = "0x400ED4E")]
      [FieldOffset(Offset = "0xC")]
      public string cost_iname;
      [Token(Token = "0x400ED4F")]
      [FieldOffset(Offset = "0x10")]
      public Json_UnitPieceShopItem[] shopitems;

      [Token(Token = "0x600DE1F")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

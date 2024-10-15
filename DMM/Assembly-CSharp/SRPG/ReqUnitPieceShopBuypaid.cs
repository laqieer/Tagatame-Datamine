// Decompiled with JetBrains decompiler
// Type: SRPG.ReqUnitPieceShopBuypaid
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
  [Token(Token = "0x200318E")]
  public class ReqUnitPieceShopBuypaid : WebAPI
  {
    [Token(Token = "0x600DE20")]
    [Address(RVA = "0xA9F250", Offset = "0xA9E050", VA = "0x10A9F250")]
    public ReqUnitPieceShopBuypaid(
      string shopIname,
      string iname,
      int buynum,
      SRPG.Network.ResponseCallback response,
      EncodingTypes.ESerializeCompressMethod compress)
    {
    }

    [Token(Token = "0x200318F")]
    [Serializable]
    public class RequestParam
    {
      [Token(Token = "0x400ED50")]
      [FieldOffset(Offset = "0x8")]
      public string shop_iname;
      [Token(Token = "0x400ED51")]
      [FieldOffset(Offset = "0xC")]
      public string iname;
      [Token(Token = "0x400ED52")]
      [FieldOffset(Offset = "0x10")]
      public int buynum;

      [Token(Token = "0x600DE21")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RequestParam()
      {
      }
    }

    [Token(Token = "0x2003190")]
    [MessagePackObject(true)]
    [Serializable]
    public class Response
    {
      [Token(Token = "0x400ED53")]
      [FieldOffset(Offset = "0x8")]
      public Json_Item[] items;
      [Token(Token = "0x400ED54")]
      [FieldOffset(Offset = "0xC")]
      public Json_UnitPieceShopItem[] shopitems;
      [Token(Token = "0x400ED55")]
      [FieldOffset(Offset = "0x10")]
      public JSON_TrophyProgress[] trophyprogs;
      [Token(Token = "0x400ED56")]
      [FieldOffset(Offset = "0x14")]
      public JSON_TrophyProgress[] bingoprogs;

      [Token(Token = "0x600DE22")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Response()
      {
      }
    }
  }
}

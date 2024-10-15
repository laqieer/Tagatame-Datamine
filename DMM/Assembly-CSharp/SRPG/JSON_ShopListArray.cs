// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ShopListArray
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200110D")]
  public class JSON_ShopListArray
  {
    [Token(Token = "0x4003DA3")]
    [FieldOffset(Offset = "0x8")]
    public JSON_ShopListArray.Shops[] shops;
    [Token(Token = "0x4003DA4")]
    [FieldOffset(Offset = "0xC")]
    public JSON_ShopListArray.Banners[] banners;
    [Token(Token = "0x4003DA5")]
    [FieldOffset(Offset = "0x10")]
    public Json_LimitedShopResponse first_shop_info;

    [Token(Token = "0x6004859")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ShopListArray()
    {
    }

    [Token(Token = "0x200110E")]
    [MessagePackObject(true)]
    [Serializable]
    public class Shops
    {
      [Token(Token = "0x4003DA6")]
      [FieldOffset(Offset = "0x8")]
      public int id;
      [Token(Token = "0x4003DA7")]
      [FieldOffset(Offset = "0xC")]
      public string gname;
      [Token(Token = "0x4003DA8")]
      [FieldOffset(Offset = "0x10")]
      public string gtype;
      [Token(Token = "0x4003DA9")]
      [FieldOffset(Offset = "0x18")]
      public long yymmddhhmm;
      [Token(Token = "0x4003DAA")]
      [FieldOffset(Offset = "0x20")]
      public int priority;
      [Token(Token = "0x4003DAB")]
      [FieldOffset(Offset = "0x24")]
      public JSON_ShopListArray.Shops.JSON_ShopListInfo info;
      [Token(Token = "0x4003DAC")]
      [FieldOffset(Offset = "0x28")]
      public long start;
      [Token(Token = "0x4003DAD")]
      [FieldOffset(Offset = "0x30")]
      public long end;
      [Token(Token = "0x4003DAE")]
      [FieldOffset(Offset = "0x38")]
      public JSON_ShopListArray.Shops.JSON_UnlockInfo unlock;
      [Token(Token = "0x4003DAF")]
      [FieldOffset(Offset = "0x3C")]
      public int always_view_flg;

      [Token(Token = "0x600485A")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Shops()
      {
      }

      [Token(Token = "0x200110F")]
      [MessagePackObject(true)]
      [Serializable]
      public class JSON_ShopListInfo
      {
        [Token(Token = "0x4003DB0")]
        [FieldOffset(Offset = "0x8")]
        public string rare;
        [Token(Token = "0x4003DB1")]
        [FieldOffset(Offset = "0xC")]
        public string title;
        [Token(Token = "0x4003DB2")]
        [FieldOffset(Offset = "0x10")]
        public int portlv;
        [Token(Token = "0x4003DB3")]
        [FieldOffset(Offset = "0x14")]
        public int unlock;
        [Token(Token = "0x4003DB4")]
        [FieldOffset(Offset = "0x18")]
        public string msg;
        [Token(Token = "0x4003DB5")]
        [FieldOffset(Offset = "0x1C")]
        private JSON_ShopListArray.Shops.JSON_ShopListInfo.JSON_ShopListInfoCost cost;
        [Token(Token = "0x4003DB6")]
        [FieldOffset(Offset = "0x20")]
        private int gold;

        [Token(Token = "0x600485B")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public JSON_ShopListInfo()
        {
        }

        [Token(Token = "0x2001110")]
        [MessagePackObject(true)]
        [Serializable]
        public class JSON_ShopListInfoCost
        {
          [Token(Token = "0x4003DB7")]
          [FieldOffset(Offset = "0x8")]
          private int gold;

          [Token(Token = "0x600485C")]
          [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
          public JSON_ShopListInfoCost()
          {
          }
        }
      }

      [Token(Token = "0x2001111")]
      [MessagePackObject(true)]
      [Serializable]
      public class JSON_UnlockInfo
      {
        [Token(Token = "0x4003DB8")]
        [FieldOffset(Offset = "0x8")]
        public int flg;
        [Token(Token = "0x4003DB9")]
        [FieldOffset(Offset = "0xC")]
        public string message;

        [Token(Token = "0x600485D")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public JSON_UnlockInfo()
        {
        }
      }
    }

    [Token(Token = "0x2001112")]
    [MessagePackObject(true)]
    [Serializable]
    public class Banners
    {
      [Token(Token = "0x4003DBA")]
      [FieldOffset(Offset = "0x8")]
      public string banner_id;
      [Token(Token = "0x4003DBB")]
      [FieldOffset(Offset = "0xC")]
      public string banner_sprite;
      [Token(Token = "0x4003DBC")]
      [FieldOffset(Offset = "0x10")]
      public int priority;
      [Token(Token = "0x4003DBD")]
      [FieldOffset(Offset = "0x14")]
      public JSON_ShopListArray.Shops[] children;
      [Token(Token = "0x4003DBE")]
      [FieldOffset(Offset = "0x18")]
      public int always_view_flg;

      [Token(Token = "0x600485E")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Banners()
      {
      }
    }
  }
}

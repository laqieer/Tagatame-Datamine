// Decompiled with JetBrains decompiler
// Type: SRPG.LimitedShopListItemInfo
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A87")]
  public class LimitedShopListItemInfo
  {
    [Token(Token = "0x400CEF3")]
    [FieldOffset(Offset = "0x8")]
    private JSON_ShopListArray.Shops mShops;
    [Token(Token = "0x400CEF4")]
    [FieldOffset(Offset = "0xC")]
    private string mShopCostIname;
    [Token(Token = "0x400CEF5")]
    [FieldOffset(Offset = "0x10")]
    private bool mButtonUpdate;

    [Token(Token = "0x170019F2")]
    public JSON_ShopListArray.Shops Shops
    {
      [Token(Token = "0x600C235"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (JSON_ShopListArray.Shops) null;
      }
    }

    [Token(Token = "0x170019F3")]
    public string ShopCostIname
    {
      [Token(Token = "0x600C236"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170019F4")]
    public bool ButtonUpdate
    {
      [Token(Token = "0x600C237"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C238")]
    [Address(RVA = "0x4ACEB0", Offset = "0x4ABCB0", VA = "0x104ACEB0")]
    public LimitedShopListItemInfo(
      JSON_ShopListArray.Shops shops,
      string shopCostIname,
      bool buttonUpdate)
    {
    }
  }
}

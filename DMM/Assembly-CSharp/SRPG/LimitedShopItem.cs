// Decompiled with JetBrains decompiler
// Type: SRPG.LimitedShopItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FD9")]
  public class LimitedShopItem : ShopItem
  {
    [Token(Token = "0x4003809")]
    [FieldOffset(Offset = "0x60")]
    public string cost_iname;

    [Token(Token = "0x60041EA")]
    [Address(RVA = "0x11992B0", Offset = "0x11980B0", VA = "0x111992B0")]
    public bool Deserialize(JSON_LimitedShopItemListSet json) => new bool();

    [Token(Token = "0x60041EB")]
    [Address(RVA = "0x10F9AC0", Offset = "0x10F88C0", VA = "0x110F9AC0")]
    public void SetShopItem(ShopItem shop_item)
    {
    }

    [Token(Token = "0x60041EC")]
    [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
    public LimitedShopItem()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.EventShopItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000EB6")]
  public class EventShopItem : ShopItem
  {
    [Token(Token = "0x4002D3F")]
    [FieldOffset(Offset = "0x60")]
    public string cost_iname;
    [Token(Token = "0x4002D40")]
    [FieldOffset(Offset = "0x64")]
    public bool update_type;
    [Token(Token = "0x4002D41")]
    [FieldOffset(Offset = "0x68")]
    private JSON_EventShopItemListSet.Cost cost;

    [Token(Token = "0x6003D29")]
    [Address(RVA = "0x10F9790", Offset = "0x10F8590", VA = "0x110F9790")]
    public bool Deserialize(JSON_EventShopItemListSet json) => new bool();

    [Token(Token = "0x6003D2A")]
    [Address(RVA = "0x10F9AC0", Offset = "0x10F88C0", VA = "0x110F9AC0")]
    public void SetShopItem(ShopItem shop_item)
    {
    }

    [Token(Token = "0x6003D2B")]
    [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
    public EventShopItem()
    {
    }
  }
}

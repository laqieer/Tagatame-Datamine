// Decompiled with JetBrains decompiler
// Type: SRPG.EventShopData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000EB7")]
  public class EventShopData
  {
    [Token(Token = "0x4002D42")]
    [FieldOffset(Offset = "0x8")]
    public List<EventShopItem> items;
    [Token(Token = "0x4002D43")]
    [FieldOffset(Offset = "0xC")]
    public int UpdateCount;
    [Token(Token = "0x4002D44")]
    [FieldOffset(Offset = "0x10")]
    private ShopData mShopData;

    [Token(Token = "0x6003D2C")]
    [Address(RVA = "0x10F8B30", Offset = "0x10F7930", VA = "0x110F8B30")]
    public bool Deserialize(Json_EventShopResponse response) => new bool();

    [Token(Token = "0x6003D2D")]
    [Address(RVA = "0x10F8C20", Offset = "0x10F7A20", VA = "0x110F8C20")]
    public bool Deserialize(Json_EventShopUpdateResponse response) => new bool();

    [Token(Token = "0x6003D2E")]
    [Address(RVA = "0x10F8F80", Offset = "0x10F7D80", VA = "0x110F8F80")]
    public bool Deserialize(Json_EventShopBuyResponse response) => new bool();

    [Token(Token = "0x6003D2F")]
    [Address(RVA = "0x10F8E70", Offset = "0x10F7C70", VA = "0x110F8E70")]
    public bool Deserialize(JSON_EventShopItemListSet[] shopitems) => new bool();

    [Token(Token = "0x6003D30")]
    [Address(RVA = "0x10F95E0", Offset = "0x10F83E0", VA = "0x110F95E0")]
    public ShopData GetShopData() => (ShopData) null;

    [Token(Token = "0x6003D31")]
    [Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")]
    public void SetShopData(ShopData shopData)
    {
    }

    [Token(Token = "0x6003D32")]
    [Address(RVA = "0x10F96E0", Offset = "0x10F84E0", VA = "0x110F96E0")]
    public EventShopData()
    {
    }
  }
}

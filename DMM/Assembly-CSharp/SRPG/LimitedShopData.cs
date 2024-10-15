// Decompiled with JetBrains decompiler
// Type: SRPG.LimitedShopData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FDA")]
  public class LimitedShopData
  {
    [Token(Token = "0x400380A")]
    [FieldOffset(Offset = "0x8")]
    public List<LimitedShopItem> items;
    [Token(Token = "0x400380B")]
    [FieldOffset(Offset = "0xC")]
    public int UpdateCount;

    [Token(Token = "0x60041ED")]
    [Address(RVA = "0x1198E10", Offset = "0x1197C10", VA = "0x11198E10")]
    public bool Deserialize(Json_LimitedShopResponse response) => new bool();

    [Token(Token = "0x60041EE")]
    [Address(RVA = "0x1198BD0", Offset = "0x11979D0", VA = "0x11198BD0")]
    public bool Deserialize(Json_LimitedShopUpdateResponse response) => new bool();

    [Token(Token = "0x60041EF")]
    [Address(RVA = "0x1198570", Offset = "0x1197370", VA = "0x11198570")]
    public bool Deserialize(Json_LimitedShopBuyResponse response) => new bool();

    [Token(Token = "0x60041F0")]
    [Address(RVA = "0x1198F00", Offset = "0x1197D00", VA = "0x11198F00")]
    public bool Deserialize(JSON_LimitedShopItemListSet[] shopitems) => new bool();

    [Token(Token = "0x60041F1")]
    [Address(RVA = "0x1199000", Offset = "0x1197E00", VA = "0x11199000")]
    public ShopData GetShopData() => (ShopData) null;

    [Token(Token = "0x60041F2")]
    [Address(RVA = "0x1199110", Offset = "0x1197F10", VA = "0x11199110")]
    public void SetShopData(ShopData shopData)
    {
    }

    [Token(Token = "0x60041F3")]
    [Address(RVA = "0x1199240", Offset = "0x1198040", VA = "0x11199240")]
    public LimitedShopData()
    {
    }
  }
}

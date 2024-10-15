// Decompiled with JetBrains decompiler
// Type: SRPG.ShopListData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001128")]
  public class ShopListData
  {
    [Token(Token = "0x4003E54")]
    [FieldOffset(Offset = "0x8")]
    private string _banner_id;
    [Token(Token = "0x4003E55")]
    [FieldOffset(Offset = "0xC")]
    private string _banner_sprite;
    [Token(Token = "0x4003E56")]
    [FieldOffset(Offset = "0x10")]
    private int _priority;
    [Token(Token = "0x4003E57")]
    [FieldOffset(Offset = "0x14")]
    private JSON_ShopListArray.Shops _shopInfo;
    [Token(Token = "0x4003E58")]
    [FieldOffset(Offset = "0x18")]
    private JSON_ShopListArray.Shops[] _children;
    [Token(Token = "0x4003E59")]
    [FieldOffset(Offset = "0x1C")]
    private bool _always_view_flg;

    [Token(Token = "0x17000795")]
    public string BannerId
    {
      [Token(Token = "0x6004899"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000796")]
    public string BannerSprite
    {
      [Token(Token = "0x600489A"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000797")]
    public int Priority
    {
      [Token(Token = "0x600489B"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000798")]
    public JSON_ShopListArray.Shops ShopInfo
    {
      [Token(Token = "0x600489C"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (JSON_ShopListArray.Shops) null;
      }
    }

    [Token(Token = "0x17000799")]
    public JSON_ShopListArray.Shops[] Childrens
    {
      [Token(Token = "0x600489D"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (JSON_ShopListArray.Shops[]) null;
      }
    }

    [Token(Token = "0x1700079A")]
    public bool Always_view_flg
    {
      [Token(Token = "0x600489E"), Address(RVA = "0x2A5AA0", Offset = "0x2A48A0", VA = "0x102A5AA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700079B")]
    public bool IsParent
    {
      [Token(Token = "0x600489F"), Address(RVA = "0x11F7EF0", Offset = "0x11F6CF0", VA = "0x111F7EF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60048A0")]
    [Address(RVA = "0x11F7DF0", Offset = "0x11F6BF0", VA = "0x111F7DF0")]
    public ShopListData()
    {
    }

    [Token(Token = "0x60048A1")]
    [Address(RVA = "0x11F7D40", Offset = "0x11F6B40", VA = "0x111F7D40")]
    public void Deserialize(JSON_ShopListArray.Shops json, bool isCheckAlwaysView = false)
    {
    }

    [Token(Token = "0x60048A2")]
    [Address(RVA = "0x11F7D90", Offset = "0x11F6B90", VA = "0x111F7D90")]
    public void Deserialize(JSON_ShopListArray.Banners json, bool isCheckAlwaysView = false)
    {
    }
  }
}

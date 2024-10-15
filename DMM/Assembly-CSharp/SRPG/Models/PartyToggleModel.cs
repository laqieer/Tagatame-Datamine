// Decompiled with JetBrains decompiler
// Type: SRPG.Models.PartyToggleModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003344")]
  public class PartyToggleModel
  {
    [Token(Token = "0x400F1EC")]
    private const string BADGE_SPRITE_NONE = "Equip";
    [Token(Token = "0x400F1ED")]
    private const string BADGE_SPRITE_ARENA = "Arena";
    [Token(Token = "0x400F1EE")]
    private const string BADGE_SPRITE_SUPPORT = "Support";
    [Token(Token = "0x400F1EF")]
    private const string BADGE_SPRITE_GVG = "Gvg";
    [Token(Token = "0x400F1F0")]
    private const string BADGE_SPRITE_LEAGUEMATCH = "Pve";
    [Token(Token = "0x400F1F1")]
    [FieldOffset(Offset = "0x8")]
    private BulkReleaseWindow.EquipPartyType mType;
    [Token(Token = "0x400F1F2")]
    [FieldOffset(Offset = "0xC")]
    private string mBadgeSpriteKey;
    [Token(Token = "0x400F1F3")]
    [FieldOffset(Offset = "0x10")]
    private bool mIsVisible;
    [Token(Token = "0x400F1F4")]
    [FieldOffset(Offset = "0x11")]
    private bool mIsBadgeVisible;
    [Token(Token = "0x400F1F5")]
    [FieldOffset(Offset = "0x12")]
    private bool mIsToggle;
    [Token(Token = "0x400F1F6")]
    [FieldOffset(Offset = "0x13")]
    private bool mIsToggleIntractable;

    [Token(Token = "0x17001E48")]
    public BulkReleaseWindow.EquipPartyType Type
    {
      [Token(Token = "0x600E2B0"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new BulkReleaseWindow.EquipPartyType();
      }
    }

    [Token(Token = "0x17001E49")]
    public string BadgeSpriteKey
    {
      [Token(Token = "0x600E2B1"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001E4A")]
    public bool IsVisible
    {
      [Token(Token = "0x600E2B2"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E4B")]
    public bool IsBadgeVisible
    {
      [Token(Token = "0x600E2B3"), Address(RVA = "0x3E6E30", Offset = "0x3E5C30", VA = "0x103E6E30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E4C")]
    public bool IsToggle
    {
      [Token(Token = "0x600E2B4"), Address(RVA = "0x610BF0", Offset = "0x60F9F0", VA = "0x10610BF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E4D")]
    public bool IsToggleIntractable
    {
      [Token(Token = "0x600E2B5"), Address(RVA = "0xAAE040", Offset = "0xAACE40", VA = "0x10AAE040")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E2B6")]
    [Address(RVA = "0xAB3800", Offset = "0xAB2600", VA = "0x10AB3800")]
    public void Initialize(
      BulkReleaseWindow.EquipPartyType type,
      bool visible,
      bool badge,
      bool toggle,
      bool toggle_intractable)
    {
    }

    [Token(Token = "0x600E2B7")]
    [Address(RVA = "0xAB3930", Offset = "0xAB2730", VA = "0x10AB3930")]
    public void SetSprite()
    {
    }

    [Token(Token = "0x600E2B8")]
    [Address(RVA = "0x2C73C0", Offset = "0x2C61C0", VA = "0x102C73C0")]
    public void SetVisible(bool visible)
    {
    }

    [Token(Token = "0x600E2B9")]
    [Address(RVA = "0xAB3920", Offset = "0xAB2720", VA = "0x10AB3920")]
    public void SetBadgeVisible(bool visible)
    {
    }

    [Token(Token = "0x600E2BA")]
    [Address(RVA = "0xAB3A40", Offset = "0xAB2840", VA = "0x10AB3A40")]
    public void SetToggle(bool toggle)
    {
    }

    [Token(Token = "0x600E2BB")]
    [Address(RVA = "0xAB3A30", Offset = "0xAB2830", VA = "0x10AB3A30")]
    public void SetToggleIntractable(bool enable)
    {
    }

    [Token(Token = "0x600E2BC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PartyToggleModel()
    {
    }
  }
}

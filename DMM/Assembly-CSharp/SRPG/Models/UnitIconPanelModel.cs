// Decompiled with JetBrains decompiler
// Type: SRPG.Models.UnitIconPanelModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033CD")]
  public class UnitIconPanelModel
  {
    [Token(Token = "0x400F553")]
    [FieldOffset(Offset = "0x8")]
    private readonly string LEVEL_HIDE_TEXT;
    [Token(Token = "0x400F554")]
    [FieldOffset(Offset = "0xC")]
    private readonly string LEVEL_LIMIT_HIDE_TEXT;
    [Token(Token = "0x400F555")]
    private const int mRarityStart = 1;
    [Token(Token = "0x400F556")]
    [FieldOffset(Offset = "0x10")]
    private bool mIsHideIcon;
    [Token(Token = "0x400F557")]
    [FieldOffset(Offset = "0x11")]
    private bool mIsHideRarity;
    [Token(Token = "0x400F558")]
    [FieldOffset(Offset = "0x12")]
    private bool mIsHideLevel;
    [Token(Token = "0x400F559")]
    [FieldOffset(Offset = "0x13")]
    private bool mIsHideJob;
    [Token(Token = "0x400F55A")]
    [FieldOffset(Offset = "0x14")]
    private UnitModel mIconModel;
    [Token(Token = "0x400F55B")]
    [FieldOffset(Offset = "0x18")]
    private string mLevel;
    [Token(Token = "0x400F55C")]
    [FieldOffset(Offset = "0x1C")]
    private string mLevelLimit;
    [Token(Token = "0x400F55D")]
    [FieldOffset(Offset = "0x20")]
    private float mLevelExp;
    [Token(Token = "0x400F55E")]
    [FieldOffset(Offset = "0x24")]
    private float mNextLevelExp;
    [Token(Token = "0x400F55F")]
    [FieldOffset(Offset = "0x28")]
    private float mNowExp;
    [Token(Token = "0x400F560")]
    [FieldOffset(Offset = "0x2C")]
    private int mRarity;
    [Token(Token = "0x400F561")]
    [FieldOffset(Offset = "0x30")]
    private int mRarityMax;
    [Token(Token = "0x400F562")]
    [FieldOffset(Offset = "0x34")]
    private bool mIsResonance;

    [Token(Token = "0x170020F4")]
    public bool IsHideIcon
    {
      [Token(Token = "0x600E7CC"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170020F5")]
    public bool IsHideRarity
    {
      [Token(Token = "0x600E7CD"), Address(RVA = "0x3E6E30", Offset = "0x3E5C30", VA = "0x103E6E30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170020F6")]
    public bool IsHideLevel
    {
      [Token(Token = "0x600E7CE"), Address(RVA = "0x610BF0", Offset = "0x60F9F0", VA = "0x10610BF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170020F7")]
    public UnitModel IconModel
    {
      [Token(Token = "0x600E7CF"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (UnitModel) null;
      }
    }

    [Token(Token = "0x170020F8")]
    public string Level
    {
      [Token(Token = "0x600E7D0"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170020F9")]
    public string LevelLimit
    {
      [Token(Token = "0x600E7D1"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170020FA")]
    public float LevelExp
    {
      [Token(Token = "0x600E7D2"), Address(RVA = "0x3A3990", Offset = "0x3A2790", VA = "0x103A3990")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x170020FB")]
    public float NextLevelExp
    {
      [Token(Token = "0x600E7D3"), Address(RVA = "0x3A3940", Offset = "0x3A2740", VA = "0x103A3940")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x170020FC")]
    public float NowExp
    {
      [Token(Token = "0x600E7D4"), Address(RVA = "0x2CD6D0", Offset = "0x2CC4D0", VA = "0x102CD6D0")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x170020FD")]
    public int Rarity
    {
      [Token(Token = "0x600E7D5"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170020FE")]
    public int RarityMax
    {
      [Token(Token = "0x600E7D6"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170020FF")]
    public bool IsResonance
    {
      [Token(Token = "0x600E7D7"), Address(RVA = "0xAD0580", Offset = "0xACF380", VA = "0x10AD0580")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E7D8")]
    [Address(RVA = "0xAD0500", Offset = "0xACF300", VA = "0x10AD0500")]
    public UnitIconPanelModel(
      bool isHideIcon = false,
      bool isHideRarity = false,
      bool isHideLevel = false,
      bool isHideJob = false)
    {
    }

    [Token(Token = "0x600E7D9")]
    [Address(RVA = "0xACFEC0", Offset = "0xACECC0", VA = "0x10ACFEC0")]
    public void Initialize(UnitData unitData)
    {
    }

    [Token(Token = "0x600E7DA")]
    [Address(RVA = "0xAD0070", Offset = "0xACEE70", VA = "0x10AD0070")]
    private void SetData(UnitData unitData)
    {
    }

    [Token(Token = "0x600E7DB")]
    [Address(RVA = "0xAD01B0", Offset = "0xACEFB0", VA = "0x10AD01B0")]
    private void SetIcon(UnitData unitData)
    {
    }

    [Token(Token = "0x600E7DC")]
    [Address(RVA = "0xAD0220", Offset = "0xACF020", VA = "0x10AD0220")]
    private void SetLevel(UnitData unitData)
    {
    }

    [Token(Token = "0x600E7DD")]
    [Address(RVA = "0xAD0440", Offset = "0xACF240", VA = "0x10AD0440")]
    private void SetRarity(UnitData unitData)
    {
    }
  }
}

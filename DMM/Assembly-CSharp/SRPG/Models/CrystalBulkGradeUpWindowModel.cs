// Decompiled with JetBrains decompiler
// Type: SRPG.Models.CrystalBulkGradeUpWindowModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200332F")]
  public class CrystalBulkGradeUpWindowModel
  {
    [Token(Token = "0x400F197")]
    [FieldOffset(Offset = "0x8")]
    private CrystalData mData;
    [Token(Token = "0x400F198")]
    [FieldOffset(Offset = "0xC")]
    private CrystalData mResultData;
    [Token(Token = "0x400F199")]
    [FieldOffset(Offset = "0x10")]
    private Sprite mPreRankSprite;
    [Token(Token = "0x400F19A")]
    [FieldOffset(Offset = "0x14")]
    private Sprite mAfterRankSprite;
    [Token(Token = "0x400F19B")]
    [FieldOffset(Offset = "0x18")]
    private bool mToggleState;
    [Token(Token = "0x400F19C")]
    [FieldOffset(Offset = "0x19")]
    private bool mIsShowDetailParent;
    [Token(Token = "0x400F19D")]
    [FieldOffset(Offset = "0x1A")]
    private bool mIsShowDetailChildren;

    [Token(Token = "0x17001E10")]
    public CrystalData BaseCrystal
    {
      [Token(Token = "0x600E20F"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (CrystalData) null;
      }
    }

    [Token(Token = "0x17001E11")]
    public CrystalData ResultCrystal
    {
      [Token(Token = "0x600E210"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (CrystalData) null;
      }
    }

    [Token(Token = "0x17001E12")]
    public Sprite PreRankSprite
    {
      [Token(Token = "0x600E211"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x17001E13")]
    public Sprite AfterRankSprite
    {
      [Token(Token = "0x600E212"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (Sprite) null;
      }
    }

    [Token(Token = "0x17001E14")]
    public string NeedAmountText
    {
      [Token(Token = "0x600E213"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600E214"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] private set
      {
      }
    }

    [Token(Token = "0x17001E15")]
    public bool ToggleState
    {
      [Token(Token = "0x600E215"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E16")]
    public bool IsShowDetailParent
    {
      [Token(Token = "0x600E216"), Address(RVA = "0x3FE5C0", Offset = "0x3FD3C0", VA = "0x103FE5C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E17")]
    public bool IsShowDetailChildren
    {
      [Token(Token = "0x600E217"), Address(RVA = "0x408500", Offset = "0x407300", VA = "0x10408500")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E218")]
    [Address(RVA = "0xAACBD0", Offset = "0xAAB9D0", VA = "0x10AACBD0")]
    public void SetData(CrystalData _data)
    {
    }

    [Token(Token = "0x600E219")]
    [Address(RVA = "0xAAD220", Offset = "0xAAC020", VA = "0x10AAD220")]
    private void SetRankSprite(ref Sprite sprite, CrystalData data)
    {
    }

    [Token(Token = "0x600E21A")]
    [Address(RVA = "0xAAD290", Offset = "0xAAC090", VA = "0x10AAD290")]
    private void SetToggleState()
    {
    }

    [Token(Token = "0x600E21B")]
    [Address(RVA = "0xAAD050", Offset = "0xAABE50", VA = "0x10AAD050")]
    private void SetDetailParentButton()
    {
    }

    [Token(Token = "0x600E21C")]
    [Address(RVA = "0xAACDA0", Offset = "0xAABBA0", VA = "0x10AACDA0")]
    private void SetDetailChildrenButton()
    {
    }

    [Token(Token = "0x600E21D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CrystalBulkGradeUpWindowModel()
    {
    }
  }
}

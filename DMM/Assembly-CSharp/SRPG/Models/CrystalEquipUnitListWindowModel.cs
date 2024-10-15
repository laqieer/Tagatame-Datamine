// Decompiled with JetBrains decompiler
// Type: SRPG.Models.CrystalEquipUnitListWindowModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003331")]
  public class CrystalEquipUnitListWindowModel
  {
    [Token(Token = "0x400F1A1")]
    [FieldOffset(Offset = "0x8")]
    private UnitData mUnit;
    [Token(Token = "0x400F1A2")]
    [FieldOffset(Offset = "0xC")]
    private UnitModel mIconModel;
    [Token(Token = "0x400F1A3")]
    [FieldOffset(Offset = "0x10")]
    private bool mIsUseQuest;
    [Token(Token = "0x400F1A4")]
    [FieldOffset(Offset = "0x11")]
    private bool mIsUseArena;
    [Token(Token = "0x400F1A5")]
    [FieldOffset(Offset = "0x12")]
    private bool mIsUseSupport;
    [Token(Token = "0x400F1A6")]
    [FieldOffset(Offset = "0x13")]
    private bool mIsUseGvG;
    [Token(Token = "0x400F1A7")]
    [FieldOffset(Offset = "0x14")]
    private bool mIsUseLeagueMatch;

    [Token(Token = "0x17001E18")]
    public UnitData Unit
    {
      [Token(Token = "0x600E225"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x17001E19")]
    public UnitModel IconModel
    {
      [Token(Token = "0x600E226"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (UnitModel) null;
      }
    }

    [Token(Token = "0x17001E1A")]
    public bool IsUseQuest
    {
      [Token(Token = "0x600E227"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E1B")]
    public bool IsUseArena
    {
      [Token(Token = "0x600E228"), Address(RVA = "0x3E6E30", Offset = "0x3E5C30", VA = "0x103E6E30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E1C")]
    public bool IsUseSupport
    {
      [Token(Token = "0x600E229"), Address(RVA = "0x610BF0", Offset = "0x60F9F0", VA = "0x10610BF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E1D")]
    public bool IsUseGvG
    {
      [Token(Token = "0x600E22A"), Address(RVA = "0xAAE040", Offset = "0xAACE40", VA = "0x10AAE040")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001E1E")]
    public bool IsUseLeagueMatch
    {
      [Token(Token = "0x600E22B"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E22C")]
    [Address(RVA = "0xAADDD0", Offset = "0xAACBD0", VA = "0x10AADDD0")]
    public void Initialize(CrystalWindow.CrystalUseUnitState _data)
    {
    }

    [Token(Token = "0x600E22D")]
    [Address(RVA = "0xAADFF0", Offset = "0xAACDF0", VA = "0x10AADFF0")]
    private void SetData(UnitData unitData)
    {
    }

    [Token(Token = "0x600E22E")]
    [Address(RVA = "0xAADFF0", Offset = "0xAACDF0", VA = "0x10AADFF0")]
    private void SetIcon(UnitData unitData)
    {
    }

    [Token(Token = "0x600E22F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CrystalEquipUnitListWindowModel()
    {
    }
  }
}

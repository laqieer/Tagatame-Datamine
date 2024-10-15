// Decompiled with JetBrains decompiler
// Type: SRPG.Models.CrystalReplaceContentModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003322")]
  public class CrystalReplaceContentModel
  {
    [Token(Token = "0x400F14C")]
    private const string ON_SELECT_CRYSTAL_DETAIL = "ON_SELECT_CRYSTAL_DETAIL";
    [Token(Token = "0x400F14D")]
    [FieldOffset(Offset = "0x8")]
    private CrystalReplaceWindow mWindow;
    [Token(Token = "0x400F14E")]
    [FieldOffset(Offset = "0xC")]
    private UnitData mUnitData;
    [Token(Token = "0x400F14F")]
    [FieldOffset(Offset = "0x10")]
    private UnitModel mUnitModelData;
    [Token(Token = "0x400F150")]
    [FieldOffset(Offset = "0x14")]
    private List<CrystalSetBonusWindowModel> mSetBonusModels;

    [Token(Token = "0x17001DD4")]
    public string UnitName
    {
      [Token(Token = "0x600E18B"), Address(RVA = "0xAB0280", Offset = "0xAAF080", VA = "0x10AB0280")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001DD5")]
    public UnitData TargetUnit
    {
      [Token(Token = "0x600E18C"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x17001DD6")]
    public UnitModel UnitModelData
    {
      [Token(Token = "0x600E18D"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (UnitModel) null;
      }
    }

    [Token(Token = "0x17001DD7")]
    public List<CrystalSetBonusWindowModel> SetBonusModels
    {
      [Token(Token = "0x600E18E"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (List<CrystalSetBonusWindowModel>) null;
      }
    }

    [Token(Token = "0x600E18F")]
    [Address(RVA = "0xAAFDF0", Offset = "0xAAEBF0", VA = "0x10AAFDF0")]
    public void Initialize(CrystalReplaceWindow _window, UnitData unit)
    {
    }

    [Token(Token = "0x600E190")]
    [Address(RVA = "0xAB00E0", Offset = "0xAAEEE0", VA = "0x10AB00E0")]
    public void OnSelectCrystalSlot(GenericSlot slot, bool interactable)
    {
    }

    [Token(Token = "0x600E191")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CrystalReplaceContentModel()
    {
    }
  }
}

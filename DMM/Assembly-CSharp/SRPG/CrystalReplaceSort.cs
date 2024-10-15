// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalReplaceSort
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200228E")]
  public class CrystalReplaceSort
  {
    [Token(Token = "0x4009978")]
    private const string SAVEKEY = "UNITLIST_SORT";
    [Token(Token = "0x4009979")]
    private const string SAVEKEY_OLD = "UNITLIST";
    [Token(Token = "0x400997A")]
    [FieldOffset(Offset = "0x8")]
    private UnitListSortWindow.SelectType m_SelectTypeReg;
    [Token(Token = "0x400997B")]
    [FieldOffset(Offset = "0xC")]
    private UnitListSortWindow.SelectType m_SelectType;
    [Token(Token = "0x400997C")]
    public const UnitListSortWindow.SelectType MASK_SECTION = (UnitListSortWindow.SelectType) 16777215;
    [Token(Token = "0x400997D")]
    public const UnitListSortWindow.SelectType MASK_ALIGNMENT = (UnitListSortWindow.SelectType) 251658240;
    [Token(Token = "0x400997E")]
    [FieldOffset(Offset = "0x10")]
    public List<UnitListWindow.Data> mUnitList;

    [Token(Token = "0x60093E4")]
    [Address(RVA = "0x56E9F0", Offset = "0x56D7F0", VA = "0x1056E9F0")]
    public CrystalReplaceSort()
    {
    }

    [Token(Token = "0x60093E5")]
    [Address(RVA = "0x56E110", Offset = "0x56CF10", VA = "0x1056E110")]
    public void Initialize()
    {
    }

    [Token(Token = "0x60093E6")]
    [Address(RVA = "0x56E9C0", Offset = "0x56D7C0", VA = "0x1056E9C0")]
    public List<UnitData> Sort(List<UnitData> list) => (List<UnitData>) null;

    [Token(Token = "0x60093E7")]
    [Address(RVA = "0x56E7F0", Offset = "0x56D5F0", VA = "0x1056E7F0")]
    public void SetList(List<UnitData> list)
    {
    }

    [Token(Token = "0x60093E8")]
    [Address(RVA = "0x56E5A0", Offset = "0x56D3A0", VA = "0x1056E5A0")]
    public List<UnitData> ResultList() => (List<UnitData>) null;

    [Token(Token = "0x60093E9")]
    [Address(RVA = "0x56E0E0", Offset = "0x56CEE0", VA = "0x1056E0E0")]
    public UnitListSortWindow.SelectType GetAlignment() => new UnitListSortWindow.SelectType();

    [Token(Token = "0x60093EA")]
    [Address(RVA = "0x56DED0", Offset = "0x56CCD0", VA = "0x1056DED0")]
    public void CalcUnit(List<UnitListWindow.Data> list)
    {
    }

    [Token(Token = "0x60093EB")]
    [Address(RVA = "0x56E180", Offset = "0x56CF80", VA = "0x1056E180")]
    public bool IsType(UnitListSortWindow.SelectType value) => new bool();

    [Token(Token = "0x60093EC")]
    [Address(RVA = "0x56E9A0", Offset = "0x56D7A0", VA = "0x1056E9A0")]
    private void SetSection(UnitListSortWindow.SelectType selectType)
    {
    }

    [Token(Token = "0x60093ED")]
    [Address(RVA = "0x56E100", Offset = "0x56CF00", VA = "0x1056E100")]
    public UnitListSortWindow.SelectType GetSection() => new UnitListSortWindow.SelectType();

    [Token(Token = "0x60093EE")]
    [Address(RVA = "0x56E0F0", Offset = "0x56CEF0", VA = "0x1056E0F0")]
    public UnitListSortWindow.SelectType GetSectionReg() => new UnitListSortWindow.SelectType();

    [Token(Token = "0x60093EF")]
    [Address(RVA = "0x56E7D0", Offset = "0x56D5D0", VA = "0x1056E7D0")]
    private void SetAlignment(UnitListSortWindow.SelectType selectType)
    {
    }

    [Token(Token = "0x60093F0")]
    [Address(RVA = "0x56E1A0", Offset = "0x56CFA0", VA = "0x1056E1A0")]
    private void LoadSelectType()
    {
    }

    [Token(Token = "0x60093F1")]
    [Address(RVA = "0x56E740", Offset = "0x56D540", VA = "0x1056E740")]
    public void SaveSelectType()
    {
    }
  }
}

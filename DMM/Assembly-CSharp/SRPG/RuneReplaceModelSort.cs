// Decompiled with JetBrains decompiler
// Type: SRPG.RuneReplaceModelSort
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029C7")]
  public class RuneReplaceModelSort
  {
    [Token(Token = "0x400CAB2")]
    private const string SAVEKEY = "UNITLIST_SORT";
    [Token(Token = "0x400CAB3")]
    private const string SAVEKEY_OLD = "UNITLIST";
    [Token(Token = "0x400CAB4")]
    [FieldOffset(Offset = "0x8")]
    private UnitListSortWindow.SelectType m_SelectTypeReg;
    [Token(Token = "0x400CAB5")]
    [FieldOffset(Offset = "0xC")]
    private UnitListSortWindow.SelectType m_SelectType;
    [Token(Token = "0x400CAB6")]
    public const UnitListSortWindow.SelectType MASK_SECTION = (UnitListSortWindow.SelectType) 16777215;
    [Token(Token = "0x400CAB7")]
    public const UnitListSortWindow.SelectType MASK_ALIGNMENT = (UnitListSortWindow.SelectType) 251658240;
    [Token(Token = "0x400CAB8")]
    [FieldOffset(Offset = "0x10")]
    public List<UnitListWindow.Data> mUnitList;

    [Token(Token = "0x600BE26")]
    [Address(RVA = "0x85B120", Offset = "0x859F20", VA = "0x1085B120")]
    public RuneReplaceModelSort()
    {
    }

    [Token(Token = "0x600BE27")]
    [Address(RVA = "0x85A880", Offset = "0x859680", VA = "0x1085A880")]
    public void Initialize()
    {
    }

    [Token(Token = "0x600BE28")]
    [Address(RVA = "0x85B0F0", Offset = "0x859EF0", VA = "0x1085B0F0")]
    public List<string> Sort(List<UnitData> list) => (List<string>) null;

    [Token(Token = "0x600BE29")]
    [Address(RVA = "0x85AF40", Offset = "0x859D40", VA = "0x1085AF40")]
    public void SetList(List<UnitData> list)
    {
    }

    [Token(Token = "0x600BE2A")]
    [Address(RVA = "0x85ACF0", Offset = "0x859AF0", VA = "0x1085ACF0")]
    public List<string> ResultList() => (List<string>) null;

    [Token(Token = "0x600BE2B")]
    [Address(RVA = "0x56E0E0", Offset = "0x56CEE0", VA = "0x1056E0E0")]
    public UnitListSortWindow.SelectType GetAlignment() => new UnitListSortWindow.SelectType();

    [Token(Token = "0x600BE2C")]
    [Address(RVA = "0x85A670", Offset = "0x859470", VA = "0x1085A670")]
    public void CalcUnit(List<UnitListWindow.Data> list)
    {
    }

    [Token(Token = "0x600BE2D")]
    [Address(RVA = "0x56E180", Offset = "0x56CF80", VA = "0x1056E180")]
    public bool IsType(UnitListSortWindow.SelectType value) => new bool();

    [Token(Token = "0x600BE2E")]
    [Address(RVA = "0x56E9A0", Offset = "0x56D7A0", VA = "0x1056E9A0")]
    private void SetSection(UnitListSortWindow.SelectType selectType)
    {
    }

    [Token(Token = "0x600BE2F")]
    [Address(RVA = "0x56E100", Offset = "0x56CF00", VA = "0x1056E100")]
    public UnitListSortWindow.SelectType GetSection() => new UnitListSortWindow.SelectType();

    [Token(Token = "0x600BE30")]
    [Address(RVA = "0x56E0F0", Offset = "0x56CEF0", VA = "0x1056E0F0")]
    public UnitListSortWindow.SelectType GetSectionReg() => new UnitListSortWindow.SelectType();

    [Token(Token = "0x600BE31")]
    [Address(RVA = "0x56E7D0", Offset = "0x56D5D0", VA = "0x1056E7D0")]
    private void SetAlignment(UnitListSortWindow.SelectType selectType)
    {
    }

    [Token(Token = "0x600BE32")]
    [Address(RVA = "0x85A8F0", Offset = "0x8596F0", VA = "0x1085A8F0")]
    private void LoadSelectType()
    {
    }

    [Token(Token = "0x600BE33")]
    [Address(RVA = "0x85AEB0", Offset = "0x859CB0", VA = "0x1085AEB0")]
    public void SaveSelectType()
    {
    }
  }
}

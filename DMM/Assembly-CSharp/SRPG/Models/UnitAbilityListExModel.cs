// Decompiled with JetBrains decompiler
// Type: SRPG.Models.UnitAbilityListExModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x20033C7")]
  public class UnitAbilityListExModel
  {
    [Token(Token = "0x400F522")]
    private const int ActionSlotMax = 2;
    [Token(Token = "0x400F523")]
    private const int ReactionSlotMax = 1;
    [Token(Token = "0x400F524")]
    private const int SupportSlotMax = 2;
    [Token(Token = "0x400F525")]
    [FieldOffset(Offset = "0x8")]
    private bool mIsEditMode;
    [Token(Token = "0x400F526")]
    [FieldOffset(Offset = "0x9")]
    private bool mIsHideMode;
    [Token(Token = "0x400F527")]
    [FieldOffset(Offset = "0xC")]
    private UnitData mUnitData;
    [Token(Token = "0x400F528")]
    [FieldOffset(Offset = "0x10")]
    private List<AbilityData> mAbilityDataList;
    [Token(Token = "0x400F529")]
    [FieldOffset(Offset = "0x14")]
    private List<UnitAbilityPanelModel.Mode> mItemModeList;

    [Token(Token = "0x170020E5")]
    public List<AbilityData> AbilityDataList
    {
      [Token(Token = "0x600E79E"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (List<AbilityData>) null;
      }
    }

    [Token(Token = "0x170020E6")]
    public bool IsEditMode
    {
      [Token(Token = "0x600E79F"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170020E7")]
    public bool IsHideMode
    {
      [Token(Token = "0x600E7A0"), Address(RVA = "0x34B080", Offset = "0x349E80", VA = "0x1034B080")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170020E8")]
    public UnitData UnitData
    {
      [Token(Token = "0x600E7A1"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x600E7A2")]
    [Address(RVA = "0xACE150", Offset = "0xACCF50", VA = "0x10ACE150")]
    public UnitAbilityListExModel(bool isEdit = true, bool isHide = false)
    {
    }

    [Token(Token = "0x600E7A3")]
    [Address(RVA = "0xACDBA0", Offset = "0xACC9A0", VA = "0x10ACDBA0")]
    public void Initialize(UnitData unitData)
    {
    }

    [Token(Token = "0x600E7A4")]
    [Address(RVA = "0xACDEA0", Offset = "0xACCCA0", VA = "0x10ACDEA0")]
    public void SetData()
    {
    }

    [Token(Token = "0x600E7A5")]
    [Address(RVA = "0xACDD10", Offset = "0xACCB10", VA = "0x10ACDD10")]
    public void SetAbilityList()
    {
    }

    [Token(Token = "0x600E7A6")]
    [Address(RVA = "0xACDB70", Offset = "0xACC970", VA = "0x10ACDB70")]
    public int GetSlotLimit(EAbilitySlot slot) => new int();

    [Token(Token = "0x600E7A7")]
    [Address(RVA = "0xACE000", Offset = "0xACCE00", VA = "0x10ACE000")]
    public void SetModeList()
    {
    }

    [Token(Token = "0x600E7A8")]
    [Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")]
    public List<AbilityData> GetAbilityList(int index) => (List<AbilityData>) null;

    [Token(Token = "0x600E7A9")]
    [Address(RVA = "0xACDAB0", Offset = "0xACC8B0", VA = "0x10ACDAB0")]
    public AbilityData GetAbilityData(int index) => (AbilityData) null;

    [Token(Token = "0x600E7AA")]
    [Address(RVA = "0xACDB10", Offset = "0xACC910", VA = "0x10ACDB10")]
    public UnitAbilityPanelModel.Mode GetItemMode(int index) => new UnitAbilityPanelModel.Mode();
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.Models.ConceptCardSlotsExModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x2003317")]
  public class ConceptCardSlotsExModel
  {
    [Token(Token = "0x400F0FC")]
    [FieldOffset(Offset = "0x8")]
    private int mSlotNum;
    [Token(Token = "0x400F0FD")]
    [FieldOffset(Offset = "0xC")]
    private bool mIsHideMode;
    [Token(Token = "0x400F0FE")]
    [FieldOffset(Offset = "0x10")]
    private UnitData mUnitData;
    [Token(Token = "0x400F0FF")]
    [FieldOffset(Offset = "0x14")]
    private bool mIsEditMode;
    [Token(Token = "0x400F100")]
    [FieldOffset(Offset = "0x18")]
    private List<ConceptCardData> mConceptCardDataList;
    [Token(Token = "0x400F101")]
    [FieldOffset(Offset = "0x1C")]
    private List<bool> mIsLockList;

    [Token(Token = "0x17001DA5")]
    public bool IsHideMode
    {
      [Token(Token = "0x600E108"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001DA6")]
    public UnitData UnitData
    {
      [Token(Token = "0x600E109"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x17001DA7")]
    public bool IsEditMode
    {
      [Token(Token = "0x600E10A"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600E10B")]
    [Address(RVA = "0x39F170", Offset = "0x39DF70", VA = "0x1039F170")]
    public ConceptCardSlotsExModel(bool isHide = false)
    {
    }

    [Token(Token = "0x600E10C")]
    [Address(RVA = "0xAAC930", Offset = "0xAAB730", VA = "0x10AAC930")]
    public void Initialize(UnitData unitData, bool editMode, int slotNum)
    {
    }

    [Token(Token = "0x600E10D")]
    [Address(RVA = "0xAACB50", Offset = "0xAAB950", VA = "0x10AACB50")]
    public void Setup(UnitData unitData, bool editMode)
    {
    }

    [Token(Token = "0x600E10E")]
    [Address(RVA = "0xAAC960", Offset = "0xAAB760", VA = "0x10AAC960")]
    private void SetList()
    {
    }

    [Token(Token = "0x600E10F")]
    [Address(RVA = "0xAAC890", Offset = "0xAAB690", VA = "0x10AAC890")]
    public ConceptCardData GetData(int i) => (ConceptCardData) null;

    [Token(Token = "0x600E110")]
    [Address(RVA = "0xAAC8E0", Offset = "0xAAB6E0", VA = "0x10AAC8E0")]
    public bool GetIsLock(int i) => new bool();
  }
}

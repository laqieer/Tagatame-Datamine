// Decompiled with JetBrains decompiler
// Type: SRPG.Models.ArtifactSlotsExModel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200330E")]
  public class ArtifactSlotsExModel
  {
    [Token(Token = "0x400F0B1")]
    private const long NONE_INDEX = -1;
    [Token(Token = "0x400F0B2")]
    [FieldOffset(Offset = "0x8")]
    private bool mIsHideMode;
    [Token(Token = "0x400F0B3")]
    [FieldOffset(Offset = "0xC")]
    private int mSlotNum;
    [Token(Token = "0x400F0B4")]
    [FieldOffset(Offset = "0x10")]
    private UnitData mUnitData;
    [Token(Token = "0x400F0B5")]
    [FieldOffset(Offset = "0x14")]
    private bool mIsEditMode;
    [Token(Token = "0x400F0B6")]
    [FieldOffset(Offset = "0x18")]
    private List<ArtifactData> mArtifactDataList;
    [Token(Token = "0x400F0B7")]
    [FieldOffset(Offset = "0x1C")]
    private List<bool> mIsLockList;
    [Token(Token = "0x400F0B8")]
    [FieldOffset(Offset = "0x20")]
    private long mSelectArtifactId;

    [Token(Token = "0x17001D7A")]
    public bool IsHideMode
    {
      [Token(Token = "0x600E098"), Address(RVA = "0x301190", Offset = "0x2FFF90", VA = "0x10301190")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001D7B")]
    public UnitData UnitData
    {
      [Token(Token = "0x600E099"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (UnitData) null;
      }
    }

    [Token(Token = "0x17001D7C")]
    public bool IsEditMode
    {
      [Token(Token = "0x600E09A"), Address(RVA = "0x2CE1E0", Offset = "0x2CCFE0", VA = "0x102CE1E0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001D7D")]
    public List<ArtifactData> ArtifactDataList
    {
      [Token(Token = "0x600E09B"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (List<ArtifactData>) null;
      }
    }

    [Token(Token = "0x17001D7E")]
    public long SelectArtifactId
    {
      [Token(Token = "0x600E09C"), Address(RVA = "0x34F490", Offset = "0x34E290", VA = "0x1034F490")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x600E09D")]
    [Address(RVA = "0xAA7D90", Offset = "0xAA6B90", VA = "0x10AA7D90")]
    public ArtifactSlotsExModel(bool isHide = false)
    {
    }

    [Token(Token = "0x600E09E")]
    [Address(RVA = "0xAA76C0", Offset = "0xAA64C0", VA = "0x10AA76C0")]
    public void Initialize(UnitData unitData, bool editMode, int slotNum)
    {
    }

    [Token(Token = "0x600E09F")]
    [Address(RVA = "0xAA7D50", Offset = "0xAA6B50", VA = "0x10AA7D50")]
    public void Setup(UnitData unitData, bool editMode)
    {
    }

    [Token(Token = "0x600E0A0")]
    [Address(RVA = "0xAA79B0", Offset = "0xAA67B0", VA = "0x10AA79B0")]
    private void SetList()
    {
    }

    [Token(Token = "0x600E0A1")]
    [Address(RVA = "0xAA7C90", Offset = "0xAA6A90", VA = "0x10AA7C90")]
    public void SetSelectSlotArtifact(int slotIndex)
    {
    }

    [Token(Token = "0x600E0A2")]
    [Address(RVA = "0xAA7810", Offset = "0xAA6610", VA = "0x10AA7810")]
    public void OverrideData()
    {
    }

    [Token(Token = "0x600E0A3")]
    [Address(RVA = "0xAA6ED0", Offset = "0xAA5CD0", VA = "0x10AA6ED0")]
    public ArtifactData GetData(int index) => (ArtifactData) null;

    [Token(Token = "0x600E0A4")]
    [Address(RVA = "0xAA6F30", Offset = "0xAA5D30", VA = "0x10AA6F30")]
    public bool GetIsLock(int index) => new bool();

    [Token(Token = "0x600E0A5")]
    [Address(RVA = "0xAA7700", Offset = "0xAA6500", VA = "0x10AA7700")]
    public bool IsLockedArtifactSlot(int slot) => new bool();

    [Token(Token = "0x600E0A6")]
    [Address(RVA = "0xAA6DF0", Offset = "0xAA5BF0", VA = "0x10AA6DF0")]
    public int GetArtifactIndex(ArtifactTypes type) => new int();

    [Token(Token = "0x600E0A7")]
    [Address(RVA = "0xAA6F90", Offset = "0xAA5D90", VA = "0x10AA6F90")]
    public List<ArtifactData> GetNewEquipArtifactList(
      ArtifactData equipArtifact,
      ArtifactTypes type)
    {
      return (List<ArtifactData>) null;
    }

    [Token(Token = "0x600E0A8")]
    [Address(RVA = "0xAA7230", Offset = "0xAA6030", VA = "0x10AA7230")]
    private List<ArtifactData> GetSingleEquipArtifactList(int index) => (List<ArtifactData>) null;

    [Token(Token = "0x600E0A9")]
    [Address(RVA = "0xAA6C90", Offset = "0xAA5A90", VA = "0x10AA6C90")]
    private List<ArtifactData> GetAccessoryList(int index) => (List<ArtifactData>) null;

    [Token(Token = "0x600E0AA")]
    [Address(RVA = "0xAA6EB0", Offset = "0xAA5CB0", VA = "0x10AA6EB0")]
    public ArtifactTypes GetArtifactSlotType(int index) => new ArtifactTypes();
  }
}

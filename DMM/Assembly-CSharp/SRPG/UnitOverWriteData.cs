// Decompiled with JetBrains decompiler
// Type: SRPG.UnitOverWriteData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002E21")]
  public class UnitOverWriteData
  {
    [Token(Token = "0x400E5F9")]
    [FieldOffset(Offset = "0x8")]
    private long mUniqueID;
    [Token(Token = "0x400E5FA")]
    [FieldOffset(Offset = "0x10")]
    private long mJobUniqueID;
    [Token(Token = "0x400E5FB")]
    [FieldOffset(Offset = "0x18")]
    private long[] mAbilities;
    [Token(Token = "0x400E5FC")]
    [FieldOffset(Offset = "0x1C")]
    private long[] mArtifacts;
    [Token(Token = "0x400E5FD")]
    [FieldOffset(Offset = "0x20")]
    private ConceptCardData[] mConceptCards;
    [Token(Token = "0x400E5FE")]
    [FieldOffset(Offset = "0x24")]
    private bool mLeaderSkillIsConceptCard;
    [Token(Token = "0x400E5FF")]
    [FieldOffset(Offset = "0x28")]
    private long[] mRunes;
    [Token(Token = "0x400E600")]
    [FieldOffset(Offset = "0x2C")]
    private InvalidSkillData mInvalidSkill;
    [Token(Token = "0x400E601")]
    [FieldOffset(Offset = "0x30")]
    private List<CrystalData> mCrystals;

    [Token(Token = "0x17001CD0")]
    public long UniqueID
    {
      [Token(Token = "0x600D999"), Address(RVA = "0x305C20", Offset = "0x304A20", VA = "0x10305C20")] get
      {
        return new long();
      }
      [Token(Token = "0x600D99A"), Address(RVA = "0x2E2BB0", Offset = "0x2E19B0", VA = "0x102E2BB0")] set
      {
      }
    }

    [Token(Token = "0x17001CD1")]
    public long JobUniqueID
    {
      [Token(Token = "0x600D99B"), Address(RVA = "0x361230", Offset = "0x360030", VA = "0x10361230")] get
      {
        return new long();
      }
      [Token(Token = "0x600D99C"), Address(RVA = "0x374A90", Offset = "0x373890", VA = "0x10374A90")] set
      {
      }
    }

    [Token(Token = "0x17001CD2")]
    public long[] Abilities
    {
      [Token(Token = "0x600D99D"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (long[]) null;
      }
      [Token(Token = "0x600D99E"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] set
      {
      }
    }

    [Token(Token = "0x17001CD3")]
    public long[] Artifacts
    {
      [Token(Token = "0x600D99F"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (long[]) null;
      }
      [Token(Token = "0x600D9A0"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] set
      {
      }
    }

    [Token(Token = "0x17001CD4")]
    public ConceptCardData[] ConceptCards
    {
      [Token(Token = "0x600D9A1"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (ConceptCardData[]) null;
      }
      [Token(Token = "0x600D9A2"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x17001CD5")]
    public bool LeaderSkillIsConceptCard
    {
      [Token(Token = "0x600D9A3"), Address(RVA = "0x2A5A90", Offset = "0x2A4890", VA = "0x102A5A90")] get
      {
        return new bool();
      }
      [Token(Token = "0x600D9A4"), Address(RVA = "0x2A5AD0", Offset = "0x2A48D0", VA = "0x102A5AD0")] set
      {
      }
    }

    [Token(Token = "0x17001CD6")]
    public long[] Runes
    {
      [Token(Token = "0x600D9A5"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (long[]) null;
      }
      [Token(Token = "0x600D9A6"), Address(RVA = "0x2A09F0", Offset = "0x29F7F0", VA = "0x102A09F0")] set
      {
      }
    }

    [Token(Token = "0x17001CD7")]
    public InvalidSkillData InvalidSkill
    {
      [Token(Token = "0x600D9A7"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (InvalidSkillData) null;
      }
      [Token(Token = "0x600D9A8"), Address(RVA = "0x27FBD0", Offset = "0x27E9D0", VA = "0x1027FBD0")] set
      {
      }
    }

    [Token(Token = "0x17001CD8")]
    public List<CrystalData> Crystals
    {
      [Token(Token = "0x600D9A9"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (List<CrystalData>) null;
      }
      [Token(Token = "0x600D9AA"), Address(RVA = "0x34C010", Offset = "0x34AE10", VA = "0x1034C010")] set
      {
      }
    }

    [Token(Token = "0x600D9AB")]
    [Address(RVA = "0xA50250", Offset = "0xA4F050", VA = "0x10A50250")]
    public void Deserialize(JSON_UnitOverWriteData json)
    {
    }

    [Token(Token = "0x600D9AC")]
    [Address(RVA = "0xA505A0", Offset = "0xA4F3A0", VA = "0x10A505A0")]
    public bool IsEquipConceptCard(long iid) => new bool();

    [Token(Token = "0x600D9AD")]
    [Address(RVA = "0xA4FFC0", Offset = "0xA4EDC0", VA = "0x10A4FFC0")]
    public int[] CreateConceptCardIds() => (int[]) null;

    [Token(Token = "0x600D9AE")]
    [Address(RVA = "0xA500C0", Offset = "0xA4EEC0", VA = "0x10A500C0")]
    public long[] CreateCrystalIds() => (long[]) null;

    [Token(Token = "0x600D9AF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public UnitOverWriteData()
    {
    }
  }
}

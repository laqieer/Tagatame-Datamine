// Decompiled with JetBrains decompiler
// Type: SRPG.UnitOverWriteCache
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002E22")]
  public class UnitOverWriteCache
  {
    [Token(Token = "0x400E60B")]
    [FieldOffset(Offset = "0x2C")]
    public SpriteSheet mLoadSheet;

    [Token(Token = "0x17001CD9")]
    public List<UnitData> mQuestUnits
    {
      [Token(Token = "0x600D9B0"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (List<UnitData>) null;
      }
      [Token(Token = "0x600D9B1"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] private set
      {
      }
    }

    [Token(Token = "0x17001CDA")]
    public List<UnitData> mArenaUnits
    {
      [Token(Token = "0x600D9B2"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (List<UnitData>) null;
      }
      [Token(Token = "0x600D9B3"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] private set
      {
      }
    }

    [Token(Token = "0x17001CDB")]
    public List<UnitData> mArenaDefUnits
    {
      [Token(Token = "0x600D9B4"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (List<UnitData>) null;
      }
      [Token(Token = "0x600D9B5"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] private set
      {
      }
    }

    [Token(Token = "0x17001CDC")]
    public List<UnitData> mSupportUnits
    {
      [Token(Token = "0x600D9B6"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (List<UnitData>) null;
      }
      [Token(Token = "0x600D9B7"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] private set
      {
      }
    }

    [Token(Token = "0x17001CDD")]
    public List<UnitData> mGvGUnits
    {
      [Token(Token = "0x600D9B8"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (List<UnitData>) null;
      }
      [Token(Token = "0x600D9B9"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
      {
      }
    }

    [Token(Token = "0x17001CDE")]
    public List<UnitData> mLeagueMatchAtkUnits
    {
      [Token(Token = "0x600D9BA"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (List<UnitData>) null;
      }
      [Token(Token = "0x600D9BB"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] private set
      {
      }
    }

    [Token(Token = "0x17001CDF")]
    public List<UnitData> mLeagueMatchAtkSetUnits
    {
      [Token(Token = "0x600D9BC"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (List<UnitData>) null;
      }
      [Token(Token = "0x600D9BD"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] private set
      {
      }
    }

    [Token(Token = "0x17001CE0")]
    public List<UnitData> mLeagueMatchDefUnits
    {
      [Token(Token = "0x600D9BE"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (List<UnitData>) null;
      }
      [Token(Token = "0x600D9BF"), Address(RVA = "0x35B840", Offset = "0x35A640", VA = "0x1035B840")] private set
      {
      }
    }

    [Token(Token = "0x17001CE1")]
    public List<UnitData> mLeagueMatchShamUnits
    {
      [Token(Token = "0x600D9C0"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (List<UnitData>) null;
      }
      [Token(Token = "0x600D9C1"), Address(RVA = "0x2A09F0", Offset = "0x29F7F0", VA = "0x102A09F0")] private set
      {
      }
    }

    [Token(Token = "0x600D9C2")]
    [Address(RVA = "0xA4F670", Offset = "0xA4E470", VA = "0x10A4F670")]
    public void ClearCache()
    {
    }

    [Token(Token = "0x600D9C3")]
    [Address(RVA = "0xA4FFA0", Offset = "0xA4EDA0", VA = "0x10A4FFA0")]
    public void ReloadUnits()
    {
    }

    [Token(Token = "0x600D9C4")]
    [Address(RVA = "0xA4F680", Offset = "0xA4E480", VA = "0x10A4F680")]
    private void ClearUnits()
    {
    }

    [Token(Token = "0x600D9C5")]
    [Address(RVA = "0xA4FB60", Offset = "0xA4E960", VA = "0x10A4FB60")]
    public void LoadUnits(bool isQuestOnly = false)
    {
    }

    [Token(Token = "0x600D9C6")]
    [Address(RVA = "0xA4F840", Offset = "0xA4E640", VA = "0x10A4F840")]
    public void LoadUnitsNotClearUnits(bool isQuestOnly = false)
    {
    }

    [Token(Token = "0x600D9C7")]
    [Address(RVA = "0xA4F730", Offset = "0xA4E530", VA = "0x10A4F730")]
    public List<UnitData> GetUnitDataList(eOverWritePartyType partyType) => (List<UnitData>) null;

    [Token(Token = "0x600D9C8")]
    [Address(RVA = "0xA4F790", Offset = "0xA4E590", VA = "0x10A4F790")]
    public SpriteSheet LoadSpriteSheet() => (SpriteSheet) null;

    [Token(Token = "0x600D9C9")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public UnitOverWriteCache()
    {
    }
  }
}

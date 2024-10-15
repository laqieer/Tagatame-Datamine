// Decompiled with JetBrains decompiler
// Type: SRPG.CombatPowerData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001187")]
  public class CombatPowerData
  {
    [Token(Token = "0x4003F8C")]
    [FieldOffset(Offset = "0x8")]
    private int m_TotalCombatPower;
    [Token(Token = "0x4003F8D")]
    [FieldOffset(Offset = "0xC")]
    private int m_TotalFireCombatPower;
    [Token(Token = "0x4003F8E")]
    [FieldOffset(Offset = "0x10")]
    private int m_TotalWaterCombatPower;
    [Token(Token = "0x4003F8F")]
    [FieldOffset(Offset = "0x14")]
    private int m_TotalThunderCombatPower;
    [Token(Token = "0x4003F90")]
    [FieldOffset(Offset = "0x18")]
    private int m_TotalWindCombatPower;
    [Token(Token = "0x4003F91")]
    [FieldOffset(Offset = "0x1C")]
    private int m_TotalShineCombatPower;
    [Token(Token = "0x4003F92")]
    [FieldOffset(Offset = "0x20")]
    private int m_TotalDarkCombatPower;
    [Token(Token = "0x4003F93")]
    [FieldOffset(Offset = "0x24")]
    private int m_HighestCombatPower;
    [Token(Token = "0x4003F94")]
    [FieldOffset(Offset = "0x28")]
    private bool m_IsChanged;
    [Token(Token = "0x4003F95")]
    [FieldOffset(Offset = "0x2C")]
    private List<UnitCombatPowers> mUnitsPowerList;

    [Token(Token = "0x1700083A")]
    public int TotalCombatPower
    {
      [Token(Token = "0x6004AE2"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700083B")]
    public int TotalFireCombatPower
    {
      [Token(Token = "0x6004AE3"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700083C")]
    public int TotalWaterCombatPower
    {
      [Token(Token = "0x6004AE4"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700083D")]
    public int TotalThunderCombatPower
    {
      [Token(Token = "0x6004AE5"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700083E")]
    public int TotalWindCombatPower
    {
      [Token(Token = "0x6004AE6"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700083F")]
    public int TotalShineCombatPower
    {
      [Token(Token = "0x6004AE7"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000840")]
    public int TotalDarkCombatPower
    {
      [Token(Token = "0x6004AE8"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000841")]
    public int HighestCombatPower
    {
      [Token(Token = "0x6004AE9"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000842")]
    public bool IsChanged
    {
      [Token(Token = "0x6004AEA"), Address(RVA = "0x34F470", Offset = "0x34E270", VA = "0x1034F470")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17000843")]
    public List<UnitCombatPowers> UnitsPowerList
    {
      [Token(Token = "0x6004AEB"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (List<UnitCombatPowers>) null;
      }
    }

    [Token(Token = "0x6004AEC")]
    [Address(RVA = "0x11FEB80", Offset = "0x11FD980", VA = "0x111FEB80")]
    private CombatPowerData Clone() => (CombatPowerData) null;

    [Token(Token = "0x6004AED")]
    [Address(RVA = "0x11FEC60", Offset = "0x11FDA60", VA = "0x111FEC60")]
    private bool IsDifferentValues(CombatPowerData compareTarget) => new bool();

    [Token(Token = "0x6004AEE")]
    [Address(RVA = "0x11FEAF0", Offset = "0x11FD8F0", VA = "0x111FEAF0")]
    private void ClearValues()
    {
    }

    [Token(Token = "0x6004AEF")]
    [Address(RVA = "0x500530", Offset = "0x4FF330", VA = "0x10500530")]
    public void ClearChangeFlag()
    {
    }

    [Token(Token = "0x6004AF0")]
    [Address(RVA = "0x11FECC0", Offset = "0x11FDAC0", VA = "0x111FECC0")]
    public void UpdateCombatPower(IEnumerable<UnitData> units)
    {
    }

    [Token(Token = "0x6004AF1")]
    [Address(RVA = "0x11FE950", Offset = "0x11FD750", VA = "0x111FE950")]
    public static int CalcTargetUnitsCombatPower(List<string> unitInames) => new int();

    [Token(Token = "0x6004AF2")]
    [Address(RVA = "0x11FE8B0", Offset = "0x11FD6B0", VA = "0x111FE8B0")]
    public static int CalcTargetUnitsCombatPower(List<UnitData> units) => new int();

    [Token(Token = "0x6004AF3")]
    [Address(RVA = "0x11FF260", Offset = "0x11FE060", VA = "0x111FF260")]
    public CombatPowerData()
    {
    }
  }
}

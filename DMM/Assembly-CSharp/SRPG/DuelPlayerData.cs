// Decompiled with JetBrains decompiler
// Type: SRPG.DuelPlayerData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002317")]
  [MessagePackObject(true)]
  [Serializable]
  public class DuelPlayerData : ICombatPowerContent
  {
    [Token(Token = "0x4009C8B")]
    [FieldOffset(Offset = "0x8")]
    private string mFuid;
    [Token(Token = "0x4009C8C")]
    [FieldOffset(Offset = "0xC")]
    private string mName;
    [Token(Token = "0x4009C8D")]
    [FieldOffset(Offset = "0x10")]
    private string mAward;
    [Token(Token = "0x4009C8E")]
    [FieldOffset(Offset = "0x14")]
    private int mLv;
    [Token(Token = "0x4009C8F")]
    [FieldOffset(Offset = "0x18")]
    private int mRank;
    [Token(Token = "0x4009C90")]
    [FieldOffset(Offset = "0x1C")]
    private string mPointStr;
    [Token(Token = "0x4009C91")]
    [FieldOffset(Offset = "0x20")]
    private float mPoint;
    [Token(Token = "0x4009C92")]
    [FieldOffset(Offset = "0x28")]
    private DateTime mLastBattleAt;
    [Token(Token = "0x4009C93")]
    [FieldOffset(Offset = "0x30")]
    private UnitData[] mUnits;
    [Token(Token = "0x4009C94")]
    [FieldOffset(Offset = "0x34")]
    private ViewGuildData mGuild;
    [Token(Token = "0x4009C95")]
    [FieldOffset(Offset = "0x38")]
    private List<AdventureDataBase> mAdvDataBaseList;
    [Token(Token = "0x4009C96")]
    [FieldOffset(Offset = "0x3C")]
    private List<BondData> mBondDatas;

    [Token(Token = "0x17001508")]
    public string Fuid
    {
      [Token(Token = "0x60096DC"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001509")]
    public string Name
    {
      [Token(Token = "0x60096DD"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700150A")]
    public string Award
    {
      [Token(Token = "0x60096DE"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700150B")]
    public int Lv
    {
      [Token(Token = "0x60096DF"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700150C")]
    public int Rank
    {
      [Token(Token = "0x60096E0"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x1700150D")]
    public string PointStr
    {
      [Token(Token = "0x60096E1"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700150E")]
    public DateTime LastBattleAt
    {
      [Token(Token = "0x60096E2"), Address(RVA = "0x31F950", Offset = "0x31E750", VA = "0x1031F950")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x1700150F")]
    public UnitData[] Units
    {
      [Token(Token = "0x60096E3"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (UnitData[]) null;
      }
    }

    [Token(Token = "0x17001510")]
    public ViewGuildData Guild
    {
      [Token(Token = "0x60096E4"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return (ViewGuildData) null;
      }
    }

    [Token(Token = "0x17001511")]
    public long CombatPower
    {
      [Token(Token = "0x60096E5"), Address(RVA = "0x599C30", Offset = "0x598A30", VA = "0x10599C30", Slot = "4")] get
      {
        return new long();
      }
    }

    [Token(Token = "0x17001512")]
    public float Point
    {
      [Token(Token = "0x60096E6"), Address(RVA = "0x3A3990", Offset = "0x3A2790", VA = "0x103A3990")] get
      {
        return new float();
      }
    }

    [Token(Token = "0x17001513")]
    public List<AdventureDataBase> AdvDataBaseList
    {
      [Token(Token = "0x60096E7"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (List<AdventureDataBase>) null;
      }
    }

    [Token(Token = "0x17001514")]
    public List<BondData> BondDatas
    {
      [Token(Token = "0x60096E8"), Address(RVA = "0x288010", Offset = "0x286E10", VA = "0x10288010")] get
      {
        return (List<BondData>) null;
      }
    }

    [Token(Token = "0x60096E9")]
    [Address(RVA = "0x599710", Offset = "0x598510", VA = "0x10599710")]
    public bool Deserialize(JSON_DuelPlayerData json) => new bool();

    [Token(Token = "0x60096EA")]
    [Address(RVA = "0x599480", Offset = "0x598280", VA = "0x10599480")]
    public bool CreateUserData() => new bool();

    [Token(Token = "0x60096EB")]
    [Address(RVA = "0x599A70", Offset = "0x598870", VA = "0x10599A70")]
    public List<Json_Unit> GetUnitDataString() => (List<Json_Unit>) null;

    [Token(Token = "0x60096EC")]
    [Address(RVA = "0x599B80", Offset = "0x598980", VA = "0x10599B80")]
    public DuelPlayerData()
    {
    }
  }
}

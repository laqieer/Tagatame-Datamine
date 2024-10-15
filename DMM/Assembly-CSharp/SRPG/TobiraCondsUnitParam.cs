// Decompiled with JetBrains decompiler
// Type: SRPG.TobiraCondsUnitParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D60")]
  public class TobiraCondsUnitParam
  {
    [Token(Token = "0x40073A5")]
    [FieldOffset(Offset = "0x8")]
    private string mId;
    [Token(Token = "0x40073A6")]
    [FieldOffset(Offset = "0xC")]
    private string mUnitIname;
    [Token(Token = "0x40073A7")]
    [FieldOffset(Offset = "0x10")]
    private int mLevel;
    [Token(Token = "0x40073A8")]
    [FieldOffset(Offset = "0x14")]
    private int mAwakeLevel;
    [Token(Token = "0x40073A9")]
    [FieldOffset(Offset = "0x18")]
    private List<TobiraCondsUnitParam.CondJob> mJobs;
    [Token(Token = "0x40073AA")]
    [FieldOffset(Offset = "0x1C")]
    private TobiraParam.Category mCategory;
    [Token(Token = "0x40073AB")]
    [FieldOffset(Offset = "0x20")]
    private int mTobiraLv;
    [Token(Token = "0x40073AC")]
    [FieldOffset(Offset = "0x28")]
    private TobiraCondsUnitParam.ConditionsDetail mConditionsDetail;

    [Token(Token = "0x17001001")]
    public string Id
    {
      [Token(Token = "0x6007841"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001002")]
    public string UnitIname
    {
      [Token(Token = "0x6007842"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001003")]
    public int Level
    {
      [Token(Token = "0x6007843"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001004")]
    public int AwakeLevel
    {
      [Token(Token = "0x6007844"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001005")]
    public TobiraParam.Category TobiraCategory
    {
      [Token(Token = "0x6007845"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return new TobiraParam.Category();
      }
    }

    [Token(Token = "0x17001006")]
    public int TobiraLv
    {
      [Token(Token = "0x6007846"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001007")]
    public List<TobiraCondsUnitParam.CondJob> Jobs
    {
      [Token(Token = "0x6007847"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (List<TobiraCondsUnitParam.CondJob>) null;
      }
    }

    [Token(Token = "0x17001008")]
    public bool IsSelfUnit
    {
      [Token(Token = "0x6007848"), Address(RVA = "0x3A4260", Offset = "0x3A3060", VA = "0x103A4260")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6007849")]
    [Address(RVA = "0x3A3E00", Offset = "0x3A2C00", VA = "0x103A3E00")]
    public void Deserialize(JSON_TobiraCondsUnitParam json)
    {
    }

    [Token(Token = "0x600784A")]
    [Address(RVA = "0x3A41D0", Offset = "0x3A2FD0", VA = "0x103A41D0")]
    private void UpdateConditionsFlag()
    {
    }

    [Token(Token = "0x600784B")]
    [Address(RVA = "0x3A4010", Offset = "0x3A2E10", VA = "0x103A4010")]
    public bool HasFlag(TobiraCondsUnitParam.ConditionsDetail flag) => new bool();

    [Token(Token = "0x600784C")]
    [Address(RVA = "0x3A4040", Offset = "0x3A2E40", VA = "0x103A4040")]
    public bool IsJobLvClear(UnitData unit) => new bool();

    [Token(Token = "0x600784D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TobiraCondsUnitParam()
    {
    }

    [Token(Token = "0x2001D61")]
    public class CondJob
    {
      [Token(Token = "0x40073AD")]
      [FieldOffset(Offset = "0x8")]
      private string mJobIname;
      [Token(Token = "0x40073AE")]
      [FieldOffset(Offset = "0xC")]
      private int mJobLevel;

      [Token(Token = "0x17001009")]
      public string JobIname
      {
        [Token(Token = "0x600784E"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x1700100A")]
      public int JobLevel
      {
        [Token(Token = "0x600784F"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x6007850")]
      [Address(RVA = "0x3217D0", Offset = "0x3205D0", VA = "0x103217D0")]
      public CondJob(string job_iname, int job_level)
      {
      }
    }

    [Token(Token = "0x2001D62")]
    [Flags]
    public enum ConditionsDetail : long
    {
      [Token(Token = "0x40073B0")] IsSelf = 1,
      [Token(Token = "0x40073B1")] IsUnitLv = 2,
      [Token(Token = "0x40073B2")] IsAwake = 4,
      [Token(Token = "0x40073B3")] IsJobLv = 8,
      [Token(Token = "0x40073B4")] IsTobiraLv = 16, // 0x0000000000000010
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.AbilityConditions
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DCA")]
  public class AbilityConditions
  {
    [Token(Token = "0x40076D3")]
    [FieldOffset(Offset = "0x8")]
    public AbilityParam m_AbilityParam;
    [Token(Token = "0x40076D4")]
    [FieldOffset(Offset = "0xC")]
    public List<UnitParam> m_CondsUnits;
    [Token(Token = "0x40076D5")]
    [FieldOffset(Offset = "0x10")]
    public List<JobParam> m_CondsJobs;
    [Token(Token = "0x40076D6")]
    [FieldOffset(Offset = "0x14")]
    private string m_CondsBirth;
    [Token(Token = "0x40076D7")]
    [FieldOffset(Offset = "0x18")]
    private ESex m_CondsSex;
    [Token(Token = "0x40076D8")]
    [FieldOffset(Offset = "0x1C")]
    private EElement m_CondsElem;

    [Token(Token = "0x17001077")]
    private bool enableCondsUnits
    {
      [Token(Token = "0x60079D5"), Address(RVA = "0x3B3020", Offset = "0x3B1E20", VA = "0x103B3020")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001078")]
    private bool enableCondsJobs
    {
      [Token(Token = "0x60079D6"), Address(RVA = "0x3B2FD0", Offset = "0x3B1DD0", VA = "0x103B2FD0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001079")]
    private bool enableCondsBirth
    {
      [Token(Token = "0x60079D7"), Address(RVA = "0x3B2FA0", Offset = "0x3B1DA0", VA = "0x103B2FA0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700107A")]
    private bool enableCondsSex
    {
      [Token(Token = "0x60079D8"), Address(RVA = "0x3B3010", Offset = "0x3B1E10", VA = "0x103B3010")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700107B")]
    private bool enableCondsElem
    {
      [Token(Token = "0x60079D9"), Address(RVA = "0x3B2FC0", Offset = "0x3B1DC0", VA = "0x103B2FC0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x60079DA")]
    [Address(RVA = "0x3B2AF0", Offset = "0x3B18F0", VA = "0x103B2AF0")]
    public void Setup(AbilityParam abil, MasterParam master)
    {
    }

    [Token(Token = "0x60079DB")]
    [Address(RVA = "0x3B2E70", Offset = "0x3B1C70", VA = "0x103B2E70")]
    private static string SexToString(ESex sex) => (string) null;

    [Token(Token = "0x60079DC")]
    [Address(RVA = "0x3B1BB0", Offset = "0x3B09B0", VA = "0x103B1BB0")]
    private static string ElementToString(EElement element) => (string) null;

    [Token(Token = "0x60079DD")]
    [Address(RVA = "0x3B1C40", Offset = "0x3B0A40", VA = "0x103B1C40")]
    private static string InternalMakeConditionsText(params string[] arg) => (string) null;

    [Token(Token = "0x60079DE")]
    [Address(RVA = "0x3B1D20", Offset = "0x3B0B20", VA = "0x103B1D20")]
    public string MakeConditionsText() => (string) null;

    [Token(Token = "0x60079DF")]
    [Address(RVA = "0x3B2EF0", Offset = "0x3B1CF0", VA = "0x103B2EF0")]
    public AbilityConditions()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.ConditionsResult_JobLv
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000EA3")]
  public class ConditionsResult_JobLv : ConditionsResult_Unit
  {
    [Token(Token = "0x4002CEE")]
    [FieldOffset(Offset = "0x1C")]
    public List<ConditionsResult_JobLv.CondsJob> mCondJobs;
    [Token(Token = "0x4002CEF")]
    [FieldOffset(Offset = "0x20")]
    private JobParam mCurrentJobParam;

    [Token(Token = "0x170004CD")]
    public override string text
    {
      [Token(Token = "0x6003CEE"), Address(RVA = "0x10F3B40", Offset = "0x10F2940", VA = "0x110F3B40", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170004CE")]
    public override string errorText
    {
      [Token(Token = "0x6003CEF"), Address(RVA = "0x10F3B10", Offset = "0x10F2910", VA = "0x110F3B10", Slot = "5")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170004CF")]
    public JobParam CurrentJobParam
    {
      [Token(Token = "0x6003CF0"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (JobParam) null;
      }
    }

    [Token(Token = "0x6003CF1")]
    [Address(RVA = "0x10F36B0", Offset = "0x10F24B0", VA = "0x110F36B0")]
    public ConditionsResult_JobLv(
      UnitData unitData,
      UnitParam unitParam,
      List<TobiraCondsUnitParam.CondJob> condsJobs)
    {
    }

    [Token(Token = "0x2000EA4")]
    public class CondsJob
    {
      [Token(Token = "0x4002CF0")]
      [FieldOffset(Offset = "0x8")]
      public string mCondsJobIname;
      [Token(Token = "0x4002CF1")]
      [FieldOffset(Offset = "0xC")]
      public int mCondsJobLv;
      [Token(Token = "0x4002CF2")]
      [FieldOffset(Offset = "0x10")]
      public JobData mJobData;
      [Token(Token = "0x4002CF3")]
      [FieldOffset(Offset = "0x14")]
      public JobParam mJobParam;

      [Token(Token = "0x6003CF2")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public CondsJob()
      {
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_TobiraCondsUnitParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D5E")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_TobiraCondsUnitParam
  {
    [Token(Token = "0x400739C")]
    [FieldOffset(Offset = "0x8")]
    public string id;
    [Token(Token = "0x400739D")]
    [FieldOffset(Offset = "0xC")]
    public string unit_iname;
    [Token(Token = "0x400739E")]
    [FieldOffset(Offset = "0x10")]
    public int lv;
    [Token(Token = "0x400739F")]
    [FieldOffset(Offset = "0x14")]
    public int awake_lv;
    [Token(Token = "0x40073A0")]
    [FieldOffset(Offset = "0x18")]
    public JSON_TobiraCondsUnitParam.JobCond[] jobs;
    [Token(Token = "0x40073A1")]
    [FieldOffset(Offset = "0x1C")]
    public int category;
    [Token(Token = "0x40073A2")]
    [FieldOffset(Offset = "0x20")]
    public int tobira_lv;

    [Token(Token = "0x600783F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_TobiraCondsUnitParam()
    {
    }

    [Token(Token = "0x2001D5F")]
    [MessagePackObject(true)]
    [Serializable]
    public class JobCond
    {
      [Token(Token = "0x40073A3")]
      [FieldOffset(Offset = "0x8")]
      public string job_iname;
      [Token(Token = "0x40073A4")]
      [FieldOffset(Offset = "0xC")]
      public int job_lv;

      [Token(Token = "0x6007840")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public JobCond()
      {
      }
    }
  }
}

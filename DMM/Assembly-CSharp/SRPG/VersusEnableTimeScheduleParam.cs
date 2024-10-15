// Decompiled with JetBrains decompiler
// Type: SRPG.VersusEnableTimeScheduleParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EBD")]
  public class VersusEnableTimeScheduleParam
  {
    [Token(Token = "0x40080FC")]
    [FieldOffset(Offset = "0x8")]
    private string mBegin;
    [Token(Token = "0x40080FD")]
    [FieldOffset(Offset = "0xC")]
    private string mOpen;
    [Token(Token = "0x40080FE")]
    [FieldOffset(Offset = "0x10")]
    private string mQuestIname;
    [Token(Token = "0x40080FF")]
    [FieldOffset(Offset = "0x14")]
    private List<DateTime> mAddDateList;
    [Token(Token = "0x4008100")]
    [FieldOffset(Offset = "0x18")]
    private string mUnitCond;

    [Token(Token = "0x170011A0")]
    public string Begin
    {
      [Token(Token = "0x6007DE4"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170011A1")]
    public string Open
    {
      [Token(Token = "0x6007DE5"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170011A2")]
    public string QuestIname
    {
      [Token(Token = "0x6007DE6"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x170011A3")]
    public List<DateTime> AddDateList
    {
      [Token(Token = "0x6007DE7"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (List<DateTime>) null;
      }
    }

    [Token(Token = "0x170011A4")]
    public string UnitCond
    {
      [Token(Token = "0x6007DE8"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6007DE9")]
    [Address(RVA = "0x3FA710", Offset = "0x3F9510", VA = "0x103FA710")]
    public bool Deserialize(JSON_VersusEnableTimeScheduleParam json) => new bool();

    [Token(Token = "0x6007DEA")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public VersusEnableTimeScheduleParam()
    {
    }
  }
}

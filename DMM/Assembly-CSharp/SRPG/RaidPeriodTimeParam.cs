// Decompiled with JetBrains decompiler
// Type: SRPG.RaidPeriodTimeParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C84")]
  public class RaidPeriodTimeParam : RaidMasterParam<JSON_RaidPeriodTimeParam>
  {
    [Token(Token = "0x4007009")]
    [FieldOffset(Offset = "0x8")]
    private int mId;
    [Token(Token = "0x400700A")]
    [FieldOffset(Offset = "0xC")]
    private int mPeriodId;
    [Token(Token = "0x400700B")]
    [FieldOffset(Offset = "0x10")]
    private DateTime mBeginAt;
    [Token(Token = "0x400700C")]
    [FieldOffset(Offset = "0x18")]
    private DateTime mEndAt;
    [Token(Token = "0x400700D")]
    [FieldOffset(Offset = "0x20")]
    private List<RaidPeriodTimeScheduleParam> mSchedule;

    [Token(Token = "0x17000F2F")]
    public int Id
    {
      [Token(Token = "0x6007597"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F30")]
    public int PeriodId
    {
      [Token(Token = "0x6007598"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F31")]
    public DateTime BeginAt
    {
      [Token(Token = "0x6007599"), Address(RVA = "0x31CBE0", Offset = "0x31B9E0", VA = "0x1031CBE0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000F32")]
    public DateTime EndAt
    {
      [Token(Token = "0x600759A"), Address(RVA = "0x31CBF0", Offset = "0x31B9F0", VA = "0x1031CBF0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000F33")]
    public List<RaidPeriodTimeScheduleParam> Schedule
    {
      [Token(Token = "0x600759B"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (List<RaidPeriodTimeScheduleParam>) null;
      }
    }

    [Token(Token = "0x600759C")]
    [Address(RVA = "0x393790", Offset = "0x392590", VA = "0x10393790", Slot = "4")]
    public override bool Deserialize(JSON_RaidPeriodTimeParam json) => new bool();

    [Token(Token = "0x600759D")]
    [Address(RVA = "0x3939D0", Offset = "0x3927D0", VA = "0x103939D0")]
    public RaidPeriodTimeParam()
    {
    }
  }
}

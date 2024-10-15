// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchAttackScheduleParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BCB")]
  [MessagePackObject(true)]
  public class LeagueMatchAttackScheduleParam
  {
    [Token(Token = "0x4006A72")]
    [FieldOffset(Offset = "0x8")]
    private DateTime mBegin_at;
    [Token(Token = "0x4006A73")]
    [FieldOffset(Offset = "0x10")]
    private DateTime mEnd_at;

    [Token(Token = "0x17000E29")]
    public DateTime Begin_at
    {
      [Token(Token = "0x60072CB"), Address(RVA = "0x2ECBB0", Offset = "0x2EB9B0", VA = "0x102ECBB0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000E2A")]
    public DateTime End_at
    {
      [Token(Token = "0x60072CC"), Address(RVA = "0x31CBE0", Offset = "0x31B9E0", VA = "0x1031CBE0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x60072CD")]
    [Address(RVA = "0x3785A0", Offset = "0x3773A0", VA = "0x103785A0")]
    public bool Deserialize(JSON_LeagueMatchAttackScheduleParam json) => new bool();

    [Token(Token = "0x60072CE")]
    [Address(RVA = "0x378690", Offset = "0x377490", VA = "0x10378690")]
    public LeagueMatchAttackScheduleParam()
    {
    }
  }
}

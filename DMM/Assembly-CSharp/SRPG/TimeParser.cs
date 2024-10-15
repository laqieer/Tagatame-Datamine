// Decompiled with JetBrains decompiler
// Type: SRPG.TimeParser
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D53")]
  public class TimeParser
  {
    [Token(Token = "0x4007373")]
    [FieldOffset(Offset = "0x8")]
    private string str_time;
    [Token(Token = "0x4007374")]
    [FieldOffset(Offset = "0x10")]
    private DateTime date_time;

    [Token(Token = "0x6007826")]
    [Address(RVA = "0x3A39A0", Offset = "0x3A27A0", VA = "0x103A39A0")]
    public void Set(string str_time_at, DateTime base_time)
    {
    }

    [Token(Token = "0x17000FF7")]
    public string StrTime
    {
      [Token(Token = "0x6007827"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000FF8")]
    public DateTime DateTimes
    {
      [Token(Token = "0x6007828"), Address(RVA = "0x31CBE0", Offset = "0x31B9E0", VA = "0x1031CBE0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x6007829")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TimeParser()
    {
    }
  }
}

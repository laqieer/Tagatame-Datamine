// Decompiled with JetBrains decompiler
// Type: SRPG.StopWatch
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Diagnostics;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001162")]
  public class StopWatch : Stopwatch
  {
    [Token(Token = "0x4003EE9")]
    [FieldOffset(Offset = "0x20")]
    private int milliSec;

    [Token(Token = "0x6004A0E")]
    [Address(RVA = "0x1207310", Offset = "0x1206110", VA = "0x11207310")]
    public void ReStart()
    {
    }

    [Token(Token = "0x6004A0F")]
    [Address(RVA = "0x2A68E0", Offset = "0x2A56E0", VA = "0x102A68E0")]
    public void SetMilliSec(int time)
    {
    }

    [Token(Token = "0x6004A10")]
    [Address(RVA = "0x12072D0", Offset = "0x12060D0", VA = "0x112072D0")]
    public bool IsElapsec() => new bool();

    [Token(Token = "0x6004A11")]
    [Address(RVA = "0x1207330", Offset = "0x1206130", VA = "0x11207330")]
    public StopWatch()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_AdventureHistory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F84")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_AdventureHistory
  {
    [Token(Token = "0x400851E")]
    [FieldOffset(Offset = "0x8")]
    public int[] units;
    [Token(Token = "0x400851F")]
    [FieldOffset(Offset = "0xC")]
    public int combat_power;
    [Token(Token = "0x4008520")]
    [FieldOffset(Offset = "0x10")]
    public JSON_AdventureDrop[] drops;
    [Token(Token = "0x4008521")]
    [FieldOffset(Offset = "0x14")]
    public string complete_time;
    [Token(Token = "0x4008522")]
    [FieldOffset(Offset = "0x18")]
    public int level;

    [Token(Token = "0x6008170")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_AdventureHistory()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_RaidPeriodTimeParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C82")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_RaidPeriodTimeParam : JSON_RaidMasterParam
  {
    [Token(Token = "0x4007002")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x4007003")]
    [FieldOffset(Offset = "0xC")]
    public int period_id;
    [Token(Token = "0x4007004")]
    [FieldOffset(Offset = "0x10")]
    public string begin_at;
    [Token(Token = "0x4007005")]
    [FieldOffset(Offset = "0x14")]
    public string end_at;
    [Token(Token = "0x4007006")]
    [FieldOffset(Offset = "0x18")]
    public JSON_RaidPeriodTimeScheduleParam[] schedule;

    [Token(Token = "0x6007592")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_RaidPeriodTimeParam()
    {
    }
  }
}

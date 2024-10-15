// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GenesisLapBossParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B09")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GenesisLapBossParam
  {
    [Token(Token = "0x4006716")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006717")]
    [FieldOffset(Offset = "0xC")]
    public int round_buff_max;
    [Token(Token = "0x4006718")]
    [FieldOffset(Offset = "0x10")]
    public string boss_bid;
    [Token(Token = "0x4006719")]
    [FieldOffset(Offset = "0x14")]
    public string other_bid;
    [Token(Token = "0x400671A")]
    [FieldOffset(Offset = "0x18")]
    public JSON_GenesisLapBossParam.LapInfo[] lap_info;

    [Token(Token = "0x6006FA6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GenesisLapBossParam()
    {
    }

    [Token(Token = "0x2001B0A")]
    [MessagePackObject(true)]
    [Serializable]
    public class LapInfo
    {
      [Token(Token = "0x400671B")]
      [FieldOffset(Offset = "0x8")]
      public int round;
      [Token(Token = "0x400671C")]
      [FieldOffset(Offset = "0xC")]
      public string reward_id;

      [Token(Token = "0x6006FA7")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public LapInfo()
      {
      }
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_AdvanceLapBossParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200195B")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_AdvanceLapBossParam
  {
    [Token(Token = "0x4005C52")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4005C53")]
    [FieldOffset(Offset = "0xC")]
    public int round_buff_max;
    [Token(Token = "0x4005C54")]
    [FieldOffset(Offset = "0x10")]
    public string boss_bid;
    [Token(Token = "0x4005C55")]
    [FieldOffset(Offset = "0x14")]
    public string other_bid;
    [Token(Token = "0x4005C56")]
    [FieldOffset(Offset = "0x18")]
    public JSON_AdvanceLapBossParam.LapInfo[] lap_info;

    [Token(Token = "0x600676F")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_AdvanceLapBossParam()
    {
    }

    [Token(Token = "0x200195C")]
    [MessagePackObject(true)]
    [Serializable]
    public class LapInfo
    {
      [Token(Token = "0x4005C57")]
      [FieldOffset(Offset = "0x8")]
      public int round;
      [Token(Token = "0x4005C58")]
      [FieldOffset(Offset = "0xC")]
      public string reward_id;

      [Token(Token = "0x6006770")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public LapInfo()
      {
      }
    }
  }
}

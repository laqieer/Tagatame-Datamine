// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_WorldRaidLapRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F0B")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_WorldRaidLapRewardParam
  {
    [Token(Token = "0x40082A4")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40082A5")]
    [FieldOffset(Offset = "0xC")]
    public JSON_WorldRaidLapRewardParam.Reward[] rewards;

    [Token(Token = "0x6007EF1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_WorldRaidLapRewardParam()
    {
    }

    [Token(Token = "0x2001F0C")]
    [MessagePackObject(true)]
    [Serializable]
    public class Reward
    {
      [Token(Token = "0x40082A6")]
      [FieldOffset(Offset = "0x8")]
      public int lap_min;
      [Token(Token = "0x40082A7")]
      [FieldOffset(Offset = "0xC")]
      public int lap_max;
      [Token(Token = "0x40082A8")]
      [FieldOffset(Offset = "0x10")]
      public string reward_id;

      [Token(Token = "0x6007EF2")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Reward()
      {
      }
    }
  }
}

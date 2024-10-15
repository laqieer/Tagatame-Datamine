// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_WorldRaidDamageRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F06")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_WorldRaidDamageRewardParam
  {
    [Token(Token = "0x4008296")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4008297")]
    [FieldOffset(Offset = "0xC")]
    public JSON_WorldRaidDamageRewardParam.Reward[] rewards;

    [Token(Token = "0x6007EDC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_WorldRaidDamageRewardParam()
    {
    }

    [Token(Token = "0x2001F07")]
    [MessagePackObject(true)]
    [Serializable]
    public class Reward
    {
      [Token(Token = "0x4008298")]
      [FieldOffset(Offset = "0x8")]
      public int dmg_min;
      [Token(Token = "0x4008299")]
      [FieldOffset(Offset = "0xC")]
      public int dmg_max;
      [Token(Token = "0x400829A")]
      [FieldOffset(Offset = "0x10")]
      public string lottery_id;
      [Token(Token = "0x400829B")]
      [FieldOffset(Offset = "0x14")]
      public int eff_idx;

      [Token(Token = "0x6007EDD")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Reward()
      {
      }
    }
  }
}

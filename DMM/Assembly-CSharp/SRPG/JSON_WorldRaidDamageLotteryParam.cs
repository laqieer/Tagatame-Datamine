// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_WorldRaidDamageLotteryParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F01")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_WorldRaidDamageLotteryParam
  {
    [Token(Token = "0x4008288")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4008289")]
    [FieldOffset(Offset = "0xC")]
    public JSON_WorldRaidDamageLotteryParam.Reward[] rewards;

    [Token(Token = "0x6007EC7")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_WorldRaidDamageLotteryParam()
    {
    }

    [Token(Token = "0x2001F02")]
    [MessagePackObject(true)]
    [Serializable]
    public class Reward
    {
      [Token(Token = "0x400828A")]
      [FieldOffset(Offset = "0x8")]
      public int weight;
      [Token(Token = "0x400828B")]
      [FieldOffset(Offset = "0xC")]
      public int item_type;
      [Token(Token = "0x400828C")]
      [FieldOffset(Offset = "0x10")]
      public string item_iname;
      [Token(Token = "0x400828D")]
      [FieldOffset(Offset = "0x14")]
      public int item_num;

      [Token(Token = "0x6007EC8")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Reward()
      {
      }
    }
  }
}

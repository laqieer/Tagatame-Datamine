// Decompiled with JetBrains decompiler
// Type: SRPG.VersusFirstWinBonusParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EC3")]
  public class VersusFirstWinBonusParam
  {
    [Token(Token = "0x400811B")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x400811C")]
    [FieldOffset(Offset = "0x10")]
    public DateTime begin_at;
    [Token(Token = "0x400811D")]
    [FieldOffset(Offset = "0x18")]
    public DateTime end_at;
    [Token(Token = "0x400811E")]
    [FieldOffset(Offset = "0x20")]
    public VersusWinBonusRewardParam[] rewards;

    [Token(Token = "0x6007DFA")]
    [Address(RVA = "0x3FA950", Offset = "0x3F9750", VA = "0x103FA950")]
    public bool Deserialize(JSON_VersusFirstWinBonus json) => new bool();

    [Token(Token = "0x6007DFB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public VersusFirstWinBonusParam()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_VersusStreakWinBonus
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EE0")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_VersusStreakWinBonus
  {
    [Token(Token = "0x40081DD")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x40081DE")]
    [FieldOffset(Offset = "0xC")]
    public int wincnt;
    [Token(Token = "0x40081DF")]
    [FieldOffset(Offset = "0x10")]
    public JSON_VersusWinBonusReward[] rewards;

    [Token(Token = "0x6007E48")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_VersusStreakWinBonus()
    {
    }
  }
}

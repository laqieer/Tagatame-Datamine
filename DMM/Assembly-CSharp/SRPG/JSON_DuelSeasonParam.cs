// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_DuelSeasonParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001AB2")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_DuelSeasonParam
  {
    [Token(Token = "0x40062F7")]
    [FieldOffset(Offset = "0x8")]
    public int season;
    [Token(Token = "0x40062F8")]
    [FieldOffset(Offset = "0xC")]
    public string begin_at;
    [Token(Token = "0x40062F9")]
    [FieldOffset(Offset = "0x10")]
    public string end_at;
    [Token(Token = "0x40062FA")]
    [FieldOffset(Offset = "0x14")]
    public string season_reward;
    [Token(Token = "0x40062FB")]
    [FieldOffset(Offset = "0x18")]
    public string daily_reward;
    [Token(Token = "0x40062FC")]
    [FieldOffset(Offset = "0x1C")]
    public string win_reward;
    [Token(Token = "0x40062FD")]
    [FieldOffset(Offset = "0x20")]
    public string lose_reward;
    [Token(Token = "0x40062FE")]
    [FieldOffset(Offset = "0x24")]
    public int win_bonus_type;
    [Token(Token = "0x40062FF")]
    [FieldOffset(Offset = "0x28")]
    public string chain_win_reward;
    [Token(Token = "0x4006300")]
    [FieldOffset(Offset = "0x2C")]
    public JSON_DuelBonusUnit[] bonus_units;

    [Token(Token = "0x6006E16")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_DuelSeasonParam()
    {
    }
  }
}

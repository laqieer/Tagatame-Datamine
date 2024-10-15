// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_DuelResultRankPointData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002314")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_DuelResultRankPointData
  {
    [Token(Token = "0x4009C81")]
    [FieldOffset(Offset = "0x8")]
    public int win;
    [Token(Token = "0x4009C82")]
    [FieldOffset(Offset = "0xC")]
    public int unit_bonus;
    [Token(Token = "0x4009C83")]
    [FieldOffset(Offset = "0x10")]
    public int win_streak;
    [Token(Token = "0x4009C84")]
    [FieldOffset(Offset = "0x14")]
    public int turn;
    [Token(Token = "0x4009C85")]
    [FieldOffset(Offset = "0x18")]
    public int rank_rate;

    [Token(Token = "0x60096D6")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_DuelResultRankPointData()
    {
    }
  }
}

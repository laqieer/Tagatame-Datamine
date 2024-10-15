// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GuildRaidRankingDamage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FA9")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GuildRaidRankingDamage
  {
    [Token(Token = "0x4003727")]
    [FieldOffset(Offset = "0x8")]
    public int role;
    [Token(Token = "0x4003728")]
    [FieldOffset(Offset = "0xC")]
    public int rank;
    [Token(Token = "0x4003729")]
    [FieldOffset(Offset = "0x10")]
    public long score;
    [Token(Token = "0x400372A")]
    [FieldOffset(Offset = "0x18")]
    public string name;
    [Token(Token = "0x400372B")]
    [FieldOffset(Offset = "0x1C")]
    public int lv;
    [Token(Token = "0x400372C")]
    [FieldOffset(Offset = "0x20")]
    public string unit;
    [Token(Token = "0x400372D")]
    [FieldOffset(Offset = "0x24")]
    public int unit_strength_total;
    [Token(Token = "0x400372E")]
    [FieldOffset(Offset = "0x28")]
    public int boss_id;
    [Token(Token = "0x400372F")]
    [FieldOffset(Offset = "0x2C")]
    public int round;
    [Token(Token = "0x4003730")]
    [FieldOffset(Offset = "0x30")]
    public int knock_down_at;

    [Token(Token = "0x60040D3")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GuildRaidRankingDamage()
    {
    }
  }
}

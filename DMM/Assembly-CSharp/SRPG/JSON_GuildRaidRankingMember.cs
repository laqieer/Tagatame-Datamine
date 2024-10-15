// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GuildRaidRankingMember
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FA7")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GuildRaidRankingMember
  {
    [Token(Token = "0x400371D")]
    [FieldOffset(Offset = "0x8")]
    public int role;
    [Token(Token = "0x400371E")]
    [FieldOffset(Offset = "0xC")]
    public int rank;
    [Token(Token = "0x400371F")]
    [FieldOffset(Offset = "0x10")]
    public long score;
    [Token(Token = "0x4003720")]
    [FieldOffset(Offset = "0x18")]
    public string name;
    [Token(Token = "0x4003721")]
    [FieldOffset(Offset = "0x1C")]
    public int lv;
    [Token(Token = "0x4003722")]
    [FieldOffset(Offset = "0x20")]
    public string unit;
    [Token(Token = "0x4003723")]
    [FieldOffset(Offset = "0x24")]
    public int unit_strength_total;
    [Token(Token = "0x4003724")]
    [FieldOffset(Offset = "0x28")]
    public JSON_GuildRaidRankingMemberBoss[] bosses;

    [Token(Token = "0x60040D1")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GuildRaidRankingMember()
    {
    }
  }
}

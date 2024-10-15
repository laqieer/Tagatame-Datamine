// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GuildRaidGuildData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000FAA")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GuildRaidGuildData
  {
    [Token(Token = "0x4003731")]
    [FieldOffset(Offset = "0x8")]
    public int gid;
    [Token(Token = "0x4003732")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x4003733")]
    [FieldOffset(Offset = "0x10")]
    public string guild_master;
    [Token(Token = "0x4003734")]
    [FieldOffset(Offset = "0x14")]
    public string award_id;
    [Token(Token = "0x4003735")]
    [FieldOffset(Offset = "0x18")]
    public int level;
    [Token(Token = "0x4003736")]
    [FieldOffset(Offset = "0x1C")]
    public int member_count;
    [Token(Token = "0x4003737")]
    [FieldOffset(Offset = "0x20")]
    public int max_count;

    [Token(Token = "0x60040D4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GuildRaidGuildData()
    {
    }
  }
}

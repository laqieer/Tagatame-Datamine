// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GuildRaidData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F98")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GuildRaidData
  {
    [Token(Token = "0x40036E8")]
    [FieldOffset(Offset = "0x8")]
    public JSON_GuildRaidPrev prev;
    [Token(Token = "0x40036E9")]
    [FieldOffset(Offset = "0xC")]
    public JSON_GuildRaidCurrent current;
    [Token(Token = "0x40036EA")]
    [FieldOffset(Offset = "0x10")]
    public JSON_GuildRaidBattlePoint bp;
    [Token(Token = "0x40036EB")]
    [FieldOffset(Offset = "0x14")]
    public JSON_GuildRaidBossInfo bossinfo;
    [Token(Token = "0x40036EC")]
    [FieldOffset(Offset = "0x18")]
    public int can_open_area_id;
    [Token(Token = "0x40036ED")]
    [FieldOffset(Offset = "0x1C")]
    public int refresh_wait_sec;

    [Token(Token = "0x60040C2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GuildRaidData()
    {
    }
  }
}

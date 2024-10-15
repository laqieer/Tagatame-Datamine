// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_LeagueMatchEnemies
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011AD")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_LeagueMatchEnemies
  {
    [Token(Token = "0x400402B")]
    [FieldOffset(Offset = "0x8")]
    public int status;
    [Token(Token = "0x400402C")]
    [FieldOffset(Offset = "0xC")]
    public string fuid;
    [Token(Token = "0x400402D")]
    [FieldOffset(Offset = "0x10")]
    public string name;
    [Token(Token = "0x400402E")]
    [FieldOffset(Offset = "0x14")]
    public int lv;
    [Token(Token = "0x400402F")]
    [FieldOffset(Offset = "0x18")]
    public Json_Unit[] units;
    [Token(Token = "0x4004030")]
    [FieldOffset(Offset = "0x1C")]
    public string map;
    [Token(Token = "0x4004031")]
    [FieldOffset(Offset = "0x20")]
    public JSON_LeagueMatchSet[] set;
    [Token(Token = "0x4004032")]
    [FieldOffset(Offset = "0x24")]
    public string[] buffs;
    [Token(Token = "0x4004033")]
    [FieldOffset(Offset = "0x28")]
    public JSON_LeagueMatchEnemiesInfo info;
    [Token(Token = "0x4004034")]
    [FieldOffset(Offset = "0x2C")]
    public int is_npc;
    [Token(Token = "0x4004035")]
    [FieldOffset(Offset = "0x30")]
    public int id;
    [Token(Token = "0x4004036")]
    [FieldOffset(Offset = "0x34")]
    public JSON_PlayerBuff player_buff;

    [Token(Token = "0x6004B27")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_LeagueMatchEnemies()
    {
    }
  }
}

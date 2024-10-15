// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_LeagueMatchHistory
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011B0")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_LeagueMatchHistory
  {
    [Token(Token = "0x400403C")]
    [FieldOffset(Offset = "0x8")]
    public long iid;
    [Token(Token = "0x400403D")]
    [FieldOffset(Offset = "0x10")]
    public int is_npc;
    [Token(Token = "0x400403E")]
    [FieldOffset(Offset = "0x14")]
    public int id;
    [Token(Token = "0x400403F")]
    [FieldOffset(Offset = "0x18")]
    public long timestamp;
    [Token(Token = "0x4004040")]
    [FieldOffset(Offset = "0x20")]
    public string name;
    [Token(Token = "0x4004041")]
    [FieldOffset(Offset = "0x24")]
    public int lv;
    [Token(Token = "0x4004042")]
    [FieldOffset(Offset = "0x28")]
    public int type;
    [Token(Token = "0x4004043")]
    [FieldOffset(Offset = "0x2C")]
    public int status;
    [Token(Token = "0x4004044")]
    [FieldOffset(Offset = "0x30")]
    public int score;
    [Token(Token = "0x4004045")]
    [FieldOffset(Offset = "0x34")]
    public int rank_class_id;
    [Token(Token = "0x4004046")]
    [FieldOffset(Offset = "0x38")]
    public string map;
    [Token(Token = "0x4004047")]
    [FieldOffset(Offset = "0x3C")]
    public string[] buffs;
    [Token(Token = "0x4004048")]
    [FieldOffset(Offset = "0x40")]
    public JSON_LeagueMatchSet[] placement;
    [Token(Token = "0x4004049")]
    [FieldOffset(Offset = "0x44")]
    public JSON_LeagueMatchBattleDetail detail;

    [Token(Token = "0x6004B2A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_LeagueMatchHistory()
    {
    }
  }
}

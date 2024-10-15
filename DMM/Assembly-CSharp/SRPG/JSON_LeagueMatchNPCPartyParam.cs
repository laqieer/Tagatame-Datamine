// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_LeagueMatchNPCPartyParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BBB")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_LeagueMatchNPCPartyParam
  {
    [Token(Token = "0x4006A1D")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x4006A1E")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x4006A1F")]
    [FieldOffset(Offset = "0x10")]
    public int lv;
    [Token(Token = "0x4006A20")]
    [FieldOffset(Offset = "0x14")]
    public int score;
    [Token(Token = "0x4006A21")]
    [FieldOffset(Offset = "0x18")]
    public int rank_class_id;
    [Token(Token = "0x4006A22")]
    [FieldOffset(Offset = "0x1C")]
    public string rank_class;
    [Token(Token = "0x4006A23")]
    [FieldOffset(Offset = "0x20")]
    public int rank_unit1_id;
    [Token(Token = "0x4006A24")]
    [FieldOffset(Offset = "0x24")]
    public int rank_unit2_id;
    [Token(Token = "0x4006A25")]
    [FieldOffset(Offset = "0x28")]
    public int rank_unit3_id;
    [Token(Token = "0x4006A26")]
    [FieldOffset(Offset = "0x2C")]
    public string quest_iname;
    [Token(Token = "0x4006A27")]
    [FieldOffset(Offset = "0x30")]
    public JSON_LeagueMatchNPCPartyBuffParam[] buffs;

    [Token(Token = "0x600727B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_LeagueMatchNPCPartyParam()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_LeagueMatchRanking
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20011BB")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_LeagueMatchRanking
  {
    [Token(Token = "0x400406F")]
    [FieldOffset(Offset = "0x8")]
    public string name;
    [Token(Token = "0x4004070")]
    [FieldOffset(Offset = "0xC")]
    public int lv;
    [Token(Token = "0x4004071")]
    [FieldOffset(Offset = "0x10")]
    public Json_Unit unit;
    [Token(Token = "0x4004072")]
    [FieldOffset(Offset = "0x14")]
    public string selected_award;
    [Token(Token = "0x4004073")]
    [FieldOffset(Offset = "0x18")]
    public int rank_class_id;
    [Token(Token = "0x4004074")]
    [FieldOffset(Offset = "0x1C")]
    public int rank;
    [Token(Token = "0x4004075")]
    [FieldOffset(Offset = "0x20")]
    public int score;
    [Token(Token = "0x4004076")]
    [FieldOffset(Offset = "0x24")]
    public JSON_LeagueMatchGuildData guild;
    [Token(Token = "0x4004077")]
    [FieldOffset(Offset = "0x28")]
    public JSON_PlayerBuff player_buff;

    [Token(Token = "0x6004B35")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_LeagueMatchRanking()
    {
    }
  }
}

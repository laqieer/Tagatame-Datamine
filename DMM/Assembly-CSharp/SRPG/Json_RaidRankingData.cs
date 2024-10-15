// Decompiled with JetBrains decompiler
// Type: SRPG.Json_RaidRankingData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20010D2")]
  [Serializable]
  public class Json_RaidRankingData
  {
    [Token(Token = "0x4003CB1")]
    [FieldOffset(Offset = "0x8")]
    public string uid;
    [Token(Token = "0x4003CB2")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x4003CB3")]
    [FieldOffset(Offset = "0x10")]
    public int lv;
    [Token(Token = "0x4003CB4")]
    [FieldOffset(Offset = "0x14")]
    public int rank;
    [Token(Token = "0x4003CB5")]
    [FieldOffset(Offset = "0x18")]
    public int score;
    [Token(Token = "0x4003CB6")]
    [FieldOffset(Offset = "0x1C")]
    public Json_Unit unit;
    [Token(Token = "0x4003CB7")]
    [FieldOffset(Offset = "0x20")]
    public string selected_award;
    [Token(Token = "0x4003CB8")]
    [FieldOffset(Offset = "0x24")]
    public JSON_ViewGuild guild;
    [Token(Token = "0x4003CB9")]
    [FieldOffset(Offset = "0x28")]
    public JSON_PlayerBuff player_buff;

    [Token(Token = "0x6004721")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_RaidRankingData()
    {
    }
  }
}

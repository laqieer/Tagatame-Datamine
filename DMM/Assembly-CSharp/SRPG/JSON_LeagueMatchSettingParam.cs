// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_LeagueMatchSettingParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BCD")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_LeagueMatchSettingParam
  {
    [Token(Token = "0x4006A77")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006A78")]
    [FieldOffset(Offset = "0xC")]
    public int unit1_edit;
    [Token(Token = "0x4006A79")]
    [FieldOffset(Offset = "0x10")]
    public int unit2_edit;
    [Token(Token = "0x4006A7A")]
    [FieldOffset(Offset = "0x14")]
    public int unit3_edit;
    [Token(Token = "0x4006A7B")]
    [FieldOffset(Offset = "0x18")]
    public int unit_job;
    [Token(Token = "0x4006A7C")]
    [FieldOffset(Offset = "0x1C")]
    public int leader_skill;
    [Token(Token = "0x4006A7D")]
    [FieldOffset(Offset = "0x20")]
    public int conceptcard;
    [Token(Token = "0x4006A7E")]
    [FieldOffset(Offset = "0x24")]
    public int artifact;
    [Token(Token = "0x4006A7F")]
    [FieldOffset(Offset = "0x28")]
    public int crystal;
    [Token(Token = "0x4006A80")]
    [FieldOffset(Offset = "0x2C")]
    public int unit_level;
    [Token(Token = "0x4006A81")]
    [FieldOffset(Offset = "0x30")]
    public int unit_ability;
    [Token(Token = "0x4006A82")]
    [FieldOffset(Offset = "0x34")]
    public int unit_status;
    [Token(Token = "0x4006A83")]
    [FieldOffset(Offset = "0x38")]
    public int unit_rarity;
    [Token(Token = "0x4006A84")]
    [FieldOffset(Offset = "0x3C")]
    public int buf;
    [Token(Token = "0x4006A85")]
    [FieldOffset(Offset = "0x40")]
    public int map;
    [Token(Token = "0x4006A86")]
    [FieldOffset(Offset = "0x44")]
    public int map_unit;

    [Token(Token = "0x60072CF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_LeagueMatchSettingParam()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_GvGPeriodParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B82")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_GvGPeriodParam : JSON_GvGMasterParam
  {
    [Token(Token = "0x40068CA")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x40068CB")]
    [FieldOffset(Offset = "0xC")]
    public string prepare_start_at;
    [Token(Token = "0x40068CC")]
    [FieldOffset(Offset = "0x10")]
    public string begin_at;
    [Token(Token = "0x40068CD")]
    [FieldOffset(Offset = "0x14")]
    public string end_at;
    [Token(Token = "0x40068CE")]
    [FieldOffset(Offset = "0x18")]
    public string exit_at;
    [Token(Token = "0x40068CF")]
    [FieldOffset(Offset = "0x1C")]
    public string declaration_start_time;
    [Token(Token = "0x40068D0")]
    [FieldOffset(Offset = "0x20")]
    public string declaration_end_time;
    [Token(Token = "0x40068D1")]
    [FieldOffset(Offset = "0x24")]
    public int declaration_cool_minites;
    [Token(Token = "0x40068D2")]
    [FieldOffset(Offset = "0x28")]
    public string battle_start_time;
    [Token(Token = "0x40068D3")]
    [FieldOffset(Offset = "0x2C")]
    public string battle_end_time;
    [Token(Token = "0x40068D4")]
    [FieldOffset(Offset = "0x30")]
    public string battle_cool_start_time;
    [Token(Token = "0x40068D5")]
    [FieldOffset(Offset = "0x34")]
    public string battle_cool_end_time;
    [Token(Token = "0x40068D6")]
    [FieldOffset(Offset = "0x38")]
    public int declared_cool_minutes;
    [Token(Token = "0x40068D7")]
    [FieldOffset(Offset = "0x3C")]
    public int battle_cool_seconds;
    [Token(Token = "0x40068D8")]
    [FieldOffset(Offset = "0x40")]
    public int declare_num;
    [Token(Token = "0x40068D9")]
    [FieldOffset(Offset = "0x44")]
    public int map_idx;
    [Token(Token = "0x40068DA")]
    [FieldOffset(Offset = "0x48")]
    public int matching_count_min;
    [Token(Token = "0x40068DB")]
    [FieldOffset(Offset = "0x4C")]
    public int matching_count_max;
    [Token(Token = "0x40068DC")]
    [FieldOffset(Offset = "0x50")]
    public int first_occupy_node_num;
    [Token(Token = "0x40068DD")]
    [FieldOffset(Offset = "0x54")]
    public int defense_unit_min;
    [Token(Token = "0x40068DE")]
    [FieldOffset(Offset = "0x58")]
    public string url;
    [Token(Token = "0x40068DF")]
    [FieldOffset(Offset = "0x5C")]
    public string[] rule_cycle;
    [Token(Token = "0x40068E0")]
    [FieldOffset(Offset = "0x60")]
    public string url_title;

    [Token(Token = "0x600719A")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_GvGPeriodParam()
    {
    }
  }
}

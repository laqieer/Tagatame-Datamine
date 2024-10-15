// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_RunePridePanelSquareData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CFD")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_RunePridePanelSquareData
  {
    [Token(Token = "0x4007196")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x4007197")]
    [FieldOffset(Offset = "0xC")]
    public int fork_id;
    [Token(Token = "0x4007198")]
    [FieldOffset(Offset = "0x10")]
    public int route_id;
    [Token(Token = "0x4007199")]
    [FieldOffset(Offset = "0x14")]
    public int fork_id2;
    [Token(Token = "0x400719A")]
    [FieldOffset(Offset = "0x18")]
    public int route_id2;
    [Token(Token = "0x400719B")]
    [FieldOffset(Offset = "0x1C")]
    public int[] prev_ids;
    [Token(Token = "0x400719C")]
    [FieldOffset(Offset = "0x20")]
    public int is_goal;
    [Token(Token = "0x400719D")]
    [FieldOffset(Offset = "0x24")]
    public int potential_num;
    [Token(Token = "0x400719E")]
    [FieldOffset(Offset = "0x28")]
    public string draw_name;
    [Token(Token = "0x400719F")]
    [FieldOffset(Offset = "0x2C")]
    public int type;
    [Token(Token = "0x40071A0")]
    [FieldOffset(Offset = "0x30")]
    public int calc_type;
    [Token(Token = "0x40071A1")]
    [FieldOffset(Offset = "0x34")]
    public int value;
    [Token(Token = "0x40071A2")]
    [FieldOffset(Offset = "0x38")]
    public string need_item;
    [Token(Token = "0x40071A3")]
    [FieldOffset(Offset = "0x3C")]
    public string tag;

    [Token(Token = "0x600770C")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_RunePridePanelSquareData()
    {
    }
  }
}

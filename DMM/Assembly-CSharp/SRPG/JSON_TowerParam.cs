// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_TowerParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D72")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_TowerParam
  {
    [Token(Token = "0x4007435")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007436")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x4007437")]
    [FieldOffset(Offset = "0x10")]
    public string expr;
    [Token(Token = "0x4007438")]
    [FieldOffset(Offset = "0x14")]
    public string banr;
    [Token(Token = "0x4007439")]
    [FieldOffset(Offset = "0x18")]
    public string item;
    [Token(Token = "0x400743A")]
    [FieldOffset(Offset = "0x1C")]
    public string bg;
    [Token(Token = "0x400743B")]
    [FieldOffset(Offset = "0x20")]
    public string floor_bg_open;
    [Token(Token = "0x400743C")]
    [FieldOffset(Offset = "0x24")]
    public string floor_bg_close;
    [Token(Token = "0x400743D")]
    [FieldOffset(Offset = "0x28")]
    public string eventURL;
    [Token(Token = "0x400743E")]
    [FieldOffset(Offset = "0x2C")]
    public short unit_recover_minute;
    [Token(Token = "0x400743F")]
    [FieldOffset(Offset = "0x2E")]
    public short unit_recover_coin;
    [Token(Token = "0x4007440")]
    [FieldOffset(Offset = "0x30")]
    public byte can_unit_recover;
    [Token(Token = "0x4007441")]
    [FieldOffset(Offset = "0x31")]
    public byte is_down;
    [Token(Token = "0x4007442")]
    [FieldOffset(Offset = "0x32")]
    public byte is_view_ranking;
    [Token(Token = "0x4007443")]
    [FieldOffset(Offset = "0x34")]
    public short unlock_level;
    [Token(Token = "0x4007444")]
    [FieldOffset(Offset = "0x38")]
    public string unlock_quest;
    [Token(Token = "0x4007445")]
    [FieldOffset(Offset = "0x3C")]
    public string url;
    [Token(Token = "0x4007446")]
    [FieldOffset(Offset = "0x40")]
    public short floor_reset_coin;
    [Token(Token = "0x4007447")]
    [FieldOffset(Offset = "0x44")]
    public string score_iname;

    [Token(Token = "0x6007894")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_TowerParam()
    {
    }
  }
}

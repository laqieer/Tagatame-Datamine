// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_MultiTowerFloorParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001BF1")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_MultiTowerFloorParam
  {
    [Token(Token = "0x4006C01")]
    [FieldOffset(Offset = "0x8")]
    public int id;
    [Token(Token = "0x4006C02")]
    [FieldOffset(Offset = "0xC")]
    public string title;
    [Token(Token = "0x4006C03")]
    [FieldOffset(Offset = "0x10")]
    public string name;
    [Token(Token = "0x4006C04")]
    [FieldOffset(Offset = "0x14")]
    public string expr;
    [Token(Token = "0x4006C05")]
    [FieldOffset(Offset = "0x18")]
    public string cond;
    [Token(Token = "0x4006C06")]
    [FieldOffset(Offset = "0x1C")]
    public string tower_id;
    [Token(Token = "0x4006C07")]
    [FieldOffset(Offset = "0x20")]
    public int cond_floor;
    [Token(Token = "0x4006C08")]
    [FieldOffset(Offset = "0x24")]
    public string reward_id;
    [Token(Token = "0x4006C09")]
    [FieldOffset(Offset = "0x28")]
    public JSON_MapParam[] map;
    [Token(Token = "0x4006C0A")]
    [FieldOffset(Offset = "0x2C")]
    public short pt;
    [Token(Token = "0x4006C0B")]
    [FieldOffset(Offset = "0x2E")]
    public short lv;
    [Token(Token = "0x4006C0C")]
    [FieldOffset(Offset = "0x30")]
    public short joblv;
    [Token(Token = "0x4006C0D")]
    [FieldOffset(Offset = "0x32")]
    public short floor;
    [Token(Token = "0x4006C0E")]
    [FieldOffset(Offset = "0x34")]
    public short unitnum;
    [Token(Token = "0x4006C0F")]
    [FieldOffset(Offset = "0x36")]
    public short notcon;
    [Token(Token = "0x4006C10")]
    [FieldOffset(Offset = "0x38")]
    public string me_id;
    [Token(Token = "0x4006C11")]
    [FieldOffset(Offset = "0x3C")]
    public int is_wth_no_chg;
    [Token(Token = "0x4006C12")]
    [FieldOffset(Offset = "0x40")]
    public string wth_set_id;
    [Token(Token = "0x4006C13")]
    [FieldOffset(Offset = "0x44")]
    public int is_skip;
    [Token(Token = "0x4006C14")]
    [FieldOffset(Offset = "0x48")]
    public string iname;
    [Token(Token = "0x4006C15")]
    [FieldOffset(Offset = "0x4C")]
    public string rdy_cnd;

    [Token(Token = "0x6007329")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_MultiTowerFloorParam()
    {
    }
  }
}

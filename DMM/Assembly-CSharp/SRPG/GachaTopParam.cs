// Decompiled with JetBrains decompiler
// Type: SRPG.GachaTopParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000F11")]
  public class GachaTopParam
  {
    [Token(Token = "0x4002E97")]
    [FieldOffset(Offset = "0x8")]
    public string[] iname;
    [Token(Token = "0x4002E98")]
    [FieldOffset(Offset = "0xC")]
    public string[] category;
    [Token(Token = "0x4002E99")]
    [FieldOffset(Offset = "0x10")]
    public int[] coin;
    [Token(Token = "0x4002E9A")]
    [FieldOffset(Offset = "0x14")]
    public int[] gold;
    [Token(Token = "0x4002E9B")]
    [FieldOffset(Offset = "0x18")]
    public int[] coin_p;
    [Token(Token = "0x4002E9C")]
    [FieldOffset(Offset = "0x1C")]
    public List<UnitParam> units;
    [Token(Token = "0x4002E9D")]
    [FieldOffset(Offset = "0x20")]
    public int[] num;
    [Token(Token = "0x4002E9E")]
    [FieldOffset(Offset = "0x24")]
    public string[] ticket;
    [Token(Token = "0x4002E9F")]
    [FieldOffset(Offset = "0x28")]
    public int[] ticket_num;
    [Token(Token = "0x4002EA0")]
    [FieldOffset(Offset = "0x2C")]
    public bool[] step;
    [Token(Token = "0x4002EA1")]
    [FieldOffset(Offset = "0x30")]
    public int[] step_num;
    [Token(Token = "0x4002EA2")]
    [FieldOffset(Offset = "0x34")]
    public int[] step_index;
    [Token(Token = "0x4002EA3")]
    [FieldOffset(Offset = "0x38")]
    public bool[] limit;
    [Token(Token = "0x4002EA4")]
    [FieldOffset(Offset = "0x3C")]
    public int[] limit_num;
    [Token(Token = "0x4002EA5")]
    [FieldOffset(Offset = "0x40")]
    public int[] limit_stock;
    [Token(Token = "0x4002EA6")]
    [FieldOffset(Offset = "0x44")]
    public string type;
    [Token(Token = "0x4002EA7")]
    [FieldOffset(Offset = "0x48")]
    public string asset_title;
    [Token(Token = "0x4002EA8")]
    [FieldOffset(Offset = "0x4C")]
    public string asset_bg;
    [Token(Token = "0x4002EA9")]
    [FieldOffset(Offset = "0x50")]
    public string group;
    [Token(Token = "0x4002EAA")]
    [FieldOffset(Offset = "0x54")]
    public string[] btext;
    [Token(Token = "0x4002EAB")]
    [FieldOffset(Offset = "0x58")]
    public string[] confirm;
    [Token(Token = "0x4002EAC")]
    [FieldOffset(Offset = "0x5C")]
    public List<int> sort;

    [Token(Token = "0x6003ECC")]
    [Address(RVA = "0x1178D10", Offset = "0x1177B10", VA = "0x11178D10")]
    public GachaTopParam()
    {
    }
  }
}

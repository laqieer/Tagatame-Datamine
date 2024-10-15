// Decompiled with JetBrains decompiler
// Type: SRPG.Json_BondGroupBuffParamDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20019AA")]
  [MessagePackObject(true)]
  [Serializable]
  public class Json_BondGroupBuffParamDetail
  {
    [Token(Token = "0x4005E32")]
    [FieldOffset(Offset = "0x8")]
    public int level;
    [Token(Token = "0x4005E33")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x4005E34")]
    [FieldOffset(Offset = "0x10")]
    public string expr;
    [Token(Token = "0x4005E35")]
    [FieldOffset(Offset = "0x14")]
    public int type_detail;
    [Token(Token = "0x4005E36")]
    [FieldOffset(Offset = "0x18")]
    public string buff_iname;
    [Token(Token = "0x4005E37")]
    [FieldOffset(Offset = "0x1C")]
    public string mats_piece_iname;
    [Token(Token = "0x4005E38")]
    [FieldOffset(Offset = "0x20")]
    public string mats_recipe_iname;
    [Token(Token = "0x4005E39")]
    [FieldOffset(Offset = "0x24")]
    public int need_gold_num;
    [Token(Token = "0x4005E3A")]
    [FieldOffset(Offset = "0x28")]
    public string need_item_iname;
    [Token(Token = "0x4005E3B")]
    [FieldOffset(Offset = "0x2C")]
    public int need_item_num;
    [Token(Token = "0x4005E3C")]
    [FieldOffset(Offset = "0x30")]
    public string unit_group_iname;
    [Token(Token = "0x4005E3D")]
    [FieldOffset(Offset = "0x34")]
    public string[] unit_inames;

    [Token(Token = "0x600688E")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Json_BondGroupBuffParamDetail()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_AbilityParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DC0")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_AbilityParam
  {
    [Token(Token = "0x4007675")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4007676")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x4007677")]
    [FieldOffset(Offset = "0x10")]
    public string expr;
    [Token(Token = "0x4007678")]
    [FieldOffset(Offset = "0x14")]
    public string icon;
    [Token(Token = "0x4007679")]
    [FieldOffset(Offset = "0x18")]
    public int type;
    [Token(Token = "0x400767A")]
    [FieldOffset(Offset = "0x1C")]
    public int slot;
    [Token(Token = "0x400767B")]
    [FieldOffset(Offset = "0x20")]
    public int fix;
    [Token(Token = "0x400767C")]
    [FieldOffset(Offset = "0x24")]
    public int cap;
    [Token(Token = "0x400767D")]
    [FieldOffset(Offset = "0x28")]
    public string skl1;
    [Token(Token = "0x400767E")]
    [FieldOffset(Offset = "0x2C")]
    public string skl2;
    [Token(Token = "0x400767F")]
    [FieldOffset(Offset = "0x30")]
    public string skl3;
    [Token(Token = "0x4007680")]
    [FieldOffset(Offset = "0x34")]
    public string skl4;
    [Token(Token = "0x4007681")]
    [FieldOffset(Offset = "0x38")]
    public string skl5;
    [Token(Token = "0x4007682")]
    [FieldOffset(Offset = "0x3C")]
    public string skl6;
    [Token(Token = "0x4007683")]
    [FieldOffset(Offset = "0x40")]
    public string skl7;
    [Token(Token = "0x4007684")]
    [FieldOffset(Offset = "0x44")]
    public string skl8;
    [Token(Token = "0x4007685")]
    [FieldOffset(Offset = "0x48")]
    public string skl9;
    [Token(Token = "0x4007686")]
    [FieldOffset(Offset = "0x4C")]
    public string skl10;
    [Token(Token = "0x4007687")]
    [FieldOffset(Offset = "0x50")]
    public int lv1;
    [Token(Token = "0x4007688")]
    [FieldOffset(Offset = "0x54")]
    public int lv2;
    [Token(Token = "0x4007689")]
    [FieldOffset(Offset = "0x58")]
    public int lv3;
    [Token(Token = "0x400768A")]
    [FieldOffset(Offset = "0x5C")]
    public int lv4;
    [Token(Token = "0x400768B")]
    [FieldOffset(Offset = "0x60")]
    public int lv5;
    [Token(Token = "0x400768C")]
    [FieldOffset(Offset = "0x64")]
    public int lv6;
    [Token(Token = "0x400768D")]
    [FieldOffset(Offset = "0x68")]
    public int lv7;
    [Token(Token = "0x400768E")]
    [FieldOffset(Offset = "0x6C")]
    public int lv8;
    [Token(Token = "0x400768F")]
    [FieldOffset(Offset = "0x70")]
    public int lv9;
    [Token(Token = "0x4007690")]
    [FieldOffset(Offset = "0x74")]
    public int lv10;
    [Token(Token = "0x4007691")]
    [FieldOffset(Offset = "0x78")]
    public string[] units;
    [Token(Token = "0x4007692")]
    [FieldOffset(Offset = "0x7C")]
    public int units_cnds_type;
    [Token(Token = "0x4007693")]
    [FieldOffset(Offset = "0x80")]
    public string[] jobs;
    [Token(Token = "0x4007694")]
    [FieldOffset(Offset = "0x84")]
    public int jobs_cnds_type;
    [Token(Token = "0x4007695")]
    [FieldOffset(Offset = "0x88")]
    public string birth;
    [Token(Token = "0x4007696")]
    [FieldOffset(Offset = "0x8C")]
    public int sex;
    [Token(Token = "0x4007697")]
    [FieldOffset(Offset = "0x90")]
    public int elem;
    [Token(Token = "0x4007698")]
    [FieldOffset(Offset = "0x94")]
    public int rmin;
    [Token(Token = "0x4007699")]
    [FieldOffset(Offset = "0x98")]
    public int rmax;
    [Token(Token = "0x400769A")]
    [FieldOffset(Offset = "0x9C")]
    public int type_detail;

    [Token(Token = "0x60079C5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_AbilityParam()
    {
    }
  }
}

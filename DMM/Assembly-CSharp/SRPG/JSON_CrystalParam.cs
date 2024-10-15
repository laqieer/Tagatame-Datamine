// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_CrystalParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A8B")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_CrystalParam
  {
    [Token(Token = "0x4006234")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006235")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x4006236")]
    [FieldOffset(Offset = "0x10")]
    public string expr;
    [Token(Token = "0x4006237")]
    [FieldOffset(Offset = "0x14")]
    public string icon;
    [Token(Token = "0x4006238")]
    [FieldOffset(Offset = "0x18")]
    public string equip_effect_d;
    [Token(Token = "0x4006239")]
    [FieldOffset(Offset = "0x1C")]
    public string equip_effect_c;
    [Token(Token = "0x400623A")]
    [FieldOffset(Offset = "0x20")]
    public string equip_effect_b;
    [Token(Token = "0x400623B")]
    [FieldOffset(Offset = "0x24")]
    public string equip_effect_a;
    [Token(Token = "0x400623C")]
    [FieldOffset(Offset = "0x28")]
    public string equip_effect_s;
    [Token(Token = "0x400623D")]
    [FieldOffset(Offset = "0x2C")]
    public string add_limit_d;
    [Token(Token = "0x400623E")]
    [FieldOffset(Offset = "0x30")]
    public string add_limit_c;
    [Token(Token = "0x400623F")]
    [FieldOffset(Offset = "0x34")]
    public string add_limit_b;
    [Token(Token = "0x4006240")]
    [FieldOffset(Offset = "0x38")]
    public string add_limit_a;
    [Token(Token = "0x4006241")]
    [FieldOffset(Offset = "0x3C")]
    public string add_limit_s;
    [Token(Token = "0x4006242")]
    [FieldOffset(Offset = "0x40")]
    public string sale_iname;
    [Token(Token = "0x4006243")]
    [FieldOffset(Offset = "0x44")]
    public int gallery_view;

    [Token(Token = "0x6006D21")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_CrystalParam()
    {
    }
  }
}

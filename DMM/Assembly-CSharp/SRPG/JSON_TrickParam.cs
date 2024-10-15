// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_TrickParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D83")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_TrickParam
  {
    [Token(Token = "0x40074A3")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40074A4")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x40074A5")]
    [FieldOffset(Offset = "0x10")]
    public string expr;
    [Token(Token = "0x40074A6")]
    [FieldOffset(Offset = "0x14")]
    public int dmg_type;
    [Token(Token = "0x40074A7")]
    [FieldOffset(Offset = "0x18")]
    public int dmg_val;
    [Token(Token = "0x40074A8")]
    [FieldOffset(Offset = "0x1C")]
    public int calc;
    [Token(Token = "0x40074A9")]
    [FieldOffset(Offset = "0x20")]
    public int elem;
    [Token(Token = "0x40074AA")]
    [FieldOffset(Offset = "0x24")]
    public int atk_det;
    [Token(Token = "0x40074AB")]
    [FieldOffset(Offset = "0x28")]
    public string buff;
    [Token(Token = "0x40074AC")]
    [FieldOffset(Offset = "0x2C")]
    public string cond;
    [Token(Token = "0x40074AD")]
    [FieldOffset(Offset = "0x30")]
    public int kb_rate;
    [Token(Token = "0x40074AE")]
    [FieldOffset(Offset = "0x34")]
    public int kb_val;
    [Token(Token = "0x40074AF")]
    [FieldOffset(Offset = "0x38")]
    public int target;
    [Token(Token = "0x40074B0")]
    [FieldOffset(Offset = "0x3C")]
    public int visual;
    [Token(Token = "0x40074B1")]
    [FieldOffset(Offset = "0x40")]
    public int count;
    [Token(Token = "0x40074B2")]
    [FieldOffset(Offset = "0x44")]
    public int clock;
    [Token(Token = "0x40074B3")]
    [FieldOffset(Offset = "0x48")]
    public int is_no_ow;
    [Token(Token = "0x40074B4")]
    [FieldOffset(Offset = "0x4C")]
    public string marker;
    [Token(Token = "0x40074B5")]
    [FieldOffset(Offset = "0x50")]
    public string effect;
    [Token(Token = "0x40074B6")]
    [FieldOffset(Offset = "0x54")]
    public int eff_target;
    [Token(Token = "0x40074B7")]
    [FieldOffset(Offset = "0x58")]
    public int eff_shape;
    [Token(Token = "0x40074B8")]
    [FieldOffset(Offset = "0x5C")]
    public int eff_scope;
    [Token(Token = "0x40074B9")]
    [FieldOffset(Offset = "0x60")]
    public int eff_height;
    [Token(Token = "0x40074BA")]
    [FieldOffset(Offset = "0x64")]
    public int ig_mt_num;
    [Token(Token = "0x40074BB")]
    [FieldOffset(Offset = "0x68")]
    public int[] ig_mts;
    [Token(Token = "0x40074BC")]
    [FieldOffset(Offset = "0x6C")]
    public int is_rein;

    [Token(Token = "0x60078A8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_TrickParam()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_DynamicTransformUnitParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001DF6")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_DynamicTransformUnitParam
  {
    [Token(Token = "0x40078D5")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x40078D6")]
    [FieldOffset(Offset = "0xC")]
    public string name;
    [Token(Token = "0x40078D7")]
    [FieldOffset(Offset = "0x10")]
    public string tr_unit_id;
    [Token(Token = "0x40078D8")]
    [FieldOffset(Offset = "0x14")]
    public int turn;
    [Token(Token = "0x40078D9")]
    [FieldOffset(Offset = "0x18")]
    public string upper_to_abid;
    [Token(Token = "0x40078DA")]
    [FieldOffset(Offset = "0x1C")]
    public string lower_to_abid;
    [Token(Token = "0x40078DB")]
    [FieldOffset(Offset = "0x20")]
    public string react_to_abid;
    [Token(Token = "0x40078DC")]
    [FieldOffset(Offset = "0x24")]
    public int is_no_wa;
    [Token(Token = "0x40078DD")]
    [FieldOffset(Offset = "0x28")]
    public int is_no_va;
    [Token(Token = "0x40078DE")]
    [FieldOffset(Offset = "0x2C")]
    public int is_no_item;
    [Token(Token = "0x40078DF")]
    [FieldOffset(Offset = "0x30")]
    public string ct_eff;
    [Token(Token = "0x40078E0")]
    [FieldOffset(Offset = "0x34")]
    public int ct_dis_ms;
    [Token(Token = "0x40078E1")]
    [FieldOffset(Offset = "0x38")]
    public int ct_app_ms;
    [Token(Token = "0x40078E2")]
    [FieldOffset(Offset = "0x3C")]
    public int is_tr_hpf;
    [Token(Token = "0x40078E3")]
    [FieldOffset(Offset = "0x40")]
    public int is_cc_hpf;
    [Token(Token = "0x40078E4")]
    [FieldOffset(Offset = "0x44")]
    public int is_inh_skin;
    [Token(Token = "0x40078E5")]
    [FieldOffset(Offset = "0x48")]
    public int is_cancel_unit_base;
    [Token(Token = "0x40078E6")]
    [FieldOffset(Offset = "0x4C")]
    public int is_ct_nochg;
    [Token(Token = "0x40078E7")]
    [FieldOffset(Offset = "0x50")]
    public int is_move_nochg;
    [Token(Token = "0x40078E8")]
    [FieldOffset(Offset = "0x54")]
    public int is_exit_truth;
    [Token(Token = "0x40078E9")]
    [FieldOffset(Offset = "0x58")]
    public int is_no_truth;
    [Token(Token = "0x40078EA")]
    [FieldOffset(Offset = "0x5C")]
    public int is_exit_insp;
    [Token(Token = "0x40078EB")]
    [FieldOffset(Offset = "0x60")]
    public int is_no_insp;
    [Token(Token = "0x40078EC")]
    [FieldOffset(Offset = "0x64")]
    public int is_exit_stone;

    [Token(Token = "0x6007A88")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_DynamicTransformUnitParam()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_BuyCoinProductParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A36")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_BuyCoinProductParam
  {
    [Token(Token = "0x4006071")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006072")]
    [FieldOffset(Offset = "0xC")]
    public string product_id;
    [Token(Token = "0x4006073")]
    [FieldOffset(Offset = "0x10")]
    public string shop_id;
    [Token(Token = "0x4006074")]
    [FieldOffset(Offset = "0x14")]
    public string hotdeal_iname;
    [Token(Token = "0x4006075")]
    [FieldOffset(Offset = "0x18")]
    public int type;
    [Token(Token = "0x4006076")]
    [FieldOffset(Offset = "0x1C")]
    public int val;
    [Token(Token = "0x4006077")]
    [FieldOffset(Offset = "0x20")]
    public int is_platform_common;
    [Token(Token = "0x4006078")]
    [FieldOffset(Offset = "0x24")]
    public string reward;
    [Token(Token = "0x4006079")]
    [FieldOffset(Offset = "0x28")]
    public string title;
    [Token(Token = "0x400607A")]
    [FieldOffset(Offset = "0x2C")]
    public string description;
    [Token(Token = "0x400607B")]
    [FieldOffset(Offset = "0x30")]
    public int badge;
    [Token(Token = "0x400607C")]
    [FieldOffset(Offset = "0x34")]
    public int img_array_idx;
    [Token(Token = "0x400607D")]
    [FieldOffset(Offset = "0x38")]
    public int unlock_lv;
    [Token(Token = "0x400607E")]
    [FieldOffset(Offset = "0x3C")]
    public string temp_name;
    [Token(Token = "0x400607F")]
    [FieldOffset(Offset = "0x40")]
    public string display_begin_at;
    [Token(Token = "0x4006080")]
    [FieldOffset(Offset = "0x44")]
    public string display_end_at;

    [Token(Token = "0x6006BBC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_BuyCoinProductParam()
    {
    }
  }
}

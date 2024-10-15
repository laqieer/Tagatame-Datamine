// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_VipParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001EED")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_VipParam
  {
    [Token(Token = "0x4008219")]
    [FieldOffset(Offset = "0x8")]
    public int exp;
    [Token(Token = "0x400821A")]
    [FieldOffset(Offset = "0xC")]
    public int ticket;
    [Token(Token = "0x400821B")]
    [FieldOffset(Offset = "0x10")]
    public int buy_coin_bonus;
    [Token(Token = "0x400821C")]
    [FieldOffset(Offset = "0x14")]
    public int buy_coin_num;
    [Token(Token = "0x400821D")]
    [FieldOffset(Offset = "0x18")]
    public int buy_stmn_num;
    [Token(Token = "0x400821E")]
    [FieldOffset(Offset = "0x1C")]
    public int reset_elite;
    [Token(Token = "0x400821F")]
    [FieldOffset(Offset = "0x20")]
    public int reset_arena;

    [Token(Token = "0x6007E6D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_VipParam()
    {
    }
  }
}

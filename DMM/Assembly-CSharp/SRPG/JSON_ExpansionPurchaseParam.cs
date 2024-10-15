// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_ExpansionPurchaseParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001ACF")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_ExpansionPurchaseParam
  {
    [Token(Token = "0x4006373")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006374")]
    [FieldOffset(Offset = "0xC")]
    public string buy_coin_product;
    [Token(Token = "0x4006375")]
    [FieldOffset(Offset = "0x10")]
    public int period;
    [Token(Token = "0x4006376")]
    [FieldOffset(Offset = "0x14")]
    public int ignore_lock;
    [Token(Token = "0x4006377")]
    [FieldOffset(Offset = "0x18")]
    public JSON_ExpansionPurchaseType[] expansions;
    [Token(Token = "0x4006378")]
    [FieldOffset(Offset = "0x1C")]
    public string url;
    [Token(Token = "0x4006379")]
    [FieldOffset(Offset = "0x20")]
    public string desc;

    [Token(Token = "0x6006E78")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_ExpansionPurchaseParam()
    {
    }
  }
}

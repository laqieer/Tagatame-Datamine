// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_CoinBuyUseBonusParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A4E")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_CoinBuyUseBonusParam
  {
    [Token(Token = "0x400610C")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x400610D")]
    [FieldOffset(Offset = "0xC")]
    public int type;
    [Token(Token = "0x400610E")]
    [FieldOffset(Offset = "0x10")]
    public int trigger;
    [Token(Token = "0x400610F")]
    [FieldOffset(Offset = "0x14")]
    public string reward_set;
    [Token(Token = "0x4006110")]
    [FieldOffset(Offset = "0x18")]
    public string begin_at;
    [Token(Token = "0x4006111")]
    [FieldOffset(Offset = "0x1C")]
    public string end_at;

    [Token(Token = "0x6006C32")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_CoinBuyUseBonusParam()
    {
    }
  }
}

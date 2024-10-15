// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_CoinBuyUseBonusContentParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A50")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_CoinBuyUseBonusContentParam
  {
    [Token(Token = "0x4006114")]
    [FieldOffset(Offset = "0x8")]
    public string name;
    [Token(Token = "0x4006115")]
    [FieldOffset(Offset = "0xC")]
    public int num;
    [Token(Token = "0x4006116")]
    [FieldOffset(Offset = "0x10")]
    public string reward_iname;
    [Token(Token = "0x4006117")]
    [FieldOffset(Offset = "0x14")]
    public string gift_msg;

    [Token(Token = "0x6006C34")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_CoinBuyUseBonusContentParam()
    {
    }
  }
}

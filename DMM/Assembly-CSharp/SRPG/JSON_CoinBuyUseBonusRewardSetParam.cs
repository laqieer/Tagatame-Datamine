// Decompiled with JetBrains decompiler
// Type: SRPG.JSON_CoinBuyUseBonusRewardSetParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A4F")]
  [MessagePackObject(true)]
  [Serializable]
  public class JSON_CoinBuyUseBonusRewardSetParam
  {
    [Token(Token = "0x4006112")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4006113")]
    [FieldOffset(Offset = "0xC")]
    public JSON_CoinBuyUseBonusContentParam[] contents;

    [Token(Token = "0x6006C33")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public JSON_CoinBuyUseBonusRewardSetParam()
    {
    }
  }
}

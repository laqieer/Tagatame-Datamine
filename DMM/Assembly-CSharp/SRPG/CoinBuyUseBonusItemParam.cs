﻿// Decompiled with JetBrains decompiler
// Type: SRPG.CoinBuyUseBonusItemParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A59")]
  public class CoinBuyUseBonusItemParam
  {
    [Token(Token = "0x4006132")]
    [FieldOffset(Offset = "0x8")]
    private eCoinBuyUseBonusRewardType type;
    [Token(Token = "0x4006133")]
    [FieldOffset(Offset = "0xC")]
    private string iname;
    [Token(Token = "0x4006134")]
    [FieldOffset(Offset = "0x10")]
    private int num;

    [Token(Token = "0x17000BD6")]
    public eCoinBuyUseBonusRewardType Type
    {
      [Token(Token = "0x6006C59"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new eCoinBuyUseBonusRewardType();
      }
    }

    [Token(Token = "0x17000BD7")]
    public string Item
    {
      [Token(Token = "0x6006C5A"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000BD8")]
    public int Num
    {
      [Token(Token = "0x6006C5B"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6006C5C")]
    [Address(RVA = "0x352630", Offset = "0x351430", VA = "0x10352630")]
    public void Deserialize(JSON_CoinBuyUseBonusItemParam json)
    {
    }

    [Token(Token = "0x6006C5D")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CoinBuyUseBonusItemParam()
    {
    }
  }
}
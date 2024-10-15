// Decompiled with JetBrains decompiler
// Type: SRPG.CoinBuyUseBonusParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A55")]
  public class CoinBuyUseBonusParam
  {
    [Token(Token = "0x4006122")]
    [FieldOffset(Offset = "0x8")]
    private string iname;
    [Token(Token = "0x4006123")]
    [FieldOffset(Offset = "0xC")]
    private eCoinBuyUseBonusType type;
    [Token(Token = "0x4006124")]
    [FieldOffset(Offset = "0x10")]
    private eCoinBuyUseBonusTrigger trigger;
    [Token(Token = "0x4006125")]
    [FieldOffset(Offset = "0x14")]
    private string reward_set;
    [Token(Token = "0x4006126")]
    [FieldOffset(Offset = "0x18")]
    private DateTime begin_at;
    [Token(Token = "0x4006127")]
    [FieldOffset(Offset = "0x20")]
    private DateTime end_at;
    [Token(Token = "0x4006128")]
    [FieldOffset(Offset = "0x28")]
    private CoinBuyUseBonusRewardSetParam mRewardSet;

    [Token(Token = "0x17000BC6")]
    public string Iname
    {
      [Token(Token = "0x6006C3C"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000BC7")]
    public eCoinBuyUseBonusType Type
    {
      [Token(Token = "0x6006C3D"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new eCoinBuyUseBonusType();
      }
    }

    [Token(Token = "0x17000BC8")]
    public eCoinBuyUseBonusTrigger Trigger
    {
      [Token(Token = "0x6006C3E"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new eCoinBuyUseBonusTrigger();
      }
    }

    [Token(Token = "0x17000BC9")]
    public DateTime BeginAt
    {
      [Token(Token = "0x6006C3F"), Address(RVA = "0x31CBF0", Offset = "0x31B9F0", VA = "0x1031CBF0")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000BCA")]
    public DateTime EndAt
    {
      [Token(Token = "0x6006C40"), Address(RVA = "0x31F940", Offset = "0x31E740", VA = "0x1031F940")] get
      {
        return new DateTime();
      }
    }

    [Token(Token = "0x17000BCB")]
    public CoinBuyUseBonusRewardSetParam RewardSet
    {
      [Token(Token = "0x6006C41"), Address(RVA = "0x29C880", Offset = "0x29B680", VA = "0x1029C880")] get
      {
        return (CoinBuyUseBonusRewardSetParam) null;
      }
    }

    [Token(Token = "0x17000BCC")]
    public bool IsEnable
    {
      [Token(Token = "0x6006C42"), Address(RVA = "0x352970", Offset = "0x351770", VA = "0x10352970")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6006C43")]
    [Address(RVA = "0x352870", Offset = "0x351670", VA = "0x10352870")]
    public void Deserialize(
      JSON_CoinBuyUseBonusParam json,
      CoinBuyUseBonusRewardSetParam[] reward_set_params)
    {
    }

    [Token(Token = "0x6006C44")]
    [Address(RVA = "0x352670", Offset = "0x351470", VA = "0x10352670")]
    public static void Deserialize(
      ref CoinBuyUseBonusParam[] param,
      JSON_CoinBuyUseBonusParam[] json,
      CoinBuyUseBonusRewardSetParam[] reward_set_params)
    {
    }

    [Token(Token = "0x6006C45")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CoinBuyUseBonusParam()
    {
    }
  }
}

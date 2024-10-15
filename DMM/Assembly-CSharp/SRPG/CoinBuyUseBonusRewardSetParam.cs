// Decompiled with JetBrains decompiler
// Type: SRPG.CoinBuyUseBonusRewardSetParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A56")]
  public class CoinBuyUseBonusRewardSetParam
  {
    [Token(Token = "0x4006129")]
    [FieldOffset(Offset = "0x8")]
    private string iname;
    [Token(Token = "0x400612A")]
    [FieldOffset(Offset = "0xC")]
    private CoinBuyUseBonusContentParam[] contents;

    [Token(Token = "0x17000BCD")]
    public string Iname
    {
      [Token(Token = "0x6006C47"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000BCE")]
    public CoinBuyUseBonusContentParam[] Contents
    {
      [Token(Token = "0x6006C48"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (CoinBuyUseBonusContentParam[]) null;
      }
    }

    [Token(Token = "0x6006C49")]
    [Address(RVA = "0x352E30", Offset = "0x351C30", VA = "0x10352E30")]
    public void Deserialize(
      JSON_CoinBuyUseBonusRewardSetParam json,
      CoinBuyUseBonusRewardParam[] reward_params)
    {
    }

    [Token(Token = "0x6006C4A")]
    [Address(RVA = "0x353030", Offset = "0x351E30", VA = "0x10353030")]
    public static void Deserialize(
      ref CoinBuyUseBonusRewardSetParam[] param,
      JSON_CoinBuyUseBonusRewardSetParam[] json,
      CoinBuyUseBonusRewardParam[] reward_params)
    {
    }

    [Token(Token = "0x6006C4B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CoinBuyUseBonusRewardSetParam()
    {
    }
  }
}

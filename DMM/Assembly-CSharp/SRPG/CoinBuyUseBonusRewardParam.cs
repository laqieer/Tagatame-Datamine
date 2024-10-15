// Decompiled with JetBrains decompiler
// Type: SRPG.CoinBuyUseBonusRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A58")]
  public class CoinBuyUseBonusRewardParam
  {
    [Token(Token = "0x4006130")]
    [FieldOffset(Offset = "0x8")]
    private string iname;
    [Token(Token = "0x4006131")]
    [FieldOffset(Offset = "0xC")]
    private CoinBuyUseBonusItemParam[] rewards;

    [Token(Token = "0x17000BD4")]
    public string Iname
    {
      [Token(Token = "0x6006C54"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000BD5")]
    public CoinBuyUseBonusItemParam[] Rewards
    {
      [Token(Token = "0x6006C55"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (CoinBuyUseBonusItemParam[]) null;
      }
    }

    [Token(Token = "0x6006C56")]
    [Address(RVA = "0x352A60", Offset = "0x351860", VA = "0x10352A60")]
    public void Deserialize(JSON_CoinBuyUseBonusRewardParam json)
    {
    }

    [Token(Token = "0x6006C57")]
    [Address(RVA = "0x352BD0", Offset = "0x3519D0", VA = "0x10352BD0")]
    public static void Deserialize(
      ref CoinBuyUseBonusRewardParam[] param,
      JSON_CoinBuyUseBonusRewardParam[] json)
    {
    }

    [Token(Token = "0x6006C58")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CoinBuyUseBonusRewardParam()
    {
    }
  }
}

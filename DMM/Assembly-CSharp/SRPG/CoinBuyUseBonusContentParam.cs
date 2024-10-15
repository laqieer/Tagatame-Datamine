// Decompiled with JetBrains decompiler
// Type: SRPG.CoinBuyUseBonusContentParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A57")]
  public class CoinBuyUseBonusContentParam
  {
    [Token(Token = "0x400612B")]
    [FieldOffset(Offset = "0x8")]
    private string name;
    [Token(Token = "0x400612C")]
    [FieldOffset(Offset = "0xC")]
    private int num;
    [Token(Token = "0x400612D")]
    [FieldOffset(Offset = "0x10")]
    private string reward_iname;
    [Token(Token = "0x400612E")]
    [FieldOffset(Offset = "0x14")]
    private string gift_msg;
    [Token(Token = "0x400612F")]
    [FieldOffset(Offset = "0x18")]
    private CoinBuyUseBonusRewardParam mRewardParam;

    [Token(Token = "0x17000BCF")]
    public string Name
    {
      [Token(Token = "0x6006C4C"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000BD0")]
    public int Num
    {
      [Token(Token = "0x6006C4D"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000BD1")]
    public string RewardIname
    {
      [Token(Token = "0x6006C4E"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000BD2")]
    public string GiftMsg
    {
      [Token(Token = "0x6006C4F"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000BD3")]
    public CoinBuyUseBonusRewardParam RewardParam
    {
      [Token(Token = "0x6006C50"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (CoinBuyUseBonusRewardParam) null;
      }
    }

    [Token(Token = "0x6006C51")]
    [Address(RVA = "0x352540", Offset = "0x351340", VA = "0x10352540")]
    public void Deserialize(
      JSON_CoinBuyUseBonusContentParam json,
      CoinBuyUseBonusRewardParam[] reward_params)
    {
    }

    [Token(Token = "0x6006C52")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public CoinBuyUseBonusContentParam()
    {
    }
  }
}

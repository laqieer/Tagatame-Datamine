// Decompiled with JetBrains decompiler
// Type: SRPG.BuyCoinRewardParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A3E")]
  public class BuyCoinRewardParam
  {
    [Token(Token = "0x40060A0")]
    [FieldOffset(Offset = "0x8")]
    private string mId;
    [Token(Token = "0x40060A1")]
    [FieldOffset(Offset = "0xC")]
    private BuyCoinManager.PremiumRewadType mDrawType;
    [Token(Token = "0x40060A2")]
    [FieldOffset(Offset = "0x10")]
    private string mDrawIname;
    [Token(Token = "0x40060A3")]
    [FieldOffset(Offset = "0x14")]
    private string mGiftMessage;
    [Token(Token = "0x40060A4")]
    [FieldOffset(Offset = "0x18")]
    private List<BuyCoinRewardItemParam> mRewards;

    [Token(Token = "0x17000BB3")]
    public string Id
    {
      [Token(Token = "0x6006BE6"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000BB4")]
    public BuyCoinManager.PremiumRewadType DrawType
    {
      [Token(Token = "0x6006BE7"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new BuyCoinManager.PremiumRewadType();
      }
    }

    [Token(Token = "0x17000BB5")]
    public string DrawIname
    {
      [Token(Token = "0x6006BE8"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000BB6")]
    public string GiftMessage
    {
      [Token(Token = "0x6006BE9"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000BB7")]
    public List<BuyCoinRewardItemParam> Reward
    {
      [Token(Token = "0x6006BEA"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (List<BuyCoinRewardItemParam>) null;
      }
    }

    [Token(Token = "0x6006BEB")]
    [Address(RVA = "0x34EEB0", Offset = "0x34DCB0", VA = "0x1034EEB0")]
    public bool Deserialize(JSON_BuyCoinRewardParam json) => new bool();

    [Token(Token = "0x6006BEC")]
    [Address(RVA = "0x34F050", Offset = "0x34DE50", VA = "0x1034F050")]
    public BuyCoinRewardParam()
    {
    }
  }
}

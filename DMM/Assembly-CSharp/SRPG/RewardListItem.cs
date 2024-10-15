// Decompiled with JetBrains decompiler
// Type: SRPG.RewardListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200294F")]
  public class RewardListItem : ListItemEvents
  {
    [Token(Token = "0x400C709")]
    [FieldOffset(Offset = "0x38")]
    public GameObject RewardUnit;
    [Token(Token = "0x400C70A")]
    [FieldOffset(Offset = "0x3C")]
    public GameObject RewardItem;
    [Token(Token = "0x400C70B")]
    [FieldOffset(Offset = "0x40")]
    public GameObject RewardCard;
    [Token(Token = "0x400C70C")]
    [FieldOffset(Offset = "0x44")]
    public GameObject RewardArtifact;
    [Token(Token = "0x400C70D")]
    [FieldOffset(Offset = "0x48")]
    public GameObject RewardAward;
    [Token(Token = "0x400C70E")]
    [FieldOffset(Offset = "0x4C")]
    public GameObject RewardGold;
    [Token(Token = "0x400C70F")]
    [FieldOffset(Offset = "0x50")]
    public GameObject RewardCoin;
    [Token(Token = "0x400C710")]
    [FieldOffset(Offset = "0x54")]
    public GameObject RewardEmblem;
    [Token(Token = "0x400C711")]
    [FieldOffset(Offset = "0x58")]
    public Transform RewardList;

    [Token(Token = "0x600BADA")]
    [Address(RVA = "0x825D60", Offset = "0x824B60", VA = "0x10825D60")]
    public void AllNotActive()
    {
    }

    [Token(Token = "0x600BADB")]
    [Address(RVA = "0x8261C0", Offset = "0x824FC0", VA = "0x108261C0")]
    public void CreateRewardIcon(string iname, BuyCoinManager.PremiumRewadType type, int num = -1)
    {
    }

    [Token(Token = "0x600BADC")]
    [Address(RVA = "0x825E10", Offset = "0x824C10", VA = "0x10825E10")]
    public void CreateRewardIcon(string iname, RaidRewardType type, int num = -1)
    {
    }

    [Token(Token = "0x600BADD")]
    [Address(RVA = "0x43AD40", Offset = "0x439B40", VA = "0x1043AD40")]
    public RewardListItem()
    {
    }
  }
}

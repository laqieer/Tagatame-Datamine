// Decompiled with JetBrains decompiler
// Type: SRPG.RaidRewardListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002906")]
  public class RaidRewardListItem : ListItemEvents
  {
    [Token(Token = "0x400C58E")]
    [FieldOffset(Offset = "0x38")]
    public GameObject RewardUnit;
    [Token(Token = "0x400C58F")]
    [FieldOffset(Offset = "0x3C")]
    public GameObject RewardItem;
    [Token(Token = "0x400C590")]
    [FieldOffset(Offset = "0x40")]
    public GameObject RewardCard;
    [Token(Token = "0x400C591")]
    [FieldOffset(Offset = "0x44")]
    public GameObject RewardArtifact;
    [Token(Token = "0x400C592")]
    [FieldOffset(Offset = "0x48")]
    public GameObject RewardAward;
    [Token(Token = "0x400C593")]
    [FieldOffset(Offset = "0x4C")]
    public GameObject RewardGold;
    [Token(Token = "0x400C594")]
    [FieldOffset(Offset = "0x50")]
    public GameObject RewardCoin;
    [Token(Token = "0x400C595")]
    [FieldOffset(Offset = "0x54")]
    public GameObject RewardEmblem;
    [Token(Token = "0x400C596")]
    [FieldOffset(Offset = "0x58")]
    public Transform RewardList;

    [Token(Token = "0x600B9B4")]
    [Address(RVA = "0x43AD40", Offset = "0x439B40", VA = "0x1043AD40")]
    public RaidRewardListItem()
    {
    }
  }
}

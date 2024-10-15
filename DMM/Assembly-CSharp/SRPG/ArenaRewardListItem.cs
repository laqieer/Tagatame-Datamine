// Decompiled with JetBrains decompiler
// Type: SRPG.ArenaRewardListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001FDF")]
  public class ArenaRewardListItem : ListItemEvents
  {
    [Token(Token = "0x400871B")]
    [FieldOffset(Offset = "0x38")]
    public GameObject RankImage;
    [Token(Token = "0x400871C")]
    [FieldOffset(Offset = "0x3C")]
    public GameObject RankText;
    [Token(Token = "0x400871D")]
    [FieldOffset(Offset = "0x40")]
    public GameObject RankObjectSingle;
    [Token(Token = "0x400871E")]
    [FieldOffset(Offset = "0x44")]
    public Text RankTextSingle;
    [Token(Token = "0x400871F")]
    [FieldOffset(Offset = "0x48")]
    public GameObject RankObjectMulti;
    [Token(Token = "0x4008720")]
    [FieldOffset(Offset = "0x4C")]
    public Text RankTextMultiFrom;
    [Token(Token = "0x4008721")]
    [FieldOffset(Offset = "0x50")]
    public Text RankTextMultiTo;
    [Token(Token = "0x4008722")]
    [FieldOffset(Offset = "0x54")]
    public GameObject RankObjectMultiTo;
    [Token(Token = "0x4008723")]
    [FieldOffset(Offset = "0x58")]
    public GameObject RewardCoin;
    [Token(Token = "0x4008724")]
    [FieldOffset(Offset = "0x5C")]
    public GameObject RewardArenaCoin;
    [Token(Token = "0x4008725")]
    [FieldOffset(Offset = "0x60")]
    public GameObject RewardGold;
    [Token(Token = "0x4008726")]
    [FieldOffset(Offset = "0x64")]
    public GameObject RewardItem;

    [Token(Token = "0x600833C")]
    [Address(RVA = "0x43A6B0", Offset = "0x4394B0", VA = "0x1043A6B0")]
    public void Initialize(ArenaRewardParam param, bool end)
    {
    }

    [Token(Token = "0x600833D")]
    [Address(RVA = "0x43AAE0", Offset = "0x4398E0", VA = "0x1043AAE0")]
    private bool SetAmount(GameObject go, int num) => new bool();

    [Token(Token = "0x600833E")]
    [Address(RVA = "0x43ABE0", Offset = "0x4399E0", VA = "0x1043ABE0")]
    private void SetRankingText(ArenaRewardParam param, bool end)
    {
    }

    [Token(Token = "0x600833F")]
    [Address(RVA = "0x43AD40", Offset = "0x439B40", VA = "0x1043AD40")]
    public ArenaRewardListItem()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.WorldRaidRewardContent
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D74")]
  [AddComponentMenu("UI/WorldRaid/WorldRaidRewardContent")]
  public class WorldRaidRewardContent : MonoBehaviour
  {
    [Token(Token = "0x400E2B6")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ImageArray mRankingImages;
    [Token(Token = "0x400E2B7")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mRankingSingleObj;
    [Token(Token = "0x400E2B8")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mRankingSingleTxt;
    [Token(Token = "0x400E2B9")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mRankingMultiObj;
    [Token(Token = "0x400E2BA")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mRankingMultiStartTxt;
    [Token(Token = "0x400E2BB")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text mRankingMultiEndTxt;
    [Token(Token = "0x400E2BC")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Transform mRaidRewardIconRoot;
    [Token(Token = "0x400E2BD")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private RaidRewardIcon mRaidRewardIcon_ItemTemplate;
    [Token(Token = "0x400E2BE")]
    [FieldOffset(Offset = "0x2C")]
    private List<GameObject> mRewardObjs;

    [Token(Token = "0x600D3FB")]
    [Address(RVA = "0x9EC740", Offset = "0x9EB540", VA = "0x109EC740")]
    public void Setup(WorldRaidRankingRewardParam.Reward reward_data, int lap)
    {
    }

    [Token(Token = "0x600D3FC")]
    [Address(RVA = "0x9EC710", Offset = "0x9EB510", VA = "0x109EC710")]
    public void Setup(WorldRaidRewardParam param)
    {
    }

    [Token(Token = "0x600D3FD")]
    [Address(RVA = "0x9EC3B0", Offset = "0x9EB1B0", VA = "0x109EC3B0")]
    private void SetReward(List<WorldRaidRewardParam.Reward> list)
    {
    }

    [Token(Token = "0x600D3FE")]
    [Address(RVA = "0x9ECB70", Offset = "0x9EB970", VA = "0x109ECB70")]
    public WorldRaidRewardContent()
    {
    }
  }
}

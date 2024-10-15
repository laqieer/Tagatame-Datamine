// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidBossDmgRankingBoss
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
  [Token(Token = "0x200256E")]
  [FlowNode.Pin(10, "BOSSランキング画面選択", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(11, "報酬一覧画面選択", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(100, "BOSSリスト追加読み込み", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/GuildRaid/GuildRaidBossDmgRankingBoss")]
  public class GuildRaidBossDmgRankingBoss : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400ACE4")]
    private const int PIN_INPUT_SELECT_BOSSRANKING = 10;
    [Token(Token = "0x400ACE5")]
    private const int PIN_INPUT_SELECT_REWARDLIST = 11;
    [Token(Token = "0x400ACE6")]
    private const int PIN_OUTPUT_REQBOSSLIST = 100;
    [Token(Token = "0x400ACE7")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mRankingTemplate;
    [Token(Token = "0x400ACE8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mRewardTemplate;
    [Token(Token = "0x400ACE9")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mRankingView;
    [Token(Token = "0x400ACEA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mRewardView;
    [Token(Token = "0x400ACEB")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mTitle;
    [Token(Token = "0x400ACEC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SRPG_ScrollRect Scroll;
    [Token(Token = "0x400ACED")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private RectTransform ScrollContent;
    [Token(Token = "0x400ACEE")]
    [FieldOffset(Offset = "0x28")]
    private bool IsLoading;
    [Token(Token = "0x400ACEF")]
    [FieldOffset(Offset = "0x2C")]
    private List<GameObject> mCreateList;
    [Token(Token = "0x400ACF0")]
    [FieldOffset(Offset = "0x30")]
    private List<GameObject> mCreateRewardList;
    [Token(Token = "0x400ACF1")]
    [FieldOffset(Offset = "0x34")]
    private GuildRaidBossDmgRankingBoss.SelectType mSelectType;

    [Token(Token = "0x600A5C0")]
    [Address(RVA = "0x67AC70", Offset = "0x679A70", VA = "0x1067AC70")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A5C1")]
    [Address(RVA = "0x67BB40", Offset = "0x67A940", VA = "0x1067BB40")]
    private void Update()
    {
    }

    [Token(Token = "0x600A5C2")]
    [Address(RVA = "0x67AC00", Offset = "0x679A00", VA = "0x1067AC00", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A5C3")]
    [Address(RVA = "0x67ACB0", Offset = "0x679AB0", VA = "0x1067ACB0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600A5C4")]
    [Address(RVA = "0x67B650", Offset = "0x67A450", VA = "0x1067B650")]
    private void SetRewardIcon(GuildRaidReward reward, RewardListItem listItem)
    {
    }

    [Token(Token = "0x600A5C5")]
    [Address(RVA = "0x67BCC0", Offset = "0x67AAC0", VA = "0x1067BCC0")]
    public GuildRaidBossDmgRankingBoss()
    {
    }

    [Token(Token = "0x200256F")]
    private enum SelectType
    {
      [Token(Token = "0x400ACF3")] Ranking,
      [Token(Token = "0x400ACF4")] Reward,
    }
  }
}

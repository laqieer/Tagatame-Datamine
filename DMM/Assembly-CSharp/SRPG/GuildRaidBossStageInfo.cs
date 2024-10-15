// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidBossStageInfo
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
  [Token(Token = "0x2002575")]
  [AddComponentMenu("UI/GuildRaid/GuildRaidBossStageInfo")]
  [FlowNode.Pin(1002, "Req and Close", FlowNode.PinTypes.Output, 1002)]
  [FlowNode.Pin(1, "Initialize", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "Close Check", FlowNode.PinTypes.Input, 101)]
  [FlowNode.Pin(1001, "Close", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(100, "Select Lap", FlowNode.PinTypes.Input, 100)]
  public class GuildRaidBossStageInfo : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400AD1B")]
    public const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400AD1C")]
    public const int PIN_INPUT_SELECTLAP = 100;
    [Token(Token = "0x400AD1D")]
    public const int PIN_INPUT_CHECK_CLOSE = 101;
    [Token(Token = "0x400AD1E")]
    public const int PIN_OUTPUT_CLOSE = 1001;
    [Token(Token = "0x400AD1F")]
    public const int PIN_OUTPUT_REQ_AND_CLOSE = 1002;
    [Token(Token = "0x400AD20")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RawImage_Transparent mGuildRaidImage;
    [Token(Token = "0x400AD21")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mClearIcon;
    [Token(Token = "0x400AD22")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mBeatReward;
    [Token(Token = "0x400AD23")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mBeatRewardItem;
    [Token(Token = "0x400AD24")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mLastAtkReward;
    [Token(Token = "0x400AD25")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mLastAtkRewardItem;
    [Token(Token = "0x400AD26")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Button mBeatReceiptButton;
    [Token(Token = "0x400AD27")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject[] mRatioRewardPart;
    [Token(Token = "0x400AD28")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Button mRefreshButton;
    [Token(Token = "0x400AD29")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject mChallengeList;
    [Token(Token = "0x400AD2A")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject mApLoopBpRemain;
    [Token(Token = "0x400AD2B")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject mApLoopBpEternal;
    [Token(Token = "0x400AD2C")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject mLapList;
    [Token(Token = "0x400AD2D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Button mLapButtonTemp;
    [Token(Token = "0x400AD2E")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Text mLapText;
    [Token(Token = "0x400AD2F")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private SRPG_ScrollRect mLapScroll;
    [Token(Token = "0x400AD30")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private Text mScheduleCloseText;
    [Token(Token = "0x400AD31")]
    [FieldOffset(Offset = "0x50")]
    private ColorBlock mKeepButtonColor;
    [Token(Token = "0x400AD32")]
    [FieldOffset(Offset = "0xA8")]
    private ColorBlock mChangeButtonColor;
    [Token(Token = "0x400AD33")]
    private const int RATIO_MAX = 5;
    [Token(Token = "0x400AD34")]
    private const int RATIO_COUNT = 20;
    [Token(Token = "0x400AD35")]
    private const int SCROLL_INITLAP = 1;
    [Token(Token = "0x400AD36")]
    [FieldOffset(Offset = "0x100")]
    private bool isListDraw;
    [Token(Token = "0x400AD37")]
    [FieldOffset(Offset = "0x104")]
    private List<GameObject> mListReward;
    [Token(Token = "0x400AD38")]
    [FieldOffset(Offset = "0x108")]
    private List<GameObject> mListChallenge;
    [Token(Token = "0x400AD39")]
    [FieldOffset(Offset = "0x10C")]
    private List<Button> mListButton;

    [Token(Token = "0x600A5DA")]
    [Address(RVA = "0x67D520", Offset = "0x67C320", VA = "0x1067D520")]
    private void Awake()
    {
    }

    [Token(Token = "0x600A5DB")]
    [Address(RVA = "0x67F2B0", Offset = "0x67E0B0", VA = "0x1067F2B0")]
    private void Update()
    {
    }

    [Token(Token = "0x600A5DC")]
    [Address(RVA = "0x67E5D0", Offset = "0x67D3D0", VA = "0x1067E5D0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600A5DD")]
    [Address(RVA = "0x67D3F0", Offset = "0x67C1F0", VA = "0x1067D3F0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A5DE")]
    [Address(RVA = "0x67D610", Offset = "0x67C410", VA = "0x1067D610")]
    private void Init()
    {
    }

    [Token(Token = "0x600A5DF")]
    [Address(RVA = "0x67EE80", Offset = "0x67DC80", VA = "0x1067EE80")]
    private void SetSelectLapButtonColor()
    {
    }

    [Token(Token = "0x600A5E0")]
    [Address(RVA = "0x67E830", Offset = "0x67D630", VA = "0x1067E830")]
    public void OnNoChallengeButton()
    {
    }

    [Token(Token = "0x600A5E1")]
    [Address(RVA = "0x67E680", Offset = "0x67D480", VA = "0x1067E680")]
    public void OnLapSelectButon(Button obj)
    {
    }

    [Token(Token = "0x600A5E2")]
    [Address(RVA = "0x67EA80", Offset = "0x67D880", VA = "0x1067EA80")]
    private void SetRewardIcon(GuildRaidReward reward, RewardListItem listItem)
    {
    }

    [Token(Token = "0x600A5E3")]
    [Address(RVA = "0x67F340", Offset = "0x67E140", VA = "0x1067F340")]
    public GuildRaidBossStageInfo()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.WorldRaidBossStageInfo
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
  [Token(Token = "0x2002D4F")]
  [AddComponentMenu("UI/WorldRaid/WorldRaidBossStageInfo")]
  [FlowNode.Pin(13, "バックボタンタップ", FlowNode.PinTypes.Input, 13)]
  [FlowNode.Pin(101, "PREインデック設定完了", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(12, "右ボタンタップ", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(11, "左ボタンタップ", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(100, "表示更新完了", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(300, "閉じる", FlowNode.PinTypes.Output, 300)]
  [FlowNode.Pin(102, "NEXTインデックス設定完了", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(10, "表示更新", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(104, "NEXTアニメーション開始", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(200, "ボスデータ取得に失敗", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(103, "PREアニメーション開始", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(301, "ワールドトップ画面更新して閉じる", FlowNode.PinTypes.Output, 301)]
  public class WorldRaidBossStageInfo : MonoBehaviour, IFlowInterface, IWebHelp
  {
    [Token(Token = "0x400E1D9")]
    public const int PIN_INPUT_REFRESH = 10;
    [Token(Token = "0x400E1DA")]
    public const int PIN_INPUT_LEFT_BUTTON = 11;
    [Token(Token = "0x400E1DB")]
    public const int PIN_INPUT_RIGHT_BUTTON = 12;
    [Token(Token = "0x400E1DC")]
    public const int PIN_INPUT_BACK_BUTTON = 13;
    [Token(Token = "0x400E1DD")]
    public const int PIN_OUTPUT_REFRESH = 100;
    [Token(Token = "0x400E1DE")]
    public const int PIN_OUTPUT_SET_INDEX_PRE = 101;
    [Token(Token = "0x400E1DF")]
    public const int PIN_OUTPUT_SET_INDEX_NEXT = 102;
    [Token(Token = "0x400E1E0")]
    public const int PIN_OUTPUT_ANIM_START_PRE = 103;
    [Token(Token = "0x400E1E1")]
    public const int PIN_OUTPUT_ANIM_START_NEXT = 104;
    [Token(Token = "0x400E1E2")]
    public const int PIN_OUTPUT_ERROR_NOT_FOUND_BOSS = 200;
    [Token(Token = "0x400E1E3")]
    public const int PIN_OUTPUT_NORMAL_BACK = 300;
    [Token(Token = "0x400E1E4")]
    public const int PIN_OUTPUT_REFRESH_BACK = 301;
    [Token(Token = "0x400E1E5")]
    private const string DEFEAT_TEXT_COLOR = "#808080";
    [Token(Token = "0x400E1E6")]
    private const string DEFAULT_TEXT_COLOR = "#F91A4A";
    [Token(Token = "0x400E1E7")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mNormalBossBg;
    [Token(Token = "0x400E1E8")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mLastBossBg;
    [Token(Token = "0x400E1E9")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private RawPolyImage mBossImage;
    [Token(Token = "0x400E1EA")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mBossNameText;
    [Token(Token = "0x400E1EB")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mBossHpText;
    [Token(Token = "0x400E1EC")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text mBossHpPercent;
    [Token(Token = "0x400E1ED")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text mBossPercentText;
    [Token(Token = "0x400E1EE")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Image mBossElementIcon;
    [Token(Token = "0x400E1EF")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject[] mBossLifeObjs;
    [Token(Token = "0x400E1F0")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Transform mRaidRewardIconParent;
    [Token(Token = "0x400E1F1")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private RaidRewardIcon mRaidRewardIcon_Templete;
    [Token(Token = "0x400E1F2")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private ScrollRect mRaidRewardScroll;
    [Token(Token = "0x400E1F3")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject mRestTimeObj;
    [Token(Token = "0x400E1F4")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text mRestTimeText;
    [Token(Token = "0x400E1F5")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Button mChallengeButton;
    [Token(Token = "0x400E1F6")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject mChallengeLight;
    [Token(Token = "0x400E1F7")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private Button mLeftButton;
    [Token(Token = "0x400E1F8")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Button mRightButton;
    [Token(Token = "0x400E1F9")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private Image mFlickButton;
    [Token(Token = "0x400E1FA")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject mBossPageParent;
    [Token(Token = "0x400E1FB")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private Toggle mTemplateDotIcon;
    [Token(Token = "0x400E1FC")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Button mRefreshButton;
    [Token(Token = "0x400E1FD")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private float mRefreshButtonInterval;
    [Token(Token = "0x400E1FE")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private WorldRaidBattlePoint mBattlePoint;
    [Token(Token = "0x400E1FF")]
    [FieldOffset(Offset = "0x6C")]
    private WorldRaidParam mWorldRaidParam;
    [Token(Token = "0x400E200")]
    [FieldOffset(Offset = "0x70")]
    private WorldRaidBossDetailData mBossData;
    [Token(Token = "0x400E201")]
    [FieldOffset(Offset = "0x74")]
    private WorldRaidParam.BossInfo mBossInfo;
    [Token(Token = "0x400E202")]
    [FieldOffset(Offset = "0x78")]
    private WorldRaidBossParam mBossParam;
    [Token(Token = "0x400E203")]
    [FieldOffset(Offset = "0x7C")]
    private List<GameObject> mRewardList;
    [Token(Token = "0x400E204")]
    [FieldOffset(Offset = "0x80")]
    private List<Toggle> mDotList;
    [Token(Token = "0x400E205")]
    [FieldOffset(Offset = "0x84")]
    private bool mIsAnimInLeft;
    [Token(Token = "0x400E206")]
    [FieldOffset(Offset = "0x85")]
    private bool mIsAnimInRight;
    [Token(Token = "0x400E207")]
    [FieldOffset(Offset = "0x88")]
    private float mRefreshButtonTime;
    [Token(Token = "0x400E208")]
    [FieldOffset(Offset = "0x8C")]
    private Color mDefeatTextColor;
    [Token(Token = "0x400E209")]
    [FieldOffset(Offset = "0x9C")]
    private Color mDefaultTextColor;
    [Token(Token = "0x400E20A")]
    [FieldOffset(Offset = "0xAC")]
    private bool mIsTopRefreshFlag;
    [Token(Token = "0x400E20B")]
    [FieldOffset(Offset = "0xAD")]
    private bool mIsFirstFlag;
    [Token(Token = "0x400E20C")]
    [FieldOffset(Offset = "0xAE")]
    private bool mIsRemainTimeDisp;

    [Token(Token = "0x600D325")]
    [Address(RVA = "0x9E3B50", Offset = "0x9E2950", VA = "0x109E3B50")]
    private void Awake()
    {
    }

    [Token(Token = "0x600D326")]
    [Address(RVA = "0x9E3960", Offset = "0x9E2760", VA = "0x109E3960", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600D327")]
    [Address(RVA = "0x9E55B0", Offset = "0x9E43B0", VA = "0x109E55B0")]
    private void Update()
    {
    }

    [Token(Token = "0x600D328")]
    [Address(RVA = "0x9E5040", Offset = "0x9E3E40", VA = "0x109E5040")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600D329")]
    [Address(RVA = "0x9E45A0", Offset = "0x9E33A0", VA = "0x109E45A0")]
    private void Refresh_BossInfo()
    {
    }

    [Token(Token = "0x600D32A")]
    [Address(RVA = "0x9E5450", Offset = "0x9E4250", VA = "0x109E5450")]
    private void Update_RestTime()
    {
    }

    [Token(Token = "0x600D32B")]
    [Address(RVA = "0x9E3BB0", Offset = "0x9E29B0", VA = "0x109E3BB0")]
    private void CheckLeftRightChange()
    {
    }

    [Token(Token = "0x600D32C")]
    [Address(RVA = "0x9E4240", Offset = "0x9E3040", VA = "0x109E4240")]
    private void OnClickLeftButton()
    {
    }

    [Token(Token = "0x600D32D")]
    [Address(RVA = "0x9E43B0", Offset = "0x9E31B0", VA = "0x109E43B0")]
    private void OnClickRightButton()
    {
    }

    [Token(Token = "0x600D32E")]
    [Address(RVA = "0x9E3D90", Offset = "0x9E2B90", VA = "0x109E3D90")]
    private void CreateDotIcon(List<WorldRaidBossChallengedData> _list)
    {
    }

    [Token(Token = "0x600D32F")]
    [Address(RVA = "0x9E4210", Offset = "0x9E3010", VA = "0x109E4210")]
    private void OnClickBackButton()
    {
    }

    [Token(Token = "0x600D330")]
    [Address(RVA = "0x9E4170", Offset = "0x9E2F70", VA = "0x109E4170", Slot = "5")]
    public bool GetHelpURL(out string url, out string title) => new bool();

    [Token(Token = "0x600D331")]
    [Address(RVA = "0x9E5820", Offset = "0x9E4620", VA = "0x109E5820")]
    public WorldRaidBossStageInfo()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.WorldRaidTop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002D75")]
  [FlowNode.Pin(106, "自動更新開始", FlowNode.PinTypes.Output, 106)]
  [FlowNode.Pin(5, "自動更新確認停止", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(1, "表示更新", FlowNode.PinTypes.Input, 1)]
  [AddComponentMenu("UI/WorldRaid/WorldRaidTop")]
  [FlowNode.Pin(1000, "表示処理エラー時", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(2, "演出判定", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(105, "演出判定終了", FlowNode.PinTypes.Output, 105)]
  [FlowNode.Pin(104, "ボス詳細表示", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(3, "更新ボタンクリック", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(103, "ラスボス出現演出", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(4, "自動更新確認開始", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(102, "ボス撃破演出", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(101, "表示更新完了", FlowNode.PinTypes.Output, 101)]
  public class WorldRaidTop : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400E2BF")]
    private const int PIN_INPUT_SETUP = 1;
    [Token(Token = "0x400E2C0")]
    private const int PIN_INPUT_CHECK_PRODUCTION = 2;
    [Token(Token = "0x400E2C1")]
    private const int PIN_INPUT_CLICK_REFRESH = 3;
    [Token(Token = "0x400E2C2")]
    private const int PIN_INPUT_CHECK_START = 4;
    [Token(Token = "0x400E2C3")]
    private const int PIN_INPUT_CHECK_STOP = 5;
    [Token(Token = "0x400E2C4")]
    private const int PIN_OUTPUT_SETUP_FINISH = 101;
    [Token(Token = "0x400E2C5")]
    private const int PIN_OUTPUT_BOSS_DIRECTION = 102;
    [Token(Token = "0x400E2C6")]
    private const int PIN_OUTPUT_LAST_BOSS_APPEARS = 103;
    [Token(Token = "0x400E2C7")]
    private const int PIN_OUTPUT_BOSS_INFO_OPEN = 104;
    [Token(Token = "0x400E2C8")]
    private const int PIN_OUTPUT_NO_PRODUCTION = 105;
    [Token(Token = "0x400E2C9")]
    private const int PIN_OUTPUT_AUTO_REFRESH_START = 106;
    [Token(Token = "0x400E2CA")]
    private const int PIN_OUTPUT_ERROR = 1000;
    [Token(Token = "0x400E2CB")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject NormalBossBgObj;
    [Token(Token = "0x400E2CC")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject LastBossBgObj;
    [Token(Token = "0x400E2CD")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject EventEndObj;
    [Token(Token = "0x400E2CE")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private WorldRaidBossIcon TemplateWorldRaidBossIcon;
    [Token(Token = "0x400E2CF")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private WorldRaidBossIcon TemplateWorldRaidLastBossIcon;
    [Token(Token = "0x400E2D0")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private List<GameObject> WorldRaidBossPoints;
    [Token(Token = "0x400E2D1")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private List<GameObject> WorldRaidLastBossPoints;
    [Token(Token = "0x400E2D2")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject RemainObj;
    [Token(Token = "0x400E2D3")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Text RemainText;
    [Token(Token = "0x400E2D4")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text ChallengeNum;
    [Token(Token = "0x400E2D5")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject OpeningObj;
    [Token(Token = "0x400E2D6")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text OpeningText;
    [Token(Token = "0x400E2D7")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Button RefreshButton;
    [Token(Token = "0x400E2D8")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject ParentInitialLogData;
    [Token(Token = "0x400E2D9")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private GameObject ParentSecondLogData;
    [Token(Token = "0x400E2DA")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private WorldRaidLogItem TemplateLogData;
    [Token(Token = "0x400E2DB")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private float CreateLogInterval;
    [Token(Token = "0x400E2DC")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private int DisplayLogMaxNum;
    [Token(Token = "0x400E2DD")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private Canvas TargetCanvas;
    [Token(Token = "0x400E2DE")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Button TargetButton;
    [Token(Token = "0x400E2DF")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private GameObject LapObj;
    [Token(Token = "0x400E2E0")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text LapText;
    [Token(Token = "0x400E2E1")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private WorldRaidBattlePoint BattlePoint;
    [Token(Token = "0x400E2E2")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text EventEndText;
    [Token(Token = "0x400E2E3")]
    [FieldOffset(Offset = "0x6C")]
    private List<WorldRaidBossIcon> mBossIcons;
    [Token(Token = "0x400E2E4")]
    [FieldOffset(Offset = "0x70")]
    private List<WorldRaidBossIcon> mLastBossIcons;
    [Token(Token = "0x400E2E5")]
    [FieldOffset(Offset = "0x74")]
    private WorldRaidParam mWorldRaidParam;
    [Token(Token = "0x400E2E6")]
    [FieldOffset(Offset = "0x78")]
    private bool mIsUpdateFlag;
    [Token(Token = "0x400E2E7")]
    [FieldOffset(Offset = "0x7C")]
    private float mAutoRefreshTime;
    [Token(Token = "0x400E2E8")]
    [FieldOffset(Offset = "0x80")]
    private float mRefreshButtonTime;
    [Token(Token = "0x400E2E9")]
    [FieldOffset(Offset = "0x84")]
    private float mFixAutoRefreshTime;
    [Token(Token = "0x400E2EA")]
    [FieldOffset(Offset = "0x88")]
    private float mFixRefreshButtonTime;
    [Token(Token = "0x400E2EB")]
    [FieldOffset(Offset = "0x8C")]
    private bool mIsPlayAnim;
    [Token(Token = "0x400E2EC")]
    [FieldOffset(Offset = "0x8D")]
    private bool mIsLastBossRefresh;
    [Token(Token = "0x400E2ED")]
    [FieldOffset(Offset = "0x8E")]
    private bool mIsChallengeLastBoss;
    [Token(Token = "0x400E2EE")]
    [FieldOffset(Offset = "0x8F")]
    private bool mIsOnlyLastBossDefeatAnim;
    [Token(Token = "0x400E2EF")]
    [FieldOffset(Offset = "0x90")]
    private bool mIsCreateLogFlag;
    [Token(Token = "0x400E2F0")]
    [FieldOffset(Offset = "0x94")]
    private float mCreateLogTime;
    [Token(Token = "0x400E2F1")]
    [FieldOffset(Offset = "0x98")]
    private List<WorldRaidLogData> mLogData;
    [Token(Token = "0x400E2F2")]
    [FieldOffset(Offset = "0x9C")]
    private List<WorldRaidLogItem> mDisplayLogData;
    [Token(Token = "0x400E2F3")]
    [FieldOffset(Offset = "0xA0")]
    private RectTransform mTargetRect;
    [Token(Token = "0x400E2F4")]
    [FieldOffset(Offset = "0xA4")]
    private List<RaycastResult> mTargetRaycastResults;
    [Token(Token = "0x400E2F5")]
    [FieldOffset(Offset = "0xA8")]
    private bool mIsNextChallengeCountDonw;
    [Token(Token = "0x400E2F6")]
    [FieldOffset(Offset = "0xA9")]
    private bool mIsRemainTimeDisp;

    [Token(Token = "0x600D3FF")]
    [Address(RVA = "0x9ECBE0", Offset = "0x9EB9E0", VA = "0x109ECBE0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600D400")]
    [Address(RVA = "0x9ECF40", Offset = "0x9EBD40", VA = "0x109ECF40")]
    private void Awake()
    {
    }

    [Token(Token = "0x600D401")]
    [Address(RVA = "0x9EF4A0", Offset = "0x9EE2A0", VA = "0x109EF4A0")]
    private void SetUp()
    {
    }

    [Token(Token = "0x600D402")]
    [Address(RVA = "0x9ECFC0", Offset = "0x9EBDC0", VA = "0x109ECFC0")]
    private void CheckBossAnim()
    {
    }

    [Token(Token = "0x600D403")]
    [Address(RVA = "0x9EE650", Offset = "0x9ED450", VA = "0x109EE650")]
    private void SetBossIcon(bool _is_force_normal = false)
    {
    }

    [Token(Token = "0x600D404")]
    [Address(RVA = "0x9EE550", Offset = "0x9ED350", VA = "0x109EE550")]
    private void SetBG(bool _is_force_normal = false)
    {
    }

    [Token(Token = "0x600D405")]
    [Address(RVA = "0x9EDB30", Offset = "0x9EC930", VA = "0x109EDB30")]
    private void ClearNormalBossIcon()
    {
    }

    [Token(Token = "0x600D406")]
    [Address(RVA = "0x9ED980", Offset = "0x9EC780", VA = "0x109ED980")]
    private void ClearLastBossIcon()
    {
    }

    [Token(Token = "0x600D407")]
    [Address(RVA = "0x9EE4C0", Offset = "0x9ED2C0", VA = "0x109EE4C0")]
    private void OnClickRefreshButton()
    {
    }

    [Token(Token = "0x600D408")]
    [Address(RVA = "0x9ECEA0", Offset = "0x9EBCA0", VA = "0x109ECEA0")]
    private void AutoRefreshCheckStart(bool _is_time_refresh)
    {
    }

    [Token(Token = "0x600D409")]
    [Address(RVA = "0x9ECF30", Offset = "0x9EBD30", VA = "0x109ECF30")]
    private void AutoRefreshCheckStop()
    {
    }

    [Token(Token = "0x600D40A")]
    [Address(RVA = "0x9EEEA0", Offset = "0x9EDCA0", VA = "0x109EEEA0")]
    private void SetRemainTime()
    {
    }

    [Token(Token = "0x600D40B")]
    [Address(RVA = "0x9EEBB0", Offset = "0x9ED9B0", VA = "0x109EEBB0")]
    private void SetNextTimeRemain()
    {
    }

    [Token(Token = "0x600D40C")]
    [Address(RVA = "0x9EEF20", Offset = "0x9EDD20", VA = "0x109EEF20")]
    private void SetUpLogData()
    {
    }

    [Token(Token = "0x600D40D")]
    [Address(RVA = "0x9EDCE0", Offset = "0x9ECAE0", VA = "0x109EDCE0")]
    private void CreateLogData()
    {
    }

    [Token(Token = "0x600D40E")]
    [Address(RVA = "0x9ECCE0", Offset = "0x9EBAE0", VA = "0x109ECCE0")]
    private void AllClearLog()
    {
    }

    [Token(Token = "0x600D40F")]
    [Address(RVA = "0x9EE1F0", Offset = "0x9ECFF0", VA = "0x109EE1F0")]
    private bool IsTargetRaycast() => new bool();

    [Token(Token = "0x600D410")]
    [Address(RVA = "0x9EFE40", Offset = "0x9EEC40", VA = "0x109EFE40")]
    private void Update()
    {
    }

    [Token(Token = "0x600D411")]
    [Address(RVA = "0x9F0020", Offset = "0x9EEE20", VA = "0x109F0020")]
    public WorldRaidTop()
    {
    }
  }
}

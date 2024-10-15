// Decompiled with JetBrains decompiler
// Type: SRPG.TowerManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B41")]
  [AddComponentMenu("UI/TowerManager")]
  [FlowNode.Pin(7, "初期化（完了）", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(12, "ミッションの進捗の取得した（完了）", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(1, "更新", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(8, "現階層のミッションの進捗取得する？", FlowNode.PinTypes.Input, 8)]
  [FlowNode.Pin(2, "ユニット回復 処理へ", FlowNode.PinTypes.Output, 3)]
  [FlowNode.Pin(0, "初期化", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(3, "ユニット回復（幻晶石不足）", FlowNode.PinTypes.Output, 4)]
  [FlowNode.Pin(4, "一階から再挑戦 処理へ", FlowNode.PinTypes.Output, 5)]
  [FlowNode.Pin(5, "一階から再挑戦（幻晶石不足）", FlowNode.PinTypes.Output, 6)]
  [FlowNode.Pin(6, "一階から再挑戦（完了）", FlowNode.PinTypes.Output, 7)]
  [FlowNode.Pin(9, "ミッションの進捗の取得が必要", FlowNode.PinTypes.Output, 9)]
  [FlowNode.Pin(10, "ミッションの進捗の取得は不要", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(11, "ミッションの進捗の取得した", FlowNode.PinTypes.Input, 11)]
  public class TowerManager : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D357")]
    private const int PIN_ID_INITIALIZE = 0;
    [Token(Token = "0x400D358")]
    private const int PIN_ID_REFRESH = 1;
    [Token(Token = "0x400D359")]
    private const int PIN_ID_RECOVER_UNIT = 2;
    [Token(Token = "0x400D35A")]
    private const int PIN_ID_RECOVER_COIN_NOT_ENOUGH = 3;
    [Token(Token = "0x400D35B")]
    private const int PIN_ID_RESET_TOWER = 4;
    [Token(Token = "0x400D35C")]
    private const int PIN_ID_RESET_TOWER_COIN_NOT_ENOUGH = 5;
    [Token(Token = "0x400D35D")]
    private const int PIN_ID_RESET_TOWER_END = 6;
    [Token(Token = "0x400D35E")]
    private const int PIN_ID_INITIALIZE_END = 7;
    [Token(Token = "0x400D35F")]
    private const int PIN_ID_CHECK_REQUIRED_PROGRESS_REQUEST = 8;
    [Token(Token = "0x400D360")]
    private const int PIN_ID_REQUIRED_PROGRESS_REQUEST = 9;
    [Token(Token = "0x400D361")]
    private const int PIN_ID_UNREQUIRE_PROGRESS_REQUEST = 10;
    [Token(Token = "0x400D362")]
    private const int PIN_ID_SET_REQUIRE_PROGRESS_RECIEVED = 11;
    [Token(Token = "0x400D363")]
    private const int PIN_ID_SET_REQUIRE_PROGRESS_RECIEVED_END = 12;
    [Token(Token = "0x400D364")]
    [FieldOffset(Offset = "0xC")]
    [HeaderBar("▼階層表示用のリスト")]
    [SerializeField]
    private TowerQuestList mTowerQuestList;
    [Token(Token = "0x400D365")]
    [FieldOffset(Offset = "0x10")]
    [HeaderBar("▼階層の詳細表示用オブジェクト")]
    [SerializeField]
    private TowerQuestInfo mTowerQuestInfo;
    [Token(Token = "0x400D366")]
    [FieldOffset(Offset = "0x14")]
    [HeaderBar("▼生存ユニット")]
    [SerializeField]
    private Text AliveUnits;
    [Token(Token = "0x400D367")]
    [FieldOffset(Offset = "0x18")]
    [HeaderBar("▼無料ユニット回復までの時間表示用の親")]
    [SerializeField]
    private GameObject RecoverTimer;
    [Token(Token = "0x400D368")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text RecoverFreeTime;
    [Token(Token = "0x400D369")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text RecoverCost;
    [Token(Token = "0x400D36A")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text RecoverCostFree;
    [Token(Token = "0x400D36B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button RecoverButton;
    [Token(Token = "0x400D36C")]
    [FieldOffset(Offset = "0x2C")]
    [HeaderBar("▼無料ユニット回復までの時間表示用")]
    [SerializeField]
    private ImageArray TimerH10;
    [Token(Token = "0x400D36D")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ImageArray TimerH1;
    [Token(Token = "0x400D36E")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private ImageArray TimerM10;
    [Token(Token = "0x400D36F")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private ImageArray TimerM1;
    [Token(Token = "0x400D370")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private ImageArray TimerS10;
    [Token(Token = "0x400D371")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private ImageArray TimerS1;
    [Token(Token = "0x400D372")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    [HeaderBar("▼ボタン類")]
    private Button DetailButton;
    [Token(Token = "0x400D373")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Button CurrentButton;
    [Token(Token = "0x400D374")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private Button ChallengeButton;
    [Token(Token = "0x400D375")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Button ResetButton;
    [Token(Token = "0x400D376")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private Button MissionButton;
    [Token(Token = "0x400D377")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject RankingButton;
    [Token(Token = "0x400D378")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private GameObject StatusButton;
    [Token(Token = "0x400D379")]
    [FieldOffset(Offset = "0x60")]
    [HeaderBar("▼１階から再挑戦")]
    [SerializeField]
    private Text ResetText;
    [Token(Token = "0x400D37A")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private Text ResetTextFree;
    [Token(Token = "0x400D37B")]
    [FieldOffset(Offset = "0x68")]
    [HeaderBar("▼制御用")]
    [SerializeField]
    private CanvasGroup mCanvasGroup;
    [Token(Token = "0x400D37C")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private ScrollAutoFit mScrollAutoFit;
    [Token(Token = "0x400D37D")]
    [FieldOffset(Offset = "0x70")]
    private TowerParam mTowerParam;
    [Token(Token = "0x400D37E")]
    [FieldOffset(Offset = "0x78")]
    private long mRecoverTime;
    [Token(Token = "0x400D37F")]
    [FieldOffset(Offset = "0x80")]
    private float mRefreshInterval;
    [Token(Token = "0x400D380")]
    [FieldOffset(Offset = "0x84")]
    private bool initialized;
    [Token(Token = "0x400D381")]
    private const string VARIABLE_KEY_EVENT_URL = "CAPTION_TOWER_EVENT_DETAIL";
    [Token(Token = "0x400D382")]
    [FieldOffset(Offset = "0x88")]
    private GameObject mConfirmBox;
    [Token(Token = "0x400D383")]
    [FieldOffset(Offset = "0x8C")]
    private bool is_reset;
    [Token(Token = "0x400D384")]
    [FieldOffset(Offset = "0x8D")]
    private bool m_IsRequireMissionProgressUpdate;
    [Token(Token = "0x400D385")]
    [FieldOffset(Offset = "0x90")]
    private TowerManager.MissionProgressRequestState m_MissionProgressState;

    [Token(Token = "0x600C5F8")]
    [Address(RVA = "0x8E7F40", Offset = "0x8E6D40", VA = "0x108E7F40")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600C5F9")]
    [Address(RVA = "0x8E7ED0", Offset = "0x8E6CD0", VA = "0x108E7ED0")]
    private IEnumerator CheckLoadIcon() => (IEnumerator) null;

    [Token(Token = "0x600C5FA")]
    [Address(RVA = "0x8E8B90", Offset = "0x8E7990", VA = "0x108E8B90")]
    private void OnScrollBegin()
    {
    }

    [Token(Token = "0x600C5FB")]
    [Address(RVA = "0x8E7E20", Offset = "0x8E6C20", VA = "0x108E7E20")]
    private void AddClickListener(Button button, Action clickListener)
    {
    }

    [Token(Token = "0x600C5FC")]
    [Address(RVA = "0x8E91A0", Offset = "0x8E7FA0", VA = "0x108E91A0")]
    private void RemoveClickListener(Button button, Action clickListener)
    {
    }

    [Token(Token = "0x600C5FD")]
    [Address(RVA = "0x8E83F0", Offset = "0x8E71F0", VA = "0x108E83F0")]
    private void OnClick_RecoverButton()
    {
    }

    [Token(Token = "0x600C5FE")]
    [Address(RVA = "0x8E9380", Offset = "0x8E8180", VA = "0x108E9380")]
    private void SetCanvasGroupIntaractable(bool value)
    {
    }

    [Token(Token = "0x600C5FF")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnClick_Detail()
    {
    }

    [Token(Token = "0x600C600")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnClick_Challenge()
    {
    }

    [Token(Token = "0x600C601")]
    [Address(RVA = "0x8E83C0", Offset = "0x8E71C0", VA = "0x108E83C0")]
    private void OnClick_Current()
    {
    }

    [Token(Token = "0x600C602")]
    [Address(RVA = "0x8E87E0", Offset = "0x8E75E0", VA = "0x108E87E0")]
    private void OnClick_Reset()
    {
    }

    [Token(Token = "0x600C603")]
    [Address(RVA = "0x8E7C70", Offset = "0x8E6A70", VA = "0x108E7C70", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C604")]
    [Address(RVA = "0x8E9A70", Offset = "0x8E8870", VA = "0x108E9A70")]
    private void Update()
    {
    }

    [Token(Token = "0x600C605")]
    [Address(RVA = "0x8E8C40", Offset = "0x8E7A40", VA = "0x108E8C40")]
    private void RefreshUI()
    {
    }

    [Token(Token = "0x600C606")]
    [Address(RVA = "0x8E9250", Offset = "0x8E8050", VA = "0x108E9250")]
    private void SetAliveUnitsText()
    {
    }

    [Token(Token = "0x600C607")]
    [Address(RVA = "0x8E93F0", Offset = "0x8E81F0", VA = "0x108E93F0")]
    private void SetRecoverText()
    {
    }

    [Token(Token = "0x600C608")]
    [Address(RVA = "0x8E97C0", Offset = "0x8E85C0", VA = "0x108E97C0")]
    private void UpdateMissionProgressRequestState(TowerFloorParam floorParam)
    {
    }

    [Token(Token = "0x600C609")]
    [Address(RVA = "0x8E9800", Offset = "0x8E8600", VA = "0x108E9800")]
    private void UpdateTimerText(int hours, int minutes, int seconds)
    {
    }

    [Token(Token = "0x600C60A")]
    [Address(RVA = "0x8E98C0", Offset = "0x8E86C0", VA = "0x108E98C0")]
    private void UpdateTimer(int hours, int minutes, int seconds)
    {
    }

    [Token(Token = "0x600C60B")]
    [Address(RVA = "0x8E9AD0", Offset = "0x8E88D0", VA = "0x108E9AD0")]
    public TowerManager()
    {
    }

    [Token(Token = "0x2002B42")]
    private enum MissionProgressRequestState
    {
      [Token(Token = "0x400D387")] NotInitialized,
      [Token(Token = "0x400D388")] RequireProgressRequest,
      [Token(Token = "0x400D389")] UnrequireProgressRequest,
      [Token(Token = "0x400D38A")] ReceivedProgress,
    }
  }
}

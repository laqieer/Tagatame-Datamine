// Decompiled with JetBrains decompiler
// Type: SRPG.RunePrideController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A05")]
  [FlowNode.Pin(102, "シート切替のためにフェードアウト開始", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(111, "レイキャストをONにする", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(112, "レイキャストをOFFにする", FlowNode.PinTypes.Output, 112)]
  [FlowNode.Pin(203, "マス選択解除(能力解放ウィンドウ行き)", FlowNode.PinTypes.Output, 203)]
  [FlowNode.Pin(201, "マス選択(能力解放ウィンドウ行き)", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(202, "マス選択(ボードボーナス行き)", FlowNode.PinTypes.Output, 202)]
  [FlowNode.Pin(204, "マス選択解除(ボードボーナス行き)", FlowNode.PinTypes.Output, 204)]
  [FlowNode.Pin(101, "ボードボーナス更新", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(200, "能力解放ウィンドウ生成", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(500, "能力解放ウィンドウ強制破棄", FlowNode.PinTypes.Output, 500)]
  [FlowNode.Pin(103, "シート切替完了後のフェードイン開始", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(22, "レイキャストをONにする", FlowNode.PinTypes.Input, 22)]
  [FlowNode.NodeType("RunePride/RunePrideController", 32741)]
  [FlowNode.Pin(1, "初期化処理", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(21, "レイキャストをOFFにする", FlowNode.PinTypes.Input, 21)]
  [FlowNode.Pin(15, "能力解放ウィンドウ破棄完了", FlowNode.PinTypes.Input, 15)]
  [FlowNode.Pin(14, "マス開放API通信成功", FlowNode.PinTypes.Input, 14)]
  [FlowNode.Pin(13, "選択中のマスを解除", FlowNode.PinTypes.Input, 13)]
  [FlowNode.Pin(12, "ボードリセットAPI成功", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(11, "能力解放ウィンドウ生成完了", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(10, "シート生成のためのフェードアウト完了", FlowNode.PinTypes.Input, 10)]
  public class RunePrideController : MonoBehaviour, IFlowInterfaceExtend
  {
    [Token(Token = "0x400CC29")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400CC2A")]
    private const int PIN_INPUT_FADE_OUT = 10;
    [Token(Token = "0x400CC2B")]
    private const int PIN_INPUT_WINDOW_CREATED = 11;
    [Token(Token = "0x400CC2C")]
    private const int PIN_INPUT_SUCCESS_RESET = 12;
    [Token(Token = "0x400CC2D")]
    private const int PIN_INPUT_PANEL_SELECT_CANCEL = 13;
    [Token(Token = "0x400CC2E")]
    private const int PIN_INPUT_PANEL_RELEASE_SUCCESS = 14;
    [Token(Token = "0x400CC2F")]
    private const int PIN_INPUT_WINDOW_DESTROYED = 15;
    [Token(Token = "0x400CC30")]
    private const int PIN_INPUT_RAYCAST_OFF = 21;
    [Token(Token = "0x400CC31")]
    private const int PIN_INPUT_RAYCAST_ON = 22;
    [Token(Token = "0x400CC32")]
    private const int PIN_OUTPUT_REFRESH_BOARD_BONUS = 101;
    [Token(Token = "0x400CC33")]
    private const int PIN_OUTPUT_FADE_OUT_FOR_CREATE_SHEET = 102;
    [Token(Token = "0x400CC34")]
    private const int PIN_OUTPUT_FADE_IN_FOR_CREATE_SHEET_END = 103;
    [Token(Token = "0x400CC35")]
    private const int PIN_OUTPUT_RAYCAST_ON = 111;
    [Token(Token = "0x400CC36")]
    private const int PIN_OUTPUT_RAYCAST_OFF = 112;
    [Token(Token = "0x400CC37")]
    private const int PIN_OUTPUT_CREATE_RELEASE_WINDOW = 200;
    [Token(Token = "0x400CC38")]
    private const int PIN_OUTPUT_PANEL_SELECT_TO_RELEASE_WINDOW = 201;
    [Token(Token = "0x400CC39")]
    private const int PIN_OUTPUT_PANEL_SELECT_TO_BOARD_BONUS = 202;
    [Token(Token = "0x400CC3A")]
    private const int PIN_OUTPUT_PANEL_SELECT_CANCEL_TO_RELEASE_WINDOW = 203;
    [Token(Token = "0x400CC3B")]
    private const int PIN_OUTPUT_PANEL_SELECT_CANCEL_TO_BOARD_BONUS = 204;
    [Token(Token = "0x400CC3C")]
    private const int PIN_OUTPUT_FORCE_DESTROY_RELEASE_WINDOW = 500;
    [Token(Token = "0x400CC3D")]
    private const string PREFAB_PATH_FORMAT = "UI/RunePride/board/{0}";
    [Token(Token = "0x400CC3E")]
    private const string ANIMATOR_PREFAB = "UI/RunePride/RunePride_BoardOpenEff";
    [Token(Token = "0x400CC3F")]
    private const string RESET_ANIMATOR_PREFAB = "UI/RunePride/RunePride_BoardResetEff";
    [Token(Token = "0x400CC40")]
    private const int DEFAULT_RESERVE_ID = -1;
    [Token(Token = "0x400CC41")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    [Header("ヘッダーの入力を有効化するグローバルイベント名")]
    private string GLOBAL_EVENT_MAIN_MENU_ON;
    [Token(Token = "0x400CC42")]
    [FieldOffset(Offset = "0x10")]
    [Header("ヘッダーの入力を無効化するグローバルイベント名")]
    [SerializeField]
    private string GLOBAL_EVENT_MAIN_MENU_OFF;
    [Token(Token = "0x400CC43")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ScrollablePulldown sheetLevelPulldown;
    [Token(Token = "0x400CC44")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Transform trSheetParent;
    [Token(Token = "0x400CC45")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Button resetButton;
    [Token(Token = "0x400CC46")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button resetLimitButton;
    [Token(Token = "0x400CC47")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Transform trAnimatorParent;
    [Token(Token = "0x400CC48")]
    [FieldOffset(Offset = "0x28")]
    private RunePridePanelController panelController;
    [Token(Token = "0x400CC49")]
    [FieldOffset(Offset = "0x2C")]
    private string currentPanelIname;
    [Token(Token = "0x400CC4A")]
    [FieldOffset(Offset = "0x30")]
    private (int id, bool canOpen) reserveSquare;
    [Token(Token = "0x400CC4B")]
    [FieldOffset(Offset = "0x38")]
    private bool isReleaseWindowCreated;
    [Token(Token = "0x400CC4C")]
    [FieldOffset(Offset = "0x3C")]
    private int currentIndex;
    [Token(Token = "0x400CC4D")]
    [FieldOffset(Offset = "0x40")]
    private List<RunePridePanelParam> panels;
    [Token(Token = "0x400CC4E")]
    [FieldOffset(Offset = "0x44")]
    private UnitData unitData;
    [Token(Token = "0x400CC4F")]
    [FieldOffset(Offset = "0x48")]
    private bool isExistLateOpenPanel;
    [Token(Token = "0x400CC50")]
    [FieldOffset(Offset = "0x4C")]
    private int canOpenPanelIndex;
    [Token(Token = "0x400CC51")]
    [FieldOffset(Offset = "0x50")]
    private bool needBoardBonusRefresh;
    [Token(Token = "0x400CC52")]
    [FieldOffset(Offset = "0x54")]
    private RunePrideBoardOpenAnimator animator;

    [Token(Token = "0x600BF82")]
    [Address(RVA = "0x87EF20", Offset = "0x87DD20", VA = "0x1087EF20", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BF83")]
    [Address(RVA = "0x87EE00", Offset = "0x87DC00", VA = "0x1087EE00", Slot = "5")]
    public void Activated(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600BF84")]
    [Address(RVA = "0x87FED0", Offset = "0x87ECD0", VA = "0x1087FED0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600BF85")]
    [Address(RVA = "0x87FCE0", Offset = "0x87EAE0", VA = "0x1087FCE0")]
    private void InitializePulldown()
    {
    }

    [Token(Token = "0x600BF86")]
    [Address(RVA = "0x880640", Offset = "0x87F440", VA = "0x10880640")]
    private void SetPulldownPrevSelection(int index)
    {
    }

    [Token(Token = "0x600BF87")]
    [Address(RVA = "0x8805A0", Offset = "0x87F3A0", VA = "0x108805A0")]
    private void SetPulldownPrevSelection(int index, bool isForceCreate = false)
    {
    }

    [Token(Token = "0x600BF88")]
    [Address(RVA = "0x87F820", Offset = "0x87E620", VA = "0x1087F820")]
    private void InitializePanels()
    {
    }

    [Token(Token = "0x600BF89")]
    [Address(RVA = "0x87F250", Offset = "0x87E050", VA = "0x1087F250")]
    private void CreateSheet()
    {
    }

    [Token(Token = "0x600BF8A")]
    [Address(RVA = "0x880280", Offset = "0x87F080", VA = "0x10880280")]
    private void ReleasePanels(bool isPanelClear)
    {
    }

    [Token(Token = "0x600BF8B")]
    [Address(RVA = "0x880770", Offset = "0x87F570", VA = "0x10880770")]
    private void SwitchRaycast(bool isOn)
    {
    }

    [Token(Token = "0x600BF8C")]
    [Address(RVA = "0x8806D0", Offset = "0x87F4D0", VA = "0x108806D0")]
    private IEnumerator StartSheetSwitchAnimation() => (IEnumerator) null;

    [Token(Token = "0x600BF8D")]
    [Address(RVA = "0x87F790", Offset = "0x87E590", VA = "0x1087F790")]
    private void FinishAnimation()
    {
    }

    [Token(Token = "0x600BF8E")]
    [Address(RVA = "0x87FFC0", Offset = "0x87EDC0", VA = "0x1087FFC0")]
    private void RefreshResetButtonInteractable()
    {
    }

    [Token(Token = "0x600BF8F")]
    [Address(RVA = "0x880660", Offset = "0x87F460", VA = "0x10880660")]
    private IEnumerator StartSheetResetAnimation() => (IEnumerator) null;

    [Token(Token = "0x600BF90")]
    [Address(RVA = "0x880740", Offset = "0x87F540", VA = "0x10880740")]
    private void SuccessBoardReset()
    {
    }

    [Token(Token = "0x600BF91")]
    [Address(RVA = "0x87FFA0", Offset = "0x87EDA0", VA = "0x1087FFA0")]
    private void RefreshBoardBonusView()
    {
    }

    [Token(Token = "0x600BF92")]
    [Address(RVA = "0x880490", Offset = "0x87F290", VA = "0x10880490")]
    private void SelectPanel(int squareId, bool canOpen)
    {
    }

    [Token(Token = "0x600BF93")]
    [Address(RVA = "0x880390", Offset = "0x87F190", VA = "0x10880390")]
    private void RemovePanels(List<int> removeIds)
    {
    }

    [Token(Token = "0x600BF94")]
    [Address(RVA = "0x8807F0", Offset = "0x87F5F0", VA = "0x108807F0")]
    public RunePrideController()
    {
    }
  }
}

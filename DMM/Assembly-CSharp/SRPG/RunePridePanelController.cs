// Decompiled with JetBrains decompiler
// Type: SRPG.RunePridePanelController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A14")]
  [FlowNode.NodeType("RunePride/RunePridePanelController", 32741)]
  [FlowNode.Pin(11, "複数選択モード切替", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(12, "能力開放ウインドウが消えた", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(301, "マス選択エラー(分岐確定済み)[表示優先度:高]", FlowNode.PinTypes.Output, 301)]
  [FlowNode.Pin(302, "マス選択エラー(ボーナス上限超過)[表示優先度:中]", FlowNode.PinTypes.Output, 302)]
  [FlowNode.Pin(303, "マス選択エラー(選択不可マス)[表示優先度:低]", FlowNode.PinTypes.Output, 303)]
  [FlowNode.Pin(304, "マス選択エラー(開放済みマス)[表示優先度:低]", FlowNode.PinTypes.Output, 304)]
  public class RunePridePanelController : MonoBehaviour, IFlowInterfaceExtend
  {
    [Token(Token = "0x400CC71")]
    private const int PIN_INPUT_SWITCH_SELECT_MULTIPLE = 11;
    [Token(Token = "0x400CC72")]
    private const int PIN_INPUT_RELEASE_SELECT = 12;
    [Token(Token = "0x400CC73")]
    private const int PIN_OUTPUT_ERROR_ROUTE_NG = 301;
    [Token(Token = "0x400CC74")]
    private const int PIN_OUTPUT_ERROR_POTENTIAL_OVER = 302;
    [Token(Token = "0x400CC75")]
    private const int PIN_OUTPUT_ERROR_SELECT_NG = 303;
    [Token(Token = "0x400CC76")]
    private const int PIN_OUTPUT_ERROR_SELECT_RELEASE = 304;
    [Token(Token = "0x400CC77")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private List<RunePridePanelSquareComponent> panels;
    [Token(Token = "0x400CC78")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ExhibitList exhibitList;
    [Token(Token = "0x400CC79")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ObjectScroller objectScroller;
    [Token(Token = "0x400CC7A")]
    [FieldOffset(Offset = "0x18")]
    [Space(5f)]
    [HeaderBar("▼RunePrideMultiple")]
    [SerializeField]
    private GameObject MultipleObject;
    [Token(Token = "0x400CC7B")]
    [FieldOffset(Offset = "0x1C")]
    [Space(5f)]
    [HeaderBar("▼RunePridePanelToolTip")]
    [SerializeField]
    private RunePridePanelToolTip runePridePanelToolTip;
    [Token(Token = "0x400CC7C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private float TOOLTIP_POS_Y;
    [Token(Token = "0x400CC7D")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private float TOOLTIP_POS_X;
    [Token(Token = "0x400CC7E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private bool IsMultModeOnly;
    [Token(Token = "0x400CC7F")]
    [FieldOffset(Offset = "0x2C")]
    private RunePridePanelModel runePridePanelModel;
    [Token(Token = "0x400CC80")]
    [FieldOffset(Offset = "0x30")]
    private bool isLastLv;
    [Token(Token = "0x400CC81")]
    [FieldOffset(Offset = "0x34")]
    private UnitData unitData;
    [Token(Token = "0x400CC82")]
    [FieldOffset(Offset = "0x38")]
    private RunePridePanelContentsParam panelContentsParam;
    [Token(Token = "0x400CC83")]
    [FieldOffset(Offset = "0x3C")]
    private bool isSelectMultipleMode;
    [Token(Token = "0x400CC84")]
    [FieldOffset(Offset = "0x3D")]
    private bool canOpen;
    [Token(Token = "0x400CC85")]
    [FieldOffset(Offset = "0x3E")]
    private bool isClearPrevAllSheet;
    [Token(Token = "0x400CC86")]
    [FieldOffset(Offset = "0x3F")]
    private bool isPanelCleared;
    [Token(Token = "0x400CC87")]
    [FieldOffset(Offset = "0x40")]
    private bool canSelectGoalSquare;
    [Token(Token = "0x400CC88")]
    [FieldOffset(Offset = "0x44")]
    private Action<int, bool> panelSelectCallback;
    [Token(Token = "0x400CC89")]
    [FieldOffset(Offset = "0x48")]
    private Action<List<int>> panelRemoveCallback;
    [Token(Token = "0x400CC8A")]
    [FieldOffset(Offset = "0x4C")]
    private string panelIname;
    [Token(Token = "0x400CC8B")]
    [FieldOffset(Offset = "0x50")]
    private int bonusMax;
    [Token(Token = "0x400CC8C")]
    [FieldOffset(Offset = "0x54")]
    private int releasedPotentialNum;
    [Token(Token = "0x400CC8D")]
    [FieldOffset(Offset = "0x58")]
    private int selectedPotentialNum;
    [Token(Token = "0x400CC8E")]
    [FieldOffset(Offset = "0x5C")]
    private List<int> releaseSquareIds;
    [Token(Token = "0x400CC8F")]
    [FieldOffset(Offset = "0x60")]
    private List<int> selectNormalIds;
    [Token(Token = "0x400CC90")]
    [FieldOffset(Offset = "0x64")]
    private Dictionary<int, int[]> selectPotentialIdAndPrevIds;
    [Token(Token = "0x400CC91")]
    [FieldOffset(Offset = "0x68")]
    private Dictionary<int, int> releasedForkAndRouteIds;
    [Token(Token = "0x400CC92")]
    [FieldOffset(Offset = "0x6C")]
    private Dictionary<int, int> releasedSecondForkAndRouteIds;
    [Token(Token = "0x400CC93")]
    [FieldOffset(Offset = "0x70")]
    private Dictionary<int, int> selectForkAndRouteIds;
    [Token(Token = "0x400CC94")]
    [FieldOffset(Offset = "0x74")]
    private Dictionary<int, int> selectSecondForkAndRouteIds;
    [Token(Token = "0x400CC95")]
    [FieldOffset(Offset = "0x78")]
    private int forceFocusId;
    [Token(Token = "0x400CC96")]
    [FieldOffset(Offset = "0x7C")]
    private List<int> selectableSquareComponentIndexies;
    [Token(Token = "0x400CC97")]
    [FieldOffset(Offset = "0x80")]
    private bool isReleaseGoalSquare;
    [Token(Token = "0x400CC98")]
    [FieldOffset(Offset = "0x84")]
    private int finishedAnimationCount;
    [Token(Token = "0x400CC99")]
    [FieldOffset(Offset = "0x88")]
    private int releaseAnimationCount;
    [Token(Token = "0x400CC9A")]
    [FieldOffset(Offset = "0x8C")]
    private Action<bool> finishAnimationCallback;
    [Token(Token = "0x400CC9B")]
    [FieldOffset(Offset = "0x90")]
    private RunePridePanelToolTip mToolTip;

    [Token(Token = "0x170019C9")]
    public bool IsSelectMultipleMode
    {
      [Token(Token = "0x600BFC8"), Address(RVA = "0x428380", Offset = "0x427180", VA = "0x10428380")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600BFC9")]
    [Address(RVA = "0x8827C0", Offset = "0x8815C0", VA = "0x108827C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BFCA")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
    public void Activated(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600BFCB")]
    [Address(RVA = "0x883D60", Offset = "0x882B60", VA = "0x10883D60")]
    public void Initialize(RunePridePanelController.SetupData setupData)
    {
    }

    [Token(Token = "0x600BFCC")]
    [Address(RVA = "0x8837A0", Offset = "0x8825A0", VA = "0x108837A0")]
    private void InitializeModel(int startLv, bool isExistLateOpenPanel)
    {
    }

    [Token(Token = "0x600BFCD")]
    [Address(RVA = "0x883990", Offset = "0x882790", VA = "0x10883990")]
    private void InitializePanels()
    {
    }

    [Token(Token = "0x600BFCE")]
    [Address(RVA = "0x884EB0", Offset = "0x883CB0", VA = "0x10884EB0")]
    private void OnSwitchSelectMultiple(bool isSelectMultiple)
    {
    }

    [Token(Token = "0x600BFCF")]
    [Address(RVA = "0x884980", Offset = "0x883780", VA = "0x10884980")]
    private void OnSelect(int squareId)
    {
    }

    [Token(Token = "0x600BFD0")]
    [Address(RVA = "0x882950", Offset = "0x881750", VA = "0x10882950")]
    public void CancelPanelSelect()
    {
    }

    [Token(Token = "0x600BFD1")]
    [Address(RVA = "0x884F90", Offset = "0x883D90", VA = "0x10884F90")]
    private void ReleaseSelectPotential(int _removeId)
    {
    }

    [Token(Token = "0x600BFD2")]
    [Address(RVA = "0x885EE0", Offset = "0x884CE0", VA = "0x10885EE0")]
    private List<int> SelectCancel(int removeId, bool isPotential, bool is_start = false)
    {
      return (List<int>) null;
    }

    [Token(Token = "0x600BFD3")]
    [Address(RVA = "0x8858C0", Offset = "0x8846C0", VA = "0x108858C0")]
    private void RemoveSquare(RunePridePanelSquareComponent panel)
    {
    }

    [Token(Token = "0x600BFD4")]
    [Address(RVA = "0x883F70", Offset = "0x882D70", VA = "0x10883F70")]
    private void IsContainsForkAndRouteInNormalSquares(
      int remove_id,
      RunePridePanelSquareComponent panel,
      ref bool isExistForkAndRoute,
      ref bool isExistSecondForkAndRoute)
    {
    }

    [Token(Token = "0x600BFD5")]
    [Address(RVA = "0x883670", Offset = "0x882470", VA = "0x10883670")]
    private UnitData GetSelectUnit() => (UnitData) null;

    [Token(Token = "0x600BFD6")]
    [Address(RVA = "0x884700", Offset = "0x883500", VA = "0x10884700")]
    public bool IsReleasePanel(int _panelId) => new bool();

    [Token(Token = "0x600BFD7")]
    [Address(RVA = "0x883380", Offset = "0x882180", VA = "0x10883380")]
    private bool CheckSquareRoute(
      int forkId,
      int routeId,
      int secondForkId,
      int secondRouteId,
      int[] prevIds)
    {
      return new bool();
    }

    [Token(Token = "0x600BFD8")]
    [Address(RVA = "0x882980", Offset = "0x881780", VA = "0x10882980")]
    private bool CheckForkAndRoute(int forkId, int routeId, int secondForkId, int secondRouteId)
    {
      return new bool();
    }

    [Token(Token = "0x600BFD9")]
    [Address(RVA = "0x882810", Offset = "0x881610", VA = "0x10882810")]
    private void AddSelectForkAndRoute(
      int forkId,
      int routeId,
      int secondForkId,
      int secondRouteId)
    {
    }

    [Token(Token = "0x600BFDA")]
    [Address(RVA = "0x882B70", Offset = "0x881970", VA = "0x10882B70")]
    private bool CheckPrevIdsOpenedOrSelected(RunePridePanelSquareData data) => new bool();

    [Token(Token = "0x600BFDB")]
    [Address(RVA = "0x882B40", Offset = "0x881940", VA = "0x10882B40")]
    private bool CheckPotentialNum(RunePridePanelSquareData data) => new bool();

    [Token(Token = "0x600BFDC")]
    [Address(RVA = "0x884680", Offset = "0x883480", VA = "0x10884680")]
    private bool IsContains(int[] prevIds, List<int> check) => new bool();

    [Token(Token = "0x600BFDD")]
    [Address(RVA = "0x8835E0", Offset = "0x8823E0", VA = "0x108835E0")]
    private int GetReleasedPrevIdIndex(int[] prevIds) => new int();

    [Token(Token = "0x600BFDE")]
    [Address(RVA = "0x882C20", Offset = "0x881A20", VA = "0x10882C20")]
    private void CheckSelectableSquares(bool isReset = true, bool isInitialize = false)
    {
    }

    [Token(Token = "0x600BFDF")]
    [Address(RVA = "0x885AC0", Offset = "0x8848C0", VA = "0x10885AC0")]
    private void ResetSelectSquares(bool isNeedOutput = false)
    {
    }

    [Token(Token = "0x600BFE0")]
    [Address(RVA = "0x885E10", Offset = "0x884C10", VA = "0x10885E10")]
    private void ResetSelectableSquares()
    {
    }

    [Token(Token = "0x600BFE1")]
    [Address(RVA = "0x8828F0", Offset = "0x8816F0", VA = "0x108828F0")]
    private void AppearErrorWindow(bool isRouteNG, bool isSelectNG, bool isPotentialOver)
    {
    }

    [Token(Token = "0x600BFE2")]
    [Address(RVA = "0x885400", Offset = "0x884200", VA = "0x10885400")]
    public void ReleaseSuccess(int[] releaseIds, Action<bool> finishCallback)
    {
    }

    [Token(Token = "0x600BFE3")]
    [Address(RVA = "0x886730", Offset = "0x885530", VA = "0x10886730")]
    private void SetAnotherRouteMask()
    {
    }

    [Token(Token = "0x600BFE4")]
    [Address(RVA = "0x886AC0", Offset = "0x8858C0", VA = "0x10886AC0")]
    private void SetStarOver()
    {
    }

    [Token(Token = "0x600BFE5")]
    [Address(RVA = "0x8835A0", Offset = "0x8823A0", VA = "0x108835A0")]
    private void FinishSquareReleaseAnimation()
    {
    }

    [Token(Token = "0x600BFE6")]
    [Address(RVA = "0x8828C0", Offset = "0x8816C0", VA = "0x108828C0")]
    private void AddSelectPanel(int squareId)
    {
    }

    [Token(Token = "0x600BFE7")]
    [Address(RVA = "0x885850", Offset = "0x884650", VA = "0x10885850")]
    private void RemoveSelectPanels(List<int> removeIds)
    {
    }

    [Token(Token = "0x600BFE8")]
    [Address(RVA = "0x885830", Offset = "0x884630", VA = "0x10885830")]
    public void RemoveAllSelectPanels()
    {
    }

    [Token(Token = "0x600BFE9")]
    [Address(RVA = "0x886C90", Offset = "0x885A90", VA = "0x10886C90")]
    public void ShowRunePrideToolTip(Transform target, RunePridePanelSquareModel model)
    {
    }

    [Token(Token = "0x600BFEA")]
    [Address(RVA = "0x883500", Offset = "0x882300", VA = "0x10883500")]
    public void DeleteRunePrideToolTip()
    {
    }

    [Token(Token = "0x600BFEB")]
    [Address(RVA = "0x887060", Offset = "0x885E60", VA = "0x10887060")]
    public RunePridePanelController()
    {
    }

    [Token(Token = "0x2002A15")]
    public struct SetupData
    {
      [Token(Token = "0x400CC9C")]
      [FieldOffset(Offset = "0x0")]
      public UnitData Unit;
      [Token(Token = "0x400CC9D")]
      [FieldOffset(Offset = "0x4")]
      public int Lv;
      [Token(Token = "0x400CC9E")]
      [FieldOffset(Offset = "0x8")]
      public bool IsLastLv;
      [Token(Token = "0x400CC9F")]
      [FieldOffset(Offset = "0x9")]
      public bool IsExistLateOpenPanel;
      [Token(Token = "0x400CCA0")]
      [FieldOffset(Offset = "0xC")]
      public RunePridePanelContentsParam PanelContentsParam;
      [Token(Token = "0x400CCA1")]
      [FieldOffset(Offset = "0x10")]
      public bool IsClearPrevAllSheet;
      [Token(Token = "0x400CCA2")]
      [FieldOffset(Offset = "0x14")]
      public Action<int, bool> PanelSelectCallback;
      [Token(Token = "0x400CCA3")]
      [FieldOffset(Offset = "0x18")]
      public Action<List<int>> PanelRemoveCallback;
      [Token(Token = "0x400CCA4")]
      [FieldOffset(Offset = "0x1C")]
      public bool IsSelectMultipleMode;

      [Token(Token = "0x600BFEE")]
      [Address(RVA = "0x890780", Offset = "0x88F580", VA = "0x10890780")]
      public SetupData(
        UnitData unit,
        int lv,
        bool isLastLv,
        bool isExistLateOpenPanel,
        RunePridePanelContentsParam panelContentsParam,
        bool isClearPrevAllSheet,
        Action<int, bool> selectCallback,
        Action<List<int>> removeCallback,
        bool isSelectMultiple = false)
      {
      }
    }
  }
}

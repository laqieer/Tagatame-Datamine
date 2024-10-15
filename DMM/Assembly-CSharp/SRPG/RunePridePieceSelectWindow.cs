// Decompiled with JetBrains decompiler
// Type: SRPG.RunePridePieceSelectWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002A35")]
  [FlowNode.Pin(504, "連続変更停止開始", FlowNode.PinTypes.Output, 504)]
  [FlowNode.Pin(1001, "ウィンドウを閉じる実行", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(503, "連続変更開始", FlowNode.PinTypes.Output, 503)]
  [FlowNode.Pin(101, "抽選実行確認ウィンドウデータ作成", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(10, "連続変更ストップ", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(9, "連続変更継続判断", FlowNode.PinTypes.Input, 9)]
  [FlowNode.Pin(7, "連続変更ウィンドウデータ作成", FlowNode.PinTypes.Input, 7)]
  [FlowNode.Pin(6, "確認画面作成", FlowNode.PinTypes.Input, 6)]
  [FlowNode.Pin(8, "連続変更停止ボタン押下", FlowNode.PinTypes.Input, 8)]
  [FlowNode.Pin(4, "選択MAX", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(3, "選択クリア", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(2, "更新", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(5, "閉じる", FlowNode.PinTypes.Input, 5)]
  public class RunePridePieceSelectWindow : MonoBehaviour, IFlowInterfaceExtend
  {
    [Token(Token = "0x400CCFA")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x400CCFB")]
    private const int PIN_INPUT_REFRESH = 2;
    [Token(Token = "0x400CCFC")]
    private const int PIN_INPUT_ON_CLEAR = 3;
    [Token(Token = "0x400CCFD")]
    private const int PIN_INPUT_ON_MAX = 4;
    [Token(Token = "0x400CCFE")]
    private const int PIN_INPUT_ON_CLOSE = 5;
    [Token(Token = "0x400CCFF")]
    private const int PIN_INPUT_ON_OK = 6;
    [Token(Token = "0x400CD00")]
    private const int PIN_INPUT_CONFIG_DATA_SET = 7;
    [Token(Token = "0x400CD01")]
    private const int PIN_INPUT_RELOT_STOP_RESERVE = 8;
    [Token(Token = "0x400CD02")]
    private const int PIN_INPUT_RELOT_CYCLE = 9;
    [Token(Token = "0x400CD03")]
    private const int PIN_INPUT_RELOT_STOP = 10;
    [Token(Token = "0x400CD04")]
    private const int PIN_OUTPUT_SHOW_RELOTTERY = 101;
    [Token(Token = "0x400CD05")]
    private const int PIN_OUTPUT_CONTINUOUS_RELOT_EXEC = 503;
    [Token(Token = "0x400CD06")]
    private const int PIN_OUTPUT_CONTINUOUS_RELOT_STOP = 504;
    [Token(Token = "0x400CD07")]
    private const int PIN_OUTPUT_CLOSE_EXEC = 1001;
    [Token(Token = "0x400CD08")]
    private const string COUNT_TEXT = "text";
    [Token(Token = "0x400CD09")]
    private const string PLUS_BTN = "plus";
    [Token(Token = "0x400CD0A")]
    private const string MINUS_BTN = "minus";
    [Token(Token = "0x400CD0B")]
    private const string SLIDER = "slider";
    [Token(Token = "0x400CD0C")]
    private const string TOGGLE = "toggle";
    [Token(Token = "0x400CD0D")]
    private const string SLIDER_SOUND = "slider_sound";
    [Token(Token = "0x400CD0E")]
    private const string ITEM_AMOUNT = "have_amount";
    [Token(Token = "0x400CD0F")]
    public const string PREFAB_PATH_RUNE_PRIDE_RESET_STATUS_CONFIG_WINDOW = "UI/RunePride/RunePrideResetStatusConfigWindow";
    [Token(Token = "0x400CD10")]
    private const float RESET_STATUS_WAIT_TIME = 1.5f;
    [Token(Token = "0x400CD11")]
    private const int SLIDER_MIN = 0;
    [Token(Token = "0x400CD12")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList ExhibitList;
    [Token(Token = "0x400CD13")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ContentExhibit ContentExhibit;
    [Token(Token = "0x400CD14")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private SRPG_Button mMaxButton;
    [Token(Token = "0x400CD15")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private CanvasGroup mCanvasGroup;
    [Token(Token = "0x400CD16")]
    [FieldOffset(Offset = "0x1C")]
    private RunePridePieceSelectorWindowModel mModel;
    [Token(Token = "0x400CD17")]
    [FieldOffset(Offset = "0x20")]
    private List<RunePridePieceSelectItemListViewModel> mChildModels;
    [Token(Token = "0x400CD18")]
    [FieldOffset(Offset = "0x24")]
    private UnitData mUnitData;
    [Token(Token = "0x400CD19")]
    [FieldOffset(Offset = "0x28")]
    private RunePrideItemListParam mItemListParam;
    [Token(Token = "0x400CD1A")]
    [FieldOffset(Offset = "0x2C")]
    private string mBonusId;
    [Token(Token = "0x400CD1B")]
    [FieldOffset(Offset = "0x30")]
    private int mSlotNum;
    [Token(Token = "0x400CD1C")]
    [FieldOffset(Offset = "0x34")]
    private List<ContentNode> mNodeList;
    [Token(Token = "0x400CD1D")]
    [FieldOffset(Offset = "0x38")]
    private int mCountPieceAmount;
    [Token(Token = "0x400CD1E")]
    [FieldOffset(Offset = "0x3C")]
    private string mUnitPieceName;
    [Token(Token = "0x400CD1F")]
    [FieldOffset(Offset = "0x40")]
    private RunePridePotentialParam mPotentialParam;
    [Token(Token = "0x400CD20")]
    [FieldOffset(Offset = "0x44")]
    private int mSlotState;
    [Token(Token = "0x400CD21")]
    [FieldOffset(Offset = "0x48")]
    private int mContinueCount;
    [Token(Token = "0x400CD22")]
    [FieldOffset(Offset = "0x4C")]
    private BaseParameterData mSlotParameter;
    [Token(Token = "0x400CD23")]
    [FieldOffset(Offset = "0x50")]
    private List<RunePridePieceSelectWindow.RunePrideToggleState> mLocalSliderStates;
    [Token(Token = "0x400CD24")]
    [FieldOffset(Offset = "0x54")]
    private List<bool> mCheckItemList;
    [Token(Token = "0x400CD25")]
    [FieldOffset(Offset = "0x58")]
    private RunePrideResetStatusConfigWindow mRunePrideResetStatusConfigWindow;
    [Token(Token = "0x400CD26")]
    [FieldOffset(Offset = "0x5C")]
    private bool mIsStopReserved;
    [Token(Token = "0x400CD27")]
    [FieldOffset(Offset = "0x5D")]
    private bool mIsResetExecuting;
    [Token(Token = "0x400CD28")]
    [FieldOffset(Offset = "0x60")]
    private RunePridePieceSelectWindow.ResetContinue mResetContinue;

    [Token(Token = "0x600C05D")]
    [Address(RVA = "0x88BB80", Offset = "0x88A980", VA = "0x1088BB80", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C05E")]
    [Address(RVA = "0x88B9D0", Offset = "0x88A7D0", VA = "0x1088B9D0", Slot = "5")]
    public void Activated(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600C05F")]
    [Address(RVA = "0x88BEF0", Offset = "0x88ACF0", VA = "0x1088BEF0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C060")]
    [Address(RVA = "0x88C530", Offset = "0x88B330", VA = "0x1088C530")]
    public void Init(SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600C061")]
    [Address(RVA = "0x88E750", Offset = "0x88D550", VA = "0x1088E750")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600C062")]
    [Address(RVA = "0x88C450", Offset = "0x88B250", VA = "0x1088C450")]
    private void ExhibitDraw()
    {
    }

    [Token(Token = "0x600C063")]
    [Address(RVA = "0x88C2B0", Offset = "0x88B0B0", VA = "0x1088C2B0")]
    private void ContentExhibitDraw()
    {
    }

    [Token(Token = "0x600C064")]
    [Address(RVA = "0x88BF40", Offset = "0x88AD40", VA = "0x1088BF40")]
    private void CallBackCollectNode(ContentNode node, RunePridePieceSelectItemListViewModel model)
    {
    }

    [Token(Token = "0x600C065")]
    [Address(RVA = "0x88E560", Offset = "0x88D360", VA = "0x1088E560")]
    private void RefreshPotentialSlotParam()
    {
    }

    [Token(Token = "0x600C066")]
    [Address(RVA = "0x88D4B0", Offset = "0x88C2B0", VA = "0x1088D4B0")]
    private void NodeRefresh()
    {
    }

    [Token(Token = "0x600C067")]
    [Address(RVA = "0x88D4E0", Offset = "0x88C2E0", VA = "0x1088D4E0")]
    private void OnClearButton()
    {
    }

    [Token(Token = "0x600C068")]
    [Address(RVA = "0x88D8A0", Offset = "0x88C6A0", VA = "0x1088D8A0")]
    private void OnMaxButton()
    {
    }

    [Token(Token = "0x600C069")]
    [Address(RVA = "0x88E130", Offset = "0x88CF30", VA = "0x1088E130")]
    public void OnValueChangedSlider(ContentNode node)
    {
    }

    [Token(Token = "0x600C06A")]
    [Address(RVA = "0x88DDD0", Offset = "0x88CBD0", VA = "0x1088DDD0")]
    public void OnValueChangedCheckBox(ContentNode node)
    {
    }

    [Token(Token = "0x600C06B")]
    [Address(RVA = "0x88DB70", Offset = "0x88C970", VA = "0x1088DB70")]
    public void OnSelectedPlusButton(ContentNode node)
    {
    }

    [Token(Token = "0x600C06C")]
    [Address(RVA = "0x88DA80", Offset = "0x88C880", VA = "0x1088DA80")]
    public void OnSelectedMinusButton(ContentNode node)
    {
    }

    [Token(Token = "0x600C06D")]
    [Address(RVA = "0x88BDC0", Offset = "0x88ABC0", VA = "0x1088BDC0")]
    private void AllCheckBtnState()
    {
    }

    [Token(Token = "0x600C06E")]
    [Address(RVA = "0x88ECA0", Offset = "0x88DAA0", VA = "0x1088ECA0")]
    private void UpdateNodeList()
    {
    }

    [Token(Token = "0x600C06F")]
    [Address(RVA = "0x88EDD0", Offset = "0x88DBD0", VA = "0x1088EDD0")]
    private void UpdateNode(ContentNode node)
    {
    }

    [Token(Token = "0x600C070")]
    [Address(RVA = "0x88CBB0", Offset = "0x88B9B0", VA = "0x1088CBB0")]
    private static bool IsValidNode(ContentNode node) => new bool();

    [Token(Token = "0x600C071")]
    [Address(RVA = "0x88E890", Offset = "0x88D690", VA = "0x1088E890")]
    private void SavePrefs()
    {
    }

    [Token(Token = "0x600C072")]
    [Address(RVA = "0x88CEA0", Offset = "0x88BCA0", VA = "0x1088CEA0")]
    private void LoadPrefs(string prefs_key)
    {
    }

    [Token(Token = "0x600C073")]
    [Address(RVA = "0x88D040", Offset = "0x88BE40", VA = "0x1088D040")]
    private void MakeChildModelList()
    {
    }

    [Token(Token = "0x600C074")]
    [Address(RVA = "0x88D5B0", Offset = "0x88C3B0", VA = "0x1088D5B0")]
    public void OnExec()
    {
    }

    [Token(Token = "0x600C075")]
    [Address(RVA = "0x88E9B0", Offset = "0x88D7B0", VA = "0x1088E9B0")]
    private void ShowConfigWindow()
    {
    }

    [Token(Token = "0x600C076")]
    [Address(RVA = "0x88BD20", Offset = "0x88AB20", VA = "0x1088BD20")]
    private void ActiveSelfWindow()
    {
    }

    [Token(Token = "0x600C077")]
    [Address(RVA = "0x88C3E0", Offset = "0x88B1E0", VA = "0x1088C3E0")]
    private void EnableConfigWindow()
    {
    }

    [Token(Token = "0x600C078")]
    [Address(RVA = "0x88C370", Offset = "0x88B170", VA = "0x1088C370")]
    private void DisableConfigWindow()
    {
    }

    [Token(Token = "0x600C079")]
    [Address(RVA = "0x88DC70", Offset = "0x88CA70", VA = "0x1088DC70")]
    private void OnStartResetStatusContinue()
    {
    }

    [Token(Token = "0x600C07A")]
    [Address(RVA = "0x88E820", Offset = "0x88D620", VA = "0x1088E820")]
    private IEnumerator ResetStatusContinue() => (IEnumerator) null;

    [Token(Token = "0x600C07B")]
    [Address(RVA = "0x88F040", Offset = "0x88DE40", VA = "0x1088F040")]
    public RunePridePieceSelectWindow()
    {
    }

    [Token(Token = "0x2002A36")]
    private class RunePrideToggleState
    {
      [Token(Token = "0x400CD29")]
      [FieldOffset(Offset = "0x8")]
      public string iname;
      [Token(Token = "0x400CD2A")]
      [FieldOffset(Offset = "0xC")]
      public bool state;
      [Token(Token = "0x400CD2B")]
      [FieldOffset(Offset = "0x10")]
      public int num;

      [Token(Token = "0x600C07D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public RunePrideToggleState()
      {
      }
    }

    [Token(Token = "0x2002A37")]
    public enum StateParamIndex
    {
      [Token(Token = "0x400CD2D")] None = -1, // 0xFFFFFFFF
      [Token(Token = "0x400CD2E")] Iname = 0,
      [Token(Token = "0x400CD2F")] State = 1,
      [Token(Token = "0x400CD30")] Num = 2,
      [Token(Token = "0x400CD31")] Max = 3,
    }

    [Token(Token = "0x2002A38")]
    private enum ResetContinue
    {
      [Token(Token = "0x400CD33")] None,
      [Token(Token = "0x400CD34")] Executing,
    }
  }
}

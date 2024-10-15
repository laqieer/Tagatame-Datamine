// Decompiled with JetBrains decompiler
// Type: SRPG.RuneDisassemblyWindow
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
  [Token(Token = "0x200297A")]
  [FlowNode.Pin(10, "分解リストすべてクリア", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(11, "キャンセル", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(12, "分解実行", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(100, "分解通信開始", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/Rune/RuneDisassemblyWindow")]
  [FlowNode.Pin(200, "ルーンを選択", FlowNode.PinTypes.Input, 200)]
  [FlowNode.Pin(131, "ステータス確認画面表示", FlowNode.PinTypes.Output, 131)]
  [FlowNode.Pin(101, "分解通信完了", FlowNode.PinTypes.Input, 101)]
  [FlowNode.Pin(130, "ステータス確認", FlowNode.PinTypes.Input, 130)]
  [FlowNode.Pin(210, "全て選択", FlowNode.PinTypes.Input, 210)]
  [FlowNode.Pin(201, "ルーンを外す", FlowNode.PinTypes.Input, 201)]
  [FlowNode.Pin(1000, "自身を閉じる", FlowNode.PinTypes.Output, 1000)]
  public class RuneDisassemblyWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C82A")]
    private const int INPUT_RUNE_CLEAR = 10;
    [Token(Token = "0x400C82B")]
    private const int INPUT_RUNE_CANCEL = 11;
    [Token(Token = "0x400C82C")]
    private const int INPUT_RUNE_EXEC = 12;
    [Token(Token = "0x400C82D")]
    private const int OUTPUT_NETWORK_START_EXEC = 100;
    [Token(Token = "0x400C82E")]
    private const int INPUT_NETWORK_FINISH_EXEC = 101;
    [Token(Token = "0x400C82F")]
    private const int INPUT_RUNE_STATUS_CONFIRM = 130;
    [Token(Token = "0x400C830")]
    private const int OUTPUT_RUNE_STATUS_CONFIRM = 131;
    [Token(Token = "0x400C831")]
    private const int INPUT_RUNE_SELECTED = 200;
    [Token(Token = "0x400C832")]
    private const int INPUT_RUNE_UNSELECTED = 201;
    [Token(Token = "0x400C833")]
    private const int INPUT_RUNE_SELECT_ALL = 210;
    [Token(Token = "0x400C834")]
    private const int OUTPUT_CLOSE_WINDOW = 1000;
    [Token(Token = "0x400C835")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mRuneSelectedInfo;
    [Token(Token = "0x400C836")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mRuneUnselectedPanel;
    [Token(Token = "0x400C837")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private RuneDrawInfo mRuneDrawInfo;
    [Token(Token = "0x400C838")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RuneIcon mRuneIcon;
    [Token(Token = "0x400C839")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private RuneDrawBaseState mRuneDrawBaseState;
    [Token(Token = "0x400C83A")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RuneDrawEnhanceLevel mRuneDrawEnhanceLevel;
    [Token(Token = "0x400C83B")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private RuneDrawEvoState mRuneDrawEvoState;
    [Token(Token = "0x400C83C")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private RuneDrawDisassemblyInfo mRuneDrawDisassemblyInfo;
    [Token(Token = "0x400C83D")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Button mExecButton;
    [Token(Token = "0x400C83E")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private RuneSelectableListWindow mRuneSelectableListWindow;
    [Token(Token = "0x400C83F")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private RuneScrollList mRuneDisassemblyScrollList;
    [Token(Token = "0x400C840")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private int mWarningRarity;
    [Token(Token = "0x400C841")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private int mMaxDisassemblySelected;
    [Token(Token = "0x400C842")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Button mResetButton;
    [Token(Token = "0x400C843")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Button mClearButton;
    [Token(Token = "0x400C844")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Button mSelectAllButton;
    [Token(Token = "0x400C845")]
    [FieldOffset(Offset = "0x4C")]
    private BindRuneData mSelectedBindRuneData;
    [Token(Token = "0x400C846")]
    [FieldOffset(Offset = "0x50")]
    private RuneManager mRuneManager;
    [Token(Token = "0x400C847")]
    [FieldOffset(Offset = "0x54")]
    private List<BindRuneData> mRuneDatas;
    [Token(Token = "0x400C848")]
    [FieldOffset(Offset = "0x58")]
    private List<BindRuneData> mPlayerRuneList;
    [Token(Token = "0x400C849")]
    [FieldOffset(Offset = "0x5C")]
    private UnitOverWriteCache mUnitOverWriteCacheData;
    [Token(Token = "0x400C84A")]
    [FieldOffset(Offset = "0x0")]
    private static RuneDisassemblyWindow mInstance;
    [Token(Token = "0x400C84B")]
    [FieldOffset(Offset = "0x60")]
    private Vector2 mVec;

    [Token(Token = "0x1700197F")]
    public UnitOverWriteCache UnitOverWriteCacheData
    {
      [Token(Token = "0x600BBD7"), Address(RVA = "0x288090", Offset = "0x286E90", VA = "0x10288090")] get
      {
        return (UnitOverWriteCache) null;
      }
    }

    [Token(Token = "0x17001980")]
    public static RuneDisassemblyWindow Instance
    {
      [Token(Token = "0x600BBD8"), Address(RVA = "0x83A710", Offset = "0x839510", VA = "0x1083A710")] get
      {
        return (RuneDisassemblyWindow) null;
      }
    }

    [Token(Token = "0x600BBD9")]
    [Address(RVA = "0x838A20", Offset = "0x837820", VA = "0x10838A20")]
    public void Awake()
    {
    }

    [Token(Token = "0x600BBDA")]
    [Address(RVA = "0x8391F0", Offset = "0x837FF0", VA = "0x108391F0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600BBDB")]
    [Address(RVA = "0x837D40", Offset = "0x836B40", VA = "0x10837D40", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BBDC")]
    [Address(RVA = "0x83A200", Offset = "0x839000", VA = "0x1083A200")]
    public void Setup(RuneManager manager, List<BindRuneData> rune_list)
    {
    }

    [Token(Token = "0x600BBDD")]
    [Address(RVA = "0x83A0A0", Offset = "0x838EA0", VA = "0x1083A0A0")]
    public void SetupBindRuneList(List<BindRuneData> rune_list)
    {
    }

    [Token(Token = "0x600BBDE")]
    [Address(RVA = "0x839630", Offset = "0x838430", VA = "0x10839630")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BBDF")]
    [Address(RVA = "0x8393E0", Offset = "0x8381E0", VA = "0x108393E0")]
    private void RefreshTarget(BindRuneData target_rune)
    {
    }

    [Token(Token = "0x600BBE0")]
    [Address(RVA = "0x839F80", Offset = "0x838D80", VA = "0x10839F80")]
    private void SelecteedRuneFromFlowNode()
    {
    }

    [Token(Token = "0x600BBE1")]
    [Address(RVA = "0x839F10", Offset = "0x838D10", VA = "0x10839F10")]
    public void SelectedDetailRune(BindRuneData rune, bool is_refresh = true)
    {
    }

    [Token(Token = "0x600BBE2")]
    [Address(RVA = "0x83A540", Offset = "0x839340", VA = "0x1083A540")]
    public void UnselectRune()
    {
    }

    [Token(Token = "0x600BBE3")]
    [Address(RVA = "0x839CC0", Offset = "0x838AC0", VA = "0x10839CC0")]
    private void SelectAll()
    {
    }

    [Token(Token = "0x600BBE4")]
    [Address(RVA = "0x839230", Offset = "0x838030", VA = "0x10839230")]
    public void OnSelectedRune(BindRuneData rune)
    {
    }

    [Token(Token = "0x600BBE5")]
    [Address(RVA = "0x838930", Offset = "0x837730", VA = "0x10838930")]
    public void AddSelectedRune(BindRuneData rune)
    {
    }

    [Token(Token = "0x600BBE6")]
    [Address(RVA = "0x839C20", Offset = "0x838A20", VA = "0x10839C20")]
    private void ScrollKeepInit()
    {
    }

    [Token(Token = "0x600BBE7")]
    [Address(RVA = "0x839B60", Offset = "0x838960", VA = "0x10839B60")]
    private void ScrollKeepApply()
    {
    }

    [Token(Token = "0x600BBE8")]
    [Address(RVA = "0x838C30", Offset = "0x837A30", VA = "0x10838C30")]
    public void ClearSelectedRune(BindRuneData rune)
    {
    }

    [Token(Token = "0x600BBE9")]
    [Address(RVA = "0x838AF0", Offset = "0x8378F0", VA = "0x10838AF0")]
    public void ClearAllSelectedRune()
    {
    }

    [Token(Token = "0x600BBEA")]
    [Address(RVA = "0x83A450", Offset = "0x839250", VA = "0x1083A450")]
    private int TotalZeny() => new int();

    [Token(Token = "0x600BBEB")]
    [Address(RVA = "0x839130", Offset = "0x837F30", VA = "0x10839130")]
    private bool IsWarning() => new bool();

    [Token(Token = "0x600BBEC")]
    [Address(RVA = "0x838F20", Offset = "0x837D20", VA = "0x10838F20")]
    private List<RuneDisassembly.Materials> DisassemblyPredictedValue()
    {
      return (List<RuneDisassembly.Materials>) null;
    }

    [Token(Token = "0x600BBED")]
    [Address(RVA = "0x7AB9E0", Offset = "0x7AA7E0", VA = "0x107AB9E0")]
    public void CloseSelf()
    {
    }

    [Token(Token = "0x600BBEE")]
    [Address(RVA = "0x838E70", Offset = "0x837C70", VA = "0x10838E70")]
    public void ConfirmDisassembly()
    {
    }

    [Token(Token = "0x600BBEF")]
    [Address(RVA = "0x83A630", Offset = "0x839430", VA = "0x1083A630")]
    public RuneDisassemblyWindow()
    {
    }
  }
}

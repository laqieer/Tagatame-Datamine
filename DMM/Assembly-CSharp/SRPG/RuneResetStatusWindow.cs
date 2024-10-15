// Decompiled with JetBrains decompiler
// Type: SRPG.RuneResetStatusWindow
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
  [Token(Token = "0x20029D9")]
  [FlowNode.Pin(117, "覚醒ステータス強化通信開始", FlowNode.PinTypes.Output, 117)]
  [FlowNode.Pin(118, "覚醒ステータス強化通信完了", FlowNode.PinTypes.Input, 118)]
  [FlowNode.Pin(111, "覚醒ステータス変更通信完了", FlowNode.PinTypes.Input, 111)]
  [FlowNode.Pin(100, "基本ステータス変更通信開始", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(900, "自身を閉じる", FlowNode.PinTypes.Input, 900)]
  [FlowNode.Pin(121, "覚醒のゲージアニメーション再生", FlowNode.PinTypes.Input, 121)]
  [FlowNode.Pin(200, "効果変更", FlowNode.PinTypes.Input, 200)]
  [FlowNode.Pin(201, "効果強化", FlowNode.PinTypes.Input, 201)]
  [FlowNode.Pin(210, "連続効果変更", FlowNode.PinTypes.Input, 210)]
  [FlowNode.Pin(211, "連続効果変更ストップ", FlowNode.PinTypes.Input, 211)]
  [FlowNode.Pin(1000, "自身を閉じる", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(300, "覚醒ステータス確認", FlowNode.PinTypes.Input, 300)]
  [FlowNode.Pin(301, "覚醒ステータス確認", FlowNode.PinTypes.Output, 301)]
  [AddComponentMenu("UI/Rune/RuneResetStatusWindow")]
  [FlowNode.Pin(120, "基本のゲージアニメーション再生", FlowNode.PinTypes.Input, 120)]
  [FlowNode.Pin(1100, "ルーンリスト更新", FlowNode.PinTypes.Input, 1100)]
  [FlowNode.Pin(110, "覚醒ステータス変更通信開始", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(101, "基本ステータス変更通信完了", FlowNode.PinTypes.Input, 101)]
  public class RuneResetStatusWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400CB2C")]
    private const int INPUT_SELECT_BASE = 10;
    [Token(Token = "0x400CB2D")]
    private const int INPUT_SELECT_EVO = 11;
    [Token(Token = "0x400CB2E")]
    private const int OUTPUT_START_RESET_PARAM_BASE = 100;
    [Token(Token = "0x400CB2F")]
    private const int INPUT_FINISHED_RESET_BASE = 101;
    [Token(Token = "0x400CB30")]
    private const int OUTPUT_START_RESET_STATUS_EVO = 110;
    [Token(Token = "0x400CB31")]
    private const int INPUT_FINISHED_RESET_EVO = 111;
    [Token(Token = "0x400CB32")]
    private const int OUTPUT_START_PARAM_ENH_EVO = 117;
    [Token(Token = "0x400CB33")]
    private const int INPUT_FINISHED_PARAM_ENH_EVO = 118;
    [Token(Token = "0x400CB34")]
    private const int INPUT_START_GAUGE_ANIM_BASE = 120;
    [Token(Token = "0x400CB35")]
    private const int INPUT_START_GAUGE_ANIM_EVO = 121;
    [Token(Token = "0x400CB36")]
    private const int INPUT_RESET_BUTTON = 200;
    [Token(Token = "0x400CB37")]
    private const int INPUT_ENHANCE_BUTTON = 201;
    [Token(Token = "0x400CB38")]
    private const int INPUT_RESET_CONTINUE_BUTTON = 210;
    [Token(Token = "0x400CB39")]
    private const int INPUT_RESET_CONTINUE_STOP = 211;
    [Token(Token = "0x400CB3A")]
    private const int INPUT_EVO_STATUS_CONFIRM = 300;
    [Token(Token = "0x400CB3B")]
    private const int OUTPUT_EVO_STATUS_CONFIRMED = 301;
    [Token(Token = "0x400CB3C")]
    private const int INPUT_CLOSE_WINDOW = 900;
    [Token(Token = "0x400CB3D")]
    private const int OUTPUT_CLOSE_WINDOW = 1000;
    [Token(Token = "0x400CB3E")]
    private const int INPUT_REFRESH_RUNE_LIST = 1100;
    [Token(Token = "0x400CB3F")]
    private const int ViewCountNum = 1;
    [Token(Token = "0x400CB40")]
    public const string PREFAB_PATH_RUNE_RESET_STATUS_CONFIG_WINDOW = "UI/Rune/RuneResetStatusConfigWindow";
    [Token(Token = "0x400CB41")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private float mResetStatusWaitTime;
    [Token(Token = "0x400CB42")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RuneDrawCost mRuneDrawCostTemp;
    [Token(Token = "0x400CB43")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private RuneDrawCost mRuneDrawCostEnhanceTemp;
    [Token(Token = "0x400CB44")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RuneDrawInfo mRuneDrawInfo;
    [Token(Token = "0x400CB45")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private RuneIcon mRuneIcon;
    [Token(Token = "0x400CB46")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RuneDrawBaseState mRuneDrawBaseStateView;
    [Token(Token = "0x400CB47")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private RuneDrawBaseState mRuneDrawBaseState;
    [Token(Token = "0x400CB48")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private RuneDrawEvoState mRuneDrawEvoState;
    [Token(Token = "0x400CB49")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    [Space(5f)]
    private GameObject mRuneDrawCostBaseParent;
    [Token(Token = "0x400CB4A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject mRuneDrawCostEvoParent;
    [Token(Token = "0x400CB4B")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject mRuneDrawCostEvoParamEnhParent;
    [Token(Token = "0x400CB4C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    [Space(5f)]
    private GameObject mTargetNone;
    [Token(Token = "0x400CB4D")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject mTargetBase;
    [Token(Token = "0x400CB4E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject mTargetEvo;
    [Token(Token = "0x400CB4F")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private GameObject mTargetEvoParamEnh;
    [Token(Token = "0x400CB50")]
    [FieldOffset(Offset = "0x48")]
    [Space(5f)]
    [SerializeField]
    private ImageArray mButtonReset;
    [Token(Token = "0x400CB51")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private ImageArray mButtonEnhance;
    [Token(Token = "0x400CB52")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    [Space(5f)]
    private GameObject mConfigButton;
    [Token(Token = "0x400CB53")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private GameObject[] mBottomObj;
    [Token(Token = "0x400CB54")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject[] mButtonStop;
    [Token(Token = "0x400CB55")]
    [FieldOffset(Offset = "0x5C")]
    [Space(5f)]
    [SerializeField]
    private Button mButtonClose;
    [Token(Token = "0x400CB56")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Button mButtonDetail;
    [Token(Token = "0x400CB57")]
    [FieldOffset(Offset = "0x64")]
    private RuneManager mRuneManager;
    [Token(Token = "0x400CB58")]
    [FieldOffset(Offset = "0x68")]
    private BindRuneData mRuneData;
    [Token(Token = "0x400CB59")]
    [FieldOffset(Offset = "0x6C")]
    private List<RuneDrawCost> mRuneBaseCostList;
    [Token(Token = "0x400CB5A")]
    [FieldOffset(Offset = "0x70")]
    private List<RuneDrawCost> mRuneEvoCostList;
    [Token(Token = "0x400CB5B")]
    [FieldOffset(Offset = "0x74")]
    private List<RuneDrawCost> mRuneParamEnhEvoCostList;
    [Token(Token = "0x400CB5C")]
    [FieldOffset(Offset = "0x78")]
    private RuneResetStatusConfigWindow mRuneResetStatusConfigWindow;
    [Token(Token = "0x400CB5D")]
    [FieldOffset(Offset = "0x7C")]
    private RuneResetStatusWindow.ButtonType mSelectedTarget;
    [Token(Token = "0x400CB5E")]
    [FieldOffset(Offset = "0x80")]
    private int mSelectedEvoIndex;
    [Token(Token = "0x400CB5F")]
    [FieldOffset(Offset = "0x84")]
    private RuneResetStatusWindow.ResetType mResetType;
    [Token(Token = "0x400CB60")]
    [FieldOffset(Offset = "0x88")]
    private RuneResetStatusWindow.RuneResetContinue mRuneResetContinue;
    [Token(Token = "0x400CB61")]
    [FieldOffset(Offset = "0x8C")]
    private bool mStopReserved;

    [Token(Token = "0x600BEAD")]
    [Address(RVA = "0x862740", Offset = "0x861540", VA = "0x10862740")]
    public void OnClickCostItem(
      RuneCost cost,
      int index,
      RuneResetStatusWindow.ButtonType type,
      RuneResetStatusWindow.ResetType reset)
    {
    }

    [Token(Token = "0x600BEAE")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void Start()
    {
    }

    [Token(Token = "0x600BEAF")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600BEB0")]
    [Address(RVA = "0x860E50", Offset = "0x85FC50", VA = "0x10860E50", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BEB1")]
    [Address(RVA = "0x862910", Offset = "0x861710", VA = "0x10862910")]
    public void OnSelectBaseStatusButton()
    {
    }

    [Token(Token = "0x600BEB2")]
    [Address(RVA = "0x862930", Offset = "0x861730", VA = "0x10862930")]
    public void OnSelectEvoStatusButton(int index)
    {
    }

    [Token(Token = "0x600BEB3")]
    [Address(RVA = "0x863D60", Offset = "0x862B60", VA = "0x10863D60")]
    public void Setup(
      RuneManager manager,
      BindRuneData rune_data,
      bool _is_enhance_evo,
      int _evo_slot_num)
    {
    }

    [Token(Token = "0x600BEB4")]
    [Address(RVA = "0x861C00", Offset = "0x860A00", VA = "0x10861C00")]
    public void CreateButton(
      RuneDrawCost template,
      List<RuneDrawCost> draw_list,
      GameObject parent,
      int num)
    {
    }

    [Token(Token = "0x600BEB5")]
    [Address(RVA = "0x8612F0", Offset = "0x8600F0", VA = "0x108612F0")]
    public void ButtonSetting(
      List<RuneDrawCost> draw_list,
      RuneCost[] cost_list,
      RuneResetStatusWindow.ButtonType btn_type,
      RuneResetStatusWindow.ResetType reset_type)
    {
    }

    [Token(Token = "0x600BEB6")]
    [Address(RVA = "0x863A70", Offset = "0x862870", VA = "0x10863A70")]
    public void SetButtonInteractable(
      List<RuneDrawCost> draw_list,
      RuneCost[] cost_list,
      bool interactable)
    {
    }

    [Token(Token = "0x600BEB7")]
    [Address(RVA = "0x862DF0", Offset = "0x861BF0", VA = "0x10862DF0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BEB8")]
    [Address(RVA = "0x8616C0", Offset = "0x8604C0", VA = "0x108616C0")]
    public void ConfirmResetParamBase(RuneCost cost, int index)
    {
    }

    [Token(Token = "0x600BEB9")]
    [Address(RVA = "0x862450", Offset = "0x861250", VA = "0x10862450")]
    private string GetDefaultConfirmSubText() => (string) null;

    [Token(Token = "0x600BEBA")]
    [Address(RVA = "0x861A00", Offset = "0x860800", VA = "0x10861A00")]
    public void ConfirmResetStatusEvo(RuneCost cost, int index)
    {
    }

    [Token(Token = "0x600BEBB")]
    [Address(RVA = "0x861570", Offset = "0x860370", VA = "0x10861570")]
    public void ConfirmParamEnhEvo(RuneCost cost, int index)
    {
    }

    [Token(Token = "0x600BEBC")]
    [Address(RVA = "0x862CE0", Offset = "0x861AE0", VA = "0x10862CE0")]
    private void OpenConfigWindow(BindRuneData selected_rune)
    {
    }

    [Token(Token = "0x600BEBD")]
    [Address(RVA = "0x8623B0", Offset = "0x8611B0", VA = "0x108623B0")]
    private void EnableConfigWindow()
    {
    }

    [Token(Token = "0x600BEBE")]
    [Address(RVA = "0x862310", Offset = "0x861110", VA = "0x10862310")]
    private void DisableConfigWindow()
    {
    }

    [Token(Token = "0x600BEBF")]
    [Address(RVA = "0x8625D0", Offset = "0x8613D0", VA = "0x108625D0")]
    private int GetResetStatusEvoCoinCost() => new int();

    [Token(Token = "0x600BEC0")]
    [Address(RVA = "0x862960", Offset = "0x861760", VA = "0x10862960")]
    private void OnStartResetStatusContinue()
    {
    }

    [Token(Token = "0x600BEC1")]
    [Address(RVA = "0x863BB0", Offset = "0x8629B0", VA = "0x10863BB0")]
    private void SetResetContinueBottomView(bool isDefaultView)
    {
    }

    [Token(Token = "0x600BEC2")]
    [Address(RVA = "0x863CB0", Offset = "0x862AB0", VA = "0x10863CB0")]
    public void SetResetContinueInteractable(bool b_enable)
    {
    }

    [Token(Token = "0x600BEC3")]
    [Address(RVA = "0x863A00", Offset = "0x862800", VA = "0x10863A00")]
    private IEnumerator ResetStatusContinue() => (IEnumerator) null;

    [Token(Token = "0x600BEC4")]
    [Address(RVA = "0x8626A0", Offset = "0x8614A0", VA = "0x108626A0")]
    private bool IsNotEnoughResetStatusContinue() => new bool();

    [Token(Token = "0x600BEC5")]
    [Address(RVA = "0x7AB9E0", Offset = "0x7AA7E0", VA = "0x107AB9E0")]
    public void CloseSelf()
    {
    }

    [Token(Token = "0x600BEC6")]
    [Address(RVA = "0x861E70", Offset = "0x860C70", VA = "0x10861E70")]
    public static void CreateCostText(RuneCost cost, out int count, out string txt)
    {
    }

    [Token(Token = "0x600BEC7")]
    [Address(RVA = "0x864200", Offset = "0x863000", VA = "0x10864200")]
    public RuneResetStatusWindow()
    {
    }

    [Token(Token = "0x20029DA")]
    public enum ButtonType
    {
      [Token(Token = "0x400CB63")] None,
      [Token(Token = "0x400CB64")] Base,
      [Token(Token = "0x400CB65")] Evo,
    }

    [Token(Token = "0x20029DB")]
    public enum ResetType
    {
      [Token(Token = "0x400CB67")] Reset,
      [Token(Token = "0x400CB68")] Enhance,
    }

    [Token(Token = "0x20029DC")]
    private enum RuneResetContinue
    {
      [Token(Token = "0x400CB6A")] None,
      [Token(Token = "0x400CB6B")] Executing,
    }
  }
}

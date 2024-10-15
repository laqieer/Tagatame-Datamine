// Decompiled with JetBrains decompiler
// Type: SRPG.RuneEnhanceWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200299F")]
  [FlowNode.Pin(130, "ステータス確認", FlowNode.PinTypes.Input, 130)]
  [AddComponentMenu("UI/Rune/RuneEnhanceWindow")]
  [FlowNode.Pin(112, "連続「強化・覚醒」後に再度ウインドウ表示", FlowNode.PinTypes.Input, 112)]
  [FlowNode.Pin(111, "連続「強化・覚醒」通信完了", FlowNode.PinTypes.Input, 111)]
  [FlowNode.Pin(101, "連続「強化・覚醒」通信開始", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(100, "強化通信開始", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(131, "ステータス確認画面表示", FlowNode.PinTypes.Output, 131)]
  [FlowNode.Pin(141, "コスト変更", FlowNode.PinTypes.Input, 141)]
  [FlowNode.Pin(11, "ゲージ使用", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(1000, "自身を閉じる", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(120, "通常強化/連続強化の切替", FlowNode.PinTypes.Input, 120)]
  [FlowNode.Pin(110, "強化通信完了", FlowNode.PinTypes.Input, 110)]
  [FlowNode.Pin(10, "強化", FlowNode.PinTypes.Input, 10)]
  public class RuneEnhanceWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C942")]
    private const int INPUT_RUNE_ENHANCE = 10;
    [Token(Token = "0x400C943")]
    private const int INPUT_RUNE_USE_GAUGE = 11;
    [Token(Token = "0x400C944")]
    private const int OUTPUT_START_ENHANCE = 100;
    [Token(Token = "0x400C945")]
    private const int OUTPUT_START_BULK_ENHANCE = 101;
    [Token(Token = "0x400C946")]
    private const int INPUT_FINISHED_ENHANCE = 110;
    [Token(Token = "0x400C947")]
    private const int INPUT_FINISHED_BULK_ENHANCE = 111;
    [Token(Token = "0x400C948")]
    private const int INPUT_FINISHED_BULK_ENHANCE_AND_OPEN_WINDOW = 112;
    [Token(Token = "0x400C949")]
    private const int INPUT_SWITCH_ENHANCE_MODE = 120;
    [Token(Token = "0x400C94A")]
    private const int INPUT_RUNE_STATUS_CONFIRM = 130;
    [Token(Token = "0x400C94B")]
    private const int OUTPUT_RUNE_STATUS_CONFIRM = 131;
    [Token(Token = "0x400C94C")]
    private const int INPUT_COST_CHANGE = 141;
    [Token(Token = "0x400C94D")]
    private const int OUTPUT_CLOSE_WINDOW = 1000;
    [Token(Token = "0x400C94E")]
    private const int NORMAL_ENHANCE_ADD = 1;
    [Token(Token = "0x400C94F")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RuneDrawInfo mRuneDrawInfo;
    [Token(Token = "0x400C950")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RuneIcon mRuneIcon;
    [Token(Token = "0x400C951")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private RuneDrawBaseState mRuneDrawBaseState;
    [Token(Token = "0x400C952")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RuneDrawBaseState mRuneDrawAfterBaseState;
    [Token(Token = "0x400C953")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private RuneDrawEnhanceLevel mRuneDrawEnhanceLevel;
    [Token(Token = "0x400C954")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RuneDrawEvoState mRuneDrawEvoState;
    [Token(Token = "0x400C955")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private RuneDrawCost mRuneDrawCost;
    [Token(Token = "0x400C956")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private RuneDrawEnhancePercentage mRuneDrawEnhancePercentage;
    [Token(Token = "0x400C957")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private RuneContinueEnhance mRuneContinueEnhance;
    [Token(Token = "0x400C958")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private RuneContinueReinforcement mRuneContinueReinforcement;
    [Token(Token = "0x400C959")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private RuneDrawCostEx mRuneDrawCostEx;
    [Token(Token = "0x400C95A")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private RuneIcon mBulkRuneIcon;
    [Token(Token = "0x400C95B")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Button mEnhanceButton;
    [Token(Token = "0x400C95C")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject mNormalEnhanceModeUI;
    [Token(Token = "0x400C95D")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private GameObject mContinueEnhanceModeUI;
    [Token(Token = "0x400C95E")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private ImageArray mSwitchEnhanceModeImage;
    [Token(Token = "0x400C95F")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private SerializeValueBehaviour mSVB;
    [Token(Token = "0x400C960")]
    [FieldOffset(Offset = "0x50")]
    private RuneManager mRuneManager;
    [Token(Token = "0x400C961")]
    [FieldOffset(Offset = "0x54")]
    private BindRuneData mRuneData;
    [Token(Token = "0x400C962")]
    [FieldOffset(Offset = "0x58")]
    private BindRuneData mBeforeRune;
    [Token(Token = "0x400C963")]
    [FieldOffset(Offset = "0x5C")]
    private bool mIsUseEnforceGauge;
    [Token(Token = "0x400C964")]
    [FieldOffset(Offset = "0x5D")]
    private bool mIsNormalEnhance;

    [Token(Token = "0x600BCC4")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void Awake()
    {
    }

    [Token(Token = "0x600BCC5")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600BCC6")]
    [Address(RVA = "0x846D80", Offset = "0x845B80", VA = "0x10846D80")]
    private void SetSerializeValueBehaviour()
    {
    }

    [Token(Token = "0x600BCC7")]
    [Address(RVA = "0x845FA0", Offset = "0x844DA0", VA = "0x10845FA0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BCC8")]
    [Address(RVA = "0x846C10", Offset = "0x845A10", VA = "0x10846C10")]
    public void ReturnBulkEnhance()
    {
    }

    [Token(Token = "0x600BCC9")]
    [Address(RVA = "0x846F40", Offset = "0x845D40", VA = "0x10846F40")]
    public void Setup(RuneManager manager, BindRuneData rune_data, bool is_reset = false)
    {
    }

    [Token(Token = "0x600BCCA")]
    [Address(RVA = "0x8465A0", Offset = "0x8453A0", VA = "0x108465A0")]
    public void CostChange()
    {
    }

    [Token(Token = "0x600BCCB")]
    [Address(RVA = "0x8468C0", Offset = "0x8456C0", VA = "0x108468C0")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BCCC")]
    [Address(RVA = "0x846820", Offset = "0x845620", VA = "0x10846820")]
    public void RefreshButton()
    {
    }

    [Token(Token = "0x600BCCD")]
    [Address(RVA = "0x8463C0", Offset = "0x8451C0", VA = "0x108463C0")]
    public void ConfirmEnhance()
    {
    }

    [Token(Token = "0x600BCCE")]
    [Address(RVA = "0x846350", Offset = "0x845150", VA = "0x10846350")]
    public void BulkConfirmEnhance()
    {
    }

    [Token(Token = "0x600BCCF")]
    [Address(RVA = "0x8473F0", Offset = "0x8461F0", VA = "0x108473F0")]
    public void SwitchEnhanceMode()
    {
    }

    [Token(Token = "0x600BCD0")]
    [Address(RVA = "0x847580", Offset = "0x846380", VA = "0x10847580")]
    public RuneEnhanceWindow()
    {
    }
  }
}

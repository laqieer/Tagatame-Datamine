// Decompiled with JetBrains decompiler
// Type: SRPG.RuneEnhanceEffectWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200299C")]
  [FlowNode.Pin(110, "強化通信完了", FlowNode.PinTypes.Input, 110)]
  [FlowNode.Pin(120, "強化再演出開始", FlowNode.PinTypes.Output, 120)]
  [FlowNode.Pin(250, "連続強化でない", FlowNode.PinTypes.Output, 250)]
  [FlowNode.Pin(230, "連続強化を止める", FlowNode.PinTypes.Input, 230)]
  [FlowNode.Pin(200, "自身を閉じてルーン装備へ", FlowNode.PinTypes.Input, 200)]
  [FlowNode.Pin(1000, "自身を閉じる", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(240, "連続強化である", FlowNode.PinTypes.Output, 240)]
  [AddComponentMenu("UI/Rune/RuneEnhanceEffectWindow")]
  [FlowNode.Pin(2, "強化成功アニメーション", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(12, "ボタン表示更新", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(11, "ゲージ使用", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(10, "強化", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(3, "強化失敗アニメーション", FlowNode.PinTypes.Output, 3)]
  [FlowNode.Pin(220, "強化アニメーション終了", FlowNode.PinTypes.Output, 220)]
  [FlowNode.Pin(1, "強化アニメーション開始", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(100, "強化通信開始", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(210, "強化アニメーション終了", FlowNode.PinTypes.Input, 210)]
  public class RuneEnhanceEffectWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C918")]
    private const int INPUT_RUNE_ENHANCE_ANIM = 1;
    [Token(Token = "0x400C919")]
    private const int OUTPUT_RUNE_ENHANCE_SUCCESS_ANIM = 2;
    [Token(Token = "0x400C91A")]
    private const int OUTPUT_RUNE_ENHANCE_FAILURE_ANIM = 3;
    [Token(Token = "0x400C91B")]
    private const int INPUT_RUNE_ENHANCE = 10;
    [Token(Token = "0x400C91C")]
    private const int INPUT_RUNE_USE_GAUGE = 11;
    [Token(Token = "0x400C91D")]
    private const int INPUT_REFRESH_BUTTON = 12;
    [Token(Token = "0x400C91E")]
    private const int OUTPUT_START_ENHANCE = 100;
    [Token(Token = "0x400C91F")]
    private const int INPUT_FINISHED_ENHANCE = 110;
    [Token(Token = "0x400C920")]
    private const int OUTPUT_START_RE_ENHANCE = 120;
    [Token(Token = "0x400C921")]
    private const int INPUT_CLOSE_TO_EQUIP = 200;
    [Token(Token = "0x400C922")]
    private const int INPUT_END_RUNE_ENHANCE_ANIM = 210;
    [Token(Token = "0x400C923")]
    private const int OUTPUT_END_RUNE_ENHANCE_ANIM = 220;
    [Token(Token = "0x400C924")]
    private const int INPUT_STOP_CONTINUE_ENHANCE = 230;
    [Token(Token = "0x400C925")]
    private const int OUTPUT_CONTINUE_ENHANCE_ON = 240;
    [Token(Token = "0x400C926")]
    private const int OUTPUT_CONTINUE_ENHANCE_OFF = 250;
    [Token(Token = "0x400C927")]
    private const int OUTPUT_CLOSE_WINDOW = 1000;
    [Token(Token = "0x400C928")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private float CONTINUE_ENHANCE_INTERVAL;
    [Token(Token = "0x400C929")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RuneIcon mRuneIcon;
    [Token(Token = "0x400C92A")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private RuneDrawEnhanceLevel mRuneDrawEnhanceLevel;
    [Token(Token = "0x400C92B")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RuneDrawEnhancedBaseState mRuneDrawEnhancedBaseState;
    [Token(Token = "0x400C92C")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private RuneDrawCost mRuneDrawCost;
    [Token(Token = "0x400C92D")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RuneDrawEnhanceEffect mRuneDrawEnhanceEffect;
    [Token(Token = "0x400C92E")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private RuneDrawEnhancePercentage mRuneDrawEnhancePercentage;
    [Token(Token = "0x400C92F")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Button mEnhanceButton;
    [Token(Token = "0x400C930")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject mSwitchObj_NextEnhance;
    [Token(Token = "0x400C931")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject mSwitchObj_NextEvo;
    [Token(Token = "0x400C932")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Button mCloseButton;
    [Token(Token = "0x400C933")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Button mContinueEnhanceStopButton;
    [Token(Token = "0x400C934")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Button mUseGaugeButton;
    [Token(Token = "0x400C935")]
    [FieldOffset(Offset = "0x40")]
    private RuneManager mRuneManager;
    [Token(Token = "0x400C936")]
    [FieldOffset(Offset = "0x44")]
    private BindRuneData mRuneDataBefore;
    [Token(Token = "0x400C937")]
    [FieldOffset(Offset = "0x48")]
    private BindRuneData mRuneDataCurr;
    [Token(Token = "0x400C938")]
    [FieldOffset(Offset = "0x4C")]
    private bool mIsEnhanceSuccess;
    [Token(Token = "0x400C939")]
    [FieldOffset(Offset = "0x4D")]
    private bool mIsUseEnforceGauge;
    [Token(Token = "0x400C93A")]
    [FieldOffset(Offset = "0x4E")]
    private bool mIsStopContinueEnhanceTime;
    [Token(Token = "0x400C93B")]
    [FieldOffset(Offset = "0x4F")]
    private bool mIsContinueEnhance;
    [Token(Token = "0x400C93C")]
    [FieldOffset(Offset = "0x50")]
    private float mRestContinueEnhanceTime;
    [Token(Token = "0x400C93D")]
    [FieldOffset(Offset = "0x54")]
    private GameObject mConfirmEnhancePopup;

    [Token(Token = "0x600BCA6")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void Awake()
    {
    }

    [Token(Token = "0x600BCA7")]
    [Address(RVA = "0x844E80", Offset = "0x843C80", VA = "0x10844E80")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600BCA8")]
    [Address(RVA = "0x8445B0", Offset = "0x8433B0", VA = "0x108445B0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BCA9")]
    [Address(RVA = "0x845C40", Offset = "0x844A40", VA = "0x10845C40")]
    private void Update()
    {
    }

    [Token(Token = "0x600BCAA")]
    [Address(RVA = "0x8454A0", Offset = "0x8442A0", VA = "0x108454A0")]
    public void Setup(
      RuneManager manager,
      BindRuneData before_rune_data,
      BindRuneData after_rune_data,
      float _before_gauge)
    {
    }

    [Token(Token = "0x600BCAB")]
    [Address(RVA = "0x845280", Offset = "0x844080", VA = "0x10845280")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BCAC")]
    [Address(RVA = "0x844CA0", Offset = "0x843AA0", VA = "0x10844CA0")]
    private void EnhanceButtonRefresh()
    {
    }

    [Token(Token = "0x600BCAD")]
    [Address(RVA = "0x844B40", Offset = "0x843940", VA = "0x10844B40")]
    public void ConfirmEnhance()
    {
    }

    [Token(Token = "0x600BCAE")]
    [Address(RVA = "0x8451F0", Offset = "0x843FF0", VA = "0x108451F0")]
    private void PlayAnimation()
    {
    }

    [Token(Token = "0x600BCAF")]
    [Address(RVA = "0x844F50", Offset = "0x843D50", VA = "0x10844F50")]
    private void OnEnhanceAnimationEnd()
    {
    }

    [Token(Token = "0x600BCB0")]
    [Address(RVA = "0x845B50", Offset = "0x844950", VA = "0x10845B50")]
    private void StopContinueEnhance()
    {
    }

    [Token(Token = "0x600BCB1")]
    [Address(RVA = "0x845C40", Offset = "0x844A40", VA = "0x10845C40")]
    private void Update_ContinueEnhance()
    {
    }

    [Token(Token = "0x600BCB2")]
    [Address(RVA = "0x845B20", Offset = "0x844920", VA = "0x10845B20")]
    private void StartEnhance()
    {
    }

    [Token(Token = "0x600BCB3")]
    [Address(RVA = "0x844D30", Offset = "0x843B30", VA = "0x10844D30")]
    private bool IsEnableContinueEnhance() => new bool();

    [Token(Token = "0x600BCB4")]
    [Address(RVA = "0x845480", Offset = "0x844280", VA = "0x10845480")]
    private void ResetContinueEnhanceParam()
    {
    }

    [Token(Token = "0x600BCB5")]
    [Address(RVA = "0x74DD10", Offset = "0x74CB10", VA = "0x1074DD10")]
    public RuneEnhanceEffectWindow()
    {
    }
  }
}

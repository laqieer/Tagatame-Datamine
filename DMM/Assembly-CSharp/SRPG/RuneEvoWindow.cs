// Decompiled with JetBrains decompiler
// Type: SRPG.RuneEvoWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20029A7")]
  [FlowNode.Pin(130, "ステータス確認", FlowNode.PinTypes.Input, 130)]
  [FlowNode.Pin(10, "覚醒", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(100, "覚醒通信開始", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(110, "覚醒通信完了", FlowNode.PinTypes.Input, 110)]
  [FlowNode.Pin(131, "ステータス確認画面表示", FlowNode.PinTypes.Output, 131)]
  [FlowNode.Pin(141, "コスト変更", FlowNode.PinTypes.Input, 141)]
  [FlowNode.Pin(101, "連続「強化・覚醒」通信開始", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(111, "連続「強化・覚醒」通信完了", FlowNode.PinTypes.Input, 111)]
  [FlowNode.Pin(112, "連続「強化・覚醒」後に再度ウインドウ表示", FlowNode.PinTypes.Input, 112)]
  [AddComponentMenu("UI/Rune/RuneEvoWindow")]
  [FlowNode.Pin(1000, "自身を閉じる", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(120, "通常強化/連続強化の切替", FlowNode.PinTypes.Input, 120)]
  public class RuneEvoWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400C9A4")]
    private const int INPUT_RUNE_EVO = 10;
    [Token(Token = "0x400C9A5")]
    private const int OUTPUT_START_EVO = 100;
    [Token(Token = "0x400C9A6")]
    private const int OUTPUT_START_BULK_ENHANCE = 101;
    [Token(Token = "0x400C9A7")]
    private const int INPUT_FINISHED_EVO = 110;
    [Token(Token = "0x400C9A8")]
    private const int INPUT_FINISHED_BULK_ENHANCE = 111;
    [Token(Token = "0x400C9A9")]
    private const int INPUT_FINISHED_BULK_ENHANCE_AND_OPEN_WINDOW = 112;
    [Token(Token = "0x400C9AA")]
    private const int INPUT_SWITCH_ENHANCE_MODE = 120;
    [Token(Token = "0x400C9AB")]
    private const int INPUT_RUNE_STATUS_CONFIRM = 130;
    [Token(Token = "0x400C9AC")]
    private const int OUTPUT_RUNE_STATUS_CONFIRM = 131;
    [Token(Token = "0x400C9AD")]
    private const int INPUT_COST_CHANGE = 141;
    [Token(Token = "0x400C9AE")]
    private const int OUTPUT_CLOSE_WINDOW = 1000;
    [Token(Token = "0x400C9AF")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mRuneGameObject;
    [Token(Token = "0x400C9B0")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private RuneDrawInfo mRuneDrawInfo;
    [Token(Token = "0x400C9B1")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private RuneIcon mRuneIconBefore;
    [Token(Token = "0x400C9B2")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RuneIcon mRuneIconAfter;
    [Token(Token = "0x400C9B3")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private RuneDrawBaseState mRuneDrawBaseState;
    [Token(Token = "0x400C9B4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RuneDrawEvoState mRuneDrawEvoState;
    [Token(Token = "0x400C9B5")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private RuneDrawCost mRuneDrawCost;
    [Token(Token = "0x400C9B6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject mRuneSet1;
    [Token(Token = "0x400C9B7")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject mRuneSet2;
    [Token(Token = "0x400C9B8")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject mDescriptionEvo;
    [Token(Token = "0x400C9B9")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject mDescriptionEnhance;
    [Token(Token = "0x400C9BA")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject mBulkState;
    [Token(Token = "0x400C9BB")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private RuneIcon mRuneIcon;
    [Token(Token = "0x400C9BC")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private RuneDrawBaseState mRuneDrawBeforeBaseState;
    [Token(Token = "0x400C9BD")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private RuneDrawBaseState mRuneDrawAfterBaseState;
    [Token(Token = "0x400C9BE")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private RuneDrawEnhanceLevel mRuneDrawEnhanceLevel;
    [Token(Token = "0x400C9BF")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private RuneContinueReinforcement mRuneContinueReinforcement;
    [Token(Token = "0x400C9C0")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private RuneDrawCostEx mRuneDrawCostEx;
    [Token(Token = "0x400C9C1")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private Button mEvoButton;
    [Token(Token = "0x400C9C2")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Button mBulkEnhanceButton;
    [Token(Token = "0x400C9C3")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private GameObject mNormalEnhanceModeUI;
    [Token(Token = "0x400C9C4")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject mContinueEnhanceModeUI;
    [Token(Token = "0x400C9C5")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private ImageArray mSwitchEvoModeImage;
    [Token(Token = "0x400C9C6")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private SerializeValueBehaviour mSVB;
    [Token(Token = "0x400C9C7")]
    [FieldOffset(Offset = "0x6C")]
    private RuneManager mRuneManager;
    [Token(Token = "0x400C9C8")]
    [FieldOffset(Offset = "0x70")]
    private BindRuneData mRuneData;
    [Token(Token = "0x400C9C9")]
    [FieldOffset(Offset = "0x74")]
    private BindRuneData mBeforeRune;
    [Token(Token = "0x400C9CA")]
    [FieldOffset(Offset = "0x78")]
    private bool mIsNormalEvo;

    [Token(Token = "0x600BD03")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public void Awake()
    {
    }

    [Token(Token = "0x600BD04")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600BD05")]
    [Address(RVA = "0x84ADD0", Offset = "0x849BD0", VA = "0x1084ADD0")]
    private void SetSerializeValueBehaviour()
    {
    }

    [Token(Token = "0x600BD06")]
    [Address(RVA = "0x84A0E0", Offset = "0x848EE0", VA = "0x1084A0E0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600BD07")]
    [Address(RVA = "0x84AC60", Offset = "0x849A60", VA = "0x1084AC60")]
    public void ReturnBulkEnhance()
    {
    }

    [Token(Token = "0x600BD08")]
    [Address(RVA = "0x84AF90", Offset = "0x849D90", VA = "0x1084AF90")]
    public void Setup(RuneManager manager, BindRuneData rune_data, bool is_reset = false)
    {
    }

    [Token(Token = "0x600BD09")]
    [Address(RVA = "0x84A4F0", Offset = "0x8492F0", VA = "0x1084A4F0")]
    public void CostChange()
    {
    }

    [Token(Token = "0x600BD0A")]
    [Address(RVA = "0x84A890", Offset = "0x849690", VA = "0x1084A890")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600BD0B")]
    [Address(RVA = "0x84A7B0", Offset = "0x8495B0", VA = "0x1084A7B0")]
    public void RefreshButton()
    {
    }

    [Token(Token = "0x600BD0C")]
    [Address(RVA = "0x84A3D0", Offset = "0x8491D0", VA = "0x1084A3D0")]
    public void ConfirmEvolution()
    {
    }

    [Token(Token = "0x600BD0D")]
    [Address(RVA = "0x84A360", Offset = "0x849160", VA = "0x1084A360")]
    public void BulkConfirmEvo()
    {
    }

    [Token(Token = "0x600BD0E")]
    [Address(RVA = "0x84B460", Offset = "0x84A260", VA = "0x1084B460")]
    public void SwitchEnhanceMode()
    {
    }

    [Token(Token = "0x600BD0F")]
    [Address(RVA = "0x84B6C0", Offset = "0x84A4C0", VA = "0x1084B6C0")]
    public RuneEvoWindow()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.BondResetWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20020C8")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "返却素材情報設定", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(101, "ボタンの有効化", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "返却素材一覧表示へ", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(110, "ホームに戻すべきエラー", FlowNode.PinTypes.Output, 110)]
  [AddComponentMenu("UI/Bond/BondResetWindow")]
  public class BondResetWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008D80")]
    private const int PIN_INPUT_INIT_BUTTON = 1;
    [Token(Token = "0x4008D81")]
    private const int PIN_INPUT_RETURN_DECIDE = 2;
    [Token(Token = "0x4008D82")]
    private const int PIN_OUTPUT_INIT_BUTTON_FINISH = 101;
    [Token(Token = "0x4008D83")]
    private const int PIN_OUTPUT_RETURN_FINISH = 102;
    [Token(Token = "0x4008D84")]
    private const int PIN_OUTPUT_ERROR_GO_HOME = 110;
    [Token(Token = "0x4008D85")]
    private const string SVB_NAME_RESET_ICON = "reward_icon";
    [Token(Token = "0x4008D86")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    [HeaderBar("▼リセット確認")]
    private GameObject mConfirmRoot;
    [Token(Token = "0x4008D87")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mItemIconObj;
    [Token(Token = "0x4008D88")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mItemCountRoot;
    [Token(Token = "0x4008D89")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mItemPosses;
    [Token(Token = "0x4008D8A")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mItemTotal;
    [Token(Token = "0x4008D8B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text mResetConfirmText;
    [Token(Token = "0x4008D8C")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mItemShortageRoot;
    [Token(Token = "0x4008D8D")]
    [FieldOffset(Offset = "0x28")]
    [HeaderBar("▼リセット実行しました")]
    [SerializeField]
    private GameObject mResetExeRoot;
    [Token(Token = "0x4008D8E")]
    [FieldOffset(Offset = "0x2C")]
    [HeaderBar("▼リセット返却素材結果")]
    [SerializeField]
    private GameObject mResetResultRoot;
    [Token(Token = "0x4008D8F")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Transform mContentRoot;
    [Token(Token = "0x4008D90")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private RewardIcon mContentTemplate;
    [Token(Token = "0x4008D91")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text mResetDialogText;
    [Token(Token = "0x4008D92")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private int mDigits;

    [Token(Token = "0x600889F")]
    [Address(RVA = "0x49D2C0", Offset = "0x49C0C0", VA = "0x1049D2C0")]
    private void Awake()
    {
    }

    [Token(Token = "0x60088A0")]
    [Address(RVA = "0x49D290", Offset = "0x49C090", VA = "0x1049D290", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60088A1")]
    [Address(RVA = "0x49D340", Offset = "0x49C140", VA = "0x1049D340")]
    private void Initialized()
    {
    }

    [Token(Token = "0x60088A2")]
    [Address(RVA = "0x49D7D0", Offset = "0x49C5D0", VA = "0x1049D7D0")]
    private void ReturnItemSet()
    {
    }

    [Token(Token = "0x60088A3")]
    [Address(RVA = "0x495600", Offset = "0x494400", VA = "0x10495600")]
    private void SetError()
    {
    }

    [Token(Token = "0x60088A4")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public BondResetWindow()
    {
    }
  }
}

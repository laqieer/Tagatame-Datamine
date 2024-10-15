// Decompiled with JetBrains decompiler
// Type: SRPG.BondGroupReinforcementWindow
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
  [Token(Token = "0x20020B1")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(101, "いずれかの欠片を変換", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "レベルアップへ遷移", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(110, "ホームに戻すべきエラー", FlowNode.PinTypes.Output, 110)]
  [AddComponentMenu("UI/Bond/BondGroupReinforcementWindow")]
  public class BondGroupReinforcementWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008CE9")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x4008CEA")]
    private const int PIN_OUTPUT_CONVERT_PIECE = 101;
    [Token(Token = "0x4008CEB")]
    private const int PIN_OUTPUT_GOTO_LEVELUP = 102;
    [Token(Token = "0x4008CEC")]
    private const int PIN_OUTPUT_ERROR_GO_HOME = 110;
    [Token(Token = "0x4008CED")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform mContentRoot;
    [Token(Token = "0x4008CEE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private SerializeValueBehaviour mContentTemplate;
    [Token(Token = "0x4008CEF")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mRequireGoldTxt;
    [Token(Token = "0x4008CF0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mRequireItemTxt;
    [Token(Token = "0x4008CF1")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mHaveItemTxt;
    [Token(Token = "0x4008CF2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mMaterialShortage;
    [Token(Token = "0x4008CF3")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private SRPG_Button mLevelUpBtn;
    [Token(Token = "0x4008CF4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject mItemIconObj;
    [Token(Token = "0x4008CF5")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private int mDigits;
    [Token(Token = "0x4008CF6")]
    private const string SVB_NAME_REWARD_ICON = "reward_icon";
    [Token(Token = "0x4008CF7")]
    private const string SVB_NAME_HAVE_COUNT_TXT = "have_count";
    [Token(Token = "0x4008CF8")]
    private const string SVB_NAME_NEED_COUNT_TXT = "need_count";
    [Token(Token = "0x4008CF9")]
    [FieldOffset(Offset = "0x30")]
    private bool mIsSufficientPiece;
    [Token(Token = "0x4008CFA")]
    [FieldOffset(Offset = "0x31")]
    private bool mConvertFactor;
    [Token(Token = "0x4008CFB")]
    [FieldOffset(Offset = "0x34")]
    public List<BondPieceMatsParam> mCurrentPieces;
    [Token(Token = "0x4008CFC")]
    [FieldOffset(Offset = "0x0")]
    private static BondGroupReinforcementWindow mInstance;

    [Token(Token = "0x17001337")]
    public static BondGroupReinforcementWindow Instance
    {
      [Token(Token = "0x6008811"), Address(RVA = "0x495680", Offset = "0x494480", VA = "0x10495680")] get
      {
        return (BondGroupReinforcementWindow) null;
      }
    }

    [Token(Token = "0x6008812")]
    [Address(RVA = "0x494D80", Offset = "0x493B80", VA = "0x10494D80")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008813")]
    [Address(RVA = "0x4955C0", Offset = "0x4943C0", VA = "0x104955C0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6008814")]
    [Address(RVA = "0x495620", Offset = "0x494420", VA = "0x10495620")]
    private void Start()
    {
    }

    [Token(Token = "0x6008815")]
    [Address(RVA = "0x494D60", Offset = "0x493B60", VA = "0x10494D60", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008816")]
    [Address(RVA = "0x494DC0", Offset = "0x493BC0", VA = "0x10494DC0")]
    private void Initialized()
    {
    }

    [Token(Token = "0x6008817")]
    [Address(RVA = "0x495590", Offset = "0x494390", VA = "0x10495590")]
    public void OnClickBranchYesBtn()
    {
    }

    [Token(Token = "0x6008818")]
    [Address(RVA = "0x495600", Offset = "0x494400", VA = "0x10495600")]
    private void SetError()
    {
    }

    [Token(Token = "0x6008819")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public BondGroupReinforcementWindow()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.BondGroupDetail
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
  [Token(Token = "0x20020AB")]
  [FlowNode.Pin(11, "LVUP演出開始", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(12, "LVUP演出中操作受付", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(102, "該当メンバー", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(103, "グループ切り替え", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(111, "LVUP演出開始後処理", FlowNode.PinTypes.Output, 111)]
  [AddComponentMenu("UI/Bond/BondGroupDetail")]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "表示更新", FlowNode.PinTypes.Input, 2)]
  public class BondGroupDetail : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008CAB")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x4008CAC")]
    private const int PIN_INPUT_REFRESH = 2;
    [Token(Token = "0x4008CAD")]
    private const int PIN_INPUT_LEVEL_UP_START = 11;
    [Token(Token = "0x4008CAE")]
    private const int PIN_INPUT_NEXT = 12;
    [Token(Token = "0x4008CAF")]
    private const int PIN_OUTPUT_APPLICABLE_MEMBER = 102;
    [Token(Token = "0x4008CB0")]
    private const int PIN_OUTPUT_CYCLE_GROUP = 103;
    [Token(Token = "0x4008CB1")]
    private const int PIN_OUTPUT_LEVEL_UP_START = 111;
    [Token(Token = "0x4008CB2")]
    [FieldOffset(Offset = "0xC")]
    private readonly string EVENT_NAME_NEXT;
    [Token(Token = "0x4008CB3")]
    private const string SVB_NAME_IS_CLEAR_OBJ = "is_clear_obj";
    [Token(Token = "0x4008CB4")]
    private const string SVB_NAME_BUFF_NAME = "buff_name";
    [Token(Token = "0x4008CB5")]
    private const string SVB_NAME_BUFF_LEVEL = "buff_level";
    [Token(Token = "0x4008CB6")]
    private const string SVB_NAME_BUFF_EXPLAIN = "buff_explain";
    [Token(Token = "0x4008CB7")]
    private const string SVB_NAME_COMINGSOON = "null_obj";
    [Token(Token = "0x4008CB8")]
    private const string SVB_NEED_ITEM_ICON = "reward_icon";
    [Token(Token = "0x4008CB9")]
    private const string SVB_NEED_ITEM_NUM = "items_need";
    [Token(Token = "0x4008CBA")]
    private const string SVB_NEED_ITEM_MAX = "items_haveMax";
    [Token(Token = "0x4008CBB")]
    private const string SVB_BUTTON_INDEX = "button_index";
    [Token(Token = "0x4008CBC")]
    [FieldOffset(Offset = "0x10")]
    [HeaderBar("▼グループ画像・グループ名・習得バフ名")]
    [SerializeField]
    private RawImage mGroupImg;
    [Token(Token = "0x4008CBD")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mGroupBonusTxt;
    [Token(Token = "0x4008CBE")]
    [FieldOffset(Offset = "0x18")]
    [HeaderBar("▼グループバフのリスト")]
    [SerializeField]
    private Transform mBuffRoot;
    [Token(Token = "0x4008CBF")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private SerializeValueBehaviour mBuffTemplate;
    [Token(Token = "0x4008CC0")]
    [FieldOffset(Offset = "0x20")]
    [HeaderBar("▼必要アイテムのリスト")]
    [SerializeField]
    private ContentScroller mContentScroller;
    [Token(Token = "0x4008CC1")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Transform mItemRoot;
    [Token(Token = "0x4008CC2")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private SerializeValueBehaviour mItemTemplate;
    [Token(Token = "0x4008CC3")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject mCompleteMessage;
    [Token(Token = "0x4008CC4")]
    [FieldOffset(Offset = "0x30")]
    [HeaderBar("▼強化・リセットボタン")]
    [SerializeField]
    private SRPG_Button mLevelUpBtn;
    [Token(Token = "0x4008CC5")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject mLevelUpBtnEffect;
    [Token(Token = "0x4008CC6")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private SRPG_Button mResetBtn;
    [Token(Token = "0x4008CC7")]
    [FieldOffset(Offset = "0x3C")]
    [HeaderBar("▼グループページ送りボタン")]
    [SerializeField]
    private SRPG_Button mRCycleGroupBtn;
    [Token(Token = "0x4008CC8")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private SRPG_Button mLCycleGroupBtn;
    [Token(Token = "0x4008CC9")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    [HeaderBar("▼絆強化時のアニメーター")]
    private Animator mAnimator;
    [Token(Token = "0x4008CCA")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    [HeaderBar("▼絆強化時のアビリティアイコン・効果名")]
    private GameObject mLearnedBuffIcon;
    [Token(Token = "0x4008CCB")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private Text mLearnedBuffTxt;
    [Token(Token = "0x4008CCC")]
    [FieldOffset(Offset = "0x50")]
    [HeaderBar("▼絆強化用アイテム・必要GOLD")]
    [SerializeField]
    private GameObject mNeedItemColumun;
    [Token(Token = "0x4008CCD")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private Text mNeedGoldTxt;
    [Token(Token = "0x4008CCE")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text mNeedItemTxt;
    [Token(Token = "0x4008CCF")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private Text mHaveItemTxt;
    [Token(Token = "0x4008CD0")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject mItemIconObj;
    [Token(Token = "0x4008CD1")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private int mDigits;
    [Token(Token = "0x4008CD2")]
    [FieldOffset(Offset = "0x68")]
    private BondGroupParam mBondGroupParam;
    [Token(Token = "0x4008CD3")]
    [FieldOffset(Offset = "0x6C")]
    private BondGroupBuffParam mBondGroupBuffParam;
    [Token(Token = "0x4008CD4")]
    [FieldOffset(Offset = "0x70")]
    private List<SerializeValueBehaviour> mItemListContents;
    [Token(Token = "0x4008CD5")]
    [FieldOffset(Offset = "0x74")]
    private List<GameObject> mBuffListContents;
    [Token(Token = "0x4008CD6")]
    [FieldOffset(Offset = "0x78")]
    private SRPG.StateMachine<BondGroupDetail> StateMachine;
    [Token(Token = "0x4008CD7")]
    [FieldOffset(Offset = "0x7C")]
    private bool mIsSkippedAnimator;
    [Token(Token = "0x4008CD8")]
    [FieldOffset(Offset = "0x0")]
    private static BondGroupDetail mInstance;

    [Token(Token = "0x17001332")]
    public static BondGroupDetail Instance
    {
      [Token(Token = "0x60087EC"), Address(RVA = "0x494820", Offset = "0x493620", VA = "0x10494820")] get
      {
        return (BondGroupDetail) null;
      }
    }

    [Token(Token = "0x60087ED")]
    [Address(RVA = "0x493120", Offset = "0x491F20", VA = "0x10493120")]
    private void Awake()
    {
    }

    [Token(Token = "0x60087EE")]
    [Address(RVA = "0x494340", Offset = "0x493140", VA = "0x10494340")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60087EF")]
    [Address(RVA = "0x4946F0", Offset = "0x4934F0", VA = "0x104946F0")]
    private void Start()
    {
    }

    [Token(Token = "0x60087F0")]
    [Address(RVA = "0x494790", Offset = "0x493590", VA = "0x10494790")]
    private void Update()
    {
    }

    [Token(Token = "0x60087F1")]
    [Address(RVA = "0x493080", Offset = "0x491E80", VA = "0x10493080", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60087F2")]
    [Address(RVA = "0x493EF0", Offset = "0x492CF0", VA = "0x10493EF0")]
    private void Initialized()
    {
    }

    [Token(Token = "0x60087F3")]
    [Address(RVA = "0x494380", Offset = "0x493180", VA = "0x10494380")]
    private IEnumerator RefreshBGImage() => (IEnumerator) null;

    [Token(Token = "0x60087F4")]
    [Address(RVA = "0x493160", Offset = "0x491F60", VA = "0x10493160")]
    private void CreateContent()
    {
    }

    [Token(Token = "0x60087F5")]
    [Address(RVA = "0x4943F0", Offset = "0x4931F0", VA = "0x104943F0")]
    private void SetCycleGroupBtnIntaractable()
    {
    }

    [Token(Token = "0x60087F6")]
    [Address(RVA = "0x494540", Offset = "0x493340", VA = "0x10494540")]
    private void SetLevelUpAnim()
    {
    }

    [Token(Token = "0x60087F7")]
    [Address(RVA = "0x494170", Offset = "0x492F70", VA = "0x10494170")]
    public void OnClickApplicableMember(GameObject go)
    {
    }

    [Token(Token = "0x60087F8")]
    [Address(RVA = "0x494200", Offset = "0x493000", VA = "0x10494200")]
    public void OnClickCycleGroup(bool isForward)
    {
    }

    [Token(Token = "0x60087F9")]
    [Address(RVA = "0x4947D0", Offset = "0x4935D0", VA = "0x104947D0")]
    public BondGroupDetail()
    {
    }

    [Token(Token = "0x20020AC")]
    private class State_Idle : State<BondGroupDetail>
    {
      [Token(Token = "0x60087FB")]
      [Address(RVA = "0x4A1530", Offset = "0x4A0330", VA = "0x104A1530")]
      public State_Idle()
      {
      }
    }

    [Token(Token = "0x20020AD")]
    private class State_BondLevelUp : State<BondGroupDetail>
    {
      [Token(Token = "0x60087FC")]
      [Address(RVA = "0x4A11A0", Offset = "0x49FFA0", VA = "0x104A11A0", Slot = "4")]
      public override void Begin(BondGroupDetail self)
      {
      }

      [Token(Token = "0x60087FD")]
      [Address(RVA = "0x4A1400", Offset = "0x4A0200", VA = "0x104A1400", Slot = "5")]
      public override void Update(BondGroupDetail self)
      {
      }

      [Token(Token = "0x60087FE")]
      [Address(RVA = "0x4A1300", Offset = "0x4A0100", VA = "0x104A1300", Slot = "7")]
      public override void Command(BondGroupDetail self, string cmd)
      {
      }

      [Token(Token = "0x60087FF")]
      [Address(RVA = "0x4A14F0", Offset = "0x4A02F0", VA = "0x104A14F0")]
      public State_BondLevelUp()
      {
      }
    }
  }
}

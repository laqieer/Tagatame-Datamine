// Decompiled with JetBrains decompiler
// Type: SRPG.DuelResultWindow
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
  [Token(Token = "0x2002330")]
  [FlowNode.Pin(30, "ランクアップ演出", FlowNode.PinTypes.Input, 30)]
  [FlowNode.Pin(10, "初期化", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(11, "演出を進める", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(20, "ポイント内訳表示", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(40, "報酬表示", FlowNode.PinTypes.Input, 40)]
  [FlowNode.Pin(100, "初期化完了", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(110, "ポイント内訳表示完了", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(120, "ランクアップ演出完了", FlowNode.PinTypes.Output, 120)]
  [FlowNode.Pin(130, "報酬表示完了", FlowNode.PinTypes.Output, 130)]
  [AddComponentMenu("UI/Duel/DuelResultWindow")]
  public class DuelResultWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009D58")]
    private const int PIN_INPUT_INIT = 10;
    [Token(Token = "0x4009D59")]
    private const int PIN_INPUT_NEXT = 11;
    [Token(Token = "0x4009D5A")]
    private const int PIN_INPUT_DISPLAY_POINT_START = 20;
    [Token(Token = "0x4009D5B")]
    private const int PIN_INPUT_RANKUP_START = 30;
    [Token(Token = "0x4009D5C")]
    private const int PIN_INPUT_REWARD_START = 40;
    [Token(Token = "0x4009D5D")]
    private const int PIN_OUTPUT_INIT_FINISH = 100;
    [Token(Token = "0x4009D5E")]
    private const int PIN_OUTPUT_DISPLAY_POINT_END = 110;
    [Token(Token = "0x4009D5F")]
    private const int PIN_OUTPUT_RANKUP_END = 120;
    [Token(Token = "0x4009D60")]
    private const int PIN_OUTPUT_REWARD_END = 130;
    [Token(Token = "0x4009D61")]
    [FieldOffset(Offset = "0xC")]
    private readonly string EVENT_NAME_NEXT;
    [Token(Token = "0x4009D62")]
    [FieldOffset(Offset = "0x10")]
    private readonly string DUEL_SVB_KEY_UNIT_EMPTY;
    [Token(Token = "0x4009D63")]
    [FieldOffset(Offset = "0x14")]
    private readonly string ANIM_PARAM_POINT_NONE;
    [Token(Token = "0x4009D64")]
    [FieldOffset(Offset = "0x18")]
    private readonly string ANIM_PARAM_POINT_ALL;
    [Token(Token = "0x4009D65")]
    [FieldOffset(Offset = "0x1C")]
    private readonly string ANIM_PARAM_POINT_UNITBONUS;
    [Token(Token = "0x4009D66")]
    [FieldOffset(Offset = "0x20")]
    private readonly string ANIM_PARAM_POINT_CHAIN;
    [Token(Token = "0x4009D67")]
    [FieldOffset(Offset = "0x24")]
    private readonly string ANIM_PARAM_RANK_UP;
    [Token(Token = "0x4009D68")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    [HeaderBar("▼ユニット")]
    private GameObject mUnitImageTemplate;
    [Token(Token = "0x4009D69")]
    [FieldOffset(Offset = "0x2C")]
    [HeaderBar("▼ランキング")]
    [SerializeField]
    private GameObject mRankRoot;
    [Token(Token = "0x4009D6A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject mRankTitleRoot;
    [Token(Token = "0x4009D6B")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Text mRanking;
    [Token(Token = "0x4009D6C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text mRankingUp;
    [Token(Token = "0x4009D6D")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject mRankingUpEffect;
    [Token(Token = "0x4009D6E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    [StringIsResourcePath(typeof (GameObject))]
    [HeaderBar("▼報酬")]
    private string REWARD_ICON_PREFAB_PATH;
    [Token(Token = "0x4009D6F")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private GameObject mRewardParentTemplate;
    [Token(Token = "0x4009D70")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Transform mMISC;
    [Token(Token = "0x4009D71")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    [HeaderBar("▼勝敗結果")]
    private GameObject mResultWin;
    [Token(Token = "0x4009D72")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject mResultLose;
    [Token(Token = "0x4009D73")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    [HeaderBar("▼連勝数")]
    private GameObject mChainWinRoot;
    [Token(Token = "0x4009D74")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text mChainWinText;
    [Token(Token = "0x4009D75")]
    [FieldOffset(Offset = "0x5C")]
    [HeaderBar("▼通算勝利数")]
    [SerializeField]
    private GameObject mTotalWinRoot;
    [Token(Token = "0x4009D76")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text mTotalWinText;
    [Token(Token = "0x4009D77")]
    [FieldOffset(Offset = "0x64")]
    [HeaderBar("▼スコア内訳")]
    [SerializeField]
    private Text mPoint_Base;
    [Token(Token = "0x4009D78")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private Text mPoint_BonusUnit;
    [Token(Token = "0x4009D79")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private Text mPoint_ChainWin;
    [Token(Token = "0x4009D7A")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text mPoint_RestAct;
    [Token(Token = "0x4009D7B")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    private Text mPoint_EnemyRank;
    [Token(Token = "0x4009D7C")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private Text mPoint_Total;
    [Token(Token = "0x4009D7D")]
    [FieldOffset(Offset = "0x7C")]
    [SerializeField]
    [HeaderBar("▼アニメータ")]
    private Animator mAnimator;
    [Token(Token = "0x4009D7E")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private Animator mRankupValueAnimator;
    [Token(Token = "0x4009D7F")]
    [FieldOffset(Offset = "0x84")]
    [SerializeField]
    [HeaderBar("▼演出パラメータ")]
    private float RANKUP_TIME;
    [Token(Token = "0x4009D80")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private float RANKUP_TEXT_DELAY;
    [Token(Token = "0x4009D81")]
    [FieldOffset(Offset = "0x8C")]
    [SerializeField]
    private float RANKUP_EFFECT_DELAY;
    [Token(Token = "0x4009D82")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private float REWARD_ICON_DISP_DELAY;
    [Token(Token = "0x4009D83")]
    [FieldOffset(Offset = "0x94")]
    [SerializeField]
    private float CLOSE_BTN_DISP_DELAY;
    [Token(Token = "0x4009D84")]
    [FieldOffset(Offset = "0x98")]
    [HeaderBar("▼その他")]
    [SerializeField]
    private GameObject mCloseButton;
    [Token(Token = "0x4009D85")]
    [FieldOffset(Offset = "0x0")]
    private static DuelBattleResultData DuelResultData;
    [Token(Token = "0x4009D86")]
    [FieldOffset(Offset = "0x4")]
    private static DuelResultWindow.ServerSyncTrophyExec mServerSyncTrophyExec;
    [Token(Token = "0x4009D87")]
    [FieldOffset(Offset = "0x9C")]
    private SRPG.StateMachine<DuelResultWindow> StateMachine;
    [Token(Token = "0x4009D88")]
    [FieldOffset(Offset = "0xA0")]
    private DuelRewardIconTemplate mRewardIconTemplate;
    [Token(Token = "0x4009D89")]
    [FieldOffset(Offset = "0xA4")]
    private List<GameObject> mCreatedRewardIcons;

    [Token(Token = "0x6009772")]
    [Address(RVA = "0x5A0910", Offset = "0x59F710", VA = "0x105A0910")]
    public static void Setup(
      JSON_DuelBattleResultData result,
      JSON_DuelRewardDetailData reward_detail,
      bool is_win,
      DuelResultWindow.ServerSyncTrophyExec _serverSyncTrophyExec)
    {
    }

    [Token(Token = "0x6009773")]
    [Address(RVA = "0x5A09D0", Offset = "0x59F7D0", VA = "0x105A09D0")]
    private void Update()
    {
    }

    [Token(Token = "0x6009774")]
    [Address(RVA = "0x59FF50", Offset = "0x59ED50", VA = "0x1059FF50")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6009775")]
    [Address(RVA = "0x59F410", Offset = "0x59E210", VA = "0x1059F410", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009776")]
    [Address(RVA = "0x59FBF0", Offset = "0x59E9F0", VA = "0x1059FBF0")]
    private void Init()
    {
    }

    [Token(Token = "0x6009777")]
    [Address(RVA = "0x5A0A10", Offset = "0x59F810", VA = "0x105A0A10")]
    private IEnumerator WaitForOpenAnimation() => (IEnumerator) null;

    [Token(Token = "0x6009778")]
    [Address(RVA = "0x59FEF0", Offset = "0x59ECF0", VA = "0x1059FEF0")]
    private bool IsEndCurrentAnim() => new bool();

    [Token(Token = "0x6009779")]
    [Address(RVA = "0x59FFB0", Offset = "0x59EDB0", VA = "0x1059FFB0")]
    private void SetBattleResult()
    {
    }

    [Token(Token = "0x600977A")]
    [Address(RVA = "0x59F9A0", Offset = "0x59E7A0", VA = "0x1059F9A0")]
    private void CreateUnitImage()
    {
    }

    [Token(Token = "0x600977B")]
    [Address(RVA = "0x59F5B0", Offset = "0x59E3B0", VA = "0x1059F5B0")]
    private void CreateRewardIcon()
    {
    }

    [Token(Token = "0x600977C")]
    [Address(RVA = "0x5A0A80", Offset = "0x59F880", VA = "0x105A0A80")]
    private GameObject __CreateRewardIcon(
      JSON_DuelRewardData reward,
      DuelRewardIconTemplate template,
      bool is_bonus_reward,
      DUEL_WIN_BONUS_TYPE type = DUEL_WIN_BONUS_TYPE.ChainWin)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x600977D")]
    [Address(RVA = "0x5A0050", Offset = "0x59EE50", VA = "0x105A0050")]
    private void SetChainWin()
    {
    }

    [Token(Token = "0x600977E")]
    [Address(RVA = "0x5A0760", Offset = "0x59F560", VA = "0x105A0760")]
    private void SetTotalWin()
    {
    }

    [Token(Token = "0x600977F")]
    [Address(RVA = "0x5A0230", Offset = "0x59F030", VA = "0x105A0230")]
    private void SetPoint()
    {
    }

    [Token(Token = "0x6009780")]
    [Address(RVA = "0x5A0180", Offset = "0x59EF80", VA = "0x105A0180")]
    private void SetPointAnimation()
    {
    }

    [Token(Token = "0x6009781")]
    [Address(RVA = "0x5A0500", Offset = "0x59F300", VA = "0x105A0500")]
    private void SetRank()
    {
    }

    [Token(Token = "0x6009782")]
    [Address(RVA = "0x5A0C00", Offset = "0x59FA00", VA = "0x105A0C00")]
    public DuelResultWindow()
    {
    }

    [Token(Token = "0x2002331")]
    public delegate void ServerSyncTrophyExec();

    [Token(Token = "0x2002332")]
    private class State_Idle : State<DuelResultWindow>
    {
      [Token(Token = "0x6009787")]
      [Address(RVA = "0x5A4410", Offset = "0x5A3210", VA = "0x105A4410")]
      public State_Idle()
      {
      }
    }

    [Token(Token = "0x2002333")]
    private class State_DisplayPoint : State<DuelResultWindow>
    {
      [Token(Token = "0x6009788")]
      [Address(RVA = "0x5A4150", Offset = "0x5A2F50", VA = "0x105A4150", Slot = "7")]
      public override void Command(DuelResultWindow self, string cmd)
      {
      }

      [Token(Token = "0x6009789")]
      [Address(RVA = "0x5A4300", Offset = "0x5A3100", VA = "0x105A4300")]
      private void Skip()
      {
      }

      [Token(Token = "0x600978A")]
      [Address(RVA = "0x5A43D0", Offset = "0x5A31D0", VA = "0x105A43D0")]
      public State_DisplayPoint()
      {
      }
    }

    [Token(Token = "0x2002334")]
    private class State_Rankup : State<DuelResultWindow>
    {
      [Token(Token = "0x4009D8A")]
      [FieldOffset(Offset = "0xC")]
      private float disp_rank;
      [Token(Token = "0x4009D8B")]
      [FieldOffset(Offset = "0x10")]
      private float elapsed_time;
      [Token(Token = "0x4009D8C")]
      [FieldOffset(Offset = "0x14")]
      private float delay_time_rankup_txt;
      [Token(Token = "0x4009D8D")]
      [FieldOffset(Offset = "0x18")]
      private float delay_time_rankup_eff;
      [Token(Token = "0x4009D8E")]
      [FieldOffset(Offset = "0x1C")]
      private bool is_rankup;

      [Token(Token = "0x600978B")]
      [Address(RVA = "0x5A4450", Offset = "0x5A3250", VA = "0x105A4450", Slot = "4")]
      public override void Begin(DuelResultWindow self)
      {
      }

      [Token(Token = "0x600978C")]
      [Address(RVA = "0x5A4B60", Offset = "0x5A3960", VA = "0x105A4B60", Slot = "5")]
      public override void Update(DuelResultWindow self)
      {
      }

      [Token(Token = "0x600978D")]
      [Address(RVA = "0x5A45F0", Offset = "0x5A33F0", VA = "0x105A45F0", Slot = "7")]
      public override void Command(DuelResultWindow self, string cmd)
      {
      }

      [Token(Token = "0x600978E")]
      [Address(RVA = "0x5A4980", Offset = "0x5A3780", VA = "0x105A4980")]
      private void Skip()
      {
      }

      [Token(Token = "0x600978F")]
      [Address(RVA = "0x5A4850", Offset = "0x5A3650", VA = "0x105A4850")]
      private void RefreshText()
      {
      }

      [Token(Token = "0x6009790")]
      [Address(RVA = "0x5A4760", Offset = "0x5A3560", VA = "0x105A4760")]
      private bool IsCanSkip() => new bool();

      [Token(Token = "0x6009791")]
      [Address(RVA = "0x5A4E00", Offset = "0x5A3C00", VA = "0x105A4E00")]
      public State_Rankup()
      {
      }
    }

    [Token(Token = "0x2002335")]
    private class State_Reward : State<DuelResultWindow>
    {
      [Token(Token = "0x4009D8F")]
      [FieldOffset(Offset = "0xC")]
      private float delay_time_close;
      [Token(Token = "0x4009D90")]
      [FieldOffset(Offset = "0x10")]
      private float delay_time_icon;
      [Token(Token = "0x4009D91")]
      [FieldOffset(Offset = "0x14")]
      private int disp_cnt;

      [Token(Token = "0x6009792")]
      [Address(RVA = "0x5A50D0", Offset = "0x5A3ED0", VA = "0x105A50D0", Slot = "5")]
      public override void Update(DuelResultWindow self)
      {
      }

      [Token(Token = "0x6009793")]
      [Address(RVA = "0x5A4E40", Offset = "0x5A3C40", VA = "0x105A4E40", Slot = "7")]
      public override void Command(DuelResultWindow self, string cmd)
      {
      }

      [Token(Token = "0x6009794")]
      [Address(RVA = "0x5A5000", Offset = "0x5A3E00", VA = "0x105A5000")]
      private void Skip()
      {
      }

      [Token(Token = "0x6009795")]
      [Address(RVA = "0x5A5200", Offset = "0x5A4000", VA = "0x105A5200")]
      public State_Reward()
      {
      }
    }
  }
}

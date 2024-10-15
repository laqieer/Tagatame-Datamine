// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestResultWindow
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
  [Token(Token = "0x200283A")]
  [FlowNode.Pin(1, "演出開始", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "演出スキップ", FlowNode.PinTypes.Input, 2)]
  public class PointQuestResultWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400BFD8")]
    private const int PIN_INPUT_INIT_ANIM_END = 1;
    [Token(Token = "0x400BFD9")]
    private const int PIN_INPUT_ANIM_SKIP = 2;
    [Token(Token = "0x400BFDA")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    [HeaderBar("▼キャラクターイメージ")]
    private GameObject CharacterImage;
    [Token(Token = "0x400BFDB")]
    [FieldOffset(Offset = "0x10")]
    [HeaderBar("▼ポイントリスト")]
    [SerializeField]
    private GameObject DetailListParent;
    [Token(Token = "0x400BFDC")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private PointQuestResultListItem DetailListItem;
    [Token(Token = "0x400BFDD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private PointQuestResultSubListItem SubListItem;
    [Token(Token = "0x400BFDE")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private ScrollRect DetailScrollRect;
    [Token(Token = "0x400BFDF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private RectTransform RTPointList;
    [Token(Token = "0x400BFE0")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private ScrollRectSound SRSound;
    [Token(Token = "0x400BFE1")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private int AddDefaultParcent;
    [Token(Token = "0x400BFE2")]
    [FieldOffset(Offset = "0x2C")]
    [HeaderBar("▼結果ポイント表示")]
    [SerializeField]
    private GameObject QuestPointObj;
    [Token(Token = "0x400BFE3")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject QuestHighScoreBadge;
    [Token(Token = "0x400BFE4")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Text QuestPoint;
    [Token(Token = "0x400BFE5")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text QuestHighScorePoint;
    [Token(Token = "0x400BFE6")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject CumulativePointObj;
    [Token(Token = "0x400BFE7")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject CumulativeHighScoreBadge;
    [Token(Token = "0x400BFE8")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Text CumulativePoint;
    [Token(Token = "0x400BFE9")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text CumulativeHighScorePoint;
    [Token(Token = "0x400BFEA")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private GameObject CumulativeHighScorePointObj;
    [Token(Token = "0x400BFEB")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    [HeaderBar("▼ポイントクエストミッションアニメーションインターバル")]
    private float MissionItemAnimInterval;
    [Token(Token = "0x400BFEC")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    [HeaderBar("▼ポイントクエストカウントアップ時間")]
    private float CountUpTime;
    [Token(Token = "0x400BFED")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    [HeaderBar("▼アニメーション終了判定ステート名")]
    private string PointIntoEndState;
    [Token(Token = "0x400BFEE")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private string HighScoreEndState;
    [Token(Token = "0x400BFEF")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private string CumulativeIntoEndState;
    [Token(Token = "0x400BFF0")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private string CumulativeHighScoreEndState;
    [Token(Token = "0x400BFF1")]
    [FieldOffset(Offset = "0x68")]
    [HeaderBar("▼演出終了時表示ボタン")]
    [SerializeField]
    private GameObject WindowCloseButton;
    [Token(Token = "0x400BFF2")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private GameObject PointQuestMissionWindowButton;
    [Token(Token = "0x400BFF3")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    [HeaderBar("▼演出スキップボタン")]
    private GameObject SkipButton;
    [Token(Token = "0x400BFF4")]
    [FieldOffset(Offset = "0x74")]
    private List<PointQuestResultListItem> mListItem;
    [Token(Token = "0x400BFF5")]
    [FieldOffset(Offset = "0x78")]
    private List<PointQuestResultSubListItem> mSubList;
    [Token(Token = "0x400BFF6")]
    [FieldOffset(Offset = "0x7C")]
    private StateMachine<PointQuestResultWindow> mStateMachine;
    [Token(Token = "0x400BFF7")]
    [FieldOffset(Offset = "0x80")]
    private Json_PointQuestResult mResultData;
    [Token(Token = "0x400BFF8")]
    [FieldOffset(Offset = "0x84")]
    private bool mIsInitDispEnd;
    [Token(Token = "0x400BFF9")]
    [FieldOffset(Offset = "0x85")]
    private bool mIsInitAnimEnd;
    [Token(Token = "0x400BFFA")]
    [FieldOffset(Offset = "0x86")]
    private bool mIsUseSkipTicket;

    [Token(Token = "0x600B591")]
    [Address(RVA = "0x7BF160", Offset = "0x7BDF60", VA = "0x107BF160", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600B592")]
    [Address(RVA = "0x7C0250", Offset = "0x7BF050", VA = "0x107C0250")]
    private void Start()
    {
    }

    [Token(Token = "0x600B593")]
    [Address(RVA = "0x7BFEB0", Offset = "0x7BECB0", VA = "0x107BFEB0")]
    public void SkipSetUp(UnitData _leader_unit, Json_PointQuestResult _result, int _skip_num)
    {
    }

    [Token(Token = "0x600B594")]
    [Address(RVA = "0x7BFD60", Offset = "0x7BEB60", VA = "0x107BFD60")]
    private void InitialSetUp()
    {
    }

    [Token(Token = "0x600B595")]
    [Address(RVA = "0x7BF3A0", Offset = "0x7BE1A0", VA = "0x107BF3A0")]
    private void CreatePointList(BattleCore _core)
    {
    }

    [Token(Token = "0x600B596")]
    [Address(RVA = "0x7BF1D0", Offset = "0x7BDFD0", VA = "0x107BF1D0")]
    private PointQuestResultSubListItem CreateDetailItem(
      string _title_key,
      string _value_text,
      string _unit_key,
      bool _is_interactable)
    {
      return (PointQuestResultSubListItem) null;
    }

    [Token(Token = "0x600B597")]
    [Address(RVA = "0x7BFC10", Offset = "0x7BEA10", VA = "0x107BFC10")]
    private void CreateSubItem(
      PointQuestResultSubListItem _item,
      string _title_key,
      int _value,
      string _unit_key)
    {
    }

    [Token(Token = "0x600B598")]
    [Address(RVA = "0x7BFAB0", Offset = "0x7BE8B0", VA = "0x107BFAB0")]
    private void CreateSkipItem(string _skip_num)
    {
    }

    [Token(Token = "0x600B599")]
    [Address(RVA = "0x7BFE80", Offset = "0x7BEC80", VA = "0x107BFE80")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600B59A")]
    [Address(RVA = "0x7C04E0", Offset = "0x7BF2E0", VA = "0x107C04E0")]
    private void Update()
    {
    }

    [Token(Token = "0x600B59B")]
    [Address(RVA = "0x7C0520", Offset = "0x7BF320", VA = "0x107C0520")]
    public PointQuestResultWindow()
    {
    }

    [Token(Token = "0x200283B")]
    private class State_Idle : State<PointQuestResultWindow>
    {
      [Token(Token = "0x600B59C")]
      [Address(RVA = "0x7CA5E0", Offset = "0x7C93E0", VA = "0x107CA5E0")]
      public State_Idle()
      {
      }
    }

    [Token(Token = "0x200283C")]
    private class State_StartWait : State<PointQuestResultWindow>
    {
      [Token(Token = "0x600B59D")]
      [Address(RVA = "0x7CB7F0", Offset = "0x7CA5F0", VA = "0x107CB7F0", Slot = "4")]
      public override void Begin(PointQuestResultWindow self)
      {
      }

      [Token(Token = "0x600B59E")]
      [Address(RVA = "0x7CB930", Offset = "0x7CA730", VA = "0x107CB930", Slot = "5")]
      public override void Update(PointQuestResultWindow self)
      {
      }

      [Token(Token = "0x600B59F")]
      [Address(RVA = "0x7CB980", Offset = "0x7CA780", VA = "0x107CB980")]
      public State_StartWait()
      {
      }
    }

    [Token(Token = "0x200283D")]
    private class State_MissonAnim : State<PointQuestResultWindow>
    {
      [Token(Token = "0x400BFFB")]
      [FieldOffset(Offset = "0xC")]
      private int now_index;
      [Token(Token = "0x400BFFC")]
      [FieldOffset(Offset = "0x10")]
      private float interval_time;
      [Token(Token = "0x400BFFD")]
      [FieldOffset(Offset = "0x14")]
      private bool is_anim_end;
      [Token(Token = "0x400BFFE")]
      [FieldOffset(Offset = "0x15")]
      private bool is_skip;
      [Token(Token = "0x400BFFF")]
      [FieldOffset(Offset = "0x18")]
      private float list_height;

      [Token(Token = "0x600B5A0")]
      [Address(RVA = "0x7CA620", Offset = "0x7C9420", VA = "0x107CA620", Slot = "4")]
      public override void Begin(PointQuestResultWindow self)
      {
      }

      [Token(Token = "0x600B5A1")]
      [Address(RVA = "0x7CA950", Offset = "0x7C9750", VA = "0x107CA950", Slot = "5")]
      public override void Update(PointQuestResultWindow self)
      {
      }

      [Token(Token = "0x600B5A2")]
      [Address(RVA = "0x7CA700", Offset = "0x7C9500", VA = "0x107CA700", Slot = "7")]
      public override void Command(PointQuestResultWindow self, string cmd)
      {
      }

      [Token(Token = "0x600B5A3")]
      [Address(RVA = "0x7CA8E0", Offset = "0x7C96E0", VA = "0x107CA8E0")]
      private IEnumerator SetScrollRect() => (IEnumerator) null;

      [Token(Token = "0x600B5A4")]
      [Address(RVA = "0x7CACA0", Offset = "0x7C9AA0", VA = "0x107CACA0")]
      public State_MissonAnim()
      {
      }
    }

    [Token(Token = "0x200283F")]
    private class State_PointAnim : State<PointQuestResultWindow>
    {
      [Token(Token = "0x400C003")]
      [FieldOffset(Offset = "0xC")]
      private Animator quest_point_anim;
      [Token(Token = "0x400C004")]
      [FieldOffset(Offset = "0x10")]
      private Animator high_score_anim;
      [Token(Token = "0x400C005")]
      [FieldOffset(Offset = "0x14")]
      private Animator cumulative_point_anim;
      [Token(Token = "0x400C006")]
      [FieldOffset(Offset = "0x18")]
      private Animator cumulative_high_score_anim;
      [Token(Token = "0x400C007")]
      [FieldOffset(Offset = "0x1C")]
      private float now_count_up_time;
      [Token(Token = "0x400C008")]
      [FieldOffset(Offset = "0x20")]
      private int current_point;
      [Token(Token = "0x400C009")]
      [FieldOffset(Offset = "0x24")]
      private int before_cumulative_point;
      [Token(Token = "0x400C00A")]
      [FieldOffset(Offset = "0x28")]
      private int after_cumulative_point;
      [Token(Token = "0x400C00B")]
      [FieldOffset(Offset = "0x2C")]
      private bool is_anim_cumulative_point;
      [Token(Token = "0x400C00C")]
      [FieldOffset(Offset = "0x30")]
      private PointQuestResultWindow.State_PointAnim.AnimState state;
      [Token(Token = "0x400C00D")]
      [FieldOffset(Offset = "0x34")]
      private AnimatorStateInfo quest_point_anim_state;

      [Token(Token = "0x600B5AB")]
      [Address(RVA = "0x7CACE0", Offset = "0x7C9AE0", VA = "0x107CACE0", Slot = "4")]
      public override void Begin(PointQuestResultWindow self)
      {
      }

      [Token(Token = "0x600B5AC")]
      [Address(RVA = "0x7CB2C0", Offset = "0x7CA0C0", VA = "0x107CB2C0", Slot = "5")]
      public override void Update(PointQuestResultWindow self)
      {
      }

      [Token(Token = "0x600B5AD")]
      [Address(RVA = "0x7CB050", Offset = "0x7C9E50", VA = "0x107CB050", Slot = "7")]
      public override void Command(PointQuestResultWindow self, string cmd)
      {
      }

      [Token(Token = "0x600B5AE")]
      [Address(RVA = "0x7CAF10", Offset = "0x7C9D10", VA = "0x107CAF10")]
      private void CheckAnimEnd(
        Animator _target_animator,
        string _end_state_name,
        PointQuestResultWindow.State_PointAnim.AnimState _next_state)
      {
      }

      [Token(Token = "0x600B5AF")]
      [Address(RVA = "0x7CB0A0", Offset = "0x7C9EA0", VA = "0x107CB0A0")]
      private void SetEndAnim()
      {
      }

      [Token(Token = "0x600B5B0")]
      [Address(RVA = "0x7CB7B0", Offset = "0x7CA5B0", VA = "0x107CB7B0")]
      public State_PointAnim()
      {
      }

      [Token(Token = "0x2002840")]
      private enum AnimState
      {
        [Token(Token = "0x400C00F")] POINT_OBJ_INTO,
        [Token(Token = "0x400C010")] POINT_COUNTUP,
        [Token(Token = "0x400C011")] HIGH_SCORE_START_ANIM,
        [Token(Token = "0x400C012")] CUMULATIVE_OBJ_INTO,
        [Token(Token = "0x400C013")] CUMULATIVE_COUNTUP,
        [Token(Token = "0x400C014")] CUMULATIVE_HIGH_SOCRE_START_ANIM,
        [Token(Token = "0x400C015")] ANIM_END,
      }
    }

    [Token(Token = "0x2002841")]
    private class State_AnimEnd : State<PointQuestResultWindow>
    {
      [Token(Token = "0x600B5B1")]
      [Address(RVA = "0x7CA500", Offset = "0x7C9300", VA = "0x107CA500", Slot = "4")]
      public override void Begin(PointQuestResultWindow self)
      {
      }

      [Token(Token = "0x600B5B2")]
      [Address(RVA = "0x7CA5A0", Offset = "0x7C93A0", VA = "0x107CA5A0")]
      public State_AnimEnd()
      {
      }
    }
  }
}

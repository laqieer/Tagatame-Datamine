// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchBattleResultView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002684")]
  [FlowNode.Pin(1, "Init", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "Skip", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1001, "Error", FlowNode.PinTypes.Output, 1001)]
  public class LeagueMatchBattleResultView : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B3F5")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400B3F6")]
    private const int PIN_IN_SKIP = 2;
    [Token(Token = "0x400B3F7")]
    private const int PIN_OUTPUT_ERROR = 1001;
    [Token(Token = "0x400B3F8")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList mUnitIconTemplete;
    [Token(Token = "0x400B3F9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mWinTitleObj;
    [Token(Token = "0x400B3FA")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mLoseTitleObj;
    [Token(Token = "0x400B3FB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Image mRankIconImg;
    [Token(Token = "0x400B3FC")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Image mRankNameImg;
    [Token(Token = "0x400B3FD")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private ImageArray[] mResultIcon;
    [Token(Token = "0x400B3FE")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private ImageArray[] mResultAddIcon;
    [Token(Token = "0x400B3FF")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject mAnimSkipBtn;
    [Token(Token = "0x400B400")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Animator mAnimator;
    [Token(Token = "0x400B401")]
    [FieldOffset(Offset = "0x30")]
    [HeaderBar("▼報酬関係")]
    [SerializeField]
    private GameObject mItemListObj;
    [Token(Token = "0x400B402")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    [StringIsResourcePath(typeof (GameObject))]
    private string REWARD_ICON_PREFAB_PATH;
    [Token(Token = "0x400B403")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject mRewardParentTemplate;
    [Token(Token = "0x400B404")]
    [FieldOffset(Offset = "0x3C")]
    [HeaderBar("(報酬アイコン表示間隔)")]
    [SerializeField]
    private float mRewardIconEffCount;
    [Token(Token = "0x400B405")]
    [FieldOffset(Offset = "0x40")]
    [HeaderBar("▼ランクアイコン&名前SpriteSheets")]
    [SerializeField]
    private SpriteSheet mRankIconSheet;
    [Token(Token = "0x400B406")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private SpriteSheet mRankNameSheet;
    [Token(Token = "0x400B407")]
    [FieldOffset(Offset = "0x48")]
    private readonly string EVENT_NAME_SKIP;
    [Token(Token = "0x400B408")]
    [FieldOffset(Offset = "0x4C")]
    private readonly string ANIM_RESULT_END;
    [Token(Token = "0x400B409")]
    [FieldOffset(Offset = "0x50")]
    private readonly string ANIM_BATTLE_RESULT_DEFAULT;
    [Token(Token = "0x400B40A")]
    [FieldOffset(Offset = "0x54")]
    private readonly string ANIM_BATTLE_RESULT_OPEN;
    [Token(Token = "0x400B40B")]
    [FieldOffset(Offset = "0x58")]
    private SRPG.StateMachine<LeagueMatchBattleResultView> StateMachine;
    [Token(Token = "0x400B40C")]
    [FieldOffset(Offset = "0x5C")]
    private Animator mTargetBattleResultIcon;
    [Token(Token = "0x400B40D")]
    [FieldOffset(Offset = "0x60")]
    private List<GameObject> mCreatedRewardIcons;
    [Token(Token = "0x400B40E")]
    [FieldOffset(Offset = "0x0")]
    private static bool mIsWin;
    [Token(Token = "0x400B40F")]
    [FieldOffset(Offset = "0x4")]
    private static List<Unit> mUnits;
    [Token(Token = "0x400B410")]
    [FieldOffset(Offset = "0x8")]
    private static JSON_LeagueMatchBattleEnd mResultData;
    [Token(Token = "0x400B411")]
    [FieldOffset(Offset = "0xC")]
    private static LeagueMatchBattleResultView.ServerSyncTrophyExec mServerSyncTrophyExec;

    [Token(Token = "0x600ABF6")]
    [Address(RVA = "0x6F4C20", Offset = "0x6F3A20", VA = "0x106F4C20")]
    private void Start()
    {
    }

    [Token(Token = "0x600ABF7")]
    [Address(RVA = "0x6F4610", Offset = "0x6F3410", VA = "0x106F4610")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600ABF8")]
    [Address(RVA = "0x6F4C90", Offset = "0x6F3A90", VA = "0x106F4C90")]
    private void Update()
    {
    }

    [Token(Token = "0x600ABF9")]
    [Address(RVA = "0x6F4930", Offset = "0x6F3730", VA = "0x106F4930")]
    public static void Setup(
      bool is_win,
      List<Unit> units,
      JSON_LeagueMatchBattleEnd result,
      LeagueMatchBattleResultView.ServerSyncTrophyExec _serverSyncTrophyExec)
    {
    }

    [Token(Token = "0x600ABFA")]
    [Address(RVA = "0x6F3CE0", Offset = "0x6F2AE0", VA = "0x106F3CE0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600ABFB")]
    [Address(RVA = "0x6F4260", Offset = "0x6F3060", VA = "0x106F4260")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600ABFC")]
    [Address(RVA = "0x6F3FD0", Offset = "0x6F2DD0", VA = "0x106F3FD0")]
    private void CreateUnitIcon()
    {
    }

    [Token(Token = "0x600ABFD")]
    [Address(RVA = "0x6F46B0", Offset = "0x6F34B0", VA = "0x106F46B0")]
    private void SetResult(int[] results, bool is_before)
    {
    }

    [Token(Token = "0x600ABFE")]
    [Address(RVA = "0x6F3D40", Offset = "0x6F2B40", VA = "0x106F3D40")]
    private void CreateRewardIcons()
    {
    }

    [Token(Token = "0x600ABFF")]
    [Address(RVA = "0x6F4B70", Offset = "0x6F3970", VA = "0x106F4B70")]
    private void Skip(Animator target_anim)
    {
    }

    [Token(Token = "0x600AC00")]
    [Address(RVA = "0x6F4CD0", Offset = "0x6F3AD0", VA = "0x106F4CD0")]
    public LeagueMatchBattleResultView()
    {
    }

    [Token(Token = "0x2002685")]
    public delegate void ServerSyncTrophyExec();

    [Token(Token = "0x2002686")]
    private class State_Idle : State<LeagueMatchBattleResultView>
    {
      [Token(Token = "0x600AC05")]
      [Address(RVA = "0x709510", Offset = "0x708310", VA = "0x10709510")]
      public State_Idle()
      {
      }
    }

    [Token(Token = "0x2002687")]
    private class State_ResultStart : State<LeagueMatchBattleResultView>
    {
      [Token(Token = "0x600AC06")]
      [Address(RVA = "0x709550", Offset = "0x708350", VA = "0x10709550", Slot = "4")]
      public override void Begin(LeagueMatchBattleResultView self)
      {
      }

      [Token(Token = "0x600AC07")]
      [Address(RVA = "0x7095D0", Offset = "0x7083D0", VA = "0x107095D0", Slot = "5")]
      public override void Update(LeagueMatchBattleResultView self)
      {
      }

      [Token(Token = "0x600AC08")]
      [Address(RVA = "0x709360", Offset = "0x708160", VA = "0x10709360", Slot = "7")]
      public override void Command(LeagueMatchBattleResultView self, string cmd)
      {
      }

      [Token(Token = "0x600AC09")]
      [Address(RVA = "0x7096B0", Offset = "0x7084B0", VA = "0x107096B0")]
      public State_ResultStart()
      {
      }
    }

    [Token(Token = "0x2002688")]
    private class State_BattleResult : State<LeagueMatchBattleResultView>
    {
      [Token(Token = "0x600AC0A")]
      [Address(RVA = "0x708F00", Offset = "0x707D00", VA = "0x10708F00", Slot = "4")]
      public override void Begin(LeagueMatchBattleResultView self)
      {
      }

      [Token(Token = "0x600AC0B")]
      [Address(RVA = "0x7091A0", Offset = "0x707FA0", VA = "0x107091A0", Slot = "5")]
      public override void Update(LeagueMatchBattleResultView self)
      {
      }

      [Token(Token = "0x600AC0C")]
      [Address(RVA = "0x709150", Offset = "0x707F50", VA = "0x10709150", Slot = "7")]
      public override void Command(LeagueMatchBattleResultView self, string cmd)
      {
      }

      [Token(Token = "0x600AC0D")]
      [Address(RVA = "0x709280", Offset = "0x708080", VA = "0x10709280")]
      public State_BattleResult()
      {
      }
    }

    [Token(Token = "0x2002689")]
    private class State_Reward : State<LeagueMatchBattleResultView>
    {
      [Token(Token = "0x400B412")]
      [FieldOffset(Offset = "0xC")]
      private IEnumerator coroutine;

      [Token(Token = "0x600AC0E")]
      [Address(RVA = "0x7096F0", Offset = "0x7084F0", VA = "0x107096F0", Slot = "4")]
      public override void Begin(LeagueMatchBattleResultView self)
      {
      }

      [Token(Token = "0x600AC0F")]
      [Address(RVA = "0x7099C0", Offset = "0x7087C0", VA = "0x107099C0")]
      private IEnumerator RewardIconView(LeagueMatchBattleResultView self) => (IEnumerator) null;

      [Token(Token = "0x600AC10")]
      [Address(RVA = "0x709800", Offset = "0x708600", VA = "0x10709800", Slot = "7")]
      public override void Command(LeagueMatchBattleResultView self, string cmd)
      {
      }

      [Token(Token = "0x600AC11")]
      [Address(RVA = "0x709A30", Offset = "0x708830", VA = "0x10709A30")]
      public State_Reward()
      {
      }
    }

    [Token(Token = "0x200268B")]
    private class State_End : State<LeagueMatchBattleResultView>
    {
      [Token(Token = "0x600AC18")]
      [Address(RVA = "0x7092C0", Offset = "0x7080C0", VA = "0x107092C0", Slot = "4")]
      public override void Begin(LeagueMatchBattleResultView self)
      {
      }

      [Token(Token = "0x600AC19")]
      [Address(RVA = "0x7093B0", Offset = "0x7081B0", VA = "0x107093B0", Slot = "5")]
      public override void Update(LeagueMatchBattleResultView self)
      {
      }

      [Token(Token = "0x600AC1A")]
      [Address(RVA = "0x709360", Offset = "0x708160", VA = "0x10709360", Slot = "7")]
      public override void Command(LeagueMatchBattleResultView self, string cmd)
      {
      }

      [Token(Token = "0x600AC1B")]
      [Address(RVA = "0x7094D0", Offset = "0x7082D0", VA = "0x107094D0")]
      public State_End()
      {
      }
    }
  }
}

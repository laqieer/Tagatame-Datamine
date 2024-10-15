// Decompiled with JetBrains decompiler
// Type: SRPG.TrophyList
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
  [Token(Token = "0x2002B77")]
  [AddComponentMenu("UI/TrophyList")]
  public class TrophyList : SRPG_ListBase, IFlowInterface
  {
    [Token(Token = "0x400D4D9")]
    [FieldOffset(Offset = "0x20")]
    public TrophyWindow trophy_window;
    [Token(Token = "0x400D4DA")]
    [FieldOffset(Offset = "0x24")]
    public TrophyList.TrophyTypes TrophyType;
    [Token(Token = "0x400D4DB")]
    [FieldOffset(Offset = "0x28")]
    public TrophyCategorys TrophyCategory;
    [Token(Token = "0x400D4DC")]
    [FieldOffset(Offset = "0x2C")]
    public TrophyRecordPullView OriginalPullView;
    [Token(Token = "0x400D4DD")]
    [FieldOffset(Offset = "0x30")]
    public ListItemEvents Item_Normal;
    [Token(Token = "0x400D4DE")]
    [FieldOffset(Offset = "0x34")]
    public ListItemEvents Item_Completed;
    [Token(Token = "0x400D4DF")]
    [FieldOffset(Offset = "0x38")]
    public ListItemEvents Item_Ended;
    [Token(Token = "0x400D4E0")]
    [FieldOffset(Offset = "0x3C")]
    public GameObject DetailWindow;
    [Token(Token = "0x400D4E1")]
    [FieldOffset(Offset = "0x40")]
    public ListItemEvents Item_Review;
    [Token(Token = "0x400D4E2")]
    [FieldOffset(Offset = "0x44")]
    public ListItemEvents Item_FollowTwitter;
    [Token(Token = "0x400D4E3")]
    [FieldOffset(Offset = "0x48")]
    public RectTransform parent_panel_rect;
    [Token(Token = "0x400D4E4")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private LayoutElement view_port_handle;
    [Token(Token = "0x400D4E5")]
    [FieldOffset(Offset = "0x50")]
    private RectTransform view_port_handle_rect;
    [Token(Token = "0x400D4E6")]
    [FieldOffset(Offset = "0x54")]
    private RectTransform scroll_trans_rect;
    [Token(Token = "0x400D4E7")]
    private const int CREATE_ENDED_PLATE_COUNT = 50;
    [Token(Token = "0x400D4E8")]
    private const int CREATE_PULL_VIEW_COUNT_MAX = 50;
    [Token(Token = "0x400D4E9")]
    private const int CREATE_CHILD_COUNT = 20;
    [Token(Token = "0x400D4EA")]
    [FieldOffset(Offset = "0x58")]
    public bool RefreshOnStart;
    [Token(Token = "0x400D4EB")]
    [FieldOffset(Offset = "0x59")]
    private bool mStarted;
    [Token(Token = "0x400D4EC")]
    [FieldOffset(Offset = "0x5C")]
    private CanvasGroup mCanvasGroup;
    [Token(Token = "0x400D4ED")]
    [FieldOffset(Offset = "0x60")]
    private List<TrophyRecordPullView> child_pull_viewes;
    [Token(Token = "0x400D4EE")]
    [FieldOffset(Offset = "0x64")]
    private List<TrophyParam> child_plates;
    [Token(Token = "0x400D4EF")]
    [FieldOffset(Offset = "0x68")]
    private bool is_busy;
    [Token(Token = "0x400D4F0")]
    [FieldOffset(Offset = "0x6C")]
    private float FOCUS_EFFECT_SECOND;
    [Token(Token = "0x400D4F1")]
    [FieldOffset(Offset = "0x70")]
    private Vector2 start_pos;
    [Token(Token = "0x400D4F2")]
    [FieldOffset(Offset = "0x78")]
    private Vector2 target_pos;
    [Token(Token = "0x400D4F3")]
    [FieldOffset(Offset = "0x80")]
    private List<TrophyRecordPullView> click_target;
    [Token(Token = "0x400D4F4")]
    [FieldOffset(Offset = "0x84")]
    [SerializeField]
    private ScrollRect scroll_rect;
    [Token(Token = "0x400D4F5")]
    [FieldOffset(Offset = "0x88")]
    private float total_close_item_size;
    [Token(Token = "0x400D4F6")]
    [FieldOffset(Offset = "0x8C")]
    private float focus_delay_time;
    [Token(Token = "0x400D4F7")]
    [FieldOffset(Offset = "0x90")]
    private float elapsed_time;
    [Token(Token = "0x400D4F8")]
    [FieldOffset(Offset = "0x94")]
    private TrophyList.eState state;
    [Token(Token = "0x400D4F9")]
    [FieldOffset(Offset = "0x98")]
    private List<TrophyRecordTab> mTabList;

    [Token(Token = "0x17001A6A")]
    public TrophyWindow Trophy_Window
    {
      [Token(Token = "0x600C71E"), Address(RVA = "0x900C80", Offset = "0x8FFA80", VA = "0x10900C80")] get
      {
        return (TrophyWindow) null;
      }
    }

    [Token(Token = "0x17001A6B")]
    private RectTransform ScrollTransRect
    {
      [Token(Token = "0x600C71F"), Address(RVA = "0x900B00", Offset = "0x8FF900", VA = "0x10900B00")] get
      {
        return (RectTransform) null;
      }
    }

    [Token(Token = "0x17001A6C")]
    public virtual List<TrophyState> TrophyDailyData
    {
      [Token(Token = "0x600C720"), Address(RVA = "0x900B80", Offset = "0x8FF980", VA = "0x10900B80", Slot = "10")] get
      {
        return (List<TrophyState>) null;
      }
    }

    [Token(Token = "0x17001A6D")]
    public virtual List<TrophyState> TrophyEndedData
    {
      [Token(Token = "0x600C721"), Address(RVA = "0x900C00", Offset = "0x8FFA00", VA = "0x10900C00", Slot = "11")] get
      {
        return (List<TrophyState>) null;
      }
    }

    [Token(Token = "0x600C722")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "9")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C723")]
    [Address(RVA = "0x8FC9A0", Offset = "0x8FB7A0", VA = "0x108FC9A0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600C724")]
    [Address(RVA = "0x8FD230", Offset = "0x8FC030", VA = "0x108FD230", Slot = "7")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x600C725")]
    [Address(RVA = "0x9001F0", Offset = "0x8FEFF0", VA = "0x109001F0", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x600C726")]
    [Address(RVA = "0x8FD790", Offset = "0x8FC590", VA = "0x108FD790")]
    private void OnTrophyReset()
    {
    }

    [Token(Token = "0x600C727")]
    [Address(RVA = "0x8FD460", Offset = "0x8FC260", VA = "0x108FD460")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600C728")]
    [Address(RVA = "0x8FD2F0", Offset = "0x8FC0F0", VA = "0x108FD2F0")]
    private void OnDisable()
    {
    }

    [Token(Token = "0x600C729")]
    [Address(RVA = "0x900A20", Offset = "0x8FF820", VA = "0x10900A20")]
    private void Update()
    {
    }

    [Token(Token = "0x600C72A")]
    [Address(RVA = "0x8FCD90", Offset = "0x8FBB90", VA = "0x108FCD90", Slot = "8")]
    protected override void LateUpdate()
    {
    }

    [Token(Token = "0x600C72B")]
    [Address(RVA = "0x8FA9C0", Offset = "0x8F97C0", VA = "0x108FA9C0")]
    public void CreateTrophies(List<TrophyState> trophies)
    {
    }

    [Token(Token = "0x600C72C")]
    [Address(RVA = "0x8FA880", Offset = "0x8F9680", VA = "0x108FA880")]
    public void ClearAllItems()
    {
    }

    [Token(Token = "0x600C72D")]
    [Address(RVA = "0x8FD820", Offset = "0x8FC620", VA = "0x108FD820")]
    private void RefreshTrophyRecordLight()
    {
    }

    [Token(Token = "0x600C72E")]
    [Address(RVA = "0x8FD800", Offset = "0x8FC600", VA = "0x108FD800")]
    public void RefreshLight()
    {
    }

    [Token(Token = "0x600C72F")]
    [Address(RVA = "0x8FDE90", Offset = "0x8FCC90", VA = "0x108FDE90")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600C730")]
    [Address(RVA = "0x8FDC70", Offset = "0x8FCA70", VA = "0x108FDC70")]
    public void RefreshTrophySimple(
      List<TrophyState> _trophies,
      int _create_count,
      bool _need_sort,
      bool _daily_comp_check)
    {
    }

    [Token(Token = "0x600C731")]
    [Address(RVA = "0x8FADA0", Offset = "0x8F9BA0", VA = "0x108FADA0")]
    private int[] GetSortedIndex(List<TrophyState> _trophies) => (int[]) null;

    [Token(Token = "0x600C732")]
    [Address(RVA = "0x8FCDB0", Offset = "0x8FBBB0", VA = "0x108FCDB0")]
    public ListItemEvents MakeTrophyPlate(TrophyState st, bool is_achievement)
    {
      return (ListItemEvents) null;
    }

    [Token(Token = "0x600C733")]
    [Address(RVA = "0x8FD6D0", Offset = "0x8FC4D0", VA = "0x108FD6D0", Slot = "12")]
    public virtual void OnItemSelect(GameObject go)
    {
    }

    [Token(Token = "0x600C734")]
    [Address(RVA = "0x8FC2E0", Offset = "0x8FB0E0", VA = "0x108FC2E0")]
    protected void GotoReward(TrophyParam param)
    {
    }

    [Token(Token = "0x600C735")]
    [Address(RVA = "0x8FE3F0", Offset = "0x8FD1F0", VA = "0x108FE3F0", Slot = "13")]
    protected virtual void SelectGotoShortCut(TrophyParam param)
    {
    }

    [Token(Token = "0x600C736")]
    [Address(RVA = "0x8FD5B0", Offset = "0x8FC3B0", VA = "0x108FD5B0")]
    protected void OnItemDetail(GameObject go)
    {
    }

    [Token(Token = "0x600C737")]
    [Address(RVA = "0x8FB1E0", Offset = "0x8F9FE0", VA = "0x108FB1E0")]
    protected void GotoArena()
    {
    }

    [Token(Token = "0x600C738")]
    [Address(RVA = "0x8FB2D0", Offset = "0x8FA0D0", VA = "0x108FB2D0")]
    protected void GotoDuel()
    {
    }

    [Token(Token = "0x600C739")]
    [Address(RVA = "0x8FC8D0", Offset = "0x8FB6D0", VA = "0x108FC8D0")]
    private void GotoVersus()
    {
    }

    [Token(Token = "0x600C73A")]
    [Address(RVA = "0x8FB580", Offset = "0x8FA380", VA = "0x108FB580")]
    private void GotoMultiTower()
    {
    }

    [Token(Token = "0x600C73B")]
    [Address(RVA = "0x8FB390", Offset = "0x8FA190", VA = "0x108FB390")]
    private void GotoEquip()
    {
    }

    [Token(Token = "0x600C73C")]
    [Address(RVA = "0x8FC500", Offset = "0x8FB300", VA = "0x108FC500")]
    private void GotoShop(TrophyParam param)
    {
    }

    [Token(Token = "0x600C73D")]
    [Address(RVA = "0x8FB2A0", Offset = "0x8FA0A0", VA = "0x108FB2A0")]
    private void GotoBeginnerTop()
    {
    }

    [Token(Token = "0x600C73E")]
    [Address(RVA = "0x8FB120", Offset = "0x8F9F20", VA = "0x108FB120")]
    protected void GotoAdventure()
    {
    }

    [Token(Token = "0x600C73F")]
    [Address(RVA = "0x8FC0D0", Offset = "0x8FAED0", VA = "0x108FC0D0")]
    protected bool GotoQuests(QuestParam[] quests) => new bool();

    [Token(Token = "0x600C740")]
    [Address(RVA = "0x8FC070", Offset = "0x8FAE70", VA = "0x108FC070")]
    protected bool GotoQuests(string iname) => new bool();

    [Token(Token = "0x600C741")]
    [Address(RVA = "0x8FC130", Offset = "0x8FAF30", VA = "0x108FC130")]
    protected bool GotoQuests(QuestParam quest) => new bool();

    [Token(Token = "0x600C742")]
    [Address(RVA = "0x8FB5F0", Offset = "0x8FA3F0", VA = "0x108FB5F0")]
    protected void GotoQuestMode(QuestDifficulties difficulty)
    {
    }

    [Token(Token = "0x600C743")]
    [Address(RVA = "0x8FA090", Offset = "0x8F8E90", VA = "0x108FA090")]
    protected void ChallengeBtnSetting(SRPG_Button btn, TrophyParam trophy)
    {
    }

    [Token(Token = "0x600C744")]
    [Address(RVA = "0x8FB460", Offset = "0x8FA260", VA = "0x108FB460")]
    protected void GotoEventQuestArchive()
    {
    }

    [Token(Token = "0x600C745")]
    [Address(RVA = "0x8F9D20", Offset = "0x8F8B20", VA = "0x108F9D20")]
    protected void AchievementBtnSetting(SRPG_Button btn)
    {
    }

    [Token(Token = "0x600C746")]
    [Address(RVA = "0x8FACC0", Offset = "0x8F9AC0", VA = "0x108FACC0")]
    protected void FollowBtnSetting(SRPG_Button btn)
    {
    }

    [Token(Token = "0x600C747")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    protected void MsgBoxJumpToQuest(GameObject go)
    {
    }

    [Token(Token = "0x600C748")]
    [Address(RVA = "0x8FDFF0", Offset = "0x8FCDF0", VA = "0x108FDFF0")]
    private void Run()
    {
    }

    [Token(Token = "0x600C749")]
    [Address(RVA = "0x8FA270", Offset = "0x8F9070", VA = "0x108FA270")]
    private void ChangeState(TrophyList.eState _new_state)
    {
    }

    [Token(Token = "0x600C74A")]
    [Address(RVA = "0x8FFAA0", Offset = "0x8FE8A0", VA = "0x108FFAA0")]
    public void SetClickTarget(TrophyRecordPullView _pull_view)
    {
    }

    [Token(Token = "0x600C74B")]
    [Address(RVA = "0x8FA780", Offset = "0x8F9580", VA = "0x108FA780")]
    private void CheckTarget()
    {
    }

    [Token(Token = "0x600C74C")]
    [Address(RVA = "0x8FD7A0", Offset = "0x8FC5A0", VA = "0x108FD7A0")]
    private bool OpenPullView() => new bool();

    [Token(Token = "0x600C74D")]
    [Address(RVA = "0x8FA9A0", Offset = "0x8F97A0", VA = "0x108FA9A0")]
    private bool ClosePullView() => new bool();

    [Token(Token = "0x600C74E")]
    [Address(RVA = "0x8FFAF0", Offset = "0x8FE8F0", VA = "0x108FFAF0")]
    private void StartCloseOtherWait()
    {
    }

    [Token(Token = "0x600C74F")]
    [Address(RVA = "0x8FAB40", Offset = "0x8F9940", VA = "0x108FAB40")]
    private void EndCloseOtherWait()
    {
    }

    [Token(Token = "0x600C750")]
    [Address(RVA = "0x900230", Offset = "0x8FF030", VA = "0x10900230")]
    private void UpdateCloseOtherWait()
    {
    }

    [Token(Token = "0x600C751")]
    [Address(RVA = "0x8FFFF0", Offset = "0x8FEDF0", VA = "0x108FFFF0")]
    private void StartFocus()
    {
    }

    [Token(Token = "0x600C752")]
    [Address(RVA = "0x8FAC60", Offset = "0x8F9A60", VA = "0x108FAC60")]
    private void EndFocus()
    {
    }

    [Token(Token = "0x600C753")]
    [Address(RVA = "0x900470", Offset = "0x8FF270", VA = "0x10900470")]
    private void UpdateFocus()
    {
    }

    [Token(Token = "0x600C754")]
    [Address(RVA = "0x900450", Offset = "0x8FF250", VA = "0x10900450")]
    private void UpdateFocusInterval()
    {
    }

    [Token(Token = "0x600C755")]
    [Address(RVA = "0x8FFE10", Offset = "0x8FEC10", VA = "0x108FFE10")]
    private void StartCreatePullItems()
    {
    }

    [Token(Token = "0x600C756")]
    [Address(RVA = "0x900430", Offset = "0x8FF230", VA = "0x10900430")]
    private void UpdateCreatePullItems()
    {
    }

    [Token(Token = "0x600C757")]
    [Address(RVA = "0x900110", Offset = "0x8FEF10", VA = "0x10900110")]
    private void StartOpen()
    {
    }

    [Token(Token = "0x600C758")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void EndOpen()
    {
    }

    [Token(Token = "0x600C759")]
    [Address(RVA = "0x900980", Offset = "0x8FF780", VA = "0x10900980")]
    private void UpdateOpen()
    {
    }

    [Token(Token = "0x600C75A")]
    [Address(RVA = "0x8FFCC0", Offset = "0x8FEAC0", VA = "0x108FFCC0")]
    private void StartClose()
    {
    }

    [Token(Token = "0x600C75B")]
    [Address(RVA = "0x8FABF0", Offset = "0x8F99F0", VA = "0x108FABF0")]
    protected void EndClose()
    {
    }

    [Token(Token = "0x600C75C")]
    [Address(RVA = "0x900340", Offset = "0x8FF140", VA = "0x10900340")]
    protected void UpdateClose()
    {
    }

    [Token(Token = "0x600C75D")]
    [Address(RVA = "0x9005B0", Offset = "0x8FF3B0", VA = "0x109005B0")]
    private void UpdateHandleHeight()
    {
    }

    [Token(Token = "0x600C75E")]
    [Address(RVA = "0x9000F0", Offset = "0x8FEEF0", VA = "0x109000F0")]
    private void StartIdle()
    {
    }

    [Token(Token = "0x600C75F")]
    [Address(RVA = "0x8FACB0", Offset = "0x8F9AB0", VA = "0x108FACB0")]
    private void EndIdle()
    {
    }

    [Token(Token = "0x600C760")]
    [Address(RVA = "0x900720", Offset = "0x8FF520", VA = "0x10900720")]
    private void UpdateIdle()
    {
    }

    [Token(Token = "0x600C761")]
    [Address(RVA = "0x8FB720", Offset = "0x8FA520", VA = "0x108FB720")]
    private void GotoQuest(string quest)
    {
    }

    [Token(Token = "0x600C762")]
    [Address(RVA = "0x8F9E00", Offset = "0x8F8C00", VA = "0x108F9E00")]
    private void ArchiveChangeSceneConfirm()
    {
    }

    [Token(Token = "0x600C763")]
    [Address(RVA = "0x8F9EB0", Offset = "0x8F8CB0", VA = "0x108F9EB0")]
    private bool ArchiveMessage(
      PlayerData player,
      ArchiveParam archive_param,
      QuestTypes questTypes)
    {
      return new bool();
    }

    [Token(Token = "0x600C764")]
    [Address(RVA = "0x8F5C50", Offset = "0x8F4A50", VA = "0x108F5C50")]
    public TrophyList()
    {
    }

    [Token(Token = "0x2002B78")]
    private enum eState
    {
      [Token(Token = "0x400D4FB")] IDLE,
      [Token(Token = "0x400D4FC")] CLOSE_OTHER_WAIT,
      [Token(Token = "0x400D4FD")] FOCUS,
      [Token(Token = "0x400D4FE")] FOCUS_INTERVAL,
      [Token(Token = "0x400D4FF")] CREATE_PULL_ITEM,
      [Token(Token = "0x400D500")] OPEN,
      [Token(Token = "0x400D501")] CLOSE,
    }

    [Token(Token = "0x2002B79")]
    public enum TrophyTypes
    {
      [Token(Token = "0x400D503")] Normal,
      [Token(Token = "0x400D504")] Daily,
      [Token(Token = "0x400D505")] All,
    }
  }
}

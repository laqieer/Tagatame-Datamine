// Decompiled with JetBrains decompiler
// Type: SRPG.AutoInvalidSkillEditWindow
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
  [Token(Token = "0x200264A")]
  [FlowNode.Pin(111, "念装詳細表示", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(112, "マスターアビリティその他詳細表示", FlowNode.PinTypes.Output, 112)]
  [FlowNode.Pin(110, "武具詳細表示", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(9, "閉じるボタン", FlowNode.PinTypes.Input, 9)]
  [FlowNode.Pin(101, "REQ_ON/OFF情報取得", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "REQ_ON/OFF情報保存", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(100, "初期化完了", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/InvalidSkill/AutoInvalidSkillEditWindow")]
  [FlowNode.Pin(103, "閉じる", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(7, "スキルOn/Off有効化", FlowNode.PinTypes.Input, 7)]
  [FlowNode.Pin(8, "スキルOn/Off無効化", FlowNode.PinTypes.Input, 8)]
  [FlowNode.Pin(2, "初期設定情報取得CallBack", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(4, "固有技タブ選択", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(6, "その他アビリティ", FlowNode.PinTypes.Input, 6)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(3, "基本技タブ選択", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(5, "装備アビリティ", FlowNode.PinTypes.Input, 5)]
  public class AutoInvalidSkillEditWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B2DA")]
    public const int INPUT_INITIALIZE = 1;
    [Token(Token = "0x400B2DB")]
    public const int INPUT_GET_REQUEST_CALLBACK = 2;
    [Token(Token = "0x400B2DC")]
    public const int INPUT_SELECT_TAB_BASIC_ABILITY = 3;
    [Token(Token = "0x400B2DD")]
    public const int INPUT_SELECT_TAB_UNIQUE_ABILITY = 4;
    [Token(Token = "0x400B2DE")]
    public const int INPUT_SELECT_TAB_MASTER_ABILITY = 5;
    [Token(Token = "0x400B2DF")]
    public const int INPUT_SELECT_TAB_OTHER_ABILITY = 6;
    [Token(Token = "0x400B2E0")]
    public const int INPUT_ENABLE_INVALID_SKILL = 7;
    [Token(Token = "0x400B2E1")]
    public const int INPUT_DISABLE_INVALID_SKILL = 8;
    [Token(Token = "0x400B2E2")]
    public const int INPUT_ON_CLICK_CLOSE = 9;
    [Token(Token = "0x400B2E3")]
    public const int OUTPUT_INITIALIZE_FINISH = 100;
    [Token(Token = "0x400B2E4")]
    public const int OUTPUT_INVALID_SKILL_GET = 101;
    [Token(Token = "0x400B2E5")]
    public const int OUTPUT_INVALID_SKILL_SET = 102;
    [Token(Token = "0x400B2E6")]
    public const int OUTPUT_WINDOW_CLOSE = 103;
    [Token(Token = "0x400B2E7")]
    public const int OUTPUT_AIRTFACT_DETAIL = 110;
    [Token(Token = "0x400B2E8")]
    public const int OUTPUT_CONCEPTCARD_DETAIL = 111;
    [Token(Token = "0x400B2E9")]
    public const int OUTPUT_MASTER_ABILITY_OTHER_MSG = 112;
    [Token(Token = "0x400B2EA")]
    [FieldOffset(Offset = "0xC")]
    private readonly string SVB_NAME_LEFT_TAB_JOB_DATA;
    [Token(Token = "0x400B2EB")]
    [FieldOffset(Offset = "0x10")]
    private readonly string SVB_NAME_LEFT_TAB_TEXT_ON;
    [Token(Token = "0x400B2EC")]
    [FieldOffset(Offset = "0x14")]
    private readonly string SVB_NAME_LEFT_TAB_TEXT_OFF;
    [Token(Token = "0x400B2ED")]
    [FieldOffset(Offset = "0x18")]
    private readonly string SVB_NAME_LEFT_TAB_SET_ICON;
    [Token(Token = "0x400B2EE")]
    [FieldOffset(Offset = "0x1C")]
    private readonly string SVB_NAME_LEFT_TAB_LOCK_ICON;
    [Token(Token = "0x400B2EF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Transform mTabLeftRoot;
    [Token(Token = "0x400B2F0")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Toggle mTabLeftTemplete;
    [Token(Token = "0x400B2F1")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Transform mSkillListRoot;
    [Token(Token = "0x400B2F2")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject mSkillListTemplete;
    [Token(Token = "0x400B2F3")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text mBasicTabOnText;
    [Token(Token = "0x400B2F4")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Text mBasicTabOffText;
    [Token(Token = "0x400B2F5")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text mUniqueTabOnText;
    [Token(Token = "0x400B2F6")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Text mUniqueTabOffText;
    [Token(Token = "0x400B2F7")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject mSkillDetailRoot;
    [Token(Token = "0x400B2F8")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private GameObject mSkillDetailCover;
    [Token(Token = "0x400B2F9")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject CloseButton;
    [Token(Token = "0x400B2FA")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private ContentController mContentController;
    [Token(Token = "0x400B2FB")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject mInvalidSkillDisableMask;
    [Token(Token = "0x400B2FC")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private SRPG_Button mEnableInvalidSkillBtn;
    [Token(Token = "0x400B2FD")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private SRPG_Button mDisableInvalidSkillBtn;
    [Token(Token = "0x400B2FF")]
    [FieldOffset(Offset = "0x4")]
    private static AutoInvalidSkillEditWindow mInstance;
    [Token(Token = "0x400B300")]
    [FieldOffset(Offset = "0x5C")]
    private AutoInvalidSkillEditWindow.ETabType mSelectTab;
    [Token(Token = "0x400B301")]
    [FieldOffset(Offset = "0x60")]
    private UnitData mSelectUnit;
    [Token(Token = "0x400B302")]
    [FieldOffset(Offset = "0x64")]
    private JobData mSelectJobData;
    [Token(Token = "0x400B303")]
    [FieldOffset(Offset = "0x68")]
    private List<InvalidSkill> mEditInvalidSkill;
    [Token(Token = "0x400B304")]
    [FieldOffset(Offset = "0x6C")]
    private List<AbilityData> mAllLearnedAbilities;
    [Token(Token = "0x400B305")]
    [FieldOffset(Offset = "0x70")]
    private UnitData.InvalidSkillList mSkillList;
    [Token(Token = "0x400B306")]
    [FieldOffset(Offset = "0x74")]
    private bool IsPopupWindow;
    [Token(Token = "0x400B307")]
    [FieldOffset(Offset = "0x78")]
    private List<InvalidSkillParam> mInvalidSkillParams;
    [Token(Token = "0x400B308")]
    [FieldOffset(Offset = "0x7C")]
    private List<SerializeValueBehaviour> mSvbLeftTabList;

    [Token(Token = "0x170017F1")]
    public static EInvalidSkillApplyType SelectApplyType
    {
      [Token(Token = "0x600AAE8"), Address(RVA = "0x6DE3B0", Offset = "0x6DD1B0", VA = "0x106DE3B0")] get
      {
        return new EInvalidSkillApplyType();
      }
      [Token(Token = "0x600AAE9"), Address(RVA = "0x6DE3E0", Offset = "0x6DD1E0", VA = "0x106DE3E0")] set
      {
      }
    }

    [Token(Token = "0x170017F2")]
    public static AutoInvalidSkillEditWindow Instance
    {
      [Token(Token = "0x600AAEA"), Address(RVA = "0x6DE380", Offset = "0x6DD180", VA = "0x106DE380")] get
      {
        return (AutoInvalidSkillEditWindow) null;
      }
    }

    [Token(Token = "0x170017F3")]
    public AutoInvalidSkillEditWindow.ETabType SelectTab
    {
      [Token(Token = "0x600AAEB"), Address(RVA = "0x288090", Offset = "0x286E90", VA = "0x10288090")] get
      {
        return new AutoInvalidSkillEditWindow.ETabType();
      }
    }

    [Token(Token = "0x600AAEC")]
    [Address(RVA = "0x6DAF50", Offset = "0x6D9D50", VA = "0x106DAF50")]
    private void Awake()
    {
    }

    [Token(Token = "0x600AAED")]
    [Address(RVA = "0x6DC3C0", Offset = "0x6DB1C0", VA = "0x106DC3C0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600AAEE")]
    [Address(RVA = "0x6DAD20", Offset = "0x6D9B20", VA = "0x106DAD20", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AAEF")]
    [Address(RVA = "0x6DC410", Offset = "0x6DB210", VA = "0x106DC410")]
    public void SetActiveForCloseButton(bool act)
    {
    }

    [Token(Token = "0x600AAF0")]
    [Address(RVA = "0x579A70", Offset = "0x578870", VA = "0x10579A70")]
    public void SetIsPopupWindow(bool b)
    {
    }

    [Token(Token = "0x600AAF1")]
    [Address(RVA = "0x6DBC70", Offset = "0x6DAA70", VA = "0x106DBC70")]
    private PlayerPartyTypes GetTargetPlayerPartyType() => new PlayerPartyTypes();

    [Token(Token = "0x600AAF2")]
    [Address(RVA = "0x6DBD50", Offset = "0x6DAB50", VA = "0x106DBD50")]
    private void Initialized()
    {
    }

    [Token(Token = "0x600AAF3")]
    [Address(RVA = "0x6DC460", Offset = "0x6DB260", VA = "0x106DC460")]
    private void SetInvalidSkillData()
    {
    }

    [Token(Token = "0x600AAF4")]
    [Address(RVA = "0x6DAFF0", Offset = "0x6D9DF0", VA = "0x106DAFF0")]
    private void CreateJobTabList()
    {
    }

    [Token(Token = "0x600AAF5")]
    [Address(RVA = "0x6DB5C0", Offset = "0x6DA3C0", VA = "0x106DB5C0")]
    private void DestroyJobTabList()
    {
    }

    [Token(Token = "0x600AAF6")]
    [Address(RVA = "0x6DD0A0", Offset = "0x6DBEA0", VA = "0x106DD0A0")]
    private void SetTabView(SerializeValueBehaviour svb, string name, bool is_set, bool is_lock)
    {
    }

    [Token(Token = "0x600AAF7")]
    [Address(RVA = "0x6DB9B0", Offset = "0x6DA7B0", VA = "0x106DB9B0")]
    private AbilityData GetAbilityData(string ability_iname) => (AbilityData) null;

    [Token(Token = "0x600AAF8")]
    [Address(RVA = "0x6DD1B0", Offset = "0x6DBFB0", VA = "0x106DD1B0")]
    private void SetViewInvalidSkillEnable()
    {
    }

    [Token(Token = "0x600AAF9")]
    [Address(RVA = "0x6DC910", Offset = "0x6DB710", VA = "0x106DC910")]
    private void SetInvalidSkillUseSetting(bool is_enable)
    {
    }

    [Token(Token = "0x600AAFA")]
    [Address(RVA = "0x6DD040", Offset = "0x6DBE40", VA = "0x106DD040")]
    private void SetSelectTab(AutoInvalidSkillEditWindow.ETabType new_tab, bool is_force = false)
    {
    }

    [Token(Token = "0x600AAFB")]
    [Address(RVA = "0x6DCB80", Offset = "0x6DB980", VA = "0x106DCB80")]
    private void SetSelectJobTabList(JobData select_job)
    {
    }

    [Token(Token = "0x600AAFC")]
    [Address(RVA = "0x6DD870", Offset = "0x6DC670", VA = "0x106DD870")]
    private void SetViewSkills()
    {
    }

    [Token(Token = "0x600AAFD")]
    [Address(RVA = "0x6DD2F0", Offset = "0x6DC0F0", VA = "0x106DD2F0")]
    private void SetViewMasterAbilities()
    {
    }

    [Token(Token = "0x600AAFE")]
    [Address(RVA = "0x6DBE70", Offset = "0x6DAC70", VA = "0x106DBE70")]
    public bool IsInvalidSkillState(string skill_iname) => new bool();

    [Token(Token = "0x600AAFF")]
    [Address(RVA = "0x6DB6F0", Offset = "0x6DA4F0", VA = "0x106DB6F0")]
    public bool EditInvalidSkill(
      string skill_iname,
      bool is_invalid_skill,
      EInvalidSkillType item_type)
    {
      return new bool();
    }

    [Token(Token = "0x600AB00")]
    [Address(RVA = "0x6DC040", Offset = "0x6DAE40", VA = "0x106DC040")]
    public void OnClickDetail(InvalidSkillParam invalidSkillParam)
    {
    }

    [Token(Token = "0x600AB01")]
    [Address(RVA = "0x6DDE40", Offset = "0x6DCC40", VA = "0x106DDE40")]
    private void UpdateSettingCheck()
    {
    }

    [Token(Token = "0x600AB02")]
    [Address(RVA = "0x6DBD00", Offset = "0x6DAB00", VA = "0x106DBD00")]
    public long GetTargetUnitIid() => new long();

    [Token(Token = "0x600AB03")]
    [Address(RVA = "0x6DBB20", Offset = "0x6DA920", VA = "0x106DBB20")]
    public List<InvalidSkill> GetInvalidSkillData(bool is_select_apply_type = true)
    {
      return (List<InvalidSkill>) null;
    }

    [Token(Token = "0x600AB04")]
    [Address(RVA = "0x6DE220", Offset = "0x6DD020", VA = "0x106DE220")]
    public AutoInvalidSkillEditWindow()
    {
    }

    [Token(Token = "0x200264B")]
    public enum ETabType
    {
      [Token(Token = "0x400B30A")] BASIC_ABILITY,
      [Token(Token = "0x400B30B")] UNIQUE_ABILITY,
      [Token(Token = "0x400B30C")] MASTER_ABILITY,
      [Token(Token = "0x400B30D")] OTHER_ABILITY,
    }
  }
}

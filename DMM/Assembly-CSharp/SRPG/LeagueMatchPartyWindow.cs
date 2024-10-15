// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchPartyWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20026A6")]
  [FlowNode.Pin(2101, "チーム登録通信(攻撃編成登録)", FlowNode.PinTypes.Output, 2101)]
  [FlowNode.Pin(2300, "模擬戦攻撃PT更新完了", FlowNode.PinTypes.Output, 2300)]
  [FlowNode.Pin(2200, "リーダースキル変更ポップ生成", FlowNode.PinTypes.Output, 2200)]
  [FlowNode.Pin(2006, "次のチームへ", FlowNode.PinTypes.Input, 2006)]
  [FlowNode.Pin(2104, "一括装着更新通信（独立編成用）", FlowNode.PinTypes.Output, 2104)]
  [FlowNode.Pin(2102, "チーム名変更通信", FlowNode.PinTypes.Output, 2102)]
  [AddComponentMenu("UI/LeagueMatch/LeagueMatchPartyWindow")]
  [FlowNode.Pin(2105, "スキルon/off更新通信（独立編成用）", FlowNode.PinTypes.Output, 2105)]
  [FlowNode.Pin(2100, "チーム変更通信(防御編成登録,事前編成変更)", FlowNode.PinTypes.Output, 2100)]
  [FlowNode.Pin(2103, "念装一括装着通信（独立編成用）", FlowNode.PinTypes.Output, 2103)]
  [FlowNode.Pin(2008, "リーダースキル変更", FlowNode.PinTypes.Input, 2008)]
  [FlowNode.Pin(2007, "前のチームへ", FlowNode.PinTypes.Input, 2007)]
  [FlowNode.Pin(2005, "PINイベントを許可", FlowNode.PinTypes.Input, 2005)]
  [FlowNode.Pin(2004, "PINイベントを拒否", FlowNode.PinTypes.Input, 2004)]
  [FlowNode.Pin(2003, "チーム名変更画面で変更完了", FlowNode.PinTypes.Input, 2003)]
  [FlowNode.Pin(2002, "チーム登録クリック", FlowNode.PinTypes.Input, 2002)]
  [FlowNode.Pin(2001, "初期化", FlowNode.PinTypes.Input, 2001)]
  [FlowNode.Pin(2090, "編成情報を更新（外部から呼ばれる）", FlowNode.PinTypes.Input, 2090)]
  public class LeagueMatchPartyWindow : PartyWindow2
  {
    [Token(Token = "0x400B4C3")]
    private const int PIN_IN_INIT = 2001;
    [Token(Token = "0x400B4C4")]
    private const int PIN_IN_REGISTE_CLICK = 2002;
    [Token(Token = "0x400B4C5")]
    private const int PIN_IN_PRESET_NAMECHANGE = 2003;
    [Token(Token = "0x400B4C6")]
    private const int PIN_IN_LOCK_PIN_EVENT = 2004;
    [Token(Token = "0x400B4C7")]
    private const int PIN_IN_UNLOCK_PIN_EVENT = 2005;
    [Token(Token = "0x400B4C8")]
    private const int PIN_IN_NEXT_TEAM = 2006;
    [Token(Token = "0x400B4C9")]
    private const int PIN_IN_PREV_TEAM = 2007;
    [Token(Token = "0x400B4CA")]
    private const int PIN_IN_LEADERSKILL_CHANGE = 2008;
    [Token(Token = "0x400B4CB")]
    private const int PIN_IN_TEAM_REFRESH = 2090;
    [Token(Token = "0x400B4CC")]
    private const int PIN_OUT_SAVE_OVERWRITE = 2100;
    [Token(Token = "0x400B4CD")]
    private const int PIN_OUT_SAVE_TEAM = 2101;
    [Token(Token = "0x400B4CE")]
    private const int PIN_OUT_SAVE_OVERWRITENAME_OUTPUT = 2102;
    [Token(Token = "0x400B4CF")]
    private const int PIN_OUT_SAVE_CONCEPT_SET_OVERWRITE_OUTPUT = 2103;
    [Token(Token = "0x400B4D0")]
    private const int PIN_OUT_SAVE_UNIT_SET_OVERWRITELIST = 2104;
    [Token(Token = "0x400B4D1")]
    private const int PIN_OUT_SAVE_UNIT_INVALIDSKILL_SETLIST = 2105;
    [Token(Token = "0x400B4D2")]
    private const int PIN_OUT_LEADERSKILL_CHANGE = 2200;
    [Token(Token = "0x400B4D3")]
    private const int PIN_OUT_LEAGUEMATCH_SHAM_ATK_UPDATE_FIN = 2300;
    [Token(Token = "0x400B4D4")]
    [FieldOffset(Offset = "0x2D4")]
    private readonly string PARTY_EDITOR_CLOSE;
    [Token(Token = "0x400B4D5")]
    [FieldOffset(Offset = "0x2D8")]
    private readonly string SHAM_BATTLE_OFFENSE_END;
    [Token(Token = "0x400B4D6")]
    [FieldOffset(Offset = "0x2DC")]
    [HeaderBar("▼LeagueMatch用")]
    [SerializeField]
    private SerializeValueBehaviour serializeValueBehaviour;
    [Token(Token = "0x400B4D7")]
    [FieldOffset(Offset = "0x2E0")]
    [SerializeField]
    private PartyWindow2 script;
    [Token(Token = "0x400B4D8")]
    [FieldOffset(Offset = "0x2E4")]
    [SerializeField]
    [HeaderBar("▼LeagueMatch-事前編成、攻撃事前編成用")]
    private FixedScrollablePulldown presetEditTeamPulldown;
    [Token(Token = "0x400B4D9")]
    [FieldOffset(Offset = "0x2E8")]
    [SerializeField]
    private FixedScrollablePulldown presetNotEditTeamPulldown;
    [Token(Token = "0x400B4DA")]
    [FieldOffset(Offset = "0x2EC")]
    [SerializeField]
    private UnitIcon unitIcon;
    [Token(Token = "0x400B4DB")]
    [FieldOffset(Offset = "0x2F0")]
    [SerializeField]
    private GameObject presetedit;
    [Token(Token = "0x400B4DC")]
    [FieldOffset(Offset = "0x2F4")]
    [SerializeField]
    private GameObject presetnotedit;
    [Token(Token = "0x400B4DD")]
    [FieldOffset(Offset = "0x2F8")]
    [SerializeField]
    [HeaderBar("▼LeagueMatch-模擬戦用")]
    private ExhibitList shamLeaderSkillExhibit;
    [Token(Token = "0x400B4DE")]
    [FieldOffset(Offset = "0x2FC")]
    private bool _isPinEvent;
    [Token(Token = "0x400B4DF")]
    [FieldOffset(Offset = "0x2FD")]
    private bool _isSaveTeam;
    [Token(Token = "0x400B4E0")]
    [FieldOffset(Offset = "0x2FE")]
    private bool _isSavePresetAPIOnly;
    [Token(Token = "0x400B4E1")]
    [FieldOffset(Offset = "0x300")]
    private eOverWritePartyType _overWritePartyType;
    [Token(Token = "0x400B4E2")]
    [FieldOffset(Offset = "0x304")]
    private EInvalidSkillApplyType _eInvalidSkillApplyType;
    [Token(Token = "0x400B4E3")]
    [FieldOffset(Offset = "0x308")]
    private JSON_LeagueMatchPresetPartyUnits[] _partyUnitsParams;
    [Token(Token = "0x400B4E4")]
    [FieldOffset(Offset = "0x30C")]
    private JSON_LeagueMatchParties[] _attackPartyUnitsParams;
    [Token(Token = "0x400B4E5")]
    [FieldOffset(Offset = "0x310")]
    private int _attackPartyNum;
    [Token(Token = "0x400B4E6")]
    [FieldOffset(Offset = "0x314")]
    private bool isSwapSaving;
    [Token(Token = "0x400B4E7")]
    [FieldOffset(Offset = "0x315")]
    private bool _isShamBattleAtk;
    [Token(Token = "0x400B4E8")]
    [FieldOffset(Offset = "0x316")]
    private bool isUnitSetOverwRitelist;

    [Token(Token = "0x600ACA3")]
    [Address(RVA = "0x7050D0", Offset = "0x703ED0", VA = "0x107050D0", Slot = "32")]
    public override void Activated(int pinID)
    {
    }

    [Token(Token = "0x600ACA4")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x600ACA5")]
    [Address(RVA = "0x705580", Offset = "0x704380", VA = "0x10705580", Slot = "6")]
    protected override void Init()
    {
    }

    [Token(Token = "0x600ACA6")]
    [Address(RVA = "0x708060", Offset = "0x706E60", VA = "0x10708060")]
    private void SetAPIData(SerializeValueList _valueList)
    {
    }

    [Token(Token = "0x600ACA7")]
    [Address(RVA = "0x704E10", Offset = "0x703C10", VA = "0x10704E10")]
    private void APIDataRefresh()
    {
    }

    [Token(Token = "0x600ACA8")]
    [Address(RVA = "0x705530", Offset = "0x704330", VA = "0x10705530")]
    private void Destroy()
    {
    }

    [Token(Token = "0x600ACA9")]
    [Address(RVA = "0x707170", Offset = "0x705F70", VA = "0x10707170")]
    private void RegisterClick()
    {
    }

    [Token(Token = "0x600ACAA")]
    [Address(RVA = "0x706EB0", Offset = "0x705CB0", VA = "0x10706EB0")]
    private void RegisterClickShamBattle()
    {
    }

    [Token(Token = "0x600ACAB")]
    [Address(RVA = "0x706A50", Offset = "0x705850", VA = "0x10706A50")]
    private void RecommendTeam()
    {
    }

    [Token(Token = "0x600ACAC")]
    [Address(RVA = "0x7067F0", Offset = "0x7055F0", VA = "0x107067F0")]
    private void PresetNameChange()
    {
    }

    [Token(Token = "0x600ACAD")]
    [Address(RVA = "0x705760", Offset = "0x704560", VA = "0x10705760")]
    private List<PartyEditData> LoadLeagueMatchPresets() => (List<PartyEditData>) null;

    [Token(Token = "0x600ACAE")]
    [Address(RVA = "0x708300", Offset = "0x707100", VA = "0x10708300")]
    private void SetLeaderSkillChange()
    {
    }

    [Token(Token = "0x600ACAF")]
    [Address(RVA = "0x706680", Offset = "0x705480", VA = "0x10706680")]
    private void OnPresetTeamChange(int index)
    {
    }

    [Token(Token = "0x600ACB0")]
    [Address(RVA = "0x708780", Offset = "0x707580", VA = "0x10708780")]
    private JSON_LeagueMatchSet[] SetPlacement(
      JSON_LeagueMatchSet[] paramData,
      UnitData unit,
      int slotIndex,
      bool isSwap)
    {
      return (JSON_LeagueMatchSet[]) null;
    }

    [Token(Token = "0x600ACB1")]
    [Address(RVA = "0x708C70", Offset = "0x707A70", VA = "0x10708C70", Slot = "11")]
    protected override bool TeamChangeImpl(PartyEditData party) => new bool();

    [Token(Token = "0x600ACB2")]
    [Address(RVA = "0x707730", Offset = "0x706530", VA = "0x10707730", Slot = "27")]
    protected override void SaveTeamPresets()
    {
    }

    [Token(Token = "0x600ACB3")]
    [Address(RVA = "0x7083B0", Offset = "0x7071B0", VA = "0x107083B0", Slot = "15")]
    protected override void SetPartyUnit(
      int slotIndex,
      UnitData unit,
      bool isSlotChange = true,
      bool edit_party_only = false,
      bool isSwap = false)
    {
    }

    [Token(Token = "0x600ACB4")]
    [Address(RVA = "0x7064D0", Offset = "0x7052D0", VA = "0x107064D0", Slot = "21")]
    protected override void OnForwardOrBackButtonClick(SRPG_Button button)
    {
    }

    [Token(Token = "0x600ACB5")]
    [Address(RVA = "0x7061D0", Offset = "0x704FD0", VA = "0x107061D0", Slot = "29")]
    protected override void LoadTeam(PartyWindow2.EditPartyTypes edit_party_type)
    {
    }

    [Token(Token = "0x600ACB6")]
    [Address(RVA = "0x708BD0", Offset = "0x7079D0", VA = "0x10708BD0", Slot = "28")]
    protected override void SetUnitOverWriteTeams(PartyWindow2.EditPartyTypes edit_party_type)
    {
    }

    [Token(Token = "0x600ACB7")]
    [Address(RVA = "0x708DB0", Offset = "0x707BB0", VA = "0x10708DB0", Slot = "13")]
    protected override void UpdateLeaderSkills()
    {
    }

    [Token(Token = "0x600ACB8")]
    [Address(RVA = "0x706570", Offset = "0x705370", VA = "0x10706570", Slot = "9")]
    protected override void OnNextTeamChange()
    {
    }

    [Token(Token = "0x600ACB9")]
    [Address(RVA = "0x7066B0", Offset = "0x7054B0", VA = "0x107066B0", Slot = "10")]
    protected override void OnPrevTeamChange()
    {
    }

    [Token(Token = "0x600ACBA")]
    [Address(RVA = "0x7067C0", Offset = "0x7055C0", VA = "0x107067C0", Slot = "18")]
    protected override void OnUnitSlotClick(GenericSlot slot, bool interactable)
    {
    }

    [Token(Token = "0x600ACBB")]
    [Address(RVA = "0x7064A0", Offset = "0x7052A0", VA = "0x107064A0", Slot = "19")]
    protected override void OnCardSlotClick(GenericSlot slot, bool interactable)
    {
    }

    [Token(Token = "0x600ACBC")]
    [Address(RVA = "0x707660", Offset = "0x706460", VA = "0x10707660", Slot = "34")]
    public override void Reopen(bool farceRefresh = false)
    {
    }

    [Token(Token = "0x600ACBD")]
    [Address(RVA = "0x708D30", Offset = "0x707B30", VA = "0x10708D30", Slot = "36")]
    protected override void UnitList_Show(bool isAsync = false)
    {
    }

    [Token(Token = "0x600ACBE")]
    [Address(RVA = "0x706160", Offset = "0x704F60", VA = "0x10706160", Slot = "26")]
    public override void LoadRecommendedTeamSetting()
    {
    }

    [Token(Token = "0x600ACBF")]
    [Address(RVA = "0x708D00", Offset = "0x707B00", VA = "0x10708D00", Slot = "35")]
    protected override void UnitList_Create()
    {
    }

    [Token(Token = "0x600ACC0")]
    [Address(RVA = "0x708E80", Offset = "0x707C80", VA = "0x10708E80")]
    public LeagueMatchPartyWindow()
    {
    }
  }
}

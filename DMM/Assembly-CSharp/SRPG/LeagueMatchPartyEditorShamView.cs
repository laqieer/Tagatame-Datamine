// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchPartyEditorShamView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20026A9")]
  [FlowNode.Pin(101, "ReqCopyDefense", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(102, "ReqCopyShamDefense", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(5, "Click:Sham→Defense", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(108, "ReqInvalidSkillSetList", FlowNode.PinTypes.Output, 108)]
  [FlowNode.Pin(13, "DefensePlacementSet", FlowNode.PinTypes.Input, 13)]
  [FlowNode.Pin(14, "DefenseUnitExhibitSet", FlowNode.PinTypes.Input, 14)]
  [FlowNode.Pin(15, "OpenHistory", FlowNode.PinTypes.Input, 15)]
  [FlowNode.Pin(6, "CopyClick:Sham→Defense", FlowNode.PinTypes.Input, 6)]
  [FlowNode.Pin(104, "UnitMapPlacementReq", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(107, "ReqUnitSetOverWriteList", FlowNode.PinTypes.Output, 107)]
  [FlowNode.Pin(4, "Copy:Sham→Defense", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(51, "OffenseRefresh", FlowNode.PinTypes.Input, 51)]
  [FlowNode.Pin(12, "DefensePlacementOpen", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(11, "DefenseRefresh", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(2, "EditOffense", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(1, "Init", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(201, "防衛をコピークリック", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(202, "模擬戦をコピークリック", FlowNode.PinTypes.Output, 202)]
  [FlowNode.Pin(1001, "Error", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(52, "OffenseClose", FlowNode.PinTypes.Input, 52)]
  [FlowNode.Pin(103, "UnitMapPlacementOpen", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(53, "OffenseReady", FlowNode.PinTypes.Input, 53)]
  [FlowNode.Pin(3, "Copy:Defense→Sham", FlowNode.PinTypes.Input, 3)]
  public class LeagueMatchPartyEditorShamView : MonoBehaviour, IFlowInterfaceExtend
  {
    [Token(Token = "0x400B4ED")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400B4EE")]
    private const int PIN_IN_EDIT_OFFENSE = 2;
    [Token(Token = "0x400B4EF")]
    private const int PIN_IN_COPY_DEFENSE = 3;
    [Token(Token = "0x400B4F0")]
    private const int PIN_IN_COPY_SHAM = 4;
    [Token(Token = "0x400B4F1")]
    private const int PIN_IN_CLICK_COPY_DEFENSE = 5;
    [Token(Token = "0x400B4F2")]
    private const int PIN_IN_CLICK_COPY_SHAM = 6;
    [Token(Token = "0x400B4F3")]
    private const int PIN_IN_DEFENSE_REFRESH = 11;
    [Token(Token = "0x400B4F4")]
    private const int PIN_IN_DEF_PLACEMENT_OPEN = 12;
    [Token(Token = "0x400B4F5")]
    private const int PIN_IN_DEF_PLACEMENT_SET = 13;
    [Token(Token = "0x400B4F6")]
    private const int PIN_IN_DEF_UNITEXHIBIT_SET = 14;
    [Token(Token = "0x400B4F7")]
    private const int PIN_IN_DEF_OPEN_HISTORY = 15;
    [Token(Token = "0x400B4F8")]
    private const int PIN_IN_OFFENSE_REFRESH = 51;
    [Token(Token = "0x400B4F9")]
    private const int PIN_IN_OFFENSE_CLOSE = 52;
    [Token(Token = "0x400B4FA")]
    private const int PIN_IN_OFFENSE_READY = 53;
    [Token(Token = "0x400B4FB")]
    private const int PIN_OUT_COPY_DEFENSE_DATA = 101;
    [Token(Token = "0x400B4FC")]
    private const int PIN_OUT_COPY_SHAMDEFENSE_DATA = 102;
    [Token(Token = "0x400B4FD")]
    private const int PIN_OUT_PLACEMENT_SET_OPEN = 103;
    [Token(Token = "0x400B4FE")]
    private const int PIN_OUT_PLACEMENT_SET_REQEST = 104;
    [Token(Token = "0x400B4FF")]
    private const int PIN_OUT_SAVE_OVERWRITELIST = 107;
    [Token(Token = "0x400B500")]
    private const int PIN_OUT_SAVE_UNIT_INVALIDSKILL_SETLIST = 108;
    [Token(Token = "0x400B501")]
    private const int PIN_OUT_CLICK_COPY_DEFENSE = 201;
    [Token(Token = "0x400B502")]
    private const int PIN_OUT_CLICK_COPY_SHAM = 202;
    [Token(Token = "0x400B503")]
    private const int PIN_OUT_ERROR = 1001;
    [Token(Token = "0x400B504")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SerializeValueBehaviour serializeValueBehaviour;
    [Token(Token = "0x400B505")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [HeaderBar("▼模擬戦-防衛編成")]
    private ExhibitList mMapExhibitList;
    [Token(Token = "0x400B506")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ContentExhibit mBuffContentExhibit;
    [Token(Token = "0x400B507")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SRPG_Button mOffenseEditBtn;
    [Token(Token = "0x400B508")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private SRPG_Button mUnitPlacementBtn;
    [Token(Token = "0x400B509")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SRPG_Button mApplyDeffence;
    [Token(Token = "0x400B50A")]
    [FieldOffset(Offset = "0x24")]
    [HeaderBar("▼模擬戦-防衛編成(攻撃編成時)")]
    [SerializeField]
    private GameObject mDefenseUnitTemplate;
    [Token(Token = "0x400B50B")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject mDefenseConceptCardTemplate;
    [Token(Token = "0x400B50C")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private ExhibitList mDefenseUnitLeaderSkillExhibit;
    [Token(Token = "0x400B50D")]
    [FieldOffset(Offset = "0x30")]
    [HeaderBar("▼模擬戦-攻撃編成")]
    [SerializeField]
    private Text mDefenseCombatPowerTxt;
    [Token(Token = "0x400B50E")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private SRPG_Button mBattleStartBtn;
    [Token(Token = "0x400B50F")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text mOffenseTitle;
    [Token(Token = "0x400B510")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Text mPresetName;
    [Token(Token = "0x400B511")]
    [FieldOffset(Offset = "0x40")]
    private int mSeasonId;
    [Token(Token = "0x400B512")]
    [FieldOffset(Offset = "0x44")]
    private LeagueMatchSeasonParam mSeasonParam;
    [Token(Token = "0x400B513")]
    [FieldOffset(Offset = "0x48")]
    private LeagueMatchMapModel mMapModel;
    [Token(Token = "0x400B514")]
    [FieldOffset(Offset = "0x4C")]
    private List<LeagueMatchBuffModel> mLeagueMatchBuffModels;
    [Token(Token = "0x400B515")]
    [FieldOffset(Offset = "0x50")]
    private List<ExhibitList> mDefenseUnitExhibitList;
    [Token(Token = "0x400B516")]
    [FieldOffset(Offset = "0x54")]
    private List<ConceptCardIconEx> mConceptCardIconExList;
    [Token(Token = "0x400B517")]
    [FieldOffset(Offset = "0x58")]
    private UnitLeaderSkillModel mDefenseunitLeaderSkillModel;
    [Token(Token = "0x400B518")]
    [FieldOffset(Offset = "0x5C")]
    private PartyData mOffenseShamPartyData;

    [Token(Token = "0x600ACC8")]
    [Address(RVA = "0x6FECC0", Offset = "0x6FDAC0", VA = "0x106FECC0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600ACC9")]
    [Address(RVA = "0x703DE0", Offset = "0x702BE0", VA = "0x10703DE0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600ACCA")]
    [Address(RVA = "0x6FECA0", Offset = "0x6FDAA0", VA = "0x106FECA0", Slot = "5")]
    public void Activated(int pinID, SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600ACCB")]
    [Address(RVA = "0x6FE660", Offset = "0x6FD460", VA = "0x106FE660", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600ACCC")]
    [Address(RVA = "0x703890", Offset = "0x702690", VA = "0x10703890")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600ACCD")]
    [Address(RVA = "0x701810", Offset = "0x700610", VA = "0x10701810")]
    private void DefenseRefresh()
    {
    }

    [Token(Token = "0x600ACCE")]
    [Address(RVA = "0x702050", Offset = "0x700E50", VA = "0x10702050")]
    private void DefenseViewRefresh()
    {
    }

    [Token(Token = "0x600ACCF")]
    [Address(RVA = "0x704000", Offset = "0x702E00", VA = "0x10704000")]
    private void OpenUnitMapPlacement()
    {
    }

    [Token(Token = "0x600ACD0")]
    [Address(RVA = "0x704A50", Offset = "0x703850", VA = "0x10704A50")]
    private void UnitMapPlacementDataSet(SerializeValueList valueList)
    {
    }

    [Token(Token = "0x600ACD1")]
    [Address(RVA = "0x700230", Offset = "0x6FF030", VA = "0x10700230")]
    private void ClickDefenseCopy()
    {
    }

    [Token(Token = "0x600ACD2")]
    [Address(RVA = "0x7013A0", Offset = "0x7001A0", VA = "0x107013A0")]
    private void DefenseCopyAPI()
    {
    }

    [Token(Token = "0x600ACD3")]
    [Address(RVA = "0x7002C0", Offset = "0x6FF0C0", VA = "0x107002C0")]
    private void ClickShamDefenseCopy()
    {
    }

    [Token(Token = "0x600ACD4")]
    [Address(RVA = "0x6FED00", Offset = "0x6FDB00", VA = "0x106FED00")]
    private void CheckShamDefenseCopy()
    {
    }

    [Token(Token = "0x600ACD5")]
    [Address(RVA = "0x704360", Offset = "0x703160", VA = "0x10704360")]
    private void ShamDefenseCopyAPI(
      JSON_LeagueMatchShamInfo shamDefenseInfo,
      string sendMapIname,
      UnitData[] unitList,
      JSON_LeagueMatchSet[] placement)
    {
    }

    [Token(Token = "0x600ACD6")]
    [Address(RVA = "0x700480", Offset = "0x6FF280", VA = "0x10700480")]
    private JSON_LeagueMatchShamInfo CreateCopyShamInfo(
      JSON_LeagueMatchShamInfo sham_info,
      UnitData[] units,
      string map,
      JSON_LeagueMatchSet[] placement)
    {
      return (JSON_LeagueMatchShamInfo) null;
    }

    [Token(Token = "0x600ACD7")]
    [Address(RVA = "0x700BD0", Offset = "0x6FF9D0", VA = "0x10700BD0")]
    private bool CreateDefenseFakeData(JSON_LeagueMatchShamInfo sham_info) => new bool();

    [Token(Token = "0x600ACD8")]
    [Address(RVA = "0x700600", Offset = "0x6FF400", VA = "0x10700600")]
    private bool CreateDefenseFakeBuffData(ref List<JSON_LeagueMatchBuffs> buffs) => new bool();

    [Token(Token = "0x600ACD9")]
    [Address(RVA = "0x703F40", Offset = "0x702D40", VA = "0x10703F40")]
    public void OpenHisotry()
    {
    }

    [Token(Token = "0x600ACDA")]
    [Address(RVA = "0x7024C0", Offset = "0x7012C0", VA = "0x107024C0")]
    private string GetUnitMessage(ShamCopyData shamCopyData, bool isUsed, bool isMap = false)
    {
      return (string) null;
    }

    [Token(Token = "0x600ACDB")]
    [Address(RVA = "0x7032B0", Offset = "0x7020B0", VA = "0x107032B0")]
    private void InitializeOffense()
    {
    }

    [Token(Token = "0x600ACDC")]
    [Address(RVA = "0x701930", Offset = "0x700730", VA = "0x10701930")]
    private void DefenseUnitExhibitRefresh()
    {
    }

    [Token(Token = "0x600ACDD")]
    [Address(RVA = "0x702DF0", Offset = "0x701BF0", VA = "0x10702DF0")]
    private void InitializeOffenseHistory()
    {
    }

    [Token(Token = "0x600ACDE")]
    [Address(RVA = "0x7027C0", Offset = "0x7015C0", VA = "0x107027C0")]
    private void HistoryDefenseUnitExhibitRefresh()
    {
    }

    [Token(Token = "0x600ACDF")]
    [Address(RVA = "0x700350", Offset = "0x6FF150", VA = "0x10700350")]
    private void CloseOffence()
    {
    }

    [Token(Token = "0x600ACE0")]
    [Address(RVA = "0x703BC0", Offset = "0x7029C0", VA = "0x10703BC0")]
    private void OffenseRefresh()
    {
    }

    [Token(Token = "0x600ACE1")]
    [Address(RVA = "0x6FE500", Offset = "0x6FD300", VA = "0x106FE500")]
    private void ActivateReady()
    {
    }

    [Token(Token = "0x600ACE2")]
    [Address(RVA = "0x6FF530", Offset = "0x6FE330", VA = "0x106FF530")]
    private void CheckUnitData()
    {
    }

    [Token(Token = "0x600ACE3")]
    [Address(RVA = "0x704D60", Offset = "0x703B60", VA = "0x10704D60")]
    public LeagueMatchPartyEditorShamView()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchBattleEditView
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
  [Token(Token = "0x200267A")]
  [FlowNode.Pin(3, "この編成で戦う(チェックボックス)", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(4, "事前編成呼び出し", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(31, "敵のユニットアイコンホールド", FlowNode.PinTypes.Input, 31)]
  [FlowNode.Pin(2, "画面更新", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(6, "バトル開始クリック", FlowNode.PinTypes.Input, 6)]
  [FlowNode.Pin(7, "ユニットアイコンクリック", FlowNode.PinTypes.Input, 7)]
  [FlowNode.Pin(30, "自身のユニットアイコンホールド", FlowNode.PinTypes.Input, 30)]
  [FlowNode.Pin(21, "事前編成一覧API完了", FlowNode.PinTypes.Input, 21)]
  [FlowNode.Pin(20, "敵情報取得API完了", FlowNode.PinTypes.Input, 20)]
  [FlowNode.Pin(5, "詳細確認", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(200, "ユニット詳細を表示", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(1000, "敵情報取得APIを実行", FlowNode.PinTypes.Output, 1000)]
  [FlowNode.Pin(9, "パーティ一括解散", FlowNode.PinTypes.Input, 9)]
  [FlowNode.Pin(103, "ユニットリストを表示", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(102, "詳細情報", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(1002, "攻撃編成登録APIを実行", FlowNode.PinTypes.Output, 1002)]
  [FlowNode.Pin(1003, "一括装備更新通信（独立編成用）APIを実行", FlowNode.PinTypes.Output, 1003)]
  [FlowNode.Pin(1004, "攻撃編成全解除APIを実行", FlowNode.PinTypes.Output, 1004)]
  [FlowNode.Pin(101, "編成へ", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(100, "バトル開始", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/LeagueMatch/LeagueMatchBattleEditView")]
  [FlowNode.Pin(53, "ユニットリスト閉じる", FlowNode.PinTypes.Input, 53)]
  [FlowNode.Pin(52, "直接ユニットを外す", FlowNode.PinTypes.Input, 52)]
  [FlowNode.Pin(51, "直接ユニット選択", FlowNode.PinTypes.Input, 51)]
  [FlowNode.Pin(1001, "事前編成一覧取得APIを実行", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(8, "チェックボックスreset", FlowNode.PinTypes.Input, 8)]
  public class LeagueMatchBattleEditView : MonoBehaviour, IFlowInterfaceExtend
  {
    [Token(Token = "0x400B3C0")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400B3C1")]
    private const int PIN_IN_UPDATE = 2;
    [Token(Token = "0x400B3C2")]
    private const int PIN_IN_CHECKBOX = 3;
    [Token(Token = "0x400B3C3")]
    private const int PIN_IN_PRIOR_EDIT = 4;
    [Token(Token = "0x400B3C4")]
    private const int PIN_IN_DETAIL = 5;
    [Token(Token = "0x400B3C5")]
    private const int PIN_IN_BATTLE_START_CLICK = 6;
    [Token(Token = "0x400B3C6")]
    private const int PIN_IN_UNITICON_CLICK = 7;
    [Token(Token = "0x400B3C7")]
    private const int PIN_IN_RESET_CHECKBOX = 8;
    [Token(Token = "0x400B3C8")]
    private const int PIN_IN_PARTY_RESET = 9;
    [Token(Token = "0x400B3C9")]
    private const int PIN_IN_ENEMY_API_COMPLETE = 20;
    [Token(Token = "0x400B3CA")]
    private const int PIN_IN_MATCHPARTY_API_COMPLETE = 21;
    [Token(Token = "0x400B3CB")]
    private const int PIN_IN_UNITICON_HOLD = 30;
    [Token(Token = "0x400B3CC")]
    private const int PIN_IN_ENEMY_UNITICON_HOLD = 31;
    [Token(Token = "0x400B3CD")]
    private const int PIN_IN_UNIT_SELECT = 51;
    [Token(Token = "0x400B3CE")]
    private const int PIN_IN_UNIT_REMOVE = 52;
    [Token(Token = "0x400B3CF")]
    private const int PIN_IN_UNIT_CLOSE_LIST = 53;
    [Token(Token = "0x400B3D0")]
    private const int PIN_OUT_BATTLE_START = 100;
    [Token(Token = "0x400B3D1")]
    private const int PIN_OUT_UNIT_EDIT = 101;
    [Token(Token = "0x400B3D2")]
    private const int PIN_OUT_ENEMY_DETAIL = 102;
    [Token(Token = "0x400B3D3")]
    private const int PIN_OUT_UNITLIST = 103;
    [Token(Token = "0x400B3D4")]
    private const int PIN_OUT_UNIT_TOOLTIP = 200;
    [Token(Token = "0x400B3D5")]
    private const int PIN_OUT_GET_ENEMY_API = 1000;
    [Token(Token = "0x400B3D6")]
    private const int PIN_OUT_MATCHPARTY_API = 1001;
    [Token(Token = "0x400B3D7")]
    private const int PIN_OUT_OFFENSE_ENTRY_API = 1002;
    [Token(Token = "0x400B3D8")]
    private const int PIN_OUT_SET_OVERWRITE_API = 1003;
    [Token(Token = "0x400B3D9")]
    private const int PIN_OUT_OFFENSE_RESET_ALL_API = 1004;
    [Token(Token = "0x400B3DA")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text noneText;
    [Token(Token = "0x400B3DB")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Button partyResetButton;
    [Token(Token = "0x400B3DC")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ContentExhibit playerContentExhibit;
    [Token(Token = "0x400B3DD")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ContentExhibit enemyContentExhibit;
    [Token(Token = "0x400B3DE")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private SerializeValueBehaviour serializeValueBehaviour;
    [Token(Token = "0x400B3DF")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private string UNITLIST_WINDOW_PATH;
    [Token(Token = "0x400B3E0")]
    [FieldOffset(Offset = "0x24")]
    private List<LeagueMatchBattleEditPlayerModel> _playerBattleEditPlayerModelList;
    [Token(Token = "0x400B3E1")]
    [FieldOffset(Offset = "0x28")]
    private List<LeagueMatchBattleEditEnemyModel> _enemyBattleEditModelList;
    [Token(Token = "0x400B3E2")]
    [FieldOffset(Offset = "0x2C")]
    private LeagueMatchBattleEditPlayerModel _editPlayerModel;
    [Token(Token = "0x400B3E3")]
    [FieldOffset(Offset = "0x30")]
    private UnitListWindow _unitListWindow;
    [Token(Token = "0x400B3E4")]
    [FieldOffset(Offset = "0x34")]
    private int _selectUnitSlot;
    [Token(Token = "0x400B3E5")]
    [FieldOffset(Offset = "0x38")]
    private bool _isOpenUnitEdit;
    [Token(Token = "0x400B3E6")]
    [FieldOffset(Offset = "0x39")]
    private bool _isEnemyUnitToolTip;

    [Token(Token = "0x600ABC0")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "5")]
    public void Activated(int pinID, SerializeValueList _valueList)
    {
    }

    [Token(Token = "0x600ABC1")]
    [Address(RVA = "0x6EC540", Offset = "0x6EB340", VA = "0x106EC540", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600ABC2")]
    [Address(RVA = "0x6ED100", Offset = "0x6EBF00", VA = "0x106ED100")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600ABC3")]
    [Address(RVA = "0x6EEDC0", Offset = "0x6EDBC0", VA = "0x106EEDC0")]
    private void RefreshData()
    {
    }

    [Token(Token = "0x600ABC4")]
    [Address(RVA = "0x6ECEC0", Offset = "0x6EBCC0", VA = "0x106ECEC0")]
    private void EnemyAPIComplete()
    {
    }

    [Token(Token = "0x600ABC5")]
    [Address(RVA = "0x6ED440", Offset = "0x6EC240", VA = "0x106ED440")]
    private void MatchPartyAPIComplete()
    {
    }

    [Token(Token = "0x600ABC6")]
    [Address(RVA = "0x6ED630", Offset = "0x6EC430", VA = "0x106ED630")]
    private void OnCheckBoxClick()
    {
    }

    [Token(Token = "0x600ABC7")]
    [Address(RVA = "0x6EE3C0", Offset = "0x6ED1C0", VA = "0x106EE3C0")]
    private void OnPriorEdit()
    {
    }

    [Token(Token = "0x600ABC8")]
    [Address(RVA = "0x6EDEC0", Offset = "0x6ECCC0", VA = "0x106EDEC0")]
    private void OnDetail()
    {
    }

    [Token(Token = "0x600ABC9")]
    [Address(RVA = "0x6ED460", Offset = "0x6EC260", VA = "0x106ED460")]
    private void OnBattleStart()
    {
    }

    [Token(Token = "0x600ABCA")]
    [Address(RVA = "0x6EE610", Offset = "0x6ED410", VA = "0x106EE610")]
    private void OnUnitIconClick()
    {
    }

    [Token(Token = "0x600ABCB")]
    [Address(RVA = "0x6EEB00", Offset = "0x6ED900", VA = "0x106EEB00")]
    private void OnUnitIconHold()
    {
    }

    [Token(Token = "0x600ABCC")]
    [Address(RVA = "0x6EE030", Offset = "0x6ECE30", VA = "0x106EE030")]
    private void OnEnemyUnitIconHold()
    {
    }

    [Token(Token = "0x600ABCD")]
    [Address(RVA = "0x6EFF90", Offset = "0x6EED90", VA = "0x106EFF90")]
    private void SelectUnit()
    {
    }

    [Token(Token = "0x600ABCE")]
    [Address(RVA = "0x6EF8F0", Offset = "0x6EE6F0", VA = "0x106EF8F0")]
    private void RemoveUnit()
    {
    }

    [Token(Token = "0x600ABCF")]
    [Address(RVA = "0x6ECB50", Offset = "0x6EB950", VA = "0x106ECB50")]
    private void CloseUnitList()
    {
    }

    [Token(Token = "0x600ABD0")]
    [Address(RVA = "0x6EFCB0", Offset = "0x6EEAB0", VA = "0x106EFCB0")]
    private void ResetCheckBox()
    {
    }

    [Token(Token = "0x600ABD1")]
    [Address(RVA = "0x6EFED0", Offset = "0x6EECD0", VA = "0x106EFED0")]
    private void ResetParty()
    {
    }

    [Token(Token = "0x600ABD2")]
    [Address(RVA = "0x6EF7D0", Offset = "0x6EE5D0", VA = "0x106EF7D0")]
    private void RefreshList()
    {
    }

    [Token(Token = "0x600ABD3")]
    [Address(RVA = "0x6EF7F0", Offset = "0x6EE5F0", VA = "0x106EF7F0")]
    private void RefreshPlayer()
    {
    }

    [Token(Token = "0x600ABD4")]
    [Address(RVA = "0x6EF750", Offset = "0x6EE550", VA = "0x106EF750")]
    private void RefreshEnemy()
    {
    }

    [Token(Token = "0x600ABD5")]
    [Address(RVA = "0x6F0440", Offset = "0x6EF240", VA = "0x106F0440")]
    private void SetHideData(LeagueMatchBattleEditEnemyModel model, bool isReset = false)
    {
    }

    [Token(Token = "0x600ABD6")]
    [Address(RVA = "0x6F0920", Offset = "0x6EF720", VA = "0x106F0920")]
    private void SetNoneText()
    {
    }

    [Token(Token = "0x600ABD7")]
    [Address(RVA = "0x6F1310", Offset = "0x6F0110", VA = "0x106F1310")]
    private bool UnitPartyOnlyOne_Select(UnitData selectedUnit) => new bool();

    [Token(Token = "0x600ABD8")]
    [Address(RVA = "0x6F0E30", Offset = "0x6EFC30", VA = "0x106F0E30")]
    private void SetUnitSlot(UnitData selectedUnit)
    {
    }

    [Token(Token = "0x600ABD9")]
    [Address(RVA = "0x6ECBD0", Offset = "0x6EB9D0", VA = "0x106ECBD0")]
    private void CreateUnitList()
    {
    }

    [Token(Token = "0x600ABDA")]
    [Address(RVA = "0x6ECDC0", Offset = "0x6EBBC0", VA = "0x106ECDC0")]
    private void CreateUseItemMessage(LeagueMatchBattleEditPlayerModel data)
    {
    }

    [Token(Token = "0x600ABDB")]
    [Address(RVA = "0x6F0090", Offset = "0x6EEE90", VA = "0x106F0090")]
    private void SendPartySetApi(LeagueMatchBattleEditPlayerModel data)
    {
    }

    [Token(Token = "0x600ABDC")]
    [Address(RVA = "0x6ECA60", Offset = "0x6EB860", VA = "0x106ECA60")]
    private bool ChackEquip(
      LeagueMatchBattleEditPlayerModel playerModel,
      LeagueMatchBattleEditPlayerModel oldplayerModel)
    {
      return new bool();
    }

    [Token(Token = "0x600ABDD")]
    [Address(RVA = "0x6F0C70", Offset = "0x6EFA70", VA = "0x106F0C70")]
    private void SetPartyReset()
    {
    }

    [Token(Token = "0x600ABDE")]
    [Address(RVA = "0x6EDD60", Offset = "0x6ECB60", VA = "0x106EDD60")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600ABDF")]
    [Address(RVA = "0x6F1690", Offset = "0x6F0490", VA = "0x106F1690")]
    public LeagueMatchBattleEditView()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.LeagueMatchTopView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using SRPG.Models;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20026B8")]
  [FlowNode.Pin(501, "WebViewを開く", FlowNode.PinTypes.Output, 501)]
  [AddComponentMenu("UI/LeagueMatch/LeagueMatchTopView")]
  [FlowNode.Pin(103, "防衛編成登録API", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(102, "Season報酬獲得表示", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(502, "URLを開く", FlowNode.PinTypes.Output, 502)]
  [FlowNode.Pin(100, "TIPS表示", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "勝敗集計結果表示", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(8, "バフ解除メッセージ表示判定", FlowNode.PinTypes.Input, 8)]
  [FlowNode.Pin(1, "画面更新", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(30, "ユニットアイコン長押し", FlowNode.PinTypes.Input, 30)]
  [FlowNode.Pin(2, "TOP通信API受け取り", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(5, "URLを開く", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(4, "WebViewを開く", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(6, "Season報酬表示判定", FlowNode.PinTypes.Input, 6)]
  [FlowNode.Pin(3, "報酬受け取りAPI受け取り", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(7, "前日の結果表示判定", FlowNode.PinTypes.Input, 7)]
  public class LeagueMatchTopView : MonoBehaviour, IFlowInterfaceExtend
  {
    [Token(Token = "0x400B58B")]
    private const int PIN_IN_UPDATE = 1;
    [Token(Token = "0x400B58C")]
    private const int PIN_IN_TOPDATA_REFRESH = 2;
    [Token(Token = "0x400B58D")]
    private const int PIN_IN_REWARDDATA_REFRESH = 3;
    [Token(Token = "0x400B58E")]
    private const int PIN_IN_OPEN_WEBVIEW = 4;
    [Token(Token = "0x400B58F")]
    private const int PIN_IN_OPEN_URL = 5;
    [Token(Token = "0x400B590")]
    private const int PIN_IN_SEASON_REWARD_CHECK = 6;
    [Token(Token = "0x400B591")]
    private const int PIN_IN_SEASON_RESULT_BEFORE = 7;
    [Token(Token = "0x400B592")]
    private const int PIN_IN_BUFF_RESET_MESSAGE = 8;
    [Token(Token = "0x400B593")]
    private const int PIN_IN_HOLD_UNITICON = 30;
    [Token(Token = "0x400B594")]
    private const int PIN_OUT_TIPS = 100;
    [Token(Token = "0x400B595")]
    private const int PIN_OUT_DAY_RESULT = 101;
    [Token(Token = "0x400B596")]
    private const int PIN_OUT_SEASON_REWARD = 102;
    [Token(Token = "0x400B597")]
    private const int PIN_OUT_DEFENSE_ENTRY_API = 103;
    [Token(Token = "0x400B598")]
    private const int PIN_OUT_OPEN_WEBVIEW = 501;
    [Token(Token = "0x400B599")]
    private const int PIN_OUT_OPEN_URL = 502;
    [Token(Token = "0x400B59A")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ContentExhibit contentExhibit;
    [Token(Token = "0x400B59B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ExhibitList topViweExhibitList;
    [Token(Token = "0x400B59C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private List<ExhibitList> unitExhibitList;
    [Token(Token = "0x400B59D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ExhibitList unitLeaderSkillExhibitList;
    [Token(Token = "0x400B59E")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private ExhibitList mapExhibitList;
    [Token(Token = "0x400B59F")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SerializeValueBehaviour serializeValueBehaviour;
    [Token(Token = "0x400B5A0")]
    [FieldOffset(Offset = "0x24")]
    private LeagueMatchTopModel _topViweModel;
    [Token(Token = "0x400B5A1")]
    [FieldOffset(Offset = "0x28")]
    private List<UnitModel> _unitModelList;
    [Token(Token = "0x400B5A2")]
    [FieldOffset(Offset = "0x2C")]
    private LeagueMatchMapModel _mapModel;
    [Token(Token = "0x400B5A3")]
    [FieldOffset(Offset = "0x30")]
    private List<LeagueMatchBuffModel> _buffModelList;
    [Token(Token = "0x400B5A4")]
    [FieldOffset(Offset = "0x34")]
    private UnitLeaderSkillModel _unitLeaderSkillModel;
    [Token(Token = "0x400B5A5")]
    [FieldOffset(Offset = "0x38")]
    private bool _isBuffNotUse;

    [Token(Token = "0x600AD30")]
    [Address(RVA = "0x712830", Offset = "0x711630", VA = "0x10712830")]
    private void Start()
    {
    }

    [Token(Token = "0x600AD31")]
    [Address(RVA = "0x711C60", Offset = "0x710A60", VA = "0x10711C60")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600AD32")]
    [Address(RVA = "0x710230", Offset = "0x70F030", VA = "0x10710230", Slot = "5")]
    public void Activated(int pinID, SerializeValueList _valueList)
    {
    }

    [Token(Token = "0x600AD33")]
    [Address(RVA = "0x70FE40", Offset = "0x70EC40", VA = "0x1070FE40", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AD34")]
    [Address(RVA = "0x712380", Offset = "0x711180", VA = "0x10712380")]
    private void RefreshTopData()
    {
    }

    [Token(Token = "0x600AD35")]
    [Address(RVA = "0x7102F0", Offset = "0x70F0F0", VA = "0x107102F0")]
    private void ApiReward(SerializeValueList _valueList)
    {
    }

    [Token(Token = "0x600AD36")]
    [Address(RVA = "0x711A10", Offset = "0x710810", VA = "0x10711A10")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600AD37")]
    [Address(RVA = "0x7124B0", Offset = "0x7112B0", VA = "0x107124B0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600AD38")]
    [Address(RVA = "0x711E60", Offset = "0x710C60", VA = "0x10711E60")]
    private void RefreshDate(SerializeValueList _valueList)
    {
    }

    [Token(Token = "0x600AD39")]
    [Address(RVA = "0x711D00", Offset = "0x710B00", VA = "0x10711D00")]
    private void OnUnitIconHold()
    {
    }

    [Token(Token = "0x600AD3A")]
    [Address(RVA = "0x711FE0", Offset = "0x710DE0", VA = "0x10711FE0")]
    private void RefreshDefenseData()
    {
    }

    [Token(Token = "0x600AD3B")]
    [Address(RVA = "0x712300", Offset = "0x711100", VA = "0x10712300")]
    private void RefreshList()
    {
    }

    [Token(Token = "0x600AD3C")]
    [Address(RVA = "0x712740", Offset = "0x711540", VA = "0x10712740")]
    private void SetSerializeValue()
    {
    }

    [Token(Token = "0x600AD3D")]
    [Address(RVA = "0x710DD0", Offset = "0x70FBD0", VA = "0x10710DD0")]
    private bool CreateDefenseFakeData() => new bool();

    [Token(Token = "0x600AD3E")]
    [Address(RVA = "0x7104C0", Offset = "0x70F2C0", VA = "0x107104C0")]
    private bool CreateDefenseFakeBuffData() => new bool();

    [Token(Token = "0x600AD3F")]
    [Address(RVA = "0x710390", Offset = "0x70F190", VA = "0x10710390")]
    private void CreateBuffResetMessage()
    {
    }

    [Token(Token = "0x600AD40")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public LeagueMatchTopView()
    {
    }
  }
}

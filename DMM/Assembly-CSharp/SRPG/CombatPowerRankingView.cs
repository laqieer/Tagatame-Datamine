// Decompiled with JetBrains decompiler
// Type: SRPG.CombatPowerRankingView
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
  [Token(Token = "0x20021AC")]
  [FlowNode.Pin(10, "初期化", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(11, "表示更新", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(12, "ランキング更新", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(13, "プレイヤータブ選択", FlowNode.PinTypes.Input, 13)]
  [FlowNode.Pin(14, "ポートタブ選択", FlowNode.PinTypes.Input, 14)]
  [FlowNode.Pin(16, "ユニットフィルター設定", FlowNode.PinTypes.Input, 16)]
  [FlowNode.Pin(100, "ギルドランキングを取得", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "プレイヤー別ランキングを取得", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(15, "ユニットフィルター選択", FlowNode.PinTypes.Input, 15)]
  [FlowNode.Pin(102, "ユニットフィルターを開く", FlowNode.PinTypes.Output, 102)]
  [AddComponentMenu("UI/CombatPower/CombatPowerRankingView")]
  public class CombatPowerRankingView : MonoBehaviour, IFlowInterfaceExtend
  {
    [Token(Token = "0x400934F")]
    private const string UNIT_DETAIL_INFO_BUTTON = "UNIT_DETAIL_INFO_BUTTON";
    [Token(Token = "0x4009350")]
    private const string PORT_DETAIL_INFO_BUTTON = "PORT_DETAIL_INFO_BUTTON";
    [Token(Token = "0x4009351")]
    private const string UNIT_DETAIL_INFO = "UNIT_DETAIL_INFO";
    [Token(Token = "0x4009352")]
    private const string PORT_DETAIL_INFO = "PORT_DETAIL_INFO";
    [Token(Token = "0x4009353")]
    private const int PIN_INPUT_INIT = 10;
    [Token(Token = "0x4009354")]
    private const int PIN_INPUT_REFRESH = 11;
    [Token(Token = "0x4009355")]
    private const int PIN_INPUT_SETRANK = 12;
    [Token(Token = "0x4009356")]
    private const int PIN_INPUT_SELECT_PLAYER = 13;
    [Token(Token = "0x4009357")]
    private const int PIN_INPUT_SELECT_PORT = 14;
    [Token(Token = "0x4009358")]
    private const int PIN_INPUT_UNIT_FILTER_UPDATE = 15;
    [Token(Token = "0x4009359")]
    private const int PIN_INPUT_FILTER_UNIT = 16;
    [Token(Token = "0x400935A")]
    private const int PIN_OUTPUT_REQUEST_PORT_RANKING = 100;
    [Token(Token = "0x400935B")]
    private const int PIN_OUTPUT_REQUEST_PLAYER_RANKING = 101;
    [Token(Token = "0x400935C")]
    private const int PIN_OUTPUT_FILTER_UNIT = 102;
    [Token(Token = "0x400935D")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SerializeValueBehaviour mSerializeValueBehaviour;
    [Token(Token = "0x400935E")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ContentExhibit mPlayerContentExhibit;
    [Token(Token = "0x400935F")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ContentExhibit mPortContentExhibit;
    [Token(Token = "0x4009360")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mPlayerParent;
    [Token(Token = "0x4009361")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mPortParent;
    [Token(Token = "0x4009362")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mFilterObject;
    [Token(Token = "0x4009363")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text mFilterName;
    [Token(Token = "0x4009364")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject mPlayerRankTemplate;
    [Token(Token = "0x4009365")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject mPortRankTemplate;
    [Token(Token = "0x4009366")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject mMyPlayerRankTemplate;
    [Token(Token = "0x4009367")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject mMyPlayerEmptyTemplate;
    [Token(Token = "0x4009368")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject mMyPortRankTemplate;
    [Token(Token = "0x4009369")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject mMyPortEmptyTemplate;
    [Token(Token = "0x400936A")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private SRPG_ScrollRect ScrollPlayer;
    [Token(Token = "0x400936B")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private RectTransform ScrollPlayerContent;
    [Token(Token = "0x400936C")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private SRPG_ScrollRect ScrollPort;
    [Token(Token = "0x400936D")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private RectTransform ScrollPortContent;
    [Token(Token = "0x400936E")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private CombatPowerRankingView.CombatRankingTab tabType;
    [Token(Token = "0x400936F")]
    [FieldOffset(Offset = "0x54")]
    private List<PlayerRankingModel> mPlayerRankModelList;
    [Token(Token = "0x4009370")]
    [FieldOffset(Offset = "0x58")]
    private List<PortRankingModel> mPortRankModelList;
    [Token(Token = "0x4009371")]
    [FieldOffset(Offset = "0x5C")]
    private ImageArray mFilterImage;
    [Token(Token = "0x4009372")]
    [FieldOffset(Offset = "0x60")]
    private Button mFilterButton;
    [Token(Token = "0x4009373")]
    [FieldOffset(Offset = "0x64")]
    private string mFilterUnit;
    [Token(Token = "0x4009374")]
    [FieldOffset(Offset = "0x68")]
    private SRPG_ScrollRect Scroll;
    [Token(Token = "0x4009375")]
    [FieldOffset(Offset = "0x6C")]
    private RectTransform ScrollContent;
    [Token(Token = "0x4009376")]
    [FieldOffset(Offset = "0x70")]
    private bool IsLoading;
    [Token(Token = "0x4009377")]
    [FieldOffset(Offset = "0x74")]
    private int currentPage;
    [Token(Token = "0x4009378")]
    [FieldOffset(Offset = "0x78")]
    private int currentPageMax;
    [Token(Token = "0x4009379")]
    [FieldOffset(Offset = "0x7C")]
    private int rankingMax;
    [Token(Token = "0x400937A")]
    [FieldOffset(Offset = "0x80")]
    private int fixPlayerRankingMax;
    [Token(Token = "0x400937B")]
    [FieldOffset(Offset = "0x84")]
    private int fixPortRankingMax;

    [Token(Token = "0x6008DBE")]
    [Address(RVA = "0x515EE0", Offset = "0x514CE0", VA = "0x10515EE0")]
    private void Start()
    {
    }

    [Token(Token = "0x6008DBF")]
    [Address(RVA = "0x515FB0", Offset = "0x514DB0", VA = "0x10515FB0")]
    private void Update()
    {
    }

    [Token(Token = "0x6008DC0")]
    [Address(RVA = "0x514C20", Offset = "0x513A20", VA = "0x10514C20")]
    private void Init()
    {
    }

    [Token(Token = "0x6008DC1")]
    [Address(RVA = "0x515080", Offset = "0x513E80", VA = "0x10515080")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6008DC2")]
    [Address(RVA = "0x515470", Offset = "0x514270", VA = "0x10515470")]
    private void SetPlayerRanking(SerializeValueList _valueList)
    {
    }

    [Token(Token = "0x6008DC3")]
    [Address(RVA = "0x515B30", Offset = "0x514930", VA = "0x10515B30")]
    private void SetPortRanking(SerializeValueList _valueList)
    {
    }

    [Token(Token = "0x6008DC4")]
    [Address(RVA = "0x5148D0", Offset = "0x5136D0", VA = "0x105148D0")]
    private void ClearScroll()
    {
    }

    [Token(Token = "0x6008DC5")]
    [Address(RVA = "0x515EF0", Offset = "0x514CF0", VA = "0x10515EF0")]
    private void TabChange(CombatPowerRankingView.CombatRankingTab _tab, bool isForce = false)
    {
    }

    [Token(Token = "0x6008DC6")]
    [Address(RVA = "0x514AB0", Offset = "0x5138B0", VA = "0x10514AB0")]
    private void GotoApi(CombatPowerRankingView.CombatRankingTab _tab)
    {
    }

    [Token(Token = "0x6008DC7")]
    [Address(RVA = "0x514EE0", Offset = "0x513CE0", VA = "0x10514EE0")]
    private bool IsRankingFilter() => new bool();

    [Token(Token = "0x6008DC8")]
    [Address(RVA = "0x514F10", Offset = "0x513D10", VA = "0x10514F10")]
    private bool IsRankingFilter(int _rank) => new bool();

    [Token(Token = "0x6008DC9")]
    [Address(RVA = "0x514950", Offset = "0x513750", VA = "0x10514950")]
    private void Draw()
    {
    }

    [Token(Token = "0x6008DCA")]
    [Address(RVA = "0x514F40", Offset = "0x513D40", VA = "0x10514F40")]
    private void PlayerInfoDetail(ContentNode _node, PlayerRankingModel _model)
    {
    }

    [Token(Token = "0x6008DCB")]
    [Address(RVA = "0x514FE0", Offset = "0x513DE0", VA = "0x10514FE0")]
    private void PortInfoDetail(ContentNode _node, PortRankingModel _model)
    {
    }

    [Token(Token = "0x6008DCC")]
    [Address(RVA = "0x514590", Offset = "0x513390", VA = "0x10514590", Slot = "5")]
    public void Activated(int pinID, SerializeValueList _valueList)
    {
    }

    [Token(Token = "0x6008DCD")]
    [Address(RVA = "0x514780", Offset = "0x513580", VA = "0x10514780", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008DCE")]
    [Address(RVA = "0x5160C0", Offset = "0x514EC0", VA = "0x105160C0")]
    public CombatPowerRankingView()
    {
    }

    [Token(Token = "0x20021AD")]
    public enum CombatRankingTab
    {
      [Token(Token = "0x400937D")] Player,
      [Token(Token = "0x400937E")] Port,
    }
  }
}

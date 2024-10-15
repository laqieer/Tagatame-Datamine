// Decompiled with JetBrains decompiler
// Type: SRPG.Models.LeagueMatchHistoryView
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG.Models
{
  [Token(Token = "0x200335C")]
  [FlowNode.Pin(102, "ReqPageChange", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(2, "情報更新", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(3, "SelectDetail", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(10, "PagePrev", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(11, "PageNext", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(12, "Close", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(101, "ViewDetail", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(1, "Init", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(104, "PageInputOff", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(1001, "Error", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(103, "PageChangeFin", FlowNode.PinTypes.Output, 103)]
  public class LeagueMatchHistoryView : MonoBehaviour, IFlowInterfaceExtend
  {
    [Token(Token = "0x400F28A")]
    private const string LEAGUEMATCH_HISTORY_DETAIL = "LEAGUEMATCH_HISTORY_DETAIL";
    [Token(Token = "0x400F28B")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x400F28C")]
    private const int PIN_IN_UPDATE_DATA = 2;
    [Token(Token = "0x400F28D")]
    private const int PIN_IN_SELECT_DETAIL = 3;
    [Token(Token = "0x400F28E")]
    private const int PIN_IN_SELECT_PAGE_PREV = 10;
    [Token(Token = "0x400F28F")]
    private const int PIN_IN_SELECT_PAGE_NEXT = 11;
    [Token(Token = "0x400F290")]
    private const int PIN_IN_SELECT_CLOSE = 12;
    [Token(Token = "0x400F291")]
    private const int PIN_OUT_VIEW_DETAIL = 101;
    [Token(Token = "0x400F292")]
    private const int PIN_OUT_REQ_PAGE_CHANGE = 102;
    [Token(Token = "0x400F293")]
    private const int PIN_OUT_PAGE_CHANGE_FIN = 103;
    [Token(Token = "0x400F294")]
    private const int PIN_OUT_PAGE_INPUT_OFF = 104;
    [Token(Token = "0x400F295")]
    private const int PIN_OUT_ERROR = 1001;
    [Token(Token = "0x400F296")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SerializeValueBehaviour serializeValueBehaviour;
    [Token(Token = "0x400F297")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private ContentExhibit mContentExhibit;
    [Token(Token = "0x400F298")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mSubTitleText;
    [Token(Token = "0x400F299")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SRPG_Button[] mPaginationBtns;
    [Token(Token = "0x400F29A")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private SRPG_Button mPagePrevBtn;
    [Token(Token = "0x400F29B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private SRPG_Button mPageNextBtn;
    [Token(Token = "0x400F29C")]
    [FieldOffset(Offset = "0x24")]
    private List<LeagueMatchHistoryModel> mModels;
    [Token(Token = "0x400F29D")]
    [FieldOffset(Offset = "0x28")]
    private int mCurrentPage;
    [Token(Token = "0x400F29E")]
    [FieldOffset(Offset = "0x2C")]
    private LeagueMatchManager mLeagueMatchManager;

    [Token(Token = "0x600E38E")]
    [Address(RVA = "0xAB66C0", Offset = "0xAB54C0", VA = "0x10AB66C0", Slot = "5")]
    public void Activated(int pinID, SerializeValueList _valueList)
    {
    }

    [Token(Token = "0x600E38F")]
    [Address(RVA = "0xAB6820", Offset = "0xAB5620", VA = "0x10AB6820", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600E390")]
    [Address(RVA = "0xAB6CF0", Offset = "0xAB5AF0", VA = "0x10AB6CF0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x600E391")]
    [Address(RVA = "0xAB7190", Offset = "0xAB5F90", VA = "0x10AB7190")]
    private void RefreshData(SerializeValueList _valueList)
    {
    }

    [Token(Token = "0x600E392")]
    [Address(RVA = "0xAB72E0", Offset = "0xAB60E0", VA = "0x10AB72E0")]
    private void Refresh(JSON_LeagueMatchHistory[] histories)
    {
    }

    [Token(Token = "0x600E393")]
    [Address(RVA = "0xAB76F0", Offset = "0xAB64F0", VA = "0x10AB76F0")]
    private void SetData(ContentNode node, LeagueMatchHistoryModel model)
    {
    }

    [Token(Token = "0x600E394")]
    [Address(RVA = "0xAB77F0", Offset = "0xAB65F0", VA = "0x10AB77F0")]
    private void SetPaginatinoButton()
    {
    }

    [Token(Token = "0x600E395")]
    [Address(RVA = "0xAB7600", Offset = "0xAB6400", VA = "0x10AB7600")]
    private void SelectPagination(int page_num)
    {
    }

    [Token(Token = "0x600E396")]
    [Address(RVA = "0xAB7490", Offset = "0xAB6290", VA = "0x10AB7490")]
    private void SelectDetail()
    {
    }

    [Token(Token = "0x600E397")]
    [Address(RVA = "0xAB6C10", Offset = "0xAB5A10", VA = "0x10AB6C10")]
    private void CloseHisotry()
    {
    }

    [Token(Token = "0x600E398")]
    [Address(RVA = "0xAB6AD0", Offset = "0xAB58D0", VA = "0x10AB6AD0")]
    private List<int> CalcPaginationNumber(
      int current,
      int btn_num,
      int max_page,
      bool is_first_last = false)
    {
      return (List<int>) null;
    }

    [Token(Token = "0x600E399")]
    [Address(RVA = "0xAB7E30", Offset = "0xAB6C30", VA = "0x10AB7E30")]
    public LeagueMatchHistoryView()
    {
    }
  }
}

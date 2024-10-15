// Decompiled with JetBrains decompiler
// Type: SRPG.MailWindow
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
  [Token(Token = "0x2002701")]
  [FlowNode.Pin(14, "再初期化", FlowNode.PinTypes.Input, 103)]
  [AddComponentMenu("UI/MailWindow")]
  [FlowNode.Pin(501, "念装選択アイテムで所持上限オーバー", FlowNode.PinTypes.Output, 501)]
  [FlowNode.Pin(50, "初期化終了(未読あり)", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(500, "武具選択アイテムで所持上限オーバー", FlowNode.PinTypes.Output, 500)]
  [FlowNode.Pin(51, "初期化終了(未読なし)", FlowNode.PinTypes.Output, 3)]
  [FlowNode.Pin(303, "念装選択アイテム", FlowNode.PinTypes.Output, 203)]
  [FlowNode.Pin(2, "期限なし", FlowNode.PinTypes.Input, 52)]
  [FlowNode.Pin(3, "期限あり", FlowNode.PinTypes.Input, 53)]
  [FlowNode.Pin(302, "武具選択アイテム", FlowNode.PinTypes.Output, 202)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(4, "開封済み", FlowNode.PinTypes.Input, 54)]
  [FlowNode.Pin(13, "次の頁", FlowNode.PinTypes.Input, 56)]
  [FlowNode.Pin(52, "メールリスト更新", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(301, "アイテム選択アイテム", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(300, "ユニット選択アイテム", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(60, "開封", FlowNode.PinTypes.Output, 106)]
  [FlowNode.Pin(11, "現在の頁更新", FlowNode.PinTypes.Input, 101)]
  [FlowNode.Pin(200, "ページ取得", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(30, "一件開封", FlowNode.PinTypes.Input, 104)]
  [FlowNode.Pin(12, "前の頁", FlowNode.PinTypes.Input, 55)]
  [FlowNode.Pin(31, "頁内開封", FlowNode.PinTypes.Input, 105)]
  public class MailWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400B7C9")]
    private const int PIN_ID_INITIALIZE = 1;
    [Token(Token = "0x400B7CA")]
    private const int PIN_ID_TAB_NOT_PERIOD = 2;
    [Token(Token = "0x400B7CB")]
    private const int PIN_ID_TAB_PERIOD = 3;
    [Token(Token = "0x400B7CC")]
    private const int PIN_ID_TAB_READ = 4;
    [Token(Token = "0x400B7CD")]
    private const int PIN_ID_CURRENT_PAGE = 11;
    [Token(Token = "0x400B7CE")]
    private const int PIN_ID_PREV_PAGE = 12;
    [Token(Token = "0x400B7CF")]
    private const int PIN_ID_NEXT_PAGE = 13;
    [Token(Token = "0x400B7D0")]
    private const int PIN_ID_REFRESH = 14;
    [Token(Token = "0x400B7D1")]
    private const int PIN_ID_READ = 30;
    [Token(Token = "0x400B7D2")]
    private const int PIN_ID_READ_PAGE = 31;
    [Token(Token = "0x400B7D3")]
    private const int PIN_ID_INITIALIZED = 50;
    [Token(Token = "0x400B7D4")]
    private const int PIN_ID_INITIALIZED_EMPTY = 51;
    [Token(Token = "0x400B7D5")]
    private const int PIN_ID_SUCCESS = 52;
    [Token(Token = "0x400B7D6")]
    private const int PIN_ID_REQUEST_READ = 60;
    [Token(Token = "0x400B7D7")]
    private const int PIN_ID_REQUEST_PAGE = 200;
    [Token(Token = "0x400B7D8")]
    private const int PIN_ID_UNIT_SELECT = 300;
    [Token(Token = "0x400B7D9")]
    private const int PIN_ID_ITEM_SELECT = 301;
    [Token(Token = "0x400B7DA")]
    private const int PIN_ID_ARTIFACT_SELECT = 302;
    [Token(Token = "0x400B7DB")]
    private const int PIN_ID_CONCEPT_CARD_SELECT = 303;
    [Token(Token = "0x400B7DC")]
    private const int PIN_ID_ARTIFACT_OVER = 500;
    [Token(Token = "0x400B7DD")]
    private const int PIN_ID_CONCEPT_CARD_OVER = 501;
    [Token(Token = "0x400B7DE")]
    [FieldOffset(Offset = "0xC")]
    private MailWindow.TabData notPeriodTab;
    [Token(Token = "0x400B7DF")]
    [FieldOffset(Offset = "0x10")]
    private MailWindow.TabData periodTab;
    [Token(Token = "0x400B7E0")]
    [FieldOffset(Offset = "0x14")]
    private MailWindow.TabData readTab;
    [Token(Token = "0x400B7E1")]
    [FieldOffset(Offset = "0x18")]
    private MailWindow.TabType currentTab;
    [Token(Token = "0x400B7E2")]
    [FieldOffset(Offset = "0x19")]
    [SerializeField]
    private MailWindow.TabType startTab;
    [Token(Token = "0x400B7E3")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private BitmapText currentPageText;
    [Token(Token = "0x400B7E4")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private BitmapText maxPageText;
    [Token(Token = "0x400B7E5")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject readAllButton;
    [Token(Token = "0x400B7E6")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ScrollRect scrollRect;
    [Token(Token = "0x400B7E7")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Button prevPageButton;
    [Token(Token = "0x400B7E8")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button nextPageButton;
    [Token(Token = "0x400B7E9")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject flowParent;
    [Token(Token = "0x400B7EA")]
    [FieldOffset(Offset = "0x38")]
    private int m_ConceptCardNum;

    [Token(Token = "0x600AED6")]
    [Address(RVA = "0x733F50", Offset = "0x732D50", VA = "0x10733F50")]
    private void Start()
    {
    }

    [Token(Token = "0x600AED7")]
    [Address(RVA = "0x733E40", Offset = "0x732C40", VA = "0x10733E40")]
    private void SetMailRequestData(int page, bool isPeriod, bool isRead)
    {
    }

    [Token(Token = "0x600AED8")]
    [Address(RVA = "0x733EC0", Offset = "0x732CC0", VA = "0x10733EC0")]
    private void SetReadRequestData(int page, bool isPeriod, long[] mailIDs)
    {
    }

    [Token(Token = "0x600AED9")]
    [Address(RVA = "0x5DD920", Offset = "0x5DC720", VA = "0x105DD920")]
    private void ActivateOutputLinks(int pinID)
    {
    }

    [Token(Token = "0x600AEDA")]
    [Address(RVA = "0x733A20", Offset = "0x732820", VA = "0x10733A20")]
    private void LateActivateOutputLinks(int pinID)
    {
    }

    [Token(Token = "0x600AEDB")]
    [Address(RVA = "0x733980", Offset = "0x732780", VA = "0x10733980")]
    private IEnumerator CoroutineActivateOutputLinks(int pinID) => (IEnumerator) null;

    [Token(Token = "0x600AEDC")]
    [Address(RVA = "0x732D80", Offset = "0x731B80", VA = "0x10732D80", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600AEDD")]
    [Address(RVA = "0x734060", Offset = "0x732E60", VA = "0x10734060")]
    private void UpdateUI()
    {
    }

    [Token(Token = "0x600AEDE")]
    [Address(RVA = "0x733DF0", Offset = "0x732BF0", VA = "0x10733DF0")]
    private void RequestRead(long[] mailIDs)
    {
    }

    [Token(Token = "0x600AEDF")]
    [Address(RVA = "0x733C30", Offset = "0x732A30", VA = "0x10733C30")]
    private void RequestCurrentMails()
    {
    }

    [Token(Token = "0x600AEE0")]
    [Address(RVA = "0x733CB0", Offset = "0x732AB0", VA = "0x10733CB0")]
    private void RequestNextMails()
    {
    }

    [Token(Token = "0x600AEE1")]
    [Address(RVA = "0x733D50", Offset = "0x732B50", VA = "0x10733D50")]
    private void RequestPrevMails()
    {
    }

    [Token(Token = "0x600AEE2")]
    [Address(RVA = "0x733FB0", Offset = "0x732DB0", VA = "0x10733FB0")]
    public void TabChange(MailWindow.TabType tabType)
    {
    }

    [Token(Token = "0x600AEE3")]
    [Address(RVA = "0x7339F0", Offset = "0x7327F0", VA = "0x107339F0")]
    private MailWindow.TabData GetTab(MailWindow.TabType tabType) => (MailWindow.TabData) null;

    [Token(Token = "0x17001831")]
    private MailWindow.TabData currentTabData
    {
      [Token(Token = "0x600AEE4"), Address(RVA = "0x7344C0", Offset = "0x7332C0", VA = "0x107344C0")] get
      {
        return (MailWindow.TabData) null;
      }
    }

    [Token(Token = "0x600AEE5")]
    [Address(RVA = "0x733A90", Offset = "0x732890", VA = "0x10733A90")]
    private bool NexePage() => new bool();

    [Token(Token = "0x600AEE6")]
    [Address(RVA = "0x733AB0", Offset = "0x7328B0", VA = "0x10733AB0")]
    private bool PrevPage() => new bool();

    [Token(Token = "0x600AEE7")]
    [Address(RVA = "0x7338D0", Offset = "0x7326D0", VA = "0x107338D0")]
    private bool AddPage(int addValue) => new bool();

    [Token(Token = "0x600AEE8")]
    [Address(RVA = "0x733AD0", Offset = "0x7328D0", VA = "0x10733AD0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600AEE9")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public MailWindow()
    {
    }

    [Token(Token = "0x2002702")]
    public enum TabType : byte
    {
      [Token(Token = "0x400B7EC")] NotPeriod,
      [Token(Token = "0x400B7ED")] Period,
      [Token(Token = "0x400B7EE")] Read,
    }

    [Token(Token = "0x2002703")]
    internal class TabData
    {
      [Token(Token = "0x400B7EF")]
      [FieldOffset(Offset = "0x8")]
      internal List<MailPageData> pageDataList;
      [Token(Token = "0x400B7F0")]
      [FieldOffset(Offset = "0xC")]
      internal int currentPage;
      [Token(Token = "0x400B7F1")]
      [FieldOffset(Offset = "0x10")]
      internal int pageMax;
      [Token(Token = "0x400B7F2")]
      [FieldOffset(Offset = "0x14")]
      internal int mailCount;
      [Token(Token = "0x400B7F3")]
      [FieldOffset(Offset = "0x18")]
      internal MailWindow.TabType tabType;

      [Token(Token = "0x17001832")]
      internal bool currentPageIsReady
      {
        [Token(Token = "0x600AEEA"), Address(RVA = "0x73B130", Offset = "0x739F30", VA = "0x1073B130")] get
        {
          return new bool();
        }
      }

      [Token(Token = "0x17001833")]
      internal MailPageData currentPageData
      {
        [Token(Token = "0x600AEEB"), Address(RVA = "0x73B110", Offset = "0x739F10", VA = "0x1073B110")] get
        {
          return (MailPageData) null;
        }
      }

      [Token(Token = "0x600AEEC")]
      [Address(RVA = "0x73AFC0", Offset = "0x739DC0", VA = "0x1073AFC0")]
      internal bool SetPage(MailPageData mailPageData) => new bool();

      [Token(Token = "0x600AEED")]
      [Address(RVA = "0x73ADD0", Offset = "0x739BD0", VA = "0x1073ADD0")]
      internal void Clear()
      {
      }

      [Token(Token = "0x600AEEE")]
      [Address(RVA = "0x73AF30", Offset = "0x739D30", VA = "0x1073AF30")]
      internal bool HasPrev() => new bool();

      [Token(Token = "0x600AEEF")]
      [Address(RVA = "0x73AF00", Offset = "0x739D00", VA = "0x1073AF00")]
      internal bool HasNext() => new bool();

      [Token(Token = "0x600AEF0")]
      [Address(RVA = "0x73AF90", Offset = "0x739D90", VA = "0x1073AF90")]
      internal MailPageData PrevPageData() => (MailPageData) null;

      [Token(Token = "0x600AEF1")]
      [Address(RVA = "0x73AF60", Offset = "0x739D60", VA = "0x1073AF60")]
      internal MailPageData NextPageData() => (MailPageData) null;

      [Token(Token = "0x600AEF2")]
      [Address(RVA = "0x73AE50", Offset = "0x739C50", VA = "0x1073AE50")]
      internal MailPageData GetPageData(int page) => (MailPageData) null;

      [Token(Token = "0x600AEF3")]
      [Address(RVA = "0x73B0F0", Offset = "0x739EF0", VA = "0x1073B0F0")]
      public TabData()
      {
      }
    }

    [Token(Token = "0x2002706")]
    public class MailPageRequestData
    {
      [Token(Token = "0x400B7F6")]
      [FieldOffset(Offset = "0x8")]
      public int page;
      [Token(Token = "0x400B7F7")]
      [FieldOffset(Offset = "0xC")]
      public bool isRead;
      [Token(Token = "0x400B7F8")]
      [FieldOffset(Offset = "0xD")]
      public bool isPeriod;

      [Token(Token = "0x600AEF8")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public MailPageRequestData()
      {
      }
    }

    [Token(Token = "0x2002707")]
    public class MailReadRequestData
    {
      [Token(Token = "0x400B7F9")]
      [FieldOffset(Offset = "0x8")]
      public long[] mailIDs;
      [Token(Token = "0x400B7FA")]
      [FieldOffset(Offset = "0xC")]
      public int page;
      [Token(Token = "0x400B7FB")]
      [FieldOffset(Offset = "0x10")]
      public bool isPeriod;

      [Token(Token = "0x600AEF9")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public MailReadRequestData()
      {
      }
    }
  }
}

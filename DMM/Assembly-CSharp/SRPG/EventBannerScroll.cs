// Decompiled with JetBrains decompiler
// Type: SRPG.EventBannerScroll
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002361")]
  [FlowNode.Pin(63, "ToGuild", FlowNode.PinTypes.Output, 19)]
  [FlowNode.Pin(50, "ToStory", FlowNode.PinTypes.Output, 6)]
  [FlowNode.Pin(51, "ToEvent", FlowNode.PinTypes.Output, 7)]
  [FlowNode.Pin(55, "ToMulti", FlowNode.PinTypes.Output, 8)]
  [FlowNode.Pin(52, "ToShop", FlowNode.PinTypes.Output, 9)]
  [FlowNode.Pin(53, "ToGacha", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(54, "ToURL", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(12, "Select", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(56, "ToArena", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(58, "ToOrdeal", FlowNode.PinTypes.Output, 14)]
  [FlowNode.Pin(59, "ToBeginner", FlowNode.PinTypes.Output, 15)]
  [FlowNode.Pin(60, "ToAdvanceEvent", FlowNode.PinTypes.Output, 16)]
  [FlowNode.Pin(61, "ToGenesisEvent", FlowNode.PinTypes.Output, 17)]
  [FlowNode.Pin(62, "ToGenesisEventTop", FlowNode.PinTypes.Output, 18)]
  [FlowNode.Pin(64, "ToPointQuest", FlowNode.PinTypes.Output, 20)]
  [FlowNode.Pin(101, "SceneChange", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(110, "Select(ポップアップ開く)", FlowNode.PinTypes.Input, 110)]
  [FlowNode.Pin(111, "Selected(ポップアップ開く)", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(57, "ToPVP", FlowNode.PinTypes.Output, 13)]
  [FlowNode.Pin(11, "PagePrev", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(10, "PageNext", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(49, "ItemEmpty", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(48, "Refreshed", FlowNode.PinTypes.Output, 1)]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 0)]
  public class EventBannerScroll : SRPG_ScrollRect, IFlowInterface
  {
    [Token(Token = "0x4009E91")]
    private const int PIN_REFRESH = 1;
    [Token(Token = "0x4009E92")]
    private const int PIN_PAGE_NEXT = 10;
    [Token(Token = "0x4009E93")]
    private const int PIN_PAGE_PREV = 11;
    [Token(Token = "0x4009E94")]
    private const int PIN_SELECT = 12;
    [Token(Token = "0x4009E95")]
    private const int PIN_REFRESHED = 48;
    [Token(Token = "0x4009E96")]
    private const int PIN_EMPTY = 49;
    [Token(Token = "0x4009E97")]
    private const int PIN_TO_STORY = 50;
    [Token(Token = "0x4009E98")]
    private const int PIN_TO_EVENT = 51;
    [Token(Token = "0x4009E99")]
    private const int PIN_TO_SHOP = 52;
    [Token(Token = "0x4009E9A")]
    private const int PIN_TO_GACHA = 53;
    [Token(Token = "0x4009E9B")]
    private const int PIN_TO_URL = 54;
    [Token(Token = "0x4009E9C")]
    private const int PIN_TO_MULTI = 55;
    [Token(Token = "0x4009E9D")]
    private const int PIN_TO_ARENA = 56;
    [Token(Token = "0x4009E9E")]
    private const int PIN_TO_PVP = 57;
    [Token(Token = "0x4009E9F")]
    private const int PIN_TO_ORDEAL = 58;
    [Token(Token = "0x4009EA0")]
    private const int PIN_TO_BEGINNER = 59;
    [Token(Token = "0x4009EA1")]
    private const int PIN_TO_ADVANCE = 60;
    [Token(Token = "0x4009EA2")]
    private const int PIN_TO_GENESIS = 61;
    [Token(Token = "0x4009EA3")]
    private const int PIN_TO_GENESIS_TOP = 62;
    [Token(Token = "0x4009EA4")]
    private const int PIN_TO_GUILD = 63;
    [Token(Token = "0x4009EA5")]
    private const int PIN_TO_POINTQUEST = 64;
    [Token(Token = "0x4009EA6")]
    private const int PIN_OUT_SCENE_CHANGE = 101;
    [Token(Token = "0x4009EA7")]
    private const int PIN_OPEN_POPUP = 110;
    [Token(Token = "0x4009EA8")]
    private const int PIN_OUT_OPEN_POPUP = 111;
    [Token(Token = "0x4009EA9")]
    private const string BannerPathOfNormals = "Banners/";
    [Token(Token = "0x4009EAA")]
    private const string BannerPathOfShop = "LimitedShopBanner/";
    [Token(Token = "0x4009EAB")]
    [FieldOffset(Offset = "0x124")]
    public ToggleGroup PageToggleGroup;
    [Token(Token = "0x4009EAC")]
    [FieldOffset(Offset = "0x128")]
    public GameObject TemplateBannerNormal;
    [Token(Token = "0x4009EAD")]
    [FieldOffset(Offset = "0x12C")]
    public GameObject TemplateBannerShop;
    [Token(Token = "0x4009EAE")]
    [FieldOffset(Offset = "0x130")]
    public GameObject TemplatePageIcon;
    [Token(Token = "0x4009EAF")]
    [FieldOffset(Offset = "0x134")]
    public float Interval;
    [Token(Token = "0x4009EB0")]
    [FieldOffset(Offset = "0x138")]
    private bool mDragging;
    [Token(Token = "0x4009EB1")]
    [FieldOffset(Offset = "0x13C")]
    private int mPage;
    [Token(Token = "0x4009EB2")]
    [FieldOffset(Offset = "0x140")]
    private float mElapsed;
    [Token(Token = "0x4009EB3")]
    [FieldOffset(Offset = "0x144")]
    private IEnumerator mMove;

    [Token(Token = "0x17001548")]
    private int PageCount
    {
      [Token(Token = "0x6009880"), Address(RVA = "0x5B2820", Offset = "0x5B1620", VA = "0x105B2820")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001549")]
    private int PageNow
    {
      [Token(Token = "0x6009881"), Address(RVA = "0x5B2840", Offset = "0x5B1640", VA = "0x105B2840")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6009882")]
    [Address(RVA = "0x5B0E90", Offset = "0x5AFC90", VA = "0x105B0E90", Slot = "61")]
    private void IFlowInterface\u002EActivated(int pinID)
    {
    }

    [Token(Token = "0x6009883")]
    [Address(RVA = "0x5B2350", Offset = "0x5B1150", VA = "0x105B2350")]
    private void SendLogBannerName(string banr_sprite)
    {
    }

    [Token(Token = "0x6009884")]
    [Address(RVA = "0x5B2420", Offset = "0x5B1220", VA = "0x105B2420", Slot = "6")]
    protected override void Start()
    {
    }

    [Token(Token = "0x6009885")]
    [Address(RVA = "0x5B1DF0", Offset = "0x5B0BF0", VA = "0x105B1DF0", Slot = "44")]
    public override void OnBeginDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6009886")]
    [Address(RVA = "0x5B1E20", Offset = "0x5B0C20", VA = "0x105B1E20", Slot = "45")]
    public override void OnEndDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6009887")]
    [Address(RVA = "0x5B24C0", Offset = "0x5B12C0", VA = "0x105B24C0")]
    private void Update()
    {
    }

    [Token(Token = "0x6009888")]
    [Address(RVA = "0x5B1A80", Offset = "0x5B0880", VA = "0x105B1A80", Slot = "48")]
    protected override void LateUpdate()
    {
    }

    [Token(Token = "0x6009889")]
    [Address(RVA = "0x5B1F60", Offset = "0x5B0D60", VA = "0x105B1F60")]
    private bool Refresh() => new bool();

    [Token(Token = "0x600988A")]
    [Address(RVA = "0x5B2850", Offset = "0x5B1650", VA = "0x105B2850")]
    private BannerParam[] makeValidBannerParams() => (BannerParam[]) null;

    [Token(Token = "0x600988B")]
    [Address(RVA = "0x5B3120", Offset = "0x5B1F20", VA = "0x105B3120")]
    private IEnumerator movePage(int from, int to) => (IEnumerator) null;

    [Token(Token = "0x600988C")]
    [Address(RVA = "0x5B1E40", Offset = "0x5B0C40", VA = "0x105B1E40")]
    private void OnValueChanged(Vector2 value)
    {
    }

    [Token(Token = "0x600988D")]
    [Address(RVA = "0x5B3190", Offset = "0x5B1F90", VA = "0x105B3190")]
    private void onPageChanged(int page)
    {
    }

    [Token(Token = "0x600988E")]
    [Address(RVA = "0x5B2680", Offset = "0x5B1480", VA = "0x105B2680")]
    private float getPageOffset(int page) => new float();

    [Token(Token = "0x600988F")]
    [Address(RVA = "0x5B25B0", Offset = "0x5B13B0", VA = "0x105B25B0")]
    private BannerParam getCurrentPageBannerParam() => (BannerParam) null;

    [Token(Token = "0x6009890")]
    [Address(RVA = "0x5B2580", Offset = "0x5B1380", VA = "0x105B2580")]
    private float decelerate(float value) => new float();

    [Token(Token = "0x6009891")]
    [Address(RVA = "0x5B3230", Offset = "0x5B2030", VA = "0x105B3230")]
    private bool setQuestVariables(string questId, bool story) => new bool();

    [Token(Token = "0x6009892")]
    [Address(RVA = "0x5B2560", Offset = "0x5B1360", VA = "0x105B2560")]
    public EventBannerScroll()
    {
    }
  }
}

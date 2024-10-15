// Decompiled with JetBrains decompiler
// Type: SRPG.EventPopup
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
  [Token(Token = "0x200236F")]
  [FlowNode.Pin(55, "ToURL", FlowNode.PinTypes.Output, 6)]
  [FlowNode.Pin(51, "ToEvent", FlowNode.PinTypes.Output, 2)]
  [FlowNode.Pin(52, "ToMulti", FlowNode.PinTypes.Output, 3)]
  [AddComponentMenu("UI/EventPopup")]
  [FlowNode.Pin(65, "ToPointQuestList", FlowNode.PinTypes.Output, 16)]
  [FlowNode.Pin(64, "ToPointQuest", FlowNode.PinTypes.Output, 15)]
  [FlowNode.Pin(63, "ToGuild", FlowNode.PinTypes.Output, 14)]
  [FlowNode.Pin(54, "ToGacha", FlowNode.PinTypes.Output, 5)]
  [FlowNode.Pin(100, "Select", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(61, "ToGenesis", FlowNode.PinTypes.Output, 12)]
  [FlowNode.Pin(60, "ToAdvance", FlowNode.PinTypes.Output, 11)]
  [FlowNode.Pin(53, "ToShop", FlowNode.PinTypes.Output, 4)]
  [FlowNode.Pin(58, "ToOrdeal", FlowNode.PinTypes.Output, 9)]
  [FlowNode.Pin(57, "ToPVP", FlowNode.PinTypes.Output, 8)]
  [FlowNode.Pin(56, "ToArena", FlowNode.PinTypes.Output, 7)]
  [FlowNode.Pin(62, "ToGenesisTop", FlowNode.PinTypes.Output, 13)]
  [FlowNode.Pin(59, "ToBeginner", FlowNode.PinTypes.Output, 10)]
  [FlowNode.Pin(50, "ToStory", FlowNode.PinTypes.Output, 1)]
  public class EventPopup : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009F33")]
    public const int INPUT_BANNER_SELECT = 100;
    [Token(Token = "0x4009F34")]
    public const int OUTPUT_BANNER_TO_STORY = 50;
    [Token(Token = "0x4009F35")]
    public const int OUTPUT_BANNER_TO_EVENT = 51;
    [Token(Token = "0x4009F36")]
    public const int OUTPUT_BANNER_TO_MULTI = 52;
    [Token(Token = "0x4009F37")]
    public const int OUTPUT_BANNER_TO_SHOP = 53;
    [Token(Token = "0x4009F38")]
    public const int OUTPUT_BANNER_TO_GACHA = 54;
    [Token(Token = "0x4009F39")]
    public const int OUTPUT_BANNER_TO_URL = 55;
    [Token(Token = "0x4009F3A")]
    public const int OUTPUT_BANNER_TO_ARENA = 56;
    [Token(Token = "0x4009F3B")]
    public const int OUTPUT_BANNER_TO_PVP = 57;
    [Token(Token = "0x4009F3C")]
    public const int OUTPUT_BANNER_TO_ORDEAL = 58;
    [Token(Token = "0x4009F3D")]
    public const int OUTPUT_BANNER_TO_BEGINNER = 59;
    [Token(Token = "0x4009F3E")]
    public const int OUTPUT_BANNER_TO_ADVANCE = 60;
    [Token(Token = "0x4009F3F")]
    public const int OUTPUT_BANNER_TO_GENESIS = 61;
    [Token(Token = "0x4009F40")]
    public const int OUTPUT_BANNER_TO_GENESIS_TOP = 62;
    [Token(Token = "0x4009F41")]
    public const int OUTPUT_BANNER_TO_GUILD_TOP = 63;
    [Token(Token = "0x4009F42")]
    public const int OUTPUT_BANNER_TO_POINTQUEST = 64;
    [Token(Token = "0x4009F43")]
    public const int OUTPUT_BANNER_TO_POINTQUEST_LIST = 65;
    [Token(Token = "0x4009F44")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject EventBannerTemplate;
    [Token(Token = "0x4009F45")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform ListRoot;
    [Token(Token = "0x4009F46")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ContentScroller ScrollObj;
    [Token(Token = "0x4009F47")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ToggleGroup TabGroup;
    [Token(Token = "0x4009F48")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Toggle EventTab;
    [Token(Token = "0x4009F49")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Toggle CampaignTab;
    [Token(Token = "0x4009F4A")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Toggle InfomationTab;
    [Token(Token = "0x4009F4B")]
    [FieldOffset(Offset = "0x28")]
    private List<GameObject> m_EventBannerList;
    [Token(Token = "0x4009F4C")]
    [FieldOffset(Offset = "0x2C")]
    private BannerParam[] m_EventList;
    [Token(Token = "0x4009F4D")]
    [FieldOffset(Offset = "0x30")]
    private BannerParam[] m_CampaignList;
    [Token(Token = "0x4009F4E")]
    [FieldOffset(Offset = "0x34")]
    private BannerParam[] m_InfomationList;
    [Token(Token = "0x4009F4F")]
    [FieldOffset(Offset = "0x0")]
    public static BannerTabType InitTabType;

    [Token(Token = "0x60098FB")]
    [Address(RVA = "0x5CE260", Offset = "0x5CD060", VA = "0x105CE260", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60098FC")]
    [Address(RVA = "0x5CE320", Offset = "0x5CD120", VA = "0x105CE320")]
    private void Awake()
    {
    }

    [Token(Token = "0x60098FD")]
    [Address(RVA = "0x5D0420", Offset = "0x5CF220", VA = "0x105D0420")]
    private void Start()
    {
    }

    [Token(Token = "0x60098FE")]
    [Address(RVA = "0x5CF120", Offset = "0x5CDF20", VA = "0x105CF120")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x60098FF")]
    [Address(RVA = "0x5CE5C0", Offset = "0x5CD3C0", VA = "0x105CE5C0")]
    private void InitBannerList()
    {
    }

    [Token(Token = "0x6009900")]
    [Address(RVA = "0x5CE390", Offset = "0x5CD190", VA = "0x105CE390")]
    private BannerParam[] GetBannerList(BannerTabType type) => (BannerParam[]) null;

    [Token(Token = "0x6009901")]
    [Address(RVA = "0x5D0130", Offset = "0x5CEF30", VA = "0x105D0130")]
    private void Setup(BannerParam[] _params)
    {
    }

    [Token(Token = "0x6009902")]
    [Address(RVA = "0x5CF260", Offset = "0x5CE060", VA = "0x105CF260")]
    private void OnSelect()
    {
    }

    [Token(Token = "0x6009903")]
    [Address(RVA = "0x5CF310", Offset = "0x5CE110", VA = "0x105CF310")]
    private void Select(int index)
    {
    }

    [Token(Token = "0x6009904")]
    [Address(RVA = "0x5CFEF0", Offset = "0x5CECF0", VA = "0x105CFEF0")]
    public static bool SetupQuestVariables(string _questID, bool _is_story) => new bool();

    [Token(Token = "0x6009905")]
    [Address(RVA = "0x5CE950", Offset = "0x5CD750", VA = "0x105CE950")]
    public static BannerParam[] MakeValidBannerParams(bool _is_home_banner = true)
    {
      return (BannerParam[]) null;
    }

    [Token(Token = "0x6009906")]
    [Address(RVA = "0x5CF160", Offset = "0x5CDF60", VA = "0x105CF160")]
    private void OnSelectTab(bool is_on)
    {
    }

    [Token(Token = "0x6009907")]
    [Address(RVA = "0x5CE3C0", Offset = "0x5CD1C0", VA = "0x105CE3C0")]
    private BannerTabType GetCurrentTabType() => new BannerTabType();

    [Token(Token = "0x6009908")]
    [Address(RVA = "0x5D07D0", Offset = "0x5CF5D0", VA = "0x105D07D0")]
    public EventPopup()
    {
    }

    [Token(Token = "0x6009909")]
    [Address(RVA = "0x5D07A0", Offset = "0x5CF5A0", VA = "0x105D07A0")]
    static EventPopup()
    {
    }
  }
}

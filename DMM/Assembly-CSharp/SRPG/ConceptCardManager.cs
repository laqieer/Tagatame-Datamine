// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardManager
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
  [Token(Token = "0x2002231")]
  [FlowNode.Pin(200, "TIPS表示", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(115, "EX化アニメ再生後", FlowNode.PinTypes.Output, 115)]
  [FlowNode.Pin(15, "EX化アニメ再生", FlowNode.PinTypes.Input, 15)]
  [FlowNode.Pin(114, "VisionMaster再生後", FlowNode.PinTypes.Output, 114)]
  [FlowNode.Pin(14, "VisionMaster再生", FlowNode.PinTypes.Input, 14)]
  [FlowNode.Pin(113, "グループスキル強化再生後", FlowNode.PinTypes.Output, 113)]
  [FlowNode.Pin(13, "グループスキル強化再生", FlowNode.PinTypes.Input, 13)]
  [FlowNode.Pin(111, "トラストマスター再生後", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(12, "限界突破アニメ再生", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(112, "限界突破アニメ再生後", FlowNode.PinTypes.Output, 112)]
  [AddComponentMenu("UI/ConceptCardManager")]
  [FlowNode.Pin(110, "強化アニメ再生後", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(10, "強化アニメ再生", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(1, "選択素材等クリア", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(0, "初期化", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(11, "トラストマスター再生", FlowNode.PinTypes.Input, 11)]
  public class ConceptCardManager : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009780")]
    [FieldOffset(Offset = "0x0")]
    private static ConceptCardManager _instance;
    [Token(Token = "0x4009781")]
    public const int PIN_INIT = 0;
    [Token(Token = "0x4009782")]
    public const int PIN_CLEAR_MAT = 1;
    [Token(Token = "0x4009783")]
    public const int PIN_SELL = 3;
    [Token(Token = "0x4009784")]
    public const int PIN_ENHANCE_ANIM = 10;
    [Token(Token = "0x4009785")]
    public const int PIN_TRUSTMASTER_ANIM = 11;
    [Token(Token = "0x4009786")]
    public const int PIN_AWAKE_ANIM = 12;
    [Token(Token = "0x4009787")]
    public const int PIN_GROUPSKILL_POWERUP_ANIM = 13;
    [Token(Token = "0x4009788")]
    public const int PIN_GROUPSKILL_MAX_POWERUP_ANIM = 14;
    [Token(Token = "0x4009789")]
    public const int PIN_EXTRA_RARITY_ANIM = 15;
    [Token(Token = "0x400978A")]
    public const int PIN_ENHANCE_ANIM_OUTPUT = 110;
    [Token(Token = "0x400978B")]
    public const int PIN_TRUSTMASTER_ANIM_OUTPUT = 111;
    [Token(Token = "0x400978C")]
    public const int PIN_AWAKE_ANIM_OUTPUT = 112;
    [Token(Token = "0x400978D")]
    public const int PIN_GROUPSKILL_POWERUP_ANIM_OUTPUT = 113;
    [Token(Token = "0x400978E")]
    public const int PIN_GROUPSKILL_MAX_POWERUP_ANIM_OUTPUT = 114;
    [Token(Token = "0x400978F")]
    public const int PIN_EXTRA_RARITY_ANIM_OUTPUT = 115;
    [Token(Token = "0x4009790")]
    public const int PIN_TIPS_EQUIPMENT_OUTPUT = 200;
    [Token(Token = "0x4009791")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private GameObject mConceptCardList;
    [Token(Token = "0x4009792")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mConceptCardEnhanceList;
    [Token(Token = "0x4009793")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mConceptCardDetail;
    [Token(Token = "0x4009794")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mConceptCardCheck;
    [Token(Token = "0x4009795")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mConceptCardSellList;
    [Token(Token = "0x4009796")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mConceptCardSellCheckList;
    [Token(Token = "0x4009797")]
    [FieldOffset(Offset = "0x24")]
    [Space(10f)]
    private ConceptCardDetailLevel mLevelObject;
    [Token(Token = "0x4009798")]
    [FieldOffset(Offset = "0x28")]
    [HideInInspector]
    public bool ToggleSameSelectCard;
    [Token(Token = "0x4009799")]
    [FieldOffset(Offset = "0x2C")]
    [HideInInspector]
    public ConceptCardListSortWindow.Type SortType;
    [Token(Token = "0x400979A")]
    [FieldOffset(Offset = "0x30")]
    [HideInInspector]
    public ConceptCardListSortWindow.Type SortOrderType;
    [Token(Token = "0x400979B")]
    [FieldOffset(Offset = "0x34")]
    private ConceptCardScrollList.ListType mActiveList;
    [Token(Token = "0x400979C")]
    [FieldOffset(Offset = "0x38")]
    private FilterConceptCardPrefs mFilterPrefs;
    [Token(Token = "0x400979D")]
    [FieldOffset(Offset = "0x40")]
    private OLong mSelectedUniqueID;
    [Token(Token = "0x400979E")]
    [FieldOffset(Offset = "0x68")]
    private MultiConceptCard mSelectedMaterials;
    [Token(Token = "0x400979F")]
    [FieldOffset(Offset = "0x6C")]
    [HideInInspector]
    public int CostConceptCardRare;
    [Token(Token = "0x40097A0")]
    [FieldOffset(Offset = "0x70")]
    private List<SelecteConceptCardMaterial> mBulkSelectedMaterialList;
    [Token(Token = "0x40097A1")]
    [FieldOffset(Offset = "0x74")]
    private ConceptCardData mSelectedConceptCardMaterial;
    [Token(Token = "0x40097A2")]
    [FieldOffset(Offset = "0x78")]
    private Dictionary<string, int> mSelectedAwakeMaterialList;
    [Token(Token = "0x40097A3")]
    [FieldOffset(Offset = "0x7C")]
    private ConceptCardDetail mInsConceptCardDetail;
    [Token(Token = "0x40097A4")]
    [FieldOffset(Offset = "0x80")]
    private List<ConceptCardIconParam> mConceptCardDrawList;

    [Token(Token = "0x17001472")]
    public static ConceptCardManager Instance
    {
      [Token(Token = "0x600915A"), Address(RVA = "0x54FFC0", Offset = "0x54EDC0", VA = "0x1054FFC0")] get
      {
        return (ConceptCardManager) null;
      }
    }

    [Token(Token = "0x600915B")]
    [Address(RVA = "0x54D690", Offset = "0x54C490", VA = "0x1054D690")]
    private void Awake()
    {
    }

    [Token(Token = "0x600915C")]
    [Address(RVA = "0x54F9E0", Offset = "0x54E7E0", VA = "0x1054F9E0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x17001473")]
    public ConceptCardScrollList.ListType ActiveList
    {
      [Token(Token = "0x600915D"), Address(RVA = "0x54FFB0", Offset = "0x54EDB0", VA = "0x1054FFB0")] get
      {
        return new ConceptCardScrollList.ListType();
      }
    }

    [Token(Token = "0x600915E")]
    [Address(RVA = "0x54FC50", Offset = "0x54EA50", VA = "0x1054FC50")]
    public void SetActiveList(ConceptCardScrollList.ListType active_list_type)
    {
    }

    [Token(Token = "0x17001474")]
    public FilterConceptCardPrefs FilterPrefs
    {
      [Token(Token = "0x600915F"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (FilterConceptCardPrefs) null;
      }
    }

    [Token(Token = "0x17001475")]
    public bool IsBranceListActive
    {
      [Token(Token = "0x6009160"), Address(RVA = "0x54FFF0", Offset = "0x54EDF0", VA = "0x1054FFF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001476")]
    public bool IsEnhanceListActive
    {
      [Token(Token = "0x6009161"), Address(RVA = "0x550050", Offset = "0x54EE50", VA = "0x10550050")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001477")]
    public bool IsSellListActive
    {
      [Token(Token = "0x6009162"), Address(RVA = "0x550080", Offset = "0x54EE80", VA = "0x10550080")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001478")]
    public bool IsDetailActive
    {
      [Token(Token = "0x6009163"), Address(RVA = "0x550020", Offset = "0x54EE20", VA = "0x10550020")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001479")]
    public ConceptCardDetail ConceptCardDetail
    {
      [Token(Token = "0x6009164"), Address(RVA = "0x2B5EF0", Offset = "0x2B4CF0", VA = "0x102B5EF0")] get
      {
        return (ConceptCardDetail) null;
      }
    }

    [Token(Token = "0x1700147A")]
    public List<ConceptCardIconParam> ConceptCardDrawList
    {
      [Token(Token = "0x6009165"), Address(RVA = "0x3197C0", Offset = "0x3185C0", VA = "0x103197C0")] get
      {
        return (List<ConceptCardIconParam>) null;
      }
    }

    [Token(Token = "0x6009166")]
    [Address(RVA = "0x54FA20", Offset = "0x54E820", VA = "0x1054FA20")]
    public static string ParseTrustFormat(ConceptCardData card, int trust) => (string) null;

    [Token(Token = "0x6009167")]
    [Address(RVA = "0x54FD20", Offset = "0x54EB20", VA = "0x1054FD20")]
    public static void SubstituteTrustFormat(
      ConceptCardData card,
      Text txt,
      int trust,
      bool notChangeColor = false)
    {
    }

    [Token(Token = "0x6009168")]
    [Address(RVA = "0x54DAF0", Offset = "0x54C8F0", VA = "0x1054DAF0")]
    public static void CalcTotalExpTrust(
      ConceptCardData selectedCard,
      MultiConceptCard materials,
      out int mixTotalExp,
      out int mixTrustExp,
      out int mixTotalAwakeLv)
    {
    }

    [Token(Token = "0x6009169")]
    [Address(RVA = "0x54E260", Offset = "0x54D060", VA = "0x1054E260")]
    public static int CalcTotalTrust(ConceptCardData selectedCard, MultiConceptCard materials)
    {
      return new int();
    }

    [Token(Token = "0x600916A")]
    [Address(RVA = "0x54EAD0", Offset = "0x54D8D0", VA = "0x1054EAD0")]
    public static bool ContainsTrustMax(ConceptCardData selectedCard, MultiConceptCard materials)
    {
      return new bool();
    }

    [Token(Token = "0x600916B")]
    [Address(RVA = "0x54E4A0", Offset = "0x54D2A0", VA = "0x1054E4A0")]
    public static bool CalcTotalUnacquiredTrustBonus(
      ConceptCardData selectedCard,
      MultiConceptCard materials)
    {
      return new bool();
    }

    [Token(Token = "0x600916C")]
    [Address(RVA = "0x54E0C0", Offset = "0x54CEC0", VA = "0x1054E0C0")]
    public static int CalcTotalTrustBonusMixCount(
      ConceptCardData selectedCard,
      MultiConceptCard materials)
    {
      return new int();
    }

    [Token(Token = "0x600916D")]
    [Address(RVA = "0x54D710", Offset = "0x54C510", VA = "0x1054D710")]
    public static int CalcTotalAwakeCount(ConceptCardData selectedCard, MultiConceptCard materials)
    {
      return new int();
    }

    [Token(Token = "0x600916E")]
    [Address(RVA = "0x54E930", Offset = "0x54D730", VA = "0x1054E930")]
    public static bool ContainsAwakeCountMax(
      ConceptCardData selectedCard,
      MultiConceptCard materials)
    {
      return new bool();
    }

    [Token(Token = "0x600916F")]
    [Address(RVA = "0x54D900", Offset = "0x54C700", VA = "0x1054D900")]
    public static void CalcTotalExpTrustMaterialData(out int mixTotalExp, out int mixTrustExp)
    {
    }

    [Token(Token = "0x6009170")]
    [Address(RVA = "0x54DE60", Offset = "0x54CC60", VA = "0x1054DE60")]
    public static void CalcTotalExpTrust(
      out int mixTotalExp,
      out int mixTrustExp,
      out int mixTotalAwakeLv)
    {
    }

    [Token(Token = "0x6009171")]
    [Address(RVA = "0x54EFA0", Offset = "0x54DDA0", VA = "0x1054EFA0")]
    public static void GalcTotalSellZeny(MultiConceptCard materials, out int totalSellZeny)
    {
    }

    [Token(Token = "0x6009172")]
    [Address(RVA = "0x54DF70", Offset = "0x54CD70", VA = "0x1054DF70")]
    public static void CalcTotalSellCoin(MultiConceptCard materials, out int totalSellCoin)
    {
    }

    [Token(Token = "0x6009173")]
    [Address(RVA = "0x54EE50", Offset = "0x54DC50", VA = "0x1054EE50")]
    public static void GalcTotalMixZeny(MultiConceptCard materials, out int totalMixZeny)
    {
    }

    [Token(Token = "0x6009174")]
    [Address(RVA = "0x54EC90", Offset = "0x54DA90", VA = "0x1054EC90")]
    public static void GalcTotalMixZenyMaterialData(out int totalMixZeny)
    {
    }

    [Token(Token = "0x6009175")]
    [Address(RVA = "0x54F450", Offset = "0x54E250", VA = "0x1054F450")]
    public static string GetWarningTextByMaterials(MultiConceptCard materials) => (string) null;

    [Token(Token = "0x6009176")]
    [Address(RVA = "0x54D3E0", Offset = "0x54C1E0", VA = "0x1054D3E0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6009177")]
    [Address(RVA = "0x495600", Offset = "0x494400", VA = "0x10495600")]
    private void EnhanceAnimCallBack()
    {
    }

    [Token(Token = "0x6009178")]
    [Address(RVA = "0x54D670", Offset = "0x54C470", VA = "0x1054D670")]
    private void AwakeAnimCallBack()
    {
    }

    [Token(Token = "0x6009179")]
    [Address(RVA = "0x54F640", Offset = "0x54E440", VA = "0x1054F640")]
    private void GroupSkillPowerUpAnimCallBack()
    {
    }

    [Token(Token = "0x600917A")]
    [Address(RVA = "0x54F620", Offset = "0x54E420", VA = "0x1054F620")]
    private void GroupSkillMaxPowerUpAnimCallBack()
    {
    }

    [Token(Token = "0x600917B")]
    [Address(RVA = "0x4051F0", Offset = "0x403FF0", VA = "0x104051F0")]
    private void TrustMasterAnimCallBack()
    {
    }

    [Token(Token = "0x1700147B")]
    public ConceptCardData SelectedConceptCardData
    {
      [Token(Token = "0x600917C"), Address(RVA = "0x550180", Offset = "0x54EF80", VA = "0x10550180")] set
      {
      }
      [Token(Token = "0x600917D"), Address(RVA = "0x5500B0", Offset = "0x54EEB0", VA = "0x105500B0")] get
      {
        return (ConceptCardData) null;
      }
    }

    [Token(Token = "0x1700147C")]
    public ConceptCardData SelectedConceptCardMaterialData
    {
      [Token(Token = "0x600917E"), Address(RVA = "0x374AB0", Offset = "0x3738B0", VA = "0x10374AB0")] set
      {
      }
      [Token(Token = "0x600917F"), Address(RVA = "0x349360", Offset = "0x348160", VA = "0x10349360")] get
      {
        return (ConceptCardData) null;
      }
    }

    [Token(Token = "0x6009180")]
    [Address(RVA = "0x54F8C0", Offset = "0x54E6C0", VA = "0x1054F8C0")]
    public bool IsEqualsSelectedConceptCardData(ConceptCardData ccd) => new bool();

    [Token(Token = "0x1700147D")]
    public MultiConceptCard SelectedMaterials
    {
      [Token(Token = "0x6009181"), Address(RVA = "0x5501B0", Offset = "0x54EFB0", VA = "0x105501B0")] set
      {
      }
      [Token(Token = "0x6009182"), Address(RVA = "0x349350", Offset = "0x348150", VA = "0x10349350")] get
      {
        return (MultiConceptCard) null;
      }
    }

    [Token(Token = "0x6009183")]
    [Address(RVA = "0x54E8E0", Offset = "0x54D6E0", VA = "0x1054E8E0")]
    private void ClearMaterials()
    {
    }

    [Token(Token = "0x1700147E")]
    public List<SelecteConceptCardMaterial> BulkSelectedMaterialList
    {
      [Token(Token = "0x6009184"), Address(RVA = "0x288B00", Offset = "0x287900", VA = "0x10288B00")] set
      {
      }
      [Token(Token = "0x6009185"), Address(RVA = "0x288AD0", Offset = "0x2878D0", VA = "0x10288AD0")] get
      {
        return (List<SelecteConceptCardMaterial>) null;
      }
    }

    [Token(Token = "0x1700147F")]
    public Dictionary<string, int> SelectedAwakeMaterialList
    {
      [Token(Token = "0x6009186"), Address(RVA = "0x550160", Offset = "0x54EF60", VA = "0x10550160")] set
      {
      }
      [Token(Token = "0x6009187"), Address(RVA = "0x349370", Offset = "0x348170", VA = "0x10349370")] get
      {
        return (Dictionary<string, int>) null;
      }
    }

    [Token(Token = "0x6009188")]
    [Address(RVA = "0x54F660", Offset = "0x54E460", VA = "0x1054F660")]
    private void Init()
    {
    }

    [Token(Token = "0x6009189")]
    [Address(RVA = "0x54E670", Offset = "0x54D470", VA = "0x1054E670")]
    private void CallConceptCardInit(GameObject obj)
    {
    }

    [Token(Token = "0x600918A")]
    [Address(RVA = "0x54F2D0", Offset = "0x54E0D0", VA = "0x1054F2D0")]
    public void GetTotalExp(out int mixTotalExp, out int mixTrustExp)
    {
    }

    [Token(Token = "0x600918B")]
    [Address(RVA = "0x54FCB0", Offset = "0x54EAB0", VA = "0x1054FCB0")]
    public void SetupLevelupAnimation()
    {
    }

    [Token(Token = "0x600918C")]
    [Address(RVA = "0x54FC60", Offset = "0x54EA60", VA = "0x1054FC60")]
    public void SetupBulkLevelupAnimation()
    {
    }

    [Token(Token = "0x600918D")]
    [Address(RVA = "0x54F9A0", Offset = "0x54E7A0", VA = "0x1054F9A0")]
    public void LoadSortFilterData()
    {
    }

    [Token(Token = "0x600918E")]
    [Address(RVA = "0x54F950", Offset = "0x54E750", VA = "0x1054F950")]
    public bool IsSellList(GameObject list_object) => new bool();

    [Token(Token = "0x600918F")]
    [Address(RVA = "0x54F870", Offset = "0x54E670", VA = "0x1054F870")]
    public bool IsEnhanceList(GameObject list_object) => new bool();

    [Token(Token = "0x6009190")]
    [Address(RVA = "0x36F5F0", Offset = "0x36E3F0", VA = "0x1036F5F0")]
    public void SetFilterPrefs(FilterConceptCardPrefs filter_prefs)
    {
    }

    [Token(Token = "0x6009191")]
    [Address(RVA = "0x460340", Offset = "0x45F140", VA = "0x10460340")]
    public void SetConceptCardDrawList(List<ConceptCardIconParam> _list)
    {
    }

    [Token(Token = "0x6009192")]
    [Address(RVA = "0x54FB00", Offset = "0x54E900", VA = "0x1054FB00")]
    public void RemoveConceptCardDrawList(long[] _remove_cards)
    {
    }

    [Token(Token = "0x6009193")]
    [Address(RVA = "0x54F1F0", Offset = "0x54DFF0", VA = "0x1054F1F0")]
    public int GetCardIndexOf(ConceptCardData _card) => new int();

    [Token(Token = "0x6009194")]
    [Address(RVA = "0x54F0F0", Offset = "0x54DEF0", VA = "0x1054F0F0")]
    public bool GetCardIndexOfMax(ConceptCardData _card) => new bool();

    [Token(Token = "0x6009195")]
    [Address(RVA = "0x54FEC0", Offset = "0x54ECC0", VA = "0x1054FEC0")]
    public ConceptCardManager()
    {
    }
  }
}

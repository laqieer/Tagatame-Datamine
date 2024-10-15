// Decompiled with JetBrains decompiler
// Type: SRPG.ArtifactScrollList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG.Exhibit;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002023")]
  [FlowNode.Pin(511, "武輝石復帰初期化", FlowNode.PinTypes.Output, 511)]
  [FlowNode.Pin(510, "武輝石復帰初期化", FlowNode.PinTypes.Input, 510)]
  [FlowNode.Pin(501, "リストを更新して選択リストからお気に入りを削除して画面更新", FlowNode.PinTypes.Input, 501)]
  [AddComponentMenu("UI/ArtifactScrollList")]
  [FlowNode.Pin(400, "武器石関連の更新", FlowNode.PinTypes.Input, 400)]
  [FlowNode.Pin(450, "武器石関連の更新", FlowNode.PinTypes.Output, 450)]
  [FlowNode.Pin(201, "Update Selection", FlowNode.PinTypes.Input, 201)]
  [FlowNode.Pin(300, "選択リストからお気に入りにを除外して画面更新", FlowNode.PinTypes.Input, 300)]
  [FlowNode.Pin(200, "Refresh", FlowNode.PinTypes.Input, 200)]
  [FlowNode.Pin(101, "Detail Selected", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(100, "Selected", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(20, "Clear Selection", FlowNode.PinTypes.Input, 20)]
  public class ArtifactScrollList : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008954")]
    private const int PIN_ID_CLEAR_SELECTION = 20;
    [Token(Token = "0x4008955")]
    private const int PIN_ID_SELECTED = 100;
    [Token(Token = "0x4008956")]
    private const int PIN_ID_DETAIL_SELECTED = 101;
    [Token(Token = "0x4008957")]
    private const int PIN_ID_REFRESH = 200;
    [Token(Token = "0x4008958")]
    private const int PIN_ID_UPDATE_SELECTION = 201;
    [Token(Token = "0x4008959")]
    private const int PIN_ID_FAVORITE_EXCLUSION = 300;
    [Token(Token = "0x400895A")]
    private const int PIN_ID_ARTIFACT_STONE_UPDATE = 400;
    [Token(Token = "0x400895B")]
    private const int PIN_ID_ARTIFACT_STONE_UPDATE_OUT = 450;
    [Token(Token = "0x400895C")]
    private const int PIN_ID_ARTIFACT_STONE_EXCHANGE_FAVORITE_EXCLUSION = 501;
    [Token(Token = "0x400895D")]
    private const int PIN_ID_ARTIFACT_STONE_SUSPEND_INIT = 510;
    [Token(Token = "0x400895E")]
    private const int PIN_ID_ARTIFACT_STONE_SUSPEND_INIT_OUT = 511;
    [Token(Token = "0x400895F")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    public bool IsArtifactScene;
    [Token(Token = "0x4008960")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject EmptyMessage;
    [Token(Token = "0x4008961")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ContentController mContentController;
    [Token(Token = "0x4008962")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    public GameObject ArtifactDetailRef;
    [Token(Token = "0x4008963")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    public GameObject ArtifactDetail;
    [Token(Token = "0x4008964")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    public Text NumSelection;
    [Token(Token = "0x4008965")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    public int MaxSelection;
    [Token(Token = "0x4008966")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    public Button ApplyButton;
    [Token(Token = "0x4008967")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private ArtifactScrollList.ListSource Source;
    [Token(Token = "0x4008968")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private bool AddEmptyItem;
    [Token(Token = "0x4008969")]
    [FieldOffset(Offset = "0x31")]
    [SerializeField]
    private bool SelectableEquipedItem;
    [Token(Token = "0x400896A")]
    [FieldOffset(Offset = "0x32")]
    [SerializeField]
    private bool SelectableFavoriteItem;
    [Token(Token = "0x400896B")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Text TotalDecomposeCost;
    [Token(Token = "0x400896C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text TotalSellCost;
    [Token(Token = "0x400896D")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Text TotalExchangeNum;
    [Token(Token = "0x400896E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    [Space(5f)]
    private ImageArray FilterBgImages;
    [Token(Token = "0x400896F")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Outline FilterTextOutline;
    [Token(Token = "0x4008970")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Color32 FilterTextOutlineColorOff;
    [Token(Token = "0x4008971")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private Color32 FilterTextOutlineColorOn;
    [Token(Token = "0x4008972")]
    [FieldOffset(Offset = "0x50")]
    [Space(6f)]
    [SerializeField]
    private SerializeValueBehaviour mSVB;
    [Token(Token = "0x4008973")]
    [FieldOffset(Offset = "0x54")]
    [Space(6f)]
    [SerializeField]
    private ExhibitList mStoneEffectExhibit;
    [Token(Token = "0x4008974")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    [Space(6f)]
    private string mSortKey;
    [Token(Token = "0x4008975")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private Text mSortText;
    [Token(Token = "0x4008976")]
    [FieldOffset(Offset = "0x60")]
    [BitMask]
    private ArtifactScrollList.KakeraHideFlags KakeraFlags;
    [Token(Token = "0x4008977")]
    [FieldOffset(Offset = "0x64")]
    private bool mAutoSelected;
    [Token(Token = "0x4008978")]
    [FieldOffset(Offset = "0x68")]
    private List<ArtifactIconParam> mIconParams;
    [Token(Token = "0x4008979")]
    [FieldOffset(Offset = "0x6C")]
    private ArtifactData mSelectedArtifactData;
    [Token(Token = "0x400897A")]
    [FieldOffset(Offset = "0x70")]
    private bool isArtifactStone;
    [Token(Token = "0x400897B")]
    [FieldOffset(Offset = "0x74")]
    private string mFilterPrefsStringCache;
    [Token(Token = "0x400897C")]
    [FieldOffset(Offset = "0x78")]
    private string mSortCache;
    [Token(Token = "0x400897D")]
    [FieldOffset(Offset = "0x7C")]
    private bool mAscendingCache;
    [Token(Token = "0x400897E")]
    [FieldOffset(Offset = "0x7D")]
    private bool mIsArtifactStoneCache;
    [Token(Token = "0x400897F")]
    [FieldOffset(Offset = "0x80")]
    private string mNameSearchString;
    [Token(Token = "0x4008980")]
    [FieldOffset(Offset = "0x84")]
    private SearchUtility.CONDITIONS mNameSearchType;
    [Token(Token = "0x4008981")]
    [FieldOffset(Offset = "0x88")]
    private ArtifactData mBaseArtifactData;
    [Token(Token = "0x4008982")]
    [FieldOffset(Offset = "0x8C")]
    private bool mShouldRefresh;
    [Token(Token = "0x4008983")]
    [FieldOffset(Offset = "0x90")]
    [NonSerialized]
    public ArtifactList.SlotExcludeEquipType ExcludeEquipType;
    [Token(Token = "0x4008984")]
    [FieldOffset(Offset = "0x94")]
    [NonSerialized]
    public List<string> ExcludeEquipTypeIname;
    [Token(Token = "0x4008985")]
    [FieldOffset(Offset = "0x98")]
    [NonSerialized]
    public bool ExcludeEquiped;
    [Token(Token = "0x4008986")]
    [FieldOffset(Offset = "0x99")]
    [NonSerialized]
    public bool KakeraCreateOnly;
    [Token(Token = "0x4008987")]
    [FieldOffset(Offset = "0x9C")]
    private List<ArtifactData> mSelection;
    [Token(Token = "0x4008988")]
    [FieldOffset(Offset = "0xA0")]
    private List<ArtifactParam> mSelectionParams;
    [Token(Token = "0x4008989")]
    [FieldOffset(Offset = "0xA4")]
    private string[] mFiltersPriority;
    [Token(Token = "0x400898A")]
    [FieldOffset(Offset = "0xA8")]
    private UnitData mCurrentArtifactOwner;
    [Token(Token = "0x400898B")]
    [FieldOffset(Offset = "0xAC")]
    private bool mFocusSelection;
    [Token(Token = "0x400898C")]
    [FieldOffset(Offset = "0xB0")]
    private List<ArtifactParam> mRecommendedArtifacts;
    [Token(Token = "0x400898D")]
    [FieldOffset(Offset = "0xB4")]
    private Vector2 mAnchorPosition;
    [Token(Token = "0x400898E")]
    [FieldOffset(Offset = "0xBC")]
    public ArtifactScrollList.SelectionChangeEvent OnSelectionChange;

    [Token(Token = "0x170012F5")]
    public string NameSearchString
    {
      [Token(Token = "0x60084F0"), Address(RVA = "0x460340", Offset = "0x45F140", VA = "0x10460340")] set
      {
      }
    }

    [Token(Token = "0x170012F6")]
    public SearchUtility.CONDITIONS NameSearchType
    {
      [Token(Token = "0x60084F1"), Address(RVA = "0x2B6180", Offset = "0x2B4F80", VA = "0x102B6180")] set
      {
      }
    }

    [Token(Token = "0x170012F7")]
    public ArtifactData BaseArtifactData
    {
      [Token(Token = "0x60084F2"), Address(RVA = "0x4602E0", Offset = "0x45F0E0", VA = "0x104602E0")] set
      {
      }
    }

    [Token(Token = "0x170012F8")]
    public object[] Selection
    {
      [Token(Token = "0x60084F3"), Address(RVA = "0x460270", Offset = "0x45F070", VA = "0x10460270")] get
      {
        return (object[]) null;
      }
    }

    [Token(Token = "0x170012F9")]
    public string[] FiltersPriority
    {
      [Token(Token = "0x60084F4"), Address(RVA = "0x4601D0", Offset = "0x45EFD0", VA = "0x104601D0")] get
      {
        return (string[]) null;
      }
      [Token(Token = "0x60084F5"), Address(RVA = "0x460320", Offset = "0x45F120", VA = "0x10460320")] set
      {
      }
    }

    [Token(Token = "0x170012FA")]
    public UnitData CurrentOwner
    {
      [Token(Token = "0x60084F6"), Address(RVA = "0x4601C0", Offset = "0x45EFC0", VA = "0x104601C0")] get
      {
        return (UnitData) null;
      }
      [Token(Token = "0x60084F7"), Address(RVA = "0x460300", Offset = "0x45F100", VA = "0x10460300")] set
      {
      }
    }

    [Token(Token = "0x60084F8")]
    [Address(RVA = "0x45B380", Offset = "0x45A180", VA = "0x1045B380")]
    private void Awake()
    {
    }

    [Token(Token = "0x60084F9")]
    [Address(RVA = "0x45B2B0", Offset = "0x45A0B0", VA = "0x1045B2B0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x60084FA")]
    [Address(RVA = "0x45E730", Offset = "0x45D530", VA = "0x1045E730")]
    private void UpdateSelection()
    {
    }

    [Token(Token = "0x60084FB")]
    [Address(RVA = "0x45B840", Offset = "0x45A640", VA = "0x1045B840")]
    public void ClearSelection()
    {
    }

    [Token(Token = "0x60084FC")]
    [Address(RVA = "0x45C9F0", Offset = "0x45B7F0", VA = "0x1045C9F0")]
    private void OnEnable()
    {
    }

    [Token(Token = "0x60084FD")]
    [Address(RVA = "0x45CD60", Offset = "0x45BB60", VA = "0x1045CD60")]
    public void Refresh()
    {
    }

    [Token(Token = "0x60084FE")]
    [Address(RVA = "0x45EE50", Offset = "0x45DC50", VA = "0x1045EE50")]
    private void _Refresh()
    {
    }

    [Token(Token = "0x60084FF")]
    [Address(RVA = "0x45E020", Offset = "0x45CE20", VA = "0x1045E020")]
    private void Sort(ref object[] artifact_datas)
    {
    }

    [Token(Token = "0x6008500")]
    [Address(RVA = "0x45C3E0", Offset = "0x45B1E0", VA = "0x1045C3E0")]
    private SortArtifactCondParam GetEnableSortArtifactCondParam(SortUtility.SortPrefs sort_prefs)
    {
      return (SortArtifactCondParam) null;
    }

    [Token(Token = "0x6008501")]
    [Address(RVA = "0x45D610", Offset = "0x45C410", VA = "0x1045D610")]
    private List<ArtifactData> SeparationRecombination(List<ArtifactData> artifacts)
    {
      return (List<ArtifactData>) null;
    }

    [Token(Token = "0x6008502")]
    [Address(RVA = "0x45CC90", Offset = "0x45BA90", VA = "0x1045CC90")]
    private bool RecombinationFlag(ArtifactData targetArtifact) => new bool();

    [Token(Token = "0x6008503")]
    [Address(RVA = "0x45B910", Offset = "0x45A710", VA = "0x1045B910")]
    private void FavoriteExclusion()
    {
    }

    [Token(Token = "0x6008504")]
    [Address(RVA = "0x45DEA0", Offset = "0x45CCA0", VA = "0x1045DEA0")]
    public void SetSelection(ArtifactData[] sel, bool invoke, bool focus)
    {
    }

    [Token(Token = "0x6008505")]
    [Address(RVA = "0x456480", Offset = "0x455280", VA = "0x10456480")]
    private static bool ShouldShowKakera(
      ArtifactParam artifact,
      GameManager gm,
      ArtifactScrollList.KakeraHideFlags flags)
    {
      return new bool();
    }

    [Token(Token = "0x6008506")]
    [Address(RVA = "0x45C040", Offset = "0x45AE40", VA = "0x1045C040")]
    public static bool FilterKakeraArtifacts(ArtifactParam artifact, string[] filter) => new bool();

    [Token(Token = "0x6008507")]
    [Address(RVA = "0x45E6B0", Offset = "0x45D4B0", VA = "0x1045E6B0")]
    private void TriggerDetailSelectionChange()
    {
    }

    [Token(Token = "0x6008508")]
    [Address(RVA = "0x45EE10", Offset = "0x45DC10", VA = "0x1045EE10")]
    private void Update()
    {
    }

    [Token(Token = "0x170012FB")]
    private List<ArtifactParam> RecommendedArtifacts
    {
      [Token(Token = "0x6008509"), Address(RVA = "0x4601E0", Offset = "0x45EFE0", VA = "0x104601E0")] get
      {
        return (List<ArtifactParam>) null;
      }
    }

    [Token(Token = "0x600850A")]
    [Address(RVA = "0x45D190", Offset = "0x45BF90", VA = "0x1045D190")]
    private void Refresh(List<ArtifactParam> arti_params)
    {
    }

    [Token(Token = "0x600850B")]
    [Address(RVA = "0x45CD70", Offset = "0x45BB70", VA = "0x1045CD70")]
    private void Refresh(List<ArtifactData> arti_datas)
    {
    }

    [Token(Token = "0x600850C")]
    [Address(RVA = "0x45E6F0", Offset = "0x45D4F0", VA = "0x1045E6F0")]
    private void TriggerSelectionChange()
    {
    }

    [Token(Token = "0x600850D")]
    [Address(RVA = "0x45CA00", Offset = "0x45B800", VA = "0x1045CA00")]
    public void OnItemDetail(ArtifactIconNode node)
    {
    }

    [Token(Token = "0x600850E")]
    [Address(RVA = "0x45B4F0", Offset = "0x45A2F0", VA = "0x1045B4F0")]
    public void ButtonEventOnClickNode(ArtifactIconNode node)
    {
    }

    [Token(Token = "0x600850F")]
    [Address(RVA = "0x45E130", Offset = "0x45CF30", VA = "0x1045E130")]
    public void StoneEffectUpdate()
    {
    }

    [Token(Token = "0x6008510")]
    [Address(RVA = "0x45B660", Offset = "0x45A460", VA = "0x1045B660")]
    public void ButtonEventOnSelectNode(ArtifactIconNode node)
    {
    }

    [Token(Token = "0x6008511")]
    [Address(RVA = "0x45B440", Offset = "0x45A240", VA = "0x1045B440")]
    public void ButtonEventArtifactDetail(ArtifactIconNode node)
    {
    }

    [Token(Token = "0x6008512")]
    [Address(RVA = "0x45DB90", Offset = "0x45C990", VA = "0x1045DB90")]
    private void SetSelectedArtifactData(ArtifactData arti_data)
    {
    }

    [Token(Token = "0x6008513")]
    [Address(RVA = "0x45DDF0", Offset = "0x45CBF0", VA = "0x1045DDF0")]
    private void SetSelectedArtifactParam(ArtifactParam arti_param)
    {
    }

    [Token(Token = "0x6008514")]
    [Address(RVA = "0x45C6F0", Offset = "0x45B4F0", VA = "0x1045C6F0")]
    private int GetIndexOf(ArtifactData artifact) => new int();

    [Token(Token = "0x6008515")]
    [Address(RVA = "0x45B7B0", Offset = "0x45A5B0", VA = "0x1045B7B0")]
    public bool CheckEndOfIndex(ArtifactData artifact) => new bool();

    [Token(Token = "0x6008516")]
    [Address(RVA = "0x45B810", Offset = "0x45A610", VA = "0x1045B810")]
    public bool CheckStartOfIndex(ArtifactData artifact) => new bool();

    [Token(Token = "0x6008517")]
    [Address(RVA = "0x45D410", Offset = "0x45C210", VA = "0x1045D410")]
    public bool SelectBack(ArtifactData artifactData) => new bool();

    [Token(Token = "0x6008518")]
    [Address(RVA = "0x45D510", Offset = "0x45C310", VA = "0x1045D510")]
    public bool SelectFoward(ArtifactData artifactData) => new bool();

    [Token(Token = "0x6008519")]
    [Address(RVA = "0x45C3C0", Offset = "0x45B1C0", VA = "0x1045C3C0")]
    public bool GetAutoSelected(bool autoReset = false) => new bool();

    [Token(Token = "0x600851A")]
    [Address(RVA = "0x45E3C0", Offset = "0x45D1C0", VA = "0x1045E3C0")]
    private void SuspendStoneEffectCheck()
    {
    }

    [Token(Token = "0x600851B")]
    [Address(RVA = "0x45E640", Offset = "0x45D440", VA = "0x1045E640")]
    private IEnumerator SuspendStoneEffectSelectNode(ArtifactIconNode node) => (IEnumerator) null;

    [Token(Token = "0x600851C")]
    [Address(RVA = "0x45B9E0", Offset = "0x45A7E0", VA = "0x1045B9E0")]
    public static List<ArtifactData> FilterArtifacts(List<ArtifactData> artifacts, string[] filter)
    {
      return (List<ArtifactData>) null;
    }

    [Token(Token = "0x600851D")]
    [Address(RVA = "0x4558A0", Offset = "0x4546A0", VA = "0x104558A0")]
    private static bool GetValue(string str, string key, ref string value) => new bool();

    [Token(Token = "0x600851E")]
    [Address(RVA = "0x45C7C0", Offset = "0x45B5C0", VA = "0x1045C7C0")]
    private bool IsEnableArtifact(ArtifactData artifact_data) => new bool();

    [Token(Token = "0x600851F")]
    [Address(RVA = "0x45C970", Offset = "0x45B770", VA = "0x1045C970")]
    private bool IsSpecialDisplay(ArtifactData artifact_data) => new bool();

    [Token(Token = "0x6008520")]
    [Address(RVA = "0x45FF20", Offset = "0x45ED20", VA = "0x1045FF20")]
    public ArtifactScrollList()
    {
    }

    [Token(Token = "0x2002024")]
    public enum ListSource
    {
      [Token(Token = "0x4008990")] Normal,
      [Token(Token = "0x4008991")] Kakera,
      [Token(Token = "0x4008992")] Skill,
      [Token(Token = "0x4008993")] Stone,
      [Token(Token = "0x4008994")] Single,
      [Token(Token = "0x4008995")] Exchange,
    }

    [Token(Token = "0x2002025")]
    [Flags]
    public enum KakeraHideFlags
    {
      [Token(Token = "0x4008997")] LeastKakera = 1,
      [Token(Token = "0x4008998")] EnoughKakera = 2,
      [Token(Token = "0x4008999")] EnoughGold = 4,
    }

    [Token(Token = "0x2002026")]
    public delegate void SelectionChangeEvent(ArtifactScrollList list);
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.CrystalWindow
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
  [Token(Token = "0x20022AC")]
  [FlowNode.Pin(5, "Refresh", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(101, "SaleExe", FlowNode.PinTypes.Input, 101)]
  [FlowNode.Pin(102, "SaleFin", FlowNode.PinTypes.Input, 102)]
  [FlowNode.Pin(103, "SaleAllSelect", FlowNode.PinTypes.Input, 103)]
  [FlowNode.Pin(105, "NameSearch", FlowNode.PinTypes.Input, 105)]
  [FlowNode.Pin(106, "全装備状況解除ボタン", FlowNode.PinTypes.Input, 106)]
  [FlowNode.Pin(110, "所持状況更新", FlowNode.PinTypes.Input, 110)]
  [FlowNode.Pin(1001, "Show Detail", FlowNode.PinTypes.Output, 1001)]
  [FlowNode.Pin(1002, "Saleリクエスト", FlowNode.PinTypes.Output, 1002)]
  [FlowNode.Pin(1003, "一括選択完了", FlowNode.PinTypes.Output, 1003)]
  [FlowNode.Pin(1004, "全装備状況解除実行", FlowNode.PinTypes.Output, 1004)]
  [FlowNode.Pin(1, "Init", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(104, "SaleAllSelectCancel", FlowNode.PinTypes.Input, 104)]
  [AddComponentMenu("UI/CrystalWindow")]
  [FlowNode.Pin(1010, "所持状況更新完了", FlowNode.PinTypes.Output, 1010)]
  public class CrystalWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009A1C")]
    private const int PIN_IN_INIT = 1;
    [Token(Token = "0x4009A1D")]
    private const int PIN_IN_REFRESH = 5;
    [Token(Token = "0x4009A1E")]
    private const int PIN_IN_SALE_EXE = 101;
    [Token(Token = "0x4009A1F")]
    private const int PIN_IN_SALE_FIN = 102;
    [Token(Token = "0x4009A20")]
    private const int PIN_IN_SALE_ALL_SELECT = 103;
    [Token(Token = "0x4009A21")]
    private const int PIN_IN_SALE_ALL_SELECT_CANCEL = 104;
    [Token(Token = "0x4009A22")]
    private const int PIN_IN_NAME_SEARCH_INPUT = 105;
    [Token(Token = "0x4009A23")]
    private const int PIN_INPUT_RELEASE_ALL = 106;
    [Token(Token = "0x4009A24")]
    private const int PIN_IN_SET_DIRTY = 110;
    [Token(Token = "0x4009A25")]
    private const int PIN_OUTPUT_SHOW_DETAIL = 1001;
    [Token(Token = "0x4009A26")]
    private const int PIN_OUTPUT_SALE_REQ = 1002;
    [Token(Token = "0x4009A27")]
    private const int PIN_OUTPUT_ALL_SELECT_FIN = 1003;
    [Token(Token = "0x4009A28")]
    private const int PIN_OUTPUT_RELEASE_ALL = 1004;
    [Token(Token = "0x4009A29")]
    private const int PIN_OUTPUT_SET_DIRTY = 1010;
    [Token(Token = "0x4009A2A")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private ExhibitList CrystalWindowExhibitList;
    [Token(Token = "0x4009A2B")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private CrystalScrollList StuffScrollList;
    [Token(Token = "0x4009A2C")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private CrystalScrollList SaleScrollList;
    [Token(Token = "0x4009A2D")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Transform mNameBoxParent;
    [Token(Token = "0x4009A2E")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private SerializeValueBehaviour mSVB;
    [Token(Token = "0x4009A2F")]
    [FieldOffset(Offset = "0x20")]
    public ERarity RarityCheckValue;
    [Token(Token = "0x4009A30")]
    [FieldOffset(Offset = "0x24")]
    public int SaleSelectMax;
    [Token(Token = "0x4009A31")]
    [FieldOffset(Offset = "0x28")]
    private int SaleEnableCount;
    [Token(Token = "0x4009A32")]
    [FieldOffset(Offset = "0x0")]
    private static CrystalWindow mInstance;
    [Token(Token = "0x4009A33")]
    [FieldOffset(Offset = "0x2C")]
    private List<CrystalData> mSelectedSaleItemList;
    [Token(Token = "0x4009A34")]
    [FieldOffset(Offset = "0x30")]
    private CrystalData mSelectedCrystal;
    [Token(Token = "0x4009A35")]
    [FieldOffset(Offset = "0x34")]
    private int mNewCrystalsNum;
    [Token(Token = "0x4009A36")]
    [FieldOffset(Offset = "0x38")]
    private List<CrystalData> mSelectedCrystalMaterial;
    [Token(Token = "0x4009A37")]
    [FieldOffset(Offset = "0x3C")]
    private CrystalWindowModel mCrystalWindowModel;
    [Token(Token = "0x4009A3A")]
    [FieldOffset(Offset = "0x48")]
    private List<CrystalData> mBulkGradeupBaseList;
    [Token(Token = "0x4009A3B")]
    [FieldOffset(Offset = "0x4C")]
    private List<List<CrystalData>> mBulkGradeUpMaterialList;
    [Token(Token = "0x4009A3C")]
    public const string DETAIL_CRYSTALS = "DETAIL_CRYSTALS";
    [Token(Token = "0x4009A3D")]
    [FieldOffset(Offset = "0x50")]
    private bool IsEnableSaleTab;
    [Token(Token = "0x4009A3E")]
    [FieldOffset(Offset = "0x54")]
    private List<CrystalWindow.BulkGradeUpCrystals> mReqCrystals;
    [Token(Token = "0x4009A3F")]
    [FieldOffset(Offset = "0x58")]
    private int mSelectedBulkListIndex;
    [Token(Token = "0x4009A40")]
    [FieldOffset(Offset = "0x5C")]
    private List<bool> mEnableFlags;
    [Token(Token = "0x4009A41")]
    [FieldOffset(Offset = "0x60")]
    private GameObject mConfirmDialogGo;
    [Token(Token = "0x4009A42")]
    [FieldOffset(Offset = "0x4")]
    private static readonly string CRYSTAL_RARITY_CHECK_UI_PATH;
    [Token(Token = "0x4009A43")]
    [FieldOffset(Offset = "0x8")]
    private static readonly string CRYSTAL_SALE_RESULT_UI_PATH;
    [Token(Token = "0x4009A44")]
    [FieldOffset(Offset = "0x64")]
    private CrystalRarityCheckWindow mCrystalRarityCheckWindow;
    [Token(Token = "0x4009A45")]
    private const string NAME_SEARCH_WINDOW_UI_PATH = "UI/NameSearchBox/namesearch_window_crystal";
    [Token(Token = "0x4009A46")]
    [FieldOffset(Offset = "0x68")]
    private NameSearchBox mNameSearchBox;
    [Token(Token = "0x4009A47")]
    [FieldOffset(Offset = "0x6C")]
    private string mNameSearchInput;
    [Token(Token = "0x4009A48")]
    [FieldOffset(Offset = "0x70")]
    private SearchUtility.CONDITIONS mNameSearchType;

    [Token(Token = "0x6009489")]
    [Address(RVA = "0x574DE0", Offset = "0x573BE0", VA = "0x10574DE0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x170014D2")]
    public static CrystalWindow Instance
    {
      [Token(Token = "0x600948A"), Address(RVA = "0x579A30", Offset = "0x578830", VA = "0x10579A30")] get
      {
        return (CrystalWindow) null;
      }
    }

    [Token(Token = "0x170014D3")]
    public List<CrystalData> SelectedSellItemList
    {
      [Token(Token = "0x600948B"), Address(RVA = "0x2A09D0", Offset = "0x29F7D0", VA = "0x102A09D0")] get
      {
        return (List<CrystalData>) null;
      }
    }

    [Token(Token = "0x170014D4")]
    public CrystalData SelectedCrystal
    {
      [Token(Token = "0x600948C"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return (CrystalData) null;
      }
      [Token(Token = "0x600948D"), Address(RVA = "0x34C010", Offset = "0x34AE10", VA = "0x1034C010")] set
      {
      }
    }

    [Token(Token = "0x170014D5")]
    public int NewCrystalsNum
    {
      [Token(Token = "0x600948E"), Address(RVA = "0x283700", Offset = "0x282500", VA = "0x10283700")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x170014D6")]
    public List<CrystalData> SelectedCrystalMaterial
    {
      [Token(Token = "0x600948F"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (List<CrystalData>) null;
      }
    }

    [Token(Token = "0x170014D7")]
    public int SaleGoldTotalNum
    {
      [Token(Token = "0x6009490"), Address(RVA = "0x34EDB0", Offset = "0x34DBB0", VA = "0x1034EDB0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009491"), Address(RVA = "0x56B300", Offset = "0x56A100", VA = "0x1056B300")] private set
      {
      }
    }

    [Token(Token = "0x170014D8")]
    public int SaleCoinTotalNum
    {
      [Token(Token = "0x6009492"), Address(RVA = "0x2880B0", Offset = "0x286EB0", VA = "0x102880B0")] get
      {
        return new int();
      }
      [Token(Token = "0x6009493"), Address(RVA = "0x56B2E0", Offset = "0x56A0E0", VA = "0x1056B2E0")] private set
      {
      }
    }

    [Token(Token = "0x170014D9")]
    public List<CrystalData> BulkGradeUpBaseList
    {
      [Token(Token = "0x6009494"), Address(RVA = "0x288000", Offset = "0x286E00", VA = "0x10288000")] get
      {
        return (List<CrystalData>) null;
      }
    }

    [Token(Token = "0x170014DA")]
    public List<List<CrystalData>> BulkGradeUpMaterialList
    {
      [Token(Token = "0x6009495"), Address(RVA = "0x2AABE0", Offset = "0x2A99E0", VA = "0x102AABE0")] get
      {
        return (List<List<CrystalData>>) null;
      }
    }

    [Token(Token = "0x170014DB")]
    public List<CrystalWindow.BulkGradeUpCrystals> GetReqCrystals
    {
      [Token(Token = "0x6009496"), Address(RVA = "0x349170", Offset = "0x347F70", VA = "0x10349170")] get
      {
        return (List<CrystalWindow.BulkGradeUpCrystals>) null;
      }
    }

    [Token(Token = "0x170014DC")]
    public int SelectedBulkListIndex
    {
      [Token(Token = "0x6009497"), Address(RVA = "0x349160", Offset = "0x347F60", VA = "0x10349160")] get
      {
        return new int();
      }
      [Token(Token = "0x6009498"), Address(RVA = "0x374A60", Offset = "0x373860", VA = "0x10374A60")] set
      {
      }
    }

    [Token(Token = "0x170014DD")]
    public List<bool> EnableFlags
    {
      [Token(Token = "0x6009499"), Address(RVA = "0x288090", Offset = "0x286E90", VA = "0x10288090")] get
      {
        return (List<bool>) null;
      }
      [Token(Token = "0x600949A"), Address(RVA = "0x525C30", Offset = "0x524A30", VA = "0x10525C30")] set
      {
      }
    }

    [Token(Token = "0x170014DE")]
    public bool IsDirtyCrystalCount
    {
      [Token(Token = "0x600949B"), Address(RVA = "0x445580", Offset = "0x444380", VA = "0x10445580")] get
      {
        return new bool();
      }
      [Token(Token = "0x600949C"), Address(RVA = "0x579A70", Offset = "0x578870", VA = "0x10579A70")] private set
      {
      }
    }

    [Token(Token = "0x600949D")]
    [Address(RVA = "0x5750A0", Offset = "0x573EA0", VA = "0x105750A0")]
    private void Awake()
    {
    }

    [Token(Token = "0x600949E")]
    [Address(RVA = "0x5773D0", Offset = "0x5761D0", VA = "0x105773D0")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x600949F")]
    [Address(RVA = "0x5787E0", Offset = "0x5775E0", VA = "0x105787E0")]
    private void SaveSVB()
    {
    }

    [Token(Token = "0x60094A0")]
    [Address(RVA = "0x575FE0", Offset = "0x574DE0", VA = "0x10575FE0")]
    private void Initialize()
    {
    }

    [Token(Token = "0x60094A1")]
    [Address(RVA = "0x577F10", Offset = "0x576D10", VA = "0x10577F10")]
    private void Refresh()
    {
    }

    [Token(Token = "0x60094A2")]
    [Address(RVA = "0x49D280", Offset = "0x49C080", VA = "0x1049D280")]
    public void SetNewCrystalsNum(int json)
    {
    }

    [Token(Token = "0x60094A3")]
    [Address(RVA = "0x578A40", Offset = "0x577840", VA = "0x10578A40")]
    public void SetNewCrystalHead(JSON_CrystalData json)
    {
    }

    [Token(Token = "0x60094A4")]
    [Address(RVA = "0x5794F0", Offset = "0x5782F0", VA = "0x105794F0")]
    private void StuffItemSelect()
    {
    }

    [Token(Token = "0x60094A5")]
    [Address(RVA = "0x575450", Offset = "0x574250", VA = "0x10575450")]
    public void FavoriteUpdate(CrystalData _data)
    {
    }

    [Token(Token = "0x60094A6")]
    [Address(RVA = "0x5783E0", Offset = "0x5771E0", VA = "0x105783E0")]
    public void SaleCrystal()
    {
    }

    [Token(Token = "0x60094A7")]
    [Address(RVA = "0x577840", Offset = "0x576640", VA = "0x10577840")]
    private void OnSaleRankCheck(GameObject go)
    {
    }

    [Token(Token = "0x60094A8")]
    [Address(RVA = "0x5775B0", Offset = "0x5763B0", VA = "0x105775B0")]
    private void OnSaleAccept(GameObject go)
    {
    }

    [Token(Token = "0x60094A9")]
    [Address(RVA = "0x577310", Offset = "0x576110", VA = "0x10577310")]
    private void OnCloseConfirmDialog(GameObject go)
    {
    }

    [Token(Token = "0x60094AA")]
    [Address(RVA = "0x578AB0", Offset = "0x5778B0", VA = "0x10578AB0")]
    private void ShowSaleResult()
    {
    }

    [Token(Token = "0x60094AB")]
    [Address(RVA = "0x578120", Offset = "0x576F20", VA = "0x10578120")]
    private void SaleCrystalSelect()
    {
    }

    [Token(Token = "0x60094AC")]
    [Address(RVA = "0x578030", Offset = "0x576E30", VA = "0x10578030")]
    private void SaleCrystalAllSelect(bool is_select)
    {
    }

    [Token(Token = "0x60094AD")]
    [Address(RVA = "0x578650", Offset = "0x577450", VA = "0x10578650")]
    private void SaleEnableCountCalc()
    {
    }

    [Token(Token = "0x60094AE")]
    [Address(RVA = "0x575500", Offset = "0x574300", VA = "0x10575500")]
    public CrystalWindow.CrystalUseContents GetCrystalUseUnitIDs(long crystal_iid)
    {
      return (CrystalWindow.CrystalUseContents) null;
    }

    [Token(Token = "0x60094AF")]
    [Address(RVA = "0x575100", Offset = "0x573F00", VA = "0x10575100")]
    private bool BulkGradeUpBtnSetUp() => new bool();

    [Token(Token = "0x60094B0")]
    [Address(RVA = "0x577040", Offset = "0x575E40", VA = "0x10577040")]
    private void MakeReqBulkGradeUpCrystals()
    {
    }

    [Token(Token = "0x60094B1")]
    [Address(RVA = "0x576620", Offset = "0x575420", VA = "0x10576620")]
    private bool MakeBulkGradeUpDataList(
      ref List<CrystalData> gradeup_bases,
      ref List<List<CrystalData>> gradeup_materials)
    {
      return new bool();
    }

    [Token(Token = "0x60094B2")]
    [Address(RVA = "0x578D60", Offset = "0x577B60", VA = "0x10578D60")]
    private void SortBulkGradeUpRule(
      ref List<CrystalData> gradeup_bases,
      ref List<List<CrystalData>> gradeup_materials)
    {
    }

    [Token(Token = "0x60094B3")]
    [Address(RVA = "0x579400", Offset = "0x578200", VA = "0x10579400")]
    private void SortBulkGradeUp(
      ref List<CrystalWindow.SortBulkUpgradeCrystal> sortlist)
    {
    }

    [Token(Token = "0x60094B4")]
    [Address(RVA = "0x575B90", Offset = "0x574990", VA = "0x10575B90")]
    private List<CrystalData> GetSortedList(
      IReadOnlyList<CrystalData> _data_source,
      int _need_amount)
    {
      return (List<CrystalData>) null;
    }

    [Token(Token = "0x60094B5")]
    [Address(RVA = "0x577C80", Offset = "0x576A80", VA = "0x10577C80")]
    private void ReformCrystalGradeUpDataLists(
      IReadOnlyList<CrystalData> _data_source,
      int need_mat,
      ref List<CrystalData> bases,
      ref List<List<CrystalData>> mats)
    {
    }

    [Token(Token = "0x60094B6")]
    [Address(RVA = "0x578890", Offset = "0x577690", VA = "0x10578890")]
    public void SetEnableFlags(bool value)
    {
    }

    [Token(Token = "0x60094B7")]
    [Address(RVA = "0x5763C0", Offset = "0x5751C0", VA = "0x105763C0")]
    public bool IsAvailableGradeUp(CrystalData _selectedItem) => new bool();

    [Token(Token = "0x60094B8")]
    [Address(RVA = "0x5796A0", Offset = "0x5784A0", VA = "0x105796A0")]
    public bool UnequipAllBtnSetUp() => new bool();

    [Token(Token = "0x60094B9")]
    [Address(RVA = "0x5774F0", Offset = "0x5762F0", VA = "0x105774F0")]
    public void OnReleaseAllBtn()
    {
    }

    [Token(Token = "0x60094BA")]
    [Address(RVA = "0x575260", Offset = "0x574060", VA = "0x10575260")]
    public void CreateNameSearchBox()
    {
    }

    [Token(Token = "0x60094BB")]
    [Address(RVA = "0x575380", Offset = "0x574180", VA = "0x10575380")]
    public void DeleteNameSearchBox()
    {
    }

    [Token(Token = "0x60094BC")]
    [Address(RVA = "0x578910", Offset = "0x577710", VA = "0x10578910")]
    public void SetNameSearchInfo()
    {
    }

    [Token(Token = "0x60094BD")]
    [Address(RVA = "0x5798C0", Offset = "0x5786C0", VA = "0x105798C0")]
    public CrystalWindow()
    {
    }

    [Token(Token = "0x60094BE")]
    [Address(RVA = "0x579820", Offset = "0x578620", VA = "0x10579820")]
    static CrystalWindow()
    {
    }

    [Token(Token = "0x20022AD")]
    public class BulkGradeUpCrystals
    {
      [Token(Token = "0x4009A4A")]
      [FieldOffset(Offset = "0x8")]
      public long base_iid;
      [Token(Token = "0x4009A4B")]
      [FieldOffset(Offset = "0x10")]
      public List<long> mats_iid;

      [Token(Token = "0x60094C2")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public BulkGradeUpCrystals()
      {
      }
    }

    [Token(Token = "0x20022AE")]
    public class CrystalUseContents
    {
      [Token(Token = "0x4009A4C")]
      [FieldOffset(Offset = "0x8")]
      public long OwnerUnit;
      [Token(Token = "0x4009A4D")]
      [FieldOffset(Offset = "0x10")]
      public long ArenaUnit;
      [Token(Token = "0x4009A4E")]
      [FieldOffset(Offset = "0x18")]
      public List<long> SupportUnits;
      [Token(Token = "0x4009A4F")]
      [FieldOffset(Offset = "0x20")]
      public long GvGUnit;
      [Token(Token = "0x4009A50")]
      [FieldOffset(Offset = "0x28")]
      public List<long> LeagueMatchUnits;

      [Token(Token = "0x60094C3")]
      [Address(RVA = "0x58EA30", Offset = "0x58D830", VA = "0x1058EA30")]
      public CrystalUseContents()
      {
      }
    }

    [Token(Token = "0x20022AF")]
    public class CrystalUseUnitState
    {
      [Token(Token = "0x4009A51")]
      [FieldOffset(Offset = "0x8")]
      public long UniqueID;
      [Token(Token = "0x4009A52")]
      [FieldOffset(Offset = "0x10")]
      public bool IsUseQuest;
      [Token(Token = "0x4009A53")]
      [FieldOffset(Offset = "0x11")]
      public bool IsArena;
      [Token(Token = "0x4009A54")]
      [FieldOffset(Offset = "0x12")]
      public bool IsSupport;
      [Token(Token = "0x4009A55")]
      [FieldOffset(Offset = "0x13")]
      public bool IsGvG;
      [Token(Token = "0x4009A56")]
      [FieldOffset(Offset = "0x14")]
      public bool IsLeagueMatch;

      [Token(Token = "0x60094C4")]
      [Address(RVA = "0x58EA70", Offset = "0x58D870", VA = "0x1058EA70")]
      public CrystalUseUnitState()
      {
      }
    }

    [Token(Token = "0x20022B0")]
    public class SortBulkUpgradeCrystal
    {
      [Token(Token = "0x4009A57")]
      [FieldOffset(Offset = "0x8")]
      private CrystalData _baseCrystal;
      [Token(Token = "0x4009A58")]
      [FieldOffset(Offset = "0xC")]
      private List<CrystalData> _materialCrystals;
      [Token(Token = "0x4009A59")]
      [FieldOffset(Offset = "0x10")]
      private int _sortValue;
      [Token(Token = "0x4009A5A")]
      [FieldOffset(Offset = "0x14")]
      private int _index;

      [Token(Token = "0x170014DF")]
      public CrystalData BaseCrystal
      {
        [Token(Token = "0x60094C5"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (CrystalData) null;
        }
      }

      [Token(Token = "0x170014E0")]
      public List<CrystalData> MaterialCrystals
      {
        [Token(Token = "0x60094C6"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return (List<CrystalData>) null;
        }
      }

      [Token(Token = "0x170014E1")]
      public int SortValue
      {
        [Token(Token = "0x60094C7"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x170014E2")]
      public int Index
      {
        [Token(Token = "0x60094C8"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
        {
          return new int();
        }
      }

      [Token(Token = "0x60094C9")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public SortBulkUpgradeCrystal()
      {
      }

      [Token(Token = "0x60094CA")]
      [Address(RVA = "0x5920B0", Offset = "0x590EB0", VA = "0x105920B0")]
      public void Setup(CrystalData base_crystal, List<CrystalData> materials, int index = 0)
      {
      }

      [Token(Token = "0x60094CB")]
      [Address(RVA = "0x591FC0", Offset = "0x590DC0", VA = "0x10591FC0")]
      public bool IsEquipAnyMaterials() => new bool();

      [Token(Token = "0x60094CC")]
      [Address(RVA = "0x591F80", Offset = "0x590D80", VA = "0x10591F80")]
      public bool IsEquipAnyBase() => new bool();
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.UnitListRootWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002C87")]
  public class UnitListRootWindow : FlowWindowBase
  {
    [Token(Token = "0x400DC81")]
    public const string UNITLIST_KEY = "unitlist";
    [Token(Token = "0x400DC82")]
    public const string PIECELIST_KEY = "piecelist";
    [Token(Token = "0x400DC83")]
    public const string SUPPORTLIST_KEY = "supportlist";
    [Token(Token = "0x400DC84")]
    public const int BTN_GROUP = 1;
    [Token(Token = "0x400DC85")]
    public const int TEXT_GROUP = 2;
    [Token(Token = "0x400DC86")]
    [FieldOffset(Offset = "0x30")]
    private UnitListRootWindow.SerializeParam m_Param;
    [Token(Token = "0x400DC87")]
    [FieldOffset(Offset = "0x34")]
    private SerializeValueList m_ValueList;
    [Token(Token = "0x400DC88")]
    [FieldOffset(Offset = "0x38")]
    private UnitListWindow m_Root;
    [Token(Token = "0x400DC89")]
    [FieldOffset(Offset = "0x3C")]
    private GameObject m_UnitList;
    [Token(Token = "0x400DC8A")]
    [FieldOffset(Offset = "0x40")]
    private GameObject m_SupportList;
    [Token(Token = "0x400DC8B")]
    [FieldOffset(Offset = "0x44")]
    private GameObject m_PieceList;
    [Token(Token = "0x400DC8C")]
    [FieldOffset(Offset = "0x48")]
    private UnitListWindow.EditType m_EditType;
    [Token(Token = "0x400DC8D")]
    [FieldOffset(Offset = "0x4C")]
    private UnitListRootWindow.ContentType m_ContentType;
    [Token(Token = "0x400DC8E")]
    [FieldOffset(Offset = "0x50")]
    private TabMaker m_Tab;
    [Token(Token = "0x400DC8F")]
    [FieldOffset(Offset = "0x54")]
    private bool m_Destroy;
    [Token(Token = "0x400DC90")]
    [FieldOffset(Offset = "0x58")]
    private UnitListRootWindow.Content.ItemSource m_ContentSource;
    [Token(Token = "0x400DC91")]
    [FieldOffset(Offset = "0x5C")]
    private ContentController m_ContentController;
    [Token(Token = "0x400DC92")]
    [FieldOffset(Offset = "0x60")]
    private Dictionary<string, UnitListRootWindow.ListData> m_Dict;
    [Token(Token = "0x400DC93")]
    [FieldOffset(Offset = "0x64")]
    private GameObject m_AccessoryRoot;
    [Token(Token = "0x400DC94")]
    [FieldOffset(Offset = "0x68")]
    private RectTransform[] m_MainSlotLabel;
    [Token(Token = "0x400DC95")]
    [FieldOffset(Offset = "0x6C")]
    private RectTransform[] m_SubSlotLabel;
    [Token(Token = "0x400DC96")]
    [FieldOffset(Offset = "0x70")]
    private RectTransform m_AdventureMain1Label;
    [Token(Token = "0x400DC97")]
    [FieldOffset(Offset = "0x0")]
    private static UnitListRootWindow m_Instance;
    [Token(Token = "0x400DC98")]
    [FieldOffset(Offset = "0x74")]
    private ContentController m_PieceController;
    [Token(Token = "0x400DC99")]
    private const float SUPPORT_REFRESH_LOCK_TIME = 10f;
    [Token(Token = "0x400DC9A")]
    [FieldOffset(Offset = "0x78")]
    private ContentController m_SupportController;
    [Token(Token = "0x400DC9B")]
    [FieldOffset(Offset = "0x7C")]
    private SerializeValueList m_SupportValueList;
    [Token(Token = "0x400DC9C")]
    [FieldOffset(Offset = "0x80")]
    private float m_SupportRefreshLock;
    [Token(Token = "0x400DC9D")]
    [FieldOffset(Offset = "0x84")]
    private ContentController m_UnitController;
    [Token(Token = "0x400DC9E")]
    [FieldOffset(Offset = "0x88")]
    private List<UnitData> mSameUnitList;

    [Token(Token = "0x17001B30")]
    public override string name
    {
      [Token(Token = "0x600CE70"), Address(RVA = "0x99FBD0", Offset = "0x99E9D0", VA = "0x1099FBD0", Slot = "4")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001B31")]
    private GameObject Param_UnitList
    {
      [Token(Token = "0x600CE71"), Address(RVA = "0x99F8C0", Offset = "0x99E6C0", VA = "0x1099F8C0")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x17001B32")]
    private GameObject Param_PieceList
    {
      [Token(Token = "0x600CE72"), Address(RVA = "0x99F460", Offset = "0x99E260", VA = "0x1099F460")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x17001B33")]
    private GameObject Param_SupportList
    {
      [Token(Token = "0x600CE73"), Address(RVA = "0x99F6F0", Offset = "0x99E4F0", VA = "0x1099F6F0")] get
      {
        return (GameObject) null;
      }
    }

    [Token(Token = "0x17001B34")]
    public static UnitListRootWindow instance
    {
      [Token(Token = "0x600CE74"), Address(RVA = "0x99FBA0", Offset = "0x99E9A0", VA = "0x1099FBA0")] get
      {
        return (UnitListRootWindow) null;
      }
    }

    [Token(Token = "0x17001B35")]
    public static bool hasInstance
    {
      [Token(Token = "0x600CE75"), Address(RVA = "0x99FB40", Offset = "0x99E940", VA = "0x1099FB40")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600CE76")]
    [Address(RVA = "0x99AF40", Offset = "0x999D40", VA = "0x1099AF40", Slot = "5")]
    public override void Initialize(FlowWindowBase.SerializeParamBase param)
    {
    }

    [Token(Token = "0x600CE77")]
    [Address(RVA = "0x99C740", Offset = "0x99B540", VA = "0x1099C740", Slot = "6")]
    public override void Release()
    {
    }

    [Token(Token = "0x600CE78")]
    [Address(RVA = "0x99F330", Offset = "0x99E130", VA = "0x1099F330", Slot = "8")]
    public override int Update() => new int();

    [Token(Token = "0x600CE79")]
    [Address(RVA = "0x99A040", Offset = "0x998E40", VA = "0x1099A040")]
    public UnitListRootWindow.ListData GetListData(string key)
    {
      return (UnitListRootWindow.ListData) null;
    }

    [Token(Token = "0x600CE7A")]
    [Address(RVA = "0x996220", Offset = "0x995020", VA = "0x10996220")]
    public UnitListRootWindow.ListData AddListData(string key)
    {
      return (UnitListRootWindow.ListData) null;
    }

    [Token(Token = "0x600CE7B")]
    [Address(RVA = "0x99C800", Offset = "0x99B600", VA = "0x1099C800")]
    public void RemoveListDataAll()
    {
    }

    [Token(Token = "0x600CE7C")]
    [Address(RVA = "0x99A500", Offset = "0x999300", VA = "0x1099A500")]
    private string[] GetTabKeys(UnitListRootWindow.Tab[] tabs) => (string[]) null;

    [Token(Token = "0x600CE7D")]
    [Address(RVA = "0x99D800", Offset = "0x99C600", VA = "0x1099D800")]
    private void SetupTab(UnitListRootWindow.Tab[] tabs, UnitListRootWindow.Tab start)
    {
    }

    [Token(Token = "0x600CE7E")]
    [Address(RVA = "0x99D700", Offset = "0x99C500", VA = "0x1099D700")]
    private void SetupTabNode(GameObject gobj, SerializeValueList value)
    {
    }

    [Token(Token = "0x600CE7F")]
    [Address(RVA = "0x999750", Offset = "0x998550", VA = "0x10999750")]
    public UnitListRootWindow.Tab GetCurrentTab() => new UnitListRootWindow.Tab();

    [Token(Token = "0x600CE80")]
    [Address(RVA = "0x999690", Offset = "0x998490", VA = "0x10999690")]
    public Vector2 GetCurrentTabAnchore() => new Vector2();

    [Token(Token = "0x600CE81")]
    [Address(RVA = "0x99A670", Offset = "0x999470", VA = "0x1099A670")]
    public UnitListRootWindow.Tab GetTab(EElement element) => new UnitListRootWindow.Tab();

    [Token(Token = "0x600CE82")]
    [Address(RVA = "0x999880", Offset = "0x998680", VA = "0x10999880")]
    public static EElement GetElement(UnitListRootWindow.Tab tab) => new EElement();

    [Token(Token = "0x600CE83")]
    [Address(RVA = "0x999830", Offset = "0x998630", VA = "0x10999830")]
    public EElement GetElement() => new EElement();

    [Token(Token = "0x600CE84")]
    [Address(RVA = "0x996440", Offset = "0x995240", VA = "0x10996440")]
    public void CalcUnit(List<UnitListWindow.Data> list)
    {
    }

    [Token(Token = "0x600CE85")]
    [Address(RVA = "0x99A6D0", Offset = "0x9994D0", VA = "0x1099A6D0")]
    public void InitializeContentList(UnitListRootWindow.ContentType contentType)
    {
    }

    [Token(Token = "0x600CE86")]
    [Address(RVA = "0x99C400", Offset = "0x99B200", VA = "0x1099C400")]
    public void RefreshContentList()
    {
    }

    [Token(Token = "0x600CE87")]
    [Address(RVA = "0x99C6B0", Offset = "0x99B4B0", VA = "0x1099C6B0")]
    public void ReleaseContentList()
    {
    }

    [Token(Token = "0x600CE88")]
    [Address(RVA = "0x99EE90", Offset = "0x99DC90", VA = "0x1099EE90")]
    private void ShowToolTip(string path, UnitData unit)
    {
    }

    [Token(Token = "0x600CE89")]
    [Address(RVA = "0x36F5F0", Offset = "0x36E3F0", VA = "0x1036F5F0")]
    public void SetRoot(UnitListWindow root)
    {
    }

    [Token(Token = "0x600CE8A")]
    [Address(RVA = "0x9964D0", Offset = "0x9952D0", VA = "0x109964D0")]
    public void ClearData()
    {
    }

    [Token(Token = "0x600CE8B")]
    [Address(RVA = "0x99C7D0", Offset = "0x99B5D0", VA = "0x1099C7D0")]
    public void RemoveData(string key)
    {
    }

    [Token(Token = "0x600CE8C")]
    [Address(RVA = "0x9961F0", Offset = "0x994FF0", VA = "0x109961F0")]
    public void AddData(string key, object value)
    {
    }

    [Token(Token = "0x600CE8D")]
    [Address(RVA = "0x999800", Offset = "0x998600", VA = "0x10999800")]
    public object GetData(string key) => (object) null;

    [Token(Token = "0x600CE8E")]
    [Address(RVA = "0x9997D0", Offset = "0x9985D0", VA = "0x109997D0")]
    public object GetData(string key, object defaultValue) => (object) null;

    [Token(Token = "0x600CE8F")]
    public T GetData<T>(string key) => (T) null;

    [Token(Token = "0x600CE90")]
    public T GetData<T>(string key, T defaultValue) => (T) null;

    [Token(Token = "0x600CE91")]
    [Address(RVA = "0x288000", Offset = "0x286E00", VA = "0x10288000")]
    public UnitListWindow.EditType GetEditType() => new UnitListWindow.EditType();

    [Token(Token = "0x600CE92")]
    [Address(RVA = "0x99B160", Offset = "0x999F60", VA = "0x1099B160")]
    public bool IsPartyEdit(UnitListWindow.EditType editType) => new bool();

    [Token(Token = "0x600CE93")]
    [Address(RVA = "0x2AABE0", Offset = "0x2A99E0", VA = "0x102AABE0")]
    public UnitListRootWindow.ContentType GetContentType() => new UnitListRootWindow.ContentType();

    [Token(Token = "0x600CE94")]
    [Address(RVA = "0x9962B0", Offset = "0x9950B0", VA = "0x109962B0")]
    public RectTransform AttachSlotLabel(UnitListWindow.Data data, ContentNode node)
    {
      return (RectTransform) null;
    }

    [Token(Token = "0x600CE95")]
    [Address(RVA = "0x999240", Offset = "0x998040", VA = "0x10999240")]
    public void DettachSlotLabel(RectTransform tr)
    {
    }

    [Token(Token = "0x600CE96")]
    [Address(RVA = "0x99C4F0", Offset = "0x99B2F0", VA = "0x1099C4F0")]
    public void RegistAnchorePos(Vector2 pos)
    {
    }

    [Token(Token = "0x600CE97")]
    [Address(RVA = "0x99C640", Offset = "0x99B440", VA = "0x1099C640")]
    public void RegistAnchorePos(string key, Vector2 pos)
    {
    }

    [Token(Token = "0x600CE98")]
    [Address(RVA = "0x99C190", Offset = "0x99AF90", VA = "0x1099C190", Slot = "9")]
    public override int OnActivate(int pinId) => new int();

    [Token(Token = "0x600CE99")]
    [Address(RVA = "0x99B200", Offset = "0x99A000", VA = "0x1099B200")]
    private int OnActivate_Base(int pinId) => new int();

    [Token(Token = "0x600CE9A")]
    [Address(RVA = "0x99C3F0", Offset = "0x99B1F0", VA = "0x1099C3F0", Slot = "10")]
    protected override int OnOpened() => new int();

    [Token(Token = "0x600CE9B")]
    [Address(RVA = "0x99C3D0", Offset = "0x99B1D0", VA = "0x1099C3D0", Slot = "11")]
    protected override int OnClosed() => new int();

    [Token(Token = "0x600CE9C")]
    [Address(RVA = "0x99A5F0", Offset = "0x9993F0", VA = "0x1099A5F0")]
    public static UnitListRootWindow.Tab GetTabMask(UnitListWindow.Data data)
    {
      return new UnitListRootWindow.Tab();
    }

    [Token(Token = "0x600CE9D")]
    [Address(RVA = "0x99A810", Offset = "0x999610", VA = "0x1099A810")]
    private void InitializePieceList()
    {
    }

    [Token(Token = "0x600CE9E")]
    [Address(RVA = "0x996580", Offset = "0x995380", VA = "0x10996580")]
    public UnitListRootWindow.ListData CreatePieceList() => (UnitListRootWindow.ListData) null;

    [Token(Token = "0x600CE9F")]
    [Address(RVA = "0x99CBB0", Offset = "0x99B9B0", VA = "0x1099CBB0")]
    private UnitListRootWindow.Content.ItemSource SetupPieceList(
      UnitListRootWindow.Content.ItemSource source)
    {
      return (UnitListRootWindow.Content.ItemSource) null;
    }

    [Token(Token = "0x600CEA0")]
    [Address(RVA = "0x99B3A0", Offset = "0x99A1A0", VA = "0x1099B3A0")]
    private int OnActivate_Piece(int pinId) => new int();

    [Token(Token = "0x600CEA1")]
    [Address(RVA = "0x99A8F0", Offset = "0x9996F0", VA = "0x1099A8F0")]
    private void InitializeSupportList()
    {
    }

    [Token(Token = "0x600CEA2")]
    [Address(RVA = "0x99F290", Offset = "0x99E090", VA = "0x1099F290")]
    private void Update_Support()
    {
    }

    [Token(Token = "0x600CEA3")]
    [Address(RVA = "0x99A3E0", Offset = "0x9991E0", VA = "0x1099A3E0")]
    private string GetSupportListKey(EElement element) => (string) null;

    [Token(Token = "0x600CEA4")]
    [Address(RVA = "0x99A490", Offset = "0x999290", VA = "0x1099A490")]
    private UnitListRootWindow.ListData GetSupportList(EElement element)
    {
      return (UnitListRootWindow.ListData) null;
    }

    [Token(Token = "0x600CEA5")]
    [Address(RVA = "0x99A450", Offset = "0x999250", VA = "0x1099A450")]
    private UnitListRootWindow.ListData GetSupportList(FlowNode_ReqSupportList.SupportList support)
    {
      return (UnitListRootWindow.ListData) null;
    }

    [Token(Token = "0x600CEA6")]
    [Address(RVA = "0x996A60", Offset = "0x995860", VA = "0x10996A60")]
    public UnitListRootWindow.ListData CreateSupportList(EElement element)
    {
      return (UnitListRootWindow.ListData) null;
    }

    [Token(Token = "0x600CEA7")]
    [Address(RVA = "0x99B190", Offset = "0x999F90", VA = "0x1099B190")]
    private bool IsSameSupportUnit(SupportData sup_1, SupportData sup_2) => new bool();

    [Token(Token = "0x600CEA8")]
    [Address(RVA = "0x9993A0", Offset = "0x9981A0", VA = "0x109993A0")]
    private bool FindIncludingTeamIndexFromSupport(
      SupportData[] supports,
      SupportData target,
      out int index)
    {
      return new bool();
    }

    [Token(Token = "0x600CEA9")]
    [Address(RVA = "0x99D120", Offset = "0x99BF20", VA = "0x1099D120")]
    private UnitListRootWindow.Content.ItemSource SetupSupportList(
      UnitListRootWindow.Content.ItemSource source)
    {
      return (UnitListRootWindow.Content.ItemSource) null;
    }

    [Token(Token = "0x600CEAA")]
    [Address(RVA = "0x99A0A0", Offset = "0x998EA0", VA = "0x1099A0A0")]
    private int GetOutputSupportWebApiPin(EElement element, bool isForce) => new int();

    [Token(Token = "0x600CEAB")]
    [Address(RVA = "0x99B520", Offset = "0x99A320", VA = "0x1099B520")]
    private int OnActivate_Support(int pinId) => new int();

    [Token(Token = "0x600CEAC")]
    [Address(RVA = "0x99AA70", Offset = "0x999870", VA = "0x1099AA70")]
    private void InitializeUnitList()
    {
    }

    [Token(Token = "0x600CEAD")]
    [Address(RVA = "0x996EA0", Offset = "0x995CA0", VA = "0x10996EA0")]
    public UnitListRootWindow.ListData CreateUnitList(
      UnitListWindow.EditType editType,
      UnitData[] units)
    {
      return (UnitListRootWindow.ListData) null;
    }

    [Token(Token = "0x600CEAE")]
    [Address(RVA = "0x999300", Offset = "0x998100", VA = "0x10999300")]
    private bool FindIncludingTeamIndexFromParty(
      PartyEditData[] partyEditDataAry,
      long uniqueID,
      out int index)
    {
      return new bool();
    }

    [Token(Token = "0x600CEAF")]
    [Address(RVA = "0x998DF0", Offset = "0x997BF0", VA = "0x10998DF0")]
    public void CreateUnitSameList(
      PartyEditData edit,
      int selectSlot,
      QuestParam quest,
      out List<UnitSameGroupParam> unitSameGroupList,
      out List<string> unitSameNameList)
    {
    }

    [Token(Token = "0x600CEB0")]
    [Address(RVA = "0x99DB70", Offset = "0x99C970", VA = "0x1099DB70")]
    private UnitListRootWindow.Content.ItemSource SetupUnitList(
      UnitListRootWindow.Content.ItemSource source)
    {
      return (UnitListRootWindow.Content.ItemSource) null;
    }

    [Token(Token = "0x600CEB1")]
    [Address(RVA = "0x99A100", Offset = "0x998F00", VA = "0x1099A100")]
    private void GetPartyList(bool hasRentalUnit, ref UnitListRootWindow.ListData list)
    {
    }

    [Token(Token = "0x600CEB2")]
    [Address(RVA = "0x999410", Offset = "0x998210", VA = "0x10999410")]
    private void GetAdventureList(ref UnitListRootWindow.ListData list)
    {
    }

    [Token(Token = "0x600CEB3")]
    [Address(RVA = "0x9998D0", Offset = "0x9986D0", VA = "0x109998D0")]
    private void GetGuildTrainingList(ref UnitListRootWindow.ListData list)
    {
    }

    [Token(Token = "0x600CEB4")]
    [Address(RVA = "0x999CB0", Offset = "0x998AB0", VA = "0x10999CB0")]
    private void GetLeagueMatchList(ref UnitListRootWindow.ListData list)
    {
    }

    [Token(Token = "0x600CEB5")]
    [Address(RVA = "0x999AD0", Offset = "0x9988D0", VA = "0x10999AD0")]
    private void GetLeagueMatchAtkSetList(ref UnitListRootWindow.ListData list)
    {
    }

    [Token(Token = "0x600CEB6")]
    [Address(RVA = "0x99C940", Offset = "0x99B740", VA = "0x1099C940")]
    private void SaveToggleBtn()
    {
    }

    [Token(Token = "0x600CEB7")]
    [Address(RVA = "0x99CA20", Offset = "0x99B820", VA = "0x1099CA20")]
    private void SetToggleBtn(string tglName)
    {
    }

    [Token(Token = "0x600CEB8")]
    [Address(RVA = "0x99B950", Offset = "0x99A750", VA = "0x1099B950")]
    private int OnActivate_Unit(int pinId) => new int();

    [Token(Token = "0x600CEB9")]
    [Address(RVA = "0x99F3F0", Offset = "0x99E1F0", VA = "0x1099F3F0")]
    public UnitListRootWindow()
    {
    }

    [Token(Token = "0x2002C88")]
    public enum ContentType
    {
      [Token(Token = "0x400DCA0")] NONE,
      [Token(Token = "0x400DCA1")] UNIT,
      [Token(Token = "0x400DCA2")] PIECE,
      [Token(Token = "0x400DCA3")] SUPPORT,
    }

    [Token(Token = "0x2002C89")]
    public enum Tab
    {
      [Token(Token = "0x400DCA5")] NONE = 0,
      [Token(Token = "0x400DCA7")] FAVORITE = 1,
      [Token(Token = "0x400DCA8")] FIRE = 2,
      [Token(Token = "0x400DCA9")] WATER = 4,
      [Token(Token = "0x400DCAA")] THUNDER = 8,
      [Token(Token = "0x400DCAB")] WIND = 16, // 0x00000010
      [Token(Token = "0x400DCAC")] LIGHT = 32, // 0x00000020
      [Token(Token = "0x400DCAD")] DARK = 64, // 0x00000040
      [Token(Token = "0x400DCAE")] MAINSUPPORT = 128, // 0x00000080
      [Token(Token = "0x400DCA6")] ALL = 65535, // 0x0000FFFF
    }

    [Token(Token = "0x2002C8A")]
    public static class Content
    {
      [Token(Token = "0x400DCAF")]
      [FieldOffset(Offset = "0x0")]
      public static UnitListRootWindow.Content.ItemAccessor clickItem;

      [Token(Token = "0x2002C8B")]
      public class ItemAccessor
      {
        [Token(Token = "0x400DCB0")]
        [FieldOffset(Offset = "0x0")]
        private static readonly string SVB_KEY_BODY;
        [Token(Token = "0x400DCB1")]
        [FieldOffset(Offset = "0x4")]
        private static readonly string SVB_KEY_SELECT;
        [Token(Token = "0x400DCB2")]
        [FieldOffset(Offset = "0x8")]
        private static readonly string SVB_KEY_TEAM;
        [Token(Token = "0x400DCB3")]
        [FieldOffset(Offset = "0xC")]
        private static readonly string SVB_KEY_USE;
        [Token(Token = "0x400DCB4")]
        [FieldOffset(Offset = "0x10")]
        private static readonly string SVB_KEY_BADGE;
        [Token(Token = "0x400DCB5")]
        [FieldOffset(Offset = "0x14")]
        private static readonly string SVB_KEY_DIED;
        [Token(Token = "0x400DCB6")]
        [FieldOffset(Offset = "0x18")]
        private static readonly string SVB_KEY_NO_ENTRY;
        [Token(Token = "0x400DCB7")]
        [FieldOffset(Offset = "0x1C")]
        private static readonly string SVB_KEY_SAME_UNIT;
        [Token(Token = "0x400DCB8")]
        [FieldOffset(Offset = "0x20")]
        private static readonly string SVB_KEY_NO_EQUIP;
        [Token(Token = "0x400DCB9")]
        [FieldOffset(Offset = "0x24")]
        private static readonly string SVB_KEY_FRIEND;
        [Token(Token = "0x400DCBA")]
        [FieldOffset(Offset = "0x28")]
        private static readonly string SVB_KEY_LOCKED;
        [Token(Token = "0x400DCBB")]
        [FieldOffset(Offset = "0x2C")]
        private static readonly string SVB_KEY_SORT;
        [Token(Token = "0x400DCBC")]
        [FieldOffset(Offset = "0x30")]
        private static readonly string SVB_KEY_LEVEL;
        [Token(Token = "0x400DCBD")]
        [FieldOffset(Offset = "0x34")]
        private static readonly string SVB_KEY_GVG_USED_UNIT;
        [Token(Token = "0x400DCBE")]
        [FieldOffset(Offset = "0x38")]
        private static readonly string SVB_KEY_GVG_USED_TEXT;
        [Token(Token = "0x400DCBF")]
        [FieldOffset(Offset = "0x3C")]
        private static readonly string SVB_KEY_GVG_PARTY_NUM;
        [Token(Token = "0x400DCC0")]
        [FieldOffset(Offset = "0x40")]
        private static readonly string SVB_KEY_GVG_PARTY_TEXT;
        [Token(Token = "0x400DCC1")]
        [FieldOffset(Offset = "0x44")]
        private static readonly string SVB_KEY_USED_ADVENTURE;
        [Token(Token = "0x400DCC2")]
        [FieldOffset(Offset = "0x48")]
        private static readonly string SVB_KEY_GUILD_TRAINING;
        [Token(Token = "0x400DCC3")]
        [FieldOffset(Offset = "0x4C")]
        private static readonly string SVB_KEY_GUILD_TRAINING_SET;
        [Token(Token = "0x400DCC4")]
        [FieldOffset(Offset = "0x50")]
        private static readonly string SVB_KEY_GUILD_TRAINING_PERIOD;
        [Token(Token = "0x400DCC5")]
        [FieldOffset(Offset = "0x54")]
        private static readonly string SVB_KEY_USED_UNIT;
        [Token(Token = "0x400DCC6")]
        [FieldOffset(Offset = "0x58")]
        private static readonly string SVB_KEY_SORT_RESONANCE;
        [Token(Token = "0x400DCC7")]
        [FieldOffset(Offset = "0x5C")]
        private static readonly string SVB_KEY_BEFORE;
        [Token(Token = "0x400DCC8")]
        [FieldOffset(Offset = "0x60")]
        private static readonly string SVB_KEY_NEXT;
        [Token(Token = "0x400DCC9")]
        [FieldOffset(Offset = "0x64")]
        private static readonly string SVB_KEY_NEXT2;
        [Token(Token = "0x400DCCA")]
        [FieldOffset(Offset = "0x68")]
        private static readonly string SVB_KEY_PVE_BADGE;
        [Token(Token = "0x400DCCB")]
        [FieldOffset(Offset = "0x8")]
        private UnitListRootWindow m_RootWindow;
        [Token(Token = "0x400DCCC")]
        [FieldOffset(Offset = "0xC")]
        private UnitListSortWindow m_SortWindow;
        [Token(Token = "0x400DCCD")]
        [FieldOffset(Offset = "0x10")]
        private UnitListRootWindow.ContentType m_ContentType;
        [Token(Token = "0x400DCCE")]
        [FieldOffset(Offset = "0x14")]
        private ContentNode m_Node;
        [Token(Token = "0x400DCCF")]
        [FieldOffset(Offset = "0x18")]
        private UnitListWindow.Data m_Param;
        [Token(Token = "0x400DCD0")]
        [FieldOffset(Offset = "0x1C")]
        private DataSource m_DataSource;
        [Token(Token = "0x400DCD1")]
        [FieldOffset(Offset = "0x20")]
        private SerializeValueBehaviour m_Value;
        [Token(Token = "0x400DCD2")]
        [FieldOffset(Offset = "0x24")]
        private SortBadge m_SortBadge;
        [Token(Token = "0x400DCD3")]
        [FieldOffset(Offset = "0x28")]
        private RectTransform m_SlotLabel;
        [Token(Token = "0x400DCD4")]
        [FieldOffset(Offset = "0x2C")]
        private SortBadge m_ResonanceSortBadge;

        [Token(Token = "0x17001B36")]
        public ContentNode node
        {
          [Token(Token = "0x600CEBA"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
          {
            return (ContentNode) null;
          }
        }

        [Token(Token = "0x17001B37")]
        public UnitListWindow.Data param
        {
          [Token(Token = "0x600CEBB"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
          {
            return (UnitListWindow.Data) null;
          }
        }

        [Token(Token = "0x17001B38")]
        public bool isValid
        {
          [Token(Token = "0x600CEBC"), Address(RVA = "0x3B3010", Offset = "0x3B1E10", VA = "0x103B3010")] get
          {
            return new bool();
          }
        }

        [Token(Token = "0x600CEBD")]
        [Address(RVA = "0x990CB0", Offset = "0x98FAB0", VA = "0x10990CB0")]
        public void Setup(UnitListWindow window, UnitListWindow.Data param)
        {
        }

        [Token(Token = "0x600CEBE")]
        [Address(RVA = "0x990690", Offset = "0x98F490", VA = "0x10990690")]
        public void Release()
        {
        }

        [Token(Token = "0x600CEBF")]
        [Address(RVA = "0x98EA30", Offset = "0x98D830", VA = "0x1098EA30")]
        public void Bind(ContentNode node)
        {
        }

        [Token(Token = "0x600CEC0")]
        [Address(RVA = "0x9907A0", Offset = "0x98F5A0", VA = "0x109907A0")]
        private void SetImageEnabled(string key)
        {
        }

        [Token(Token = "0x600CEC1")]
        [Address(RVA = "0x98E8D0", Offset = "0x98D6D0", VA = "0x1098E8D0")]
        private void AddSwitchiSlotLabel()
        {
        }

        [Token(Token = "0x600CEC2")]
        [Address(RVA = "0x98E940", Offset = "0x98D740", VA = "0x1098E940")]
        private void AddSwitchingBadge(GameObject go)
        {
        }

        [Token(Token = "0x600CEC3")]
        [Address(RVA = "0x990480", Offset = "0x98F280", VA = "0x10990480")]
        public void Clear()
        {
        }

        [Token(Token = "0x600CEC4")]
        [Address(RVA = "0x990570", Offset = "0x98F370", VA = "0x10990570")]
        public void ForceUpdate()
        {
        }

        [Token(Token = "0x600CEC5")]
        [Address(RVA = "0x990610", Offset = "0x98F410", VA = "0x10990610")]
        public void LateUpdate()
        {
        }

        [Token(Token = "0x600CEC6")]
        [Address(RVA = "0x990850", Offset = "0x98F650", VA = "0x10990850")]
        public void SetSortValue(UnitListSortWindow.SelectType section, int value, string name = "")
        {
        }

        [Token(Token = "0x600CEC7")]
        [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
        public ItemAccessor()
        {
        }

        [Token(Token = "0x600CEC8")]
        [Address(RVA = "0x990D50", Offset = "0x98FB50", VA = "0x10990D50")]
        static ItemAccessor()
        {
        }
      }

      [Token(Token = "0x2002C8C")]
      public class ItemSource : ContentSource
      {
        [Token(Token = "0x400DCD5")]
        [FieldOffset(Offset = "0x10")]
        private List<UnitListRootWindow.Content.ItemSource.ItemParam> m_Params;
        [Token(Token = "0x400DCD6")]
        [FieldOffset(Offset = "0x14")]
        private Vector2 m_AnchorePos;
        [Token(Token = "0x400DCD7")]
        [FieldOffset(Offset = "0x1C")]
        private int m_Forcus;

        [Token(Token = "0x600CEC9")]
        [Address(RVA = "0x9A0C40", Offset = "0x99FA40", VA = "0x109A0C40", Slot = "4")]
        public override void Initialize(ContentController controller)
        {
        }

        [Token(Token = "0x600CECA")]
        [Address(RVA = "0x9A0C60", Offset = "0x99FA60", VA = "0x109A0C60", Slot = "5")]
        public override void Release()
        {
        }

        [Token(Token = "0x600CECB")]
        [Address(RVA = "0x9A0BC0", Offset = "0x99F9C0", VA = "0x109A0BC0")]
        public int Add(
          UnitListRootWindow.Content.ItemSource.ItemParam param)
        {
          return new int();
        }

        [Token(Token = "0x600CECC")]
        [Address(RVA = "0x9A0C20", Offset = "0x99FA20", VA = "0x109A0C20")]
        public void AnchorePos(Vector2 pos)
        {
        }

        [Token(Token = "0x600CECD")]
        [Address(RVA = "0x35B870", Offset = "0x35A670", VA = "0x1035B870")]
        public void ForcusIndex(int index)
        {
        }

        [Token(Token = "0x600CECE")]
        [Address(RVA = "0x9A0CC0", Offset = "0x99FAC0", VA = "0x109A0CC0")]
        public void Setup()
        {
        }

        [Token(Token = "0x600CECF")]
        [Address(RVA = "0x9A0F70", Offset = "0x99FD70", VA = "0x109A0F70")]
        public ItemSource()
        {
        }

        [Token(Token = "0x2002C8D")]
        public class ItemParam : ContentSource.Param
        {
          [Token(Token = "0x400DCD8")]
          [FieldOffset(Offset = "0x10")]
          private UnitListRootWindow.Content.ItemAccessor m_Accessor;

          [Token(Token = "0x600CED0")]
          [Address(RVA = "0x9A0A50", Offset = "0x99F850", VA = "0x109A0A50", Slot = "6")]
          public override bool IsValid() => new bool();

          [Token(Token = "0x17001B39")]
          public UnitListRootWindow.Content.ItemAccessor accerror
          {
            [Token(Token = "0x600CED1"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
            {
              return (UnitListRootWindow.Content.ItemAccessor) null;
            }
          }

          [Token(Token = "0x600CED2")]
          [Address(RVA = "0x9A0B40", Offset = "0x99F940", VA = "0x109A0B40")]
          public ItemParam(UnitListWindow window, UnitListWindow.Data param)
          {
          }

          [Token(Token = "0x600CED3")]
          [Address(RVA = "0x9A0B10", Offset = "0x99F910", VA = "0x109A0B10", Slot = "5")]
          public override void Release()
          {
          }

          [Token(Token = "0x600CED4")]
          [Address(RVA = "0x9A0A80", Offset = "0x99F880", VA = "0x109A0A80", Slot = "10")]
          public override void LateUpdate()
          {
          }

          [Token(Token = "0x600CED5")]
          [Address(RVA = "0x9A0AD0", Offset = "0x99F8D0", VA = "0x109A0AD0", Slot = "12")]
          public override void OnEnable(ContentNode node)
          {
          }

          [Token(Token = "0x600CED6")]
          [Address(RVA = "0x9A0AB0", Offset = "0x99F8B0", VA = "0x109A0AB0", Slot = "13")]
          public override void OnDisable(ContentNode node)
          {
          }

          [Token(Token = "0x600CED7")]
          [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "19")]
          public override void OnClick(ContentNode node)
          {
          }
        }
      }
    }

    [Token(Token = "0x2002C8E")]
    [Serializable]
    public class SerializeParam : FlowWindowBase.SerializeParamBase
    {
      [Token(Token = "0x400DCD9")]
      [FieldOffset(Offset = "0xC")]
      public string unitList;
      [Token(Token = "0x400DCDA")]
      [FieldOffset(Offset = "0x10")]
      public string pieceList;
      [Token(Token = "0x400DCDB")]
      [FieldOffset(Offset = "0x14")]
      public string supportList;
      [Token(Token = "0x400DCDC")]
      [FieldOffset(Offset = "0x18")]
      public GameObject listParent;
      [Token(Token = "0x400DCDD")]
      [FieldOffset(Offset = "0x1C")]
      public string tooltipPrefab;

      [Token(Token = "0x17001B3A")]
      public override System.Type type
      {
        [Token(Token = "0x600CED8"), Address(RVA = "0x9A1460", Offset = "0x9A0260", VA = "0x109A1460", Slot = "4")] get
        {
          return (System.Type) null;
        }
      }

      [Token(Token = "0x600CED9")]
      [Address(RVA = "0x2ECB10", Offset = "0x2EB910", VA = "0x102ECB10")]
      public SerializeParam()
      {
      }
    }

    [Token(Token = "0x2002C8F")]
    public class ListData
    {
      [Token(Token = "0x400DCDE")]
      [FieldOffset(Offset = "0x8")]
      public bool isValid;
      [Token(Token = "0x400DCDF")]
      [FieldOffset(Offset = "0xC")]
      public string key;
      [Token(Token = "0x400DCE0")]
      [FieldOffset(Offset = "0x10")]
      public object response;
      [Token(Token = "0x400DCE1")]
      [FieldOffset(Offset = "0x14")]
      public List<UnitListWindow.Data> data;
      [Token(Token = "0x400DCE2")]
      [FieldOffset(Offset = "0x18")]
      public List<UnitListWindow.Data> calcData;
      [Token(Token = "0x400DCE3")]
      [FieldOffset(Offset = "0x1C")]
      public Vector2 anchorePos;
      [Token(Token = "0x400DCE4")]
      [FieldOffset(Offset = "0x24")]
      public UnitListRootWindow.Tab selectTab;
      [Token(Token = "0x400DCE5")]
      [FieldOffset(Offset = "0x28")]
      public long selectUniqueID;

      [Token(Token = "0x600CEDA")]
      [Address(RVA = "0x9A1030", Offset = "0x99FE30", VA = "0x109A1030")]
      public void Delete()
      {
      }

      [Token(Token = "0x600CEDB")]
      [Address(RVA = "0x9A1250", Offset = "0x9A0050", VA = "0x109A1250")]
      public void Refresh()
      {
      }

      [Token(Token = "0x600CEDC")]
      [Address(RVA = "0x9A11A0", Offset = "0x99FFA0", VA = "0x109A11A0")]
      public void RefreshTabMask()
      {
      }

      [Token(Token = "0x600CEDD")]
      [Address(RVA = "0x9A10C0", Offset = "0x99FEC0", VA = "0x109A10C0")]
      public List<long> GetUniqs() => (List<long>) null;

      [Token(Token = "0x600CEDE")]
      [Address(RVA = "0x9A1310", Offset = "0x9A0110", VA = "0x109A1310")]
      public ListData()
      {
      }
    }

    [Token(Token = "0x2002C90")]
    public class TabRegister
    {
      [Token(Token = "0x400DCE6")]
      [FieldOffset(Offset = "0x8")]
      public UnitListRootWindow.Tab tab;
      [Token(Token = "0x400DCE7")]
      [FieldOffset(Offset = "0xC")]
      public Vector2 anchorePos;
      [Token(Token = "0x400DCE8")]
      [FieldOffset(Offset = "0x18")]
      public long forcus;

      [Token(Token = "0x600CEDF")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public TabRegister()
      {
      }
    }

    [Token(Token = "0x2002C91")]
    protected class Json_ReqSupporterResponse
    {
      [Token(Token = "0x400DCE9")]
      [FieldOffset(Offset = "0x8")]
      public Json_Support[] supports;

      [Token(Token = "0x600CEE0")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public Json_ReqSupporterResponse()
      {
      }
    }
  }
}

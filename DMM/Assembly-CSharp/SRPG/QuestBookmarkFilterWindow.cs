// Decompiled with JetBrains decompiler
// Type: SRPG.QuestBookmarkFilterWindow
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
  [Token(Token = "0x20020DC")]
  [AddComponentMenu("UI/Bookmark/QuestBookmarkFilterWindow")]
  [FlowNode.Pin(32, "終了ボタンが押された", FlowNode.PinTypes.Input, 32)]
  [FlowNode.Pin(31, "フィルタを実行する", FlowNode.PinTypes.Input, 31)]
  [FlowNode.Pin(101, "閉じる", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(22, "全フィルターを選択", FlowNode.PinTypes.Input, 22)]
  [FlowNode.Pin(21, "フィルタを選択", FlowNode.PinTypes.Input, 21)]
  [FlowNode.Pin(11, "タブが選択された", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(1, "初期化", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(23, "フィルタークリア", FlowNode.PinTypes.Input, 23)]
  public class QuestBookmarkFilterWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4008DE5")]
    private const string SVB_KEY_SCROLL_RECT = "scroll_rect";
    [Token(Token = "0x4008DE6")]
    private const string SVB_KEY_TAB_PARENT = "tab_btn_parent";
    [Token(Token = "0x4008DE7")]
    private const string SVB_KEY_TAB_TEMPLATE = "tab_btn_template";
    [Token(Token = "0x4008DE8")]
    private const string SVB_KEY_CATEGORY_RARITY = "category_rarity";
    [Token(Token = "0x4008DE9")]
    private const string SVB_KEY_CATEGORY_JOB = "category_job";
    [Token(Token = "0x4008DEA")]
    private const string SVB_KEY_CATEGORY_BIRTH = "category_birth";
    [Token(Token = "0x4008DEB")]
    private const string SVB_KEY_CATEGORY_SEX = "category_sex";
    [Token(Token = "0x4008DEC")]
    private const string SVB_KEY_CATEGORY_UNIT = "category_unit";
    [Token(Token = "0x4008DED")]
    private const string SVB_KEY_CATEGORY_ARTIFACT = "category_artifact";
    [Token(Token = "0x4008DEE")]
    private const string SVB_KEY_CATEGORY_ELEMENT = "category_element";
    [Token(Token = "0x4008DEF")]
    private const string PrefsFilterKey = "PREFS_KEY_BOOKMARK_FILTER_UNIT";
    [Token(Token = "0x4008DF0")]
    private const int PIN_INPUT_INIT = 1;
    [Token(Token = "0x4008DF1")]
    private const int PIN_INPUT_SELECT_TAB = 11;
    [Token(Token = "0x4008DF2")]
    private const int PIN_INPUT_FILTER = 21;
    [Token(Token = "0x4008DF3")]
    private const int PIN_INPUT_FILTER_ALL = 22;
    [Token(Token = "0x4008DF4")]
    private const int PIN_INPUT_FILTER_CLEAR = 23;
    [Token(Token = "0x4008DF5")]
    private const int PIN_INPUT_EXECUTE_FILTER = 31;
    [Token(Token = "0x4008DF6")]
    private const int PIN_INPUT_CLOSE = 32;
    [Token(Token = "0x4008DF7")]
    private const int PIN_OUTPUT_CLOSE = 101;
    [Token(Token = "0x4008DF8")]
    [FieldOffset(Offset = "0xC")]
    private SerializeValueBehaviour m_TargetPrefabSVB;
    [Token(Token = "0x4008DF9")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject[] ElementObject;
    [Token(Token = "0x4008DFA")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject m_Animator;
    [Token(Token = "0x4008DFB")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ScrollRect m_ScrollRect;
    [Token(Token = "0x4008DFC")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private CanvasGroup mWindowCanvasGroup;
    [Token(Token = "0x4008DFD")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mElement;
    [Token(Token = "0x4008DFE")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Toggle mToggleElementFire;
    [Token(Token = "0x4008DFF")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Toggle mToggleElementWater;
    [Token(Token = "0x4008E00")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Toggle mToggleElementThunder;
    [Token(Token = "0x4008E01")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Toggle mToggleElementWind;
    [Token(Token = "0x4008E02")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Toggle mToggleElementShine;
    [Token(Token = "0x4008E03")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Toggle mToggleElementDark;
    [Token(Token = "0x4008E04")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private SRPG_Button QuestCheckAllClearButton;
    [Token(Token = "0x4008E05")]
    [FieldOffset(Offset = "0x40")]
    private Dictionary<string, FilterUnitTab> m_Tabs;
    [Token(Token = "0x4008E06")]
    [FieldOffset(Offset = "0x44")]
    private Dictionary<string, GameObject> m_ToggleCategory;
    [Token(Token = "0x4008E07")]
    [FieldOffset(Offset = "0x48")]
    private Dictionary<string, Toggle> m_Toggles;
    [Token(Token = "0x4008E08")]
    [FieldOffset(Offset = "0x4C")]
    private Dictionary<string, QuestBookmarkFilterWindow.FilterValue> m_SelectType;
    [Token(Token = "0x4008E09")]
    [FieldOffset(Offset = "0x50")]
    private Dictionary<string, QuestBookmarkFilterWindow.FilterValue> m_SelectTypeReg;
    [Token(Token = "0x4008E0A")]
    [FieldOffset(Offset = "0x54")]
    private Dictionary<EElement, Toggle> m_Element_Toggles;
    [Token(Token = "0x4008E0B")]
    [FieldOffset(Offset = "0x58")]
    private Dictionary<EElement, bool> m_SelectElementType;
    [Token(Token = "0x4008E0C")]
    [FieldOffset(Offset = "0x5C")]
    private Dictionary<EElement, bool> m_SelectElementTypeReg;
    [Token(Token = "0x4008E0D")]
    [FieldOffset(Offset = "0x60")]
    private string mCurrentTab;
    [Token(Token = "0x4008E0E")]
    [FieldOffset(Offset = "0x64")]
    private string mFirstTab;
    [Token(Token = "0x4008E0F")]
    [FieldOffset(Offset = "0x68")]
    private string mEndTab;
    [Token(Token = "0x4008E10")]
    [FieldOffset(Offset = "0x0")]
    private static QuestBookmarkFilterWindow mInstance;

    [Token(Token = "0x1700135B")]
    public static QuestBookmarkFilterWindow Instance
    {
      [Token(Token = "0x6008910"), Address(RVA = "0x4B3000", Offset = "0x4B1E00", VA = "0x104B3000")] get
      {
        return (QuestBookmarkFilterWindow) null;
      }
    }

    [Token(Token = "0x6008911")]
    [Address(RVA = "0x4AEF60", Offset = "0x4ADD60", VA = "0x104AEF60")]
    private void Awake()
    {
    }

    [Token(Token = "0x6008912")]
    [Address(RVA = "0x4B1770", Offset = "0x4B0570", VA = "0x104B1770")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6008913")]
    [Address(RVA = "0x4AEE90", Offset = "0x4ADC90", VA = "0x104AEE90", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008914")]
    [Address(RVA = "0x4B0630", Offset = "0x4AF430", VA = "0x104B0630")]
    private void Init()
    {
    }

    [Token(Token = "0x6008915")]
    [Address(RVA = "0x4AEFA0", Offset = "0x4ADDA0", VA = "0x104AEFA0")]
    private void CacheTabParam()
    {
    }

    [Token(Token = "0x6008916")]
    [Address(RVA = "0x4AF3A0", Offset = "0x4AE1A0", VA = "0x104AF3A0")]
    private void CacheToggleParam(GameObject toggle_parent_obj)
    {
    }

    [Token(Token = "0x6008917")]
    [Address(RVA = "0x4B24B0", Offset = "0x4B12B0", VA = "0x104B24B0")]
    private void SelectTab(string tabName)
    {
    }

    [Token(Token = "0x6008918")]
    [Address(RVA = "0x4B2C80", Offset = "0x4B1A80", VA = "0x104B2C80")]
    private void UpdateTabState()
    {
    }

    [Token(Token = "0x6008919")]
    [Address(RVA = "0x4AFF90", Offset = "0x4AED90", VA = "0x104AFF90")]
    private bool ContainsActiveFilterInTab(string tab) => new bool();

    [Token(Token = "0x600891A")]
    [Address(RVA = "0x4B1AA0", Offset = "0x4B08A0", VA = "0x104B1AA0")]
    private void ResetScrollPos()
    {
    }

    [Token(Token = "0x600891B")]
    [Address(RVA = "0x4B2630", Offset = "0x4B1430", VA = "0x104B2630")]
    private void SwitchToggleActiveWithTabName(string tab_name)
    {
    }

    [Token(Token = "0x600891C")]
    [Address(RVA = "0x4B19D0", Offset = "0x4B07D0", VA = "0x104B19D0")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600891D")]
    [Address(RVA = "0x4B1950", Offset = "0x4B0750", VA = "0x104B1950")]
    public void RefreshTab(GameObject btn)
    {
    }

    [Token(Token = "0x600891E")]
    [Address(RVA = "0x4B0160", Offset = "0x4AEF60", VA = "0x104B0160")]
    private void FilterSetup(Toggle toggle, bool value)
    {
    }

    [Token(Token = "0x600891F")]
    [Address(RVA = "0x4B1610", Offset = "0x4B0410", VA = "0x104B1610")]
    private void OnChangeValueElementFilter(bool isOn, EElement element)
    {
    }

    [Token(Token = "0x6008920")]
    [Address(RVA = "0x4B3030", Offset = "0x4B1E30", VA = "0x104B3030")]
    private void onCheckClearButtton(SRPG_Button btn)
    {
    }

    [Token(Token = "0x6008921")]
    [Address(RVA = "0x4B1690", Offset = "0x4B0490", VA = "0x104B1690")]
    private void OnCheckUnitClear(GameObject go)
    {
    }

    [Token(Token = "0x6008922")]
    [Address(RVA = "0x4B02A0", Offset = "0x4AF0A0", VA = "0x104B02A0")]
    private void FilterToggleSetup(bool check)
    {
    }

    [Token(Token = "0x6008923")]
    [Address(RVA = "0x4B0280", Offset = "0x4AF080", VA = "0x104B0280")]
    private void FilterToggleAllOn()
    {
    }

    [Token(Token = "0x6008924")]
    [Address(RVA = "0x4B0260", Offset = "0x4AF060", VA = "0x104B0260")]
    private void FilterToggleAllOff()
    {
    }

    [Token(Token = "0x6008925")]
    [Address(RVA = "0x4B1420", Offset = "0x4B0220", VA = "0x104B1420")]
    public void LoadSelectType()
    {
    }

    [Token(Token = "0x6008926")]
    [Address(RVA = "0x4B1150", Offset = "0x4AFF50", VA = "0x104B1150")]
    public void LoadSelectTypeElement()
    {
    }

    [Token(Token = "0x6008927")]
    [Address(RVA = "0x4B1E30", Offset = "0x4B0C30", VA = "0x104B1E30")]
    public void SaveSelectType()
    {
    }

    [Token(Token = "0x6008928")]
    [Address(RVA = "0x4B1BA0", Offset = "0x4B09A0", VA = "0x104B1BA0")]
    public void SaveSelectElementType()
    {
    }

    [Token(Token = "0x6008929")]
    [Address(RVA = "0x4B2090", Offset = "0x4B0E90", VA = "0x104B2090")]
    private static void SelectCopyTo(
      Dictionary<string, QuestBookmarkFilterWindow.FilterValue> src,
      ref Dictionary<string, QuestBookmarkFilterWindow.FilterValue> dst)
    {
    }

    [Token(Token = "0x600892A")]
    [Address(RVA = "0x4B22F0", Offset = "0x4B10F0", VA = "0x104B22F0")]
    private static void SelectElementCopyTo(
      Dictionary<EElement, bool> src,
      ref Dictionary<EElement, bool> dst)
    {
    }

    [Token(Token = "0x600892B")]
    [Address(RVA = "0x4B0B70", Offset = "0x4AF970", VA = "0x104B0B70")]
    private void InitializeToggleContent()
    {
    }

    [Token(Token = "0x600892C")]
    [Address(RVA = "0x4B09B0", Offset = "0x4AF7B0", VA = "0x104B09B0")]
    private void InitializeElementToggleContent()
    {
    }

    [Token(Token = "0x600892D")]
    [Address(RVA = "0x4B0E90", Offset = "0x4AFC90", VA = "0x104B0E90")]
    private FilterUtility.FilterPrefs LoadPrefs() => (FilterUtility.FilterPrefs) null;

    [Token(Token = "0x600892E")]
    [Address(RVA = "0x4B0D50", Offset = "0x4AFB50", VA = "0x104B0D50")]
    private List<EElement> LoadElementPrefs() => (List<EElement>) null;

    [Token(Token = "0x600892F")]
    [Address(RVA = "0x4B2DE0", Offset = "0x4B1BE0", VA = "0x104B2DE0")]
    public QuestBookmarkFilterWindow()
    {
    }

    [Token(Token = "0x20020DD")]
    private class FilterValue
    {
      [Token(Token = "0x4008E11")]
      [FieldOffset(Offset = "0x8")]
      private string m_Majorkey;
      [Token(Token = "0x4008E12")]
      [FieldOffset(Offset = "0xC")]
      private string m_Minorkey;
      [Token(Token = "0x4008E13")]
      [FieldOffset(Offset = "0x10")]
      private bool m_Value;

      [Token(Token = "0x1700135C")]
      public string MajorKey
      {
        [Token(Token = "0x6008937"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x1700135D")]
      public string Minorkey
      {
        [Token(Token = "0x6008938"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
        {
          return (string) null;
        }
      }

      [Token(Token = "0x1700135E")]
      public bool Value
      {
        [Token(Token = "0x6008939"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
        {
          return new bool();
        }
        [Token(Token = "0x600893A"), Address(RVA = "0x2C73C0", Offset = "0x2C61C0", VA = "0x102C73C0")] set
        {
        }
      }

      [Token(Token = "0x600893B")]
      [Address(RVA = "0x4ACEB0", Offset = "0x4ABCB0", VA = "0x104ACEB0")]
      public FilterValue(string majorKey, string minorKey, bool value)
      {
      }

      [Token(Token = "0x600893C")]
      [Address(RVA = "0x4ACE30", Offset = "0x4ABC30", VA = "0x104ACE30")]
      public QuestBookmarkFilterWindow.FilterValue Clone()
      {
        return (QuestBookmarkFilterWindow.FilterValue) null;
      }
    }
  }
}

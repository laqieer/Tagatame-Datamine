// Decompiled with JetBrains decompiler
// Type: SRPG.EnhanceEquipDetailWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002348")]
  [AddComponentMenu("UI/EnhanceEquipDetailWindow")]
  [FlowNode.Pin(1, "Refresh", FlowNode.PinTypes.Input, 1)]
  [FlowNode.Pin(2, "Reset", FlowNode.PinTypes.Input, 2)]
  [FlowNode.Pin(3, "Max", FlowNode.PinTypes.Input, 3)]
  [FlowNode.Pin(4, "Clear", FlowNode.PinTypes.Input, 4)]
  [FlowNode.Pin(5, "全体強化確認", FlowNode.PinTypes.Input, 5)]
  [FlowNode.Pin(100, "強化", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(101, "全体強化開始", FlowNode.PinTypes.Output, 101)]
  [FlowNode.Pin(200, "コストが足りない", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(201, "素材が足りない", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(300, "  強化失敗", FlowNode.PinTypes.Output, 300)]
  public class EnhanceEquipDetailWindow : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x4009DF9")]
    private const int PIN_IN_REFRESH = 1;
    [Token(Token = "0x4009DFA")]
    private const int PIN_IN_RESET = 2;
    [Token(Token = "0x4009DFB")]
    private const int PIN_IN_MATERIA_MAX = 3;
    [Token(Token = "0x4009DFC")]
    private const int PIN_IN_MATERIA_CLEAR = 4;
    [Token(Token = "0x4009DFD")]
    private const int PIN_IN_STRENGEMAX = 5;
    [Token(Token = "0x4009DFE")]
    private const int PIN_OUT_STRENGE = 100;
    [Token(Token = "0x4009DFF")]
    private const int PIN_OUT_STRENGEMAX = 101;
    [Token(Token = "0x4009E00")]
    private const int PIN_OUT_STRENGECOSTERROR = 200;
    [Token(Token = "0x4009E01")]
    private const int PIN_OUT_STRENGEMATERROR = 201;
    [Token(Token = "0x4009E02")]
    private const int PIN_OUT_ERROR = 300;
    [Token(Token = "0x4009E03")]
    [FieldOffset(Offset = "0xC")]
    public GameObject Unit;
    [Token(Token = "0x4009E04")]
    [FieldOffset(Offset = "0x10")]
    public List<Button> Equipments;
    [Token(Token = "0x4009E05")]
    [FieldOffset(Offset = "0x14")]
    public List<RawImage> EquipmentRawImages;
    [Token(Token = "0x4009E06")]
    [FieldOffset(Offset = "0x18")]
    public List<GameObject> EquipmentCursors;
    [Token(Token = "0x4009E07")]
    [FieldOffset(Offset = "0x1C")]
    public GameObject EmptyLabel;
    [Token(Token = "0x4009E08")]
    [FieldOffset(Offset = "0x20")]
    public Transform ParamUpLayoutParent;
    [Token(Token = "0x4009E09")]
    [FieldOffset(Offset = "0x24")]
    public GameObject ParamUpTemplate;
    [Token(Token = "0x4009E0A")]
    [FieldOffset(Offset = "0x28")]
    public Transform ItemLayoutParent;
    [Token(Token = "0x4009E0B")]
    [FieldOffset(Offset = "0x2C")]
    public GameObject ItemTemplate;
    [Token(Token = "0x4009E0C")]
    [FieldOffset(Offset = "0x30")]
    public GameObject EquipSelectParent;
    [Token(Token = "0x4009E0D")]
    [FieldOffset(Offset = "0x34")]
    public GameObject SelectedParent;
    [Token(Token = "0x4009E0E")]
    [FieldOffset(Offset = "0x38")]
    public GameObject EnhanceGaugeParent;
    [Token(Token = "0x4009E0F")]
    [FieldOffset(Offset = "0x3C")]
    public GameObject ExpUpTemplate;
    [Token(Token = "0x4009E10")]
    [FieldOffset(Offset = "0x40")]
    public Text TxtExpUpValue;
    [Token(Token = "0x4009E11")]
    [FieldOffset(Offset = "0x44")]
    public Button BtnJob;
    [Token(Token = "0x4009E12")]
    [FieldOffset(Offset = "0x48")]
    public Button BtnAdd;
    [Token(Token = "0x4009E13")]
    [FieldOffset(Offset = "0x4C")]
    public Button BtnSub;
    [Token(Token = "0x4009E14")]
    [FieldOffset(Offset = "0x50")]
    public Button BtnEnhance;
    [Token(Token = "0x4009E15")]
    [FieldOffset(Offset = "0x54")]
    public Button BtnAllEnhance;
    [Token(Token = "0x4009E16")]
    [FieldOffset(Offset = "0x58")]
    public Button BtnMax;
    [Token(Token = "0x4009E17")]
    [FieldOffset(Offset = "0x5C")]
    public Button BtnClear;
    [Token(Token = "0x4009E18")]
    [FieldOffset(Offset = "0x60")]
    public Text TxtJob;
    [Token(Token = "0x4009E19")]
    [FieldOffset(Offset = "0x64")]
    public Text TxtCost;
    [Token(Token = "0x4009E1A")]
    [FieldOffset(Offset = "0x68")]
    public Text TxtComment;
    [Token(Token = "0x4009E1B")]
    [FieldOffset(Offset = "0x6C")]
    public Text TxtDisableEnhanceOnGauge;
    [Token(Token = "0x4009E1C")]
    [FieldOffset(Offset = "0x70")]
    public Slider EquipSelectCountSlider;
    [Token(Token = "0x4009E1D")]
    [FieldOffset(Offset = "0x74")]
    public readonly string ALL_EQUIPENHANCE_UI_PATH;
    [Token(Token = "0x4009E1E")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private ContentController mContentController;
    [Token(Token = "0x4009E1F")]
    [FieldOffset(Offset = "0x7C")]
    [SerializeField]
    [CustomEnum(typeof (SystemSound.ECue), -1)]
    private SystemSound.ECue SliderSound;
    [Token(Token = "0x4009E20")]
    [FieldOffset(Offset = "0x80")]
    private UnitData mUnit;
    [Token(Token = "0x4009E21")]
    [FieldOffset(Offset = "0x84")]
    private int mJobIndex;
    [Token(Token = "0x4009E22")]
    [FieldOffset(Offset = "0x88")]
    private GameObject mSelectedEquipItem;
    [Token(Token = "0x4009E23")]
    [FieldOffset(Offset = "0x8C")]
    private EnhanceEquipData mEnhanceEquipData;
    [Token(Token = "0x4009E24")]
    [FieldOffset(Offset = "0x90")]
    private List<GameObject> mEnhanceParameters;
    [Token(Token = "0x4009E25")]
    [FieldOffset(Offset = "0x94")]
    private string mSelectedMaterialItemId;
    [Token(Token = "0x4009E26")]
    [FieldOffset(Offset = "0x98")]
    private List<EnhanceMaterial> mEnhanceMaterials;
    [Token(Token = "0x4009E27")]
    [FieldOffset(Offset = "0x9C")]
    private Dictionary<string, EnhanceMaterial> mEnhanceMaterialsDict;
    [Token(Token = "0x4009E28")]
    [FieldOffset(Offset = "0xA0")]
    private List<EnhanceMaterial> mEnableEnhanceMaterials;
    [Token(Token = "0x4009E29")]
    [FieldOffset(Offset = "0xA4")]
    private List<ItemData> mMaterialItems;
    [Token(Token = "0x4009E2A")]
    [FieldOffset(Offset = "0xA8")]
    private List<ItemData> mEnhanceItems;
    [Token(Token = "0x4009E2B")]
    [FieldOffset(Offset = "0xAC")]
    private List<EnhanceEquipIconParam> mEnhanceEquipIconParam;
    [Token(Token = "0x4009E2C")]
    [FieldOffset(Offset = "0xB0")]
    private Vector2 mAnchorPosition;
    [Token(Token = "0x4009E2D")]
    [FieldOffset(Offset = "0xB8")]
    private EnhanceEquipDetailWindow.EnhanceEquipTouchController mTouchControllerAdd;
    [Token(Token = "0x4009E2E")]
    [FieldOffset(Offset = "0xBC")]
    private EnhanceEquipDetailWindow.EnhanceEquipTouchController mTouchControllerSub;
    [Token(Token = "0x4009E2F")]
    [FieldOffset(Offset = "0xC0")]
    private bool endAddDialog;

    [Token(Token = "0x6009809")]
    [Address(RVA = "0x5AEF80", Offset = "0x5ADD80", VA = "0x105AEF80")]
    private void Start()
    {
    }

    [Token(Token = "0x600980A")]
    [Address(RVA = "0x5AAC30", Offset = "0x5A9A30", VA = "0x105AAC30", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600980B")]
    [Address(RVA = "0x5AF8E0", Offset = "0x5AE6E0", VA = "0x105AF8E0")]
    private void Update()
    {
    }

    [Token(Token = "0x600980C")]
    [Address(RVA = "0x5ADBA0", Offset = "0x5AC9A0", VA = "0x105ADBA0")]
    private void RefreshData()
    {
    }

    [Token(Token = "0x600980D")]
    [Address(RVA = "0x5AD3A0", Offset = "0x5AC1A0", VA = "0x105AD3A0")]
    private void OnJobChange()
    {
    }

    [Token(Token = "0x600980E")]
    [Address(RVA = "0x5AD770", Offset = "0x5AC570", VA = "0x105AD770")]
    private void OnSelectEquipment(int slot)
    {
    }

    [Token(Token = "0x600980F")]
    [Address(RVA = "0x5AD080", Offset = "0x5ABE80", VA = "0x105AD080")]
    public void OnItemSelect(GameObject go)
    {
    }

    [Token(Token = "0x6009810")]
    [Address(RVA = "0x5AAE60", Offset = "0x5A9C60", VA = "0x105AAE60")]
    private void AllEquipmentEnhance()
    {
    }

    [Token(Token = "0x6009811")]
    [Address(RVA = "0x5ACC30", Offset = "0x5ABA30", VA = "0x105ACC30")]
    private void OnAllEquipEnhanceEvent()
    {
    }

    [Token(Token = "0x6009812")]
    [Address(RVA = "0x5ACC20", Offset = "0x5ABA20", VA = "0x105ACC20")]
    private void OnAllEquipEnhanceCancelEvent()
    {
    }

    [Token(Token = "0x6009813")]
    [Address(RVA = "0x5AC4D0", Offset = "0x5AB2D0", VA = "0x105AC4D0")]
    private void EnhanceLimitedMaterials(int addExp)
    {
    }

    [Token(Token = "0x6009814")]
    [Address(RVA = "0x5AD480", Offset = "0x5AC280", VA = "0x105AD480")]
    private void OnMaxMaterial()
    {
    }

    [Token(Token = "0x6009815")]
    [Address(RVA = "0x5ACD80", Offset = "0x5ABB80", VA = "0x105ACD80")]
    private void OnClearMaterial()
    {
    }

    [Token(Token = "0x6009816")]
    [Address(RVA = "0x5AC9C0", Offset = "0x5AB7C0", VA = "0x105AC9C0")]
    private void OnAddMaterial()
    {
    }

    [Token(Token = "0x6009817")]
    [Address(RVA = "0x5ADA60", Offset = "0x5AC860", VA = "0x105ADA60")]
    private void OnSubMaterial()
    {
    }

    [Token(Token = "0x6009818")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnLevelDown(
      EnhanceEquipDetailWindow.EnhanceEquipTouchController controller)
    {
    }

    [Token(Token = "0x6009819")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void OnLevelUp(
      EnhanceEquipDetailWindow.EnhanceEquipTouchController controller)
    {
    }

    [Token(Token = "0x600981A")]
    [Address(RVA = "0x5ABA90", Offset = "0x5AA890", VA = "0x105ABA90")]
    private bool CheckEquipItemEnhance(int addExp = 0) => new bool();

    [Token(Token = "0x600981B")]
    [Address(RVA = "0x5AB9E0", Offset = "0x5AA7E0", VA = "0x105AB9E0")]
    private int CheckEquipItemEnhanceOverflow(EquipData equip, int addExp = 0) => new int();

    [Token(Token = "0x600981C")]
    [Address(RVA = "0x5AC7A0", Offset = "0x5AB5A0", VA = "0x105AC7A0")]
    private int GetJustCost(EquipData equip, List<ItemData> list, int overExp) => new int();

    [Token(Token = "0x600981D")]
    [Address(RVA = "0x5ACDE0", Offset = "0x5ABBE0", VA = "0x105ACDE0")]
    private void OnEnhance()
    {
    }

    [Token(Token = "0x600981E")]
    [Address(RVA = "0x460550", Offset = "0x45F350", VA = "0x10460550")]
    private void OnDecide(GameObject go)
    {
    }

    [Token(Token = "0x600981F")]
    [Address(RVA = "0x5ACCF0", Offset = "0x5ABAF0", VA = "0x105ACCF0")]
    private void OnCancel(GameObject go)
    {
    }

    [Token(Token = "0x6009820")]
    [Address(RVA = "0x5ABAE0", Offset = "0x5AA8E0", VA = "0x105ABAE0")]
    private void ClearEnhancedMaterial()
    {
    }

    [Token(Token = "0x6009821")]
    [Address(RVA = "0x5ABB90", Offset = "0x5AA990", VA = "0x105ABB90")]
    public void ClearMaterialSelect()
    {
    }

    [Token(Token = "0x6009822")]
    [Address(RVA = "0x5AC680", Offset = "0x5AB480", VA = "0x105AC680")]
    private int GetEquipItemEnhanceCount(
      ItemData item,
      int selectedCount = 0,
      int startExp = 0,
      bool allowOverflow = false)
    {
      return new int();
    }

    [Token(Token = "0x6009823")]
    [Address(RVA = "0x5AD940", Offset = "0x5AC740", VA = "0x105AD940")]
    private void OnSelectMaterial(float value)
    {
    }

    [Token(Token = "0x6009824")]
    [Address(RVA = "0x5ABC40", Offset = "0x5AAA40", VA = "0x105ABC40")]
    private void CreateItemList()
    {
    }

    [Token(Token = "0x6009825")]
    [Address(RVA = "0x5AF9C0", Offset = "0x5AE7C0", VA = "0x105AF9C0")]
    public EnhanceEquipDetailWindow()
    {
    }

    [Token(Token = "0x2002349")]
    public class EnhanceEquipTouchController : 
      MonoBehaviour,
      IPointerDownHandler,
      IEventSystemHandler
    {
      [Token(Token = "0x4009E30")]
      [FieldOffset(Offset = "0xC")]
      public EnhanceEquipDetailWindow.EnhanceEquipTouchController.DelegateOnPointerDown OnPointerDownFunc;
      [Token(Token = "0x4009E31")]
      [FieldOffset(Offset = "0x10")]
      public EnhanceEquipDetailWindow.EnhanceEquipTouchController.DelegateOnPointerUp OnPointerUpFunc;
      [Token(Token = "0x4009E32")]
      [FieldOffset(Offset = "0x14")]
      public EnhanceEquipDetailWindow.EnhanceEquipTouchController.DelegateLevelUp LevelupFunc;
      [Token(Token = "0x4009E33")]
      [FieldOffset(Offset = "0x18")]
      public float UseLevelSpan;
      [Token(Token = "0x4009E34")]
      [FieldOffset(Offset = "0x1C")]
      public float HoldDuration;
      [Token(Token = "0x4009E35")]
      [FieldOffset(Offset = "0x20")]
      public bool Holding;
      [Token(Token = "0x4009E36")]
      [FieldOffset(Offset = "0x24")]
      private int UseNum;
      [Token(Token = "0x4009E37")]
      [FieldOffset(Offset = "0x28")]
      private int NextSettingIndex;
      [Token(Token = "0x4009E38")]
      [FieldOffset(Offset = "0x2C")]
      private Vector2 mDragStartPos;

      [Token(Token = "0x6009827")]
      [Address(RVA = "0x5AFFB0", Offset = "0x5AEDB0", VA = "0x105AFFB0", Slot = "4")]
      public void OnPointerDown(PointerEventData eventData)
      {
      }

      [Token(Token = "0x6009828")]
      [Address(RVA = "0x5B0000", Offset = "0x5AEE00", VA = "0x105B0000")]
      public void OnPointerUp()
      {
      }

      [Token(Token = "0x6009829")]
      [Address(RVA = "0x5AFF40", Offset = "0x5AED40", VA = "0x105AFF40")]
      public void OnDestroy()
      {
      }

      [Token(Token = "0x600982A")]
      [Address(RVA = "0x5B0080", Offset = "0x5AEE80", VA = "0x105B0080")]
      public void UpdateTimer(float deltaTime)
      {
      }

      [Token(Token = "0x600982B")]
      [Address(RVA = "0x5B0050", Offset = "0x5AEE50", VA = "0x105B0050")]
      public void StatusReset()
      {
      }

      [Token(Token = "0x600982C")]
      [Address(RVA = "0x5B0260", Offset = "0x5AF060", VA = "0x105B0260")]
      public EnhanceEquipTouchController()
      {
      }

      [Token(Token = "0x200234A")]
      public delegate void DelegateOnPointerDown(
        EnhanceEquipDetailWindow.EnhanceEquipTouchController controller);

      [Token(Token = "0x200234B")]
      public delegate void DelegateOnPointerUp(
        EnhanceEquipDetailWindow.EnhanceEquipTouchController controller);

      [Token(Token = "0x200234C")]
      public delegate void DelegateLevelUp();
    }
  }
}

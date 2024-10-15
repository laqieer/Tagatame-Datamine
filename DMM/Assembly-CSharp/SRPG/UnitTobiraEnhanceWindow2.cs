// Decompiled with JetBrains decompiler
// Type: SRPG.UnitTobiraEnhanceWindow2
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
  [Token(Token = "0x2002D0C")]
  [AddComponentMenu("UI/UnitTobiraEnhanceWindow2")]
  [FlowNode.Pin(104, "素材を獲得できるクエスト一覧表示", FlowNode.PinTypes.Output, 104)]
  [FlowNode.Pin(103, "代用アイテムを使うか確認", FlowNode.PinTypes.Output, 103)]
  [FlowNode.Pin(102, "閉じる：完了", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(0, "表示を更新", FlowNode.PinTypes.Input, 0)]
  [FlowNode.Pin(50, "素材をクリック", FlowNode.PinTypes.Input, 50)]
  [FlowNode.Pin(100, "扉強化ボタン押下", FlowNode.PinTypes.Input, 100)]
  public class UnitTobiraEnhanceWindow2 : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400E032")]
    public const int ON_CLICK_ELEMENT_BUTTON = 50;
    [Token(Token = "0x400E033")]
    public const int ON_CLICK_TOBIRA_ENHANCE_BUTTON = 100;
    [Token(Token = "0x400E034")]
    public const int OUT_CLOSE_WINDOW = 102;
    [Token(Token = "0x400E035")]
    public const int OUT_IS_USE_SUB_PIESE = 103;
    [Token(Token = "0x400E036")]
    public const int OUT_CLICK_ELEMENT_QUEST_LIST = 104;
    [Token(Token = "0x400E037")]
    [FieldOffset(Offset = "0xC")]
    [HelpBox("アイテムスロットの雛形")]
    public GameObject ItemSlotTemplate;
    [Token(Token = "0x400E038")]
    [FieldOffset(Offset = "0x10")]
    [HelpBox("足りてないものを表示するラベル")]
    public Text HelpText;
    [Token(Token = "0x400E039")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Button EnhanceTobiraButton;
    [Token(Token = "0x400E03A")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Button MainPanelCloseBtn;
    [Token(Token = "0x400E03B")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject ItemSlotRoot;
    [Token(Token = "0x400E03C")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject ItemSlotBox;
    [Token(Token = "0x400E03D")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject MainPanel;
    [Token(Token = "0x400E03E")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text TitleText;
    [Token(Token = "0x400E03F")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Text MessageText;
    [Token(Token = "0x400E040")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private ImageArray TobiraIcons;
    [Token(Token = "0x400E041")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private UnitTobiraParamLevel[] mLevelIcons;
    [Token(Token = "0x400E042")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private StatusList Status;
    [Token(Token = "0x400E043")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Text AdditionalLevelCap;
    [Token(Token = "0x400E044")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Slider UseExpItemSlider;
    [Token(Token = "0x400E045")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private SRPG_Button PlusBtn;
    [Token(Token = "0x400E046")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private SRPG_Button MinusBtn;
    [Token(Token = "0x400E047")]
    [FieldOffset(Offset = "0x4C")]
    private UnitData mCurrentUnit;
    [Token(Token = "0x400E048")]
    [FieldOffset(Offset = "0x50")]
    private TobiraData mCurrentTobira;
    [Token(Token = "0x400E049")]
    [FieldOffset(Offset = "0x54")]
    private TobiraRecipeParam mFixReceipeParam;
    [Token(Token = "0x400E04A")]
    [FieldOffset(Offset = "0x58")]
    private List<GameObject> mItems;
    [Token(Token = "0x400E04B")]
    [FieldOffset(Offset = "0x5C")]
    public UnitTobiraEnhanceWindow2.CallbackEvent OnCallback;
    [Token(Token = "0x400E04C")]
    [FieldOffset(Offset = "0x60")]
    private int mTargetLevel;
    [Token(Token = "0x400E04D")]
    [FieldOffset(Offset = "0x0")]
    private static bool isUseSubPiece;
    [Token(Token = "0x400E04E")]
    private const string CHECK_SUB_PIECE_PREFAB_PATH = "UI/UnitTobiraCommonItemConfirmWindow";

    [Token(Token = "0x17001B84")]
    public static bool IsUseSubPiese
    {
      [Token(Token = "0x600D1AD"), Address(RVA = "0x9CE550", Offset = "0x9CD350", VA = "0x109CE550")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600D1AE")]
    [Address(RVA = "0x9CE180", Offset = "0x9CCF80", VA = "0x109CE180")]
    private void Start()
    {
    }

    [Token(Token = "0x600D1AF")]
    [Address(RVA = "0x9CCB80", Offset = "0x9CB980", VA = "0x109CCB80")]
    public void Initialize(UnitData unit, TobiraData tobira)
    {
    }

    [Token(Token = "0x600D1B0")]
    [Address(RVA = "0x9CBE10", Offset = "0x9CAC10", VA = "0x109CBE10", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600D1B1")]
    [Address(RVA = "0x9CDCB0", Offset = "0x9CCAB0", VA = "0x109CDCB0")]
    private void RequestTobiraEnhance()
    {
    }

    [Token(Token = "0x600D1B2")]
    [Address(RVA = "0x517F80", Offset = "0x516D80", VA = "0x10517F80")]
    private void CloseWindow()
    {
    }

    [Token(Token = "0x600D1B3")]
    [Address(RVA = "0x9CD080", Offset = "0x9CBE80", VA = "0x109CD080")]
    private void Refresh()
    {
    }

    [Token(Token = "0x600D1B4")]
    [Address(RVA = "0x9CC190", Offset = "0x9CAF90", VA = "0x109CC190")]
    private void CreateIconList(
      TobiraRecipeParam recipe_param,
      out string errMsg,
      out bool can_enhance)
    {
    }

    [Token(Token = "0x600D1B5")]
    [Address(RVA = "0x9CC840", Offset = "0x9CB640", VA = "0x109CC840")]
    private GameObject CreateIcon(ItemParam item_param, int required_amount) => (GameObject) null;

    [Token(Token = "0x600D1B6")]
    [Address(RVA = "0x9CDE50", Offset = "0x9CCC50", VA = "0x109CDE50")]
    private void SetSlider()
    {
    }

    [Token(Token = "0x600D1B7")]
    [Address(RVA = "0x9CCE60", Offset = "0x9CBC60", VA = "0x109CCE60")]
    private void OnSelectUseNumChanged(float value)
    {
    }

    [Token(Token = "0x600D1B8")]
    [Address(RVA = "0x9CCD20", Offset = "0x9CBB20", VA = "0x109CCD20")]
    private void OnAddNum()
    {
    }

    [Token(Token = "0x600D1B9")]
    [Address(RVA = "0x9CCDC0", Offset = "0x9CBBC0", VA = "0x109CCDC0")]
    private void OnRemoveNum()
    {
    }

    [Token(Token = "0x600D1BA")]
    [Address(RVA = "0x9CDCE0", Offset = "0x9CCAE0", VA = "0x109CDCE0")]
    private void SetBtnInteractable()
    {
    }

    [Token(Token = "0x600D1BB")]
    [Address(RVA = "0x9CE580", Offset = "0x9CD380", VA = "0x109CE580")]
    private bool isSubstitutionUnitPiece(TobiraRecipeParam recipe_param) => new bool();

    [Token(Token = "0x600D1BC")]
    [Address(RVA = "0x9CE350", Offset = "0x9CD150", VA = "0x109CE350")]
    private bool _CheckNullReference() => new bool();

    [Token(Token = "0x600D1BD")]
    [Address(RVA = "0x9CCA60", Offset = "0x9CB860", VA = "0x109CCA60")]
    private List<TobiraRecipeParam> GetCurrentRecipes() => (List<TobiraRecipeParam>) null;

    [Token(Token = "0x600D1BE")]
    [Address(RVA = "0x9CE4E0", Offset = "0x9CD2E0", VA = "0x109CE4E0")]
    public UnitTobiraEnhanceWindow2()
    {
    }

    [Token(Token = "0x2002D0D")]
    public delegate void CallbackEvent();
  }
}

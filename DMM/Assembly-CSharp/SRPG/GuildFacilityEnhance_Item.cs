// Decompiled with JetBrains decompiler
// Type: SRPG.GuildFacilityEnhance_Item
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
  [Token(Token = "0x2002528")]
  [FlowNode.Pin(40, "施設強化開始", FlowNode.PinTypes.Input, 40)]
  [FlowNode.Pin(50, "素材選択(次ページ)", FlowNode.PinTypes.Input, 50)]
  [FlowNode.Pin(60, "素材選択(前ページ)", FlowNode.PinTypes.Input, 60)]
  [FlowNode.Pin(70, "データ、表示を更新", FlowNode.PinTypes.Input, 70)]
  [FlowNode.Pin(80, "施設強化演出", FlowNode.PinTypes.Input, 80)]
  [FlowNode.Pin(1010, "施設強化リクエスト", FlowNode.PinTypes.Output, 1010)]
  [FlowNode.Pin(30, "素材選択クリア", FlowNode.PinTypes.Input, 30)]
  [AddComponentMenu("UI/Guild/GuildFacilityEnhance_Item")]
  [FlowNode.Pin(1020, "施設強化演出完了", FlowNode.PinTypes.Output, 1020)]
  public class GuildFacilityEnhance_Item : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A9F9")]
    private const int PIN_INPUT_CLEAR_ENHANCE_MATERIALS = 30;
    [Token(Token = "0x400A9FA")]
    private const int PIN_INPUT_START_FACILITY_ENHANCE = 40;
    [Token(Token = "0x400A9FB")]
    private const int PIN_INPUT_SELECT_MATERIAL_PAGE_NEXT = 50;
    [Token(Token = "0x400A9FC")]
    private const int PIN_INPUT_SELECT_MATERIAL_PAGE_BACK = 60;
    [Token(Token = "0x400A9FD")]
    private const int PIN_INPUT_RESET_ALL = 70;
    [Token(Token = "0x400A9FE")]
    private const int PIN_INPUT_START_ENHANCE_ANIMATION = 80;
    [Token(Token = "0x400A9FF")]
    private const int PIN_OUTPUT_REQUEST_FACILITY_ENHANCE = 1010;
    [Token(Token = "0x400AA00")]
    private const int PIN_OUTPUT_START_ENHANCE_ANIMATION = 1020;
    [Token(Token = "0x400AA01")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private float ENHANCE_EFFECT_TIME;
    [Token(Token = "0x400AA02")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private int SELECTABLE_LIMIT;
    [Token(Token = "0x400AA03")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private int ENHANCE_ITEM_COUNT_MAX;
    [Token(Token = "0x400AA04")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mEnhanceItemTemplate;
    [Token(Token = "0x400AA05")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mFacilityEnhanceSliderRoot;
    [Token(Token = "0x400AA06")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Slider mFacilityEnhanceSlider;
    [Token(Token = "0x400AA07")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Slider mFacilityExpGauge;
    [Token(Token = "0x400AA08")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text mFacilityNextExpText;
    [Token(Token = "0x400AA09")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Text mFacilityEnhanceAfterLevelText;
    [Token(Token = "0x400AA0A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject mFacilityEffectTemplate;
    [Token(Token = "0x400AA0B")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Text mCurrentInvestPoint;
    [Token(Token = "0x400AA0C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Button mEnhanceSubmitButton;
    [Token(Token = "0x400AA0D")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Button mEnhanceClearButton;
    [Token(Token = "0x400AA0E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Button mPageNextObject;
    [Token(Token = "0x400AA0F")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Button mPageBackObject;
    [Token(Token = "0x400AA10")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject mEnhanceLevelupEffect;
    [Token(Token = "0x400AA11")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private Button mEnhanceMaterialPlusButton;
    [Token(Token = "0x400AA12")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private Button mEnhanceMaterialMinusButton;
    [Token(Token = "0x400AA13")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private Button mEnhanceMaterialMaxButton;
    [Token(Token = "0x400AA14")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject mFacilityLevelMaxMask;
    [Token(Token = "0x400AA15")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private GameObject mNormalLevelObject;
    [Token(Token = "0x400AA16")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private GameObject mMaxLevelObject;
    [Token(Token = "0x400AA17")]
    [FieldOffset(Offset = "0x64")]
    private GuildFacilityData mTargetFacility;
    [Token(Token = "0x400AA18")]
    [FieldOffset(Offset = "0x68")]
    private List<ItemData> mEnhanceItems;
    [Token(Token = "0x400AA19")]
    [FieldOffset(Offset = "0x6C")]
    private List<GameObject> mCreatedEnhanceItemObjects;
    [Token(Token = "0x400AA1A")]
    [FieldOffset(Offset = "0x70")]
    private List<EnhanceMaterial> mEnhanceMaterials;
    [Token(Token = "0x400AA1B")]
    [FieldOffset(Offset = "0x74")]
    private EnhanceMaterial mTargetEnhanceMaterial;
    [Token(Token = "0x400AA1C")]
    [FieldOffset(Offset = "0x78")]
    private List<EnhanceMaterial> mSelectedEnhanceMaterials;
    [Token(Token = "0x400AA1D")]
    [FieldOffset(Offset = "0x7C")]
    private List<GameObject> mCreatedFacilityEffectTexts;
    [Token(Token = "0x400AA1E")]
    [FieldOffset(Offset = "0x80")]
    private int mCurrentPage;
    [Token(Token = "0x400AA1F")]
    [FieldOffset(Offset = "0x84")]
    private int mPageMax;
    [Token(Token = "0x400AA20")]
    [FieldOffset(Offset = "0x88")]
    private long mBeforeEnhanceInvestPoint;
    [Token(Token = "0x400AA21")]
    [FieldOffset(Offset = "0x90")]
    private GameObject mConfirmWindow;
    [Token(Token = "0x400AA22")]
    [FieldOffset(Offset = "0x94")]
    private GameObject mErrorWindow;
    [Token(Token = "0x400AA23")]
    [FieldOffset(Offset = "0x98")]
    private GuildFacilityEnhance_Item.EffectCallBack mCallback;

    [Token(Token = "0x600A37F")]
    [Address(RVA = "0x6588E0", Offset = "0x6576E0", VA = "0x106588E0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A380")]
    [Address(RVA = "0x65C1E0", Offset = "0x65AFE0", VA = "0x1065C1E0")]
    private void Start()
    {
    }

    [Token(Token = "0x600A381")]
    [Address(RVA = "0x65C3E0", Offset = "0x65B1E0", VA = "0x1065C3E0")]
    private void Update()
    {
    }

    [Token(Token = "0x600A382")]
    [Address(RVA = "0x659970", Offset = "0x658770", VA = "0x10659970")]
    private void Init()
    {
    }

    [Token(Token = "0x600A383")]
    [Address(RVA = "0x65B980", Offset = "0x65A780", VA = "0x1065B980")]
    private void ResetAll()
    {
    }

    [Token(Token = "0x600A384")]
    [Address(RVA = "0x6597E0", Offset = "0x6585E0", VA = "0x106597E0")]
    private long GetSelectedMaterialsTotalExp(bool is_enhance_animation = false, bool is_simple_total = false)
    {
      return new long();
    }

    [Token(Token = "0x600A385")]
    [Address(RVA = "0x659770", Offset = "0x658570", VA = "0x10659770")]
    private long GetRestInvestPoint() => new long();

    [Token(Token = "0x600A386")]
    [Address(RVA = "0x65BEF0", Offset = "0x65ACF0", VA = "0x1065BEF0")]
    private void StartGuildFacilityEnhance()
    {
    }

    [Token(Token = "0x600A387")]
    [Address(RVA = "0x65B850", Offset = "0x65A650", VA = "0x1065B850")]
    private void RequestGuildFacilityEnhance(GameObject obj)
    {
    }

    [Token(Token = "0x600A388")]
    [Address(RVA = "0x659560", Offset = "0x658360", VA = "0x10659560")]
    private List<ItemData> GetPlayerEnhanceItmes() => (List<ItemData>) null;

    [Token(Token = "0x600A389")]
    [Address(RVA = "0x65BA80", Offset = "0x65A880", VA = "0x1065BA80")]
    private void SetActive_FacilityLevelMaxUI(bool is_level_max)
    {
    }

    [Token(Token = "0x600A38A")]
    [Address(RVA = "0x65B020", Offset = "0x659E20", VA = "0x1065B020")]
    private void Refresh_FacilityEnhance(int page, bool is_update_items = true)
    {
    }

    [Token(Token = "0x600A38B")]
    [Address(RVA = "0x65A660", Offset = "0x659460", VA = "0x1065A660")]
    private void PageNext()
    {
    }

    [Token(Token = "0x600A38C")]
    [Address(RVA = "0x65A620", Offset = "0x659420", VA = "0x1065A620")]
    private void PageBack()
    {
    }

    [Token(Token = "0x600A38D")]
    [Address(RVA = "0x65B500", Offset = "0x65A300", VA = "0x1065B500")]
    private void Refresh_FacilityExp(long total_add_exp = -1)
    {
    }

    [Token(Token = "0x600A38E")]
    [Address(RVA = "0x65A730", Offset = "0x659530", VA = "0x1065A730")]
    private void Refresh_FacilityEffect(int after_level)
    {
    }

    [Token(Token = "0x600A38F")]
    [Address(RVA = "0x65BAE0", Offset = "0x65A8E0", VA = "0x1065BAE0")]
    private void SetGuildFacilityEffectPlus(SerializeValueBehaviour svb, int dif_value)
    {
    }

    [Token(Token = "0x600A390")]
    [Address(RVA = "0x65BC30", Offset = "0x65AA30", VA = "0x1065BC30")]
    private void SetupInvestGuildFacilityUI(EnhanceMaterial mat)
    {
    }

    [Token(Token = "0x600A391")]
    [Address(RVA = "0x658B00", Offset = "0x657900", VA = "0x10658B00")]
    private void ClearSelectEnhanceMaterial(bool is_keep_select = true)
    {
    }

    [Token(Token = "0x600A392")]
    [Address(RVA = "0x6591C0", Offset = "0x657FC0", VA = "0x106591C0")]
    private bool ErrorCheck_LvMax() => new bool();

    [Token(Token = "0x600A393")]
    [Address(RVA = "0x659100", Offset = "0x657F00", VA = "0x10659100")]
    private bool ErrorCheck_InvestLimit() => new bool();

    [Token(Token = "0x600A394")]
    [Address(RVA = "0x659150", Offset = "0x657F50", VA = "0x10659150")]
    private bool ErrorCheck_ItemLimit() => new bool();

    [Token(Token = "0x600A395")]
    [Address(RVA = "0x6593C0", Offset = "0x6581C0", VA = "0x106593C0")]
    private int GetNeedNum_LvMax() => new int();

    [Token(Token = "0x600A396")]
    [Address(RVA = "0x659250", Offset = "0x658050", VA = "0x10659250")]
    private int GetNeedNum_InvestLimit() => new int();

    [Token(Token = "0x600A397")]
    [Address(RVA = "0x65A6A0", Offset = "0x6594A0", VA = "0x1065A6A0")]
    private void RefreshFacilityEnhanceSlider()
    {
    }

    [Token(Token = "0x600A398")]
    [Address(RVA = "0x65A4D0", Offset = "0x6592D0", VA = "0x1065A4D0")]
    public void OnClick_GuildFacilityEnhanceMaterial(GameObject obj)
    {
    }

    [Token(Token = "0x600A399")]
    [Address(RVA = "0x659AC0", Offset = "0x6588C0", VA = "0x10659AC0")]
    private void OnChange_GuildFacilityEnhanceMaterialSlider(float value)
    {
    }

    [Token(Token = "0x600A39A")]
    [Address(RVA = "0x65A5F0", Offset = "0x6593F0", VA = "0x1065A5F0")]
    private void OnClose_ErrorWindow(GameObject go)
    {
    }

    [Token(Token = "0x600A39B")]
    [Address(RVA = "0x65A470", Offset = "0x659270", VA = "0x1065A470")]
    public void OnClick_EnhanceMaterialCountUp()
    {
    }

    [Token(Token = "0x600A39C")]
    [Address(RVA = "0x65A150", Offset = "0x658F50", VA = "0x1065A150")]
    public void OnClick_EnhanceMaterialCountDown()
    {
    }

    [Token(Token = "0x600A39D")]
    [Address(RVA = "0x65A1B0", Offset = "0x658FB0", VA = "0x1065A1B0")]
    public void OnClick_EnhanceMaterialCountMax()
    {
    }

    [Token(Token = "0x600A39E")]
    [Address(RVA = "0x659A50", Offset = "0x658850", VA = "0x10659A50")]
    private IEnumerator LevelupAnimation(
      GuildFacilityData facility,
      GuildFacilityEnhance_Item.EffectCallBack callback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600A39F")]
    [Address(RVA = "0x659040", Offset = "0x657E40", VA = "0x10659040")]
    private void EndLevelupAnimation()
    {
    }

    [Token(Token = "0x600A3A0")]
    [Address(RVA = "0x65C5D0", Offset = "0x65B3D0", VA = "0x1065C5D0")]
    public GuildFacilityEnhance_Item()
    {
    }

    [Token(Token = "0x2002529")]
    public delegate void EffectCallBack();
  }
}

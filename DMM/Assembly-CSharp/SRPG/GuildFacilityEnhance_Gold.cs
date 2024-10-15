// Decompiled with JetBrains decompiler
// Type: SRPG.GuildFacilityEnhance_Gold
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
  [Token(Token = "0x2002525")]
  [FlowNode.Pin(70, "データ、表示を更新", FlowNode.PinTypes.Input, 70)]
  [FlowNode.Pin(80, "施設強化演出", FlowNode.PinTypes.Input, 80)]
  [FlowNode.Pin(1010, "施設強化リクエスト", FlowNode.PinTypes.Output, 1010)]
  [FlowNode.Pin(1020, "施設強化演出完了", FlowNode.PinTypes.Output, 1020)]
  [AddComponentMenu("UI/Guild/GuildFacilityEnhance_Gold")]
  [FlowNode.Pin(30, "素材選択クリア", FlowNode.PinTypes.Input, 30)]
  [FlowNode.Pin(40, "施設強化開始", FlowNode.PinTypes.Input, 40)]
  public class GuildFacilityEnhance_Gold : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400A9CE")]
    private const int PIN_INPUT_CLEAR_ENHANCE_GOLD = 30;
    [Token(Token = "0x400A9CF")]
    private const int PIN_INPUT_START_FACILITY_ENHANCE = 40;
    [Token(Token = "0x400A9D0")]
    private const int PIN_INPUT_RESET_ALL = 70;
    [Token(Token = "0x400A9D1")]
    private const int PIN_INPUT_START_ENHANCE_ANIMATION = 80;
    [Token(Token = "0x400A9D2")]
    private const int PIN_OUTPUT_REQUEST_FACILITY_ENHANCE = 1010;
    [Token(Token = "0x400A9D3")]
    private const int PIN_OUTPUT_START_ENHANCE_ANIMATION = 1020;
    [Token(Token = "0x400A9D4")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private float ENHANCE_EFFECT_TIME;
    [Token(Token = "0x400A9D5")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Slider mFacilityEnhanceSlider;
    [Token(Token = "0x400A9D6")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Slider mFacilityExpGauge;
    [Token(Token = "0x400A9D7")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Slider mFacilityInvestLimitGauge;
    [Token(Token = "0x400A9D8")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mFacilityNextExpText;
    [Token(Token = "0x400A9D9")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text mFacilityEnhanceAfterLevelText;
    [Token(Token = "0x400A9DA")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mFacilityEffectTemplate;
    [Token(Token = "0x400A9DB")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text mCurrentInvestPoint;
    [Token(Token = "0x400A9DC")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Button mEnhanceSubmitButton;
    [Token(Token = "0x400A9DD")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button mEnhanceClearButton;
    [Token(Token = "0x400A9DE")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private GameObject mEnhanceLevelupEffect;
    [Token(Token = "0x400A9DF")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Button mEnhanceGoldPlusButton;
    [Token(Token = "0x400A9E0")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Button mEnhanceGoldMinusButton;
    [Token(Token = "0x400A9E1")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Button mEnhanceGoldMaxButton;
    [Token(Token = "0x400A9E2")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Text mSelectedGoldText;
    [Token(Token = "0x400A9E3")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text mIncrementPlusText;
    [Token(Token = "0x400A9E4")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private Text mIncrementMinusText;
    [Token(Token = "0x400A9E5")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject mFacilityLevelMaxMask;
    [Token(Token = "0x400A9E6")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private GameObject mNormalLevelObject;
    [Token(Token = "0x400A9E7")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject mMaxLevelObject;
    [Token(Token = "0x400A9E8")]
    [FieldOffset(Offset = "0x5C")]
    private GuildFacilityData mTargetFacility;
    [Token(Token = "0x400A9E9")]
    [FieldOffset(Offset = "0x60")]
    private long mSelectedGold;
    [Token(Token = "0x400A9EA")]
    [FieldOffset(Offset = "0x68")]
    private List<GameObject> mCreatedFacilityEffectTexts;
    [Token(Token = "0x400A9EB")]
    [FieldOffset(Offset = "0x70")]
    private long mBeforeEnhanceInvestPoint;
    [Token(Token = "0x400A9EC")]
    [FieldOffset(Offset = "0x78")]
    private GameObject mErrorWindow;
    [Token(Token = "0x400A9ED")]
    [FieldOffset(Offset = "0x7C")]
    private GuildFacilityEnhance_Gold.EffectCallBack mCallback;

    [Token(Token = "0x600A352")]
    [Address(RVA = "0x652BE0", Offset = "0x6519E0", VA = "0x10652BE0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600A353")]
    [Address(RVA = "0x655740", Offset = "0x654540", VA = "0x10655740")]
    private void Start()
    {
    }

    [Token(Token = "0x600A354")]
    [Address(RVA = "0x6557B0", Offset = "0x6545B0", VA = "0x106557B0")]
    private void Update()
    {
    }

    [Token(Token = "0x600A355")]
    [Address(RVA = "0x653710", Offset = "0x652510", VA = "0x10653710")]
    private void Init()
    {
    }

    [Token(Token = "0x600A356")]
    [Address(RVA = "0x655050", Offset = "0x653E50", VA = "0x10655050")]
    private void ResetAll()
    {
    }

    [Token(Token = "0x600A357")]
    [Address(RVA = "0x6535E0", Offset = "0x6523E0", VA = "0x106535E0")]
    private long GetSelectedTotalGold(bool is_enhance_animation = false, bool is_simple_total = false)
    {
      return new long();
    }

    [Token(Token = "0x600A358")]
    [Address(RVA = "0x653570", Offset = "0x652370", VA = "0x10653570")]
    private long GetRestInvestPoint() => new long();

    [Token(Token = "0x600A359")]
    [Address(RVA = "0x6555B0", Offset = "0x6543B0", VA = "0x106555B0")]
    private void StartGuildFacilityEnhance()
    {
    }

    [Token(Token = "0x600A35A")]
    [Address(RVA = "0x654EE0", Offset = "0x653CE0", VA = "0x10654EE0")]
    private void RequestGuildFacilityEnhance(GameObject obj)
    {
    }

    [Token(Token = "0x600A35B")]
    [Address(RVA = "0x6551B0", Offset = "0x653FB0", VA = "0x106551B0")]
    private void SetActive_FacilityLevelMaxUI(bool is_level_max)
    {
    }

    [Token(Token = "0x600A35C")]
    [Address(RVA = "0x654920", Offset = "0x653720", VA = "0x10654920")]
    private void Refresh_FacilityEnhance()
    {
    }

    [Token(Token = "0x600A35D")]
    [Address(RVA = "0x6549B0", Offset = "0x6537B0", VA = "0x106549B0")]
    private void Refresh_FacilityExp(long total_add_gold = -1)
    {
    }

    [Token(Token = "0x600A35E")]
    [Address(RVA = "0x654030", Offset = "0x652E30", VA = "0x10654030")]
    private void Refresh_FacilityEffect(int after_level)
    {
    }

    [Token(Token = "0x600A35F")]
    [Address(RVA = "0x655210", Offset = "0x654010", VA = "0x10655210")]
    private void SetGuildFacilityEffectPlus(SerializeValueBehaviour svb, int dif_value)
    {
    }

    [Token(Token = "0x600A360")]
    [Address(RVA = "0x655360", Offset = "0x654160", VA = "0x10655360")]
    private void SetupInvestGuildFacilityUI()
    {
    }

    [Token(Token = "0x600A361")]
    [Address(RVA = "0x652E70", Offset = "0x651C70", VA = "0x10652E70")]
    private void ClearSelectEnhanceGold()
    {
    }

    [Token(Token = "0x600A362")]
    [Address(RVA = "0x653150", Offset = "0x651F50", VA = "0x10653150")]
    private bool ErrorCheck_LvMax() => new bool();

    [Token(Token = "0x600A363")]
    [Address(RVA = "0x6530F0", Offset = "0x651EF0", VA = "0x106530F0")]
    private bool ErrorCheck_InvestLimit() => new bool();

    [Token(Token = "0x600A364")]
    [Address(RVA = "0x653070", Offset = "0x651E70", VA = "0x10653070")]
    private bool ErrorCheck_HaveGold() => new bool();

    [Token(Token = "0x600A365")]
    [Address(RVA = "0x6534E0", Offset = "0x6522E0", VA = "0x106534E0")]
    private long GetNeedNum_LvMax() => new long();

    [Token(Token = "0x600A366")]
    [Address(RVA = "0x6534B0", Offset = "0x6522B0", VA = "0x106534B0")]
    private long GetNeedNum_InvestLimit() => new long();

    [Token(Token = "0x600A367")]
    [Address(RVA = "0x653FD0", Offset = "0x652DD0", VA = "0x10653FD0")]
    private void RefreshFacilityEnhanceSlider()
    {
    }

    [Token(Token = "0x600A368")]
    [Address(RVA = "0x653220", Offset = "0x652020", VA = "0x10653220")]
    private long Exp2Gold(long exp) => new long();

    [Token(Token = "0x600A369")]
    [Address(RVA = "0x653680", Offset = "0x652480", VA = "0x10653680")]
    private long Gold2Exp(long gold) => new long();

    [Token(Token = "0x600A36A")]
    [Address(RVA = "0x653250", Offset = "0x652050", VA = "0x10653250")]
    private string GetEnhancedNoticeText() => (string) null;

    [Token(Token = "0x600A36B")]
    [Address(RVA = "0x653960", Offset = "0x652760", VA = "0x10653960")]
    private void OnChange_GuildFacilityEnhanceGoldSlider(float value)
    {
    }

    [Token(Token = "0x600A36C")]
    [Address(RVA = "0x653FA0", Offset = "0x652DA0", VA = "0x10653FA0")]
    private void OnClose_ErrorWindow(GameObject go)
    {
    }

    [Token(Token = "0x600A36D")]
    [Address(RVA = "0x653F40", Offset = "0x652D40", VA = "0x10653F40")]
    public void OnClick_EnhanceGoldCountUp()
    {
    }

    [Token(Token = "0x600A36E")]
    [Address(RVA = "0x653CA0", Offset = "0x652AA0", VA = "0x10653CA0")]
    public void OnClick_EnhanceGoldCountDown()
    {
    }

    [Token(Token = "0x600A36F")]
    [Address(RVA = "0x653D00", Offset = "0x652B00", VA = "0x10653D00")]
    public void OnClick_EnhanceGoldCountMax()
    {
    }

    [Token(Token = "0x600A370")]
    [Address(RVA = "0x6538F0", Offset = "0x6526F0", VA = "0x106538F0")]
    private IEnumerator LevelupAnimation(
      GuildFacilityData facility,
      GuildFacilityEnhance_Gold.EffectCallBack callback)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x600A371")]
    [Address(RVA = "0x652F40", Offset = "0x651D40", VA = "0x10652F40")]
    private void EndLevelupAnimation()
    {
    }

    [Token(Token = "0x600A372")]
    [Address(RVA = "0x6558F0", Offset = "0x6546F0", VA = "0x106558F0")]
    public GuildFacilityEnhance_Gold()
    {
    }

    [Token(Token = "0x2002526")]
    public delegate void EffectCallBack();
  }
}

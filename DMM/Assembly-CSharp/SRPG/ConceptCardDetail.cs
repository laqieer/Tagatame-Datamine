// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardDetail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021E2")]
  [AddComponentMenu("UI/ConceptCardDetail")]
  [FlowNode.Pin(201, "念装開眼表示を閉じる", FlowNode.PinTypes.Output, 201)]
  [FlowNode.Pin(200, "素材アイコンを更新", FlowNode.PinTypes.Output, 200)]
  [FlowNode.Pin(120, "開眼素材一覧を閉じる", FlowNode.PinTypes.Output, 120)]
  [FlowNode.Pin(111, "念装切替終了", FlowNode.PinTypes.Output, 111)]
  [FlowNode.Pin(102, "未受取トラストマスター達成", FlowNode.PinTypes.Output, 102)]
  [FlowNode.Pin(110, "EX化可能(TIPS表示用)", FlowNode.PinTypes.Output, 110)]
  [FlowNode.Pin(15, "強化ボタンが押された", FlowNode.PinTypes.Input, 15)]
  [FlowNode.Pin(14, "念装開眼表示", FlowNode.PinTypes.Input, 14)]
  [FlowNode.Pin(13, "一括強化後の処理", FlowNode.PinTypes.Input, 13)]
  [FlowNode.Pin(12, "未受取トラストマスター達成", FlowNode.PinTypes.Input, 12)]
  [FlowNode.Pin(11, "強化パラメータ表示", FlowNode.PinTypes.Input, 11)]
  [FlowNode.Pin(10, "通常パラメータ表示", FlowNode.PinTypes.Input, 10)]
  [FlowNode.Pin(16, "開眼ボタンが押された", FlowNode.PinTypes.Input, 16)]
  public class ConceptCardDetail : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x40094E0")]
    public const int PIN_REFRESH_PARAM = 10;
    [Token(Token = "0x40094E1")]
    public const int PIN_REFRESH_ENH_PARAM = 11;
    [Token(Token = "0x40094E2")]
    public const int PIN_TRUSTMASTER_START = 12;
    [Token(Token = "0x40094E3")]
    public const int PIN_ENHANCE_BULK_CHECK = 13;
    [Token(Token = "0x40094E4")]
    public const int PIN_EXTRA_RARITY = 14;
    [Token(Token = "0x40094E5")]
    public const int PIN_INPUT_ENHANCE_BTN = 15;
    [Token(Token = "0x40094E6")]
    public const int PIN_INPUT_EXTEA_BTN = 16;
    [Token(Token = "0x40094E7")]
    public const int PIN_TRUSTMASTER_END = 102;
    [Token(Token = "0x40094E8")]
    public const int PIN_OUT_IS_CAN_EXTRA_RARITY = 110;
    [Token(Token = "0x40094E9")]
    public const int PIN_OUT_SET_PARAM = 111;
    [Token(Token = "0x40094EA")]
    public const int PIN_OUT_CLOSE_SELECT_EXTRA = 120;
    [Token(Token = "0x40094EB")]
    public const int PIN_OUT_REFRESH_MATERIAL_LIST = 200;
    [Token(Token = "0x40094EC")]
    public const int PIN_OUT_FORCE_CLOSE_EXTRA_RARITY = 201;
    [Token(Token = "0x40094ED")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RawImage mIllustImage;
    [Token(Token = "0x40094EE")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Image mIllustFrame;
    [Token(Token = "0x40094EF")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mCardNameText;
    [Token(Token = "0x40094F0")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mFlavorText;
    [Token(Token = "0x40094F1")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Toggle mFavoriteToggle;
    [Token(Token = "0x40094F2")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Button EnhanceButton;
    [Token(Token = "0x40094F3")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Button EnhanceExecButton;
    [Token(Token = "0x40094F4")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject GroupIconParent;
    [Token(Token = "0x40094F5")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private StarGaugeEx mStarGauge;
    [Token(Token = "0x40094F6")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Button BackButton;
    [Token(Token = "0x40094F7")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Button FowardButton;
    [Token(Token = "0x40094F8")]
    [FieldOffset(Offset = "0x38")]
    private ConceptCardDescription mConceptCardDescription;
    [Token(Token = "0x40094F9")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private GameObject mConceptCardDescriptionPrefab;
    [Token(Token = "0x40094FA")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Transform mConceptCardDescriptionParent;
    [Token(Token = "0x40094FB")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private ConceptCardExtraRaritySelectedMaterialView mSelectedMaterialView;
    [Token(Token = "0x40094FC")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject mExtraRarityHoloEffect;
    [Token(Token = "0x40094FD")]
    [FieldOffset(Offset = "0x4C")]
    private ConceptCardData mConceptCardData;
    [Token(Token = "0x40094FE")]
    [FieldOffset(Offset = "0x50")]
    private ConceptCardManager mCCManager;
    [Token(Token = "0x40094FF")]
    [FieldOffset(Offset = "0x54")]
    private bool mIsExtraRaritySet;
    [Token(Token = "0x4009500")]
    [FieldOffset(Offset = "0x55")]
    private ConceptCardDetail.SelectDetail mCurrentDetail;
    [Token(Token = "0x4009501")]
    [FieldOffset(Offset = "0x56")]
    private ConceptCardDetail.SelectDetail mPreviousDetail;
    [Token(Token = "0x4009502")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private ConceptCardDetail.IllustFrame IllustFrameSprites;

    [Token(Token = "0x17001436")]
    public ConceptCardDescription Description
    {
      [Token(Token = "0x6008F20"), Address(RVA = "0x2880A0", Offset = "0x286EA0", VA = "0x102880A0")] get
      {
        return (ConceptCardDescription) null;
      }
    }

    [Token(Token = "0x17001437")]
    private ConceptCardManager CCManager
    {
      [Token(Token = "0x6008F21"), Address(RVA = "0x52D500", Offset = "0x52C300", VA = "0x1052D500")] get
      {
        return (ConceptCardManager) null;
      }
    }

    [Token(Token = "0x17001438")]
    public bool IsCanExtraRarity
    {
      [Token(Token = "0x6008F22"), Address(RVA = "0x52D5C0", Offset = "0x52C3C0", VA = "0x1052D5C0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6008F23")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    private void Start()
    {
    }

    [Token(Token = "0x6008F24")]
    [Address(RVA = "0x52BC90", Offset = "0x52AA90", VA = "0x1052BC90")]
    public void Init()
    {
    }

    [Token(Token = "0x6008F25")]
    [Address(RVA = "0x52B6D0", Offset = "0x52A4D0", VA = "0x1052B6D0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008F26")]
    [Address(RVA = "0x52BD40", Offset = "0x52AB40", VA = "0x1052BD40")]
    public bool IsTrsutMaster() => new bool();

    [Token(Token = "0x6008F27")]
    [Address(RVA = "0x52D2E0", Offset = "0x52C0E0", VA = "0x1052D2E0")]
    private IEnumerator TrustMasterUpdate(ConceptCardData cardData) => (IEnumerator) null;

    [Token(Token = "0x6008F28")]
    [Address(RVA = "0x52BF10", Offset = "0x52AD10", VA = "0x1052BF10")]
    public void RefreshEnhanceButton()
    {
    }

    [Token(Token = "0x6008F29")]
    [Address(RVA = "0x52C060", Offset = "0x52AE60", VA = "0x1052C060")]
    public void RefreshEnhanceExecButton()
    {
    }

    [Token(Token = "0x6008F2A")]
    [Address(RVA = "0x52CBD0", Offset = "0x52B9D0", VA = "0x1052CBD0")]
    public void SetParam(bool bEnhance, bool isExtraRaritySet = false)
    {
    }

    [Token(Token = "0x6008F2B")]
    [Address(RVA = "0x52C620", Offset = "0x52B420", VA = "0x1052C620")]
    private void Refresh()
    {
    }

    [Token(Token = "0x6008F2C")]
    [Address(RVA = "0x52C540", Offset = "0x52B340", VA = "0x1052C540")]
    private void RefreshSelectedMaterialView()
    {
    }

    [Token(Token = "0x6008F2D")]
    [Address(RVA = "0x52C3F0", Offset = "0x52B1F0", VA = "0x1052C3F0")]
    public void RefreshSelectButtonInteractable()
    {
    }

    [Token(Token = "0x6008F2E")]
    [Address(RVA = "0x52CB40", Offset = "0x52B940", VA = "0x1052CB40")]
    public void SetFlavorTextText()
    {
    }

    [Token(Token = "0x6008F2F")]
    [Address(RVA = "0x52D270", Offset = "0x52C070", VA = "0x1052D270")]
    public void SetText(Text text, string str)
    {
    }

    [Token(Token = "0x6008F30")]
    [Address(RVA = "0x52CAD0", Offset = "0x52B8D0", VA = "0x1052CAD0")]
    public void SetFavoriteToggle(bool is_on)
    {
    }

    [Token(Token = "0x6008F31")]
    [Address(RVA = "0x52D090", Offset = "0x52BE90", VA = "0x1052D090")]
    private void SetStarGauge()
    {
    }

    [Token(Token = "0x6008F32")]
    [Address(RVA = "0x52BA90", Offset = "0x52A890", VA = "0x1052BA90")]
    public void FowardCardDetail()
    {
    }

    [Token(Token = "0x6008F33")]
    [Address(RVA = "0x52B960", Offset = "0x52A760", VA = "0x1052B960")]
    public void BackCardDetail()
    {
    }

    [Token(Token = "0x6008F34")]
    [Address(RVA = "0x52D350", Offset = "0x52C150", VA = "0x1052D350")]
    public void UpdateSelectConceptCard(int index)
    {
    }

    [Token(Token = "0x6008F35")]
    [Address(RVA = "0x52BB80", Offset = "0x52A980", VA = "0x1052BB80")]
    private Sprite GetIllustFrame(int index, bool isExtraRarity = false) => (Sprite) null;

    [Token(Token = "0x6008F36")]
    [Address(RVA = "0x52C230", Offset = "0x52B030", VA = "0x1052C230")]
    private void RefreshIllustFrame()
    {
    }

    [Token(Token = "0x6008F37")]
    [Address(RVA = "0x52C1C0", Offset = "0x52AFC0", VA = "0x1052C1C0")]
    private void RefreshHoloEffect()
    {
    }

    [Token(Token = "0x6008F38")]
    [Address(RVA = "0x52D070", Offset = "0x52BE70", VA = "0x1052D070")]
    private bool SetSelectDetail(ConceptCardDetail.SelectDetail select) => new bool();

    [Token(Token = "0x6008F39")]
    [Address(RVA = "0x52BA30", Offset = "0x52A830", VA = "0x1052BA30")]
    private void CheckPrevSelectDetail(ConceptCardDetail.SelectDetail select)
    {
    }

    [Token(Token = "0x6008F3A")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardDetail()
    {
    }

    [Token(Token = "0x20021E3")]
    private enum SelectDetail : byte
    {
      [Token(Token = "0x4009504")] DEFAULT,
      [Token(Token = "0x4009505")] ENHANCE,
      [Token(Token = "0x4009506")] EXTRA_RARITY,
    }

    [Token(Token = "0x20021E4")]
    [Serializable]
    public struct IllustFrame
    {
      [Token(Token = "0x4009507")]
      [FieldOffset(Offset = "0x0")]
      public Sprite[] DefaultFrame;
      [Token(Token = "0x4009508")]
      [FieldOffset(Offset = "0x4")]
      public Sprite[] ExtraFrames;
    }
  }
}

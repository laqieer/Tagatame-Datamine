// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardIcon
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
  [Token(Token = "0x2002212")]
  [AddComponentMenu("UI/ConceptCardIcon")]
  public class ConceptCardIcon : MonoBehaviour
  {
    [Token(Token = "0x400966F")]
    private const string EXTRA_RARITY_MATERIAL_POINT_TEXT = "sys.CONCEPTCARD_ICON_EXTRA_RARITY_MATERIAL_POINT";
    [Token(Token = "0x4009670")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private RawImage mIconImage;
    [Token(Token = "0x4009671")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Text mNameText;
    [Token(Token = "0x4009672")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private Text mLevelTitleText;
    [Token(Token = "0x4009673")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text mLevelText;
    [Token(Token = "0x4009674")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Text mLevelCapText;
    [Token(Token = "0x4009675")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Image mRarityImage;
    [Token(Token = "0x4009676")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private ImageArray mRarityFrame;
    [Token(Token = "0x4009677")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text mTrustText;
    [Token(Token = "0x4009678")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject mFavorite;
    [Token(Token = "0x4009679")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private GameObject mOwner;
    [Token(Token = "0x400967A")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Image mOwnerIcon;
    [Token(Token = "0x400967B")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private GameObject mSameCardIcon;
    [Token(Token = "0x400967C")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private ImageArray mEquipTypeImage;
    [Token(Token = "0x400967D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private GameObject mExistSwitchOn;
    [Token(Token = "0x400967E")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private GameObject mExistSwitchOff;
    [Token(Token = "0x400967F")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text mCardNum;
    [Token(Token = "0x4009680")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private GameObject mNotSale;
    [Token(Token = "0x4009681")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject mRecommend;
    [Token(Token = "0x4009682")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private GameObject mDisableObject;
    [Token(Token = "0x4009683")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private GameObject mSelectObject;
    [Token(Token = "0x4009684")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private bool mIsIncludeOverWrite;
    [Token(Token = "0x4009685")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private SwitchingBadge mSwitchingBadge;
    [Token(Token = "0x4009686")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private GameObject mOrganization;
    [Token(Token = "0x4009687")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject mBeforeUsed;
    [Token(Token = "0x4009688")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private Text mTrustMaxText;
    [Token(Token = "0x4009689")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Text mParameterText;
    [Token(Token = "0x400968A")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    private Text mExtraRareText;
    [Token(Token = "0x400968B")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private GameObject mLevelTextObj;
    [Token(Token = "0x400968C")]
    [FieldOffset(Offset = "0x7C")]
    [SerializeField]
    private GameObject mTrustTextObj;
    [Token(Token = "0x400968D")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private GameObject mParamTextObj;
    [Token(Token = "0x400968E")]
    [FieldOffset(Offset = "0x84")]
    [SerializeField]
    private GameObject mExRareTextObj;
    [Token(Token = "0x400968F")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private List<Text> mTrustTextList;
    [Token(Token = "0x4009690")]
    [FieldOffset(Offset = "0x8C")]
    [SerializeField]
    private List<Text> mExRareTextList;
    [Token(Token = "0x4009691")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Text mExtraRarityMaterialPtText;
    [Token(Token = "0x4009692")]
    [FieldOffset(Offset = "0x94")]
    [SerializeField]
    private Text mHaveAountText;
    [Token(Token = "0x4009693")]
    [FieldOffset(Offset = "0x98")]
    private ConceptCardData mConceptCard;
    [Token(Token = "0x4009694")]
    [FieldOffset(Offset = "0x9C")]
    private ConceptCardListSortWindow.Type SortType;

    [Token(Token = "0x17001469")]
    public ConceptCardData ConceptCard
    {
      [Token(Token = "0x6009063"), Address(RVA = "0x289A70", Offset = "0x288870", VA = "0x10289A70")] get
      {
        return (ConceptCardData) null;
      }
    }

    [Token(Token = "0x6009064")]
    [Address(RVA = "0x53E240", Offset = "0x53D040", VA = "0x1053E240")]
    public void Setup(ConceptCardData card)
    {
    }

    [Token(Token = "0x6009065")]
    [Address(RVA = "0x53CB00", Offset = "0x53B900", VA = "0x1053CB00")]
    public void ResetIcon()
    {
    }

    [Token(Token = "0x6009066")]
    [Address(RVA = "0x53C920", Offset = "0x53B720", VA = "0x1053C920")]
    public void Refresh()
    {
    }

    [Token(Token = "0x6009067")]
    [Address(RVA = "0x53B6B0", Offset = "0x53A4B0", VA = "0x1053B6B0")]
    public UnitData GetOwner(bool is_include_over_write) => (UnitData) null;

    [Token(Token = "0x6009068")]
    [Address(RVA = "0x53B9E0", Offset = "0x53A7E0", VA = "0x1053B9E0")]
    private void RefreshExistImage()
    {
    }

    [Token(Token = "0x6009069")]
    [Address(RVA = "0x53BA50", Offset = "0x53A850", VA = "0x1053BA50")]
    private void RefreshIconImage()
    {
    }

    [Token(Token = "0x600906A")]
    [Address(RVA = "0x53BB40", Offset = "0x53A940", VA = "0x1053BB40")]
    private void RefreshIconParam()
    {
    }

    [Token(Token = "0x600906B")]
    [Address(RVA = "0x53D700", Offset = "0x53C500", VA = "0x1053D700")]
    public void SetNameText(string name)
    {
    }

    [Token(Token = "0x600906C")]
    [Address(RVA = "0x53D5F0", Offset = "0x53C3F0", VA = "0x1053D5F0")]
    public void SetLevelText(int lv)
    {
    }

    [Token(Token = "0x600906D")]
    [Address(RVA = "0x53D4E0", Offset = "0x53C2E0", VA = "0x1053D4E0")]
    public void SetLevelCapText(int lvcap)
    {
    }

    [Token(Token = "0x600906E")]
    [Address(RVA = "0x53E1D0", Offset = "0x53CFD0", VA = "0x1053E1D0")]
    public void SetTrustText(int trust)
    {
    }

    [Token(Token = "0x600906F")]
    [Address(RVA = "0x53E150", Offset = "0x53CF50", VA = "0x1053E150")]
    public void SetTrustMaxText(int value)
    {
    }

    [Token(Token = "0x6009070")]
    [Address(RVA = "0x53D760", Offset = "0x53C560", VA = "0x1053D760")]
    public void SetNoRewardTrustText(string text = "---")
    {
    }

    [Token(Token = "0x6009071")]
    [Address(RVA = "0x53DD60", Offset = "0x53CB60", VA = "0x1053DD60")]
    public void SetRarityImage(ConceptCardData card)
    {
    }

    [Token(Token = "0x6009072")]
    [Address(RVA = "0x53D2F0", Offset = "0x53C0F0", VA = "0x1053D2F0")]
    public void SetFavorite(bool favorite)
    {
    }

    [Token(Token = "0x6009073")]
    [Address(RVA = "0x53DC60", Offset = "0x53CA60", VA = "0x1053DC60")]
    public void SetRarityFrame(ConceptCardData cardData)
    {
    }

    [Token(Token = "0x6009074")]
    [Address(RVA = "0x53D810", Offset = "0x53C610", VA = "0x1053D810")]
    private void SetObjectTrustSentence(bool value)
    {
    }

    [Token(Token = "0x6009075")]
    [Address(RVA = "0x53DBC0", Offset = "0x53C9C0", VA = "0x1053DBC0")]
    public void SetParameterText(long parameter)
    {
    }

    [Token(Token = "0x6009076")]
    [Address(RVA = "0x53CCF0", Offset = "0x53BAF0", VA = "0x1053CCF0")]
    public void SetExRarePointText(long value, bool is_enable_extra_rarity = false)
    {
    }

    [Token(Token = "0x6009077")]
    [Address(RVA = "0x53DAA0", Offset = "0x53C8A0", VA = "0x1053DAA0")]
    public void SetOwnerIcon(Image OwnerIcon)
    {
    }

    [Token(Token = "0x6009078")]
    [Address(RVA = "0x53DF80", Offset = "0x53CD80", VA = "0x1053DF80")]
    public void SetSameCardIcon()
    {
    }

    [Token(Token = "0x6009079")]
    [Address(RVA = "0x53CC80", Offset = "0x53BA80", VA = "0x1053CC80")]
    public void SetCardNum(int num)
    {
    }

    [Token(Token = "0x600907A")]
    [Address(RVA = "0x53D7C0", Offset = "0x53C5C0", VA = "0x1053D7C0")]
    public void SetNotSellFlag(bool flag)
    {
    }

    [Token(Token = "0x600907B")]
    [Address(RVA = "0x53DE50", Offset = "0x53CC50", VA = "0x1053DE50")]
    public void SetRecommendFlag(bool flag)
    {
    }

    [Token(Token = "0x600907C")]
    [Address(RVA = "0x53B6E0", Offset = "0x53A4E0", VA = "0x1053B6E0")]
    public void RefreshEnableParam(bool enable)
    {
    }

    [Token(Token = "0x600907D")]
    [Address(RVA = "0x53C890", Offset = "0x53B690", VA = "0x1053C890")]
    public void RefreshSelectParam(bool selected)
    {
    }

    [Token(Token = "0x600907E")]
    [Address(RVA = "0x53D970", Offset = "0x53C770", VA = "0x1053D970")]
    public void SetOrganization(bool flag)
    {
    }

    [Token(Token = "0x600907F")]
    [Address(RVA = "0x53CB50", Offset = "0x53B950", VA = "0x1053CB50")]
    public void SetBeforeUsed(bool flag)
    {
    }

    [Token(Token = "0x6009080")]
    [Address(RVA = "0x53B7D0", Offset = "0x53A5D0", VA = "0x1053B7D0")]
    private void RefreshEquipTypeImage(UnitData owner)
    {
    }

    [Token(Token = "0x6009081")]
    [Address(RVA = "0x53D050", Offset = "0x53BE50", VA = "0x1053D050")]
    private void SetExtraRarityMaterialPoint()
    {
    }

    [Token(Token = "0x6009082")]
    [Address(RVA = "0x53D340", Offset = "0x53C140", VA = "0x1053D340")]
    private void SetHaveAmount()
    {
    }

    [Token(Token = "0x6009083")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardIcon()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardDetailLevel
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021EC")]
  [AddComponentMenu("UI/ConceptCardDetailLevel")]
  public class ConceptCardDetailLevel : ConceptCardDetailBase
  {
    [Token(Token = "0x4009532")]
    [FieldOffset(Offset = "0x10")]
    private readonly string ANIM_NAME_LV_TEXT_STYLE_DEFAULT;
    [Token(Token = "0x4009533")]
    [FieldOffset(Offset = "0x14")]
    private readonly string ANIM_NAME_LV_TEXT_STYLE_ENHANCE;
    [Token(Token = "0x4009534")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mTrustList;
    [Token(Token = "0x4009535")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private Animator mCardLvAnimator;
    [Token(Token = "0x4009536")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private Text mCardLvCapText;
    [Token(Token = "0x4009537")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Text mCardLvText;
    [Token(Token = "0x4009538")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private Text mCardNextExpText;
    [Token(Token = "0x4009539")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private Text mCardTrustItemText;
    [Token(Token = "0x400953A")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text mCardTrustItemMaxText;
    [Token(Token = "0x400953B")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Text mCardTrustBonusText;
    [Token(Token = "0x400953C")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Text mCardTrustBonusMaxText;
    [Token(Token = "0x400953D")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private Text mCardTrustName;
    [Token(Token = "0x400953E")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text mCardPredictLvWhiteText;
    [Token(Token = "0x400953F")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private Text mCardPredictLvGreenText;
    [Token(Token = "0x4009540")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private Text mCardPredictLvCapWhiteText;
    [Token(Token = "0x4009541")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private Text mCardPredictLvCapGreenText;
    [Token(Token = "0x4009542")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject mCardPredictLvSlash;
    [Token(Token = "0x4009543")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private Text mCardNextPredictExpText;
    [Token(Token = "0x4009544")]
    [FieldOffset(Offset = "0x58")]
    [SerializeField]
    private Text mCardPredictTrustItemText;
    [Token(Token = "0x4009545")]
    [FieldOffset(Offset = "0x5C")]
    [SerializeField]
    private Text mCardPredictTrustItemMaxText;
    [Token(Token = "0x4009546")]
    [FieldOffset(Offset = "0x60")]
    [SerializeField]
    private Text mCardPredictTrustBonusText;
    [Token(Token = "0x4009547")]
    [FieldOffset(Offset = "0x64")]
    [SerializeField]
    private Text mCardPredictTrustBonusMaxText;
    [Token(Token = "0x4009548")]
    [FieldOffset(Offset = "0x68")]
    [SerializeField]
    private GameObject mCardPredictLvArrow;
    [Token(Token = "0x4009549")]
    [FieldOffset(Offset = "0x6C")]
    [SerializeField]
    private Slider mCardLvSlider;
    [Token(Token = "0x400954A")]
    [FieldOffset(Offset = "0x70")]
    [SerializeField]
    private Slider mCardPredictLvSlider;
    [Token(Token = "0x400954B")]
    [FieldOffset(Offset = "0x74")]
    [SerializeField]
    private GameObject mTrustMasterRewardBase;
    [Token(Token = "0x400954C")]
    [FieldOffset(Offset = "0x78")]
    [SerializeField]
    private RawImage mTrustMasterRewardIcon;
    [Token(Token = "0x400954D")]
    [FieldOffset(Offset = "0x7C")]
    [SerializeField]
    private Image mTrustMasuterRewardFrame;
    [Token(Token = "0x400954E")]
    [FieldOffset(Offset = "0x80")]
    [SerializeField]
    private GameObject mTrustMasterRewardItemIconObject;
    [Token(Token = "0x400954F")]
    [FieldOffset(Offset = "0x84")]
    [SerializeField]
    private ConceptCardIcon mTrustMasterRewardCardIcon;
    [Token(Token = "0x4009550")]
    [FieldOffset(Offset = "0x88")]
    [SerializeField]
    private GameObject mTrustMasterRewardAmountCountParent;
    [Token(Token = "0x4009551")]
    [FieldOffset(Offset = "0x8C")]
    [SerializeField]
    private Text mTrustMasterRewardAmountCount;
    [Token(Token = "0x4009552")]
    [FieldOffset(Offset = "0x90")]
    [SerializeField]
    private Animator mTrustUpAnimator;
    [Token(Token = "0x4009553")]
    [FieldOffset(Offset = "0x94")]
    [SerializeField]
    private GameObject mAwakeCountIconsParent;
    [Token(Token = "0x4009554")]
    [FieldOffset(Offset = "0x98")]
    [SerializeField]
    private float mMixEffectAnimTime;
    [Token(Token = "0x4009555")]
    [FieldOffset(Offset = "0x9C")]
    [SerializeField]
    private GameObject mPrefabPopupLeaderSkillOpen;
    [Token(Token = "0x4009556")]
    [FieldOffset(Offset = "0xA0")]
    private GameObject mPopupLeaderSkillOpen;
    [Token(Token = "0x4009557")]
    [FieldOffset(Offset = "0xA4")]
    private int mExpStart;
    [Token(Token = "0x4009558")]
    [FieldOffset(Offset = "0xA8")]
    private int mExpEnd;
    [Token(Token = "0x4009559")]
    [FieldOffset(Offset = "0xAC")]
    private int mTrustStart;
    [Token(Token = "0x400955A")]
    [FieldOffset(Offset = "0xB0")]
    private int mTrustEnd;
    [Token(Token = "0x400955B")]
    [FieldOffset(Offset = "0xB4")]
    private ConceptCardDetailLevel.EffectCallBack mCallback;
    [Token(Token = "0x400955C")]
    [FieldOffset(Offset = "0xB8")]
    private int mAddExp;
    [Token(Token = "0x400955D")]
    [FieldOffset(Offset = "0xBC")]
    private int mAddTrust;
    [Token(Token = "0x400955E")]
    [FieldOffset(Offset = "0xC0")]
    private int mAddAwakeLv;
    [Token(Token = "0x400955F")]
    [FieldOffset(Offset = "0xC4")]
    private int mAddAwakeCount;
    [Token(Token = "0x4009560")]
    [FieldOffset(Offset = "0xC8")]
    private int mAddTrustLv;
    [Token(Token = "0x4009561")]
    [FieldOffset(Offset = "0xCC")]
    private bool mEnhance;
    [Token(Token = "0x4009562")]
    [FieldOffset(Offset = "0xCD")]
    private bool mIsEnableOpenExtra;

    [Token(Token = "0x6008F5C")]
    [Address(RVA = "0x529270", Offset = "0x528070", VA = "0x10529270", Slot = "6")]
    public override void SetParam(
      ConceptCardData card_data,
      int addExp,
      int addTrust,
      int addAwakeLv,
      bool isExtra)
    {
    }

    [Token(Token = "0x6008F5D")]
    [Address(RVA = "0x528E40", Offset = "0x527C40", VA = "0x10528E40", Slot = "7")]
    public override void Refresh()
    {
    }

    [Token(Token = "0x6008F5E")]
    [Address(RVA = "0x5279C0", Offset = "0x5267C0", VA = "0x105279C0")]
    public void RefreshIcon()
    {
    }

    [Token(Token = "0x6008F5F")]
    [Address(RVA = "0x527930", Offset = "0x526730", VA = "0x10527930")]
    public void RefreshFrame()
    {
    }

    [Token(Token = "0x6008F60")]
    [Address(RVA = "0x528D20", Offset = "0x527B20", VA = "0x10528D20")]
    private void RefreshRewardAmountCount()
    {
    }

    [Token(Token = "0x6008F61")]
    [Address(RVA = "0x527BD0", Offset = "0x5269D0", VA = "0x10527BD0")]
    public void RefreshParam(
      int rarity,
      int baseExp,
      int baseTrust,
      int lvCap,
      bool enhance,
      bool enhance_anim = false)
    {
    }

    [Token(Token = "0x6008F62")]
    [Address(RVA = "0x527170", Offset = "0x525F70", VA = "0x10527170")]
    private void GetExpParameter(
      int rarity,
      int exp,
      int lvcap,
      out int lv,
      out int nextExp,
      out int expTbl)
    {
    }

    [Token(Token = "0x6008F63")]
    [Address(RVA = "0x5274C0", Offset = "0x5262C0", VA = "0x105274C0")]
    private void RefreshAwakeIcons(bool is_enhance)
    {
    }

    [Token(Token = "0x6008F64")]
    [Address(RVA = "0x529440", Offset = "0x528240", VA = "0x10529440")]
    public void SetupLevelupAnimation(int addExp, int addTrust, int addAwakeLv = 0)
    {
    }

    [Token(Token = "0x6008F65")]
    [Address(RVA = "0x529F10", Offset = "0x528D10", VA = "0x10529F10")]
    public void StartLevelupAnimation(ConceptCardDetailLevel.EffectCallBack cb)
    {
    }

    [Token(Token = "0x6008F66")]
    [Address(RVA = "0x5296B0", Offset = "0x5284B0", VA = "0x105296B0")]
    public void StartAwakeAnimation(ConceptCardDetailLevel.EffectCallBack cb)
    {
    }

    [Token(Token = "0x6008F67")]
    [Address(RVA = "0x52A240", Offset = "0x529040", VA = "0x1052A240")]
    public void StartTrustMasterAnimation(ConceptCardDetailLevel.EffectCallBack cb)
    {
    }

    [Token(Token = "0x6008F68")]
    [Address(RVA = "0x529740", Offset = "0x528540", VA = "0x10529740")]
    public void StartExtraRarityAnimation(ConceptCardDetailLevel.EffectCallBack cb)
    {
    }

    [Token(Token = "0x6008F69")]
    [Address(RVA = "0x529CA0", Offset = "0x528AA0", VA = "0x10529CA0")]
    public void StartGroupSkillPowerUpAnimation(ConceptCardDetailLevel.EffectCallBack cb)
    {
    }

    [Token(Token = "0x6008F6A")]
    [Address(RVA = "0x5297F0", Offset = "0x5285F0", VA = "0x105297F0")]
    public void StartGroupSkillMaxPowerUpAnimation(ConceptCardDetailLevel.EffectCallBack cb)
    {
    }

    [Token(Token = "0x6008F6B")]
    [Address(RVA = "0x5273C0", Offset = "0x5261C0", VA = "0x105273C0")]
    private IEnumerator LevelupUpdate(
      ConceptCardData cardData,
      bool bLevelUpEffect,
      bool bTrustUpEffect)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6008F6C")]
    [Address(RVA = "0x527080", Offset = "0x525E80", VA = "0x10527080")]
    private IEnumerator AwakeUpdate(bool is_awake) => (IEnumerator) null;

    [Token(Token = "0x6008F6D")]
    [Address(RVA = "0x52A3A0", Offset = "0x5291A0", VA = "0x1052A3A0")]
    private IEnumerator TrustMasterUpdate(ConceptCardData cardData, bool bTrustMasterEffect)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6008F6E")]
    [Address(RVA = "0x527330", Offset = "0x526130", VA = "0x10527330")]
    private IEnumerator GroupSkillPowerUpUpdate(
      ConceptCardData cardData,
      bool bGroupSkillPowerUp,
      ConceptCardEffectRoutine.EffectAltData altData)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6008F6F")]
    [Address(RVA = "0x5272A0", Offset = "0x5260A0", VA = "0x105272A0")]
    private IEnumerator GroupSkillMaxPowerUpUpdate(
      ConceptCardData cardData,
      bool bGroupSkillMaxPowerUp,
      ConceptCardEffectRoutine.EffectAltData altData)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6008F70")]
    [Address(RVA = "0x527440", Offset = "0x526240", VA = "0x10527440")]
    private void OnDestroy()
    {
    }

    [Token(Token = "0x6008F71")]
    [Address(RVA = "0x5290C0", Offset = "0x527EC0", VA = "0x105290C0")]
    private void SetExtraRarityParam(bool isExtra)
    {
    }

    [Token(Token = "0x6008F72")]
    [Address(RVA = "0x5270F0", Offset = "0x525EF0", VA = "0x105270F0")]
    private IEnumerator ExtraRarityUpdate(bool is_extra_rarity, ConceptCardData cardData)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6008F73")]
    [Address(RVA = "0x52A420", Offset = "0x529220", VA = "0x1052A420")]
    public ConceptCardDetailLevel()
    {
    }

    [Token(Token = "0x20021ED")]
    public delegate void EffectCallBack();
  }
}

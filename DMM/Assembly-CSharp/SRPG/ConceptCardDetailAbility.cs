// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardDetailAbility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021E6")]
  [FlowNode.Pin(10, "データ設定完了", FlowNode.PinTypes.Output, 10)]
  [AddComponentMenu("UI/ConceptCardDetailAbility")]
  public class ConceptCardDetailAbility : ConceptCardDetailBase, IFlowInterface
  {
    [Token(Token = "0x400950F")]
    private const int PIN_ABILITY_DETAIL = 0;
    [Token(Token = "0x4009510")]
    private const int PIN_ABILITY_DETAIL_END = 10;
    [Token(Token = "0x4009511")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private GameObject mCardAbilityObject;
    [Token(Token = "0x4009512")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject mCardSkillObject;
    [Token(Token = "0x4009513")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private GameObject mCardAbilityNameObject;
    [Token(Token = "0x4009514")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject mCardSkillNameObject;
    [Token(Token = "0x4009515")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mCardUniqueUnitObject;
    [Token(Token = "0x4009516")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private GameObject mCardUniqueJobObject;
    [Token(Token = "0x4009517")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private GameObject mCardCommonUnitObject;
    [Token(Token = "0x4009518")]
    [FieldOffset(Offset = "0x2C")]
    [SerializeField]
    private GameObject mCardCommonJobObject;
    [Token(Token = "0x4009519")]
    [FieldOffset(Offset = "0x30")]
    [SerializeField]
    private Text mCardUseUnitText;
    [Token(Token = "0x400951A")]
    [FieldOffset(Offset = "0x34")]
    [SerializeField]
    private Text mCardUseJobText;
    [Token(Token = "0x400951B")]
    [FieldOffset(Offset = "0x38")]
    [SerializeField]
    private Image_Transparent mCardUseUnitImage;
    [Token(Token = "0x400951C")]
    [FieldOffset(Offset = "0x3C")]
    [SerializeField]
    private RawImage_Transparent mCardUseJobImage;
    [Token(Token = "0x400951D")]
    [FieldOffset(Offset = "0x40")]
    [SerializeField]
    private Text mCardAbilityDescription;
    [Token(Token = "0x400951E")]
    [FieldOffset(Offset = "0x44")]
    [SerializeField]
    private StatusList mCardSkillStatusList;
    [Token(Token = "0x400951F")]
    [FieldOffset(Offset = "0x48")]
    [SerializeField]
    private GameObject mLock;
    [Token(Token = "0x4009520")]
    [FieldOffset(Offset = "0x4C")]
    [SerializeField]
    private Text mLockText;
    [Token(Token = "0x4009521")]
    [FieldOffset(Offset = "0x50")]
    [SerializeField]
    private GameObject mDecreaseEffectObject;
    [Token(Token = "0x4009522")]
    [FieldOffset(Offset = "0x54")]
    [SerializeField]
    private Text mDecreaseEffectText;
    [Token(Token = "0x4009523")]
    [FieldOffset(Offset = "0x58")]
    private ConceptCardSkillDatailData mShowData;
    [Token(Token = "0x4009524")]
    [FieldOffset(Offset = "0x5C")]
    private ConceptCardDetailAbility.ClickDetail mClickDetail;

    [Token(Token = "0x6008F41")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "8")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x6008F42")]
    [Address(RVA = "0x525C00", Offset = "0x524A00", VA = "0x10525C00")]
    public void OnClickDetail()
    {
    }

    [Token(Token = "0x6008F43")]
    [Address(RVA = "0x525C50", Offset = "0x524A50", VA = "0x10525C50")]
    public void SetCardSkill(
      ConceptCardSkillDatailData data,
      bool isSubSlot,
      int decreaseEffectRate)
    {
    }

    [Token(Token = "0x6008F44")]
    [Address(RVA = "0x526850", Offset = "0x525650", VA = "0x10526850")]
    public void SetUnitIcon(Image_Transparent image, UnitParam unit_param)
    {
    }

    [Token(Token = "0x6008F45")]
    [Address(RVA = "0x525C30", Offset = "0x524A30", VA = "0x10525C30")]
    public void SetAbilityDetailParent(ConceptCardDetailAbility.ClickDetail detail)
    {
    }

    [Token(Token = "0x6008F46")]
    [Address(RVA = "0x525AB0", Offset = "0x5248B0", VA = "0x10525AB0")]
    private string GetLockText(int level) => (string) null;

    [Token(Token = "0x6008F47")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardDetailAbility()
    {
    }

    [Token(Token = "0x20021E7")]
    public enum ShowType
    {
      [Token(Token = "0x4009526")] None,
      [Token(Token = "0x4009527")] Skill,
      [Token(Token = "0x4009528")] Ability,
      [Token(Token = "0x4009529")] LockSkill,
    }

    [Token(Token = "0x20021E8")]
    public delegate void ClickDetail(ConceptCardSkillDatailData data);
  }
}

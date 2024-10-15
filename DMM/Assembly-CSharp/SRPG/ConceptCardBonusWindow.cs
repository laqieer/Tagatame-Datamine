// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardBonusWindow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021DA")]
  [AddComponentMenu("UI/ConceptCardBonusWindow")]
  public class ConceptCardBonusWindow : MonoBehaviour
  {
    [Token(Token = "0x4009496")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Transform mAwakeBonusParent;
    [Token(Token = "0x4009497")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Transform mLvMaxBonusParent;
    [Token(Token = "0x4009498")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private ConceptCardBonusContentAwake mAwakeBonusTemplate;
    [Token(Token = "0x4009499")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private ConceptCardBonusContentLvMax mLvMaxBonusSkillTemplate;
    [Token(Token = "0x400949A")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private ConceptCardBonusContentLvMax mLvMaxBonusAbilityTemplate;
    [Token(Token = "0x400949B")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject mExRareBonusRoot;
    [Token(Token = "0x400949C")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    private Transform mExRareBonusParent;
    [Token(Token = "0x400949D")]
    [FieldOffset(Offset = "0x28")]
    [SerializeField]
    private ConceptCardLimitBreakBonusContentLvMax mExRareBonusTemplate;

    [Token(Token = "0x6008EEC")]
    [Address(RVA = "0x522600", Offset = "0x521400", VA = "0x10522600")]
    public void Initailize(ConceptCardData data)
    {
    }

    [Token(Token = "0x6008EED")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ConceptCardBonusWindow()
    {
    }

    [Token(Token = "0x20021DB")]
    public enum eViewType
    {
      [Token(Token = "0x400949F")] CARD_SKILL,
      [Token(Token = "0x40094A0")] ABILITY,
    }
  }
}

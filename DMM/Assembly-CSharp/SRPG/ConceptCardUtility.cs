// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E93")]
  public class ConceptCardUtility
  {
    [Token(Token = "0x6003CB5")]
    [Address(RVA = "0x10F2390", Offset = "0x10F1190", VA = "0x110F2390")]
    public static bool IsEnableCardSkillForUnit(Unit target, SkillData card_skill) => new bool();

    [Token(Token = "0x6003CB6")]
    [Address(RVA = "0x10F2460", Offset = "0x10F1260", VA = "0x110F2460")]
    public static bool IsGetUnitConceptCard(string iname) => new bool();

    [Token(Token = "0x6003CB7")]
    [Address(RVA = "0x10F2210", Offset = "0x10F1010", VA = "0x110F2210")]
    public static void GetExpParameter(
      int rarity,
      int exp,
      int current_lvcap,
      out int lv,
      out int nextExp,
      out int expTbl)
    {
    }

    [Token(Token = "0x6003CB8")]
    [Address(RVA = "0x10F1E50", Offset = "0x10F0C50", VA = "0x110F1E50")]
    public static List<ConceptCardSkillDatailData> CreateConceptCardSkillDatailData(
      AbilityData abilityData)
    {
      return (List<ConceptCardSkillDatailData>) null;
    }

    [Token(Token = "0x6003CB9")]
    [Address(RVA = "0x10F2170", Offset = "0x10F0F70", VA = "0x110F2170")]
    public static ConceptCardSkillDatailData CreateConceptCardSkillDatailData(SkillData groupSkill)
    {
      return (ConceptCardSkillDatailData) null;
    }

    [Token(Token = "0x6003CBA")]
    [Address(RVA = "0x10F24E0", Offset = "0x10F12E0", VA = "0x110F24E0")]
    public static ConceptCardData[] SetConceptCardData(
      ConceptCardData[] cards,
      int index,
      ConceptCardData cardData)
    {
      return (ConceptCardData[]) null;
    }

    [Token(Token = "0x6003CBB")]
    [Address(RVA = "0x10F2690", Offset = "0x10F1490", VA = "0x110F2690")]
    public static void SetDecreaseEffectRateText(Text text, int decreaseEffectRate)
    {
    }

    [Token(Token = "0x6003CBC")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ConceptCardUtility()
    {
    }
  }
}

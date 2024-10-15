// Decompiled with JetBrains decompiler
// Type: SRPG.SkillAbilityDeriveListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002ABB")]
  [AddComponentMenu("UI/SkillAbilityDeriveListItem")]
  public class SkillAbilityDeriveListItem : MonoBehaviour
  {
    [Token(Token = "0x400D073")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    [HeaderBar("▼派生アビリティ関連")]
    private RectTransform m_AbilityDeriveListRoot;
    [Token(Token = "0x400D074")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private AbilityDeriveList m_AbilityDeriveListTemplate;
    [Token(Token = "0x400D075")]
    [FieldOffset(Offset = "0x14")]
    [HeaderBar("▼派生スキル関連")]
    [SerializeField]
    private RectTransform m_SkillDeriveListRoot;
    [Token(Token = "0x400D076")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private SkillDeriveList m_SkillDeriveListTemplate;
    [Token(Token = "0x400D077")]
    [FieldOffset(Offset = "0x1C")]
    private List<SkillAbilityDeriveListItem.ViewContentSkillParam> m_ViewContentSkillParams;
    [Token(Token = "0x400D078")]
    [FieldOffset(Offset = "0x20")]
    private List<SkillAbilityDeriveListItem.ViewContentAbilityParam> m_ViewContentAbilityParams;

    [Token(Token = "0x600C324")]
    [Address(RVA = "0x8B9120", Offset = "0x8B7F20", VA = "0x108B9120")]
    private void Start()
    {
    }

    [Token(Token = "0x600C325")]
    [Address(RVA = "0x8B8EB0", Offset = "0x8B7CB0", VA = "0x108B8EB0")]
    public void Setup(SkillAbilityDeriveParam skillAbilityDeriveParam)
    {
    }

    [Token(Token = "0x600C326")]
    [Address(RVA = "0x8B8C30", Offset = "0x8B7A30", VA = "0x108B8C30")]
    public void Setup(SkillAbilityDeriveData skillAbilityDeriveData)
    {
    }

    [Token(Token = "0x600C327")]
    [Address(RVA = "0x8B8610", Offset = "0x8B7410", VA = "0x108B8610")]
    private static List<SkillAbilityDeriveListItem.ViewContentAbilityParam> CreateViewContentAbilityParams(
      List<AbilityDeriveParam> deriveAbilityParams)
    {
      return (List<SkillAbilityDeriveListItem.ViewContentAbilityParam>) null;
    }

    [Token(Token = "0x600C328")]
    [Address(RVA = "0x8B8920", Offset = "0x8B7720", VA = "0x108B8920")]
    private static List<SkillAbilityDeriveListItem.ViewContentSkillParam> CreateViewContentSkillParams(
      List<SkillDeriveParam> deriveSkillParams)
    {
      return (List<SkillAbilityDeriveListItem.ViewContentSkillParam>) null;
    }

    [Token(Token = "0x600C329")]
    [Address(RVA = "0x8B8450", Offset = "0x8B7250", VA = "0x108B8450")]
    private void CreateListItem(
      SkillAbilityDeriveListItem.ViewContentSkillParam viewContentSkillParam)
    {
    }

    [Token(Token = "0x600C32A")]
    [Address(RVA = "0x8B8530", Offset = "0x8B7330", VA = "0x108B8530")]
    private void CreateListItem(
      SkillAbilityDeriveListItem.ViewContentAbilityParam viewContentAbilityParam)
    {
    }

    [Token(Token = "0x600C32B")]
    [Address(RVA = "0x8B9180", Offset = "0x8B7F80", VA = "0x108B9180")]
    private void UpdateUIActive()
    {
    }

    [Token(Token = "0x600C32C")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public SkillAbilityDeriveListItem()
    {
    }

    [Token(Token = "0x2002ABC")]
    private class ViewContentAbilityParam
    {
      [Token(Token = "0x400D079")]
      [FieldOffset(Offset = "0x8")]
      public AbilityParam m_BaseAbilityParam;
      [Token(Token = "0x400D07A")]
      [FieldOffset(Offset = "0xC")]
      public List<AbilityDeriveParam> m_AbilityDeriveParam;

      [Token(Token = "0x600C32D")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ViewContentAbilityParam()
      {
      }
    }

    [Token(Token = "0x2002ABD")]
    private class ViewContentSkillParam
    {
      [Token(Token = "0x400D07B")]
      [FieldOffset(Offset = "0x8")]
      public SkillParam m_BaseSkillParam;
      [Token(Token = "0x400D07C")]
      [FieldOffset(Offset = "0xC")]
      public List<SkillDeriveParam> m_SkillDeriveParams;

      [Token(Token = "0x600C32E")]
      [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
      public ViewContentSkillParam()
      {
      }
    }
  }
}

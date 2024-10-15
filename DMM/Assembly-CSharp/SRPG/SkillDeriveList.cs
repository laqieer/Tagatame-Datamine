// Decompiled with JetBrains decompiler
// Type: SRPG.SkillDeriveList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AC0")]
  [AddComponentMenu("UI/SkillDeriveList")]
  public class SkillDeriveList : MonoBehaviour
  {
    [Token(Token = "0x400D07F")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private SkillViewList mBaseSkillViewList;
    [Token(Token = "0x400D080")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    [HeaderBar("▼派生元スキルのバナーが属するリストの親")]
    private GameObject m_BaseSkillRoot;
    [Token(Token = "0x400D081")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject m_DisableBaseObject;
    [Token(Token = "0x400D082")]
    [FieldOffset(Offset = "0x18")]
    [HeaderBar("▼派生先スキル関連のオブジェクトの親")]
    [SerializeField]
    private GameObject m_DeriveObjectRoot;
    [Token(Token = "0x400D083")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private RectTransform m_DeriveSkillListRoot;
    [Token(Token = "0x400D084")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    private GameObject m_DeriveSkillTemplate;
    [Token(Token = "0x400D085")]
    [FieldOffset(Offset = "0x24")]
    [SerializeField]
    [BitMask]
    private SkillDeriveList.ShowFlags m_ShowFlags;
    [Token(Token = "0x400D086")]
    [FieldOffset(Offset = "0x28")]
    private List<GameObject> m_DeriveSkills;
    [Token(Token = "0x400D087")]
    [FieldOffset(Offset = "0x2C")]
    private SkillParam mBaseSkill;

    [Token(Token = "0x170019FB")]
    public bool HasDerive
    {
      [Token(Token = "0x600C333"), Address(RVA = "0x8CADD0", Offset = "0x8C9BD0", VA = "0x108CADD0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x170019FC")]
    public bool IsShowBaseSkill
    {
      [Token(Token = "0x600C334"), Address(RVA = "0x8CAE20", Offset = "0x8C9C20", VA = "0x108CAE20")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C335"), Address(RVA = "0x8CAE30", Offset = "0x8C9C30", VA = "0x108CAE30")] set
      {
      }
    }

    [Token(Token = "0x170019FD")]
    public bool IsDisableBaseSkillInteractable
    {
      [Token(Token = "0x600C336"), Address(RVA = "0x8CAE10", Offset = "0x8C9C10", VA = "0x108CAE10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C337")]
    [Address(RVA = "0x8CA980", Offset = "0x8C9780", VA = "0x108CA980")]
    private void Start()
    {
    }

    [Token(Token = "0x600C338")]
    [Address(RVA = "0x8CA730", Offset = "0x8C9530", VA = "0x108CA730")]
    public void Setup(SkillParam baseSkill, List<SkillDeriveParam> skillDeriveParams)
    {
    }

    [Token(Token = "0x600C339")]
    [Address(RVA = "0x8CA560", Offset = "0x8C9360", VA = "0x108CA560")]
    private void CreateDeriveSkillItem(SkillDeriveParam skillDeriveParam)
    {
    }

    [Token(Token = "0x600C33A")]
    [Address(RVA = "0x8CA9D0", Offset = "0x8C97D0", VA = "0x108CA9D0")]
    public void SwitchBaseSkillEnable(bool enable)
    {
    }

    [Token(Token = "0x600C33B")]
    [Address(RVA = "0x8CAA00", Offset = "0x8C9800", VA = "0x108CAA00")]
    private void UpdateUIActive()
    {
    }

    [Token(Token = "0x600C33C")]
    [Address(RVA = "0x8CA910", Offset = "0x8C9710", VA = "0x108CA910")]
    private bool ShowFlags_IsOn(SkillDeriveList.ShowFlags flags) => new bool();

    [Token(Token = "0x600C33D")]
    [Address(RVA = "0x8CA8F0", Offset = "0x8C96F0", VA = "0x108CA8F0")]
    private bool ShowFlags_IsOff(SkillDeriveList.ShowFlags flags) => new bool();

    [Token(Token = "0x600C33E")]
    [Address(RVA = "0x8CA940", Offset = "0x8C9740", VA = "0x108CA940")]
    private void ShowFlags_SetOn(SkillDeriveList.ShowFlags flags)
    {
    }

    [Token(Token = "0x600C33F")]
    [Address(RVA = "0x8CA930", Offset = "0x8C9730", VA = "0x108CA930")]
    private void ShowFlags_SetOff(SkillDeriveList.ShowFlags flags)
    {
    }

    [Token(Token = "0x600C340")]
    [Address(RVA = "0x8CA950", Offset = "0x8C9750", VA = "0x108CA950")]
    private void ShowFlags_Set(SkillDeriveList.ShowFlags flags, bool value)
    {
    }

    [Token(Token = "0x600C341")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public SkillDeriveList()
    {
    }

    [Token(Token = "0x2002AC1")]
    [Flags]
    private enum ShowFlags
    {
      [Token(Token = "0x400D089")] ShowBaseSkill = 1,
      [Token(Token = "0x400D08A")] DisableBaseSkillInteractable = 2,
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.AbilityDeriveList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001F25")]
  [AddComponentMenu("UI/AbilityDeriveList")]
  public class AbilityDeriveList : MonoBehaviour
  {
    [Token(Token = "0x400830F")]
    [FieldOffset(Offset = "0xC")]
    [HeaderBar("▼派生元アビリティのバナーが属するリストの親")]
    [SerializeField]
    private GameObject m_BaseAbilityRoot;
    [Token(Token = "0x4008310")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Button m_DisableBaseAbility;
    [Token(Token = "0x4008311")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    [HeaderBar("▼派生先アビリティ関連のオブジェクトの親")]
    private GameObject m_DeriveObjectRoot;
    [Token(Token = "0x4008312")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private RectTransform m_DeriveAbilityListRoot;
    [Token(Token = "0x4008313")]
    [FieldOffset(Offset = "0x1C")]
    [SerializeField]
    private GameObject m_DeriveAbilityTemplate;
    [Token(Token = "0x4008314")]
    [FieldOffset(Offset = "0x20")]
    [SerializeField]
    [BitMask]
    private AbilityDeriveList.ShowFlags m_ShowFlags;
    [Token(Token = "0x4008315")]
    [FieldOffset(Offset = "0x24")]
    [HeaderBar("▼アビリティ詳細を開く為のコールバック")]
    public AbilityDeriveList.OnListItemEvent OnDetailOpen;
    [Token(Token = "0x4008316")]
    [FieldOffset(Offset = "0x28")]
    [HeaderBar("▼アビリティが選択された時のコールバック")]
    public AbilityDeriveList.OnListItemEvent OnSelectEvent;
    [Token(Token = "0x4008317")]
    [FieldOffset(Offset = "0x2C")]
    [HeaderBar("▼アビリティのランクアップボタンのコールバック")]
    public AbilityDeriveList.OnListItemEvent OnRankUpEvent;
    [Token(Token = "0x4008318")]
    [FieldOffset(Offset = "0x30")]
    public AbilityDeriveList.OnListItemEvent OnRankUpBtnPressEvent;
    [Token(Token = "0x4008319")]
    [FieldOffset(Offset = "0x34")]
    public AbilityDeriveList.OnListItemEvent OnRankUpBtnUpEvent;
    [Token(Token = "0x400831A")]
    [FieldOffset(Offset = "0x38")]
    private List<GameObject> m_DeriveAbilitys;

    [Token(Token = "0x1700124B")]
    public bool HasDerive
    {
      [Token(Token = "0x6007F70"), Address(RVA = "0x400540", Offset = "0x3FF340", VA = "0x10400540")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700124C")]
    public bool IsShowBaseAbility
    {
      [Token(Token = "0x6007F71"), Address(RVA = "0x400590", Offset = "0x3FF390", VA = "0x10400590")] get
      {
        return new bool();
      }
      [Token(Token = "0x6007F72"), Address(RVA = "0x4005A0", Offset = "0x3FF3A0", VA = "0x104005A0")] set
      {
      }
    }

    [Token(Token = "0x1700124D")]
    public bool IsDisableBaseAbilityInteractable
    {
      [Token(Token = "0x6007F73"), Address(RVA = "0x400580", Offset = "0x3FF380", VA = "0x10400580")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x6007F74")]
    [Address(RVA = "0x400120", Offset = "0x3FEF20", VA = "0x10400120")]
    private void Start()
    {
    }

    [Token(Token = "0x6007F75")]
    [Address(RVA = "0x3FFAF0", Offset = "0x3FE8F0", VA = "0x103FFAF0")]
    public void SetupWithAbilityParam(
      AbilityParam baseAbility,
      List<AbilityDeriveParam> abilityDeriveParams)
    {
    }

    [Token(Token = "0x6007F76")]
    [Address(RVA = "0x3FF8B0", Offset = "0x3FE6B0", VA = "0x103FF8B0")]
    public void SetupWithAbilityData(
      AbilityData baseAbility,
      List<AbilityData> derivedAbilitys,
      UnitData unit_data = null)
    {
    }

    [Token(Token = "0x6007F77")]
    [Address(RVA = "0x3FFCB0", Offset = "0x3FEAB0", VA = "0x103FFCB0")]
    public void SetupWithConceptCard(
      ConceptCardSkillDatailData conceptCardSkillDatailData,
      UnitData unitData,
      ConceptCardDetailAbility.ClickDetail onClickDetail,
      bool enableDecreaseEffectObject,
      int decreaseEffectRate)
    {
    }

    [Token(Token = "0x6007F78")]
    [Address(RVA = "0x3FF810", Offset = "0x3FE610", VA = "0x103FF810")]
    private static void SetupConceptCard(
      GameObject obj,
      ConceptCardSkillDatailData conceptCardSkillDatailData,
      ConceptCardDetailAbility.ClickDetail onClickDetail,
      bool isSubSlot,
      int decreaseEffectRate)
    {
    }

    [Token(Token = "0x6007F79")]
    [Address(RVA = "0x3FED30", Offset = "0x3FDB30", VA = "0x103FED30")]
    private GameObject CreateDeriveAbilityItem(AbilityDeriveParam abilityDeriveParam)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x6007F7A")]
    [Address(RVA = "0x3FEB80", Offset = "0x3FD980", VA = "0x103FEB80")]
    private GameObject CreateDeriveAbilityItem(AbilityData derivedAbility) => (GameObject) null;

    [Token(Token = "0x6007F7B")]
    [Address(RVA = "0x3FEEE0", Offset = "0x3FDCE0", VA = "0x103FEEE0")]
    private GameObject CreateDeriveConceptCardSkillItem(SkillData derivedSkill)
    {
      return (GameObject) null;
    }

    [Token(Token = "0x6007F7C")]
    [Address(RVA = "0x3FF250", Offset = "0x3FE050", VA = "0x103FF250")]
    private void RegisterHoldEvent(GameObject obj)
    {
    }

    [Token(Token = "0x6007F7D")]
    [Address(RVA = "0x400170", Offset = "0x3FEF70", VA = "0x10400170")]
    public void SwitchBaseAbilityEnable(bool enable)
    {
    }

    [Token(Token = "0x6007F7E")]
    [Address(RVA = "0x4001A0", Offset = "0x3FEFA0", VA = "0x104001A0")]
    private void UpdateUIActive()
    {
    }

    [Token(Token = "0x6007F7F")]
    [Address(RVA = "0x3FE770", Offset = "0x3FD570", VA = "0x103FE770")]
    public void AddDetailOpenEventListener(UnityAction<GameObject> callback)
    {
    }

    [Token(Token = "0x6007F80")]
    [Address(RVA = "0x3FEAB0", Offset = "0x3FD8B0", VA = "0x103FEAB0")]
    public void AddSelectEventListener(UnityAction<GameObject> callback)
    {
    }

    [Token(Token = "0x6007F81")]
    [Address(RVA = "0x3FE9E0", Offset = "0x3FD7E0", VA = "0x103FE9E0")]
    public void AddRankUpEventListener(UnityAction<GameObject> callback)
    {
    }

    [Token(Token = "0x6007F82")]
    [Address(RVA = "0x3FE840", Offset = "0x3FD640", VA = "0x103FE840")]
    public void AddRankUpBtnPressEventListener(UnityAction<GameObject> callback)
    {
    }

    [Token(Token = "0x6007F83")]
    [Address(RVA = "0x3FE910", Offset = "0x3FD710", VA = "0x103FE910")]
    public void AddRankUpBtnUpEventListener(UnityAction<GameObject> callback)
    {
    }

    [Token(Token = "0x6007F84")]
    [Address(RVA = "0x3FF7D0", Offset = "0x3FE5D0", VA = "0x103FF7D0")]
    public void RemoveOnDetailOpen(UnityAction<GameObject> callback)
    {
    }

    [Token(Token = "0x6007F85")]
    [Address(RVA = "0x3FF190", Offset = "0x3FDF90", VA = "0x103FF190")]
    public void OpenAbilityDetail(GameObject obj)
    {
    }

    [Token(Token = "0x6007F86")]
    [Address(RVA = "0x3FF150", Offset = "0x3FDF50", VA = "0x103FF150")]
    public void OnSelect(GameObject obj)
    {
    }

    [Token(Token = "0x6007F87")]
    [Address(RVA = "0x3FF110", Offset = "0x3FDF10", VA = "0x103FF110")]
    public void OnRankUp(GameObject obj)
    {
    }

    [Token(Token = "0x6007F88")]
    [Address(RVA = "0x3FF090", Offset = "0x3FDE90", VA = "0x103FF090")]
    public void OnRankUpBtnPress(GameObject obj)
    {
    }

    [Token(Token = "0x6007F89")]
    [Address(RVA = "0x3FF0D0", Offset = "0x3FDED0", VA = "0x103FF0D0")]
    public void OnRankUpBtnUp(GameObject obj)
    {
    }

    [Token(Token = "0x6007F8A")]
    [Address(RVA = "0x4000B0", Offset = "0x3FEEB0", VA = "0x104000B0")]
    private bool ShowFlags_IsOn(AbilityDeriveList.ShowFlags flags) => new bool();

    [Token(Token = "0x6007F8B")]
    [Address(RVA = "0x400090", Offset = "0x3FEE90", VA = "0x10400090")]
    private bool ShowFlags_IsOff(AbilityDeriveList.ShowFlags flags) => new bool();

    [Token(Token = "0x6007F8C")]
    [Address(RVA = "0x4000E0", Offset = "0x3FEEE0", VA = "0x104000E0")]
    private void ShowFlags_SetOn(AbilityDeriveList.ShowFlags flags)
    {
    }

    [Token(Token = "0x6007F8D")]
    [Address(RVA = "0x4000D0", Offset = "0x3FEED0", VA = "0x104000D0")]
    private void ShowFlags_SetOff(AbilityDeriveList.ShowFlags flags)
    {
    }

    [Token(Token = "0x6007F8E")]
    [Address(RVA = "0x4000F0", Offset = "0x3FEEF0", VA = "0x104000F0")]
    private void ShowFlags_Set(AbilityDeriveList.ShowFlags flags, bool value)
    {
    }

    [Token(Token = "0x6007F8F")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public AbilityDeriveList()
    {
    }

    [Token(Token = "0x2001F26")]
    [Serializable]
    public class OnListItemEvent : UnityEvent<GameObject>
    {
      [Token(Token = "0x6007F90")]
      [Address(RVA = "0x411410", Offset = "0x410210", VA = "0x10411410")]
      public OnListItemEvent()
      {
      }
    }

    [Token(Token = "0x2001F27")]
    [Flags]
    private enum ShowFlags
    {
      [Token(Token = "0x400831C")] ShowBaseAbility = 1,
      [Token(Token = "0x400831D")] DisableBaseAbilityInteractable = 2,
    }
  }
}

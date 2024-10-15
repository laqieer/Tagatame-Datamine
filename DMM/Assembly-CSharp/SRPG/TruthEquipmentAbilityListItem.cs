// Decompiled with JetBrains decompiler
// Type: SRPG.TruthEquipmentAbilityListItem
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B8B")]
  [AddComponentMenu("UI/TruthEquipment/TruthEquipmentAbilityListItem")]
  public class TruthEquipmentAbilityListItem : MonoBehaviour
  {
    [Token(Token = "0x400D5B1")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private Text m_TxtLv;
    [Token(Token = "0x400D5B2")]
    [FieldOffset(Offset = "0x10")]
    [SerializeField]
    private Button m_BtnAbilityDetail;
    [Token(Token = "0x400D5B3")]
    [FieldOffset(Offset = "0x14")]
    [SerializeField]
    private GameObject m_LockObject;
    [Token(Token = "0x400D5B4")]
    [FieldOffset(Offset = "0x18")]
    [SerializeField]
    private Text m_TextUnlock;
    [Token(Token = "0x400D5B5")]
    [FieldOffset(Offset = "0x1C")]
    private ViewTruthEquipmentLearnAbility m_LearnAbility;

    [Token(Token = "0x600C7E8")]
    [Address(RVA = "0x90CC80", Offset = "0x90BA80", VA = "0x1090CC80")]
    public void Setup(
      ViewTruthEquipmentLearnAbility ability,
      TruthEquipmentAbilityListItem.OnListItemClicked abilityDetailClicked)
    {
    }

    [Token(Token = "0x600C7E9")]
    [Address(RVA = "0x90CA60", Offset = "0x90B860", VA = "0x1090CA60")]
    private void RefreshLvText()
    {
    }

    [Token(Token = "0x600C7EA")]
    [Address(RVA = "0x90CA00", Offset = "0x90B800", VA = "0x1090CA00")]
    private void RefreshLockObject()
    {
    }

    [Token(Token = "0x600C7EB")]
    [Address(RVA = "0x90CAF0", Offset = "0x90B8F0", VA = "0x1090CAF0")]
    private void RefreshTextUnlock()
    {
    }

    [Token(Token = "0x600C7EC")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public TruthEquipmentAbilityListItem()
    {
    }

    [Token(Token = "0x2002B8C")]
    public delegate void OnListItemClicked(ViewTruthEquipmentLearnAbility learnAbility);
  }
}

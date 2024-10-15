// Decompiled with JetBrains decompiler
// Type: SRPG.TruthEquipmentAbilityList
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B8A")]
  [FlowNode.Pin(100, "アビリティ詳細表示", FlowNode.PinTypes.Output, 100)]
  [AddComponentMenu("UI/TruthEquipment/TruthEquipmentAbilityList")]
  public class TruthEquipmentAbilityList : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D5AC")]
    private const int PIN_OUT_ABILITY_DETAIL_OPEN = 100;
    [Token(Token = "0x400D5AD")]
    [FieldOffset(Offset = "0xC")]
    [SerializeField]
    private TruthEquipmentAbilityListItem m_ListItemTemplate;
    [Token(Token = "0x400D5AE")]
    [FieldOffset(Offset = "0x10")]
    private List<ViewTruthEquipmentLearnAbility> m_LearnAbility;
    [Token(Token = "0x400D5AF")]
    [FieldOffset(Offset = "0x14")]
    private List<TruthEquipmentAbilityListItem> m_ListItems;
    [Token(Token = "0x400D5B0")]
    [FieldOffset(Offset = "0x18")]
    private UnitData m_TargetUnit;

    [Token(Token = "0x600C7E3")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C7E4")]
    [Address(RVA = "0x90CEE0", Offset = "0x90BCE0", VA = "0x1090CEE0")]
    private void OnAbilityDetailClicked(ViewTruthEquipmentLearnAbility ability)
    {
    }

    [Token(Token = "0x600C7E5")]
    [Address(RVA = "0x90D410", Offset = "0x90C210", VA = "0x1090D410")]
    private void Start()
    {
    }

    [Token(Token = "0x600C7E6")]
    [Address(RVA = "0x90D070", Offset = "0x90BE70", VA = "0x1090D070")]
    public void Setup(UnitData unit, TruthEquipmentParam param, int lv)
    {
    }

    [Token(Token = "0x600C7E7")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public TruthEquipmentAbilityList()
    {
    }
  }
}

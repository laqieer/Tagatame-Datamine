// Decompiled with JetBrains decompiler
// Type: SRPG.UnitAbilityPicker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002BB2")]
  [AddComponentMenu("UI/UnitAbilityPicker")]
  [FlowNode.Pin(100, "アビリティが選択された", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(0, "リスト更新", FlowNode.PinTypes.Input, 0)]
  public class UnitAbilityPicker : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D691")]
    [FieldOffset(Offset = "0xC")]
    public UnitData UnitData;
    [Token(Token = "0x400D692")]
    [FieldOffset(Offset = "0x10")]
    [NonSerialized]
    public int AbilitySlot;
    [Token(Token = "0x400D693")]
    [FieldOffset(Offset = "0x14")]
    [StringIsGameObjectID]
    public string InventoryWindowID;
    [Token(Token = "0x400D694")]
    [FieldOffset(Offset = "0x18")]
    public UnitAbilityList ListBody;
    [Token(Token = "0x400D695")]
    [FieldOffset(Offset = "0x1C")]
    public Button ClearButton;
    [Token(Token = "0x400D696")]
    [FieldOffset(Offset = "0x20")]
    public bool AlwaysShowClearButton;
    [Token(Token = "0x400D697")]
    [FieldOffset(Offset = "0x24")]
    public GameObject NoAbilityMessage;
    [Token(Token = "0x400D698")]
    [FieldOffset(Offset = "0x28")]
    public Slider YajirushiSlider;
    [Token(Token = "0x400D699")]
    [FieldOffset(Offset = "0x2C")]
    public UnitAbilityPicker.AbilityPickerEvent OnAbilitySelect;
    [Token(Token = "0x400D69A")]
    [FieldOffset(Offset = "0x30")]
    public UnitAbilityPicker.AbilityPickerEvent OnAbilityRankUp;

    [Token(Token = "0x600C8DA")]
    [Address(RVA = "0x91A360", Offset = "0x919160", VA = "0x1091A360", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C8DB")]
    [Address(RVA = "0x91A9C0", Offset = "0x9197C0", VA = "0x1091A9C0")]
    private void Start()
    {
    }

    [Token(Token = "0x600C8DC")]
    [Address(RVA = "0x91A380", Offset = "0x919180", VA = "0x1091A380")]
    private void OnClearSlot()
    {
    }

    [Token(Token = "0x600C8DD")]
    [Address(RVA = "0x91AA80", Offset = "0x919880", VA = "0x1091AA80")]
    private void _OnAbilitySelect(AbilityData ability, GameObject itemGO)
    {
    }

    [Token(Token = "0x600C8DE")]
    [Address(RVA = "0x91A0C0", Offset = "0x918EC0", VA = "0x1091A0C0")]
    private void _OnAbilityRankUp(AbilityData ability, GameObject itemGO)
    {
    }

    [Token(Token = "0x600C8DF")]
    [Address(RVA = "0x91A550", Offset = "0x919350", VA = "0x1091A550")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600C8E0")]
    [Address(RVA = "0x91A340", Offset = "0x919140", VA = "0x1091A340")]
    public UnitAbilityPicker()
    {
    }

    [Token(Token = "0x2002BB3")]
    public delegate void AbilityPickerEvent(AbilityData ability, GameObject itemGO);
  }
}

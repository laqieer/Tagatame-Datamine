// Decompiled with JetBrains decompiler
// Type: SRPG.UnitAbilityPickerEx
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
  [Token(Token = "0x2002BB4")]
  [AddComponentMenu("UI/UnitAbilityPickerEx")]
  [FlowNode.Pin(100, "アビリティが選択された", FlowNode.PinTypes.Output, 100)]
  [FlowNode.Pin(0, "リスト更新", FlowNode.PinTypes.Input, 0)]
  public class UnitAbilityPickerEx : MonoBehaviour, IFlowInterface
  {
    [Token(Token = "0x400D69B")]
    private const int PIN_IN_REFRESH = 0;
    [Token(Token = "0x400D69C")]
    private const int PIN_OUT_SELECT_ABILITY = 100;
    [Token(Token = "0x400D69D")]
    [FieldOffset(Offset = "0xC")]
    public UnitData UnitData;
    [Token(Token = "0x400D69E")]
    [FieldOffset(Offset = "0x10")]
    [NonSerialized]
    public int AbilitySlot;
    [Token(Token = "0x400D69F")]
    [FieldOffset(Offset = "0x14")]
    [StringIsGameObjectID]
    public string InventoryWindowID;
    [Token(Token = "0x400D6A0")]
    [FieldOffset(Offset = "0x18")]
    public UnitAbilityListEx ListBody;
    [Token(Token = "0x400D6A1")]
    [FieldOffset(Offset = "0x1C")]
    public Button ClearButton;
    [Token(Token = "0x400D6A2")]
    [FieldOffset(Offset = "0x20")]
    public bool AlwaysShowClearButton;
    [Token(Token = "0x400D6A3")]
    [FieldOffset(Offset = "0x24")]
    public GameObject NoAbilityMessage;
    [Token(Token = "0x400D6A4")]
    [FieldOffset(Offset = "0x28")]
    public Slider YajirushiSlider;
    [Token(Token = "0x400D6A5")]
    [FieldOffset(Offset = "0x2C")]
    public UnitAbilityPickerEx.AbilityPickerEvent OnAbilitySelect;
    [Token(Token = "0x400D6A6")]
    [FieldOffset(Offset = "0x30")]
    public UnitAbilityPickerEx.AbilityPickerEvent OnAbilityRankUp;

    [Token(Token = "0x600C8E5")]
    [Address(RVA = "0x919990", Offset = "0x918790", VA = "0x10919990", Slot = "4")]
    public void Activated(int pinID)
    {
    }

    [Token(Token = "0x600C8E6")]
    [Address(RVA = "0x91A000", Offset = "0x918E00", VA = "0x1091A000")]
    private void Start()
    {
    }

    [Token(Token = "0x600C8E7")]
    [Address(RVA = "0x9199B0", Offset = "0x9187B0", VA = "0x109199B0")]
    private void OnClearSlot()
    {
    }

    [Token(Token = "0x600C8E8")]
    [Address(RVA = "0x91A0F0", Offset = "0x918EF0", VA = "0x1091A0F0")]
    private void _OnAbilitySelect(AbilityData ability, GameObject itemGO)
    {
    }

    [Token(Token = "0x600C8E9")]
    [Address(RVA = "0x91A0C0", Offset = "0x918EC0", VA = "0x1091A0C0")]
    private void _OnAbilityRankUp(AbilityData ability, GameObject itemGO)
    {
    }

    [Token(Token = "0x600C8EA")]
    [Address(RVA = "0x919B70", Offset = "0x918970", VA = "0x10919B70")]
    public void Refresh()
    {
    }

    [Token(Token = "0x600C8EB")]
    [Address(RVA = "0x91A340", Offset = "0x919140", VA = "0x1091A340")]
    public UnitAbilityPickerEx()
    {
    }

    [Token(Token = "0x2002BB5")]
    public delegate void AbilityPickerEvent(AbilityData ability, GameObject itemGO);
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.SRPG_ToggleButtonObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001161")]
  public class SRPG_ToggleButtonObject : Toggle
  {
    [Token(Token = "0x4003EE5")]
    [FieldOffset(Offset = "0xC4")]
    [CustomEnum(typeof (SystemSound.ECue), -1)]
    public int ClickSound;
    [Token(Token = "0x4003EE6")]
    [FieldOffset(Offset = "0xC8")]
    [BitMask]
    public CriticalSections CSMask;
    [Token(Token = "0x4003EE7")]
    [FieldOffset(Offset = "0xCC")]
    [SerializeField]
    private GameObject m_EnableIfON;
    [Token(Token = "0x4003EE8")]
    [FieldOffset(Offset = "0xD0")]
    [SerializeField]
    private GameObject m_EnableIfOFF;

    [Token(Token = "0x6004A04")]
    [Address(RVA = "0x1205D80", Offset = "0x1204B80", VA = "0x11205D80", Slot = "4")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x6004A05")]
    [Address(RVA = "0x1206070", Offset = "0x1204E70", VA = "0x11206070")]
    private void OnValueChanged(bool isOn)
    {
    }

    [Token(Token = "0x6004A06")]
    [Address(RVA = "0x12060E0", Offset = "0x1204EE0", VA = "0x112060E0")]
    private void PlaySound()
    {
    }

    [Token(Token = "0x6004A07")]
    [Address(RVA = "0x1205E10", Offset = "0x1204C10", VA = "0x11205E10")]
    private bool IsCriticalSectionActive() => new bool();

    [Token(Token = "0x6004A08")]
    [Address(RVA = "0x1205E60", Offset = "0x1204C60", VA = "0x11205E60", Slot = "49")]
    public override void OnPointerClick(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6004A09")]
    [Address(RVA = "0x1205F70", Offset = "0x1204D70", VA = "0x11205F70", Slot = "50")]
    public override void OnSubmit(BaseEventData eventData)
    {
    }

    [Token(Token = "0x6004A0A")]
    [Address(RVA = "0x8C67C0", Offset = "0x8C55C0", VA = "0x108C67C0", Slot = "51")]
    public virtual void UpdateButtonState()
    {
    }

    [Token(Token = "0x6004A0B")]
    [Address(RVA = "0x1206180", Offset = "0x1204F80", VA = "0x11206180")]
    public void SetValueSilent(bool isOn)
    {
    }

    [Token(Token = "0x6004A0C")]
    [Address(RVA = "0x1206120", Offset = "0x1204F20", VA = "0x11206120")]
    public void SetIsOnSilent()
    {
    }

    [Token(Token = "0x6004A0D")]
    [Address(RVA = "0x12061E0", Offset = "0x1204FE0", VA = "0x112061E0")]
    public SRPG_ToggleButtonObject()
    {
    }
  }
}

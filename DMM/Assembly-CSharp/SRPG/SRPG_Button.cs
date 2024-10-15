// Decompiled with JetBrains decompiler
// Type: SRPG.SRPG_Button
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
  [Token(Token = "0x2002AF4")]
  [AddComponentMenu("UI/Button (SRPG)")]
  public class SRPG_Button : Button
  {
    [Token(Token = "0x400D19C")]
    [FieldOffset(Offset = "0xB4")]
    private SRPG_Button.ButtonClickEvent mOnClick;
    [Token(Token = "0x400D19D")]
    [FieldOffset(Offset = "0xB8")]
    [CustomEnum(typeof (SystemSound.ECue), -1)]
    public int ClickSound;
    [Token(Token = "0x400D19E")]
    [FieldOffset(Offset = "0xBC")]
    [BitMask]
    public CriticalSections CSMask;

    [Token(Token = "0x600C45E")]
    [Address(RVA = "0x8C6360", Offset = "0x8C5160", VA = "0x108C6360")]
    public void AddListener(SRPG_Button.ButtonClickEvent listener)
    {
    }

    [Token(Token = "0x600C45F")]
    [Address(RVA = "0x8C6710", Offset = "0x8C5510", VA = "0x108C6710")]
    public void RemoveListener(SRPG_Button.ButtonClickEvent listener)
    {
    }

    [Token(Token = "0x600C460")]
    [Address(RVA = "0x8C66D0", Offset = "0x8C54D0", VA = "0x108C66D0")]
    protected void PlaySound()
    {
    }

    [Token(Token = "0x600C461")]
    [Address(RVA = "0x8C63F0", Offset = "0x8C51F0", VA = "0x108C63F0")]
    protected bool IsCriticalSectionActive() => new bool();

    [Token(Token = "0x600C462")]
    [Address(RVA = "0x8C6440", Offset = "0x8C5240", VA = "0x108C6440", Slot = "41")]
    public override void OnPointerClick(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600C463")]
    [Address(RVA = "0x8C6590", Offset = "0x8C5390", VA = "0x108C6590", Slot = "42")]
    public override void OnSubmit(BaseEventData eventData)
    {
    }

    [Token(Token = "0x600C464")]
    [Address(RVA = "0x8C67C0", Offset = "0x8C55C0", VA = "0x108C67C0", Slot = "43")]
    public virtual void UpdateButtonState()
    {
    }

    [Token(Token = "0x600C465")]
    [Address(RVA = "0x8C67A0", Offset = "0x8C55A0", VA = "0x108C67A0")]
    public void SetNormalStateTransition()
    {
    }

    [Token(Token = "0x600C466")]
    [Address(RVA = "0x8C6830", Offset = "0x8C5630", VA = "0x108C6830")]
    public SRPG_Button()
    {
    }

    [Token(Token = "0x2002AF5")]
    public delegate void ButtonClickEvent(SRPG_Button go);
  }
}

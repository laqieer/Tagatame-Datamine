// Decompiled with JetBrains decompiler
// Type: AnimatedToggle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x200028B")]
[RequireComponent(typeof (Animator))]
public class AnimatedToggle : Toggle
{
  [Token(Token = "0x4000AAA")]
  [FieldOffset(Offset = "0xC4")]
  public string BoolName;
  [Token(Token = "0x4000AAB")]
  [FieldOffset(Offset = "0xC8")]
  public string DisabledBool;
  [Token(Token = "0x4000AAC")]
  [FieldOffset(Offset = "0xCC")]
  private Animator mAnimator;
  [Token(Token = "0x4000AAD")]
  [FieldOffset(Offset = "0xD0")]
  public AnimatedToggle.ClickEvent OnClick;
  [Token(Token = "0x4000AAE")]
  [FieldOffset(Offset = "0xD4")]
  [CustomEnum(typeof (SystemSound.ECue), -1)]
  public int ClickSound;
  [Token(Token = "0x4000AAF")]
  [FieldOffset(Offset = "0xD8")]
  [BitMask]
  public CriticalSections CSMask;

  [Token(Token = "0x6000D8F")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "26")]
  protected override void DoStateTransition(Selectable.SelectionState state, bool instant)
  {
  }

  [Token(Token = "0x6000D90")]
  [Address(RVA = "0x11CB5C0", Offset = "0x11CA3C0", VA = "0x111CB5C0", Slot = "4")]
  protected override void Awake()
  {
  }

  [Token(Token = "0x6000D91")]
  [Address(RVA = "0x11CB660", Offset = "0x11CA460", VA = "0x111CB660", Slot = "5")]
  protected override void OnEnable()
  {
  }

  [Token(Token = "0x6000D92")]
  [Address(RVA = "0x11CB7D0", Offset = "0x11CA5D0", VA = "0x111CB7D0")]
  private void Update()
  {
  }

  [Token(Token = "0x6000D93")]
  [Address(RVA = "0x11CB6E0", Offset = "0x11CA4E0", VA = "0x111CB6E0", Slot = "49")]
  public override void OnPointerClick(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000D94")]
  [Address(RVA = "0x11CB790", Offset = "0x11CA590", VA = "0x111CB790")]
  private void PlaySound()
  {
  }

  [Token(Token = "0x6000D95")]
  [Address(RVA = "0x11CB610", Offset = "0x11CA410", VA = "0x111CB610")]
  private bool IsCriticalSectionActive() => new bool();

  [Token(Token = "0x6000D96")]
  [Address(RVA = "0x11CB840", Offset = "0x11CA640", VA = "0x111CB840")]
  public AnimatedToggle()
  {
  }

  [Token(Token = "0x200028C")]
  public delegate void ClickEvent(AnimatedToggle toggle);
}

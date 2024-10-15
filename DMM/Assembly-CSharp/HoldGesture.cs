// Decompiled with JetBrains decompiler
// Type: HoldGesture
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

#nullable disable
[Token(Token = "0x20000FD")]
[AddComponentMenu("Event/Hold Gesture")]
public class HoldGesture : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IHoldGesture
{
  [Token(Token = "0x40004C1")]
  [FieldOffset(Offset = "0xC")]
  public UnityEvent OnHoldStart;
  [Token(Token = "0x40004C2")]
  [FieldOffset(Offset = "0x10")]
  public UnityEvent OnHoldEnd;

  [Token(Token = "0x6000694")]
  [Address(RVA = "0xD58B30", Offset = "0xD57930", VA = "0x10D58B30", Slot = "5")]
  public void OnPointerHoldStart()
  {
  }

  [Token(Token = "0x6000695")]
  [Address(RVA = "0x638900", Offset = "0x637700", VA = "0x10638900", Slot = "6")]
  public void OnPointerHoldEnd()
  {
  }

  [Token(Token = "0x6000696")]
  [Address(RVA = "0xD58650", Offset = "0xD57450", VA = "0x10D58650", Slot = "4")]
  public void OnPointerDown(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000697")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public HoldGesture()
  {
  }
}

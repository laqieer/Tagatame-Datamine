// Decompiled with JetBrains decompiler
// Type: NonInteractableMessage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20002C2")]
[RequireComponent(typeof (Selectable))]
[AddComponentMenu("UI/NonInteractableMessage")]
public class NonInteractableMessage : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
{
  [Token(Token = "0x4000B72")]
  [FieldOffset(Offset = "0xC")]
  public string Caption;
  [Token(Token = "0x4000B73")]
  [FieldOffset(Offset = "0x10")]
  public string Message;

  [Token(Token = "0x6000E73")]
  [Address(RVA = "0x11D5C20", Offset = "0x11D4A20", VA = "0x111D5C20", Slot = "4")]
  public void OnPointerClick(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000E74")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public NonInteractableMessage()
  {
  }
}

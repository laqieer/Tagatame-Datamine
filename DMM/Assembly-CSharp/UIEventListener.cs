// Decompiled with JetBrains decompiler
// Type: UIEventListener
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
[Token(Token = "0x20002EA")]
[AddComponentMenu("UI/UIEventListener")]
public class UIEventListener : 
  MonoBehaviour,
  IPointerEnterHandler,
  IEventSystemHandler,
  IPointerExitHandler,
  IPointerDownHandler,
  IPointerUpHandler,
  IPointerClickHandler,
  IDragHandler,
  IBeginDragHandler,
  IEndDragHandler,
  IDropHandler,
  IScrollHandler,
  IUpdateSelectedHandler,
  ISelectHandler,
  IDeselectHandler,
  IMoveHandler
{
  [Token(Token = "0x4000C22")]
  [FieldOffset(Offset = "0xC")]
  public UIEventListener.PointerEvent onPointerEnter;
  [Token(Token = "0x4000C23")]
  [FieldOffset(Offset = "0x10")]
  public UIEventListener.PointerEvent onPointerExit;
  [Token(Token = "0x4000C24")]
  [FieldOffset(Offset = "0x14")]
  public UIEventListener.PointerEvent onPointerDown;
  [Token(Token = "0x4000C25")]
  [FieldOffset(Offset = "0x18")]
  public UIEventListener.PointerEvent onPointerUp;
  [Token(Token = "0x4000C26")]
  [FieldOffset(Offset = "0x1C")]
  public UIEventListener.PointerEvent onPointerClick;
  [Token(Token = "0x4000C27")]
  [FieldOffset(Offset = "0x20")]
  public UIEventListener.PointerEvent onDrag;
  [Token(Token = "0x4000C28")]
  [FieldOffset(Offset = "0x24")]
  public UIEventListener.PointerEvent onBeginDrag;
  [Token(Token = "0x4000C29")]
  [FieldOffset(Offset = "0x28")]
  public UIEventListener.PointerEvent onEndDrag;
  [Token(Token = "0x4000C2A")]
  [FieldOffset(Offset = "0x2C")]
  public UIEventListener.PointerEvent onDrop;
  [Token(Token = "0x4000C2B")]
  [FieldOffset(Offset = "0x30")]
  public UIEventListener.PointerEvent onScroll;
  [Token(Token = "0x4000C2C")]
  [FieldOffset(Offset = "0x34")]
  public UIEventListener.BaseEvent onSelect;
  [Token(Token = "0x4000C2D")]
  [FieldOffset(Offset = "0x38")]
  public UIEventListener.BaseEvent onDeselect;
  [Token(Token = "0x4000C2E")]
  [FieldOffset(Offset = "0x3C")]
  public UIEventListener.BaseEvent onUpdateSelected;
  [Token(Token = "0x4000C2F")]
  [FieldOffset(Offset = "0x40")]
  public UIEventListener.AxisEvent onMove;

  [Token(Token = "0x6000F13")]
  [Address(RVA = "0x12A7290", Offset = "0x12A6090", VA = "0x112A7290")]
  public static UIEventListener Get(GameObject go) => (UIEventListener) null;

  [Token(Token = "0x6000F14")]
  [Address(RVA = "0x12A7330", Offset = "0x12A6130", VA = "0x112A7330")]
  public static UIEventListener Get(Component go) => (UIEventListener) null;

  [Token(Token = "0x6000F15")]
  [Address(RVA = "0x10232A0", Offset = "0x10220A0", VA = "0x110232A0", Slot = "4")]
  public void OnPointerEnter(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000F16")]
  [Address(RVA = "0x614860", Offset = "0x613660", VA = "0x10614860", Slot = "5")]
  public void OnPointerExit(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000F17")]
  [Address(RVA = "0x12A74C0", Offset = "0x12A62C0", VA = "0x112A74C0", Slot = "6")]
  public void OnPointerDown(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000F18")]
  [Address(RVA = "0x12A74E0", Offset = "0x12A62E0", VA = "0x112A74E0", Slot = "7")]
  public void OnPointerUp(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000F19")]
  [Address(RVA = "0x12A74A0", Offset = "0x12A62A0", VA = "0x112A74A0", Slot = "8")]
  public void OnPointerClick(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000F1A")]
  [Address(RVA = "0x12A73E0", Offset = "0x12A61E0", VA = "0x112A73E0", Slot = "10")]
  public void OnBeginDrag(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000F1B")]
  [Address(RVA = "0x12A7460", Offset = "0x12A6260", VA = "0x112A7460", Slot = "11")]
  public void OnEndDrag(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000F1C")]
  [Address(RVA = "0x12A7420", Offset = "0x12A6220", VA = "0x112A7420", Slot = "9")]
  public void OnDrag(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000F1D")]
  [Address(RVA = "0x12A7440", Offset = "0x12A6240", VA = "0x112A7440", Slot = "12")]
  public void OnDrop(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000F1E")]
  [Address(RVA = "0x12A7500", Offset = "0x12A6300", VA = "0x112A7500", Slot = "13")]
  public void OnScroll(PointerEventData eventData)
  {
  }

  [Token(Token = "0x6000F1F")]
  [Address(RVA = "0x12A7540", Offset = "0x12A6340", VA = "0x112A7540", Slot = "14")]
  public void OnUpdateSelected(BaseEventData eventData)
  {
  }

  [Token(Token = "0x6000F20")]
  [Address(RVA = "0x12A7520", Offset = "0x12A6320", VA = "0x112A7520", Slot = "15")]
  public void OnSelect(BaseEventData eventData)
  {
  }

  [Token(Token = "0x6000F21")]
  [Address(RVA = "0x12A7400", Offset = "0x12A6200", VA = "0x112A7400", Slot = "16")]
  public void OnDeselect(BaseEventData eventData)
  {
  }

  [Token(Token = "0x6000F22")]
  [Address(RVA = "0x12A7480", Offset = "0x12A6280", VA = "0x112A7480", Slot = "17")]
  public void OnMove(AxisEventData eventData)
  {
  }

  [Token(Token = "0x6000F23")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public UIEventListener()
  {
  }

  [Token(Token = "0x20002EB")]
  public delegate void PointerEvent(PointerEventData eventData);

  [Token(Token = "0x20002EC")]
  public delegate void BaseEvent(BaseEventData eventData);

  [Token(Token = "0x20002ED")]
  public delegate void AxisEvent(AxisEventData eventData);
}

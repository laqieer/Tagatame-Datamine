// Decompiled with JetBrains decompiler
// Type: DragEventListener
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
[Token(Token = "0x20000D3")]
[AddComponentMenu("Common/DragEventListener")]
public class DragEventListener : 
  MonoBehaviour,
  IDragHandler,
  IEventSystemHandler,
  IBeginDragHandler,
  IEndDragHandler
{
  [Token(Token = "0x40003B9")]
  [FieldOffset(Offset = "0xC")]
  public DragEventListener.BeginDragDelegate BeginDrag;
  [Token(Token = "0x40003BA")]
  [FieldOffset(Offset = "0x10")]
  public DragEventListener.BeginDragDelegate Drag;
  [Token(Token = "0x40003BB")]
  [FieldOffset(Offset = "0x14")]
  public DragEventListener.BeginDragDelegate EndDrag;

  [Token(Token = "0x6000519")]
  [Address(RVA = "0xC6EC90", Offset = "0xC6DA90", VA = "0x10C6EC90", Slot = "5")]
  public void OnBeginDrag(PointerEventData eventData)
  {
  }

  [Token(Token = "0x600051A")]
  [Address(RVA = "0xC6ECC0", Offset = "0xC6DAC0", VA = "0x10C6ECC0", Slot = "4")]
  public void OnDrag(PointerEventData eventData)
  {
  }

  [Token(Token = "0x600051B")]
  [Address(RVA = "0xC6ECF0", Offset = "0xC6DAF0", VA = "0x10C6ECF0", Slot = "6")]
  public void OnEndDrag(PointerEventData eventData)
  {
  }

  [Token(Token = "0x600051C")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public DragEventListener()
  {
  }

  [Token(Token = "0x20000D4")]
  public delegate void BeginDragDelegate(GameObject sender, PointerEventData eventData);

  [Token(Token = "0x20000D5")]
  public delegate void DragDelegate(GameObject sender, PointerEventData eventData);

  [Token(Token = "0x20000D6")]
  public delegate void EndDragDelegate(GameObject sender, PointerEventData eventData);
}

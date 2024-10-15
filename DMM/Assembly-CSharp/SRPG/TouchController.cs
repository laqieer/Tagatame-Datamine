// Decompiled with JetBrains decompiler
// Type: SRPG.TouchController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002B35")]
  [AddComponentMenu("Event/TouchController")]
  public class TouchController : 
    MonoBehaviour,
    IPointerDownHandler,
    IEventSystemHandler,
    IPointerUpHandler,
    IDragHandler
  {
    [Token(Token = "0x400D2F5")]
    [FieldOffset(Offset = "0xC")]
    public float DragStartThreshold;
    [Token(Token = "0x400D2F6")]
    [FieldOffset(Offset = "0x10")]
    public TouchController.ClickEvent OnClick;
    [Token(Token = "0x400D2F7")]
    [FieldOffset(Offset = "0x14")]
    public TouchController.DragEvent OnDragDelegate;
    [Token(Token = "0x400D2F8")]
    [FieldOffset(Offset = "0x18")]
    public TouchController.DragEvent OnDragEndDelegate;
    [Token(Token = "0x400D2F9")]
    [FieldOffset(Offset = "0x1C")]
    [NonSerialized]
    public Vector2 Velocity;
    [Token(Token = "0x400D2FA")]
    [FieldOffset(Offset = "0x24")]
    [NonSerialized]
    public Vector2 AngularVelocity;
    [Token(Token = "0x400D2FB")]
    [FieldOffset(Offset = "0x2C")]
    private Vector2 mClickPos;
    [Token(Token = "0x400D2FC")]
    [FieldOffset(Offset = "0x34")]
    private bool mMultiTouched;
    [Token(Token = "0x400D2FD")]
    [FieldOffset(Offset = "0x35")]
    private bool mIsTouching;
    [Token(Token = "0x400D2FE")]
    [FieldOffset(Offset = "0x38")]
    private float mPointerDownTime;
    [Token(Token = "0x400D2FF")]
    [FieldOffset(Offset = "0x3C")]
    [NonSerialized]
    public Vector2 DragDelta;
    [Token(Token = "0x400D300")]
    [FieldOffset(Offset = "0x44")]
    private float mClickRadiusThreshold;
    [Token(Token = "0x400D301")]
    [FieldOffset(Offset = "0x48")]
    private RectTransform mRectTransform;
    [Token(Token = "0x400D302")]
    [FieldOffset(Offset = "0x4C")]
    private Vector2 mDragStart;

    [Token(Token = "0x600C5BB")]
    [Address(RVA = "0x288000", Offset = "0x286E00", VA = "0x10288000")]
    public RectTransform GetRectTransform() => (RectTransform) null;

    [Token(Token = "0x17001A3C")]
    public bool IsTouching
    {
      [Token(Token = "0x600C5BC"), Address(RVA = "0x8E4B70", Offset = "0x8E3970", VA = "0x108E4B70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001A3D")]
    public Vector2 DragStart
    {
      [Token(Token = "0x600C5BD"), Address(RVA = "0x8E4B40", Offset = "0x8E3940", VA = "0x108E4B40")] get
      {
        return new Vector2();
      }
    }

    [Token(Token = "0x17001A3E")]
    public Vector2 WorldSpaceVelocity
    {
      [Token(Token = "0x600C5BE"), Address(RVA = "0x8E4B80", Offset = "0x8E3980", VA = "0x108E4B80")] get
      {
        return new Vector2();
      }
    }

    [Token(Token = "0x600C5BF")]
    [Address(RVA = "0x8E45A0", Offset = "0x8E33A0", VA = "0x108E45A0")]
    public void IgnoreCurrentTouch()
    {
    }

    [Token(Token = "0x600C5C0")]
    [Address(RVA = "0x8E4550", Offset = "0x8E3350", VA = "0x108E4550")]
    private void Awake()
    {
    }

    [Token(Token = "0x600C5C1")]
    [Address(RVA = "0x8E4A90", Offset = "0x8E3890", VA = "0x108E4A90")]
    private void Start()
    {
    }

    [Token(Token = "0x600C5C2")]
    [Address(RVA = "0x8E4AD0", Offset = "0x8E38D0", VA = "0x108E4AD0")]
    private void Update()
    {
    }

    [Token(Token = "0x600C5C3")]
    [Address(RVA = "0x8E47A0", Offset = "0x8E35A0", VA = "0x108E47A0", Slot = "4")]
    public void OnPointerDown(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600C5C4")]
    [Address(RVA = "0x8E4910", Offset = "0x8E3710", VA = "0x108E4910", Slot = "5")]
    public void OnPointerUp(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600C5C5")]
    [Address(RVA = "0x8E4620", Offset = "0x8E3420", VA = "0x108E4620", Slot = "6")]
    public void OnDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600C5C6")]
    [Address(RVA = "0x8E4B10", Offset = "0x8E3910", VA = "0x108E4B10")]
    public TouchController()
    {
    }

    [Token(Token = "0x2002B36")]
    public delegate void ClickEvent(Vector2 screenPos);

    [Token(Token = "0x2002B37")]
    public delegate void DragEvent();
  }
}

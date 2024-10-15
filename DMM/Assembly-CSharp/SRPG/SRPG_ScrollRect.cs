// Decompiled with JetBrains decompiler
// Type: SRPG.SRPG_ScrollRect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AF9")]
  [AddComponentMenu("UI/ScrollRect (SRPG)")]
  public class SRPG_ScrollRect : ScrollRect
  {
    [Token(Token = "0x400D1AB")]
    [FieldOffset(Offset = "0xF0")]
    private float DEFAULT_REST_ADD_TIME;
    [Token(Token = "0x400D1AC")]
    [FieldOffset(Offset = "0xF4")]
    private float DEFAULT_SCROLL_DECELERATION_RATE;
    [Token(Token = "0x400D1AD")]
    [FieldOffset(Offset = "0xF8")]
    private float WHEEL_SCROLL_DECELERATION_RATE;
    [Token(Token = "0x400D1AE")]
    [FieldOffset(Offset = "0xFC")]
    private float SCROLL_FIXED_VALUE;
    [Token(Token = "0x400D1AF")]
    [FieldOffset(Offset = "0x100")]
    private float SCROLL_VALUE_COEF;
    [Token(Token = "0x400D1B0")]
    [FieldOffset(Offset = "0x104")]
    private bool IS_ENABLE_WHEEL_SCROLL_FOR_HORIZENTAL;
    [Token(Token = "0x400D1B1")]
    [FieldOffset(Offset = "0x108")]
    private PointerEventData pointer_event;
    [Token(Token = "0x400D1B2")]
    [FieldOffset(Offset = "0x10C")]
    private List<GameObject> child_objects;
    [Token(Token = "0x400D1B3")]
    [FieldOffset(Offset = "0x110")]
    private List<RaycastResult> raycast_result_list;
    [Token(Token = "0x400D1B4")]
    [FieldOffset(Offset = "0x114")]
    private ScrollRect.MovementType defalt_movement_type;
    [Token(Token = "0x400D1B5")]
    [FieldOffset(Offset = "0x118")]
    private float axis_val;
    [Token(Token = "0x400D1B6")]
    [FieldOffset(Offset = "0x11C")]
    private float rest_add_time;
    [Token(Token = "0x400D1B7")]
    [FieldOffset(Offset = "0x120")]
    private bool is_scroll_now;
    [Token(Token = "0x400D1B8")]
    [FieldOffset(Offset = "0x121")]
    private bool is_wheel_scroll;

    [Token(Token = "0x600C49C")]
    [Address(RVA = "0x8D10A0", Offset = "0x8CFEA0", VA = "0x108D10A0", Slot = "4")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x17001A29")]
    public bool IsScrollNow
    {
      [Token(Token = "0x600C49D"), Address(RVA = "0x8D1980", Offset = "0x8D0780", VA = "0x108D1980")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001A2A")]
    private bool IsWheelScroll
    {
      [Token(Token = "0x600C49E"), Address(RVA = "0x8D1990", Offset = "0x8D0790", VA = "0x108D1990")] get
      {
        return new bool();
      }
      [Token(Token = "0x600C49F"), Address(RVA = "0x8D19A0", Offset = "0x8D07A0", VA = "0x108D19A0")] set
      {
      }
    }

    [Token(Token = "0x17001A2B")]
    public bool IsWheelScrollNow
    {
      [Token(Token = "0x600C4A0"), Address(RVA = "0x8D1990", Offset = "0x8D0790", VA = "0x108D1990")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600C4A1")]
    [Address(RVA = "0x8D1480", Offset = "0x8D0280", VA = "0x108D1480", Slot = "48")]
    protected override void LateUpdate()
    {
    }

    [Token(Token = "0x600C4A2")]
    [Address(RVA = "0x8D1730", Offset = "0x8D0530", VA = "0x108D1730")]
    private void UpdateDecelerationRate()
    {
    }

    [Token(Token = "0x600C4A3")]
    [Address(RVA = "0x8D1840", Offset = "0x8D0640", VA = "0x108D1840")]
    private void UpdateWheelScrollFlag()
    {
    }

    [Token(Token = "0x600C4A4")]
    [Address(RVA = "0x8D1760", Offset = "0x8D0560", VA = "0x108D1760")]
    private void UpdateScroll()
    {
    }

    [Token(Token = "0x600C4A5")]
    [Address(RVA = "0x8D1670", Offset = "0x8D0470", VA = "0x108D1670")]
    private void SetGlideValue(float _axis_value, bool _is_begin)
    {
    }

    [Token(Token = "0x600C4A6")]
    [Address(RVA = "0x8D1130", Offset = "0x8CFF30", VA = "0x108D1130")]
    private bool IsHitRayCast() => new bool();

    [Token(Token = "0x600C4A7")]
    [Address(RVA = "0x8D15C0", Offset = "0x8D03C0", VA = "0x108D15C0", Slot = "44")]
    public override void OnBeginDrag(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600C4A8")]
    [Address(RVA = "0x8D1600", Offset = "0x8D0400", VA = "0x108D1600")]
    public void ResetHorizontalPosition()
    {
    }

    [Token(Token = "0x600C4A9")]
    [Address(RVA = "0x8D1630", Offset = "0x8D0430", VA = "0x108D1630")]
    public void ResetVerticalPosition(bool reverse = false)
    {
    }

    [Token(Token = "0x600C4AA")]
    [Address(RVA = "0x8D1890", Offset = "0x8D0690", VA = "0x108D1890")]
    public SRPG_ScrollRect()
    {
    }
  }
}

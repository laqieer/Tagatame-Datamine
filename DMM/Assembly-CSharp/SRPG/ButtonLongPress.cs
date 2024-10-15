// Decompiled with JetBrains decompiler
// Type: SRPG.ButtonLongPress
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x20021B4")]
  [AddComponentMenu("UI/Button (SRPG LongPress)")]
  public class ButtonLongPress : SRPG_Button
  {
    [Token(Token = "0x400939C")]
    [FieldOffset(Offset = "0xC0")]
    [SerializeField]
    private float NORMAL_PRESS_TIME;
    [Token(Token = "0x400939D")]
    [FieldOffset(Offset = "0xC4")]
    [SerializeField]
    private float FAST_PRESS_TIME;
    [Token(Token = "0x400939E")]
    [FieldOffset(Offset = "0xC8")]
    [SerializeField]
    private int FAST_COUNT;
    [Token(Token = "0x400939F")]
    [FieldOffset(Offset = "0xCC")]
    public UnityEvent onLongPress;
    [Token(Token = "0x40093A0")]
    [FieldOffset(Offset = "0xD0")]
    private float pressingSeconds;
    [Token(Token = "0x40093A1")]
    [FieldOffset(Offset = "0xD4")]
    private int pressingCount;
    [Token(Token = "0x40093A2")]
    [FieldOffset(Offset = "0xD8")]
    private bool isPressing;

    [Token(Token = "0x6008DEC")]
    [Address(RVA = "0x50C7E0", Offset = "0x50B5E0", VA = "0x1050C7E0")]
    private void Update()
    {
    }

    [Token(Token = "0x6008DED")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "41")]
    public override void OnPointerClick(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6008DEE")]
    [Address(RVA = "0x50C6D0", Offset = "0x50B4D0", VA = "0x1050C6D0", Slot = "32")]
    public override void OnPointerDown(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6008DEF")]
    [Address(RVA = "0x50C7A0", Offset = "0x50B5A0", VA = "0x1050C7A0", Slot = "33")]
    public override void OnPointerUp(PointerEventData eventData)
    {
    }

    [Token(Token = "0x6008DF0")]
    [Address(RVA = "0x50C8A0", Offset = "0x50B6A0", VA = "0x1050C8A0")]
    public ButtonLongPress()
    {
    }
  }
}

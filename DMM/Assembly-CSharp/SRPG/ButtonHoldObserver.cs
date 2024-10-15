// Decompiled with JetBrains decompiler
// Type: SRPG.ButtonHoldObserver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200206C")]
  public class ButtonHoldObserver : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
  {
    [Token(Token = "0x4008B82")]
    [FieldOffset(Offset = "0xC")]
    private float[] HoldSpan;
    [Token(Token = "0x4008B83")]
    [FieldOffset(Offset = "0x10")]
    private float HoldDuration;
    [Token(Token = "0x4008B84")]
    [FieldOffset(Offset = "0x14")]
    private bool Holding;
    [Token(Token = "0x4008B85")]
    [FieldOffset(Offset = "0x18")]
    private int ActionCount;
    [Token(Token = "0x4008B86")]
    [FieldOffset(Offset = "0x1C")]
    private Vector2 mDragStartPos;
    [Token(Token = "0x4008B87")]
    [FieldOffset(Offset = "0x24")]
    public ButtonHoldObserver.DelegateOnHoldEvent OnHoldStart;
    [Token(Token = "0x4008B88")]
    [FieldOffset(Offset = "0x28")]
    public ButtonHoldObserver.DelegateOnHoldEvent OnHoldEnd;
    [Token(Token = "0x4008B89")]
    [FieldOffset(Offset = "0x2C")]
    public ButtonHoldObserver.DelegateOnHoldEvent OnHoldUpdate;

    [Token(Token = "0x60086C7")]
    [Address(RVA = "0x489C00", Offset = "0x488A00", VA = "0x10489C00", Slot = "4")]
    public void OnPointerDown(PointerEventData eventData)
    {
    }

    [Token(Token = "0x60086C8")]
    [Address(RVA = "0x489C50", Offset = "0x488A50", VA = "0x10489C50")]
    public void OnPointerUp()
    {
    }

    [Token(Token = "0x60086C9")]
    [Address(RVA = "0x489C90", Offset = "0x488A90", VA = "0x10489C90")]
    public void StatusReset()
    {
    }

    [Token(Token = "0x60086CA")]
    [Address(RVA = "0x489CC0", Offset = "0x488AC0", VA = "0x10489CC0")]
    public void Update()
    {
    }

    [Token(Token = "0x60086CB")]
    [Address(RVA = "0x489BA0", Offset = "0x4889A0", VA = "0x10489BA0")]
    public void OnDestroy()
    {
    }

    [Token(Token = "0x60086CC")]
    [Address(RVA = "0x489E70", Offset = "0x488C70", VA = "0x10489E70")]
    public ButtonHoldObserver()
    {
    }

    [Token(Token = "0x200206D")]
    public delegate void DelegateOnHoldEvent();
  }
}

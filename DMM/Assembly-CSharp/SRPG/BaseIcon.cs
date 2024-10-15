// Decompiled with JetBrains decompiler
// Type: SRPG.BaseIcon
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200207F")]
  [AddComponentMenu("UI/BaseIcon")]
  public class BaseIcon : 
    MonoBehaviour,
    IGameParameter,
    IPointerDownHandler,
    IEventSystemHandler,
    IHoldGesture
  {
    [Token(Token = "0x17001326")]
    public virtual bool HasTooltip
    {
      [Token(Token = "0x600873A"), Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0", Slot = "8")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600873B")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "9")]
    protected virtual void ShowTooltip(Vector2 screen)
    {
    }

    [Token(Token = "0x600873C")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "10")]
    protected virtual void ShowTooltipByTap(Vector2 _screen)
    {
    }

    [Token(Token = "0x600873D")]
    [Address(RVA = "0x448BE0", Offset = "0x4479E0", VA = "0x10448BE0", Slot = "11")]
    public virtual void OnPointerDown(PointerEventData eventData)
    {
    }

    [Token(Token = "0x600873E")]
    [Address(RVA = "0x488140", Offset = "0x486F40", VA = "0x10488140", Slot = "6")]
    public void OnPointerHoldStart()
    {
    }

    [Token(Token = "0x600873F")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "7")]
    public void OnPointerHoldEnd()
    {
    }

    [Token(Token = "0x6008740")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "12")]
    public virtual void UpdateValue()
    {
    }

    [Token(Token = "0x6008741")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public BaseIcon()
    {
    }
  }
}

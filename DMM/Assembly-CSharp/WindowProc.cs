// Decompiled with JetBrains decompiler
// Type: WindowProc
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using AOT;
using GR;
using Il2CppDummyDll;
using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.Events;

#nullable disable
[Token(Token = "0x200018A")]
[AddComponentMenu("Common/WindowProc")]
public class WindowProc : MonoSingleton<WindowProc>
{
  [Token(Token = "0x4000779")]
  public const int WM_CLOSE = 16;
  [Token(Token = "0x400077A")]
  public const int WM_MOVE = 3;
  [Token(Token = "0x400077B")]
  public const int WM_SIZE = 5;
  [Token(Token = "0x400077C")]
  public const int WM_SIZING = 532;
  [Token(Token = "0x400077D")]
  public const int WM_ENTERSIZEMOVE = 561;
  [Token(Token = "0x400077E")]
  public const int WM_EXITSIZEMOVE = 562;
  [Token(Token = "0x400077F")]
  [Il2CppDummyDll.FieldOffset(Offset = "0xC")]
  private HandleRef hMainWindow;
  [Token(Token = "0x4000780")]
  [Il2CppDummyDll.FieldOffset(Offset = "0x14")]
  private IntPtr oldWndProcPtr;
  [Token(Token = "0x4000781")]
  [Il2CppDummyDll.FieldOffset(Offset = "0x18")]
  private IntPtr newWndProcPtr;
  [Token(Token = "0x4000782")]
  [Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
  private WindowsAPI.WndProcDelegate newWndProc;
  [Token(Token = "0x4000783")]
  [Il2CppDummyDll.FieldOffset(Offset = "0x20")]
  private WindowProc.WM_CloseEvent onWM_Close;
  [Token(Token = "0x4000784")]
  [Il2CppDummyDll.FieldOffset(Offset = "0x24")]
  private WindowProc.WM_MoveEvent onWM_Move;
  [Token(Token = "0x4000785")]
  [Il2CppDummyDll.FieldOffset(Offset = "0x28")]
  private WindowProc.WM_SizeEvent onWM_Size;
  [Token(Token = "0x4000786")]
  [Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
  private WindowProc.WM_SizingEvent onWM_Sizing;
  [Token(Token = "0x4000787")]
  [Il2CppDummyDll.FieldOffset(Offset = "0x30")]
  private WindowProc.WM_EnterSizeMoveEvent onWM_EnterSizeMove;
  [Token(Token = "0x4000788")]
  [Il2CppDummyDll.FieldOffset(Offset = "0x34")]
  private WindowProc.WM_ExitSizeMoveEvent onWM_ExitSizeMove;

  [Token(Token = "0x60009B6")]
  [Address(RVA = "0xF55900", Offset = "0xF54700", VA = "0x10F55900")]
  private void _RegisterWindowProc()
  {
  }

  [Token(Token = "0x60009B7")]
  [Address(RVA = "0xF55B70", Offset = "0xF54970", VA = "0x10F55B70")]
  private void _ReleaseWindowProc()
  {
  }

  [Token(Token = "0x60009B8")]
  [Address(RVA = "0xF55580", Offset = "0xF54380", VA = "0x10F55580", Slot = "4")]
  protected override void Initialize()
  {
  }

  [Token(Token = "0x60009B9")]
  [Address(RVA = "0xF55600", Offset = "0xF54400", VA = "0x10F55600", Slot = "5")]
  protected override void Release()
  {
  }

  [Token(Token = "0x60009BA")]
  [Address(RVA = "0xF55EB0", Offset = "0xF54CB0", VA = "0x10F55EB0")]
  [MonoPInvokeCallback(typeof (WindowProc.wndProcCallback))]
  private static IntPtr wndProc(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam)
  {
    return new IntPtr();
  }

  [Token(Token = "0x60009BB")]
  [Address(RVA = "0xF555F0", Offset = "0xF543F0", VA = "0x10F555F0")]
  protected short LoWord(long input) => new short();

  [Token(Token = "0x60009BC")]
  [Address(RVA = "0xF55570", Offset = "0xF54370", VA = "0x10F55570")]
  protected short HiWord(long input) => new short();

  [Token(Token = "0x60009BD")]
  [Address(RVA = "0xF55390", Offset = "0xF54190", VA = "0x10F55390")]
  public void AddWM_CloseListener(
    UnityAction<WindowProc.WM_CloseEvent.Param> callback)
  {
  }

  [Token(Token = "0x60009BE")]
  [Address(RVA = "0xF55720", Offset = "0xF54520", VA = "0x10F55720")]
  public void RemoveWM_CloseListener(
    UnityAction<WindowProc.WM_CloseEvent.Param> callback)
  {
  }

  [Token(Token = "0x60009BF")]
  [Address(RVA = "0xF55480", Offset = "0xF54280", VA = "0x10F55480")]
  public void AddWM_MoveListener(
    UnityAction<WindowProc.WM_MoveEvent.Param> callback)
  {
  }

  [Token(Token = "0x60009C0")]
  [Address(RVA = "0xF55810", Offset = "0xF54610", VA = "0x10F55810")]
  public void RemoveWM_MoveListener(
    UnityAction<WindowProc.WM_MoveEvent.Param> callback)
  {
  }

  [Token(Token = "0x60009C1")]
  [Address(RVA = "0xF554D0", Offset = "0xF542D0", VA = "0x10F554D0")]
  public void AddWM_SizeListener(
    UnityAction<WindowProc.WM_SizeEvent.Param> callback)
  {
  }

  [Token(Token = "0x60009C2")]
  [Address(RVA = "0xF55860", Offset = "0xF54660", VA = "0x10F55860")]
  public void RemoveWM_SizeListener(
    UnityAction<WindowProc.WM_SizeEvent.Param> callback)
  {
  }

  [Token(Token = "0x60009C3")]
  [Address(RVA = "0xF55520", Offset = "0xF54320", VA = "0x10F55520")]
  public void AddWM_SizingListener(
    UnityAction<WindowProc.WM_SizingEvent.Param> callback)
  {
  }

  [Token(Token = "0x60009C4")]
  [Address(RVA = "0xF558B0", Offset = "0xF546B0", VA = "0x10F558B0")]
  public void RemoveWM_SizingListener(
    UnityAction<WindowProc.WM_SizingEvent.Param> callback)
  {
  }

  [Token(Token = "0x60009C5")]
  [Address(RVA = "0xF553E0", Offset = "0xF541E0", VA = "0x10F553E0")]
  public void AddWM_EnterSizeMoveListener(
    UnityAction<WindowProc.WM_EnterSizeMoveEvent.Param> callback)
  {
  }

  [Token(Token = "0x60009C6")]
  [Address(RVA = "0xF55770", Offset = "0xF54570", VA = "0x10F55770")]
  public void RemoveWM_EnterSizeMoveListener(
    UnityAction<WindowProc.WM_EnterSizeMoveEvent.Param> callback)
  {
  }

  [Token(Token = "0x60009C7")]
  [Address(RVA = "0xF55430", Offset = "0xF54230", VA = "0x10F55430")]
  public void AddWM_ExitSizeMoveListener(
    UnityAction<WindowProc.WM_ExitSizeMoveEvent.Param> callback)
  {
  }

  [Token(Token = "0x60009C8")]
  [Address(RVA = "0xF557C0", Offset = "0xF545C0", VA = "0x10F557C0")]
  public void RemoveWM_ExitSizeMoveListener(
    UnityAction<WindowProc.WM_ExitSizeMoveEvent.Param> callback)
  {
  }

  [Token(Token = "0x60009C9")]
  [Address(RVA = "0xF55C60", Offset = "0xF54A60", VA = "0x10F55C60")]
  public WindowProc()
  {
  }

  [Token(Token = "0x200018B")]
  public abstract class WindowEventParamBase
  {
    [Token(Token = "0x4000789")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x8")]
    public IntPtr hWnd;
    [Token(Token = "0x400078A")]
    [Il2CppDummyDll.FieldOffset(Offset = "0xC")]
    public bool skipProc;

    [Token(Token = "0x60009CA")]
    [Address(RVA = "0x28EFD0", Offset = "0x28DDD0", VA = "0x1028EFD0")]
    public WindowEventParamBase(IntPtr hWnd)
    {
    }

    [Token(Token = "0x60009CB")]
    [Address(RVA = "0x2E2F20", Offset = "0x2E1D20", VA = "0x102E2F20")]
    public void EnableSkipProc()
    {
    }

    [Token(Token = "0x60009CC")]
    [Address(RVA = "0x50A240", Offset = "0x509040", VA = "0x1050A240")]
    public void DisableSkipProc()
    {
    }
  }

  [Token(Token = "0x200018C")]
  public class WM_CloseEvent : UnityEvent<WindowProc.WM_CloseEvent.Param>
  {
    [Token(Token = "0x60009CD")]
    [Address(RVA = "0xF55210", Offset = "0xF54010", VA = "0x10F55210")]
    public WM_CloseEvent()
    {
    }

    [Token(Token = "0x200018D")]
    public class Param : WindowProc.WindowEventParamBase
    {
      [Token(Token = "0x60009CE")]
      [Address(RVA = "0x28EFD0", Offset = "0x28DDD0", VA = "0x1028EFD0")]
      public Param(IntPtr hWnd)
      {
      }
    }
  }

  [Token(Token = "0x200018E")]
  public class WM_MoveEvent : UnityEvent<WindowProc.WM_MoveEvent.Param>
  {
    [Token(Token = "0x60009CF")]
    [Address(RVA = "0xF552D0", Offset = "0xF540D0", VA = "0x10F552D0")]
    public WM_MoveEvent()
    {
    }

    [Token(Token = "0x200018F")]
    public class Param : WindowProc.WindowEventParamBase
    {
      [Token(Token = "0x400078B")]
      [Il2CppDummyDll.FieldOffset(Offset = "0x10")]
      public Vector2 pos;

      [Token(Token = "0x60009D0")]
      [Address(RVA = "0x28EFD0", Offset = "0x28DDD0", VA = "0x1028EFD0")]
      public Param(IntPtr hWnd)
      {
      }
    }
  }

  [Token(Token = "0x2000190")]
  public class WM_SizeEvent : UnityEvent<WindowProc.WM_SizeEvent.Param>
  {
    [Token(Token = "0x60009D1")]
    [Address(RVA = "0xF55310", Offset = "0xF54110", VA = "0x10F55310")]
    public WM_SizeEvent()
    {
    }

    [Token(Token = "0x2000191")]
    public enum EventType
    {
      [Token(Token = "0x400078D")] Restored,
      [Token(Token = "0x400078E")] Minimized,
      [Token(Token = "0x400078F")] Maximized,
      [Token(Token = "0x4000790")] Maxshow,
      [Token(Token = "0x4000791")] Maxhide,
    }

    [Token(Token = "0x2000192")]
    public class Param : WindowProc.WindowEventParamBase
    {
      [Token(Token = "0x4000792")]
      [Il2CppDummyDll.FieldOffset(Offset = "0x10")]
      public WindowProc.WM_SizeEvent.EventType eventType;
      [Token(Token = "0x4000793")]
      [Il2CppDummyDll.FieldOffset(Offset = "0x14")]
      public Vector2 size;

      [Token(Token = "0x60009D2")]
      [Address(RVA = "0x28EFD0", Offset = "0x28DDD0", VA = "0x1028EFD0")]
      public Param(IntPtr hWnd)
      {
      }
    }
  }

  [Token(Token = "0x2000193")]
  public class WM_SizingEvent : UnityEvent<WindowProc.WM_SizingEvent.Param>
  {
    [Token(Token = "0x60009D3")]
    [Address(RVA = "0xF55350", Offset = "0xF54150", VA = "0x10F55350")]
    public WM_SizingEvent()
    {
    }

    [Token(Token = "0x2000194")]
    public enum EventType
    {
      [Token(Token = "0x4000795")] Left = 1,
      [Token(Token = "0x4000796")] Right = 2,
      [Token(Token = "0x4000797")] Top = 3,
      [Token(Token = "0x4000798")] TopLeft = 4,
      [Token(Token = "0x4000799")] TopRight = 5,
      [Token(Token = "0x400079A")] Bottom = 6,
      [Token(Token = "0x400079B")] BottomLeft = 7,
      [Token(Token = "0x400079C")] BottomRight = 8,
    }

    [Token(Token = "0x2000195")]
    public class Param : WindowProc.WindowEventParamBase
    {
      [Token(Token = "0x400079D")]
      [Il2CppDummyDll.FieldOffset(Offset = "0x10")]
      public WindowProc.WM_SizingEvent.EventType eventType;
      [Token(Token = "0x400079E")]
      [Il2CppDummyDll.FieldOffset(Offset = "0x14")]
      public Rect rect;

      [Token(Token = "0x60009D4")]
      [Address(RVA = "0x28EFD0", Offset = "0x28DDD0", VA = "0x1028EFD0")]
      public Param(IntPtr hWnd)
      {
      }
    }
  }

  [Token(Token = "0x2000196")]
  public class WM_EnterSizeMoveEvent : UnityEvent<WindowProc.WM_EnterSizeMoveEvent.Param>
  {
    [Token(Token = "0x60009D5")]
    [Address(RVA = "0xF55250", Offset = "0xF54050", VA = "0x10F55250")]
    public WM_EnterSizeMoveEvent()
    {
    }

    [Token(Token = "0x2000197")]
    public class Param : WindowProc.WindowEventParamBase
    {
      [Token(Token = "0x60009D6")]
      [Address(RVA = "0x28EFD0", Offset = "0x28DDD0", VA = "0x1028EFD0")]
      public Param(IntPtr hWnd)
      {
      }
    }
  }

  [Token(Token = "0x2000198")]
  public class WM_ExitSizeMoveEvent : UnityEvent<WindowProc.WM_ExitSizeMoveEvent.Param>
  {
    [Token(Token = "0x60009D7")]
    [Address(RVA = "0xF55290", Offset = "0xF54090", VA = "0x10F55290")]
    public WM_ExitSizeMoveEvent()
    {
    }

    [Token(Token = "0x2000199")]
    public class Param : WindowProc.WindowEventParamBase
    {
      [Token(Token = "0x60009D8")]
      [Address(RVA = "0x28EFD0", Offset = "0x28DDD0", VA = "0x1028EFD0")]
      public Param(IntPtr hWnd)
      {
      }
    }
  }

  [Token(Token = "0x200019A")]
  private delegate IntPtr wndProcCallback(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);
}

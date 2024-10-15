// Decompiled with JetBrains decompiler
// Type: WindowsAPI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
[Token(Token = "0x200019B")]
public class WindowsAPI
{
  [Token(Token = "0x400079F")]
  [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
  public static readonly int MONITOR_DEFAULTTONULL;
  [Token(Token = "0x40007A0")]
  [Il2CppDummyDll.FieldOffset(Offset = "0x4")]
  public static readonly int MONITOR_DEFAULTTOPRIMARY;
  [Token(Token = "0x40007A1")]
  [Il2CppDummyDll.FieldOffset(Offset = "0x8")]
  public static readonly int MONITOR_DEFAULTTONEAREST;

  [Token(Token = "0x60009DD")]
  [Address(RVA = "0xF56810", Offset = "0xF55610", VA = "0x10F56810")]
  [MethodImpl(MethodImplOptions.PreserveSig)]
  public static extern IntPtr FindWindow(string className, string windowName);

  [Token(Token = "0x60009DE")]
  [Address(RVA = "0xF57250", Offset = "0xF56050", VA = "0x10F57250")]
  [MethodImpl(MethodImplOptions.PreserveSig)]
  public static extern int SetWindowLong32(HandleRef hWnd, int nIndex, int dwNewLong);

  [Token(Token = "0x60009DF")]
  [Address(RVA = "0xF572B0", Offset = "0xF560B0", VA = "0x10F572B0")]
  [MethodImpl(MethodImplOptions.PreserveSig)]
  public static extern IntPtr SetWindowLongPtr64(HandleRef hWnd, int nIndex, IntPtr dwNewLong);

  [Token(Token = "0x60009E0")]
  [Address(RVA = "0xF567A0", Offset = "0xF555A0", VA = "0x10F567A0")]
  [MethodImpl(MethodImplOptions.PreserveSig)]
  public static extern IntPtr DefWindowProc(IntPtr hWnd, uint wMsg, IntPtr wParam, IntPtr lParam);

  [Token(Token = "0x60009E1")]
  [Address(RVA = "0xF56730", Offset = "0xF55530", VA = "0x10F56730")]
  [MethodImpl(MethodImplOptions.PreserveSig)]
  public static extern IntPtr CallWindowProc(
    IntPtr lpPrevWndFunc,
    IntPtr hWnd,
    uint wMsg,
    IntPtr wParam,
    IntPtr lParam);

  [Token(Token = "0x60009E2")]
  [Address(RVA = "0xF56F00", Offset = "0xF55D00", VA = "0x10F56F00")]
  [MethodImpl(MethodImplOptions.PreserveSig)]
  private static extern int GetWindowRect(IntPtr hWnd, out WindowsAPI.RECT rect);

  [Token(Token = "0x60009E3")]
  [Address(RVA = "0xF569A0", Offset = "0xF557A0", VA = "0x10F569A0")]
  [MethodImpl(MethodImplOptions.PreserveSig)]
  private static extern bool GetClientRect(IntPtr hWnd, out WindowsAPI.RECT rect);

  [Token(Token = "0x60009E4")]
  [Address(RVA = "0xF570D0", Offset = "0xF55ED0", VA = "0x10F570D0")]
  [MethodImpl(MethodImplOptions.PreserveSig)]
  private static extern int MoveWindow(
    IntPtr hWnd,
    int x,
    int y,
    int nWidth,
    int nHeight,
    int bRepaint);

  [Token(Token = "0x60009E5")]
  [Address(RVA = "0xF57070", Offset = "0xF55E70", VA = "0x10F57070")]
  [MethodImpl(MethodImplOptions.PreserveSig)]
  public static extern IntPtr MonitorFromWindow(IntPtr hwnd, IntPtr dwFlags);

  [Token(Token = "0x60009E6")]
  [Address(RVA = "0xF56A10", Offset = "0xF55810", VA = "0x10F56A10")]
  [MethodImpl(MethodImplOptions.PreserveSig)]
  public static extern bool GetMonitorInfo(
    IntPtr hMonitor,
    ref WindowsAPI.MONITORINFOEX moniterInfoEX);

  [Token(Token = "0x60009E7")]
  [Address(RVA = "0xF57140", Offset = "0xF55F40", VA = "0x10F57140")]
  public static int MoveWindow(IntPtr hWnd, Rect rect, bool repaint) => new int();

  [Token(Token = "0x60009E8")]
  [Address(RVA = "0xF56B60", Offset = "0xF55960", VA = "0x10F56B60")]
  public static WindowsAPI.MonitorInfoEx GetMonitorInfo(IntPtr hWnd)
  {
    return (WindowsAPI.MonitorInfoEx) null;
  }

  [Token(Token = "0x60009E9")]
  [Address(RVA = "0xF56F60", Offset = "0xF55D60", VA = "0x10F56F60")]
  public static Rect GetWindowRect(IntPtr hWnd) => new Rect();

  [Token(Token = "0x60009EA")]
  [Address(RVA = "0xF56890", Offset = "0xF55690", VA = "0x10F56890")]
  public static Rect GetClientRect(IntPtr hWnd) => new Rect();

  [Token(Token = "0x60009EB")]
  [Address(RVA = "0xF57310", Offset = "0xF56110", VA = "0x10F57310")]
  public static IntPtr SetWindowLongPtr(HandleRef hWnd, int nIndex, IntPtr dwNewLong)
  {
    return new IntPtr();
  }

  [Token(Token = "0x60009EC")]
  [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
  public WindowsAPI()
  {
  }

  [Token(Token = "0x60009ED")]
  [Address(RVA = "0xF57450", Offset = "0xF56250", VA = "0x10F57450")]
  static WindowsAPI()
  {
  }

  [Token(Token = "0x200019C")]
  public delegate IntPtr WndProcDelegate(IntPtr hWnd, uint msg, IntPtr wParam, IntPtr lParam);

  [Token(Token = "0x200019D")]
  public struct RECT
  {
    [Token(Token = "0x40007A2")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
    public int left;
    [Token(Token = "0x40007A3")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x4")]
    public int top;
    [Token(Token = "0x40007A4")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x8")]
    public int right;
    [Token(Token = "0x40007A5")]
    [Il2CppDummyDll.FieldOffset(Offset = "0xC")]
    public int bottom;
  }

  [Token(Token = "0x200019E")]
  [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
  public struct MONITORINFOEX
  {
    [Token(Token = "0x40007A6")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x0")]
    public int cbSize;
    [Token(Token = "0x40007A7")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x4")]
    public WindowsAPI.RECT rcMonitor;
    [Token(Token = "0x40007A8")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x14")]
    public WindowsAPI.RECT rcWork;
    [Token(Token = "0x40007A9")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x24")]
    public uint dwFlags;
    [Token(Token = "0x40007AA")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x28")]
    public string szDevice;
  }

  [Token(Token = "0x200019F")]
  public class MonitorInfoEx
  {
    [Token(Token = "0x40007AB")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x8")]
    public Rect monitorRect;
    [Token(Token = "0x40007AC")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x18")]
    public Rect workAreaRect;
    [Token(Token = "0x40007AD")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x28")]
    public int flag;
    [Token(Token = "0x40007AE")]
    [Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
    public string Device;

    [Token(Token = "0x60009F2")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public MonitorInfoEx()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.ScreenSizeManager
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200110A")]
  [AddComponentMenu("Common/ScreenSizeManager")]
  public class ScreenSizeManager : MonoBehaviour
  {
    [Token(Token = "0x4003D8E")]
    [FieldOffset(Offset = "0xC")]
    private IntPtr window_handle;
    [Token(Token = "0x4003D8F")]
    [FieldOffset(Offset = "0x10")]
    private ScreenSizeManager.MYRECT window_rect;
    [Token(Token = "0x4003D90")]
    [FieldOffset(Offset = "0x20")]
    private ScreenSizeManager.MYRECT client_rect;
    [Token(Token = "0x4003D91")]
    [FieldOffset(Offset = "0x30")]
    private int current_client_width;
    [Token(Token = "0x4003D92")]
    [FieldOffset(Offset = "0x34")]
    private int current_client_height;
    [Token(Token = "0x4003D93")]
    [FieldOffset(Offset = "0x38")]
    private int next_client_width;
    [Token(Token = "0x4003D94")]
    [FieldOffset(Offset = "0x3C")]
    private int next_client_height;
    [Token(Token = "0x4003D95")]
    [FieldOffset(Offset = "0x40")]
    private int frame_width;
    [Token(Token = "0x4003D96")]
    [FieldOffset(Offset = "0x44")]
    private int frame_height;

    [Token(Token = "0x6004849")]
    [Address(RVA = "0x11F3D20", Offset = "0x11F2B20", VA = "0x111F3D20")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    private static extern IntPtr FindWindow(string className, string windowName);

    [Token(Token = "0x600484A")]
    [Address(RVA = "0x11F3E70", Offset = "0x11F2C70", VA = "0x111F3E70")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    private static extern bool IsZoomed(IntPtr hWnd);

    [Token(Token = "0x600484B")]
    [Address(RVA = "0x11F4040", Offset = "0x11F2E40", VA = "0x111F4040")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    private static extern int MoveWindow(
      IntPtr hWnd,
      int x,
      int y,
      int nWidth,
      int nHeight,
      int bRepaint);

    [Token(Token = "0x600484C")]
    [Address(RVA = "0x11F3E10", Offset = "0x11F2C10", VA = "0x111F3E10")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    private static extern int GetWindowRect(IntPtr hWnd, out ScreenSizeManager.MYRECT rect);

    [Token(Token = "0x600484D")]
    [Address(RVA = "0x11F3DA0", Offset = "0x11F2BA0", VA = "0x111F3DA0")]
    [MethodImpl(MethodImplOptions.PreserveSig)]
    private static extern bool GetClientRect(IntPtr hWnd, out ScreenSizeManager.MYRECT rect);

    [Token(Token = "0x600484E")]
    [Address(RVA = "0x11F3910", Offset = "0x11F2710", VA = "0x111F3910")]
    private void Awake()
    {
    }

    [Token(Token = "0x600484F")]
    [Address(RVA = "0x11F3ED0", Offset = "0x11F2CD0", VA = "0x111F3ED0")]
    private void LateUpdate()
    {
    }

    [Token(Token = "0x6004850")]
    [Address(RVA = "0x11F3BC0", Offset = "0x11F29C0", VA = "0x111F3BC0")]
    private void EditWindowsSizeW(int _new_window_width, bool _size_check = true)
    {
    }

    [Token(Token = "0x6004851")]
    [Address(RVA = "0x11F3A60", Offset = "0x11F2860", VA = "0x111F3A60")]
    private void EditWindowSizeH(int _new_window_height, bool _size_check = true)
    {
    }

    [Token(Token = "0x6004852")]
    [Address(RVA = "0x11F40B0", Offset = "0x11F2EB0", VA = "0x111F40B0")]
    private void Resize(int _width, int _height)
    {
    }

    [Token(Token = "0x6004853")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ScreenSizeManager()
    {
    }

    [Token(Token = "0x200110B")]
    private struct MYRECT
    {
      [Token(Token = "0x4003D97")]
      [FieldOffset(Offset = "0x0")]
      public int left;
      [Token(Token = "0x4003D98")]
      [FieldOffset(Offset = "0x4")]
      public int top;
      [Token(Token = "0x4003D99")]
      [FieldOffset(Offset = "0x8")]
      public int right;
      [Token(Token = "0x4003D9A")]
      [FieldOffset(Offset = "0xC")]
      public int bottom;
    }
  }
}

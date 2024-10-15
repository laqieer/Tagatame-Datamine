// Decompiled with JetBrains decompiler
// Type: ApplicationEventHandler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000041")]
[AddComponentMenu("Common/ApplicationEventHandler")]
public class ApplicationEventHandler : MonoBehaviour
{
  [Token(Token = "0x400013F")]
  [FieldOffset(Offset = "0xC")]
  private bool m_IsQuiting;
  [Token(Token = "0x4000140")]
  [FieldOffset(Offset = "0x10")]
  private EmbedWindowYesNo m_QuitWindow;
  [Token(Token = "0x4000141")]
  [FieldOffset(Offset = "0x14")]
  private Rect m_WindowRect;
  [Token(Token = "0x4000142")]
  [FieldOffset(Offset = "0x24")]
  private Vector2 m_FrameSize;
  [Token(Token = "0x4000143")]
  [FieldOffset(Offset = "0x2C")]
  private Rect m_PrimaryWindowRect;
  [Token(Token = "0x4000144")]
  [FieldOffset(Offset = "0x3C")]
  private EnumBitArray<ApplicationEventHandler.State> m_EventFlag;

  [Token(Token = "0x6000183")]
  [Address(RVA = "0x2CFAA0", Offset = "0x2CE8A0", VA = "0x102CFAA0")]
  public void OpenQuitWindow()
  {
  }

  [Token(Token = "0x6000184")]
  [Address(RVA = "0x2CE8D0", Offset = "0x2CD6D0", VA = "0x102CE8D0")]
  public void OnApplicationQuitWindowResult(bool yes)
  {
  }

  [Token(Token = "0x6000185")]
  [Address(RVA = "0x2CE910", Offset = "0x2CD710", VA = "0x102CE910")]
  private void OnCancel()
  {
  }

  [Token(Token = "0x6000186")]
  [Address(RVA = "0x2CE940", Offset = "0x2CD740", VA = "0x102CE940")]
  private void OnDecide()
  {
  }

  [Token(Token = "0x6000187")]
  [Address(RVA = "0x2CE1F0", Offset = "0x2CCFF0", VA = "0x102CE1F0")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000188")]
  [Address(RVA = "0x2CE510", Offset = "0x2CD310", VA = "0x102CE510")]
  private void InitializeWindowSize(IntPtr hWnd)
  {
  }

  [Token(Token = "0x6000189")]
  [Address(RVA = "0x2CFB90", Offset = "0x2CE990", VA = "0x102CFB90")]
  private Rect ToScreenRect(Rect value) => new Rect();

  [Token(Token = "0x600018A")]
  [Address(RVA = "0x2CFBF0", Offset = "0x2CE9F0", VA = "0x102CFBF0")]
  private Rect ToWindowRect(Rect value) => new Rect();

  [Token(Token = "0x600018B")]
  [Address(RVA = "0x2CE970", Offset = "0x2CD770", VA = "0x102CE970")]
  private void OnWM_Close(WindowProc.WM_CloseEvent.Param param)
  {
  }

  [Token(Token = "0x600018C")]
  [Address(RVA = "0x2CEA70", Offset = "0x2CD870", VA = "0x102CEA70")]
  public void OnWM_Move(WindowProc.WM_MoveEvent.Param param)
  {
  }

  [Token(Token = "0x600018D")]
  [Address(RVA = "0x2CEAC0", Offset = "0x2CD8C0", VA = "0x102CEAC0")]
  public void OnWM_Size(WindowProc.WM_SizeEvent.Param param)
  {
  }

  [Token(Token = "0x600018E")]
  [Address(RVA = "0x2CF040", Offset = "0x2CDE40", VA = "0x102CF040")]
  public void OnWM_Sizing(WindowProc.WM_SizingEvent.Param param)
  {
  }

  [Token(Token = "0x600018F")]
  [Address(RVA = "0x2CFC50", Offset = "0x2CEA50", VA = "0x102CFC50")]
  public ApplicationEventHandler()
  {
  }

  [Token(Token = "0x2000042")]
  private enum State
  {
    [Token(Token = "0x4000146")] Resize,
    [Token(Token = "0x4000147")] SizeMove,
    [Token(Token = "0x4000148")] Sizing,
  }
}

// Decompiled with JetBrains decompiler
// Type: ScreenBlankSpaceFrame
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
[Token(Token = "0x20002CC")]
[AddComponentMenu("UI/ScreenBlankSpaceFrame")]
public class ScreenBlankSpaceFrame : UIBehaviour
{
  [Token(Token = "0x4000B98")]
  [FieldOffset(Offset = "0xC")]
  [SerializeField]
  private RectTransform m_ImageLeft;
  [Token(Token = "0x4000B99")]
  [FieldOffset(Offset = "0x10")]
  [SerializeField]
  private RectTransform m_ImageRight;
  [Token(Token = "0x4000B9A")]
  [FieldOffset(Offset = "0x14")]
  [SerializeField]
  private RectTransform m_ImageTop;
  [Token(Token = "0x4000B9B")]
  [FieldOffset(Offset = "0x18")]
  [SerializeField]
  private RectTransform m_ImageBottom;
  [Token(Token = "0x4000B9C")]
  [FieldOffset(Offset = "0x1C")]
  [SerializeField]
  private RectTransform m_CanvasBoundsPanel;
  [Token(Token = "0x4000B9D")]
  [FieldOffset(Offset = "0x20")]
  private Coroutine m_AdjustCoroutine;
  [Token(Token = "0x4000B9E")]
  [FieldOffset(Offset = "0x24")]
  private DrivenRectTransformTracker m_Tracker;

  [Token(Token = "0x6000E91")]
  [Address(RVA = "0x11D8310", Offset = "0x11D7110", VA = "0x111D8310", Slot = "6")]
  protected override void Start()
  {
  }

  [Token(Token = "0x6000E92")]
  [Address(RVA = "0x11D76E0", Offset = "0x11D64E0", VA = "0x111D76E0", Slot = "10")]
  protected override void OnRectTransformDimensionsChange()
  {
  }

  [Token(Token = "0x6000E93")]
  [Address(RVA = "0x11D76C0", Offset = "0x11D64C0", VA = "0x111D76C0", Slot = "7")]
  protected override void OnDisable()
  {
  }

  [Token(Token = "0x6000E94")]
  [Address(RVA = "0x11D75B0", Offset = "0x11D63B0", VA = "0x111D75B0")]
  private void AsyncAdjustRecttransformSize()
  {
  }

  [Token(Token = "0x6000E95")]
  [Address(RVA = "0x11D82A0", Offset = "0x11D70A0", VA = "0x111D82A0")]
  private IEnumerator StartAdjustSize() => (IEnumerator) null;

  [Token(Token = "0x6000E96")]
  [Address(RVA = "0x11D7EB0", Offset = "0x11D6CB0", VA = "0x111D7EB0")]
  private void SetScreenOutFrameSize()
  {
  }

  [Token(Token = "0x6000E97")]
  [Address(RVA = "0x11D77E0", Offset = "0x11D65E0", VA = "0x111D77E0")]
  private void SetRect(RectTransform rt, RectTransform.Edge edge)
  {
  }

  [Token(Token = "0x6000E98")]
  [Address(RVA = "0x11D76F0", Offset = "0x11D64F0", VA = "0x111D76F0")]
  private void SetAnchorAndPivot(RectTransform rt, RectTransform.Edge edge)
  {
  }

  [Token(Token = "0x6000E99")]
  [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
  public ScreenBlankSpaceFrame()
  {
  }
}

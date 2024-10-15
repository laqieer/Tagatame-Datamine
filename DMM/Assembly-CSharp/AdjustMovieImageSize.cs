// Decompiled with JetBrains decompiler
// Type: AdjustMovieImageSize
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
[Token(Token = "0x2000284")]
[AddComponentMenu("UI/AdjustMovieImageSize")]
public class AdjustMovieImageSize : UIBehaviour
{
  [Token(Token = "0x4000A93")]
  [FieldOffset(Offset = "0xC")]
  private RectTransform m_ParentTransform;
  [Token(Token = "0x4000A94")]
  [FieldOffset(Offset = "0x10")]
  private RectTransform m_Transform;
  [Token(Token = "0x4000A95")]
  [FieldOffset(Offset = "0x14")]
  private Coroutine m_AdjustCoroutine;

  [Token(Token = "0x6000D72")]
  [Address(RVA = "0x11CA490", Offset = "0x11C9290", VA = "0x111CA490", Slot = "4")]
  protected override void Awake()
  {
  }

  [Token(Token = "0x6000D73")]
  [Address(RVA = "0x11CA6B0", Offset = "0x11C94B0", VA = "0x111CA6B0", Slot = "6")]
  protected override void Start()
  {
  }

  [Token(Token = "0x6000D74")]
  [Address(RVA = "0x11CA630", Offset = "0x11C9430", VA = "0x111CA630", Slot = "10")]
  protected override void OnRectTransformDimensionsChange()
  {
  }

  [Token(Token = "0x6000D75")]
  [Address(RVA = "0x11CA3E0", Offset = "0x11C91E0", VA = "0x111CA3E0")]
  private void AsyncAdjustRecttransformSize()
  {
  }

  [Token(Token = "0x6000D76")]
  [Address(RVA = "0x11CA640", Offset = "0x11C9440", VA = "0x111CA640")]
  private IEnumerator StartAdjustSize() => (IEnumerator) null;

  [Token(Token = "0x6000D77")]
  [Address(RVA = "0x11CA560", Offset = "0x11C9360", VA = "0x111CA560")]
  private void InternalAdjustRecttransformSize(float canvasBoundsScale)
  {
  }

  [Token(Token = "0x6000D78")]
  [Address(RVA = "0x44BFA0", Offset = "0x44ADA0", VA = "0x1044BFA0")]
  public AdjustMovieImageSize()
  {
  }
}

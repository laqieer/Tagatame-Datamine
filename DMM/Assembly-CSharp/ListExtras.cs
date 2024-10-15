// Decompiled with JetBrains decompiler
// Type: ListExtras
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20002BB")]
[RequireComponent(typeof (ScrollRect))]
[DisallowMultipleComponent]
[AddComponentMenu("UI/ListExtras")]
public class ListExtras : MonoBehaviour
{
  [Token(Token = "0x4000B4F")]
  [FieldOffset(Offset = "0xC")]
  public Selectable PageUpButton;
  [Token(Token = "0x4000B50")]
  [FieldOffset(Offset = "0x10")]
  public Selectable PageDownButton;
  [Token(Token = "0x4000B51")]
  [FieldOffset(Offset = "0x14")]
  public float PageScrollTime;
  [Token(Token = "0x4000B52")]
  [FieldOffset(Offset = "0x18")]
  private Vector2 mScrollAnimStart;
  [Token(Token = "0x4000B53")]
  [FieldOffset(Offset = "0x20")]
  private Vector2 mScrollAnimEnd;
  [Token(Token = "0x4000B54")]
  [FieldOffset(Offset = "0x28")]
  private float mScrollAnimTime;
  [Token(Token = "0x4000B55")]
  [FieldOffset(Offset = "0x2C")]
  private ScrollRect mScrollRect;
  [Token(Token = "0x4000B56")]
  private const float ScrollTop = 0.001f;
  [Token(Token = "0x4000B57")]
  private const float ScrollEnd = 0.999f;

  [Token(Token = "0x6000E58")]
  [Address(RVA = "0x11D4500", Offset = "0x11D3300", VA = "0x111D4500")]
  protected void Awake()
  {
  }

  [Token(Token = "0x6000E59")]
  [Address(RVA = "0x11D48F0", Offset = "0x11D36F0", VA = "0x111D48F0")]
  protected void Update()
  {
  }

  [Token(Token = "0x170001B8")]
  private Vector2 ScrollDir
  {
    [Token(Token = "0x6000E5A"), Address(RVA = "0x11D4DD0", Offset = "0x11D3BD0", VA = "0x111D4DD0")] get
    {
      return new Vector2();
    }
  }

  [Token(Token = "0x6000E5B")]
  [Address(RVA = "0x11D45B0", Offset = "0x11D33B0", VA = "0x111D45B0")]
  public void PageUp(float delta)
  {
  }

  [Token(Token = "0x6000E5C")]
  [Address(RVA = "0x11D4590", Offset = "0x11D3390", VA = "0x111D4590")]
  public void PageDown(float delta)
  {
  }

  [Token(Token = "0x6000E5D")]
  [Address(RVA = "0x11D4870", Offset = "0x11D3670", VA = "0x111D4870")]
  public void SetScrollPos(float position)
  {
  }

  [Token(Token = "0x6000E5E")]
  [Address(RVA = "0x11D45E0", Offset = "0x11D33E0", VA = "0x111D45E0")]
  public void ScrollTo(float normalizedPosition)
  {
  }

  [Token(Token = "0x6000E5F")]
  [Address(RVA = "0x11D4660", Offset = "0x11D3460", VA = "0x111D4660")]
  private void Scroll(float delta)
  {
  }

  [Token(Token = "0x6000E60")]
  [Address(RVA = "0x11D4DA0", Offset = "0x11D3BA0", VA = "0x111D4DA0")]
  public ListExtras()
  {
  }
}

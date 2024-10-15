// Decompiled with JetBrains decompiler
// Type: AnimateBlockRaycasts
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000033")]
[AddComponentMenu("Common/AnimateBlockRaycasts")]
public class AnimateBlockRaycasts : MonoBehaviour
{
  [Token(Token = "0x40000F5")]
  [FieldOffset(Offset = "0xC")]
  private Animator mAnimator;
  [Token(Token = "0x40000F6")]
  [FieldOffset(Offset = "0x10")]
  private CanvasGroup mCanvasGroup;
  [Token(Token = "0x40000F7")]
  [FieldOffset(Offset = "0x14")]
  private int mBlockCount;
  [Token(Token = "0x40000F8")]
  [FieldOffset(Offset = "0x18")]
  public string[] BlockStates;

  [Token(Token = "0x600012B")]
  [Address(RVA = "0x2BC460", Offset = "0x2BB260", VA = "0x102BC460")]
  private void Start()
  {
  }

  [Token(Token = "0x600012C")]
  [Address(RVA = "0x2BC350", Offset = "0x2BB150", VA = "0x102BC350")]
  private void LateUpdate()
  {
  }

  [Token(Token = "0x600012D")]
  [Address(RVA = "0x2BC550", Offset = "0x2BB350", VA = "0x102BC550")]
  public AnimateBlockRaycasts()
  {
  }
}

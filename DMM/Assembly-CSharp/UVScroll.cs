// Decompiled with JetBrains decompiler
// Type: UVScroll
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000188")]
[RequireComponent(typeof (Renderer))]
[DisallowMultipleComponent]
[AddComponentMenu("Rendering/UVScroll")]
public class UVScroll : MonoBehaviour
{
  [Token(Token = "0x400076F")]
  [FieldOffset(Offset = "0xC")]
  public Vector2 Speed;
  [Token(Token = "0x4000770")]
  [FieldOffset(Offset = "0x14")]
  private Vector2 mOffset;
  [Token(Token = "0x4000771")]
  [FieldOffset(Offset = "0x1C")]
  public Vector2 Limit;

  [Token(Token = "0x60009AC")]
  [Address(RVA = "0xF53F50", Offset = "0xF52D50", VA = "0x10F53F50")]
  private void Update()
  {
  }

  [Token(Token = "0x60009AD")]
  [Address(RVA = "0xF540C0", Offset = "0xF52EC0", VA = "0x10F540C0")]
  public UVScroll()
  {
  }
}

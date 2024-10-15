// Decompiled with JetBrains decompiler
// Type: ColorBlendVolume
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x200009A")]
[AddComponentMenu("Common/ColorBlendVolume")]
[ExecuteInEditMode]
public class ColorBlendVolume : MonoBehaviour
{
  [Token(Token = "0x40002F6")]
  [FieldOffset(Offset = "0x0")]
  public static List<ColorBlendVolume> Volumes;
  [Token(Token = "0x40002F7")]
  [FieldOffset(Offset = "0xC")]
  public Color32 Color;
  [Token(Token = "0x40002F8")]
  [FieldOffset(Offset = "0x10")]
  public float Radius;
  [Token(Token = "0x40002F9")]
  [FieldOffset(Offset = "0x14")]
  [NonSerialized]
  public Bounds Bounds;
  [Token(Token = "0x40002FA")]
  [FieldOffset(Offset = "0x2C")]
  private Bounds mBoundsInner;

  [Token(Token = "0x60003C1")]
  [Address(RVA = "0xB835A0", Offset = "0xB823A0", VA = "0x10B835A0")]
  public void UpdateBounds()
  {
  }

  [Token(Token = "0x60003C2")]
  [Address(RVA = "0xB833D0", Offset = "0xB821D0", VA = "0x10B833D0")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x60003C3")]
  [Address(RVA = "0xB83360", Offset = "0xB82160", VA = "0x10B83360")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x60003C4")]
  [Address(RVA = "0xB83250", Offset = "0xB82050", VA = "0x10B83250")]
  public static ColorBlendVolume FindVolume(Vector3 point) => (ColorBlendVolume) null;

  [Token(Token = "0x60003C5")]
  [Address(RVA = "0xB82F70", Offset = "0xB81D70", VA = "0x10B82F70")]
  public Color32 CalcBlendColor32(Vector3 point) => new Color32();

  [Token(Token = "0x60003C6")]
  [Address(RVA = "0xB83790", Offset = "0xB82590", VA = "0x10B83790")]
  public ColorBlendVolume()
  {
  }

  [Token(Token = "0x60003C7")]
  [Address(RVA = "0xB83710", Offset = "0xB82510", VA = "0x10B83710")]
  static ColorBlendVolume()
  {
  }
}

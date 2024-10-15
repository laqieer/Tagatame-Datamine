// Decompiled with JetBrains decompiler
// Type: GiziScroll
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000F9")]
[AddComponentMenu("Common/GiziScroll")]
public class GiziScroll : MonoBehaviour
{
  [Token(Token = "0x40004B3")]
  [FieldOffset(Offset = "0xC")]
  public Vector2 MinAspectSize;
  [Token(Token = "0x40004B4")]
  [FieldOffset(Offset = "0x14")]
  public float MinScroll;
  [Token(Token = "0x40004B5")]
  [FieldOffset(Offset = "0x18")]
  public float MinOffset;
  [Token(Token = "0x40004B6")]
  [FieldOffset(Offset = "0x1C")]
  [Space(10f)]
  public Vector2 MaxAspectSize;
  [Token(Token = "0x40004B7")]
  [FieldOffset(Offset = "0x24")]
  public float MaxScroll;
  [Token(Token = "0x40004B8")]
  [FieldOffset(Offset = "0x28")]
  public float MaxOffset;
  [Token(Token = "0x40004B9")]
  [FieldOffset(Offset = "0x2C")]
  [Space(10f)]
  public float MaxZ;
  [Token(Token = "0x40004BA")]
  [FieldOffset(Offset = "0x30")]
  public Camera ProjectionCamera;
  [Token(Token = "0x40004BB")]
  [FieldOffset(Offset = "0x34")]
  private float mScrollPos;
  [Token(Token = "0x40004BC")]
  [FieldOffset(Offset = "0x38")]
  private List<KeyValuePair<Transform, Vector3>> mChildren;

  [Token(Token = "0x17000103")]
  public float ScrollPos
  {
    [Token(Token = "0x6000679"), Address(RVA = "0xD58600", Offset = "0xD57400", VA = "0x10D58600")] set
    {
    }
    [Token(Token = "0x600067A"), Address(RVA = "0x3A3970", Offset = "0x3A2770", VA = "0x103A3970")] get
    {
      return new float();
    }
  }

  [Token(Token = "0x600067B")]
  [Address(RVA = "0xD583F0", Offset = "0xD571F0", VA = "0x10D583F0")]
  private void Start()
  {
  }

  [Token(Token = "0x600067C")]
  [Address(RVA = "0xD58060", Offset = "0xD56E60", VA = "0x10D58060")]
  private void Layout()
  {
  }

  [Token(Token = "0x600067D")]
  [Address(RVA = "0xD58380", Offset = "0xD57180", VA = "0x10D58380")]
  private void OnValidate()
  {
  }

  [Token(Token = "0x600067E")]
  [Address(RVA = "0xD58550", Offset = "0xD57350", VA = "0x10D58550")]
  public GiziScroll()
  {
  }
}

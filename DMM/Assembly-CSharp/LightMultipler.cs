// Decompiled with JetBrains decompiler
// Type: LightMultipler
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x200010A")]
[DisallowMultipleComponent]
[ExecuteInEditMode]
[AddComponentMenu("Rendering/Light Multipler")]
public class LightMultipler : MonoBehaviour
{
  [Token(Token = "0x40004E4")]
  [FieldOffset(Offset = "0xC")]
  public float Radius;
  [Token(Token = "0x40004E5")]
  [FieldOffset(Offset = "0x10")]
  public float Exponent;
  [Token(Token = "0x40004E6")]
  [FieldOffset(Offset = "0x14")]
  public Vector3 Multipler;
  [Token(Token = "0x40004E7")]
  [FieldOffset(Offset = "0x20")]
  protected Vector3 mPositionCache;

  [Token(Token = "0x60006CC")]
  [Address(RVA = "0xD5ADE0", Offset = "0xD59BE0", VA = "0x10D5ADE0", Slot = "4")]
  public virtual void Cache()
  {
  }

  [Token(Token = "0x60006CD")]
  [Address(RVA = "0xD5AFE0", Offset = "0xD59DE0", VA = "0x10D5AFE0")]
  protected Vector3 CalcMultipler(float distance) => new Vector3();

  [Token(Token = "0x60006CE")]
  [Address(RVA = "0xD5AE30", Offset = "0xD59C30", VA = "0x10D5AE30", Slot = "5")]
  public virtual Vector3 CalcMultiplerAtPoint(Vector3 position, Vector3 normal) => new Vector3();

  [Token(Token = "0x60006CF")]
  [Address(RVA = "0xD5AD90", Offset = "0xD59B90", VA = "0x10D5AD90")]
  private void Awake()
  {
  }

  [Token(Token = "0x60006D0")]
  [Address(RVA = "0xD5B0F0", Offset = "0xD59EF0", VA = "0x10D5B0F0")]
  public LightMultipler()
  {
  }
}

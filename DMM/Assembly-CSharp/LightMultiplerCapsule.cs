// Decompiled with JetBrains decompiler
// Type: LightMultiplerCapsule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x200010B")]
[AddComponentMenu("Rendering/Light Multipler Capsule")]
public class LightMultiplerCapsule : LightMultipler
{
  [Token(Token = "0x40004E8")]
  [FieldOffset(Offset = "0x2C")]
  [SerializeField]
  public List<Vector3> mPoints;

  [Token(Token = "0x60006D1")]
  [Address(RVA = "0xD5ACD0", Offset = "0xD59AD0", VA = "0x10D5ACD0")]
  public LightMultiplerCapsule()
  {
  }
}

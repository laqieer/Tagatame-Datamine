// Decompiled with JetBrains decompiler
// Type: GemParticleHitEffect
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000011")]
[AddComponentMenu("Battle/GemParticleHitEffect")]
public class GemParticleHitEffect : MonoBehaviour
{
  [Token(Token = "0x4000044")]
  [FieldOffset(Offset = "0xC")]
  private Vector3 mStartPosition;
  [Token(Token = "0x4000045")]
  [FieldOffset(Offset = "0x0")]
  public static bool IsEnable;
  [Token(Token = "0x4000046")]
  [FieldOffset(Offset = "0x18")]
  public GameObject EffectPrefab;

  [Token(Token = "0x6000065")]
  [Address(RVA = "0x2C4A80", Offset = "0x2C3880", VA = "0x102C4A80")]
  private void Start()
  {
  }

  [Token(Token = "0x6000066")]
  [Address(RVA = "0x2C4AD0", Offset = "0x2C38D0", VA = "0x102C4AD0")]
  private void Update()
  {
  }

  [Token(Token = "0x6000067")]
  [Address(RVA = "0x2C4A20", Offset = "0x2C3820", VA = "0x102C4A20")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x6000068")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public GemParticleHitEffect()
  {
  }
}

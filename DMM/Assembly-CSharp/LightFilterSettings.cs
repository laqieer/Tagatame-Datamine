// Decompiled with JetBrains decompiler
// Type: LightFilterSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000106")]
[ExecuteInEditMode]
[AddComponentMenu("")]
public class LightFilterSettings : MonoBehaviour
{
  [Token(Token = "0x40004D9")]
  [FieldOffset(Offset = "0xC")]
  public float AOSampleRadius;
  [Token(Token = "0x40004DA")]
  [FieldOffset(Offset = "0x10")]
  public float AOExponent;
  [Token(Token = "0x40004DB")]
  [FieldOffset(Offset = "0x14")]
  public float AOStrength;
  [Token(Token = "0x40004DC")]
  [FieldOffset(Offset = "0x18")]
  public Gradient AOGradient;
  [Token(Token = "0x40004DD")]
  [FieldOffset(Offset = "0x1C")]
  public bool UseAmbientOcclusion;

  [Token(Token = "0x1700010D")]
  public static LightFilterSettings Current
  {
    [Token(Token = "0x60006BD"), Address(RVA = "0xD5AA20", Offset = "0xD59820", VA = "0x10D5AA20")] get
    {
      return (LightFilterSettings) null;
    }
  }

  [Token(Token = "0x60006BE")]
  [Address(RVA = "0xD5A780", Offset = "0xD59580", VA = "0x10D5A780")]
  private void Awake()
  {
  }

  [Token(Token = "0x60006BF")]
  [Address(RVA = "0xD5A9F0", Offset = "0xD597F0", VA = "0x10D5A9F0")]
  public LightFilterSettings()
  {
  }
}

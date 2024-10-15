// Decompiled with JetBrains decompiler
// Type: AmbientLightSettings
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000031")]
[ExecuteInEditMode]
[AddComponentMenu("Common/AmbientLightSettings")]
public class AmbientLightSettings : MonoBehaviour
{
  [Token(Token = "0x40000EC")]
  [FieldOffset(Offset = "0x0")]
  public static List<AmbientLightSettings> Volumes;
  [Token(Token = "0x40000ED")]
  [FieldOffset(Offset = "0xC")]
  [Header("Ambient Light")]
  public Color AmbientLightColor;
  [Token(Token = "0x40000EE")]
  [FieldOffset(Offset = "0x1C")]
  [Header("Fog")]
  public Color FogColor;
  [Token(Token = "0x40000EF")]
  [FieldOffset(Offset = "0x2C")]
  public float FogStartDistance;
  [Token(Token = "0x40000F0")]
  [FieldOffset(Offset = "0x30")]
  public float FogEndDistance;

  [Token(Token = "0x6000123")]
  [Address(RVA = "0x2BC2A0", Offset = "0x2BB0A0", VA = "0x102BC2A0")]
  public static implicit operator AmbientLightSettings.State(AmbientLightSettings src)
  {
    return new AmbientLightSettings.State();
  }

  [Token(Token = "0x17000019")]
  public Bounds Bounds
  {
    [Token(Token = "0x6000124"), Address(RVA = "0x2BC210", Offset = "0x2BB010", VA = "0x102BC210")] get
    {
      return new Bounds();
    }
  }

  [Token(Token = "0x6000125")]
  [Address(RVA = "0x2BBEF0", Offset = "0x2BACF0", VA = "0x102BBEF0")]
  public static AmbientLightSettings FindVolume(Vector3 pos) => (AmbientLightSettings) null;

  [Token(Token = "0x6000126")]
  [Address(RVA = "0x2BC120", Offset = "0x2BAF20", VA = "0x102BC120")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x6000127")]
  [Address(RVA = "0x2BC0B0", Offset = "0x2BAEB0", VA = "0x102BC0B0")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x6000128")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public AmbientLightSettings()
  {
  }

  [Token(Token = "0x6000129")]
  [Address(RVA = "0x2BC190", Offset = "0x2BAF90", VA = "0x102BC190")]
  static AmbientLightSettings()
  {
  }

  [Token(Token = "0x2000032")]
  public struct State
  {
    [Token(Token = "0x40000F1")]
    [FieldOffset(Offset = "0x0")]
    public Color AmbientLightColor;
    [Token(Token = "0x40000F2")]
    [FieldOffset(Offset = "0x10")]
    public Color FogColor;
    [Token(Token = "0x40000F3")]
    [FieldOffset(Offset = "0x20")]
    public float FogStartDistance;
    [Token(Token = "0x40000F4")]
    [FieldOffset(Offset = "0x24")]
    public float FogEndDistance;

    [Token(Token = "0x600012A")]
    [Address(RVA = "0x2CCC00", Offset = "0x2CBA00", VA = "0x102CCC00")]
    public static AmbientLightSettings.State Lerp(
      AmbientLightSettings.State a,
      AmbientLightSettings.State b,
      float t)
    {
      return new AmbientLightSettings.State();
    }
  }
}

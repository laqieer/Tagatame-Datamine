// Decompiled with JetBrains decompiler
// Type: StaticLightVolume
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000169")]
[ExecuteInEditMode]
[AddComponentMenu("Common/StaticLightVolume")]
public class StaticLightVolume : MonoBehaviour
{
  [Token(Token = "0x40006D0")]
  [FieldOffset(Offset = "0x0")]
  public static List<StaticLightVolume> Volumes;
  [Token(Token = "0x40006D1")]
  [FieldOffset(Offset = "0xC")]
  [NonSerialized]
  public Bounds Bounds;
  [Token(Token = "0x40006D2")]
  [FieldOffset(Offset = "0x24")]
  [Range(0.0f, 1f)]
  public float AmbientLitToDirectLit;
  [Token(Token = "0x40006D3")]
  [FieldOffset(Offset = "0x28")]
  [Range(0.0f, 1f)]
  public float AmbientLitToIndirectLit;
  [Token(Token = "0x40006D4")]
  [FieldOffset(Offset = "0x2C")]
  [Range(0.0f, 1f)]
  public float PointLitToDirectLit;
  [Token(Token = "0x40006D5")]
  [FieldOffset(Offset = "0x30")]
  [Range(0.0f, 1f)]
  public float PointLitToIndirectLit;
  [Token(Token = "0x40006D6")]
  [FieldOffset(Offset = "0x34")]
  [Range(0.1f, 4f)]
  public float DirectLightingScale;
  [Token(Token = "0x40006D7")]
  [FieldOffset(Offset = "0x38")]
  [Range(0.1f, 4f)]
  public float IndirectLightingScale;
  [Token(Token = "0x40006D8")]
  [FieldOffset(Offset = "0x3C")]
  [HideInInspector]
  [SerializeField]
  private StaticLightVolume.LightProbe[] mVoxel;
  [Token(Token = "0x40006D9")]
  [FieldOffset(Offset = "0x40")]
  [Range(1f, 16f)]
  public int XSize;
  [Token(Token = "0x40006DA")]
  [FieldOffset(Offset = "0x44")]
  [Range(1f, 16f)]
  public int YSize;
  [Token(Token = "0x40006DB")]
  [FieldOffset(Offset = "0x48")]
  [Range(1f, 16f)]
  public int ZSize;
  [Token(Token = "0x40006DC")]
  private const float GizmoColorR = 0.2f;
  [Token(Token = "0x40006DD")]
  private const float GizmoColorG = 0.6f;
  [Token(Token = "0x40006DE")]
  private const float GizmoColorB = 0.6f;

  [Token(Token = "0x6000957")]
  [Address(RVA = "0xE65290", Offset = "0xE64090", VA = "0x10E65290")]
  public static StaticLightVolume FindVolume(Vector3 pos) => (StaticLightVolume) null;

  [Token(Token = "0x6000958")]
  [Address(RVA = "0x2BC210", Offset = "0x2BB010", VA = "0x102BC210")]
  private Bounds CalcBounds() => new Bounds();

  [Token(Token = "0x6000959")]
  [Address(RVA = "0xE65470", Offset = "0xE64270", VA = "0x10E65470")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x600095A")]
  [Address(RVA = "0xE65400", Offset = "0xE64200", VA = "0x10E65400")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x600095B")]
  [Address(RVA = "0xE64260", Offset = "0xE63060", VA = "0x10E64260")]
  public void CalcLightColor(Vector3 position, out Color directLit, out Color indirectLit)
  {
  }

  [Token(Token = "0x600095C")]
  [Address(RVA = "0xE65570", Offset = "0xE64370", VA = "0x10E65570")]
  private void OnValidate()
  {
  }

  [Token(Token = "0x600095D")]
  [Address(RVA = "0xE640D0", Offset = "0xE62ED0", VA = "0x10E640D0")]
  private Vector3 CalcCenter(int x, int y, int z) => new Vector3();

  [Token(Token = "0x600095E")]
  [Address(RVA = "0xE63600", Offset = "0xE62400", VA = "0x10E63600")]
  public void Bake()
  {
  }

  [Token(Token = "0x600095F")]
  [Address(RVA = "0xE65750", Offset = "0xE64550", VA = "0x10E65750")]
  public StaticLightVolume()
  {
  }

  [Token(Token = "0x6000960")]
  [Address(RVA = "0xE656D0", Offset = "0xE644D0", VA = "0x10E656D0")]
  static StaticLightVolume()
  {
  }

  [Token(Token = "0x200016A")]
  [Serializable]
  public struct LightProbe
  {
    [Token(Token = "0x40006DF")]
    [FieldOffset(Offset = "0x0")]
    public Color32 DirectLightColor;
    [Token(Token = "0x40006E0")]
    [FieldOffset(Offset = "0x4")]
    public Color32 IndirectLightColor;
  }
}

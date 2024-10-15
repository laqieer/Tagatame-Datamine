// Decompiled with JetBrains decompiler
// Type: StaticProjector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x200016C")]
[RequireComponent(typeof (MeshFilter))]
[RequireComponent(typeof (MeshRenderer))]
[AddComponentMenu("Rendering/Static Projector")]
[ExecuteInEditMode]
public class StaticProjector : MonoBehaviour
{
  [Token(Token = "0x40006E4")]
  [FieldOffset(Offset = "0xC")]
  [SerializeField]
  [HideInInspector]
  private Mesh mMesh;
  [Token(Token = "0x40006E5")]
  [FieldOffset(Offset = "0x10")]
  public float FOVAngle;
  [Token(Token = "0x40006E6")]
  [FieldOffset(Offset = "0x14")]
  public float FarPlane;

  [Token(Token = "0x6000965")]
  [Address(RVA = "0xB7FC50", Offset = "0xB7EA50", VA = "0x10B7FC50")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000966")]
  [Address(RVA = "0xF4FF40", Offset = "0xF4ED40", VA = "0x10F4FF40")]
  public StaticProjector()
  {
  }
}

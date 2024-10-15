// Decompiled with JetBrains decompiler
// Type: StaticBatchGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000166")]
[DisallowMultipleComponent]
[AddComponentMenu("Common/StaticBatchGroup")]
public class StaticBatchGroup : MonoBehaviour
{
  [Token(Token = "0x40006C6")]
  [FieldOffset(Offset = "0x0")]
  private static List<StaticBatchGroup> mInstances;
  [Token(Token = "0x40006C7")]
  private const int DEFAULT_INDEX_BUFFER_SIZE = 512;
  [Token(Token = "0x40006C8")]
  [FieldOffset(Offset = "0xC")]
  private MeshRenderer mMeshRenderer;
  [Token(Token = "0x40006C9")]
  [FieldOffset(Offset = "0x10")]
  private MeshFilter mMeshFilter;

  [Token(Token = "0x600094C")]
  [Address(RVA = "0xE61CB0", Offset = "0xE60AB0", VA = "0x10E61CB0")]
  private void Awake()
  {
  }

  [Token(Token = "0x600094D")]
  [Address(RVA = "0xE63320", Offset = "0xE62120", VA = "0x10E63320")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x600094E")]
  [Address(RVA = "0xE62960", Offset = "0xE61760", VA = "0x10E62960")]
  private static float GetScaleSign(Transform tr) => new float();

  [Token(Token = "0x600094F")]
  [Address(RVA = "0xE629F0", Offset = "0xE617F0", VA = "0x10E629F0")]
  private static Mesh MergeMeshes(
    List<StaticBatchGroup.Section>[] groups,
    int numSubMeshes,
    List<Vector3> verts,
    List<Vector3> normals,
    List<Color32> colors,
    List<Vector2> uvs,
    List<Vector2> uvs1,
    List<Vector2> uvs2,
    List<int>[] newIndices,
    List<int> indexMap)
  {
    return (Mesh) null;
  }

  [Token(Token = "0x6000950")]
  [Address(RVA = "0xE61D80", Offset = "0xE60B80", VA = "0x10E61D80")]
  private static Mesh[] GenerateBatch() => (Mesh[]) null;

  [Token(Token = "0x6000951")]
  [Address(RVA = "0xE63390", Offset = "0xE62190", VA = "0x10E63390")]
  private void Start()
  {
  }

  [Token(Token = "0x6000952")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public StaticBatchGroup()
  {
  }

  [Token(Token = "0x6000953")]
  [Address(RVA = "0xE63580", Offset = "0xE62380", VA = "0x10E63580")]
  static StaticBatchGroup()
  {
  }

  [Token(Token = "0x2000167")]
  private class Section
  {
    [Token(Token = "0x40006CA")]
    [FieldOffset(Offset = "0x8")]
    public Material Material;
    [Token(Token = "0x40006CB")]
    [FieldOffset(Offset = "0xC")]
    public MeshRenderer MeshRenderer;
    [Token(Token = "0x40006CC")]
    [FieldOffset(Offset = "0x10")]
    public MeshFilter MeshFilter;
    [Token(Token = "0x40006CD")]
    [FieldOffset(Offset = "0x14")]
    public int SubMesh;
    [Token(Token = "0x40006CE")]
    [FieldOffset(Offset = "0x18")]
    public bool Merged;

    [Token(Token = "0x6000954")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public Section()
    {
    }
  }
}

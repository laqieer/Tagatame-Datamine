// Decompiled with JetBrains decompiler
// Type: SRPG.GridMeshGenerator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000C78")]
  internal class GridMeshGenerator
  {
    [Token(Token = "0x40021C9")]
    private const float MinNormalThreshold = 0.5f;
    [Token(Token = "0x40021CA")]
    [FieldOffset(Offset = "0x8")]
    private List<Vector3> mVerts;
    [Token(Token = "0x40021CB")]
    [FieldOffset(Offset = "0xC")]
    private List<int> mIndices;

    [Token(Token = "0x6003122")]
    [Address(RVA = "0x1022BB0", Offset = "0x10219B0", VA = "0x11022BB0")]
    public void Clear()
    {
    }

    [Token(Token = "0x6003123")]
    [Address(RVA = "0x1022850", Offset = "0x1021650", VA = "0x11022850")]
    public IEnumerator AddMeshAsync(Mesh mesh, Matrix4x4 matrix, Rect clipRect, bool mirror)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6003124")]
    [Address(RVA = "0x10228F0", Offset = "0x10216F0", VA = "0x110228F0")]
    public void AddTriangle(Vector3 v0, Vector3 v1, Vector3 v2, Rect rect)
    {
    }

    [Token(Token = "0x6003125")]
    [Address(RVA = "0x1022AA0", Offset = "0x10218A0", VA = "0x11022AA0")]
    private int AddVertex(Vector3 v) => new int();

    [Token(Token = "0x6003126")]
    [Address(RVA = "0x1022C10", Offset = "0x1021A10", VA = "0x11022C10")]
    public Mesh CreateMesh() => (Mesh) null;

    [Token(Token = "0x6003127")]
    [Address(RVA = "0x1022DD0", Offset = "0x1021BD0", VA = "0x11022DD0")]
    public GridMeshGenerator()
    {
    }
  }
}

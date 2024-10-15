// Decompiled with JetBrains decompiler
// Type: BatchChunk
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000092")]
[DisallowMultipleComponent]
[ExecuteInEditMode]
public abstract class BatchChunk : MonoBehaviour
{
  [Token(Token = "0x40002D6")]
  [FieldOffset(Offset = "0xC")]
  public Mesh Mesh;
  [Token(Token = "0x40002D7")]
  [FieldOffset(Offset = "0x10")]
  public Material Material;

  [Token(Token = "0x600038C")]
  [Address(RVA = "0xB7FC50", Offset = "0xB7EA50", VA = "0x10B7FC50")]
  private void Awake()
  {
  }

  [Token(Token = "0x600038D")]
  public abstract void FillTriangles(
    int baseVertex,
    Vector3[] vertices,
    Vector3[] normals,
    Vector2[] uv,
    Color32[] colors,
    Vector3[] centers,
    int baseIndex,
    int[] indices);

  [Token(Token = "0x170000A1")]
  public virtual int VertexCount
  {
    [Token(Token = "0x600038E"), Address(RVA = "0xB7FD00", Offset = "0xB7EB00", VA = "0x10B7FD00", Slot = "5")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x170000A2")]
  public virtual int IndexCount
  {
    [Token(Token = "0x600038F"), Address(RVA = "0xB7FC80", Offset = "0xB7EA80", VA = "0x10B7FC80", Slot = "6")] get
    {
      return new int();
    }
  }

  [Token(Token = "0x6000390")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  protected BatchChunk()
  {
  }
}

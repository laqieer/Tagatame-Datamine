// Decompiled with JetBrains decompiler
// Type: BatchGroup
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000093")]
[AddComponentMenu("Rendering/Batch Group")]
[DisallowMultipleComponent]
[ExecuteInEditMode]
public class BatchGroup : MonoBehaviour
{
  [Token(Token = "0x40002D8")]
  [FieldOffset(Offset = "0xC")]
  private List<BatchGroup.BatchInfo> mBatches;
  [Token(Token = "0x40002D9")]
  [FieldOffset(Offset = "0x10")]
  private Matrix4x4 mWorldToLocal;

  [Token(Token = "0x6000391")]
  [Address(RVA = "0xB7FE60", Offset = "0xB7EC60", VA = "0x10B7FE60")]
  private void Start()
  {
  }

  [Token(Token = "0x6000392")]
  [Address(RVA = "0xB7FE50", Offset = "0xB7EC50", VA = "0x10B7FE50")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000393")]
  [Address(RVA = "0xB7FD80", Offset = "0xB7EB80", VA = "0x10B7FD80")]
  private void ClearBatches()
  {
  }

  [Token(Token = "0x6000394")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  public void RequestUpdateBatch()
  {
  }

  [Token(Token = "0x6000395")]
  [Address(RVA = "0xB7FE70", Offset = "0xB7EC70", VA = "0x10B7FE70")]
  public void UpdateBatch()
  {
  }

  [Token(Token = "0x6000396")]
  [Address(RVA = "0xB803B0", Offset = "0xB7F1B0", VA = "0x10B803B0")]
  private void Update()
  {
  }

  [Token(Token = "0x6000397")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  private void OnRenderObject()
  {
  }

  [Token(Token = "0x6000398")]
  [Address(RVA = "0xB80570", Offset = "0xB7F370", VA = "0x10B80570")]
  public BatchGroup()
  {
  }

  [Token(Token = "0x2000094")]
  private struct BatchInfo
  {
    [Token(Token = "0x40002DA")]
    [FieldOffset(Offset = "0x0")]
    public Mesh Mesh;
    [Token(Token = "0x40002DB")]
    [FieldOffset(Offset = "0x4")]
    public Material Material;
  }
}

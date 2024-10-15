// Decompiled with JetBrains decompiler
// Type: SRPG.AnimEventWithTarget
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E40")]
  public abstract class AnimEventWithTarget : AnimEvent
  {
    [Token(Token = "0x4002B56")]
    protected const string BONE_NAME_CAMERA = "CAMERA";
    [Token(Token = "0x4002B57")]
    [FieldOffset(Offset = "0x18")]
    public string BoneName;
    [Token(Token = "0x4002B58")]
    [FieldOffset(Offset = "0x1C")]
    public Vector3 Offset;
    [Token(Token = "0x4002B59")]
    [FieldOffset(Offset = "0x28")]
    public Vector3 Rotation;
    [Token(Token = "0x4002B5A")]
    [FieldOffset(Offset = "0x34")]
    public bool LocalOffset;
    [Token(Token = "0x4002B5B")]
    [FieldOffset(Offset = "0x35")]
    public bool LocalRotation;

    [Token(Token = "0x6003ADF")]
    [Address(RVA = "0x10CB8F0", Offset = "0x10CA6F0", VA = "0x110CB8F0")]
    public void CalcPosition(
      GameObject go,
      GameObject prefab,
      out Vector3 spawnPos,
      out Quaternion spawnRot)
    {
    }

    [Token(Token = "0x6003AE0")]
    [Address(RVA = "0x10CB990", Offset = "0x10CA790", VA = "0x110CB990")]
    public void CalcPosition(
      GameObject go,
      Vector3 deltaOffset,
      Quaternion deltaRotation,
      out Vector3 spawnPos,
      out Quaternion spawnRot)
    {
    }

    [Token(Token = "0x6003AE1")]
    [Address(RVA = "0x10CBEA0", Offset = "0x10CACA0", VA = "0x110CBEA0")]
    protected AnimEventWithTarget()
    {
    }
  }
}

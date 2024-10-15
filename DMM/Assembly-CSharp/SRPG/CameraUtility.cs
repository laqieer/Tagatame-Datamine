// Decompiled with JetBrains decompiler
// Type: SRPG.CameraUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E2B")]
  [AddComponentMenu("Scripts/SRPG/Camera/Utility")]
  public class CameraUtility : MonoBehaviour
  {
    [Token(Token = "0x4002AFE")]
    [FieldOffset(Offset = "0xC")]
    private float mFixedWidth;
    [Token(Token = "0x4002AFF")]
    [FieldOffset(Offset = "0x10")]
    private float mFixedHeight;

    [Token(Token = "0x6003A66")]
    [Address(RVA = "0x10D83E0", Offset = "0x10D71E0", VA = "0x110D83E0")]
    private void Awake()
    {
    }

    [Token(Token = "0x6003A67")]
    [Address(RVA = "0x10D8580", Offset = "0x10D7380", VA = "0x110D8580")]
    public void Reset()
    {
    }

    [Token(Token = "0x6003A68")]
    [Address(RVA = "0x10D8430", Offset = "0x10D7230", VA = "0x110D8430")]
    public float CalcAspectRatio(float w, float h) => new float();

    [Token(Token = "0x6003A69")]
    [Address(RVA = "0x10D8440", Offset = "0x10D7240", VA = "0x110D8440")]
    private Rect CalcScreenAspect() => new Rect();

    [Token(Token = "0x6003A6A")]
    [Address(RVA = "0x10D8750", Offset = "0x10D7550", VA = "0x110D8750")]
    public CameraUtility()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SkyLayer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000161")]
[AddComponentMenu("Rendering/Sky Layer")]
[RequireComponent(typeof (Renderer))]
public class SkyLayer : MonoBehaviour
{
  [Token(Token = "0x40006B6")]
  [FieldOffset(Offset = "0xC")]
  public float SkyDistance;
  [Token(Token = "0x40006B7")]
  [FieldOffset(Offset = "0x10")]
  public Vector3 SkyOffset;
  [Token(Token = "0x40006B8")]
  [FieldOffset(Offset = "0x1C")]
  private bool mVisible;
  [Token(Token = "0x40006B9")]
  [FieldOffset(Offset = "0x20")]
  private Vector3 mOldPosition;
  [Token(Token = "0x40006BA")]
  [FieldOffset(Offset = "0x2C")]
  private Camera mCamera;

  [Token(Token = "0x6000939")]
  [Address(RVA = "0xE616C0", Offset = "0xE604C0", VA = "0x10E616C0")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x600093A")]
  [Address(RVA = "0xE61630", Offset = "0xE60430", VA = "0x10E61630")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x600093B")]
  [Address(RVA = "0xE61500", Offset = "0xE60300", VA = "0x10E61500")]
  private void OnCameraPreCull(Camera camera)
  {
  }

  [Token(Token = "0x600093C")]
  [Address(RVA = "0xE61500", Offset = "0xE60300", VA = "0x10E61500")]
  private void OnWillRenderObject()
  {
  }

  [Token(Token = "0x600093D")]
  [Address(RVA = "0xE61750", Offset = "0xE60550", VA = "0x10E61750")]
  private void OnRenderObject()
  {
  }

  [Token(Token = "0x600093E")]
  [Address(RVA = "0xE617A0", Offset = "0xE605A0", VA = "0x10E617A0")]
  public SkyLayer()
  {
  }
}

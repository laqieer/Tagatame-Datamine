// Decompiled with JetBrains decompiler
// Type: CameraCallback
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x200001F")]
[DisallowMultipleComponent]
[AddComponentMenu("")]
[ExecuteInEditMode]
public class CameraCallback : MonoBehaviour
{
  [Token(Token = "0x4000085")]
  [FieldOffset(Offset = "0xC")]
  public CameraCallback.CameraEvent OnCameraPreCull;
  [Token(Token = "0x4000086")]
  [FieldOffset(Offset = "0x10")]
  public CameraCallback.CameraEvent OnCameraPreRender;
  [Token(Token = "0x4000087")]
  [FieldOffset(Offset = "0x14")]
  public CameraCallback.CameraEvent OnCameraPostRender;
  [Token(Token = "0x4000088")]
  [FieldOffset(Offset = "0x18")]
  public CameraCallback.RenderImageEvent OnCameraRenderImage;

  [Token(Token = "0x60000AD")]
  [Address(RVA = "0x2C1330", Offset = "0x2C0130", VA = "0x102C1330")]
  private void OnPreCull()
  {
  }

  [Token(Token = "0x60000AE")]
  [Address(RVA = "0x2C1380", Offset = "0x2C0180", VA = "0x102C1380")]
  private void OnPreRender()
  {
  }

  [Token(Token = "0x60000AF")]
  [Address(RVA = "0x2C12E0", Offset = "0x2C00E0", VA = "0x102C12E0")]
  private void OnPostRender()
  {
  }

  [Token(Token = "0x60000B0")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public CameraCallback()
  {
  }

  [Token(Token = "0x2000020")]
  public delegate void CameraEvent(Camera camera);

  [Token(Token = "0x2000021")]
  public delegate void RenderImageEvent(Camera camera, RenderTexture src, RenderTexture dest);
}

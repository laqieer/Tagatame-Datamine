// Decompiled with JetBrains decompiler
// Type: RenkeiCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x200002A")]
[RequireComponent(typeof (Camera))]
[AddComponentMenu("Camera/RenkeiCamera")]
public class RenkeiCamera : MonoBehaviour
{
  [Token(Token = "0x40000C1")]
  [FieldOffset(Offset = "0xC")]
  private RenderTexture mRT;
  [Token(Token = "0x40000C2")]
  [FieldOffset(Offset = "0x10")]
  private bool mRTDirty;
  [Token(Token = "0x40000C3")]
  [FieldOffset(Offset = "0x14")]
  private Transform mBackground;
  [Token(Token = "0x40000C4")]
  [FieldOffset(Offset = "0x18")]
  private float mRenderWidth;
  [Token(Token = "0x40000C5")]
  [FieldOffset(Offset = "0x1C")]
  private float mRenderHeight;

  [Token(Token = "0x1700000D")]
  public bool IsSceneTextureDirty
  {
    [Token(Token = "0x60000E8"), Address(RVA = "0x2B0B70", Offset = "0x2AF970", VA = "0x102B0B70")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x1700000E")]
  public RenderTexture SceneTexture
  {
    [Token(Token = "0x60000E9"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
    {
      return (RenderTexture) null;
    }
  }

  [Token(Token = "0x1700000F")]
  public Color FillColor
  {
    [Token(Token = "0x60000EA"), Address(RVA = "0x2C9FC0", Offset = "0x2C8DC0", VA = "0x102C9FC0")] set
    {
    }
  }

  [Token(Token = "0x60000EB")]
  [Address(RVA = "0x2C99C0", Offset = "0x2C87C0", VA = "0x102C99C0")]
  private void ReleaseRenderTarget()
  {
  }

  [Token(Token = "0x60000EC")]
  [Address(RVA = "0x2C9C90", Offset = "0x2C8A90", VA = "0x102C9C90")]
  public void SetRenderSize(float w, float h)
  {
  }

  [Token(Token = "0x60000ED")]
  [Address(RVA = "0x2C9B30", Offset = "0x2C8930", VA = "0x102C9B30")]
  public void SetBackgroundTemplate(GameObject backgroundTemplate)
  {
  }

  [Token(Token = "0x60000EE")]
  [Address(RVA = "0x2C9DE0", Offset = "0x2C8BE0", VA = "0x102C9DE0")]
  private void Start()
  {
  }

  [Token(Token = "0x60000EF")]
  [Address(RVA = "0x2C99C0", Offset = "0x2C87C0", VA = "0x102C99C0")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x60000F0")]
  [Address(RVA = "0x2C9A80", Offset = "0x2C8880", VA = "0x102C9A80")]
  private void OnPreCull()
  {
  }

  [Token(Token = "0x60000F1")]
  [Address(RVA = "0x2C99F0", Offset = "0x2C87F0", VA = "0x102C99F0")]
  private void OnPostRender()
  {
  }

  [Token(Token = "0x60000F2")]
  [Address(RVA = "0x2C9F90", Offset = "0x2C8D90", VA = "0x102C9F90")]
  public RenkeiCamera()
  {
  }
}

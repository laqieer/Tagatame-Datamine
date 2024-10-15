// Decompiled with JetBrains decompiler
// Type: RenderPipeline
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using SRPG;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000027")]
[RequireComponent(typeof (UnityEngine.Camera))]
[DisallowMultipleComponent]
public class RenderPipeline : MonoBehaviour
{
  [Token(Token = "0x4000098")]
  [FieldOffset(Offset = "0xC")]
  [NonSerialized]
  public RenderPipeline.RenderModes RenderMode;
  [Token(Token = "0x4000099")]
  [FieldOffset(Offset = "0x10")]
  private UnityEngine.Camera mCamera;
  [Token(Token = "0x400009A")]
  [FieldOffset(Offset = "0x14")]
  private GameObject mSubCameraGO;
  [Token(Token = "0x400009B")]
  [FieldOffset(Offset = "0x18")]
  private UnityEngine.Camera mSubCamera;
  [Token(Token = "0x400009C")]
  [FieldOffset(Offset = "0x1C")]
  private RenderTexture mRTBase;
  [Token(Token = "0x400009D")]
  [FieldOffset(Offset = "0x20")]
  private RenderTexture mRTComposite;
  [Token(Token = "0x400009E")]
  [FieldOffset(Offset = "0x24")]
  private RenderTexture mRTBloom0;
  [Token(Token = "0x400009F")]
  [FieldOffset(Offset = "0x28")]
  private RenderTexture mRTBloom1;
  [Token(Token = "0x40000A0")]
  [FieldOffset(Offset = "0x2C")]
  private GameObject mPassBG;
  [Token(Token = "0x40000A1")]
  [FieldOffset(Offset = "0x30")]
  private GameObject mPassCH;
  [Token(Token = "0x40000A2")]
  [FieldOffset(Offset = "0x34")]
  private GameObject mPassEffect;
  [Token(Token = "0x40000A3")]
  [FieldOffset(Offset = "0x38")]
  private GameObject mPassUI;
  [Token(Token = "0x40000A4")]
  [FieldOffset(Offset = "0x3C")]
  private Material mUberPostEffect;
  [Token(Token = "0x40000A5")]
  [FieldOffset(Offset = "0x40")]
  private Material mBlitCopy;
  [Token(Token = "0x40000A6")]
  [FieldOffset(Offset = "0x44")]
  private Material mBlitAdd;
  [Token(Token = "0x40000A7")]
  [FieldOffset(Offset = "0x48")]
  private Material mBlitDodge;
  [Token(Token = "0x40000A8")]
  [FieldOffset(Offset = "0x4C")]
  private Material mBlurEffect;
  [Token(Token = "0x40000A9")]
  [FieldOffset(Offset = "0x50")]
  private Material mBloomPrePass;
  [Token(Token = "0x40000AA")]
  [FieldOffset(Offset = "0x54")]
  private Material mBlendX;
  [Token(Token = "0x40000AB")]
  [FieldOffset(Offset = "0x58")]
  private Material mDilateErode;
  [Token(Token = "0x40000AC")]
  [FieldOffset(Offset = "0x5C")]
  private Material mBlitFunc;
  [Token(Token = "0x40000AD")]
  [FieldOffset(Offset = "0x60")]
  private Material mBGImage;
  [Token(Token = "0x40000AE")]
  [FieldOffset(Offset = "0x64")]
  private Material mGradientFill;
  [Token(Token = "0x40000AF")]
  [FieldOffset(Offset = "0x68")]
  public RenderPipeline.SwapEffects SwapEffect;
  [Token(Token = "0x40000B0")]
  [FieldOffset(Offset = "0x6C")]
  public float SwapEffectOpacity;
  [Token(Token = "0x40000B1")]
  [FieldOffset(Offset = "0x70")]
  public Texture BackgroundImage;
  [Token(Token = "0x40000B2")]
  [FieldOffset(Offset = "0x74")]
  public Texture ScreenFilter;
  [Token(Token = "0x40000B3")]
  [FieldOffset(Offset = "0x78")]
  public bool FlipHorizontally;
  [Token(Token = "0x40000B4")]
  [FieldOffset(Offset = "0x79")]
  private bool mApplyBloom;
  [Token(Token = "0x40000B5")]
  [FieldOffset(Offset = "0x7A")]
  private bool mApplyVignette;
  [Token(Token = "0x40000B6")]
  [FieldOffset(Offset = "0x7C")]
  private RenderForWindows mRenderForWindows;
  [Token(Token = "0x40000B7")]
  [FieldOffset(Offset = "0x80")]
  private Quaternion mOldRotation;

  [Token(Token = "0x17000009")]
  public bool EnableBloom
  {
    [Token(Token = "0x60000CF"), Address(RVA = "0x2C99A0", Offset = "0x2C87A0", VA = "0x102C99A0")] set
    {
    }
    [Token(Token = "0x60000D0"), Address(RVA = "0x2C9960", Offset = "0x2C8760", VA = "0x102C9960")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x1700000A")]
  public bool EnableVignette
  {
    [Token(Token = "0x60000D1"), Address(RVA = "0x2C99B0", Offset = "0x2C87B0", VA = "0x102C99B0")] set
    {
    }
    [Token(Token = "0x60000D2"), Address(RVA = "0x2C9970", Offset = "0x2C8770", VA = "0x102C9970")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x1700000B")]
  public float mBloomStrength
  {
    [Token(Token = "0x60000D3"), Address(RVA = "0x2C9980", Offset = "0x2C8780", VA = "0x102C9980")] get
    {
      return new float();
    }
  }

  [Token(Token = "0x1700000C")]
  public float BlurStrength
  {
    [Token(Token = "0x60000D4"), Address(RVA = "0x2C9940", Offset = "0x2C8740", VA = "0x102C9940")] get
    {
      return new float();
    }
  }

  [Token(Token = "0x60000D5")]
  [Address(RVA = "0x2C9690", Offset = "0x2C8490", VA = "0x102C9690")]
  public static void Setup(UnityEngine.Camera camera)
  {
  }

  [Token(Token = "0x60000D6")]
  [Address(RVA = "0x2C7C40", Offset = "0x2C6A40", VA = "0x102C7C40")]
  private void Awake()
  {
  }

  [Token(Token = "0x60000D7")]
  [Address(RVA = "0x2C9700", Offset = "0x2C8500", VA = "0x102C9700")]
  private void Start()
  {
  }

  [Token(Token = "0x60000D8")]
  [Address(RVA = "0x2C9440", Offset = "0x2C8240", VA = "0x102C9440")]
  private RenderTexture ReserveRT(
    ref RenderTexture rt,
    float w,
    float h,
    RenderTextureFormat format,
    int depth)
  {
    return (RenderTexture) null;
  }

  [Token(Token = "0x60000D9")]
  [Address(RVA = "0x2C93C0", Offset = "0x2C81C0", VA = "0x102C93C0")]
  private void ReleaseRT(ref RenderTexture rt)
  {
  }

  [Token(Token = "0x60000DA")]
  [Address(RVA = "0x2C7E20", Offset = "0x2C6C20", VA = "0x102C7E20")]
  private void CreatePass(
    ref GameObject pass,
    string name,
    int priority,
    CameraCallback.CameraEvent onPreCull,
    CameraCallback.CameraEvent onPreRender,
    CameraCallback.CameraEvent onPostRender,
    CameraCallback.RenderImageEvent onRenderImage,
    int cullingMask,
    bool clearDepth)
  {
  }

  [Token(Token = "0x60000DB")]
  [Address(RVA = "0x2C8100", Offset = "0x2C6F00", VA = "0x102C8100")]
  private void DestroyPass(ref GameObject pass)
  {
  }

  [Token(Token = "0x60000DC")]
  [Address(RVA = "0x2C7DF0", Offset = "0x2C6BF0", VA = "0x102C7DF0")]
  private void ClearBackground(bool clearColor, bool clearDepth, Color bgColor, float depth)
  {
  }

  [Token(Token = "0x60000DD")]
  [Address(RVA = "0x2C82B0", Offset = "0x2C70B0", VA = "0x102C82B0")]
  private Material LoadShader(string path) => (Material) null;

  [Token(Token = "0x60000DE")]
  [Address(RVA = "0x2C8560", Offset = "0x2C7360", VA = "0x102C8560")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x60000DF")]
  [Address(RVA = "0x2C8390", Offset = "0x2C7190", VA = "0x102C8390")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x60000E0")]
  [Address(RVA = "0x2C8E90", Offset = "0x2C7C90", VA = "0x102C8E90")]
  private void OnPreCull()
  {
  }

  [Token(Token = "0x60000E1")]
  [Address(RVA = "0x2C81B0", Offset = "0x2C6FB0", VA = "0x102C81B0")]
  private RenderTexture GetTemporaryRT(float scaleFactor, RenderTextureFormat format, int depthBpp)
  {
    return (RenderTexture) null;
  }

  [Token(Token = "0x60000E2")]
  [Address(RVA = "0x2C8FF0", Offset = "0x2C7DF0", VA = "0x102C8FF0")]
  private void OnPreRender()
  {
  }

  [Token(Token = "0x60000E3")]
  [Address(RVA = "0x2C8830", Offset = "0x2C7630", VA = "0x102C8830")]
  private void OnPostRender()
  {
  }

  [Token(Token = "0x60000E4")]
  [Address(RVA = "0x2C93F0", Offset = "0x2C81F0", VA = "0x102C93F0")]
  private static void RenderCamera(
    UnityEngine.Camera tempCam,
    int cullingMask,
    RenderBuffer colorBuffer,
    RenderBuffer depthBuffer)
  {
  }

  [Token(Token = "0x60000E5")]
  [Address(RVA = "0x2C7D00", Offset = "0x2C6B00", VA = "0x102C7D00")]
  private float[] CalcGaussianKernel(int count, float strength) => (float[]) null;

  [Token(Token = "0x60000E6")]
  [Address(RVA = "0x2C78E0", Offset = "0x2C66E0", VA = "0x102C78E0")]
  private Texture ApplyBloom() => (Texture) null;

  [Token(Token = "0x60000E7")]
  [Address(RVA = "0x2C9920", Offset = "0x2C8720", VA = "0x102C9920")]
  public RenderPipeline()
  {
  }

  [Token(Token = "0x2000028")]
  public enum RenderModes
  {
    [Token(Token = "0x40000B9")] Default,
    [Token(Token = "0x40000BA")] Base,
    [Token(Token = "0x40000BB")] Bloom0,
    [Token(Token = "0x40000BC")] Bloom1,
    [Token(Token = "0x40000BD")] None,
  }

  [Token(Token = "0x2000029")]
  public enum SwapEffects
  {
    [Token(Token = "0x40000BF")] Copy,
    [Token(Token = "0x40000C0")] Dodge,
  }
}

// Decompiled with JetBrains decompiler
// Type: CameraHook
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000022")]
[DisallowMultipleComponent]
[AddComponentMenu("Camera/CameraHook")]
public class CameraHook : MonoBehaviour
{
  [Token(Token = "0x4000089")]
  [FieldOffset(Offset = "0xC")]
  private AmbientLightSettings mCurrentAmbientVolume;
  [Token(Token = "0x400008A")]
  [FieldOffset(Offset = "0x10")]
  private AmbientLightSettings mNextAmbientVolume;
  [Token(Token = "0x400008B")]
  [FieldOffset(Offset = "0x14")]
  private AmbientLightSettings.State mCurrentAmbientState;
  [Token(Token = "0x400008C")]
  [FieldOffset(Offset = "0x3C")]
  private AmbientLightSettings.State mAmbientStateStart;
  [Token(Token = "0x400008D")]
  [FieldOffset(Offset = "0x64")]
  private AmbientLightSettings.State mAmbientStateEnd;
  [Token(Token = "0x400008E")]
  [FieldOffset(Offset = "0x8C")]
  private float mAmbientStateTransition;
  [Token(Token = "0x400008F")]
  [FieldOffset(Offset = "0x0")]
  public static CameraHook.PreCullEvent mPreCullEventListeners;
  [Token(Token = "0x4000090")]
  [FieldOffset(Offset = "0x4")]
  public static Color ColorMod;
  [Token(Token = "0x4000091")]
  [FieldOffset(Offset = "0x14")]
  private static CameraHook mInstance;
  [Token(Token = "0x4000092")]
  [FieldOffset(Offset = "0x90")]
  private bool mDisableFog;

  [Token(Token = "0x60000B9")]
  [Address(RVA = "0x2C1D20", Offset = "0x2C0B20", VA = "0x102C1D20")]
  private void Start()
  {
  }

  [Token(Token = "0x60000BA")]
  [Address(RVA = "0x2C14D0", Offset = "0x2C02D0", VA = "0x102C14D0")]
  public static void Inject()
  {
  }

  [Token(Token = "0x60000BB")]
  [Address(RVA = "0x2C1C70", Offset = "0x2C0A70", VA = "0x102C1C70")]
  public static void SetDisableFog(bool disable)
  {
  }

  [Token(Token = "0x60000BC")]
  [Address(RVA = "0x2C13D0", Offset = "0x2C01D0", VA = "0x102C13D0")]
  public static void AddPreCullEventListener(CameraHook.PreCullEvent e)
  {
  }

  [Token(Token = "0x60000BD")]
  [Address(RVA = "0x2C1B90", Offset = "0x2C0990", VA = "0x102C1B90")]
  public static void RemovePreCullEventListener(CameraHook.PreCullEvent e)
  {
  }

  [Token(Token = "0x60000BE")]
  [Address(RVA = "0x2C15B0", Offset = "0x2C03B0", VA = "0x102C15B0")]
  private void LateUpdate()
  {
  }

  [Token(Token = "0x60000BF")]
  [Address(RVA = "0x2C18A0", Offset = "0x2C06A0", VA = "0x102C18A0")]
  private void OnPreCull()
  {
  }

  [Token(Token = "0x60000C0")]
  [Address(RVA = "0x2C19B0", Offset = "0x2C07B0", VA = "0x102C19B0")]
  protected void OnPreRender()
  {
  }

  [Token(Token = "0x60000C1")]
  [Address(RVA = "0x2C1840", Offset = "0x2C0640", VA = "0x102C1840")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x60000C2")]
  [Address(RVA = "0x2C1DF0", Offset = "0x2C0BF0", VA = "0x102C1DF0")]
  public CameraHook()
  {
  }

  [Token(Token = "0x60000C3")]
  [Address(RVA = "0x2C1D90", Offset = "0x2C0B90", VA = "0x102C1D90")]
  static CameraHook()
  {
  }

  [Token(Token = "0x2000023")]
  public delegate void PreCullEvent(Camera camera);
}

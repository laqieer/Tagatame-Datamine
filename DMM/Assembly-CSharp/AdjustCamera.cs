// Decompiled with JetBrains decompiler
// Type: AdjustCamera
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000280")]
[AddComponentMenu("UI/AdjustCamera")]
public class AdjustCamera : MonoBehaviour
{
  [Token(Token = "0x4000A8C")]
  [FieldOffset(Offset = "0xC")]
  [SerializeField]
  private bool m_IsIgnoreAutoAdjust;
  [Token(Token = "0x4000A8D")]
  [FieldOffset(Offset = "0x10")]
  private Camera m_TargetCamera;
  [Token(Token = "0x4000A8E")]
  [FieldOffset(Offset = "0x0")]
  private static Dictionary<Camera, AdjustCamera> s_ComponentCache;

  [Token(Token = "0x6000D64")]
  [Address(RVA = "0x11C9830", Offset = "0x11C8630", VA = "0x111C9830")]
  [RuntimeInitializeOnLoadMethod]
  private static void InitializeOnLoad()
  {
  }

  [Token(Token = "0x6000D65")]
  [Address(RVA = "0x11C99A0", Offset = "0x11C87A0", VA = "0x111C99A0")]
  private void Start()
  {
  }

  [Token(Token = "0x6000D66")]
  [Address(RVA = "0x11C9B10", Offset = "0x11C8910", VA = "0x111C9B10")]
  private static void onPreCull(Camera camera)
  {
  }

  [Token(Token = "0x6000D67")]
  [Address(RVA = "0x11C9920", Offset = "0x11C8720", VA = "0x111C9920")]
  private static void SetViewportRect(Camera camera)
  {
  }

  [Token(Token = "0x6000D68")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public AdjustCamera()
  {
  }

  [Token(Token = "0x6000D69")]
  [Address(RVA = "0x11C9A90", Offset = "0x11C8890", VA = "0x111C9A90")]
  static AdjustCamera()
  {
  }
}

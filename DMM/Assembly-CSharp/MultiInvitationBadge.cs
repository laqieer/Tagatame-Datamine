// Decompiled with JetBrains decompiler
// Type: MultiInvitationBadge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20002C1")]
[AddComponentMenu("UI/MultiInvitationBadge")]
public class MultiInvitationBadge : MonoBehaviour
{
  [Token(Token = "0x4000B6A")]
  [FieldOffset(Offset = "0xC")]
  public AnimationCurve AnimationCurve;
  [Token(Token = "0x4000B6B")]
  [FieldOffset(Offset = "0x10")]
  public float Delay;
  [Token(Token = "0x4000B6C")]
  [FieldOffset(Offset = "0x14")]
  public float Duration;
  [Token(Token = "0x4000B6D")]
  [FieldOffset(Offset = "0x18")]
  private Image m_Image;
  [Token(Token = "0x4000B6E")]
  [FieldOffset(Offset = "0x1C")]
  private bool m_StartAnimation;
  [Token(Token = "0x4000B6F")]
  [FieldOffset(Offset = "0x20")]
  private float m_Factor;
  [Token(Token = "0x4000B70")]
  [FieldOffset(Offset = "0x24")]
  private float m_Time;

  [Token(Token = "0x170001BB")]
  public static bool isValid
  {
    [Token(Token = "0x6000E6B"), Address(RVA = "0x11D5A40", Offset = "0x11D4840", VA = "0x111D5A40")] set
    {
    }
    [Token(Token = "0x6000E6C"), Address(RVA = "0x11D5A10", Offset = "0x11D4810", VA = "0x111D5A10")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x6000E6D")]
  [Address(RVA = "0x11D5440", Offset = "0x11D4240", VA = "0x111D5440")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000E6E")]
  [Address(RVA = "0x11D54C0", Offset = "0x11D42C0", VA = "0x111D54C0")]
  private void Start()
  {
  }

  [Token(Token = "0x6000E6F")]
  [Address(RVA = "0x11D5650", Offset = "0x11D4450", VA = "0x111D5650")]
  private void Update()
  {
  }

  [Token(Token = "0x6000E70")]
  [Address(RVA = "0x11D54A0", Offset = "0x11D42A0", VA = "0x111D54A0")]
  public void Play()
  {
  }

  [Token(Token = "0x6000E71")]
  [Address(RVA = "0x11D55C0", Offset = "0x11D43C0", VA = "0x111D55C0")]
  public void Stop()
  {
  }

  [Token(Token = "0x6000E72")]
  [Address(RVA = "0x11D58B0", Offset = "0x11D46B0", VA = "0x111D58B0")]
  public MultiInvitationBadge()
  {
  }
}

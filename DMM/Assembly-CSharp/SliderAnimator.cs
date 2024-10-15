// Decompiled with JetBrains decompiler
// Type: SliderAnimator
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20002D3")]
[AddComponentMenu("UI/SliderAnimator")]
[RequireComponent(typeof (Slider))]
public class SliderAnimator : MonoBehaviour
{
  [Token(Token = "0x4000BB9")]
  [FieldOffset(Offset = "0xC")]
  private Slider mSlider;
  [Token(Token = "0x4000BBA")]
  [FieldOffset(Offset = "0x10")]
  private float mStartValue;
  [Token(Token = "0x4000BBB")]
  [FieldOffset(Offset = "0x14")]
  private float mTargetValue;
  [Token(Token = "0x4000BBC")]
  [FieldOffset(Offset = "0x18")]
  private float mTime;
  [Token(Token = "0x4000BBD")]
  [FieldOffset(Offset = "0x1C")]
  private float mTransitionTime;

  [Token(Token = "0x6000EC0")]
  [Address(RVA = "0x11D9310", Offset = "0x11D8110", VA = "0x111D9310")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000EC1")]
  [Address(RVA = "0x11D9280", Offset = "0x11D8080", VA = "0x111D9280")]
  public void AnimateValue(float value, float time)
  {
  }

  [Token(Token = "0x6000EC2")]
  [Address(RVA = "0x11D9360", Offset = "0x11D8160", VA = "0x111D9360")]
  private void Update()
  {
  }

  [Token(Token = "0x170001C8")]
  public bool IsAnimating
  {
    [Token(Token = "0x6000EC3"), Address(RVA = "0xD63580", Offset = "0xD62380", VA = "0x10D63580")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x6000EC4")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public SliderAnimator()
  {
  }
}

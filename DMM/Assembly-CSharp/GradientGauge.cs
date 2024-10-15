// Decompiled with JetBrains decompiler
// Type: GradientGauge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20002B2")]
[RequireComponent(typeof (CanvasRenderer))]
public class GradientGauge : Image
{
  [Token(Token = "0x4000B32")]
  [FieldOffset(Offset = "0xB0")]
  public Color32[] Colors;
  [Token(Token = "0x4000B33")]
  [FieldOffset(Offset = "0xB4")]
  [Range(0.0f, 1f)]
  public float Value;
  [Token(Token = "0x4000B34")]
  [FieldOffset(Offset = "0xB8")]
  private float mStartValue;
  [Token(Token = "0x4000B35")]
  [FieldOffset(Offset = "0xBC")]
  private float mEndValue;
  [Token(Token = "0x4000B36")]
  [FieldOffset(Offset = "0xC0")]
  private float mAnimateTime;
  [Token(Token = "0x4000B37")]
  [FieldOffset(Offset = "0xC4")]
  private float mCurrentTime;

  [Token(Token = "0x6000E37")]
  [Address(RVA = "0x11D1E10", Offset = "0x11D0C10", VA = "0x111D1E10")]
  public void UpdateColors(Color32[] colors)
  {
  }

  [Token(Token = "0x6000E38")]
  [Address(RVA = "0x11D1E40", Offset = "0x11D0C40", VA = "0x111D1E40")]
  public void UpdateValue(float val)
  {
  }

  [Token(Token = "0x170001B5")]
  public bool IsAnimating
  {
    [Token(Token = "0x6000E39"), Address(RVA = "0x11D1FE0", Offset = "0x11D0DE0", VA = "0x111D1FE0")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x6000E3A")]
  [Address(RVA = "0x11D1410", Offset = "0x11D0210", VA = "0x111D1410")]
  public void AnimateRangedValue(long current, long maxValue, float time)
  {
  }

  [Token(Token = "0x6000E3B")]
  [Address(RVA = "0x11D14D0", Offset = "0x11D02D0", VA = "0x111D14D0")]
  public void AnimateValue(float newValue, float time)
  {
  }

  [Token(Token = "0x6000E3C")]
  [Address(RVA = "0x11D1E70", Offset = "0x11D0C70", VA = "0x111D1E70")]
  private void Update()
  {
  }

  [Token(Token = "0x6000E3D")]
  [Address(RVA = "0x11D1530", Offset = "0x11D0330", VA = "0x111D1530")]
  private Color32 ApplyBaseColor(Color32 c) => new Color32();

  [Token(Token = "0x6000E3E")]
  [Address(RVA = "0x11D15C0", Offset = "0x11D03C0", VA = "0x111D15C0", Slot = "44")]
  protected override void OnPopulateMesh(VertexHelper vh)
  {
  }

  [Token(Token = "0x6000E3F")]
  [Address(RVA = "0x11D1F30", Offset = "0x11D0D30", VA = "0x111D1F30")]
  public GradientGauge()
  {
  }

  [Token(Token = "0x20002B3")]
  public enum eColorType
  {
    [Token(Token = "0x4000B39")] NOW,
    [Token(Token = "0x4000B3A")] DIF,
  }
}

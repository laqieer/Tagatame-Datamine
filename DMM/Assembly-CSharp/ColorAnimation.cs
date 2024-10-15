// Decompiled with JetBrains decompiler
// Type: ColorAnimation
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000098")]
[AddComponentMenu("Common/ColorAnimation")]
public class ColorAnimation : MonoBehaviour
{
  [Token(Token = "0x40002EA")]
  [FieldOffset(Offset = "0xC")]
  public float Duration;
  [Token(Token = "0x40002EB")]
  [FieldOffset(Offset = "0x10")]
  public Color ColorStart;
  [Token(Token = "0x40002EC")]
  [FieldOffset(Offset = "0x20")]
  public Color ColorEnd;
  [Token(Token = "0x40002ED")]
  [FieldOffset(Offset = "0x30")]
  public ColorAnimation.AnimationTypes AnimationType;
  [Token(Token = "0x40002EE")]
  [FieldOffset(Offset = "0x34")]
  public Graphic Graphic;
  [Token(Token = "0x40002EF")]
  [FieldOffset(Offset = "0x38")]
  public AnimatorUpdateMode UpdateMode;
  [Token(Token = "0x40002F0")]
  [FieldOffset(Offset = "0x3C")]
  private float mAnimPos;
  [Token(Token = "0x40002F1")]
  [FieldOffset(Offset = "0x40")]
  private float mResetTime;

  [Token(Token = "0x60003BC")]
  [Address(RVA = "0xB82F20", Offset = "0xB81D20", VA = "0x10B82F20")]
  private void Update()
  {
  }

  [Token(Token = "0x60003BD")]
  [Address(RVA = "0xB82CF0", Offset = "0xB81AF0", VA = "0x10B82CF0")]
  private void UpdateColor()
  {
  }

  [Token(Token = "0x60003BE")]
  [Address(RVA = "0xB82CD0", Offset = "0xB81AD0", VA = "0x10B82CD0")]
  public void ResetTime()
  {
  }

  [Token(Token = "0x60003BF")]
  [Address(RVA = "0xB82C90", Offset = "0xB81A90", VA = "0x10B82C90")]
  public void ResetLoopAnimTime()
  {
  }

  [Token(Token = "0x60003C0")]
  [Address(RVA = "0xB82F30", Offset = "0xB81D30", VA = "0x10B82F30")]
  public ColorAnimation()
  {
  }

  [Token(Token = "0x2000099")]
  public enum AnimationTypes
  {
    [Token(Token = "0x40002F3")] Loop,
    [Token(Token = "0x40002F4")] PingPong,
    [Token(Token = "0x40002F5")] Once,
  }
}

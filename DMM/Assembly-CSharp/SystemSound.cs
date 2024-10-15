// Decompiled with JetBrains decompiler
// Type: SystemSound
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x200016E")]
[AddComponentMenu("Audio/System Sound")]
public class SystemSound : MonoBehaviour
{
  [Token(Token = "0x40006E7")]
  [FieldOffset(Offset = "0xC")]
  public SystemSound.ECue Cue;

  [Token(Token = "0x6000969")]
  [Address(RVA = "0xF50170", Offset = "0xF4EF70", VA = "0x10F50170")]
  public static void Play(SystemSound.ECue cue)
  {
  }

  [Token(Token = "0x600096A")]
  [Address(RVA = "0xF502C0", Offset = "0xF4F0C0", VA = "0x10F502C0")]
  public void Play()
  {
  }

  [Token(Token = "0x600096B")]
  [Address(RVA = "0xF500D0", Offset = "0xF4EED0", VA = "0x10F500D0")]
  public void PlayOnToggleValueChangedToTrue(bool value)
  {
  }

  [Token(Token = "0x600096C")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public SystemSound()
  {
  }

  [Token(Token = "0x200016F")]
  public enum ECue
  {
    [Token(Token = "0x40006E9")] Tap,
    [Token(Token = "0x40006EA")] OK,
    [Token(Token = "0x40006EB")] Cancel,
    [Token(Token = "0x40006EC")] Select,
    [Token(Token = "0x40006ED")] Buzzer,
    [Token(Token = "0x40006EE")] Swipe,
    [Token(Token = "0x40006EF")] ScrollList,
    [Token(Token = "0x40006F0")] WindowPop,
    [Token(Token = "0x40006F1")] WindowClose,
  }
}

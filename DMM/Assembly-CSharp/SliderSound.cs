// Decompiled with JetBrains decompiler
// Type: SliderSound
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000162")]
[AddComponentMenu("Audio/Slider Sound")]
public class SliderSound : MonoBehaviour
{
  [Token(Token = "0x40006BB")]
  [FieldOffset(Offset = "0xC")]
  public string cueID;
  [Token(Token = "0x40006BC")]
  [FieldOffset(Offset = "0x10")]
  public float WaitSec;
  [Token(Token = "0x40006BD")]
  [FieldOffset(Offset = "0x14")]
  private float mWait;
  [Token(Token = "0x40006BE")]
  [FieldOffset(Offset = "0x18")]
  private float mPrevValue;
  [Token(Token = "0x40006BF")]
  [FieldOffset(Offset = "0x1C")]
  private Slider mSlider;

  [Token(Token = "0x600093F")]
  [Address(RVA = "0xE61950", Offset = "0xE60750", VA = "0x10E61950")]
  private void Start()
  {
  }

  [Token(Token = "0x6000940")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x6000941")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x6000942")]
  [Address(RVA = "0xE61A00", Offset = "0xE60800", VA = "0x10E61A00")]
  private void Update()
  {
  }

  [Token(Token = "0x6000943")]
  [Address(RVA = "0xE617E0", Offset = "0xE605E0", VA = "0x10E617E0")]
  public void OnValueChanged()
  {
  }

  [Token(Token = "0x6000944")]
  [Address(RVA = "0xE618F0", Offset = "0xE606F0", VA = "0x10E618F0")]
  public void Play()
  {
  }

  [Token(Token = "0x6000945")]
  [Address(RVA = "0xE61A30", Offset = "0xE60830", VA = "0x10E61A30")]
  public SliderSound()
  {
  }
}

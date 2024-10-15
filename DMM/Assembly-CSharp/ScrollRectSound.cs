// Decompiled with JetBrains decompiler
// Type: ScrollRectSound
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000148")]
[AddComponentMenu("Audio/ScrollRect Sound")]
public class ScrollRectSound : MonoBehaviour
{
  [Token(Token = "0x400064F")]
  [FieldOffset(Offset = "0xC")]
  public string cueID;
  [Token(Token = "0x4000650")]
  [FieldOffset(Offset = "0x10")]
  private Vector2 mPos;
  [Token(Token = "0x4000651")]
  [FieldOffset(Offset = "0x18")]
  private Vector2 mPosDif;
  [Token(Token = "0x4000652")]
  [FieldOffset(Offset = "0x20")]
  private float mWait;
  [Token(Token = "0x4000653")]
  [FieldOffset(Offset = "0x24")]
  private bool mInitPos;
  [Token(Token = "0x4000654")]
  [FieldOffset(Offset = "0x28")]
  private IntVector2 mPosID;

  [Token(Token = "0x6000800")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000801")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x6000802")]
  [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x6000803")]
  [Address(RVA = "0xE52690", Offset = "0xE51490", VA = "0x10E52690")]
  private void Update()
  {
  }

  [Token(Token = "0x6000804")]
  [Address(RVA = "0xE51DB0", Offset = "0xE50BB0", VA = "0x10E51DB0")]
  public void OnValueChanged()
  {
  }

  [Token(Token = "0x6000805")]
  [Address(RVA = "0xE52580", Offset = "0xE51380", VA = "0x10E52580")]
  public void Play()
  {
  }

  [Token(Token = "0x6000806")]
  [Address(RVA = "0xE525E0", Offset = "0xE513E0", VA = "0x10E525E0")]
  public void Reset()
  {
  }

  [Token(Token = "0x6000807")]
  [Address(RVA = "0xE526C0", Offset = "0xE514C0", VA = "0x10E526C0")]
  public ScrollRectSound()
  {
  }
}

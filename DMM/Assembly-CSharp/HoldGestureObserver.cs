// Decompiled with JetBrains decompiler
// Type: HoldGestureObserver
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20000FF")]
[AddComponentMenu("Common/HoldGestureObserver")]
internal class HoldGestureObserver : MonoBehaviour
{
  [Token(Token = "0x40004C3")]
  [FieldOffset(Offset = "0x0")]
  private static HoldGestureObserver mInstance;
  [Token(Token = "0x40004C4")]
  [FieldOffset(Offset = "0xC")]
  private IHoldGesture mReceiver;
  [Token(Token = "0x40004C5")]
  [FieldOffset(Offset = "0x10")]
  private float mPressTime;
  [Token(Token = "0x40004C6")]
  [FieldOffset(Offset = "0x14")]
  private bool mTriggered;
  [Token(Token = "0x40004C7")]
  [FieldOffset(Offset = "0x18")]
  private Vector2 mPressStart;
  [Token(Token = "0x40004C8")]
  [FieldOffset(Offset = "0x20")]
  private float mDragDist;
  [Token(Token = "0x40004C9")]
  [FieldOffset(Offset = "0x24")]
  private Vector2 mOldPosition;

  [Token(Token = "0x17000107")]
  private static HoldGestureObserver Instance
  {
    [Token(Token = "0x600069A"), Address(RVA = "0xD58A50", Offset = "0xD57850", VA = "0x10D58A50")] get
    {
      return (HoldGestureObserver) null;
    }
  }

  [Token(Token = "0x600069B")]
  [Address(RVA = "0xD58650", Offset = "0xD57450", VA = "0x10D58650")]
  public static void StartHoldGesture(IHoldGesture receiver)
  {
  }

  [Token(Token = "0x600069C")]
  [Address(RVA = "0xD587A0", Offset = "0xD575A0", VA = "0x10D587A0")]
  private void Start()
  {
  }

  [Token(Token = "0x600069D")]
  [Address(RVA = "0xD58800", Offset = "0xD57600", VA = "0x10D58800")]
  private void Update()
  {
  }

  [Token(Token = "0x600069E")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public HoldGestureObserver()
  {
  }
}

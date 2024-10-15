// Decompiled with JetBrains decompiler
// Type: AdjustRectPos
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000286")]
[AddComponentMenu("UI/AdjustRectPos")]
public class AdjustRectPos : MonoBehaviour
{
  [Token(Token = "0x4000A99")]
  [FieldOffset(Offset = "0xC")]
  [SerializeField]
  private Vector3 SetOffsetPos;
  [Token(Token = "0x4000A9A")]
  [FieldOffset(Offset = "0x18")]
  private Rect lastSafeArea;
  [Token(Token = "0x4000A9B")]
  [FieldOffset(Offset = "0x28")]
  private Vector3 initPos;
  [Token(Token = "0x4000A9C")]
  [FieldOffset(Offset = "0x34")]
  private Vector3 lastSetOffsetPos;

  [Token(Token = "0x6000D7F")]
  [Address(RVA = "0x11CA830", Offset = "0x11C9630", VA = "0x111CA830")]
  private void Start()
  {
  }

  [Token(Token = "0x6000D80")]
  [Address(RVA = "0x11CA6D0", Offset = "0x11C94D0", VA = "0x111CA6D0")]
  private void ApplySafeAreaPos(Rect area)
  {
  }

  [Token(Token = "0x6000D81")]
  [Address(RVA = "0x11CAA70", Offset = "0x11C9870", VA = "0x111CAA70")]
  public AdjustRectPos()
  {
  }
}

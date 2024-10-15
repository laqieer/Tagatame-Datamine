// Decompiled with JetBrains decompiler
// Type: AdjustRectScale
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000287")]
[AddComponentMenu("UI/AdjustRectScale")]
public class AdjustRectScale : MonoBehaviour
{
  [Token(Token = "0x4000A9D")]
  [FieldOffset(Offset = "0xC")]
  [SerializeField]
  private float SetScale;
  [Token(Token = "0x4000A9E")]
  [FieldOffset(Offset = "0x10")]
  private Rect lastSafeArea;
  [Token(Token = "0x4000A9F")]
  [FieldOffset(Offset = "0x20")]
  private Vector3 initScale;
  [Token(Token = "0x4000AA0")]
  [FieldOffset(Offset = "0x2C")]
  private float lastSetScale;

  [Token(Token = "0x6000D82")]
  [Address(RVA = "0x11CAC80", Offset = "0x11C9A80", VA = "0x111CAC80")]
  private void Start()
  {
  }

  [Token(Token = "0x6000D83")]
  [Address(RVA = "0x11CAB70", Offset = "0x11C9970", VA = "0x111CAB70")]
  private void ApplySafeAreaScale(Rect area)
  {
  }

  [Token(Token = "0x6000D84")]
  [Address(RVA = "0x11CAE40", Offset = "0x11C9C40", VA = "0x111CAE40")]
  public AdjustRectScale()
  {
  }
}

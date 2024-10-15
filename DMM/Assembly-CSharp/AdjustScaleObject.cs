// Decompiled with JetBrains decompiler
// Type: AdjustScaleObject
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000288")]
[AddComponentMenu("UI/AdjustScaleObject")]
public class AdjustScaleObject : MonoBehaviour
{
  [Token(Token = "0x4000AA1")]
  [FieldOffset(Offset = "0xC")]
  [SerializeField]
  private float SetPower;
  [Token(Token = "0x4000AA2")]
  [FieldOffset(Offset = "0x10")]
  private Rect lastSafeArea;
  [Token(Token = "0x4000AA3")]
  [FieldOffset(Offset = "0x20")]
  private Vector3 initScale;
  [Token(Token = "0x4000AA4")]
  [FieldOffset(Offset = "0x2C")]
  private float lastSetPower;

  [Token(Token = "0x6000D85")]
  [Address(RVA = "0x11CAFC0", Offset = "0x11C9DC0", VA = "0x111CAFC0")]
  private void Start()
  {
  }

  [Token(Token = "0x6000D86")]
  [Address(RVA = "0x11CAEE0", Offset = "0x11C9CE0", VA = "0x111CAEE0")]
  private void ApplySafeAreaScale(Rect area)
  {
  }

  [Token(Token = "0x6000D87")]
  [Address(RVA = "0x11CAE40", Offset = "0x11C9C40", VA = "0x111CAE40")]
  public AdjustScaleObject()
  {
  }
}

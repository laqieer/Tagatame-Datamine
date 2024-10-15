// Decompiled with JetBrains decompiler
// Type: SyncSize
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x20002D9")]
[DisallowMultipleComponent]
[AddComponentMenu("UI/SyncSize")]
public class SyncSize : MonoBehaviour
{
  [Token(Token = "0x4000BCE")]
  [FieldOffset(Offset = "0xC")]
  public RectTransform Source;
  [Token(Token = "0x4000BCF")]
  [FieldOffset(Offset = "0x10")]
  public float ExtraW;
  [Token(Token = "0x4000BD0")]
  [FieldOffset(Offset = "0x14")]
  public float ExtraH;
  [Token(Token = "0x4000BD1")]
  [FieldOffset(Offset = "0x18")]
  private float mLastWidth;
  [Token(Token = "0x4000BD2")]
  [FieldOffset(Offset = "0x1C")]
  private float mLastHeight;
  [Token(Token = "0x4000BD3")]
  [FieldOffset(Offset = "0x20")]
  private RectTransform mRect;

  [Token(Token = "0x6000EDA")]
  [Address(RVA = "0x11DAA50", Offset = "0x11D9850", VA = "0x111DAA50")]
  private void Start()
  {
  }

  [Token(Token = "0x6000EDB")]
  [Address(RVA = "0x11DAA40", Offset = "0x11D9840", VA = "0x111DAA40")]
  private void LateUpdate()
  {
  }

  [Token(Token = "0x6000EDC")]
  [Address(RVA = "0x11DAAC0", Offset = "0x11D98C0", VA = "0x111DAAC0")]
  private void Sync()
  {
  }

  [Token(Token = "0x6000EDD")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public SyncSize()
  {
  }
}

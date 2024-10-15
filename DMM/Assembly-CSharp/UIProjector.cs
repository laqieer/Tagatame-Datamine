// Decompiled with JetBrains decompiler
// Type: UIProjector
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000183")]
[AddComponentMenu("UI/Link UI Position")]
public class UIProjector : MonoBehaviour
{
  [Token(Token = "0x4000755")]
  [FieldOffset(Offset = "0xC")]
  public Camera ProjectCamera;
  [Token(Token = "0x4000756")]
  [FieldOffset(Offset = "0x10")]
  public RectTransform UIObject;
  [Token(Token = "0x4000757")]
  [FieldOffset(Offset = "0x14")]
  public string UIObjectID;
  [Token(Token = "0x4000758")]
  [FieldOffset(Offset = "0x18")]
  private Canvas mCanvas;
  [Token(Token = "0x4000759")]
  [FieldOffset(Offset = "0x1C")]
  public bool AutoDestroyUIObject;
  [Token(Token = "0x400075A")]
  [FieldOffset(Offset = "0x20")]
  public Vector3 LocalOffset;

  [Token(Token = "0x6000998")]
  [Address(RVA = "0xF53AF0", Offset = "0xF528F0", VA = "0x10F53AF0")]
  public void SetCanvas(Canvas canvas)
  {
  }

  [Token(Token = "0x6000999")]
  [Address(RVA = "0xF53530", Offset = "0xF52330", VA = "0x10F53530", Slot = "4")]
  protected virtual void Awake()
  {
  }

  [Token(Token = "0x600099A")]
  [Address(RVA = "0xF53BB0", Offset = "0xF529B0", VA = "0x10F53BB0", Slot = "5")]
  protected virtual void Start()
  {
  }

  [Token(Token = "0x600099B")]
  [Address(RVA = "0xF53580", Offset = "0xF52380", VA = "0x10F53580", Slot = "6")]
  protected virtual void OnDestroy()
  {
  }

  [Token(Token = "0x600099C")]
  [Address(RVA = "0xF53640", Offset = "0xF52440", VA = "0x10F53640")]
  public void PreCull(Camera camera)
  {
  }

  [Token(Token = "0x600099D")]
  [Address(RVA = "0xF53AD0", Offset = "0xF528D0", VA = "0x10F53AD0")]
  public void ReStart()
  {
  }

  [Token(Token = "0x600099E")]
  [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
  public UIProjector()
  {
  }
}

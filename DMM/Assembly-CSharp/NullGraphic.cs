// Decompiled with JetBrains decompiler
// Type: NullGraphic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20002C3")]
[ExecuteInEditMode]
[AddComponentMenu("UI/NullGraphic")]
[RequireComponent(typeof (CanvasRenderer))]
public class NullGraphic : Graphic
{
  [Token(Token = "0x6000E75")]
  [Address(RVA = "0x11D5D60", Offset = "0x11D4B60", VA = "0x111D5D60", Slot = "44")]
  protected override void OnPopulateMesh(VertexHelper vh)
  {
  }

  [Token(Token = "0x6000E76")]
  [Address(RVA = "0x11D5D80", Offset = "0x11D4B80", VA = "0x111D5D80")]
  public NullGraphic()
  {
  }
}

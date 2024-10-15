// Decompiled with JetBrains decompiler
// Type: KuroObi
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20002B9")]
[ExecuteInEditMode]
[RequireComponent(typeof (CanvasRenderer))]
[AddComponentMenu("UI/KuroObi")]
public class KuroObi : Graphic
{
  [Token(Token = "0x6000E51")]
  [Address(RVA = "0x11D2FB0", Offset = "0x11D1DB0", VA = "0x111D2FB0")]
  public static float CalcObiSize() => new float();

  [Token(Token = "0x6000E52")]
  [Address(RVA = "0x11D3430", Offset = "0x11D2230", VA = "0x111D3430", Slot = "46")]
  public override bool Raycast(Vector2 sp, Camera eventCamera) => new bool();

  [Token(Token = "0x6000E53")]
  [Address(RVA = "0x11D3060", Offset = "0x11D1E60", VA = "0x111D3060", Slot = "44")]
  protected override void OnPopulateMesh(VertexHelper vh)
  {
  }

  [Token(Token = "0x6000E54")]
  [Address(RVA = "0x11D3540", Offset = "0x11D2340", VA = "0x111D3540")]
  public KuroObi()
  {
  }
}

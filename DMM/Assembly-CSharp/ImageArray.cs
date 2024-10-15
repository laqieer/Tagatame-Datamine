// Decompiled with JetBrains decompiler
// Type: ImageArray
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x20002B5")]
[AddComponentMenu("UI/ImageArray")]
public class ImageArray : Image
{
  [Token(Token = "0x4000B3F")]
  [FieldOffset(Offset = "0xB0")]
  public Sprite[] Images;
  [Token(Token = "0x4000B40")]
  [FieldOffset(Offset = "0xB4")]
  private int mImageIndex;

  [Token(Token = "0x170001B6")]
  public int ImageIndex
  {
    [Token(Token = "0x6000E43"), Address(RVA = "0x305C10", Offset = "0x304A10", VA = "0x10305C10")] get
    {
      return new int();
    }
    [Token(Token = "0x6000E44"), Address(RVA = "0x11D27D0", Offset = "0x11D15D0", VA = "0x111D27D0")] set
    {
    }
  }

  [Token(Token = "0x6000E45")]
  [Address(RVA = "0x11D26E0", Offset = "0x11D14E0", VA = "0x111D26E0", Slot = "44")]
  protected override void OnPopulateMesh(VertexHelper toFill)
  {
  }

  [Token(Token = "0x6000E46")]
  [Address(RVA = "0x11D2760", Offset = "0x11D1560", VA = "0x111D2760")]
  public ImageArray()
  {
  }
}

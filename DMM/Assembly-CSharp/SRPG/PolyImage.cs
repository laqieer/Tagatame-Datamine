// Decompiled with JetBrains decompiler
// Type: SRPG.PolyImage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002850")]
  public class PolyImage : Image
  {
    [Token(Token = "0x400C071")]
    [FieldOffset(Offset = "0xB0")]
    public Quad[] Quads;
    [Token(Token = "0x400C072")]
    [FieldOffset(Offset = "0xB4")]
    public bool Transparent;
    [Token(Token = "0x400C073")]
    [FieldOffset(Offset = "0xB8")]
    private RectTransform mRectTransform;

    [Token(Token = "0x600B5FB")]
    [Address(RVA = "0x7C4E00", Offset = "0x7C3C00", VA = "0x107C4E00", Slot = "4")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x600B5FC")]
    [Address(RVA = "0x7C4E60", Offset = "0x7C3C60", VA = "0x107C4E60", Slot = "44")]
    protected override void OnPopulateMesh(VertexHelper vh)
    {
    }

    [Token(Token = "0x600B5FD")]
    [Address(RVA = "0x7C6440", Offset = "0x7C5240", VA = "0x107C6440")]
    public PolyImage()
    {
    }
  }
}

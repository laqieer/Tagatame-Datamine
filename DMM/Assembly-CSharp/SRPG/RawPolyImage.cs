// Decompiled with JetBrains decompiler
// Type: SRPG.RawPolyImage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200292E")]
  public class RawPolyImage : RawImage
  {
    [Token(Token = "0x400C659")]
    [FieldOffset(Offset = "0x94")]
    public Quad[] Quads;
    [Token(Token = "0x400C65A")]
    [FieldOffset(Offset = "0x98")]
    public bool Transparent;
    [Token(Token = "0x400C65B")]
    [FieldOffset(Offset = "0x9C")]
    public string Preview;
    [Token(Token = "0x400C65C")]
    [FieldOffset(Offset = "0xA0")]
    private RectTransform mRectTransform;

    [Token(Token = "0x600BA49")]
    [Address(RVA = "0x81A290", Offset = "0x819090", VA = "0x1081A290", Slot = "4")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x600BA4A")]
    [Address(RVA = "0x81A2F0", Offset = "0x8190F0", VA = "0x1081A2F0", Slot = "44")]
    protected override void OnPopulateMesh(VertexHelper vh)
    {
    }

    [Token(Token = "0x600BA4B")]
    [Address(RVA = "0x81B710", Offset = "0x81A510", VA = "0x1081B710")]
    public RawPolyImage()
    {
    }
  }
}

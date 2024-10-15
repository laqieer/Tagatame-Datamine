// Decompiled with JetBrains decompiler
// Type: SRPG.ClampSize
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200219C")]
  [ExecuteInEditMode]
  [AddComponentMenu("UI/ClampSize")]
  public class ClampSize : UIBehaviour
  {
    [Token(Token = "0x40092D2")]
    [FieldOffset(Offset = "0xC")]
    private RectTransform mTransform;
    [Token(Token = "0x40092D3")]
    [FieldOffset(Offset = "0x10")]
    public RectTransform Target;
    [Token(Token = "0x40092D4")]
    [FieldOffset(Offset = "0x14")]
    public bool ClampX;
    [Token(Token = "0x40092D5")]
    [FieldOffset(Offset = "0x18")]
    public float XSize;
    [Token(Token = "0x40092D6")]
    [FieldOffset(Offset = "0x1C")]
    public float XMargin;
    [Token(Token = "0x40092D7")]
    [FieldOffset(Offset = "0x20")]
    public float XPadding;
    [Token(Token = "0x40092D8")]
    [FieldOffset(Offset = "0x24")]
    public bool ClampY;
    [Token(Token = "0x40092D9")]
    [FieldOffset(Offset = "0x28")]
    public float YSize;
    [Token(Token = "0x40092DA")]
    [FieldOffset(Offset = "0x2C")]
    public float YMargin;
    [Token(Token = "0x40092DB")]
    [FieldOffset(Offset = "0x30")]
    public float YPadding;

    [Token(Token = "0x6008D40")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0", Slot = "4")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x6008D41")]
    [Address(RVA = "0x50DA30", Offset = "0x50C830", VA = "0x1050DA30", Slot = "10")]
    protected override void OnRectTransformDimensionsChange()
    {
    }

    [Token(Token = "0x6008D42")]
    [Address(RVA = "0x50DA50", Offset = "0x50C850", VA = "0x1050DA50")]
    public void Resize()
    {
    }

    [Token(Token = "0x6008D43")]
    [Address(RVA = "0x50DCC0", Offset = "0x50CAC0", VA = "0x1050DCC0")]
    public ClampSize()
    {
    }
  }
}

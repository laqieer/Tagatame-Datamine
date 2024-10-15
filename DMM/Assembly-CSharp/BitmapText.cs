// Decompiled with JetBrains decompiler
// Type: BitmapText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;
using UnityEngine.UI;

#nullable disable
[Token(Token = "0x2000292")]
public class BitmapText : Text
{
  [Token(Token = "0x4000ABB")]
  [FieldOffset(Offset = "0x98")]
  public BitmapText.FontScale AutoSize;
  [Token(Token = "0x4000ABC")]
  [FieldOffset(Offset = "0xA8")]
  private bool mDelayUpdate;

  [Token(Token = "0x1700019A")]
  public override Material defaultMaterial
  {
    [Token(Token = "0x6000DAE"), Address(RVA = "0x11CC240", Offset = "0x11CB040", VA = "0x111CC240", Slot = "31")] get
    {
      return (Material) null;
    }
  }

  [Token(Token = "0x6000DAF")]
  [Address(RVA = "0x11CBF20", Offset = "0x11CAD20", VA = "0x111CBF20")]
  private void ResizeFont()
  {
  }

  [Token(Token = "0x6000DB0")]
  [Address(RVA = "0x11CC000", Offset = "0x11CAE00", VA = "0x111CC000", Slot = "6")]
  protected override void Start()
  {
  }

  [Token(Token = "0x6000DB1")]
  [Address(RVA = "0x11CC020", Offset = "0x11CAE20", VA = "0x111CC020")]
  private void Update()
  {
  }

  [Token(Token = "0x6000DB2")]
  [Address(RVA = "0x11CBF10", Offset = "0x11CAD10", VA = "0x111CBF10", Slot = "12")]
  protected override void OnTransformParentChanged()
  {
  }

  [Token(Token = "0x1700019B")]
  public override string text
  {
    [Token(Token = "0x6000DB3"), Address(RVA = "0x2B6020", Offset = "0x2B4E20", VA = "0x102B6020", Slot = "74")] get
    {
      return (string) null;
    }
    [Token(Token = "0x6000DB4"), Address(RVA = "0x11CC280", Offset = "0x11CB080", VA = "0x111CC280", Slot = "75")] set
    {
    }
  }

  [Token(Token = "0x1700019C")]
  private bool IsParentCanvasActive
  {
    [Token(Token = "0x6000DB5"), Address(RVA = "0x11CC080", Offset = "0x11CAE80", VA = "0x111CC080")] get
    {
      return new bool();
    }
  }

  [Token(Token = "0x6000DB6")]
  [Address(RVA = "0x71F360", Offset = "0x71E160", VA = "0x1071F360")]
  public BitmapText()
  {
  }

  [Token(Token = "0x2000293")]
  [Serializable]
  public struct FontScale
  {
    [Token(Token = "0x4000ABD")]
    [FieldOffset(Offset = "0x0")]
    public int CountMin;
    [Token(Token = "0x4000ABE")]
    [FieldOffset(Offset = "0x4")]
    public int SizeMin;
    [Token(Token = "0x4000ABF")]
    [FieldOffset(Offset = "0x8")]
    public int CountMax;
    [Token(Token = "0x4000AC0")]
    [FieldOffset(Offset = "0xC")]
    public int SizeMax;
  }
}

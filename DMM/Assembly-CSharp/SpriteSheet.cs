// Decompiled with JetBrains decompiler
// Type: SpriteSheet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
[Token(Token = "0x2000164")]
public class SpriteSheet : ScriptableObject
{
  [Token(Token = "0x40006C1")]
  [FieldOffset(Offset = "0xC")]
  public SpriteSheet.Item[] Items;
  [Token(Token = "0x40006C2")]
  [FieldOffset(Offset = "0x10")]
  [NonSerialized]
  public bool Dirty;

  [Token(Token = "0x6000949")]
  [Address(RVA = "0xE61AF0", Offset = "0xE608F0", VA = "0x10E61AF0")]
  public Sprite GetSprite(string name) => (Sprite) null;

  [Token(Token = "0x600094A")]
  [Address(RVA = "0xE61C20", Offset = "0xE60A20", VA = "0x10E61C20")]
  private void RecalcHashCodes()
  {
  }

  [Token(Token = "0x600094B")]
  [Address(RVA = "0xE61C90", Offset = "0xE60A90", VA = "0x10E61C90")]
  public SpriteSheet()
  {
  }

  [Token(Token = "0x2000165")]
  [Serializable]
  public struct Item
  {
    [Token(Token = "0x40006C3")]
    [FieldOffset(Offset = "0x0")]
    public string n;
    [Token(Token = "0x40006C4")]
    [FieldOffset(Offset = "0x4")]
    public Sprite s;
    [Token(Token = "0x40006C5")]
    [FieldOffset(Offset = "0x8")]
    [NonSerialized]
    public int h;
  }
}

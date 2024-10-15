// Decompiled with JetBrains decompiler
// Type: SRPG.AppealSprites
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E45")]
  public class AppealSprites : ScriptableObject
  {
    [Token(Token = "0x4002B68")]
    [FieldOffset(Offset = "0xC")]
    public AppealSprites.Item[] Items;
    [Token(Token = "0x4002B69")]
    [FieldOffset(Offset = "0x10")]
    private bool Dirty;

    [Token(Token = "0x6003AEB")]
    [Address(RVA = "0xE61AF0", Offset = "0xE608F0", VA = "0x10E61AF0")]
    public Sprite GetSprite(string id) => (Sprite) null;

    [Token(Token = "0x6003AEC")]
    [Address(RVA = "0xE61C20", Offset = "0xE60A20", VA = "0x10E61C20")]
    private void RecalcHashCodes()
    {
    }

    [Token(Token = "0x6003AED")]
    [Address(RVA = "0x10CC570", Offset = "0x10CB370", VA = "0x110CC570")]
    public AppealSprites()
    {
    }

    [Token(Token = "0x2000E46")]
    [Serializable]
    public struct Item
    {
      [Token(Token = "0x4002B6A")]
      [FieldOffset(Offset = "0x0")]
      public string ID;
      [Token(Token = "0x4002B6B")]
      [FieldOffset(Offset = "0x4")]
      public Sprite Sprite;
      [Token(Token = "0x4002B6C")]
      [FieldOffset(Offset = "0x8")]
      [NonSerialized]
      public int hash;
    }
  }
}

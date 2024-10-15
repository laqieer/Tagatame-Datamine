// Decompiled with JetBrains decompiler
// Type: SRPG.AppealBallonSprites
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E43")]
  public class AppealBallonSprites : ScriptableObject
  {
    [Token(Token = "0x4002B61")]
    [FieldOffset(Offset = "0xC")]
    public AppealBallonSprites.Item[] Items;
    [Token(Token = "0x4002B62")]
    [FieldOffset(Offset = "0x10")]
    private bool Dirty;

    [Token(Token = "0x6003AE5")]
    [Address(RVA = "0x10CC220", Offset = "0x10CB020", VA = "0x110CC220")]
    public Sprite GetSprite(string id) => (Sprite) null;

    [Token(Token = "0x6003AE6")]
    [Address(RVA = "0x10CC0A0", Offset = "0x10CAEA0", VA = "0x110CC0A0")]
    public Sprite GetSpriteTextL(string id) => (Sprite) null;

    [Token(Token = "0x6003AE7")]
    [Address(RVA = "0x10CC160", Offset = "0x10CAF60", VA = "0x110CC160")]
    public Sprite GetSpriteTextR(string id) => (Sprite) null;

    [Token(Token = "0x6003AE8")]
    [Address(RVA = "0x10CC2E0", Offset = "0x10CB0E0", VA = "0x110CC2E0")]
    public Sprite[] GetSprites(string id) => (Sprite[]) null;

    [Token(Token = "0x6003AE9")]
    [Address(RVA = "0x10CC4B0", Offset = "0x10CB2B0", VA = "0x110CC4B0")]
    private void RecalcHashCodes()
    {
    }

    [Token(Token = "0x6003AEA")]
    [Address(RVA = "0x10CC520", Offset = "0x10CB320", VA = "0x110CC520")]
    public AppealBallonSprites()
    {
    }

    [Token(Token = "0x2000E44")]
    [Serializable]
    public struct Item
    {
      [Token(Token = "0x4002B63")]
      [FieldOffset(Offset = "0x0")]
      public string ID;
      [Token(Token = "0x4002B64")]
      [FieldOffset(Offset = "0x4")]
      public Sprite CharSprite;
      [Token(Token = "0x4002B65")]
      [FieldOffset(Offset = "0x8")]
      public Sprite TextLSprite;
      [Token(Token = "0x4002B66")]
      [FieldOffset(Offset = "0xC")]
      public Sprite TextRSprite;
      [Token(Token = "0x4002B67")]
      [FieldOffset(Offset = "0x10")]
      [NonSerialized]
      public int hash;
    }
  }
}

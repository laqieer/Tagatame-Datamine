// Decompiled with JetBrains decompiler
// Type: SRPG.ShopText
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002AB3")]
  [AddComponentMenu("UI/ShopText")]
  public class ShopText : MonoBehaviour
  {
    [Token(Token = "0x400D047")]
    [FieldOffset(Offset = "0xC")]
    public string Normal;
    [Token(Token = "0x400D048")]
    [FieldOffset(Offset = "0x10")]
    public string Tabi;
    [Token(Token = "0x400D049")]
    [FieldOffset(Offset = "0x14")]
    public string Kimagure;
    [Token(Token = "0x400D04A")]
    [FieldOffset(Offset = "0x18")]
    public string Monozuki;
    [Token(Token = "0x400D04B")]
    [FieldOffset(Offset = "0x1C")]
    public string Tour;
    [Token(Token = "0x400D04C")]
    [FieldOffset(Offset = "0x20")]
    public string Arena;
    [Token(Token = "0x400D04D")]
    [FieldOffset(Offset = "0x24")]
    public string Multi;
    [Token(Token = "0x400D04E")]
    [FieldOffset(Offset = "0x28")]
    public string AwakePiece;
    [Token(Token = "0x400D04F")]
    [FieldOffset(Offset = "0x2C")]
    public string Artifact;
    [Token(Token = "0x400D050")]
    [FieldOffset(Offset = "0x30")]
    public string Limited;
    [Token(Token = "0x400D051")]
    [FieldOffset(Offset = "0x34")]
    public string Port;
    [Token(Token = "0x400D052")]
    [FieldOffset(Offset = "0x38")]
    private string mTextID;

    [Token(Token = "0x600C30C")]
    [Address(RVA = "0x8B6E70", Offset = "0x8B5C70", VA = "0x108B6E70")]
    private void LateUpdate()
    {
    }

    [Token(Token = "0x600C30D")]
    [Address(RVA = "0x2ACF80", Offset = "0x2ABD80", VA = "0x102ACF80")]
    public ShopText()
    {
    }
  }
}

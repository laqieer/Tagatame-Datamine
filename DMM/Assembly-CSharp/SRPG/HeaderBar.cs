// Decompiled with JetBrains decompiler
// Type: SRPG.HeaderBar
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200113E")]
  public class HeaderBar : PropertyAttribute
  {
    [Token(Token = "0x4003ED0")]
    [FieldOffset(Offset = "0xC")]
    public string Text;
    [Token(Token = "0x4003ED1")]
    [FieldOffset(Offset = "0x10")]
    public Color BGColor;
    [Token(Token = "0x4003ED2")]
    [FieldOffset(Offset = "0x20")]
    public Color FGColor;

    [Token(Token = "0x60049DB")]
    [Address(RVA = "0x11FF3B0", Offset = "0x11FE1B0", VA = "0x111FF3B0")]
    public HeaderBar(string text)
    {
    }

    [Token(Token = "0x60049DC")]
    [Address(RVA = "0x11FF3F0", Offset = "0x11FE1F0", VA = "0x111FF3F0")]
    public HeaderBar(string text, Color bg)
    {
    }

    [Token(Token = "0x60049DD")]
    [Address(RVA = "0x11FF370", Offset = "0x11FE170", VA = "0x111FF370")]
    public HeaderBar(string text, Color bg, Color fg)
    {
    }
  }
}

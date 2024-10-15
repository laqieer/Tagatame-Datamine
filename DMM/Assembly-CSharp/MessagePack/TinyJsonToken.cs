// Decompiled with JetBrains decompiler
// Type: MessagePack.TinyJsonToken
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack
{
  [Token(Token = "0x2000352")]
  internal enum TinyJsonToken
  {
    [Token(Token = "0x4000D33")] None,
    [Token(Token = "0x4000D34")] StartObject,
    [Token(Token = "0x4000D35")] EndObject,
    [Token(Token = "0x4000D36")] StartArray,
    [Token(Token = "0x4000D37")] EndArray,
    [Token(Token = "0x4000D38")] Number,
    [Token(Token = "0x4000D39")] String,
    [Token(Token = "0x4000D3A")] True,
    [Token(Token = "0x4000D3B")] False,
    [Token(Token = "0x4000D3C")] Null,
  }
}

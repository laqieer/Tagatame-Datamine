// Decompiled with JetBrains decompiler
// Type: MessagePack.MessagePackType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack
{
  [Token(Token = "0x200035F")]
  public enum MessagePackType : byte
  {
    [Token(Token = "0x4000D7F")] Unknown,
    [Token(Token = "0x4000D80")] Integer,
    [Token(Token = "0x4000D81")] Nil,
    [Token(Token = "0x4000D82")] Boolean,
    [Token(Token = "0x4000D83")] Float,
    [Token(Token = "0x4000D84")] String,
    [Token(Token = "0x4000D85")] Binary,
    [Token(Token = "0x4000D86")] Array,
    [Token(Token = "0x4000D87")] Map,
    [Token(Token = "0x4000D88")] Extension,
  }
}

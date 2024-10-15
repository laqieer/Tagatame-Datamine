// Decompiled with JetBrains decompiler
// Type: MessagePack.ValueType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack
{
  [Token(Token = "0x2000353")]
  internal enum ValueType : byte
  {
    [Token(Token = "0x4000D3E")] Null,
    [Token(Token = "0x4000D3F")] True,
    [Token(Token = "0x4000D40")] False,
    [Token(Token = "0x4000D41")] Double,
    [Token(Token = "0x4000D42")] Long,
    [Token(Token = "0x4000D43")] ULong,
    [Token(Token = "0x4000D44")] Decimal,
    [Token(Token = "0x4000D45")] String,
  }
}

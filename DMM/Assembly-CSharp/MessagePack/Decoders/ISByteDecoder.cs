// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.ISByteDecoder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x20003CA")]
  internal interface ISByteDecoder
  {
    [Token(Token = "0x60013B1")]
    sbyte Read(byte[] bytes, int offset, out int readSize);
  }
}

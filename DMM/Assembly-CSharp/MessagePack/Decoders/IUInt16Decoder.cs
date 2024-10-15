// Decompiled with JetBrains decompiler
// Type: MessagePack.Decoders.IUInt16Decoder
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace MessagePack.Decoders
{
  [Token(Token = "0x2000407")]
  internal interface IUInt16Decoder
  {
    [Token(Token = "0x600145C")]
    ushort Read(byte[] bytes, int offset, out int readSize);
  }
}

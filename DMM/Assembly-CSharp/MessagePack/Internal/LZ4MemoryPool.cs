// Decompiled with JetBrains decompiler
// Type: MessagePack.Internal.LZ4MemoryPool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Internal
{
  [Token(Token = "0x2000474")]
  internal static class LZ4MemoryPool
  {
    [Token(Token = "0x4000F22")]
    [ThreadStatic]
    private static byte[] lz4buffer;

    [Token(Token = "0x6001635")]
    [Address(RVA = "0x6A1050", Offset = "0x69FE50", VA = "0x106A1050")]
    public static byte[] GetBuffer() => (byte[]) null;
  }
}

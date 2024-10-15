// Decompiled with JetBrains decompiler
// Type: MessagePack.Internal.InternalMemoryPool
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Internal
{
  [Token(Token = "0x2000476")]
  internal static class InternalMemoryPool
  {
    [Token(Token = "0x4000F26")]
    [ThreadStatic]
    private static byte[] buffer;

    [Token(Token = "0x6001637")]
    [Address(RVA = "0x69FBD0", Offset = "0x69E9D0", VA = "0x1069FBD0")]
    public static byte[] GetBuffer(long length) => (byte[]) null;

    [Token(Token = "0x6001638")]
    [Address(RVA = "0x69FB80", Offset = "0x69E980", VA = "0x1069FB80")]
    public static void Clear()
    {
    }
  }
}

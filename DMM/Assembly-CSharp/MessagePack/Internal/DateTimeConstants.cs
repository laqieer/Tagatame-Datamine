// Decompiled with JetBrains decompiler
// Type: MessagePack.Internal.DateTimeConstants
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace MessagePack.Internal
{
  [Token(Token = "0x2000475")]
  internal static class DateTimeConstants
  {
    [Token(Token = "0x4000F23")]
    [FieldOffset(Offset = "0x0")]
    internal static readonly DateTime UnixEpoch;
    [Token(Token = "0x4000F24")]
    internal const long BclSecondsAtUnixEpoch = 62135596800;
    [Token(Token = "0x4000F25")]
    internal const int NanosecondsPerTick = 100;

    [Token(Token = "0x6001636")]
    [Address(RVA = "0x6979A0", Offset = "0x6967A0", VA = "0x106979A0")]
    static DateTimeConstants()
    {
    }
  }
}

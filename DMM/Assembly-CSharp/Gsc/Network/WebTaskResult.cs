// Decompiled with JetBrains decompiler
// Type: Gsc.Network.WebTaskResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Gsc.Network
{
  [Token(Token = "0x2003594")]
  [Flags]
  public enum WebTaskResult : uint
  {
    [Token(Token = "0x400FD50")] None = 0,
    [Token(Token = "0x400FD51")] kLocalResult = 65280, // 0x0000FF00
    [Token(Token = "0x400FD52")] Success = 256, // 0x00000100
    [Token(Token = "0x400FD53")] MustErrorHandle = 512, // 0x00000200
    [Token(Token = "0x400FD54")] Broken = 1024, // 0x00000400
    [Token(Token = "0x400FD55")] kGrobalResult = 16711680, // 0x00FF0000
    [Token(Token = "0x400FD56")] ServerError = 65536, // 0x00010000
    [Token(Token = "0x400FD57")] UpdateResource = 131072, // 0x00020000
    [Token(Token = "0x400FD58")] Interrupt = 262144, // 0x00040000
    [Token(Token = "0x400FD59")] kUnableToContinue = 251658240, // 0x0F000000
    [Token(Token = "0x400FD5A")] Maintenance = 16777216, // 0x01000000
    [Token(Token = "0x400FD5B")] UpdateApplication = 33554432, // 0x02000000
    [Token(Token = "0x400FD5C")] ExpiredSessionError = 67108864, // 0x04000000
    [Token(Token = "0x400FD5D")] InvalidDeviceError = 134217728, // 0x08000000
    [Token(Token = "0x400FD5E")] kCreticalError = 4026531840, // 0xF0000000
    [Token(Token = "0x400FD5F")] UnknownError = 268435456, // 0x10000000
    [Token(Token = "0x400FD60")] ParseError = 536870912, // 0x20000000
    [Token(Token = "0x400FD61")] InvalidContentType = 1073741824, // 0x40000000
    [Token(Token = "0x400FD62")] kInternalResult = 240, // 0x000000F0
    [Token(Token = "0x400FD63")] InternalExpiredTokenError = 16, // 0x00000010
    [Token(Token = "0x400FD64")] InternalCheckMaintenance = 32, // 0x00000020
    [Token(Token = "0x400FD65")] kAll = 4294967040, // 0xFFFFFF00
  }
}

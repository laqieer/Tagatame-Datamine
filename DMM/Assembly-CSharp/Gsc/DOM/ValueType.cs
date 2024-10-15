// Decompiled with JetBrains decompiler
// Type: Gsc.DOM.ValueType
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Gsc.DOM
{
  [Token(Token = "0x20035BC")]
  [Flags]
  public enum ValueType : uint
  {
    [Token(Token = "0x400FDBE")] Null = 0,
    [Token(Token = "0x400FDBF")] Object = 1,
    [Token(Token = "0x400FDC0")] Array = 2,
    [Token(Token = "0x400FDC1")] Bool = 4,
    [Token(Token = "0x400FDC2")] String = 8,
    [Token(Token = "0x400FDC3")] Integer = 3840, // 0x00000F00
    [Token(Token = "0x400FDC4")] Int32 = 256, // 0x00000100
    [Token(Token = "0x400FDC5")] UInt32 = 512, // 0x00000200
    [Token(Token = "0x400FDC6")] Int64 = 1024, // 0x00000400
    [Token(Token = "0x400FDC7")] UInt64 = 2048, // 0x00000800
    [Token(Token = "0x400FDC8")] Number = 393216, // 0x00060000
    [Token(Token = "0x400FDC9")] Float = 131072, // 0x00020000
    [Token(Token = "0x400FDCA")] Double = 262144, // 0x00040000
  }
}

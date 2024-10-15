// Decompiled with JetBrains decompiler
// Type: Gsc.Network.WebTaskAttribute
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Gsc.Network
{
  [Token(Token = "0x2003595")]
  [Flags]
  public enum WebTaskAttribute : uint
  {
    [Token(Token = "0x400FD67")] None = 0,
    [Token(Token = "0x400FD68")] Reliable = 1,
    [Token(Token = "0x400FD69")] Interrupt = 2,
    [Token(Token = "0x400FD6A")] Silent = 4,
    [Token(Token = "0x400FD6B")] Parallel = 8,
  }
}

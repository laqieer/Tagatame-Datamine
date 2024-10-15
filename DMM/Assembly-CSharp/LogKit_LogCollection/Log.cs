// Decompiled with JetBrains decompiler
// Type: LogKit_LogCollection.Log
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using LogKit;
using System;

#nullable disable
namespace LogKit_LogCollection
{
  [Token(Token = "0x200351D")]
  public struct Log
  {
    [Token(Token = "0x400FC15")]
    [FieldOffset(Offset = "0x0")]
    public Guid ID;
    [Token(Token = "0x400FC16")]
    [FieldOffset(Offset = "0x10")]
    public string Tag;
    [Token(Token = "0x400FC17")]
    [FieldOffset(Offset = "0x18")]
    public DateTime Date;
    [Token(Token = "0x400FC18")]
    [FieldOffset(Offset = "0x20")]
    public LogKit.LogLevel LogLevel;
    [Token(Token = "0x400FC19")]
    [FieldOffset(Offset = "0x24")]
    public UserInfo UserInfo;
  }
}

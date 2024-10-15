// Decompiled with JetBrains decompiler
// Type: LogKit_ClientLogs.Log
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using LogKit;
using System;

#nullable disable
namespace LogKit_ClientLogs
{
  [Token(Token = "0x2003529")]
  public struct Log
  {
    [Token(Token = "0x400FC44")]
    [FieldOffset(Offset = "0x0")]
    public Guid ID;
    [Token(Token = "0x400FC45")]
    [FieldOffset(Offset = "0x10")]
    public string Tag;
    [Token(Token = "0x400FC46")]
    [FieldOffset(Offset = "0x18")]
    public DateTime Date;
    [Token(Token = "0x400FC47")]
    [FieldOffset(Offset = "0x20")]
    public LogKit.LogLevel LogLevel;
    [Token(Token = "0x400FC48")]
    [FieldOffset(Offset = "0x24")]
    public UserInfo UserInfo;
  }
}

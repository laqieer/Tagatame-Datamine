// Decompiled with JetBrains decompiler
// Type: LogKit.Logger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using UnityEngine;

#nullable disable
namespace LogKit
{
  [Token(Token = "0x2003532")]
  public class Logger
  {
    [Token(Token = "0x400FC71")]
    [FieldOffset(Offset = "0x8")]
    private LogKit_LogCollection.Logger m_LogCollection;
    [Token(Token = "0x400FC72")]
    [FieldOffset(Offset = "0xC")]
    private LogKit_ClientLogs.Logger m_ClientLogs;

    [Token(Token = "0x600EB8E")]
    [Address(RVA = "0xB0BF80", Offset = "0xB0AD80", VA = "0x10B0BF80")]
    public static Logger CreateLogger(string key, Logger.Destination dest = Logger.Destination.NativeBase)
    {
      return (Logger) null;
    }

    [Token(Token = "0x600EB8F")]
    [Address(RVA = "0xB0C1D0", Offset = "0xB0AFD0", VA = "0x10B0C1D0")]
    public static void Init(string appName, string outDir, GameObject node = null)
    {
    }

    [Token(Token = "0x600EB90")]
    [Address(RVA = "0xB0C630", Offset = "0xB0B430", VA = "0x10B0C630")]
    public static void SetLogCollectionServerUrl(string url)
    {
    }

    [Token(Token = "0x600EB91")]
    [Address(RVA = "0xB0C680", Offset = "0xB0B480", VA = "0x10B0C680")]
    public static void SetLogParallelServerUrl(Logger.Destination dest, string url)
    {
    }

    [Token(Token = "0x600EB92")]
    [Address(RVA = "0xB0C6D0", Offset = "0xB0B4D0", VA = "0x10B0C6D0")]
    public static void SetPlatform(string platform)
    {
    }

    [Token(Token = "0x600EB93")]
    [Address(RVA = "0xB0C4E0", Offset = "0xB0B2E0", VA = "0x10B0C4E0")]
    public static void SetDeviceIdGetter(Func<string> deviceIdGetter)
    {
    }

    [Token(Token = "0x600EB94")]
    [Address(RVA = "0xB0C5E0", Offset = "0xB0B3E0", VA = "0x10B0C5E0")]
    public static void SetEnvName(string envName)
    {
    }

    [Token(Token = "0x600EB95")]
    [Address(RVA = "0xB0C8F0", Offset = "0xB0B6F0", VA = "0x10B0C8F0")]
    public Logger(string key, Logger.Destination dest)
    {
    }

    [Token(Token = "0x600EB96")]
    [Address(RVA = "0xB0C300", Offset = "0xB0B100", VA = "0x10B0C300")]
    public void Post(string tag, LogLevel logLevel, string message)
    {
    }

    [Token(Token = "0x2003533")]
    public enum Destination
    {
      [Token(Token = "0x400FC74")] None,
      [Token(Token = "0x400FC75")] ActionLog,
      [Token(Token = "0x400FC76")] NativeBase,
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: LogKit_ClientLogs.Logger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using LogKit;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace LogKit_ClientLogs
{
  [Token(Token = "0x200352A")]
  public class Logger
  {
    [Token(Token = "0x400FC49")]
    public const int LOG_VERSION = 2;
    [Token(Token = "0x400FC4A")]
    public const string OS = "windows";
    [Token(Token = "0x400FC4B")]
    private const int DEFAULT_POOL_SIZE = 5;
    [Token(Token = "0x400FC4C")]
    private const int DEFAULT_BUFFER_SIZE = 10;
    [Token(Token = "0x400FC4D")]
    [FieldOffset(Offset = "0x0")]
    private static bool _initialized;
    [Token(Token = "0x400FC4E")]
    [FieldOffset(Offset = "0x1")]
    private static bool _isSetServerUrl;
    [Token(Token = "0x400FC4F")]
    [FieldOffset(Offset = "0x4")]
    private static Func<string> _deviceIdGetter;
    [Token(Token = "0x400FC51")]
    [FieldOffset(Offset = "0xC")]
    private static Dictionary<LogKit.Logger.Destination, string> m_LogCollectionUrl;
    [Token(Token = "0x400FC56")]
    [FieldOffset(Offset = "0x20")]
    private static readonly List<Logger> loggers;
    [Token(Token = "0x400FC57")]
    [FieldOffset(Offset = "0x8")]
    private readonly BufferPool mBufferPool;
    [Token(Token = "0x400FC58")]
    [FieldOffset(Offset = "0xC")]
    private readonly Writter mWritter;
    [Token(Token = "0x400FC59")]
    [FieldOffset(Offset = "0x10")]
    private readonly Sender mSender;
    [Token(Token = "0x400FC5A")]
    [FieldOffset(Offset = "0x14")]
    private Buffer mBuffer;

    [Token(Token = "0x1700218B")]
    public static bool initialized
    {
      [Token(Token = "0x600EB4A"), Address(RVA = "0xAEBF40", Offset = "0xAEAD40", VA = "0x10AEBF40")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700218C")]
    public static bool IsSetServerUrl
    {
      [Token(Token = "0x600EB4B"), Address(RVA = "0xAEBCC0", Offset = "0xAEAAC0", VA = "0x10AEBCC0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700218D")]
    public static string AppName
    {
      [Token(Token = "0x600EB4C"), Address(RVA = "0xAEBAF0", Offset = "0xAEA8F0", VA = "0x10AEBAF0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600EB4D"), Address(RVA = "0xAEBF90", Offset = "0xAEAD90", VA = "0x10AEBF90")] private set
      {
      }
    }

    [Token(Token = "0x1700218E")]
    public LogKit.Logger.Destination destination
    {
      [Token(Token = "0x600EB4E"), Address(RVA = "0xAEBED0", Offset = "0xAEACD0", VA = "0x10AEBED0")] get
      {
        return new LogKit.Logger.Destination();
      }
    }

    [Token(Token = "0x600EB4F")]
    [Address(RVA = "0xAEAF30", Offset = "0xAE9D30", VA = "0x10AEAF30")]
    public static void SetLogCollectionUrl(LogKit.Logger.Destination dest, string url)
    {
    }

    [Token(Token = "0x600EB50")]
    [Address(RVA = "0xAE97E0", Offset = "0xAE85E0", VA = "0x10AE97E0")]
    public static string GetLogCollectionUrl(LogKit.Logger.Destination dest) => (string) null;

    [Token(Token = "0x1700218F")]
    public static string Platform
    {
      [Token(Token = "0x600EB51"), Address(RVA = "0xAEBDD0", Offset = "0xAEABD0", VA = "0x10AEBDD0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600EB52"), Address(RVA = "0xAEC240", Offset = "0xAEB040", VA = "0x10AEC240")] private set
      {
      }
    }

    [Token(Token = "0x17002190")]
    public static string DeviceID
    {
      [Token(Token = "0x600EB53"), Address(RVA = "0xAEBB30", Offset = "0xAEA930", VA = "0x10AEBB30")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002191")]
    public static string OutDirectory
    {
      [Token(Token = "0x600EB54"), Address(RVA = "0xAEBD50", Offset = "0xAEAB50", VA = "0x10AEBD50")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600EB55"), Address(RVA = "0xAEC180", Offset = "0xAEAF80", VA = "0x10AEC180")] private set
      {
      }
    }

    [Token(Token = "0x17002192")]
    public static string EnvName
    {
      [Token(Token = "0x600EB56"), Address(RVA = "0xAEBC30", Offset = "0xAEAA30", VA = "0x10AEBC30")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600EB57"), Address(RVA = "0xAEC060", Offset = "0xAEAE60", VA = "0x10AEC060")] private set
      {
      }
    }

    [Token(Token = "0x17002193")]
    public static Logger defaultLogger
    {
      [Token(Token = "0x600EB58"), Address(RVA = "0xAEBE50", Offset = "0xAEAC50", VA = "0x10AEBE50")] get
      {
        return (Logger) null;
      }
      [Token(Token = "0x600EB59"), Address(RVA = "0xAEC2A0", Offset = "0xAEB0A0", VA = "0x10AEC2A0")] private set
      {
      }
    }

    [Token(Token = "0x600EB5A")]
    [Address(RVA = "0xAE9C80", Offset = "0xAE8A80", VA = "0x10AE9C80")]
    public static void Init(string appName, string outDir, GameObject node = null)
    {
    }

    [Token(Token = "0x600EB5B")]
    [Address(RVA = "0xAEB070", Offset = "0xAE9E70", VA = "0x10AEB070")]
    public static void SetPlatform(string platform)
    {
    }

    [Token(Token = "0x600EB5C")]
    [Address(RVA = "0xAEB1A0", Offset = "0xAE9FA0", VA = "0x10AEB1A0")]
    public static void SetServerUrl(LogKit.Logger.Destination dest, string url)
    {
    }

    [Token(Token = "0x600EB5D")]
    [Address(RVA = "0xAEADE0", Offset = "0xAE9BE0", VA = "0x10AEADE0")]
    public static void SetDeviceIdGetter(Func<string> deviceIdGetter)
    {
    }

    [Token(Token = "0x600EB5E")]
    [Address(RVA = "0xAEAC40", Offset = "0xAE9A40", VA = "0x10AEAC40")]
    public static void SetDeviceID(string deviceId)
    {
    }

    [Token(Token = "0x600EB5F")]
    [Address(RVA = "0xAEAEA0", Offset = "0xAE9CA0", VA = "0x10AEAEA0")]
    public static void SetEnvName(string envName)
    {
    }

    [Token(Token = "0x17002194")]
    public string Key
    {
      [Token(Token = "0x600EB60"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600EB61"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
      {
      }
    }

    [Token(Token = "0x600EB62")]
    [Address(RVA = "0xAE90F0", Offset = "0xAE7EF0", VA = "0x10AE90F0")]
    public static Logger CreateLogger(string key, LogKit.Logger.Destination dest = LogKit.Logger.Destination.NativeBase)
    {
      return (Logger) null;
    }

    [Token(Token = "0x600EB63")]
    [Address(RVA = "0xAE9230", Offset = "0xAE8030", VA = "0x10AE9230")]
    public static Logger CreateLogger(
      string key,
      int poolSize,
      int bufferSize,
      LogKit.Logger.Destination dest)
    {
      return (Logger) null;
    }

    [Token(Token = "0x600EB64")]
    [Address(RVA = "0xAEB7F0", Offset = "0xAEA5F0", VA = "0x10AEB7F0")]
    private Logger(string key, int poolSize, int bufferSize, LogKit.Logger.Destination dest)
    {
    }

    [Token(Token = "0x600EB65")]
    [Address(RVA = "0xAE96A0", Offset = "0xAE84A0", VA = "0x10AE96A0", Slot = "1")]
    ~Logger()
    {
    }

    [Token(Token = "0x600EB66")]
    [Address(RVA = "0xAEAAD0", Offset = "0xAE98D0", VA = "0x10AEAAD0")]
    public void Post(string tag, LogKit.LogLevel logLevel, string message)
    {
    }

    [Token(Token = "0x600EB67")]
    [Address(RVA = "0xAEAB70", Offset = "0xAE9970", VA = "0x10AEAB70")]
    public void Post(string tag, LogKit.LogLevel logLevel, string key, string value)
    {
    }

    [Token(Token = "0x600EB68")]
    [Address(RVA = "0xAEA3F0", Offset = "0xAE91F0", VA = "0x10AEA3F0")]
    public void Post(string tag, LogKit.LogLevel logLevel, UserInfo userInfo)
    {
    }

    [Token(Token = "0x600EB69")]
    [Address(RVA = "0xAE94F0", Offset = "0xAE82F0", VA = "0x10AE94F0")]
    public void Emit()
    {
    }

    [Token(Token = "0x600EB6A")]
    [Address(RVA = "0xAE97B0", Offset = "0xAE85B0", VA = "0x10AE97B0")]
    public void Flush()
    {
    }

    [Token(Token = "0x600EB6B")]
    [Address(RVA = "0xAEABF0", Offset = "0xAE99F0", VA = "0x10AEABF0")]
    public void Send()
    {
    }

    [Token(Token = "0x600EB6C")]
    [Address(RVA = "0xAE99C0", Offset = "0xAE87C0", VA = "0x10AE99C0")]
    public static string GetLogFilePath(string key, Guid logId) => (string) null;

    [Token(Token = "0x600EB6D")]
    [Address(RVA = "0xAE98B0", Offset = "0xAE86B0", VA = "0x10AE98B0")]
    public static string GetLogFilePath(string key, string logId = null) => (string) null;

    [Token(Token = "0x600EB6E")]
    [Address(RVA = "0xAEB290", Offset = "0xAEA090", VA = "0x10AEB290")]
    static Logger()
    {
    }
  }
}

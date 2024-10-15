// Decompiled with JetBrains decompiler
// Type: LogKit_LogCollection.Logger
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using LogKit;
using System;
using System.Collections.Generic;
using UnityEngine;

#nullable disable
namespace LogKit_LogCollection
{
  [Token(Token = "0x200351E")]
  public class Logger
  {
    [Token(Token = "0x400FC1A")]
    public const int LOG_VERSION = 2;
    [Token(Token = "0x400FC1B")]
    public const string OS = "windows";
    [Token(Token = "0x400FC1C")]
    private const int DEFAULT_POOL_SIZE = 5;
    [Token(Token = "0x400FC1D")]
    private const int DEFAULT_BUFFER_SIZE = 10;
    [Token(Token = "0x400FC1E")]
    [FieldOffset(Offset = "0x0")]
    private static bool _initialized;
    [Token(Token = "0x400FC1F")]
    [FieldOffset(Offset = "0x1")]
    private static bool _isSetServerUrl;
    [Token(Token = "0x400FC20")]
    [FieldOffset(Offset = "0x4")]
    private static Func<string> _deviceIdGetter;
    [Token(Token = "0x400FC26")]
    [FieldOffset(Offset = "0x1C")]
    private static readonly List<Logger> loggers;
    [Token(Token = "0x400FC27")]
    [FieldOffset(Offset = "0x8")]
    private readonly BufferPool mBufferPool;
    [Token(Token = "0x400FC28")]
    [FieldOffset(Offset = "0xC")]
    private readonly Writter mWritter;
    [Token(Token = "0x400FC29")]
    [FieldOffset(Offset = "0x10")]
    private readonly Sender mSender;
    [Token(Token = "0x400FC2A")]
    [FieldOffset(Offset = "0x14")]
    private Buffer mBuffer;

    [Token(Token = "0x1700217B")]
    public static bool initialized
    {
      [Token(Token = "0x600EAFA"), Address(RVA = "0xAEBEF0", Offset = "0xAEACF0", VA = "0x10AEBEF0")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700217C")]
    public static bool IsSetServerUrl
    {
      [Token(Token = "0x600EAFB"), Address(RVA = "0xAEBC70", Offset = "0xAEAA70", VA = "0x10AEBC70")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700217D")]
    public static string AppName
    {
      [Token(Token = "0x600EAFC"), Address(RVA = "0xAEBAB0", Offset = "0xAEA8B0", VA = "0x10AEBAB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600EAFD"), Address(RVA = "0xAEC000", Offset = "0xAEAE00", VA = "0x10AEC000")] private set
      {
      }
    }

    [Token(Token = "0x1700217E")]
    public static string LogCollectionUrl
    {
      [Token(Token = "0x600EAFE"), Address(RVA = "0xAEBD10", Offset = "0xAEAB10", VA = "0x10AEBD10")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600EAFF"), Address(RVA = "0xAEC0C0", Offset = "0xAEAEC0", VA = "0x10AEC0C0")] private set
      {
      }
    }

    [Token(Token = "0x1700217F")]
    public static string Platform
    {
      [Token(Token = "0x600EB00"), Address(RVA = "0xAEBE10", Offset = "0xAEAC10", VA = "0x10AEBE10")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600EB01"), Address(RVA = "0xAEC1E0", Offset = "0xAEAFE0", VA = "0x10AEC1E0")] private set
      {
      }
    }

    [Token(Token = "0x17002180")]
    public static string DeviceID
    {
      [Token(Token = "0x600EB02"), Address(RVA = "0xAEBBB0", Offset = "0xAEA9B0", VA = "0x10AEBBB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17002181")]
    public static string OutDirectory
    {
      [Token(Token = "0x600EB03"), Address(RVA = "0xAEBD90", Offset = "0xAEAB90", VA = "0x10AEBD90")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600EB04"), Address(RVA = "0xAEC120", Offset = "0xAEAF20", VA = "0x10AEC120")] private set
      {
      }
    }

    [Token(Token = "0x17002182")]
    public static Logger defaultLogger
    {
      [Token(Token = "0x600EB05"), Address(RVA = "0xAEBE90", Offset = "0xAEAC90", VA = "0x10AEBE90")] get
      {
        return (Logger) null;
      }
      [Token(Token = "0x600EB06"), Address(RVA = "0xAEC300", Offset = "0xAEB100", VA = "0x10AEC300")] private set
      {
      }
    }

    [Token(Token = "0x600EB07")]
    [Address(RVA = "0xAE9FC0", Offset = "0xAE8DC0", VA = "0x10AE9FC0")]
    public static void Init(string appName, string outDir, GameObject node = null)
    {
    }

    [Token(Token = "0x600EB08")]
    [Address(RVA = "0xAEAFE0", Offset = "0xAE9DE0", VA = "0x10AEAFE0")]
    public static void SetPlatform(string platform)
    {
    }

    [Token(Token = "0x600EB09")]
    [Address(RVA = "0xAEB100", Offset = "0xAE9F00", VA = "0x10AEB100")]
    public static void SetServerUrl(string url)
    {
    }

    [Token(Token = "0x600EB0A")]
    [Address(RVA = "0xAEAE40", Offset = "0xAE9C40", VA = "0x10AEAE40")]
    public static void SetDeviceIdGetter(Func<string> deviceIdGetter)
    {
    }

    [Token(Token = "0x600EB0B")]
    [Address(RVA = "0xAEAD10", Offset = "0xAE9B10", VA = "0x10AEAD10")]
    public static void SetDeviceID(string deviceId)
    {
    }

    [Token(Token = "0x17002183")]
    public string Key
    {
      [Token(Token = "0x600EB0C"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600EB0D"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] private set
      {
      }
    }

    [Token(Token = "0x600EB0E")]
    [Address(RVA = "0xAE8FD0", Offset = "0xAE7DD0", VA = "0x10AE8FD0")]
    public static Logger CreateLogger(string key) => (Logger) null;

    [Token(Token = "0x600EB0F")]
    [Address(RVA = "0xAE9340", Offset = "0xAE8140", VA = "0x10AE9340")]
    public static Logger CreateLogger(string key, int poolSize, int bufferSize) => (Logger) null;

    [Token(Token = "0x600EB10")]
    [Address(RVA = "0xAEB460", Offset = "0xAEA260", VA = "0x10AEB460")]
    private Logger(string key, int poolSize, int bufferSize)
    {
    }

    [Token(Token = "0x600EB11")]
    [Address(RVA = "0xAE95B0", Offset = "0xAE83B0", VA = "0x10AE95B0", Slot = "1")]
    ~Logger()
    {
    }

    [Token(Token = "0x600EB12")]
    [Address(RVA = "0xAEA710", Offset = "0xAE9510", VA = "0x10AEA710")]
    public void Post(string tag, LogKit.LogLevel logLevel, string message)
    {
    }

    [Token(Token = "0x600EB13")]
    [Address(RVA = "0xAEAA50", Offset = "0xAE9850", VA = "0x10AEAA50")]
    public void Post(string tag, LogKit.LogLevel logLevel, string key, string value)
    {
    }

    [Token(Token = "0x600EB14")]
    [Address(RVA = "0xAEA7B0", Offset = "0xAE95B0", VA = "0x10AEA7B0")]
    public void Post(string tag, LogKit.LogLevel logLevel, UserInfo userInfo)
    {
    }

    [Token(Token = "0x600EB15")]
    [Address(RVA = "0xAE9430", Offset = "0xAE8230", VA = "0x10AE9430")]
    public void Emit()
    {
    }

    [Token(Token = "0x600EB16")]
    [Address(RVA = "0xAE9790", Offset = "0xAE8590", VA = "0x10AE9790")]
    public void Flush()
    {
    }

    [Token(Token = "0x600EB17")]
    [Address(RVA = "0xAEAC20", Offset = "0xAE9A20", VA = "0x10AEAC20")]
    public void Send()
    {
    }

    [Token(Token = "0x600EB18")]
    [Address(RVA = "0xAE9B10", Offset = "0xAE8910", VA = "0x10AE9B10")]
    public static string GetLogFilePath(string key, Guid logId) => (string) null;

    [Token(Token = "0x600EB19")]
    [Address(RVA = "0xAE9B70", Offset = "0xAE8970", VA = "0x10AE9B70")]
    public static string GetLogFilePath(string key, string logId = null) => (string) null;

    [Token(Token = "0x600EB1A")]
    [Address(RVA = "0xAEB3A0", Offset = "0xAEA1A0", VA = "0x10AEB3A0")]
    static Logger()
    {
    }
  }
}

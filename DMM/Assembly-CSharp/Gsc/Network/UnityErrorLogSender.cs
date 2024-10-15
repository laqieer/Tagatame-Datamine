// Decompiled with JetBrains decompiler
// Type: Gsc.Network.UnityErrorLogSender
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;

#nullable disable
namespace Gsc.Network
{
  [Token(Token = "0x2003565")]
  public class UnityErrorLogSender : IEnumerator
  {
    [Token(Token = "0x400FCE7")]
    private const int BUFFER_SIZE = 5;
    [Token(Token = "0x400FCE8")]
    private const float TRANS_INTERVAL = 5f;
    [Token(Token = "0x400FCE9")]
    [FieldOffset(Offset = "0x0")]
    private static UnityErrorLogSender _instance;
    [Token(Token = "0x400FCEA")]
    [FieldOffset(Offset = "0x4")]
    private static readonly Regex regex;
    [Token(Token = "0x400FCEC")]
    [FieldOffset(Offset = "0xC")]
    private LinkedList<UnityErrorLogSender.ErrorData> buffer;
    [Token(Token = "0x400FCED")]
    [FieldOffset(Offset = "0x10")]
    private object current;
    [Token(Token = "0x400FCEE")]
    [FieldOffset(Offset = "0x14")]
    private bool isRunning;

    [Token(Token = "0x170021E0")]
    public static UnityErrorLogSender Instance
    {
      [Token(Token = "0x600ECB5"), Address(RVA = "0xB168B0", Offset = "0xB156B0", VA = "0x10B168B0")] get
      {
        return (UnityErrorLogSender) null;
      }
    }

    [Token(Token = "0x600ECB6")]
    [Address(RVA = "0xB167C0", Offset = "0xB155C0", VA = "0x10B167C0")]
    static UnityErrorLogSender()
    {
    }

    [Token(Token = "0x600ECB7")]
    [Address(RVA = "0xB15D90", Offset = "0xB14B90", VA = "0x10B15D90")]
    public static void Initialize()
    {
    }

    [Token(Token = "0x170021E1")]
    public Action<CustomHeaders, Dictionary<string, object>, Dictionary<string, object>, Dictionary<string, object>> Callback
    {
      [Token(Token = "0x600ECB8"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (Action<CustomHeaders, Dictionary<string, object>, Dictionary<string, object>, Dictionary<string, object>>) null;
      }
      [Token(Token = "0x600ECB9"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] set
      {
      }
    }

    [Token(Token = "0x600ECBA")]
    [Address(RVA = "0xB160C0", Offset = "0xB14EC0", VA = "0x10B160C0")]
    public void Send(string message, string stacktrace, LogType logType)
    {
    }

    [Token(Token = "0x170021E2")]
    public object Current
    {
      [Token(Token = "0x600ECBB"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0", Slot = "5")] get
      {
        return (object) null;
      }
    }

    [Token(Token = "0x600ECBC")]
    [Address(RVA = "0xB15FA0", Offset = "0xB14DA0", VA = "0x10B15FA0", Slot = "4")]
    public bool MoveNext() => new bool();

    [Token(Token = "0x600ECBD")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "6")]
    public void Reset()
    {
    }

    [Token(Token = "0x600ECBE")]
    [Address(RVA = "0xB161E0", Offset = "0xB14FE0", VA = "0x10B161E0")]
    private static void TryGetException(
      string message,
      IEnumerator stacktrace,
      List<object> exceptions)
    {
    }

    [Token(Token = "0x600ECBF")]
    [Address(RVA = "0xB159D0", Offset = "0xB147D0", VA = "0x10B159D0")]
    private static List<object> GetStackframes(IEnumerator stacktrace, List<object> exceptions)
    {
      return (List<object>) null;
    }

    [Token(Token = "0x600ECC0")]
    [Address(RVA = "0xB163D0", Offset = "0xB151D0", VA = "0x10B163D0")]
    private static Dictionary<string, object> TryParseError(
      UnityErrorLogSender.ErrorData data,
      Dictionary<string, object> user,
      Dictionary<string, object> tags,
      Dictionary<string, object> extra)
    {
      return (Dictionary<string, object>) null;
    }

    [Token(Token = "0x600ECC1")]
    [Address(RVA = "0xB157C0", Offset = "0xB145C0", VA = "0x10B157C0")]
    private static Dictionary<string, object> GetSendData(
      UnityErrorLogSender.ErrorData data,
      Dictionary<string, object> user,
      Dictionary<string, object> tags,
      Dictionary<string, object> extra)
    {
      return (Dictionary<string, object>) null;
    }

    [Token(Token = "0x600ECC2")]
    [Address(RVA = "0xB155B0", Offset = "0xB143B0", VA = "0x10B155B0")]
    private static Dictionary<string, object> CreateUserData() => (Dictionary<string, object>) null;

    [Token(Token = "0x600ECC3")]
    [Address(RVA = "0xB152B0", Offset = "0xB140B0", VA = "0x10B152B0")]
    private static Dictionary<string, object> CreateExtraData()
    {
      return (Dictionary<string, object>) null;
    }

    [Token(Token = "0x600ECC4")]
    [Address(RVA = "0xB15DF0", Offset = "0xB14BF0", VA = "0x10B15DF0")]
    private void InternalSend(UnityErrorLogSender.ErrorData data)
    {
    }

    [Token(Token = "0x600ECC5")]
    [Address(RVA = "0xB16840", Offset = "0xB15640", VA = "0x10B16840")]
    public UnityErrorLogSender()
    {
    }

    [Token(Token = "0x2003566")]
    private struct ErrorData
    {
      [Token(Token = "0x400FCEF")]
      [FieldOffset(Offset = "0x0")]
      public string message;
      [Token(Token = "0x400FCF0")]
      [FieldOffset(Offset = "0x4")]
      public string stacktrace;
      [Token(Token = "0x400FCF1")]
      [FieldOffset(Offset = "0x8")]
      public LogType logType;
    }

    [Token(Token = "0x2003567")]
    private class Request : Gsc.Network.Request<UnityErrorLogSender.Request, UnityErrorLogSender.Response>
    {
      [Token(Token = "0x400FCF2")]
      [FieldOffset(Offset = "0x1C")]
      private readonly Dictionary<string, object> data;

      [Token(Token = "0x600ECC6")]
      [Address(RVA = "0xB0F130", Offset = "0xB0DF30", VA = "0x10B0F130")]
      public Request(Dictionary<string, object> data)
      {
      }

      [Token(Token = "0x600ECC7")]
      [Address(RVA = "0xB0F0B0", Offset = "0xB0DEB0", VA = "0x10B0F0B0", Slot = "30")]
      public override string GetPath() => (string) null;

      [Token(Token = "0x600ECC8")]
      [Address(RVA = "0xB0F080", Offset = "0xB0DE80", VA = "0x10B0F080", Slot = "31")]
      public override string GetMethod() => (string) null;

      [Token(Token = "0x600ECC9")]
      [Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0", Slot = "32")]
      protected override Dictionary<string, object> GetParameters()
      {
        return (Dictionary<string, object>) null;
      }
    }

    [Token(Token = "0x2003568")]
    private class Response : Gsc.Network.Response<UnityErrorLogSender.Response>
    {
      [Token(Token = "0x600ECCA")]
      [Address(RVA = "0xB0F180", Offset = "0xB0DF80", VA = "0x10B0F180")]
      public Response(WebInternalResponse response)
      {
      }
    }
  }
}

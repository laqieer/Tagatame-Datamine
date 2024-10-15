// Decompiled with JetBrains decompiler
// Type: Gsc.App.NetworkHelper.GsccBridge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Il2CppDummyDll;
using SRPG;
using System;
using UnityEngine.Networking;

#nullable disable
namespace Gsc.App.NetworkHelper
{
  [Token(Token = "0x2003549")]
  public static class GsccBridge
  {
    [Token(Token = "0x400FCC6")]
    [FieldOffset(Offset = "0x0")]
    private static WebTaskBundle unhandledTasks;

    [Token(Token = "0x600EC31")]
    [Address(RVA = "0xB0A270", Offset = "0xB09070", VA = "0x10B0A270")]
    public static void Send(WebAPI api, bool silent)
    {
    }

    [Token(Token = "0x600EC32")]
    [Address(RVA = "0xB09ED0", Offset = "0xB08CD0", VA = "0x10B09ED0")]
    public static void SendImmediate(WebAPI api)
    {
    }

    [Token(Token = "0x600EC33")]
    [Address(RVA = "0xB09990", Offset = "0xB08790", VA = "0x10B09990")]
    private static byte[] EncodePayload(WebAPI api) => (byte[]) null;

    [Token(Token = "0x600EC34")]
    [Address(RVA = "0xB0A940", Offset = "0xB09740", VA = "0x10B0A940")]
    private static void SetCustomHeaders(CustomHeaders headers)
    {
    }

    [Token(Token = "0x600EC35")]
    [Address(RVA = "0xB0A500", Offset = "0xB09300", VA = "0x10B0A500")]
    public static void SetBaseCustomHeaders(
      UnityWebRequest webReq,
      Action<string, string> setter,
      string requestId)
    {
    }

    [Token(Token = "0x600EC36")]
    [Address(RVA = "0xB0AA50", Offset = "0xB09850", VA = "0x10B0AA50")]
    public static void SetWebViewHeaders(Action<string, string> setter)
    {
    }

    [Token(Token = "0x600EC37")]
    [Address(RVA = "0xB0A1B0", Offset = "0xB08FB0", VA = "0x10B0A1B0")]
    private static void Send(
      WebTask<WebRequest, WebResponse> task,
      SRPG.Network.ResponseCallback callback)
    {
    }

    [Token(Token = "0x170021CC")]
    public static bool HasUnhandledTasks
    {
      [Token(Token = "0x600EC38"), Address(RVA = "0xB0AC10", Offset = "0xB09A10", VA = "0x10B0AC10")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x600EC39")]
    [Address(RVA = "0xB09B30", Offset = "0xB08930", VA = "0x10B09B30")]
    public static void OnReceiveUnhandledTasks(WebTaskBundle taskBundle)
    {
    }

    [Token(Token = "0x600EC3A")]
    [Address(RVA = "0xB09D80", Offset = "0xB08B80", VA = "0x10B09D80")]
    public static void Retry()
    {
    }

    [Token(Token = "0x600EC3B")]
    [Address(RVA = "0xB09D40", Offset = "0xB08B40", VA = "0x10B09D40")]
    public static void Reset()
    {
    }
  }
}

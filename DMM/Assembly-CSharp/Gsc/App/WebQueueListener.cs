// Decompiled with JetBrains decompiler
// Type: Gsc.App.WebQueueListener
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Network;
using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace Gsc.App
{
  [Token(Token = "0x2003548")]
  public class WebQueueListener : IWebQueueObserver
  {
    [Token(Token = "0x170021CB")]
    public static byte[] ErrorPayload
    {
      [Token(Token = "0x600EC29"), Address(RVA = "0xB19C40", Offset = "0xB18A40", VA = "0x10B19C40")] get
      {
        return (byte[]) null;
      }
      [Token(Token = "0x600EC2A"), Address(RVA = "0xB19C70", Offset = "0xB18A70", VA = "0x10B19C70")] set
      {
      }
    }

    [Token(Token = "0x600EC2B")]
    [Address(RVA = "0xB19C00", Offset = "0xB18A00", VA = "0x10B19C00", Slot = "4")]
    public void OnStart()
    {
    }

    [Token(Token = "0x600EC2C")]
    [Address(RVA = "0xB19680", Offset = "0xB18480", VA = "0x10B19680", Slot = "5")]
    public void OnFinish()
    {
    }

    [Token(Token = "0x600EC2D")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0", Slot = "7")]
    public void Reset()
    {
    }

    [Token(Token = "0x600EC2E")]
    [Address(RVA = "0xB196C0", Offset = "0xB184C0", VA = "0x10B196C0", Slot = "6")]
    public void OnReceiveUnhandledTasks(WebTaskBundle taskBundle)
    {
    }

    [Token(Token = "0x600EC2F")]
    [Address(RVA = "0x2781C0", Offset = "0x276FC0", VA = "0x102781C0")]
    public static void UnityErrorLogCallback(
      CustomHeaders customHeaders,
      Dictionary<string, object> user,
      Dictionary<string, object> tags,
      Dictionary<string, object> extra)
    {
    }

    [Token(Token = "0x600EC30")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public WebQueueListener()
    {
    }
  }
}

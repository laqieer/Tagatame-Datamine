// Decompiled with JetBrains decompiler
// Type: Slack.SlackAPI
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections;

#nullable disable
namespace Slack
{
  [Token(Token = "0x2000B4C")]
  public static class SlackAPI
  {
    [Token(Token = "0x6002B3C")]
    [Address(RVA = "0xFCD9F0", Offset = "0xFCC7F0", VA = "0x10FCD9F0")]
    public static IEnumerator PostMessage(
      PostMessageData data,
      Action onSuccess = null,
      Action<string> onError = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6002B3D")]
    [Address(RVA = "0xFCDAF0", Offset = "0xFCC8F0", VA = "0x10FCDAF0")]
    public static IEnumerator UploadScreenShot(
      UploadData data,
      byte[] contents = null,
      Action<string> onSuccess = null,
      Action<string> onError = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6002B3E")]
    [Address(RVA = "0xFCDA70", Offset = "0xFCC870", VA = "0x10FCDA70")]
    public static IEnumerator UploadScreenRecording(
      UploadData data,
      Action onSuccess = null,
      Action<string> onError = null)
    {
      return (IEnumerator) null;
    }

    [Token(Token = "0x6002B3F")]
    [Address(RVA = "0xFCD8F0", Offset = "0xFCC6F0", VA = "0x10FCD8F0")]
    public static string GetMessageID(string _text) => (string) null;
  }
}

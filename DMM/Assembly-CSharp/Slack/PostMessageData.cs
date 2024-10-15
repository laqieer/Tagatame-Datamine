// Decompiled with JetBrains decompiler
// Type: Slack.PostMessageData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Slack
{
  [Token(Token = "0x2000B4A")]
  [Serializable]
  public class PostMessageData
  {
    [Token(Token = "0x4001B33")]
    [FieldOffset(Offset = "0x8")]
    public string token;
    [Token(Token = "0x4001B34")]
    [FieldOffset(Offset = "0xC")]
    public string channel;
    [Token(Token = "0x4001B35")]
    [FieldOffset(Offset = "0x10")]
    public string text;
    [Token(Token = "0x4001B36")]
    [FieldOffset(Offset = "0x14")]
    public string parse;
    [Token(Token = "0x4001B37")]
    [FieldOffset(Offset = "0x18")]
    public string link_names;
    [Token(Token = "0x4001B38")]
    [FieldOffset(Offset = "0x1C")]
    public string username;
    [Token(Token = "0x4001B39")]
    [FieldOffset(Offset = "0x20")]
    public string icon_url;
    [Token(Token = "0x4001B3A")]
    [FieldOffset(Offset = "0x24")]
    public string icon_emoji;
    [Token(Token = "0x4001B3B")]
    [FieldOffset(Offset = "0x28")]
    public string message;
    [Token(Token = "0x4001B3C")]
    [FieldOffset(Offset = "0x2C")]
    public string filename;

    [Token(Token = "0x6002B38")]
    [Address(RVA = "0xFCB480", Offset = "0xFCA280", VA = "0x10FCB480")]
    public void CreateText(LogMonitor.ErrorInfo info, SlackOption option = null)
    {
    }

    [Token(Token = "0x6002B39")]
    [Address(RVA = "0xFCB9B0", Offset = "0xFCA7B0", VA = "0x10FCB9B0")]
    public PostMessageData()
    {
    }
  }
}

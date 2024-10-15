// Decompiled with JetBrains decompiler
// Type: Slack.UploadData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;

#nullable disable
namespace Slack
{
  [Token(Token = "0x2000B4B")]
  [Serializable]
  public class UploadData
  {
    [Token(Token = "0x4001B3D")]
    [FieldOffset(Offset = "0x8")]
    public string token;
    [Token(Token = "0x4001B3E")]
    [FieldOffset(Offset = "0xC")]
    public string filename;
    [Token(Token = "0x4001B3F")]
    [FieldOffset(Offset = "0x10")]
    public string title;
    [Token(Token = "0x4001B40")]
    [FieldOffset(Offset = "0x14")]
    public string initial_comment;
    [Token(Token = "0x4001B41")]
    [FieldOffset(Offset = "0x18")]
    public string channels;

    [Token(Token = "0x6002B3A")]
    [Address(RVA = "0xFD70A0", Offset = "0xFD5EA0", VA = "0x10FD70A0")]
    public void CreateText(LogMonitor.ErrorInfo info, SlackOption option = null)
    {
    }

    [Token(Token = "0x6002B3B")]
    [Address(RVA = "0xFD75D0", Offset = "0xFD63D0", VA = "0x10FD75D0")]
    public UploadData()
    {
    }
  }
}

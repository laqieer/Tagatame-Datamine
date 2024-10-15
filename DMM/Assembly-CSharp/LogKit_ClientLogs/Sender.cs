// Decompiled with JetBrains decompiler
// Type: LogKit_ClientLogs.Sender
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Collections.Generic;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

#nullable disable
namespace LogKit_ClientLogs
{
  [Token(Token = "0x200352E")]
  public class Sender
  {
    [Token(Token = "0x400FC64")]
    [FieldOffset(Offset = "0x8")]
    private readonly LinkedList<Guid> queue;
    [Token(Token = "0x400FC65")]
    [FieldOffset(Offset = "0xC")]
    private readonly string key;
    [Token(Token = "0x400FC66")]
    [FieldOffset(Offset = "0x10")]
    private readonly LogKit.Logger.Destination mDestination;

    [Token(Token = "0x17002197")]
    public LogKit.Logger.Destination destination
    {
      [Token(Token = "0x600EB7E"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new LogKit.Logger.Destination();
      }
    }

    [Token(Token = "0x600EB7F")]
    [Address(RVA = "0xB10D40", Offset = "0xB0FB40", VA = "0x10B10D40")]
    public Sender(string key, LogKit.Logger.Destination dest)
    {
    }

    [Token(Token = "0x600EB80")]
    [Address(RVA = "0xB10920", Offset = "0xB0F720", VA = "0x10B10920")]
    private void Init()
    {
    }

    [Token(Token = "0x600EB81")]
    [Address(RVA = "0xB10810", Offset = "0xB0F610", VA = "0x10B10810")]
    private static void FileDeleteThread(object data)
    {
    }

    [Token(Token = "0x600EB82")]
    [Address(RVA = "0xB10C30", Offset = "0xB0FA30", VA = "0x10B10C30")]
    public void Push(Guid logId)
    {
    }

    [Token(Token = "0x600EB83")]
    [Address(RVA = "0xB10AA0", Offset = "0xB0F8A0", VA = "0x10B10AA0")]
    private void Pop(Guid logId)
    {
    }

    [Token(Token = "0x600EB84")]
    [Address(RVA = "0x280EA0", Offset = "0x27FCA0", VA = "0x10280EA0")]
    public static bool Validator(
      object sender,
      X509Certificate certificate,
      X509Chain chain,
      SslPolicyErrors policyErrors)
    {
      return new bool();
    }

    [Token(Token = "0x600EB85")]
    [Address(RVA = "0xB102A0", Offset = "0xB0F0A0", VA = "0x10B102A0")]
    public void Emit()
    {
    }

    [Token(Token = "0x600EB86")]
    [Address(RVA = "0xB0FFD0", Offset = "0xB0EDD0", VA = "0x10B0FFD0")]
    private void ClearQueue()
    {
    }
  }
}

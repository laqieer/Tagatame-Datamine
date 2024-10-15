// Decompiled with JetBrains decompiler
// Type: Gsc.Network.RequestException
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System;
using System.Runtime.Serialization;

#nullable disable
namespace Gsc.Network
{
  [Token(Token = "0x2003563")]
  [Serializable]
  public class RequestException : Exception
  {
    [Token(Token = "0x600ECAE")]
    [Address(RVA = "0xB0EF90", Offset = "0xB0DD90", VA = "0x10B0EF90")]
    public RequestException()
    {
    }

    [Token(Token = "0x600ECAF")]
    [Address(RVA = "0xB0EFE0", Offset = "0xB0DDE0", VA = "0x10B0EFE0")]
    public RequestException(string message)
    {
    }

    [Token(Token = "0x600ECB0")]
    [Address(RVA = "0xB0EF40", Offset = "0xB0DD40", VA = "0x10B0EF40")]
    public RequestException(string message, Exception inner)
    {
    }

    [Token(Token = "0x600ECB1")]
    [Address(RVA = "0xB0F030", Offset = "0xB0DE30", VA = "0x10B0F030")]
    protected RequestException(SerializationInfo info, StreamingContext context)
    {
    }
  }
}

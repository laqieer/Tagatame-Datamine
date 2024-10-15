// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.AdjustEventFailure
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x20036D9")]
  public class AdjustEventFailure
  {
    [Token(Token = "0x170023C3")]
    public string Adid
    {
      [Token(Token = "0x600F8EA"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F8EB"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] set
      {
      }
    }

    [Token(Token = "0x170023C4")]
    public string Message
    {
      [Token(Token = "0x600F8EC"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F8ED"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] set
      {
      }
    }

    [Token(Token = "0x170023C5")]
    public string Timestamp
    {
      [Token(Token = "0x600F8EE"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F8EF"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] set
      {
      }
    }

    [Token(Token = "0x170023C6")]
    public string EventToken
    {
      [Token(Token = "0x600F8F0"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F8F1"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] set
      {
      }
    }

    [Token(Token = "0x170023C7")]
    public string CallbackId
    {
      [Token(Token = "0x600F8F2"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F8F3"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] set
      {
      }
    }

    [Token(Token = "0x170023C8")]
    public bool WillRetry
    {
      [Token(Token = "0x600F8F4"), Address(RVA = "0x2A5AA0", Offset = "0x2A48A0", VA = "0x102A5AA0")] get
      {
        return new bool();
      }
      [Token(Token = "0x600F8F5"), Address(RVA = "0x2A5AE0", Offset = "0x2A48E0", VA = "0x102A5AE0")] set
      {
      }
    }

    [Token(Token = "0x170023C9")]
    public Dictionary<string, object> JsonResponse
    {
      [Token(Token = "0x600F8F6"), Address(RVA = "0x2880C0", Offset = "0x286EC0", VA = "0x102880C0")] get
      {
        return (Dictionary<string, object>) null;
      }
      [Token(Token = "0x600F8F7"), Address(RVA = "0x288700", Offset = "0x287500", VA = "0x10288700")] set
      {
      }
    }

    [Token(Token = "0x600F8F8")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AdjustEventFailure()
    {
    }

    [Token(Token = "0x600F8F9")]
    [Address(RVA = "0xB66990", Offset = "0xB65790", VA = "0x10B66990")]
    public AdjustEventFailure(Dictionary<string, string> eventFailureDataMap)
    {
    }

    [Token(Token = "0x600F8FA")]
    [Address(RVA = "0xB66EE0", Offset = "0xB65CE0", VA = "0x10B66EE0")]
    public AdjustEventFailure(string jsonString)
    {
    }

    [Token(Token = "0x600F8FB")]
    [Address(RVA = "0xB66830", Offset = "0xB65630", VA = "0x10B66830")]
    public void BuildJsonResponseFromString(string jsonResponseString)
    {
    }

    [Token(Token = "0x600F8FC")]
    [Address(RVA = "0xB66940", Offset = "0xB65740", VA = "0x10B66940")]
    public string GetJsonResponse() => (string) null;
  }
}

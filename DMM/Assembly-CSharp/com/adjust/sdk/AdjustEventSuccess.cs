// Decompiled with JetBrains decompiler
// Type: com.adjust.sdk.AdjustEventSuccess
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Collections.Generic;

#nullable disable
namespace com.adjust.sdk
{
  [Token(Token = "0x20036DA")]
  public class AdjustEventSuccess
  {
    [Token(Token = "0x170023CA")]
    public string Adid
    {
      [Token(Token = "0x600F8FD"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F8FE"), Address(RVA = "0x301150", Offset = "0x2FFF50", VA = "0x10301150")] set
      {
      }
    }

    [Token(Token = "0x170023CB")]
    public string Message
    {
      [Token(Token = "0x600F8FF"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F900"), Address(RVA = "0x301130", Offset = "0x2FFF30", VA = "0x10301130")] set
      {
      }
    }

    [Token(Token = "0x170023CC")]
    public string Timestamp
    {
      [Token(Token = "0x600F901"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F902"), Address(RVA = "0x2ECBC0", Offset = "0x2EB9C0", VA = "0x102ECBC0")] set
      {
      }
    }

    [Token(Token = "0x170023CD")]
    public string EventToken
    {
      [Token(Token = "0x600F903"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F904"), Address(RVA = "0x34D340", Offset = "0x34C140", VA = "0x1034D340")] set
      {
      }
    }

    [Token(Token = "0x170023CE")]
    public string CallbackId
    {
      [Token(Token = "0x600F905"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
      [Token(Token = "0x600F906"), Address(RVA = "0x2A5AB0", Offset = "0x2A48B0", VA = "0x102A5AB0")] set
      {
      }
    }

    [Token(Token = "0x170023CF")]
    public Dictionary<string, object> JsonResponse
    {
      [Token(Token = "0x600F907"), Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0")] get
      {
        return (Dictionary<string, object>) null;
      }
      [Token(Token = "0x600F908"), Address(RVA = "0x283780", Offset = "0x282580", VA = "0x10283780")] set
      {
      }
    }

    [Token(Token = "0x600F909")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public AdjustEventSuccess()
    {
    }

    [Token(Token = "0x600F90A")]
    [Address(RVA = "0xB67340", Offset = "0xB66140", VA = "0x10B67340")]
    public AdjustEventSuccess(Dictionary<string, string> eventSuccessDataMap)
    {
    }

    [Token(Token = "0x600F90B")]
    [Address(RVA = "0xB677D0", Offset = "0xB665D0", VA = "0x10B677D0")]
    public AdjustEventSuccess(string jsonString)
    {
    }

    [Token(Token = "0x600F90C")]
    [Address(RVA = "0xB671E0", Offset = "0xB65FE0", VA = "0x10B671E0")]
    public void BuildJsonResponseFromString(string jsonResponseString)
    {
    }

    [Token(Token = "0x600F90D")]
    [Address(RVA = "0xB672F0", Offset = "0xB660F0", VA = "0x10B672F0")]
    public string GetJsonResponse() => (string) null;
  }
}

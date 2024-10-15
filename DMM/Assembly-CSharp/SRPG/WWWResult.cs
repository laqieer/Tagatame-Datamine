// Decompiled with JetBrains decompiler
// Type: SRPG.WWWResult
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using UnityEngine.Networking;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002E33")]
  public struct WWWResult
  {
    [Token(Token = "0x400E840")]
    [FieldOffset(Offset = "0x0")]
    private UnityWebRequest mResult;
    [Token(Token = "0x400E841")]
    [FieldOffset(Offset = "0x4")]
    private string mResultValue;
    [Token(Token = "0x400E842")]
    [FieldOffset(Offset = "0x8")]
    public byte[] rawResult;

    [Token(Token = "0x600DA74")]
    [Address(RVA = "0xA7F0C0", Offset = "0xA7DEC0", VA = "0x10A7F0C0")]
    public WWWResult(UnityWebRequest www)
    {
    }

    [Token(Token = "0x600DA75")]
    [Address(RVA = "0xA7F080", Offset = "0xA7DE80", VA = "0x10A7F080")]
    public WWWResult(string result)
    {
    }

    [Token(Token = "0x600DA76")]
    [Address(RVA = "0xA7F040", Offset = "0xA7DE40", VA = "0x10A7F040")]
    public WWWResult(byte[] rawResult)
    {
    }

    [Token(Token = "0x17001D03")]
    public string text
    {
      [Token(Token = "0x600DA77"), Address(RVA = "0xA7F100", Offset = "0xA7DF00", VA = "0x10A7F100")] get
      {
        return (string) null;
      }
    }
  }
}

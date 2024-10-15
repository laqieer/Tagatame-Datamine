// Decompiled with JetBrains decompiler
// Type: SRPG.ReqMail
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x200308A")]
  public class ReqMail : WebAPI
  {
    [Token(Token = "0x600DD04")]
    [Address(RVA = "0xA88300", Offset = "0xA87100", VA = "0x10A88300")]
    public ReqMail(int page, bool isPeriod, bool isRead, Network.ResponseCallback response)
    {
    }

    [Token(Token = "0x600DD05")]
    [Address(RVA = "0xA88240", Offset = "0xA87040", VA = "0x10A88240")]
    private string MakeKeyValue(string key, int value) => (string) null;

    [Token(Token = "0x600DD06")]
    [Address(RVA = "0xA881E0", Offset = "0xA86FE0", VA = "0x10A881E0")]
    private string MakeKeyValue(string key, float value) => (string) null;

    [Token(Token = "0x600DD07")]
    [Address(RVA = "0xA882A0", Offset = "0xA870A0", VA = "0x10A882A0")]
    private string MakeKeyValue(string key, long value) => (string) null;

    [Token(Token = "0x600DD08")]
    [Address(RVA = "0xA881A0", Offset = "0xA86FA0", VA = "0x10A881A0")]
    private string MakeKeyValue(string key, string value) => (string) null;
  }
}

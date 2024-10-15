// Decompiled with JetBrains decompiler
// Type: Gsc.App.NetworkHelper.WebRequest
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Gsc.App.NetworkHelper
{
  [Token(Token = "0x200354B")]
  public class WebRequest : ApiRequest<WebRequest, WebResponse>
  {
    [Token(Token = "0x400FCC8")]
    [FieldOffset(Offset = "0x1C")]
    private readonly string method;
    [Token(Token = "0x400FCC9")]
    [FieldOffset(Offset = "0x20")]
    private readonly string path;
    [Token(Token = "0x400FCCA")]
    [FieldOffset(Offset = "0x24")]
    private readonly byte[] payload;

    [Token(Token = "0x600EC3E")]
    [Address(RVA = "0xB1B390", Offset = "0xB1A190", VA = "0x10B1B390")]
    public WebRequest(string method, string path, byte[] unencryptedPayload, byte[] payload)
    {
    }

    [Token(Token = "0x600EC3F")]
    [Address(RVA = "0x2700B0", Offset = "0x26EEB0", VA = "0x102700B0", Slot = "31")]
    public override string GetMethod() => (string) null;

    [Token(Token = "0x600EC40")]
    [Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830", Slot = "34")]
    public override byte[] GetPayload() => (byte[]) null;

    [Token(Token = "0x600EC41")]
    [Address(RVA = "0xB1B350", Offset = "0xB1A150", VA = "0x10B1B350", Slot = "30")]
    public override string GetPath() => (string) null;
  }
}

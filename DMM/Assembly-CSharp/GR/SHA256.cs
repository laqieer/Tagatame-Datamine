// Decompiled with JetBrains decompiler
// Type: GR.SHA256
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Text;

#nullable disable
namespace GR
{
  [Token(Token = "0x2000333")]
  public sealed class SHA256
  {
    [Token(Token = "0x4000D07")]
    [FieldOffset(Offset = "0x8")]
    private System.Security.Cryptography.SHA256 mSHA256;

    [Token(Token = "0x600112C")]
    [Address(RVA = "0x12A3B80", Offset = "0x12A2980", VA = "0x112A3B80", Slot = "1")]
    ~SHA256()
    {
    }

    [Token(Token = "0x600112D")]
    [Address(RVA = "0x12A5710", Offset = "0x12A4510", VA = "0x112A5710")]
    public void Create()
    {
    }

    [Token(Token = "0x600112E")]
    [Address(RVA = "0x12A3B20", Offset = "0x12A2920", VA = "0x112A3B20")]
    public void Clear()
    {
    }

    [Token(Token = "0x600112F")]
    [Address(RVA = "0x12A5520", Offset = "0x12A4320", VA = "0x112A5520")]
    public string Calc(string str, Encoding encode) => (string) null;

    [Token(Token = "0x6001130")]
    [Address(RVA = "0x12A5630", Offset = "0x12A4430", VA = "0x112A5630")]
    public string Calc(byte[] src) => (string) null;

    [Token(Token = "0x6001131")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public SHA256()
    {
    }
  }
}

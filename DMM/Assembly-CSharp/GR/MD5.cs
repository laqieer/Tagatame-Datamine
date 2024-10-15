// Decompiled with JetBrains decompiler
// Type: GR.MD5
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using System.Text;

#nullable disable
namespace GR
{
  [Token(Token = "0x2000332")]
  public sealed class MD5
  {
    [Token(Token = "0x4000D06")]
    [FieldOffset(Offset = "0x8")]
    private System.Security.Cryptography.MD5 mMD5;

    [Token(Token = "0x6001126")]
    [Address(RVA = "0x12A3B80", Offset = "0x12A2980", VA = "0x112A3B80", Slot = "1")]
    ~MD5()
    {
    }

    [Token(Token = "0x6001127")]
    [Address(RVA = "0x12A3B50", Offset = "0x12A2950", VA = "0x112A3B50")]
    public void Create()
    {
    }

    [Token(Token = "0x6001128")]
    [Address(RVA = "0x12A3B20", Offset = "0x12A2920", VA = "0x112A3B20")]
    public void Clear()
    {
    }

    [Token(Token = "0x6001129")]
    [Address(RVA = "0x12A3A30", Offset = "0x12A2830", VA = "0x112A3A30")]
    public string Calc(string str, Encoding encode) => (string) null;

    [Token(Token = "0x600112A")]
    [Address(RVA = "0x12A3960", Offset = "0x12A2760", VA = "0x112A3960")]
    public string Calc(byte[] src) => (string) null;

    [Token(Token = "0x600112B")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public MD5()
    {
    }
  }
}

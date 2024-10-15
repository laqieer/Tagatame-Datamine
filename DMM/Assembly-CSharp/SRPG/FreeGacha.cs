// Decompiled with JetBrains decompiler
// Type: SRPG.FreeGacha
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001046")]
  public class FreeGacha
  {
    [Token(Token = "0x4003A16")]
    [FieldOffset(Offset = "0x8")]
    public int num;
    [Token(Token = "0x4003A17")]
    [FieldOffset(Offset = "0x10")]
    public long at;

    [Token(Token = "0x60042CE")]
    [Address(RVA = "0x11DCB60", Offset = "0x11DB960", VA = "0x111DCB60")]
    public bool Deserialize(Json_FreeGacha json) => new bool();

    [Token(Token = "0x60042CF")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public FreeGacha()
    {
    }
  }
}

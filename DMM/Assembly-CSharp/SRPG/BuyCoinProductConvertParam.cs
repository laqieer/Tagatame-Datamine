// Decompiled with JetBrains decompiler
// Type: SRPG.BuyCoinProductConvertParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001A34")]
  public class BuyCoinProductConvertParam
  {
    [Token(Token = "0x400606B")]
    [FieldOffset(Offset = "0x8")]
    private string mName;
    [Token(Token = "0x400606C")]
    [FieldOffset(Offset = "0xC")]
    private string mConvert;

    [Token(Token = "0x17000B9F")]
    public string Name
    {
      [Token(Token = "0x6006BB8"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17000BA0")]
    public string Convert
    {
      [Token(Token = "0x6006BB9"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6006BBA")]
    [Address(RVA = "0x34E540", Offset = "0x34D340", VA = "0x1034E540")]
    public bool Deserialize(JSON_BuyCoinProductConvertParam json) => new bool();

    [Token(Token = "0x6006BBB")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public BuyCoinProductConvertParam()
    {
    }
  }
}

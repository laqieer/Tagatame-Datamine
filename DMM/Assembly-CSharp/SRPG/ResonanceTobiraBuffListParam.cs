// Decompiled with JetBrains decompiler
// Type: SRPG.ResonanceTobiraBuffListParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001CC6")]
  [MessagePackObject(true)]
  public class ResonanceTobiraBuffListParam
  {
    [Token(Token = "0x40070D8")]
    [FieldOffset(Offset = "0x8")]
    private ParamTypes mType;
    [Token(Token = "0x40070D9")]
    [FieldOffset(Offset = "0xC")]
    private int mValue;
    [Token(Token = "0x40070DA")]
    [FieldOffset(Offset = "0x10")]
    private string mTag;

    [Token(Token = "0x17000F63")]
    public ParamTypes Type
    {
      [Token(Token = "0x600765E"), Address(RVA = "0x357AF0", Offset = "0x3568F0", VA = "0x10357AF0")] get
      {
        return new ParamTypes();
      }
    }

    [Token(Token = "0x17000F64")]
    public int Value
    {
      [Token(Token = "0x600765F"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000F65")]
    public string Tag
    {
      [Token(Token = "0x6007660"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6007661")]
    [Address(RVA = "0x397F90", Offset = "0x396D90", VA = "0x10397F90")]
    public bool Deserialize(JSON_ResonanceTobiraBuffParam json) => new bool();

    [Token(Token = "0x6007662")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public ResonanceTobiraBuffListParam()
    {
    }
  }
}

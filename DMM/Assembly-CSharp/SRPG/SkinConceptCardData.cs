// Decompiled with JetBrains decompiler
// Type: SRPG.SkinConceptCardData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E97")]
  public class SkinConceptCardData
  {
    [Token(Token = "0x4002CD4")]
    [FieldOffset(Offset = "0x8")]
    public string iname;
    [Token(Token = "0x4002CD5")]
    [FieldOffset(Offset = "0xC")]
    public ConceptCardParam param;

    [Token(Token = "0x6003CC3")]
    [Address(RVA = "0x11050B0", Offset = "0x1103EB0", VA = "0x111050B0")]
    public bool Deserialize(string _iname) => new bool();

    [Token(Token = "0x6003CC4")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public SkinConceptCardData()
    {
    }
  }
}

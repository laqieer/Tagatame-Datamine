// Decompiled with JetBrains decompiler
// Type: SRPG.ConceptCardMaterialData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2000E92")]
  public class ConceptCardMaterialData
  {
    [Token(Token = "0x4002CC9")]
    [FieldOffset(Offset = "0x8")]
    private OLong mUniqueID;
    [Token(Token = "0x4002CCA")]
    [FieldOffset(Offset = "0x30")]
    private OString mIName;
    [Token(Token = "0x4002CCB")]
    [FieldOffset(Offset = "0x34")]
    private OInt mNum;
    [Token(Token = "0x4002CCC")]
    [FieldOffset(Offset = "0x48")]
    private ConceptCardParam mParam;

    [Token(Token = "0x170004B5")]
    public OLong UniqueID
    {
      [Token(Token = "0x6003CAE"), Address(RVA = "0x305BB0", Offset = "0x3049B0", VA = "0x10305BB0")] get
      {
        return new OLong();
      }
    }

    [Token(Token = "0x170004B6")]
    public OString IName
    {
      [Token(Token = "0x6003CAF"), Address(RVA = "0x29C8D0", Offset = "0x29B6D0", VA = "0x1029C8D0")] get
      {
        return new OString();
      }
    }

    [Token(Token = "0x170004B7")]
    public OInt Num
    {
      [Token(Token = "0x6003CB0"), Address(RVA = "0x90BB40", Offset = "0x90A940", VA = "0x1090BB40")] get
      {
        return new OInt();
      }
      [Token(Token = "0x6003CB1"), Address(RVA = "0x10F16D0", Offset = "0x10F04D0", VA = "0x110F16D0")] set
      {
      }
    }

    [Token(Token = "0x170004B8")]
    public ConceptCardParam Param
    {
      [Token(Token = "0x6003CB2"), Address(RVA = "0x288000", Offset = "0x286E00", VA = "0x10288000")] get
      {
        return (ConceptCardParam) null;
      }
    }

    [Token(Token = "0x6003CB3")]
    [Address(RVA = "0x10F15B0", Offset = "0x10F03B0", VA = "0x110F15B0")]
    public bool Deserialize(JSON_ConceptCardMaterial json) => new bool();

    [Token(Token = "0x6003CB4")]
    [Address(RVA = "0x10F1690", Offset = "0x10F0490", VA = "0x110F1690")]
    public ConceptCardMaterialData()
    {
    }
  }
}

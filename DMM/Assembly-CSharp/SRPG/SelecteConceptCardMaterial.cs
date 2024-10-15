// Decompiled with JetBrains decompiler
// Type: SRPG.SelecteConceptCardMaterial
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2002239")]
  public class SelecteConceptCardMaterial
  {
    [Token(Token = "0x40097AD")]
    [FieldOffset(Offset = "0x8")]
    public OLong mUniqueID;
    [Token(Token = "0x40097AE")]
    [FieldOffset(Offset = "0x30")]
    public ConceptCardData mSelectedData;
    [Token(Token = "0x40097AF")]
    [FieldOffset(Offset = "0x34")]
    public int mSelectNum;

    [Token(Token = "0x17001481")]
    public string iname
    {
      [Token(Token = "0x60091B4"), Address(RVA = "0x560BB0", Offset = "0x55F9B0", VA = "0x10560BB0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x60091B5")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public SelecteConceptCardMaterial()
    {
    }
  }
}

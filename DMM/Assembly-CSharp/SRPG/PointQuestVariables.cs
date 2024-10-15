// Decompiled with JetBrains decompiler
// Type: SRPG.PointQuestVariables
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C0E")]
  public class PointQuestVariables
  {
    [Token(Token = "0x4006CB4")]
    [FieldOffset(Offset = "0x8")]
    private PointQuestPointType mId;
    [Token(Token = "0x4006CB5")]
    [FieldOffset(Offset = "0xC")]
    private int mConstant;
    [Token(Token = "0x4006CB6")]
    [FieldOffset(Offset = "0x10")]
    private int mCoefficient;
    [Token(Token = "0x4006CB7")]
    [FieldOffset(Offset = "0x14")]
    private int mMin;
    [Token(Token = "0x4006CB8")]
    [FieldOffset(Offset = "0x18")]
    private int mMax;
    [Token(Token = "0x4006CB9")]
    [FieldOffset(Offset = "0x1C")]
    private int mElems;

    [Token(Token = "0x17000E6F")]
    public PointQuestPointType Id
    {
      [Token(Token = "0x600738F"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return new PointQuestPointType();
      }
    }

    [Token(Token = "0x17000E70")]
    public int Constant
    {
      [Token(Token = "0x6007390"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E71")]
    public int Coefficient
    {
      [Token(Token = "0x6007391"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E72")]
    public int Min
    {
      [Token(Token = "0x6007392"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17000E73")]
    public int Max
    {
      [Token(Token = "0x6007393"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x6007394")]
    [Address(RVA = "0x37F860", Offset = "0x37E660", VA = "0x1037F860")]
    public void Deserialize(JSON_PointQuestVariables json)
    {
    }

    [Token(Token = "0x6007395")]
    [Address(RVA = "0x37F900", Offset = "0x37E700", VA = "0x1037F900")]
    private void SetElemFlag(int tgt, bool sw)
    {
    }

    [Token(Token = "0x6007396")]
    [Address(RVA = "0x37F8E0", Offset = "0x37E6E0", VA = "0x1037F8E0")]
    public bool IsElemFlag(int tgt) => new bool();

    [Token(Token = "0x6007397")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public PointQuestVariables()
    {
    }
  }
}

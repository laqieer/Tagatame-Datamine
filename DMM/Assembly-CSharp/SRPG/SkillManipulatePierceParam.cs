// Decompiled with JetBrains decompiler
// Type: SRPG.SkillManipulatePierceParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E46")]
  [MessagePackObject(true)]
  public class SkillManipulatePierceParam
  {
    [Token(Token = "0x4007B42")]
    [FieldOffset(Offset = "0x8")]
    public string mIname;
    [Token(Token = "0x4007B43")]
    [FieldOffset(Offset = "0xC")]
    public ManipulateTypes mManipulate;
    [Token(Token = "0x4007B44")]
    [FieldOffset(Offset = "0xD")]
    public DamageTypes mDamageType;
    [Token(Token = "0x4007B45")]
    [FieldOffset(Offset = "0xE")]
    public bool mIsPierce;
    [Token(Token = "0x4007B46")]
    [FieldOffset(Offset = "0xF")]
    public bool mIsBreak;
    [Token(Token = "0x4007B47")]
    [FieldOffset(Offset = "0x10")]
    public int mIsElems;
    [Token(Token = "0x4007B48")]
    [FieldOffset(Offset = "0x14")]
    public string mEffect;

    [Token(Token = "0x1700113C")]
    public string Iname
    {
      [Token(Token = "0x6007C32"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x1700113D")]
    public ManipulateTypes Manipulate
    {
      [Token(Token = "0x6007C33"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new ManipulateTypes();
      }
    }

    [Token(Token = "0x1700113E")]
    public DamageTypes DamageType
    {
      [Token(Token = "0x6007C34"), Address(RVA = "0x3DA450", Offset = "0x3D9250", VA = "0x103DA450")] get
      {
        return new DamageTypes();
      }
    }

    [Token(Token = "0x1700113F")]
    public bool IsPierce
    {
      [Token(Token = "0x6007C35"), Address(RVA = "0x3E7F60", Offset = "0x3E6D60", VA = "0x103E7F60")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001140")]
    public bool IsBreak
    {
      [Token(Token = "0x6007C36"), Address(RVA = "0x3E7F50", Offset = "0x3E6D50", VA = "0x103E7F50")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x17001141")]
    public string Effect
    {
      [Token(Token = "0x6007C37"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6007C38")]
    [Address(RVA = "0x3E7B10", Offset = "0x3E6910", VA = "0x103E7B10")]
    public void Deserialize(JSON_SkillManipulatePierceParam json)
    {
    }

    [Token(Token = "0x6007C39")]
    [Address(RVA = "0x3E7BC0", Offset = "0x3E69C0", VA = "0x103E7BC0")]
    public static void Deserialize(
      ref ParamDictionary<string, SkillManipulatePierceParam> ref_params,
      JSON_SkillManipulatePierceParam[] jsons)
    {
    }

    [Token(Token = "0x6007C3A")]
    [Address(RVA = "0x3E7F20", Offset = "0x3E6D20", VA = "0x103E7F20")]
    private void SetElemFlag(int tgt, bool sw)
    {
    }

    [Token(Token = "0x6007C3B")]
    [Address(RVA = "0x3E7EB0", Offset = "0x3E6CB0", VA = "0x103E7EB0")]
    public bool IsElemFlag(int tgt) => new bool();

    [Token(Token = "0x6007C3C")]
    [Address(RVA = "0x3E7D80", Offset = "0x3E6B80", VA = "0x103E7D80")]
    public static SkillManipulatePierceParam GetSkillManipulatePierceParam(string iname)
    {
      return (SkillManipulatePierceParam) null;
    }

    [Token(Token = "0x6007C3D")]
    [Address(RVA = "0x3E7E80", Offset = "0x3E6C80", VA = "0x103E7E80")]
    public bool IsDamageType(ManipulateTypes type, DamageTypes damageType) => new bool();

    [Token(Token = "0x6007C3E")]
    [Address(RVA = "0x3E7ED0", Offset = "0x3E6CD0", VA = "0x103E7ED0")]
    public bool IsElem(ManipulateTypes type, int elem) => new bool();

    [Token(Token = "0x6007C3F")]
    [Address(RVA = "0x3E7F00", Offset = "0x3E6D00", VA = "0x103E7F00")]
    private bool IsManipulateType(ManipulateTypes type) => new bool();

    [Token(Token = "0x6007C40")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public SkillManipulatePierceParam()
    {
    }
  }
}

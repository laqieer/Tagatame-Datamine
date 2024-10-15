// Decompiled with JetBrains decompiler
// Type: SRPG.SkillManipulateParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E44")]
  [MessagePackObject(true)]
  public class SkillManipulateParam
  {
    [Token(Token = "0x4007B31")]
    [FieldOffset(Offset = "0x8")]
    public string mIname;
    [Token(Token = "0x4007B32")]
    [FieldOffset(Offset = "0xC")]
    public ManipulateTypes mManipulate;
    [Token(Token = "0x4007B33")]
    [FieldOffset(Offset = "0xD")]
    public ProtectTypes mType;
    [Token(Token = "0x4007B34")]
    [FieldOffset(Offset = "0x10")]
    public SkillRankUpValue mValue;
    [Token(Token = "0x4007B35")]
    [FieldOffset(Offset = "0x14")]
    public int mRatio;
    [Token(Token = "0x4007B36")]
    [FieldOffset(Offset = "0x18")]
    public DamageTypes mDamageType;
    [Token(Token = "0x4007B37")]
    [FieldOffset(Offset = "0x1C")]
    public int mIsElems;
    [Token(Token = "0x4007B38")]
    [FieldOffset(Offset = "0x20")]
    public bool mIsEternal;
    [Token(Token = "0x4007B39")]
    [FieldOffset(Offset = "0x24")]
    public string mEffect;
    [Token(Token = "0x4007B3A")]
    public const int ETERNAL_TURN = 99;

    [Token(Token = "0x17001134")]
    public string Iname
    {
      [Token(Token = "0x6007C20"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001135")]
    public ManipulateTypes Manipulate
    {
      [Token(Token = "0x6007C21"), Address(RVA = "0x360B80", Offset = "0x35F980", VA = "0x10360B80")] get
      {
        return new ManipulateTypes();
      }
    }

    [Token(Token = "0x17001136")]
    public ProtectTypes Type
    {
      [Token(Token = "0x6007C22"), Address(RVA = "0x3DA450", Offset = "0x3D9250", VA = "0x103DA450")] get
      {
        return new ProtectTypes();
      }
    }

    [Token(Token = "0x17001137")]
    public SkillRankUpValue Value
    {
      [Token(Token = "0x6007C23"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return (SkillRankUpValue) null;
      }
    }

    [Token(Token = "0x17001138")]
    public int Ratio
    {
      [Token(Token = "0x6007C24"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001139")]
    public DamageTypes DamageType
    {
      [Token(Token = "0x6007C25"), Address(RVA = "0x3057E0", Offset = "0x3045E0", VA = "0x103057E0")] get
      {
        return new DamageTypes();
      }
    }

    [Token(Token = "0x1700113A")]
    public bool IsEternal
    {
      [Token(Token = "0x6007C26"), Address(RVA = "0x305F30", Offset = "0x304D30", VA = "0x10305F30")] get
      {
        return new bool();
      }
    }

    [Token(Token = "0x1700113B")]
    public string Effect
    {
      [Token(Token = "0x6007C27"), Address(RVA = "0x29E830", Offset = "0x29D630", VA = "0x1029E830")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6007C28")]
    [Address(RVA = "0x3E77F0", Offset = "0x3E65F0", VA = "0x103E77F0")]
    public void Deserialize(JSON_SkillManipulateParam json)
    {
    }

    [Token(Token = "0x6007C29")]
    [Address(RVA = "0x3E7550", Offset = "0x3E6350", VA = "0x103E7550")]
    public static void Deserialize(
      ref ParamDictionary<string, SkillManipulateParam> ref_params,
      JSON_SkillManipulateParam[] jsons)
    {
    }

    [Token(Token = "0x6007C2A")]
    [Address(RVA = "0x37F900", Offset = "0x37E700", VA = "0x1037F900")]
    private void SetElemFlag(int tgt, bool sw)
    {
    }

    [Token(Token = "0x6007C2B")]
    [Address(RVA = "0x37F8E0", Offset = "0x37E6E0", VA = "0x1037F8E0")]
    public bool IsElemFlag(int tgt) => new bool();

    [Token(Token = "0x6007C2C")]
    [Address(RVA = "0x3E7920", Offset = "0x3E6720", VA = "0x103E7920")]
    public static SkillManipulateParam GetSkillManipulateParam(string iname)
    {
      return (SkillManipulateParam) null;
    }

    [Token(Token = "0x6007C2D")]
    [Address(RVA = "0x3E7A70", Offset = "0x3E6870", VA = "0x103E7A70")]
    public static bool IsSkillManipulateType(string iname, DamageTypes damageType) => new bool();

    [Token(Token = "0x6007C2E")]
    [Address(RVA = "0x3E7A20", Offset = "0x3E6820", VA = "0x103E7A20")]
    public static bool IsSkillManipulateElem(string iname, int elem) => new bool();

    [Token(Token = "0x6007C2F")]
    [Address(RVA = "0x3E7A50", Offset = "0x3E6850", VA = "0x103E7A50")]
    private bool IsSkillManipulateEternal(int value) => new bool();

    [Token(Token = "0x6007C30")]
    [Address(RVA = "0x3E7AA0", Offset = "0x3E68A0", VA = "0x103E7AA0")]
    public SkillManipulateParam()
    {
    }
  }
}

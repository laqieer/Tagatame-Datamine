// Decompiled with JetBrains decompiler
// Type: SRPG.TobiraLearnAbilityParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001D67")]
  [MessagePackObject(true)]
  public class TobiraLearnAbilityParam
  {
    [Token(Token = "0x40073CA")]
    [FieldOffset(Offset = "0x8")]
    private string mAbilityIname;
    [Token(Token = "0x40073CB")]
    [FieldOffset(Offset = "0xC")]
    private int mLevel;
    [Token(Token = "0x40073CC")]
    [FieldOffset(Offset = "0x10")]
    private TobiraLearnAbilityParam.AddType mAddType;
    [Token(Token = "0x40073CD")]
    [FieldOffset(Offset = "0x14")]
    private string mTargeJob;
    [Token(Token = "0x40073CE")]
    [FieldOffset(Offset = "0x18")]
    private string mAbilityOverwrite;

    [Token(Token = "0x1700100F")]
    public string AbilityIname
    {
      [Token(Token = "0x600785F"), Address(RVA = "0x28D5B0", Offset = "0x28C3B0", VA = "0x1028D5B0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001010")]
    public int Level
    {
      [Token(Token = "0x6007860"), Address(RVA = "0x28D5A0", Offset = "0x28C3A0", VA = "0x1028D5A0")] get
      {
        return new int();
      }
    }

    [Token(Token = "0x17001011")]
    public TobiraLearnAbilityParam.AddType AbilityAddType
    {
      [Token(Token = "0x6007861"), Address(RVA = "0x29EEB0", Offset = "0x29DCB0", VA = "0x1029EEB0")] get
      {
        return new TobiraLearnAbilityParam.AddType();
      }
    }

    [Token(Token = "0x17001012")]
    public string TargetJob
    {
      [Token(Token = "0x6007862"), Address(RVA = "0x2BAA70", Offset = "0x2B9870", VA = "0x102BAA70")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001013")]
    public string AbilityOverwrite
    {
      [Token(Token = "0x6007863"), Address(RVA = "0x26E190", Offset = "0x26CF90", VA = "0x1026E190")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6007864")]
    [Address(RVA = "0x3A4410", Offset = "0x3A3210", VA = "0x103A4410")]
    public void Deserialize(JSON_TobiraLearnAbilityParam json)
    {
    }

    [Token(Token = "0x6007865")]
    [Address(RVA = "0x276BC0", Offset = "0x2759C0", VA = "0x10276BC0")]
    public TobiraLearnAbilityParam()
    {
    }

    [Token(Token = "0x2001D68")]
    public enum AddType
    {
      [Token(Token = "0x40073D0")] Unknow,
      [Token(Token = "0x40073D1")] JobOverwrite,
      [Token(Token = "0x40073D2")] MasterAdd,
      [Token(Token = "0x40073D3")] MasterOverwrite,
    }
  }
}

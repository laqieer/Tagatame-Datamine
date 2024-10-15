// Decompiled with JetBrains decompiler
// Type: SRPG.SkillDeriveParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E21")]
  [MessagePackObject(true)]
  public class SkillDeriveParam : BaseDeriveParam<SkillParam>
  {
    [Token(Token = "0x17001100")]
    public string BaseSkillIname
    {
      [Token(Token = "0x6007BA4"), Address(RVA = "0x3DA4C0", Offset = "0x3D92C0", VA = "0x103DA4C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001101")]
    public string DeriveSkillIname
    {
      [Token(Token = "0x6007BA5"), Address(RVA = "0x3DA4E0", Offset = "0x3D92E0", VA = "0x103DA4E0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001102")]
    public string BaseSkillName
    {
      [Token(Token = "0x6007BA6"), Address(RVA = "0x2DC030", Offset = "0x2DAE30", VA = "0x102DC030")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001103")]
    public string DeriveSkillName
    {
      [Token(Token = "0x6007BA7"), Address(RVA = "0x3DA500", Offset = "0x3D9300", VA = "0x103DA500")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6007BA8")]
    [Address(RVA = "0x3E6640", Offset = "0x3E5440", VA = "0x103E6640")]
    public SkillDeriveParam()
    {
    }
  }
}

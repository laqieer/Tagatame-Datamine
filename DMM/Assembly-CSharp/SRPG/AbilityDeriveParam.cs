// Decompiled with JetBrains decompiler
// Type: SRPG.AbilityDeriveParam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;
using MessagePack;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E22")]
  [MessagePackObject(true)]
  public class AbilityDeriveParam : BaseDeriveParam<AbilityParam>
  {
    [Token(Token = "0x17001104")]
    public string BaseAbilityIname
    {
      [Token(Token = "0x6007BA9"), Address(RVA = "0x3DA4C0", Offset = "0x3D92C0", VA = "0x103DA4C0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001105")]
    public string DeriveAbilityIname
    {
      [Token(Token = "0x6007BAA"), Address(RVA = "0x3DA4E0", Offset = "0x3D92E0", VA = "0x103DA4E0")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001106")]
    public string BaseAbilityName
    {
      [Token(Token = "0x6007BAB"), Address(RVA = "0x2DC030", Offset = "0x2DAE30", VA = "0x102DC030")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x17001107")]
    public string DeriveAbilityName
    {
      [Token(Token = "0x6007BAC"), Address(RVA = "0x3DA500", Offset = "0x3D9300", VA = "0x103DA500")] get
      {
        return (string) null;
      }
    }

    [Token(Token = "0x6007BAD")]
    [Address(RVA = "0x3DA480", Offset = "0x3D9280", VA = "0x103DA480")]
    public AbilityDeriveParam()
    {
    }
  }
}

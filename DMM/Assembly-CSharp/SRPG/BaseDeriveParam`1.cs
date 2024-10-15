// Decompiled with JetBrains decompiler
// Type: SRPG.BaseDeriveParam`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001E20")]
  public class BaseDeriveParam<T>
  {
    [Token(Token = "0x4007AB2")]
    [FieldOffset(Offset = "0x0")]
    public SkillAbilityDeriveParam m_SkillAbilityDeriveParam;
    [Token(Token = "0x4007AB3")]
    [FieldOffset(Offset = "0x0")]
    public T m_BaseParam;
    [Token(Token = "0x4007AB4")]
    [FieldOffset(Offset = "0x0")]
    public T m_DeriveParam;

    [Token(Token = "0x170010FF")]
    public int MasterIndex
    {
      [Token(Token = "0x6007BA2")] get => new int();
    }

    [Token(Token = "0x6007BA3")]
    public BaseDeriveParam()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: SRPG.GvGMasterParam`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B6F")]
  public abstract class GvGMasterParam<T> where T : JSON_GvGMasterParam
  {
    [Token(Token = "0x6007145")]
    public abstract bool Deserialize(T json);

    [Token(Token = "0x6007146")]
    protected GvGMasterParam()
    {
    }
  }
}

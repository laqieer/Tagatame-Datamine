// Decompiled with JetBrains decompiler
// Type: SRPG.RaidMasterParam`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001C7D")]
  public abstract class RaidMasterParam<T> where T : JSON_RaidMasterParam
  {
    [Token(Token = "0x600757E")]
    public abstract bool Deserialize(T json);

    [Token(Token = "0x600757F")]
    protected RaidMasterParam()
    {
    }
  }
}

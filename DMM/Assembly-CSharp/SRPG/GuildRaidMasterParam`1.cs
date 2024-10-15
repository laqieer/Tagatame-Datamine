// Decompiled with JetBrains decompiler
// Type: SRPG.GuildRaidMasterParam`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace SRPG
{
  [Token(Token = "0x2001B4A")]
  public abstract class GuildRaidMasterParam<T> where T : JSON_GuildRaidMasterParam
  {
    [Token(Token = "0x6007086")]
    public abstract bool Deserialize(T json);

    [Token(Token = "0x6007087")]
    protected GuildRaidMasterParam()
    {
    }
  }
}

// Decompiled with JetBrains decompiler
// Type: Gsc.Network.Data.IEntity
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Gsc.Network.Data
{
  [Token(Token = "0x20035B6")]
  public interface IEntity : IObject
  {
    [Token(Token = "0x1700220F")]
    string pk { [Token(Token = "0x600EE8D")] get; }

    [Token(Token = "0x600EE8E")]
    void Update();

    [Token(Token = "0x600EE8F")]
    void ResolveRefs();

    [Token(Token = "0x600EE90")]
    IEntity Clone();
  }
}

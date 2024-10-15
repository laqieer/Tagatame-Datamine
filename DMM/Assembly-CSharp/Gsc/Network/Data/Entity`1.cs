// Decompiled with JetBrains decompiler
// Type: Gsc.Network.Data.Entity`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Il2CppDummyDll;

#nullable disable
namespace Gsc.Network.Data
{
  [Token(Token = "0x20035AE")]
  public abstract class Entity<T> : IEntity, IObject where T : Entity<T>
  {
    [Token(Token = "0x400FDAA")]
    [FieldOffset(Offset = "0x0")]
    private uint ver;

    [Token(Token = "0x17002208")]
    public string pk
    {
      [Token(Token = "0x600EE55")] get => (string) null;
      [Token(Token = "0x600EE56")] protected set
      {
      }
    }

    [Token(Token = "0x600EE57")]
    public abstract void Update();

    [Token(Token = "0x600EE58")]
    public abstract void ResolveRefs();

    [Token(Token = "0x600EE59")]
    public T Clone() => (T) null;

    [Token(Token = "0x600EE5A")]
    private IEntity Gsc\u002ENetwork\u002EData\u002EIEntity\u002EClone() => (IEntity) null;

    [Token(Token = "0x600EE5B")]
    protected bool IsUpdatedOnce() => new bool();

    [Token(Token = "0x600EE5C")]
    protected Entity()
    {
    }
  }
}

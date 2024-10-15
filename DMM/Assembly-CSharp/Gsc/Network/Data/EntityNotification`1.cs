// Decompiled with JetBrains decompiler
// Type: Gsc.Network.Data.EntityNotification`1
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Components;
using Il2CppDummyDll;

#nullable disable
namespace Gsc.Network.Data
{
  [Token(Token = "0x20035B0")]
  public class EntityNotification<T> : INotification where T : Gsc.Network.Data.Entity<T>
  {
    [Token(Token = "0x400FDAE")]
    [FieldOffset(Offset = "0x0")]
    public readonly T Entity;
    [Token(Token = "0x400FDAF")]
    [FieldOffset(Offset = "0x0")]
    public readonly EntityNotificationType NotificationType;

    [Token(Token = "0x600EE5D")]
    public EntityNotification(T entity, EntityNotificationType type)
    {
    }
  }
}

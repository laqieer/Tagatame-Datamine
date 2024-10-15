// Decompiled with JetBrains decompiler
// Type: Gsc.Network.Data.EntityRepository
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: DAD16919-792A-4B52-A355-9FC67E79AC85
// Assembly location: C:\r\Tagatame-Datamine\DMM\Il2CppDumper\DummyDll\Assembly-CSharp.dll

using Gsc.Components;
using Il2CppDummyDll;
using System;
using System.Collections.Generic;

#nullable disable
namespace Gsc.Network.Data
{
  [Token(Token = "0x20035B1")]
  public class EntityRepository
  {
    [Token(Token = "0x400FDB0")]
    [FieldOffset(Offset = "0x0")]
    private static readonly EntityRepository repository;
    [Token(Token = "0x400FDB2")]
    [FieldOffset(Offset = "0x8")]
    private readonly Dictionary<Type, EntityRepository.ISimpleRepository> entityRepositories;

    [Token(Token = "0x600EE5E")]
    public static T Get<T>(string key) where T : Entity<T> => (T) null;

    [Token(Token = "0x600EE5F")]
    public static EntityList<T> GetAll<T>() where T : Entity<T> => (EntityList<T>) null;

    [Token(Token = "0x600EE60")]
    public static void Subscribe<T>(
      NotificationObserver<EntityNotification<T>> observer,
      T sender = null)
      where T : Entity<T>
    {
    }

    [Token(Token = "0x600EE61")]
    [Address(RVA = "0xB07900", Offset = "0xB06700", VA = "0x10B07900")]
    public static void AllClear()
    {
    }

    [Token(Token = "0x600EE62")]
    [Address(RVA = "0xB07B10", Offset = "0xB06910", VA = "0x10B07B10")]
    public static void CacheClear()
    {
    }

    [Token(Token = "0x600EE63")]
    [Address(RVA = "0xB08AB0", Offset = "0xB078B0", VA = "0x10B08AB0")]
    private EntityRepository()
    {
    }

    [Token(Token = "0x17002209")]
    public static uint ver
    {
      [Token(Token = "0x600EE64"), Address(RVA = "0xB08B20", Offset = "0xB07920", VA = "0x10B08B20")] get
      {
        return new uint();
      }
      [Token(Token = "0x600EE65"), Address(RVA = "0xB08B60", Offset = "0xB07960", VA = "0x10B08B60")] private set
      {
      }
    }

    [Token(Token = "0x600EE66")]
    private EntityRepository.SimpleRepository<T> GetRepository<T>() where T : Entity<T>
    {
      return (EntityRepository.SimpleRepository<T>) null;
    }

    [Token(Token = "0x600EE67")]
    [Address(RVA = "0xB07D20", Offset = "0xB06B20", VA = "0x10B07D20")]
    private EntityRepository.ISimpleRepository GetRepository(Type type)
    {
      return (EntityRepository.ISimpleRepository) null;
    }

    [Token(Token = "0x600EE68")]
    [Address(RVA = "0xB07E00", Offset = "0xB06C00", VA = "0x10B07E00")]
    public static void Update(Gsc.DOM.IObject root)
    {
    }

    [Token(Token = "0x600EE69")]
    [Address(RVA = "0xB089F0", Offset = "0xB077F0", VA = "0x10B089F0")]
    static EntityRepository()
    {
    }

    [Token(Token = "0x20035B2")]
    private interface ISimpleRepository
    {
      [Token(Token = "0x600EE6A")]
      void Push(IEntity value, bool isPermanent);

      [Token(Token = "0x600EE6B")]
      void Remove(string key);

      [Token(Token = "0x600EE6C")]
      void AllClear();

      [Token(Token = "0x600EE6D")]
      void CacheClear();
    }

    [Token(Token = "0x20035B3")]
    private class SimpleRepository<T> : EntityRepository.ISimpleRepository where T : Entity<T>
    {
      [Token(Token = "0x400FDB3")]
      [FieldOffset(Offset = "0x0")]
      public readonly EntityList<T> PublicList;
      [Token(Token = "0x400FDB4")]
      [FieldOffset(Offset = "0x0")]
      private readonly SortedList<string, T> entityList;
      [Token(Token = "0x400FDB5")]
      [FieldOffset(Offset = "0x0")]
      private readonly SortedList<string, T> permanentEntitityList;
      [Token(Token = "0x400FDB6")]
      [FieldOffset(Offset = "0x0")]
      private SortedList<string, object> senderList;

      [Token(Token = "0x600EE6E")]
      public SimpleRepository()
      {
      }

      [Token(Token = "0x600EE6F")]
      public void Push(T value, bool isPermanent)
      {
      }

      [Token(Token = "0x600EE70")]
      private void Gsc\u002ENetwork\u002EData\u002EEntityRepository\u002EISimpleRepository\u002EPush(
        IEntity value,
        bool isPermanent)
      {
      }

      [Token(Token = "0x600EE71")]
      public void Remove(string key)
      {
      }

      [Token(Token = "0x600EE72")]
      public object GetSender(string key) => (object) null;

      [Token(Token = "0x600EE73")]
      public void AllClear()
      {
      }

      [Token(Token = "0x600EE74")]
      public void CacheClear()
      {
      }
    }
  }
}
